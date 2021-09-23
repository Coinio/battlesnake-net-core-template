using BattleSnake.GameLogic.DataTypes;
using BattleSnake.GameLogic.Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Battlesnake.Api.Controllers
{
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly IGameStrategy _gameStrategy;

        public GameController(IGameStrategy gameStrategy)
        {
            _gameStrategy = gameStrategy;
        }

        [HttpGet("/")]
        public async Task<ActionResult<SnakeInfo>> GetInfo()
        {
            SnakeInfo info = await _gameStrategy.GetSnakeInfo();

            return Ok(info);
        }

        [HttpPost("start")]
        public async Task<IActionResult> StartGame([FromBody] GameState initialState)
        {
            await _gameStrategy.StartGame(initialState);

            return Ok();
        }

        [HttpPost("move")]
        public async Task<ActionResult<MoveDecision>> GetNextMove([FromBody] GameState gameState)
        {
            MoveDecision nextMove = await _gameStrategy.GetNextMove(gameState);

            return Ok(nextMove);
        }

        [HttpPost("end")]
        public async Task<IActionResult> EndGame([FromBody] GameState finalState)
        {
            await _gameStrategy.EndGame(finalState);

            return Ok();
        }
    }
}
