using System;
namespace Elevator.classes
{
    public class Elevador
    {
        private int andarAtual;

        public int AndarAtual{
            get{return andarAtual;}
            set{ andarAtual = value;}
        }

        private int totalAndares = 10;

        public int TotalAndares{
            get{return totalAndares;}
        }

        private int capacidade = 8;

        public int Capacidade{
            get{ return capacidade;}
        }

        public string Entrar(int capacidade, int qtdp){
            if(qtdp <= capacidade){
                Console.WriteLine("Entrada permitida");
                
            }else{
                Console.WriteLine("Entrada negada.Limite Excedido.");
                Console.Clear();
            }
            return "";
            
        }
        public string Inicializar(int capacidade, int totalAndares, int qtdp, int andarAtual){

            if(capacidade == qtdp || andarAtual<= totalAndares){
                 Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("ESCOLHA UM ANDAR:");
                Console.WriteLine("[1]");
                Console.WriteLine("[2]");
                Console.WriteLine("[3]");
                Console.WriteLine("[4]");
                Console.WriteLine("[5]");
                Console.WriteLine("[6]");
                Console.WriteLine("[7]");
                Console.WriteLine("[8]");
                Console.WriteLine("[9]");
                Console.WriteLine("[10]");
                int escolha = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.DarkCyan;

                for(var i=andarAtual; i< escolha;i++){
                    Console.WriteLine($"Subindo...");
                    Console.WriteLine($"{i}...");
                
                }
                for(var i=andarAtual; i> escolha;i--){
                     Console.WriteLine($"Descendo...");
                     Console.WriteLine($"{i}...");
                }
                
                }
                return "";
               
            }
            
            public void Sair(){
                Console.WriteLine("Chegamos! Saia do elevador!");
            }
        }
    
}

