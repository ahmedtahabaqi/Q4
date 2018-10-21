using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    class Program
    {
        public static int size;
        static void Main(string[] args)
        {
            Console.Write("enter the size of list : ");
            size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("NOTE// insert items without enter");
            char [] list1=new char[size];
            char [] list2=new char[size];
            char [] result = new char[size * 2];
            //this for to insert list one from the user
            for (int i = 0; i < size; i++)
            {
                Console.Write("enter the item (" + (i+1) +" )of list one :");
                list1[i] = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }
            Console.WriteLine();
            // this for to insert list two from the user
            for (int i = 0; i < size; i++)
            {
                Console.Write("enter the item (" + (i+1) + " )of list two :");
                list2[i] = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }
            result = combines(list1, list2);
            Console.WriteLine();
            Console.Write("the result is :");
            Console.WriteLine(result);
            Console.ReadKey();
        }
        //in this function make form of finaly list and put the item in list 
        static char []combines(char []list1,char []list2)
        {
            int size2 = size *2;
            char[] result = new char[size2];
            int x= 0, y= 0;
            for (int i = 0; i < size2; i++)
            {
                if (i % 2 == 0)
                    result[i] = list1[x++];
                else
                    result[i] = list2[y++];  
            }
            return result;
		}
    }
}
