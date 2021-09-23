namespace BattleSnake.GameLogic.DataTypes
{
    public enum MoveDirection
    {
        Up,
        Down,
        Left,
        Right
    };

    /// <summary>
    /// A class representing your next move
    /// </summary>
    public class MoveDecision
    {
        /// <summary>
        /// The direction of the move
        /// </summary>
        public string Move { get; set; }   
        /// <summary>
        /// Shout something cool (optional)
        /// </summary>
        public string Shout { get; set; }
    }
}
