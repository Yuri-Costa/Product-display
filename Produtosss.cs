using System;
namespace Constructor_Methods
{
    public class Produtosss : Produto 
    {
        
        public void mostraProduto1(){

            Produto p1 = new Produto();
            p1.Nome = "tenis";
            p1.Estoque= 10;
            p1.Descricao= "tenis nike de corrida";
            p1.Codigo=1;
            Console.ForegroundColor=ConsoleColor.Magenta;
            Console.WriteLine("--Produto 1--");
            Console.WriteLine($"Nome: {p1.Nome ?? "sem nome"}");
            Console.WriteLine($"Descrição: {p1.Descricao  ?? "sem descrição"}");
            Console.WriteLine($"Estoque: {p1.Estoque}");
            Console.WriteLine($"Codigo: {p1.Codigo}");
        }
     
         public void mostrarProduto2(){
             Produto p2 = new Produto();
              p2.Nome = "Boné";
            p2.Estoque= 30;
            p2.Descricao= "Boné aba reta, New Era.";
            p2.Codigo=2;
            Console.ForegroundColor=ConsoleColor.Cyan;
            Console.WriteLine("--Produto 2--");
            Console.WriteLine($"Nome: {p2.Nome}");
            Console.WriteLine($"Descrição: {p2.Descricao}");
            Console.WriteLine($"Estoque: {p2.Estoque}");
            Console.WriteLine($"Codigo: {p2.Codigo}");

            
         }

          public void mostrarProduto3(){
             Produto p3 = new Produto();
              p3.Nome = "Jaqueta";
            p3.Estoque= 25;
            p3.Descricao= "Jaqueta preta, Adidas.";
            p3.Codigo=3;
            Console.ForegroundColor=ConsoleColor.Yellow;
            Console.WriteLine("--Produto 3--");
            Console.WriteLine($"Nome: {p3.Nome}");
            Console.WriteLine($"Descrição: {p3.Descricao}");
            Console.WriteLine($"Estoque: {p3.Estoque}");
            Console.WriteLine($"Codigo: {p3.Codigo}");

            
         }

         
            

        
    }
}