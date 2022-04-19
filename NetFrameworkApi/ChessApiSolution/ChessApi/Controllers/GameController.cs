using ChessApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ChessApi.Controllers
{
	//[RoutePrefix("api/Game")]
	//[Authorize]
	public class GameController : ApiController
    {
		/*
         * // User has ability to create game, join game, invite player to game
	
	Create Game
		// This will create a game with the current player
		[post]
		/api/game/create
	
	Join Game
		// Adds the logged in user to the provided game (if possible)
		[get?]
		/api/game/join/id
	
	Invite player 
		// Sends an invite to another player
		[get?]
		/api/game/invite/id
	
	Update Board
		// updates the chess board
		[put]
		/api/game/updateBoard
	
	Leave game?
		// Is needed, does it need to be an api call?
		// yes
		[put]
		/api/game/leave/id
	
	// Delete game
		// can be deleted by either player
		// or
		// can be deleted by maker, and if there is only 1 player, they can delete it if owner or not
		[delete]
		/api/game/delete/id



		// trying to combine routes

		create game
			[post]
			/api/game
		
		delete game
			[delete]
			/api/game/id
		
		Get Game Info
			[get]
			/api/game/id
		
		update board (update game table)
			[put]
			/api/game/id
			
		
		// leave game (remove player)
			[put]
			/api/game/leave/gameid
		

		/api/game/invite/gameid

		post?
		// invite player (send invitation to another user)
			do we do a post?
			/api/game/invite/gameid? - posts { "id": "userid" }
			// Makes the most sense to do a post

		put?
		// join game ( add player)
			/api/game/invite/gameid - puts { "id": "userid" }

         * */



		/*
		[Authorize(Roles = "Admin")]
        [HttpGet]
        [Route("api/User/Admin/GetAllUsers")]
		// We do not need api/User because we set it at the top
		 * */


		// GET: api/Game/5
		[HttpGet]
		[Route("api/Game/{id}")]
		public string ChangedName(int id)
        {
            return id + "value";
        }

		// POST: api/Game
		[HttpPost]
		[Route("api/Game")]
		public string CreateGame(TestModel value)
        {
			var test = value;
			return "Hey we're here";
		}

		// PUT: api/Game/5
		[HttpPut]
		[Route("api/Game")]
		public void UpdateBoard(int id, [FromBody]string value)
        {

        }

		// DELETE: api/Game/5
		[HttpDelete]
		[Route("api/Game")]
		public void Delete(int id)
        {

        }


		/*
		 * 
		 * // leave game (remove player)
			[put]
			/api/game/leave/gameid
		

		/api/game/invite/gameid

		post?
		// invite player (send invitation to another user)
			do we do a post?
			/api/game/invite/gameid? - posts { "id": "userid" }
			// Makes the most sense to do a post

		put?
		// join game ( add player)
			/api/game/invite/gameid - puts { "id": "userid" }
		 * */

		// PUT: api/Game/5
		[HttpPut]
		[Route("api/Game/Leave")]
		public void LeaveGame(int id, [FromBody] string value)
		{

		}
	}
}
