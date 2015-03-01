using System;

namespace UnitConverter
{
    public class NodeCalculator : INodeCalculator
    {
        private readonly INodeParser _parser;

        public NodeCalculator(INodeParser parser)
        {
            _parser = parser;
        }

        public NodeCalculator()
        {
            _parser = new NodeParser();
        }

        public int Calculate(string input)
        {
            var node = _parser.Parse(input);
            return Calculate(node);
        }

        private int Calculate(NodeBase node, int total = 0)
        {
            if(node == null)
                return total;      
       
            if(node.Previous == null)           
                return total + node.Value;


            //if current node value is greater than previous value subtract previous from current 
            if(node.Value > node.Previous.Value)
            {
                total = total + node.Previous.Subtract(node);
                total = Calculate(node.Previous.Previous, total);
            }
            else if(node.Value == node.Previous.Value)
            {
                node.Previous.Repetation = node.Repetation + 1;
                if(node.Previous.CanRepeat())
                {
                    total = total + node.Value;
                    total = Calculate(node.Previous, total);
                }
                else
                {
                    throw new ArgumentException(String.Format("{0} letter cannot be repeat more than {1}", node.Previous.Name, node.Previous.MaxRepetition));
                }
            } 
            else
            {
                total = total + node.Value;
                total = Calculate(node.Previous, total);
            }

            return total;
        }
    }
}
