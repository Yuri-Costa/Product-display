using System;

namespace Constructor_Methods
{
    class Program
    {
        static void Main(string[] args)
        {

          do
          {
              
              Produto p1 = new Produto();
              Produtosss ps = new Produtosss();
              p1.mostraMenu();
              int resposta = int.Parse(Console.ReadLine());

              switch (resposta)
              {
                  case 1:
                        ps.mostraProduto1();
                      break;

                      case 2:
                        ps.mostrarProduto2();
                      break;

                      case 3:
                        ps.mostrarProduto3();
                      break;

                  default:
                      break;
              }

          } while (true);
        }
    }
}
