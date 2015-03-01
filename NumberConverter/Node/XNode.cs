namespace NumberConverter
{
    public class XNode : NodeBase
    {
        /// <summary>
        /// Node Value : 10
        /// </summary>
        public override int Value
        {
            get { return 10; }
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
            if (from is LNode || from is CNode)
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
