using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Pensionato
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(" How many rooms will be rented?" );
            int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Room[] room = new Room[9]; 

            for (int i = 0; i < n; i++)
            {

                Console.WriteLine(" number of room ,name and e-mail please");
                int number = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                string name = Console.ReadLine();
                string email = Console.ReadLine();

                room[number] = new Room { Name = name, Email = email, Number=number };



            }


            for (int i = 0; i < 10; i++)
            {
                if (room[i] != null)
                {
                    Console.WriteLine(room[i].Number + ":" + room[i].Name + room[i].Email);

                }



            }





        }
    }
}
