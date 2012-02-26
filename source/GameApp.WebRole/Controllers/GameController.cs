using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using GameApp.WebRole.Models;

namespace GameApp.WebRole.Controllers {
    public class GameController : ApiController {
        private static GameContext context = new GameContext();
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
        public Game Get(int id) {
            var game = context.Games.SingleOrDefault(g => g.Id == id);
            if (game == null)
            {
                var count = context.Games.Count();
                game = new Game {
                    Id = count + 1,
                    IsActive = true,
                    Player1 = context.Users.Single(u => u.Id == 1),
                    Player2 = context.Users.Single(u => u.Id == 2),

                };
                context.Games.Add(game);
            }
            context.SaveChanges();
            return game;
        }

        /// <summary>
        /// Play a turn in a game.
        /// </summary>
        public void PlayMove(int gameId, long playerId, long faceBookId) {
            var game = context.Games.Single(g => g.Id == gameId);
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
