using System.Drawing;

namespace BattleSnake.GameLogic.DataTypes
{
    /// <summary>
    /// An object to represent a game board. The game board is represented by a standard 2D grid, oriented with (0,0) in the bottom left. 
    /// The Y-Axis is positive in the up direction, and X-Axis is positive to the right. Coordinates begin at zero, such that a board that is 11x11 will have coordinates ranging from [0, 10]
    /// </summary>
    public class GameBoard
    {
        /// <summary>
        /// The number of columns on the x-axis of the board
        /// </summary>
        public int Width { get; set; }
        /// <summary>
        /// The number of rows on the y-axis of the board
        /// </summary>
        public int Height { get; set; }
        /// <summary>
        /// An array of coordinates containing the locations of food on the game board.
        /// </summary>
        public Point[] Food { get; set; }
        /// <summary>
        /// An array of coordinates containing the locations of any hazards on the game board.
        /// </summary>
        public Point[] Hazards { get; set; }
        /// <summary>
        /// An array of battle snakes on the game board that haven't been eliminated, including 'you'.
        /// </summary>
        public BattleSnake[] Snakes { get; set; }
    }
}
