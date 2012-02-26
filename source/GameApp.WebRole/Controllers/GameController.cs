﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using GameApp.WebRole.Models;

namespace GameApp.WebRole.Controllers
{
    public class GameController : ApiController
    {
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
        public Game Get(int id)
        {
            return context.Games.Single(g => g.Id == id);
        }

        /// <summary>
        /// Play a turn in a game.
        /// </summary>
        public void PlayMove(int gameId, long playerId, long faceBookId)
        {
            var game = context.Games.Single(g => g.Id == gameId);
       
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
