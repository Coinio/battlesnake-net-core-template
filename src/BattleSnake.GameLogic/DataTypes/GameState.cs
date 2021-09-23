namespace BattleSnake.GameLogic.DataTypes
{
    /// <summary>
    /// An object to represent the current state of a game
    /// </summary>
    public class GameState
    {
        /// <summary>
        /// A game object describing the game being played
        /// </summary>
        public Game Game { get; set; }
        /// <summary>
        /// The turn number of the game being played. A game starts at 0.
        /// </summary>
        public int Turn { get; set; }
        /// <summary>
        /// A board object describing the current state of the game board
        /// </summary>
        public GameBoard Board { get; set; }
        /// <summary>
        /// Your battlesnake!
        /// </summary>
        public BattleSnake You { get; set; }
    }
}
