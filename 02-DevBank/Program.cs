using System;

namespace _02_DevBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaFelipe = new ContaCorrente();
            contaFelipe.titular = "Felipe Luiz Pereira";

            Console.WriteLine("O saldo da conta de " + contaFelipe.titular + " é de " + contaFelipe.saldo);

            Console.WriteLine("Iremos sacar R$ 50,00");
            contaFelipe.Sacar(50);
            Console.WriteLine("O novo saldo da conta de " + contaFelipe.titular + " é de " + contaFelipe.saldo);

            Console.WriteLine("Iremos depositar R$ 125,60");
            contaFelipe.Depositar(125.6);
            Console.WriteLine("O novo saldo da conta de " + contaFelipe.titular + " é de " + contaFelipe.saldo);

            ContaCorrente contaDaphne = new ContaCorrente();
            contaDaphne.titular = "Daphne dos Reis";
            contaDaphne.saldo = 0;

            Console.WriteLine("Exibiremos o saldo");
            Console.WriteLine("O saldo da conta de " + contaDaphne.titular + " é de " + contaDaphne.saldo);

            Console.WriteLine("Iremos transferir R$ 25,00 de " + contaFelipe.titular + " para " + contaDaphne.titular);
            contaFelipe.Transferir(25, contaDaphne);
            Console.WriteLine("O novo saldo da conta de " + contaFelipe.titular + " é de " + contaFelipe.saldo);
            Console.WriteLine("O novo saldo da conta de " + contaDaphne.titular + " é de " + contaDaphne.saldo);

            Console.ReadLine();

        }
    }
}
