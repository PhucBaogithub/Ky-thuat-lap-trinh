using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSLKDon
{
    class MyList
    {

        private IntNode first;

        private IntNode last;

        public IntNode First
        {
            get { return first; }
            set { first = value; }
        }

        public IntNode Last
        {
            get { return last; }
            set { last = value; }
        }

        public MyList()
        {
            first = null;
            last = null;
        }

        public bool IsEmpty()
        {
            return first == null;
        }

        public void AddFirst(IntNode newNode)
        {
            if (IsEmpty())
                first = last = newNode;
            else
            {
                newNode.Next = first;
                first = newNode;
            }
        }

        public void AddLast(IntNode newNode)
        {
            if (IsEmpty())
                first = last = newNode;
            else
            {
                last.Next = newNode;
                newNode = last;
            }
        }

        public void Input()
        {
            int x;
            do
            {
                Console.Write("Gia tri (0 ket thuc): ");
                int.TryParse(Console.ReadLine(), out x);
                if (x == 0)
                    return;
                IntNode newNode = new IntNode(x);
                AddFirst(newNode);
            } while (true);
        }

        public void ShowList()
        {
            IntNode p = first;
            while (p != null)
            {
                Console.Write("{0} -> ", p.Data);
                p = p.Next;
            }
            Console.WriteLine("null");
        }
        public int SearchX(int x)
        {
            int count = 0;
            if (IsEmpty())
            {
                return 0;
            }
            else
            {
                IntNode p = first;
                while (p.Data != x)
                {
                    count++;
                    p = p.Next;
                }
                return count+1;
            }
        }

        public void GetMax()
        {
            int max = 0;
            IntNode p = first;
            while (p != null)
            {
                if (max < p.Data)
                {
                    max = p.Data;
                }
                p = p.Next;
            }
            Console.WriteLine($"Gia tri lon nhat {max} o vi tri: {SearchX(max)}");
        }

        public void GetMin()
        {
            IntNode p = first;
            int min = p.Data;
            while (p != null)
            {
                if (min > p.Data)
                {
                    min = p.Data;
                }
                p = p.Next;
            }
            Console.WriteLine($"Gia tri nho nhat {min} o vi tri: {SearchX(min)}");
        }

        public void GetEvenList()
        {
            MyList GetEvenList = new MyList();
            if (IsEmpty())
            {
                first = last = null;
            }
            else
            {
                IntNode p = first;
                while (p != null)
                {
                    if(p.Data % 2 == 0)
                    {
                        IntNode newNode = new IntNode(p.Data);
                        GetEvenList.AddFirst(newNode);
                    }
                    p = p.Next;
                }              
            }
            GetEvenList.ShowList();
        }

        public void GetOddList()
        {
            MyList GetOddList = new MyList();
            if (IsEmpty())
            {
                first = last = null;
            }
            else
            {
                IntNode p = first;
                while (p != null)
                {
                    if (p.Data % 2 != 0)
                    {
                        IntNode newNode = new IntNode(p.Data);
                        GetOddList.AddFirst(newNode);
                    }
                    p = p.Next;
                }              
            }
            GetOddList.ShowList();
        }
    }
}
