using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {


            List<string> list = new List<string>();


            list.Add("Caio");
            list.Add("Pri");
            list.Add("Matheus");
            list.Add("Mel");
            list.Insert(2, "oi");

            foreach (string obj in list)
            {

                Console.WriteLine(obj);
               
            }

            Console.WriteLine("list count:" + list.Count);


            string s1 = list.Find(x => x[0] == "P");


        }
    }
}
