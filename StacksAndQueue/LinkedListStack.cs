using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueue
{
    internal class LinkedListStack
    {
        public Node top;
        public void Push(int newData)
        {

            Node new_node = new Node(newData);
            if (this.top != null)
            {
                new_node.next = this.top;
            }
            this.top = new_node;
            Console.WriteLine(" pushed into stack: "+ new_node.data);
        }
        public void Display()
        {          
            Node temp = this.top;
            if (temp == null)
            {
                Console.WriteLine("No data in stack");           
            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine(temp.data+" ");
                    temp = temp.next;
                }
            }
        }
    }
}
