using BattleSnake.GameLogic.DataTypes;
using BattleSnake.GameLogic.Logic.Interfaces;
using System.Threading.Tasks;

namespace BattleSnake.GameLogic.Logic
{
    /// <summary>
    /// Simple strategy to get started with
    /// </summary>
    public class DemoGameStrategy : IGameStrategy
    {
        public Task<SnakeInfo> GetSnakeInfo()
        {
            SnakeInfo info = new SnakeInfo
            {
                Author = "",
                Color = "#FFFFFF",
                Head = "default",
                Tail = "default",
                Version = ""
            };

            return Task.FromResult(info);
        }

        public Task StartGame(GameState gameState)
        {          
            return Task.CompletedTask;
        }

        public Task<MoveDecision> GetNextMove(GameState gameState)
        {        
            return Task.FromResult(new MoveDecision
            {
                Move = "down",
                Shout = "DOWN!"
            });
        }

        public Task EndGame(GameState gameState)
        {
            return Task.CompletedTask;
        }

    }
}
