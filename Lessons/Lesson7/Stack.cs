using System.Collections.Generic;
namespace Lesson7
{
    class Stack
    {
        class Node
        {
            public int value;
            public Node? prev;

            public Node(int value, Node? prev)
            {
                this.value = value;
                this.prev = prev;
            }
        }

        private Node? top;
        private int size;

        public Stack()
        {
            top = null;
            size = 0;
        }

        public Stack(IEnumerable<int> collection)
        {
            foreach (int buf in collection)
            {
                Push(buf);
            }
        }

        public void Push(int value)
        {
            top = new Node(value, top);
            ++size;
        }

        public int Top()
        {
            if (top is Node node)
            {
                return node.value;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public int Pop()
        {
            if (top is null)
            {
                throw new System.Exception("Empty stack");
            }

            int buf = top.value;
            top = top.prev;
            --size;
            return buf;
        }

        public bool Empty()
        {
            return size == 0;
        }

        public override string ToString()
        {
            Node? buf = top;
            string result = "";
            while (buf != null)
            {
                result += $"{buf.value}\n";
                buf = buf.prev;
            }
            return result;
        }
    }
}