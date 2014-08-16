using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExemplosCSharp.Console.Exemplos
{
  public static class ExemploThreads
  {
    public static void Executar()
    {
      var array = new int[] { 1, 4, 18, 32, 46, 98, 115 };
      array.Minimo();
      array.Maximo();
    }

    public static void Minimo(this int[] array)
    {
      Thread thread = new Thread(RecuperarMinimo);
      thread.Start(array);
    }

    public static void Maximo(this int[] array)
    {
      Thread thread = new Thread(RecuperarMaximo);
      thread.Start(array);
    }

    private static void RecuperarMinimo(object array)
    {
      var a = (array as int[]);
      System.Console.WriteLine("Valor Mínimo é: " + a.Min());
    }

    private static void RecuperarMaximo(object array)
    {
      var a = (array as int[]);
      System.Console.WriteLine("Valor Máximo é: " + a.Max());
    }
  }
}
