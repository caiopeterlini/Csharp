using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CaixaEletronico
{
    class Conta
    {

        public string Nome { get; set; }
        public double Nconta { get; private set; }
        public double Saldo { get; private set; }



        public Conta()
        {
        }

        public Conta( string nome, double nconta , double saldo)
        {
            Nome = nome;
            Nconta = nconta;
            Saldo = saldo;


        }


        public Boolean verifica( String resposta)
        {

            if (resposta.Length > 1)

            {

                return false;


            }
            else
            {

                return true;

            }

        }


        public void Deposito( double valor)
        {

            Saldo += valor;



        }

        public void Saque(double valor)
        {

            Saldo -= valor+5.00;



        }




        public override string ToString()
        {



            return "Titular da conta:"+ Nome + ", Número da conta:"+ Nconta + ", Saldo atual: $" + Saldo.ToString("F2", CultureInfo.InvariantCulture ) ;




        }
















    }
}
