using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_project
{
    public class PseudoQueue
    {
        Stack stack1 = new Stack();
        Stack stack2 = new Stack();

        public void Enqueue(string value)
        {
            while (stack1.top != null)
            {
                stack2.Push(stack1.Pop());
            }

            stack1.Push(value);

            while (stack2.top != null)
            {
                stack1.Push(stack2.Pop());
            }
        }
        public void Dequeue()
        {
            if(stack1.top != null)
            {
                stack1.Pop();
            }
            else
            {
                throw new Exception("The Queue is Empty");
            }
            
        }
    }
}
