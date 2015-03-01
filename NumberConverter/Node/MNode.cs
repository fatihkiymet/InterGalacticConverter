namespace NumberConverter
{
    public class MNode : NodeBase
    {

        public MNode() : base()
        {
            Name = "M";
        }

        /// <summary>
        /// Node Value : 1000
        /// </summary>
        public override int Value
        {
            get { return (int)NodeType.M; }
        }

        /// <summary>
        /// MaxRepetition : 3
        /// </summary>
        public override int MaxRepetition
        {
            get { return 3; }
        }
    }
}
