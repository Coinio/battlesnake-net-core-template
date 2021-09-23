namespace BattleSnake.GameLogic.DataTypes
{
    /// <summary>
    /// A game object to identify a game and define the rules in play
    /// </summary>
    public class Game
    {
        /// <summary>
        /// A unique identifier for this Game.
        /// Example: "totally-unique-game-id"
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Information about the ruleset being used to run this game.
        /// Example: {"name": "standard", "version": "v1.2.3"}
        /// </summary>
        public Ruleset Ruleset { get; set; }
        /// <summary>
        /// The amount of time your snake has to respond to requests for this game, in milliseconds.
        /// Example: 500        
        ///</summary>
        public int Timeout { get; set; }
    }
}
