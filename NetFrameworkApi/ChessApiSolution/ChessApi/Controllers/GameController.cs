using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ChessApi.Controllers
{
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
         * */
		// GET: api/Game
		public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Game/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Game
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Game/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Game/5
        public void Delete(int id)
        {
        }
    }
}
