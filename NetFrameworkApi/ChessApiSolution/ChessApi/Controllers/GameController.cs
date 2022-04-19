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

		// GET: api/Game/5
		[HttpGet]
		[Route("api/Game/{id}")]
		public string GetUserDetails(int id)
        {
            return id + "value";
        }

		// POST: api/Game
		[HttpPost]
		[Route("api/Game")]
		public string CreateGame([FromBody] Dictionary<string,string> value)
        {
			var test = value;
			return "Hey we're here " + value;
		}

		// PUT: api/Game/5
		[HttpPut]
		[Route("api/Game/{id}")]
		public void UpdateBoard(int id, [FromBody]string value)
        {

        }

		// DELETE: api/Game/5
		[HttpDelete]
		[Route("api/Game/{id}")]
		public void Delete(int id)
        {

        }

		// PUT: api/Game/5
		[HttpPut]
		[Route("api/Game/Leave/{id}")]
		public void LeaveGame(int id, [FromBody] string value)
		{

		}

		[HttpPost]
		[Route("api/Game/Invite/{id}")]
		public void InviteToGame(int id, [FromBody] string value)
		{

		}

		[HttpPut]
		[Route("api/Game/Invite/{id}")]
		public void JoinGame(int id, [FromBody] string value)
		{

		}
	}
}
