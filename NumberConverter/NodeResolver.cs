using System;
using System.Collections.Generic;
using System.Globalization;

namespace UnitConverter
{
    public class NodeResolver
    {
        private readonly Dictionary<char, Type> _nodeBag;

        public static readonly NodeResolver Instance;

        static NodeResolver()
        {
            Instance = new NodeResolver();
        }

        public NodeResolver()
        {
            _nodeBag = new Dictionary<char, Type>
                          {
                              {'I', typeof (I_Node)},
                              {'V', typeof (VNode)},
                              {'X', typeof (XNode)},
                              {'L', typeof (LNode)},
                              {'C', typeof (CNode)},
                              {'D', typeof (DNode)},
                              {'M', typeof (MNode)}
                          };
        }

        public NodeBase Resolve(char letter)
        {
            letter = char.ToUpper(letter, CultureInfo.InvariantCulture);

            if(!_nodeBag.ContainsKey(letter))
            {
                throw new ParseException(string.Format("{0} cannot be recognized", letter));
            }

            var nodeType = _nodeBag[letter];
            return Activator.CreateInstance(nodeType) as NodeBase;
        }
    }
}
