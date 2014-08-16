using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using console = System.Console;

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
      new Thread(t => {
        console.WriteLine("Valor Mínimo é: " + array.Min());
      }).Start();
    }

    public static void Maximo(this int[] array)
    {
      new Thread(t =>{
        console.WriteLine("Valor Máximo é: " + array.Max());
      }).Start();
    }
  }
}
