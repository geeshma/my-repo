using System;
using System.Collections;
namespace ArrayList2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList() { 25, 34, 56, 76 };
            list.Add(45);            
            list.Add(45);
            list.Add(67);
            //insert at particular position
            list.Insert(0, 100);
            //remove item
            list.Remove(34);
            //remove at particular index
            list.RemoveAt(2);
            //count returns how many values are in list
            if (list.Count > 0)
            {
                foreach(var i in list)
                {
                    Console.WriteLine(i);
                }
            }
            //converting object to integer
            int k = Convert.ToInt32(list[1]);
            if (list.Contains(25))
            {
                Console.WriteLine("True");
            }
            else
            {

                Console.WriteLine("False");
            }

            

        }
    }
}
