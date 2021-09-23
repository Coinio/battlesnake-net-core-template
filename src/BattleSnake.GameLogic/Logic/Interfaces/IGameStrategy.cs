using BattleSnake.GameLogic.DataTypes;
using System.Threading.Tasks;

namespace BattleSnake.GameLogic.Logic.Interfaces
{
    /// <summary>
    /// A simple interface for a game strategy.
    /// </summary>
    public interface IGameStrategy
    {
        Task<SnakeInfo> GetSnakeInfo();
        Task StartGame(GameState gameState);
        Task<MoveDecision> GetNextMove(GameState gameState);
        Task EndGame(GameState gameState);
    }
}
