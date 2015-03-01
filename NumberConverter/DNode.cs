namespace UnitConverter
{
    public class DNode : NodeBase
    {
        public DNode() : base()
        {
            Name = "D";
        }

        /// <summary>
        /// Node Value : 500
        /// </summary>
        public override int Value
        {
            get { return (int)NodeType.D; }
        }
    }
}
