using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosCSharp.Console
{
  class Program
  {
    static bool continuar = true;

    static void Main(string[] args)
    {
      while(continuar)
      {
        DesenharMenu();
        ExecutarOpcaoDoMenu();
      }
    }

    static void DesenharMenu()
    {
      System.Console.WriteLine();
      System.Console.WriteLine("Digite 1 parar recuperar o mínimo e o máximo");
      System.Console.WriteLine("Digite 99 parar sair");
    }

    static void ExecutarOpcaoDoMenu()
    {
      int opcao = 99;
      int.TryParse(System.Console.ReadLine(), out opcao);

      switch (opcao)
      {
        case 1: Exemplos.ExemploThreads.Executar(); break;
        default: continuar = !opcao.Equals(99); break;
      }
    }
  }
}
