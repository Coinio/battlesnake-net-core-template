namespace BattleSnake.GameLogic.DataTypes
{
    /// <summary>
    /// This contains the basic information and customisation details of your battlesnake
    /// </summary>
    public class SnakeInfo
    {
        /// <summary>
        /// The version of the Battlesnake API implemented by this Battlesnake. Currently only API version 1 is valid.
        /// Example: "1"
        /// </summary>        
        public string ApiVersion { get; } = "1";
        /// <summary>
        /// The optional username of the author of this Battlesnake. If provided, this will be used to verify ownership.
        /// Example: "BattlesnakeOfficial"
        /// </summary>
        public string Author { get; set; }
        /// <summary>
        /// A hex color code used to display this Battlesnake. Must start with "#" and be 7 characters long.
        /// Example: "#888888"
        /// </summary>
        public string Color { get; set; }
        /// <summary>
        /// The displayed head of this Battlesnake. See https://docs.battlesnake.com/references/personalization
        /// Example: "default"
        /// </summary>
        public string Head { get; set; }
        /// <summary>  
        /// Displayed tail of this Battlesnake. See https://docs.battlesnake.com/references/personalization
        /// Example: "default"
        /// </summary>
        public string Tail { get; set; }
        /// <summary>
        /// A version number or tag for your snake.
        /// </summary>
        public string Version { get; set; }
    }
}
