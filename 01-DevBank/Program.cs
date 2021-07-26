using System;

namespace _01_DevBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaGabriela = new ContaCorrente();
            contaGabriela.saldo = 125.6;
            contaGabriela.titular = "Gabriela Martins Safra";
            Console.WriteLine(contaGabriela.saldo);

            contaGabriela.saldo += 100;
            Console.WriteLine(contaGabriela.saldo);

            ContaCorrente contaJoao = new ContaCorrente();
            contaJoao.saldo = 95.0;
            contaJoao.titular = "João Almeirda Pires";
            Console.WriteLine(contaJoao.saldo);

            contaJoao.saldo += 120.0;
            Console.WriteLine(contaJoao.saldo);

            Console.WriteLine("A conta corrente de " + contaGabriela.titular + " tem o saldo de " + contaGabriela.saldo);
            Console.WriteLine("A conta corrente de " + contaJoao.titular + " tem o saldo de " + contaJoao.saldo);


            Console.ReadLine();
        }
    }
}
