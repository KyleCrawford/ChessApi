using ChessApi.Models;
using DataManager.Library.DataAccess;
using DataManager.Library.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ChessApi.Controllers
{
	//[RoutePrefix("api/Game")]
	[Authorize]
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
		public string CreateGame(GameModel game)
        {
			string userId = RequestContext.Principal.Identity.GetUserId();
			UserData data = new UserData();
			game.Code = "ABC123"; // will change this later
			game.BoardData = "initial text"; 

			CreateGameModel model = new CreateGameModel
			{
				UserId = userId,
				Name = game.Name,
				Code = game.Code,
				BoardData = game.BoardData
			};

			data.CreateGame(model);
			return "Game Created";
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
