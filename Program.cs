using System;
using Elevator.classes;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {   
            
            Elevador objeto = new Elevador();

            Console.WriteLine("Quantidade de pessoas no elevador (?)");
            int qtdp = int.Parse(Console.ReadLine());
          
            objeto.Entrar(objeto.Capacidade,qtdp);

            Console.WriteLine("Digite o andar onde você está.");
            objeto.AndarAtual = int.Parse(Console.ReadLine());

            objeto.Inicializar(objeto.Capacidade, objeto.TotalAndares, qtdp, objeto.AndarAtual);

            objeto.Sair();
            
        }
    }
}
