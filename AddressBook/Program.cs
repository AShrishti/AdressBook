using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Stack myStack = new Stack(4);

            myStack.Push(10);
            myStack.Push(20);
            myStack.Push(30);
            myStack.Push(40);
            myStack.Peek();
            Console.WriteLine("Item popped from Stack : {0}", myStack.Pop());
            
            System.Collections.Generic.LinkedList<int> list =new LinkedList<int>();
            list.AddLast(30);
            list.AddFirst(70);
             list.Append(90);
            list.Max();
            list.Contains(30);
            Console.WriteLine(list.Contains(70));

            Contact contact1 = new Contact("Ashish", 22003, "lko", "UP");
            Contact contact2 = new Contact("Ashu", 24004, "knp", "UP");
            Contact contact3 = new Contact("Romi", 24205, "lko", "UP");

            Dictionary<int, Contact> contacts = new Dictionary<int, Contact>();
            contacts.Add(1, contact1);
            contacts.Add(2, contact2);
              contacts.Add(3, contact3);
            Console.WriteLine(contact1.ToString());
            Console.WriteLine(contact2.ToString());
            Console.WriteLine(contact3.ToString());

            Contact value= contacts[1];
            Console.WriteLine(value);

            
            // AddBook addressBook = new AddBook(2);
            // addressBook.AddnewContact();
            // addressBook.PrintAllContacts();
           // LinkedList list2=new LinkedList();
           // list2.Insert(1,30); 
            //list2.Insert(2,40);

            //Console.WriteLine(list2.Index(20));
            // list2.Contains(20);

            //Contact c1 = new Contact("Ashish");


            int[] intArray = { 1,2,3,4,9};
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'o' };


           //  Program.toPrint(intArray);
           //  Program.toPrint(doubleArray);
           //     Program.toPrint(charArray);

          //  ToPrint<int>(intArray);
            //ToPrint<double>(doubleArray);
           // ToPrint<char>(charArray);
            //Program.toPrint<int>[intArray];
           // Program.toPrint<double>[doubleArray];
           // Program.toPrint<char>[charArray];



        }
        public static void ToPrint<T>(T[] fff)
        {
            for (int i = 0; i < fff.Length; i++)
            {
                Console.WriteLine(fff[i]);
                    }
        }
        public static void toPrint(double[] inputArray)
            {
                foreach (double element in inputArray)
                {
                    Console.WriteLine(element);
                }
                Console.WriteLine("------------");
            }

            public static void toPrint(char[] inputArray)
            {
                foreach (char element in inputArray)
                {
                    Console.WriteLine(element);
                }
                Console.WriteLine("------------");
            }

        public static void toPrint(int[] inputArray)
        {
            foreach (int element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("------------");
        }
        //public class MaximumNumCheck {
            
        //    public static int MaximumIntegerNumber(int firstvalue,int secondValue, int thirdValue)
        //    {
        //        if (firstvalue.CompareTo(secondValue) > 0 && firstvalue.CompareTo(thirdValue);
        //        return firstvalue;
            //}
            

    }
    }

    