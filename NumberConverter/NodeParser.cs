using System;
using System.Collections.Generic;
using System.Linq;

namespace NumberConverter
{
    public class NodeParser : INodeParser
    {
        public NodeBase Parse(string input)
        {
            if(string.IsNullOrWhiteSpace(input))
                throw new ArgumentNullException("input", "parameter cannot be null or empty");
            
            List<NodeBase> nodeList = input.Select( c => NodeResolver.Instance.Resolve(c)).ToList();

            for (int i = 0; i < nodeList.Count; i++)
            {
                var node = nodeList[i];
                if( i > 0)
                    node.Previous = nodeList[i - 1];
            }

            return nodeList.Last();
        }
    }
}
