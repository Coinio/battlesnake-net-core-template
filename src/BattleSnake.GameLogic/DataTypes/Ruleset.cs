namespace BattleSnake.GameLogic.DataTypes
{
    /// <summary>
    /// An object to define which ruleset a game is being played under
    /// </summary>
    public class Ruleset
    {
        /// <summary>
        /// The name of the ruleset
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The version of the ruleset
        /// </summary>
        public string Version { get; set; }

        // TODO : Add ruleset settings
    }
}
