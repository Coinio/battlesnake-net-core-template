using System.Drawing;

namespace BattleSnake.GameLogic.DataTypes
{
    /// <summary>
    /// An object to represent the details (body positions, health, etc) of a battlesnake
    /// </summary>
    public class BattleSnake
    {
        /// <summary>
        /// A unique identifier for this Battlesnake in the context of the current Game.
        /// Example: "totally-unique-snake-id"
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// The name of the snake given by its author.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The current health of the battle snake. This is an integer value between 1 and 100.
        /// </summary>
        public int Health { get; set; }
        /// <summary>
        /// An array of coordinates representing the location of each body section within the game board. This is ordered from head to tail.        
        /// </summary>
        public Point[] Body { get; set; }
        /// <summary>
        /// The previous response time for this battlesnake in milliseconds. A value of 0 indicates the previous response timed out.
        /// </summary>
        public string Latency { get; set; }
        /// <summary>
        /// The coordinates for the battlesnakes head.
        /// </summary>
        public Point Head { get; set; }
        /// <summary>
        /// The length of the battlesnakes body.
        /// </summary>
        public int Length { get; set; }
        /// <summary>
        /// A message shouted by this battlesnake on the previous turn
        /// </summary>
        public string Shout { get; set; }
        /// <summary>
        /// An identifier to signify which squad a battlesnake belongs to in squad mode games.
        /// </summary>
        public string Squad { get; set; }
    }
}
