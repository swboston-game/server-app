﻿using System;
using System.Collections.Generic;
using System.Linq;
using WhoIzIt.Model;

namespace WhiIzIt.BLL
{

    public class GameService
    {
        private readonly WhoIzItDbContext _context = new WhoIzItDbContext();
        private readonly NotificationService _notificationService = new NotificationService();

        public void Invite(int challengerId, int opponentId)
        {
            var invite = new Invite
                             {
                                 Challenger = { Id = challengerId },
                                 Opponent = { Id = opponentId },
                                 Status = InviteStatus.Waiting
                             };
            _context.Invites.Add(invite);
            _context.SaveChanges();
        }

        public Game AcceptInvite(int challengerId, int opponentId)
        {
            var invite =
                _context.Invites.Single(
                    i =>
                    i.Challenger.Id == challengerId && i.Opponent.Id == opponentId && i.Status == InviteStatus.Waiting);
            invite.Status = InviteStatus.Accepted;
            _context.SaveChanges();
            _notificationService.InviteAccepted(challengerId);
            var game = CreateGame(invite.Challenger, invite.Opponent);
            return game;
        }

        public void DeclineInvite(int challengerId, int opponentId)
        {
            var invite =
                _context.Invites.Single(
                    i =>
                    i.Challenger.Id == challengerId && i.Opponent.Id == opponentId && i.Status == InviteStatus.Waiting);
            invite.Status = InviteStatus.Declined;
            _context.SaveChanges();
            _notificationService.InviteDeclined(challengerId);
        }

        public Game CreateGame(Player challenger, Player opponent)
        {
            var game = new Game();
            game.Challenger = challenger;
            game.Opponent = opponent;
            game.Status = GameStatus.SettingUp;
            game.GamePieces = GenerateGamePieces(challenger, opponent);
            _context.Games.Add(game);
            _context.SaveChanges();
            return game;
        }

        private IEnumerable<GamePiece> GenerateGamePieces(Player challenger, Player opponent)
        {
            throw new NotImplementedException();
        }

        public void SelectGamePiece(int playerId, int gameId, int gamePieceId)
        {
            var game = _context.Games.Single(g => g.Id == gameId);
            if (game.Challenger.Id == playerId)
            {
                game.ChallengerSelection.Id = gamePieceId;
            }
            else
            {
                game.OpponenetSelection.Id = gamePieceId;
            }
            if (game.ChallengerSelection != null && game.OpponenetSelection != null)
            {
                game.Status = GameStatus.InProgress;
                game.PlayersMove = game.Opponent;
            }
            _context.SaveChanges();
        }

        public void AskQuestion(int gameId, int playerId, string questionText)
        {
            var question = new Question();
            question.QuestionText = questionText;
            question.Status = QuestionStatus.UnAnswered;
            var game = _context.Games.Single(g => g.Id == gameId);
            game.Questions.Add(question);
            _context.SaveChanges();
            _notificationService.QuestionAsked(question.Id);
        }

        public void AnswerQuestion(int questionId, Answer answer)
        {
            var question = _context.Questions.Single(q => q.Id == questionId);
            question.Answer = answer;
            question.Status = QuestionStatus.Answered;
            question.UpdatedOn = DateTime.Now;
            _context.SaveChanges();
            _notificationService.QuestionAnswered(questionId);
        }

        public bool Guess(int gameId, int playerId, int gamePieceId)
        {
            var game = _context.Games.Single(g => g.Id == gameId);
            if (game.Opponent.Id == playerId)
            {
                if (game.ChallengerSelection.Id == gamePieceId)
                {
                    game.Winner = game.Opponent;
                    return true;
                }
                game.Winner = game.Challenger;
            }
            else
            {
                if (game.OpponenetSelection.Id == gamePieceId)
                {
                    game.Winner = game.Challenger;
                    game.Status = GameStatus.Completed;
                    return true;
                }
                game.Winner = game.Opponent;
            }
            game.Status = GameStatus.Completed;
            game.UpdatedOn = DateTime.Now;
            return false;
        }
    }
}