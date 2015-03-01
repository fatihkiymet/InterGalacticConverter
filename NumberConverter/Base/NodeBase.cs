namespace UnitConverter
{
    public abstract class NodeBase
    {
        public string Name { get; protected set; }

        /// <summary>
        /// MaxRepetition : 1
        /// </summary>   
        public virtual int MaxRepetition {
            get { return 1; }
        }

        /// <summary>
        /// Repetition : 1
        /// </summary>  
        public int Repetation { get; set; }

        /// <summary>
        /// Previous Node
        /// </summary>
        public NodeBase Previous { get; set; }


        public virtual int Value
        {
            get;
            protected set;
        }
    

        /// <summary>
        /// Subtracts node value from given node value 
        /// </summary>
        /// <param name="from">node to be subtracted from</param>
        /// <returns>throws exception if fails</returns>
        public virtual int Subtract(NodeBase from)
        {
            throw new InvalidSubtractionException(string.Format("{0} cannot be subtracted from {1}", this.Name, from.Name));
        }

        /// <summary>
        /// Checks if node can repeat
        /// </summary>
        /// <returns>return true if node can repeat</returns>
        public bool CanRepeat()
        {
            return Repetation <= MaxRepetition;
        }

        protected NodeBase()
        {
            Repetation = 1;
        }
    }
}
