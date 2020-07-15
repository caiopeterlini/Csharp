using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CaixaEletronico
{
    class Program
    {
        static void Main(string[] args)
        {

            string nome, statusdeposito, statusop;
            double numero;
            double saldoinicial=0;

            

            Console.WriteLine("Olá,");
            Console.WriteLine("");
            Console.WriteLine("Entre com o numero da conta");
            numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com o titular da conta");
            nome = Console.ReadLine();

            Console.WriteLine("Havera deposito inicial?  (s/n)");
            statusdeposito = Console.ReadLine();

            while (statusdeposito.Length > 1)
                
            {

                Console.WriteLine("Entre com uma resposta válida!!");



                Console.WriteLine("Havera deposito inicial?  (s/n)");
                statusdeposito = Console.ReadLine();


            }

            if (statusdeposito=="s")
            {

                Console.WriteLine("Entre com o valor do depósito inicial");
                saldoinicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            }


            Conta p = new Conta(nome, numero, saldoinicial);


            Console.WriteLine("Dados da conta:" + p);



            Console.WriteLine("Deseja efetuar um depósito?  (s/n)");
            statusop = Console.ReadLine();

            while (p.verifica(statusop) == false)

            {

                Console.WriteLine("Entre com uma resposta válida!!");




                Console.WriteLine("Deseja efetuar um depósito?  (s/n)");
                statusop = Console.ReadLine();


            }

            if (statusop=="s")

            {




            Console.WriteLine("Entre com o valor do depósito ");
            p.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));


            Console.WriteLine("Dados atualizados  da conta:" );
            Console.WriteLine("");
            Console.WriteLine(p);


            }



            Console.WriteLine("Deseja efetuar um saque?  (s/n)");
            statusop = Console.ReadLine();


           



            while (p.verifica(statusop) == false)

            {

                Console.WriteLine("Entre com uma resposta válida!!");




                Console.WriteLine("Deseja efetuar um saque?  (s/n)");
                statusop = Console.ReadLine();


            }


            if (statusop == "s"){
                Console.WriteLine("Entre com o valor do saque");
                p.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));


                Console.WriteLine("Dados atualizados  da conta:");
                Console.WriteLine("");
                Console.WriteLine(p);

            }











        }
    }
}
