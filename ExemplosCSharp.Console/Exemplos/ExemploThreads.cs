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
      new Thread(RecuperarMinimo).Start(array);
    }

    public static void Maximo(this int[] array)
    {
      new Thread(RecuperarMaximo).Start(array);
    }

    private static void RecuperarMinimo(object array)
    {
      System.Console.WriteLine("Valor Mínimo é: " + (array as int[]).Min());
    }

    private static void RecuperarMaximo(object array)
    {
      System.Console.WriteLine("Valor Máximo é: " + (array as int[]).Max());
    }
  }
}
