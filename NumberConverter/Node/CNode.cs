namespace NumberConverter
{
    public class CNode : NodeBase
    {
        public CNode() : base()
        {
            Name = "C";
        }

        /// <summary>
        /// Node Value : 100
        /// </summary>
        public override int Value
        {
            get { return (int)NodeType.C; }
        }

        /// <summary>
        /// MaxRepetition : 3
        /// </summary>   
        public override int MaxRepetition
        {
            get { return 3; }
        }

        public override int Subtract(NodeBase from)
        {
            if (from is DNode || from is MNode)
            {
                return from.Value - this.Value;
            }
            else
            {
                return base.Subtract(from);
            }
        }
    }
}
