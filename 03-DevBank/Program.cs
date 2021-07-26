using System;

namespace _03_DevBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cliente felipe = new Cliente();

            //felipe.nomeCliente = "Felipe Pereira";
            //felipe.cpf = "07684329952";
            //felipe.profissaoCliente = "Programador";

            ContaCorrente conta = new ContaCorrente();
            //conta.titular = felipe;

            conta.titular = new Cliente();
            conta.titular.nomeCliente = "Felipe Pereira";
            conta.titular.cpf = "451.852.123-21";
            conta.titular.profissaoCliente = "Desenvolver C#";
             
            conta.numAgencia = 001;
            conta.numConta = 523;
            conta.saldo = 120.0;

            //Console.WriteLine(felipe.nomeCliente);
            Console.WriteLine(conta.titular.nomeCliente);
            Console.WriteLine(conta.titular.cpf);
            Console.WriteLine(conta.titular.profissaoCliente);



            Console.ReadLine(); 
        }
    }
}
