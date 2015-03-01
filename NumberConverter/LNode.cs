namespace UnitConverter
{
    public class LNode : NodeBase
    {
        public LNode() : base()
        {
            Name = "L";
        }

        /// <summary>
        /// Node Value : 50
        /// </summary>
        public override int Value
        {
            get { return (int)NodeType.L; }
        }
    }
}
