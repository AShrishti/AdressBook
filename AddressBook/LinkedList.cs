using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class LinkedList
    {
        public class Node
        {
            public int data;
            public Node next;
            public Node(int data)
            {
                this.data = data;
            }
        }
        private Node head;
        //correct
        public int Index(int data)
        {
            int count = -1;
            if (head == null)
                return -1;
            Node t = head;
            while (t != null)
            {
                count++;
                if (t.data.Equals(data))
                    return count;
                t = t.next;

            }
            return -1;
        }

        public bool Add(int data)
        {
            Node n = new Node(data);
            if (head == null)
            {
                head = n;
                return true;
            }
            n.next = head;
            head = n;
            return true;
        }
        public bool Insert(int ind, int data)
        {
            Node n = new Node(data);
            if (ind == 0)
            {
                n.next = head.next;
                head = n;
                return true;
            }
            Node t = head, pre = null;
            while (ind > 0 && t != null)
            {
                ind--;
                pre = t;
                t = t.next;
            }
            if (ind == 0)
            {
                pre.next = n;
                n.next = t;
                return true;
            }
            throw new NullReferenceException("index is not in range");
        }
    }
}
