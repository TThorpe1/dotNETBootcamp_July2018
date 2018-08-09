using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    class TheMostAwesomeList
    {
        public Node Head { set; get; }

        public Node Tail { set; get; }

        public int Count { set; get; }

        public void Add (string userInput)
        {
            if (Count == 0) // very first node
            {
                //1. Make a new code
                Node newNode = new Node { Next = null, Data = userInput };

                Head = newNode; // 2
                Tail = newNode; //3
                Count++;// 4 

            }

            else
            {
                //1. 
                Node newNode = new Node { Next = null, Data = userInput };

                //2. Change the tail reference
                Tail.Next = newNode;

                Tail = newNode;

                //3. increment the count 
                Count++;

            }
        }

        public Node GetNode(int index)
        {
            int start = 0;
            Node temp = Head; // mark the start of the search 
            while (start != index)
            {
                start += 1;
                temp = temp.Next; 

            }

            return temp; // once found, return the node 

        }

    }
}
