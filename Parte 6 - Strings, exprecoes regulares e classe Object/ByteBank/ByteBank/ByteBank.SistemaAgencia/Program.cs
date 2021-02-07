using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //string padrao = "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
            //string padrao = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
            //string padrao = "[0-9]{4,5}[-]{0,1}[0-9]{4}"; // O {} se chama quantificador
            //string padrao = "[0-9]{4,5}-{0,1}[0-9]{4}"; 
            string padrao = "[0-9]{4,5}-?[0-9]{4}"; 
            string textoDeTeste = "Me liguem em 94002-8922";

            //Expressões regulares: REGEX (regular expressions)
            Console.WriteLine(Regex.IsMatch(textoDeTeste, padrao));
            Match resultado = Regex.Match(textoDeTeste, padrao);

            Console.WriteLine(resultado.Value);


            Console.ReadLine();



            string urlTeste = "https://www.byteBank.com.br/cambio";
            int indiceByteBank = urlTeste.IndexOf("https://www.byteBank.com.br");

            Console.WriteLine(urlTeste.StartsWith("https://www.byteBank.com.br"));
            Console.WriteLine(urlTeste.EndsWith("cambio"));
            Console.WriteLine(urlTeste.Contains("bytebank"));

            Console.ReadLine();





            // --------------
            string palavra = "moedaOrigem=real&moedaDestino=dolar";
            string nomeArgumento = "moedaOrigem";

            string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&Valor=10";
            ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(urlParametros);

            string valor = extratorDeValores.GetValor("moedaOrigem");
            Console.WriteLine("Valor de moedaOrigem " + valor);

            string valor2 = extratorDeValores.GetValor("moedaDestino");
            Console.WriteLine("Valor de moedaDestino " + valor2);

            Console.WriteLine(extratorDeValores.GetValor("VALOR"));

            var teste = nomeArgumento.Substring(0, 2);
            Console.WriteLine(teste);



            //string testeRemocao = "primeiraParte&parteParaRemover";
            //int indiceEComercial = testeRemocao.IndexOf('&');
            //Console.WriteLine(testeRemocao.Remove(indiceEComercial));

            Console.ReadLine();



            int indice = palavra.IndexOf(nomeArgumento);

            Console.WriteLine("Tamanho da string noomeArgumento: " + nomeArgumento.Length);

            Console.WriteLine(palavra);
            Console.WriteLine(palavra.Substring(indice));
            Console.WriteLine(palavra.Substring(indice + nomeArgumento.Length + 1));


            Console.ReadLine();






            string url = "pagina?moedaOrigem=real&moedaDestino=dolar";
            int indiceInterrogacao = url.IndexOf('?');

            Console.WriteLine(indiceInterrogacao);


            Console.WriteLine(url);
            string argumentos = url.Substring(indiceInterrogacao + 1); //Substring de um caracter a partir da posição 6
            Console.WriteLine(argumentos);


            Console.ReadLine();
        }
    }
}
