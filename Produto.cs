using System;
namespace Constructor_Methods
{
    public class Produto
    {
        public int Codigo{get; set;}
        public string Nome{get; set;}
        public string Descricao{get; set;}
        public int Estoque{get; set;}



        public Produto(){
            Console.WriteLine("metodo contrutor executado");
        }

        public Produto (int valor){
            Codigo = valor;
            Console.WriteLine($"o codigo inserido foi {Codigo} ");


        }
            public void mostraMenu(){
                    Console.ForegroundColor=ConsoleColor.Red;
                    Console.WriteLine("--PRODUTOS--");
                    Console.WriteLine("Produto 1 -- [1]");
                    Console.WriteLine("Produto 2 -- [2]");
                    Console.WriteLine("Produto 3 -- [3]");
                   
            }
    }
}