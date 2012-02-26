﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using GameApp.WebRole.Models;

namespace GameApp.WebRole.Controllers {
    public class GameController : ApiController {
        private static readonly GameContext Context = new GameContext();

        private List<Tuple<int, long>> _people = new List<Tuple<int, long>>
                             {
                                 Tuple.Create(1, 4L),
                                 Tuple.Create(2, 1269565700L),
                                 Tuple.Create(3, 1238130858L),
                                 Tuple.Create(4, 1201700386L),
                                 Tuple.Create(5, 1063140540L),
                                 Tuple.Create(6, 1435451815L),
                                 Tuple.Create(7, 1332833126L),
                                 Tuple.Create(8, 14903120L),
                                 Tuple.Create(9, 515673069L),
                                 Tuple.Create(10, 14812017L),
                                 Tuple.Create(11, 100003566112576L),
                                 Tuple.Create(12, 5L),
                                 Tuple.Create(13, 6L),
                                 Tuple.Create(14, 7L),
                                 Tuple.Create(15, 8L)
                             };
        /// <summary>
        /// Invite a Facebook friend to play a game.
        /// </summary>
        public void InviteFriend() {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Accept an invation to play a game.
        /// </summary>
        public void AcceptInvite() {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get your current game.
        /// </summary>
        /// <returns></returns>
        public string GetCurrent() {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get a game by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Game Get(int id)
        {
            var pieces = new List<GamePiece>();
            foreach(var person in _people)
            {
                var gamePiece = new GamePiece
                                    {
                                        Id = person.Item1,
                                        Player1Status = true,
                                        Player2Status = true,
                                        FacebookId = person.Item2
                                    };

            }
            var game = Context.Games.SingleOrDefault(g => g.Id == id);
            if (game == null)
            {
                var count = Context.Games.Count();
                game = new Game {
                    Id = count + 1,
                    IsActive = true,
                    Player1 = Context.Users.Single(u => u.Id == 1),
                    Player2 = Context.Users.Single(u => u.Id == 2),
                    Pieces = pieces
                };
                Context.Games.Add(game);
            }
            Context.SaveChanges();
            return game;
        }

        /// <summary>
        /// Play a turn in a game.
        /// </summary>
        public void PlayMove(int gameId, long playerId, long faceBookId) {
            var game = Context.Games.Single(g => g.Id == gameId);
        }

        public void HidePiece(int gameId, long playerId, long gamePieceId) {

        }

        /// <summary>
        /// Guess the answer to the game.
        /// </summary>
        public void Guess() {
        }

        /// <summary>
        /// Quite a game.
        /// </summary>
        public void Quit(int id) {
        }

    }
}
