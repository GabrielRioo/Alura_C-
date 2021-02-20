using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista<int> idades = new Lista<int>();

            idades.Adicionar(5);
            idades.Adicionar(50);
            idades.AdicionarVarios(20, 30);
            

            Console.ReadLine();
        }

        static void TestaListaDeObject()
        {
            //Console.WriteLine(SomarVarios(1, 2, 3, 4, 5, 6) );
            ListaDeObject listaDeIdades = new ListaDeObject();

            listaDeIdades.Adicionar(10);
            listaDeIdades.Adicionar(6);
            listaDeIdades.Adicionar(40);
            listaDeIdades.Adicionar(23);
            listaDeIdades.AdicionarVarios(23, 6, 78, 3);

            for (int i = 0; i < listaDeIdades.Tamanho; i++)
            {
                int idade = (int)listaDeIdades[i];
                Console.WriteLine($"Idade no indice {i}: {idade}");
            }
        }

        static void TestaContaCorrente()
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente();
            ContaCorrente contaDoGabs = new ContaCorrente(111, 11111111);

            lista.Adicionar(contaDoGabs);

            //lista.Adicionar(new ContaCorrente(845, 456789));
            //lista.Adicionar(new ContaCorrente(845, 456788));

            ContaCorrente[] contas = new ContaCorrente[]
            {
                contaDoGabs,
                new ContaCorrente(845, 456789),
                new ContaCorrente(845, 456788)
            };
            //lista.Adicionar(contas);
            lista.AdicionarVarios(
                contaDoGabs,
                new ContaCorrente(845, 456789),
                new ContaCorrente(845, 456788)
                );

            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente itemAtual = lista[i];
                Console.WriteLine($"Item na posicao {i} = Conta {itemAtual.Numero}/{itemAtual.Agencia}");

            }


            //lista.EscreverListaNaTela();
            //lista.Remover(contaDoGabs);
            //Console.WriteLine("Apos remover o item");
            //lista.EscreverListaNaTela();



            Console.ReadLine();

            ContaCorrente[] contas2 = new ContaCorrente[] {
                new ContaCorrente(845, 456789),
                new ContaCorrente(845, 794567),
                new ContaCorrente(845, 461234)
            };

            for (int indice = 0; indice < contas.Length; indice++)
            {
                ContaCorrente contaAtual = contas[indice];
                Console.WriteLine($"Conta {indice} {contaAtual.Numero}"); // $ = interpolaçao
            }
        }
        static int SomarVarios(params int[] numeros)
        {
            int acumulador = 0;
            foreach (var numero in numeros)
            {
                acumulador += numero;
            }
            return acumulador;
        }
        static void TestaArrayInt()
        {
            //Array de inteiros com 5 posições
            int[] idades = new int[5];

            idades[0] = 15;
            idades[1] = 21;
            idades[2] = 51;
            idades[3] = 84;
            idades[4] = 76;

            int acumulador = 0;
            for (int indice = 0; indice < idades.Length; indice++)
            {
                int idade = idades[indice];

                Console.WriteLine($"Acessando o array idades no indice {indice}");
                Console.WriteLine($"Valor de idades[{indice}] = {idades}");

                acumulador += idade;

            }
            int media = acumulador / idades.Length;
            Console.WriteLine($"Media de idades = {media}");
            //Console.WriteLine(idades[4]);
        }
    }
}
