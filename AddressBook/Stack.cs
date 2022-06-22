using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
	public class Stack
	{
		int capacity;
		int[] obj;
		int top = -1;
		public Stack(int capacity)
		{
			this.capacity = capacity;
			obj = new int[capacity];
		}
		public bool Push(int data)
		{
			if (top == capacity - 1)
			{
				Console.WriteLine("Stack overFlow");
				return false;
			}
			obj[++top] = data;
			return true;
		}
		//pop
		public int Pop()
		{
			if (top == -1)
			{
				Console.WriteLine("Stack Underflow");
				return default(int);
			}
			return obj[top--];
		}
		public int Peek()
		{
			if (top == -1)
			{
				Console.WriteLine("Stack is UnderFlow");
				return (int)default;
			}
			return obj[top];
		}
	}
}
