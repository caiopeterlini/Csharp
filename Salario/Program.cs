using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many employees will be registred?");
            int quant = int.Parse(Console.ReadLine());
            List<Funcionario> funcionarios = new List<Funcionario>();


            for (int i = 0; i < quant; i++)
            {
                Console.WriteLine("ID, name, salary");
                int id = int.Parse(Console.ReadLine());
                string name = Console.ReadLine();
                double salary = double.Parse(Console.ReadLine());

                funcionarios.Add(new Funcionario(id, name, salary));
                Console.WriteLine("----------------------------");
            }


            Console.WriteLine("Enter the employee id that will have salary increase:");
            int sourcheid = int.Parse(Console.ReadLine());

            Funcionario emp = funcionarios.Find(x => x.ID == sourcheid);

            if (emp != null)
            {
                Console.WriteLine("Enter the porcentage:");
                double percentage = double.Parse(Console.ReadLine());
                emp.Increase(percentage);

            }
            else
            {
                Console.WriteLine("This id not exist");



            }

            Console.WriteLine();
            Console.WriteLine("Update list: ");
            foreach (var item in funcionarios)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }
    }
}
