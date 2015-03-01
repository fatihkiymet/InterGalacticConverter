using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{    
    public class I_Node : NodeBase
    {
        public I_Node() : base()
        {
            Name = "I";
        }

        /// <summary>
        /// Node Value : 1
        /// </summary>
        public override int Value
        {
            get { return (int)NodeType.I; }
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
            if(from is XNode || from is VNode)
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
