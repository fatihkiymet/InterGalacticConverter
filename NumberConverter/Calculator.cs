using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
    public class Calculator
    {
        public int Calculate(Node root, int total = 0)
        {            
            if (root == null)
                return total;

            if(root.Previous != null)
            {
                //if current < previous IX
                if(root.Type.CompareTo(root.Previous.Type) > 0)
                {
                    if(!CanSubtract(root.Previous, root))
                        throw new ArgumentException();

                    total = total + (int) root.Type - (int) root.Previous.Type;
                    Calculate(root.Previous.Previous, total);
                }
                else if (root.Type.CompareTo(root.Previous.Type) == 0)
                {
                    root.Previous.Repetition = root.Repetition + 1;

                    if (!CanRepeat(root.Previous))
                        throw new ArgumentException();
      
                    total = total + (int)root.Type + (int)root.Previous.Type;
                    Calculate(root.Previous.Previous, total);
                }
                else
                {
                    total = total + (int)root.Type + (int)root.Previous.Type;
                    Calculate(root.Previous.Previous, total);
                }
            }
            else
            {
                total = total + (int) root.Type;
            }

            return total;
        }

        public bool CanRepeat(Node node)
        {                       
            switch (node.Type)
            {
                case NodeType.I:
                case NodeType.C:
                case NodeType.X:
                case NodeType.M:
                    if (node.Repetition < 4)
                        return true;
                    break;
            }

            return false;
        }

        public bool CanSubtract(Node node, Node from)
        {
            switch (node.Type)
            {
                case NodeType.V:
                case NodeType.L:
                case NodeType.D:
                    return false;
                case NodeType.I:
                    if (from.Type == NodeType.V || from.Type == NodeType.X)
                        return true;
                    break;
                case NodeType.X:
                    if (from.Type == NodeType.L || from.Type == NodeType.C)
                        return true;
                    break;
                case NodeType.C:
                    if (from.Type == NodeType.D || from.Type == NodeType.M)
                        return true;
                    break;
            }

            return false;
        }
    }
}
