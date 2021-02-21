using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public static class ListExtencoes
    {
        public static void AdicionarVarios(this List<int> listaDeInteiros, params int[] itens)
        {
            foreach (var item in itens)
            {
                listaDeInteiros.Add(item);
            }
        }

        public static void EscreverNaTela(this object obj)
        {
            Console.WriteLine(obj);
        }
    }
}
