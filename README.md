# Alura .NET

**Rodar uma Aplicação no Bloco de Notas:** (sempre compilar e executar, após uma modificação)
* CMD:
   * Ir para pasta onde está o arquivo `.txt`
   * Compilar: `c:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe MeuPrimeiroPrograma.txt`
   * Será gerado um arquivo `.exe`
   * Executar: `MeuPrimeiroPrograma.exe`
   * Irá rodar o programa e aparecer no Prompt
   
* DICAS:
   * **Return:** Após o return de uma condição, tudo que vem abaixo nao é executado
   * Sempre por a condição que pod falhar primeiro.
   * Valor Padrão:
      * int = 0
      * Tipo de referencia `public Cliente titular` = null
   * Ao utilizar o `_saldo` underline antes do campo, quer dizer que ela é privada e pertence somente aquela classe.
   * Por padrão um construtor `public int Cliente { get; set; }` cria um metodo privado por tras.
   * **SobreCargas de Métodos:** Uma classe pode ter dois métodos com mesmo nome, porem com parametros diferentes.
   * **SobrePosição**: Uma classe mais derivada(filha) pode sobreescrever um método 
      * **virtual**: Habilita a sobrescrita do método `public virtual double GetBonificacao() {} `
      * **override**: o método que irá sobrescrever `public override double GetBonificacao() {} `
   * Syntax Sugar(Açucar Sintatico): Simplificação e manipulação por parte do compilador `{ get; set; }`
   * **Polimofismo**: Na varivel base um objeto especializado. `Funcionario gabriel = new Diretor();`
   * **StackOverflow**: Quando estoura a pilha de memoria guardada pelo programa.
   * **base.** : chama o metodo da classe base (herança)  `return Salario + base.GetBonificacao();` 
   * O Construtor da classe base sempre será executado antes do contrutor da classe derivada(filha)
   * Não é possivel instanciar um método de instancia em um metodo static. Solução:
      * Tornar o metodo de instancia em static: `public static void Calcular(){}` <-> **Mais usual**
      * Criar uma nova instancia do class: `Program programa = new Program(); programa.CalcularBonificacao();`
   * Metodos abstrados só podem pertencer a classes abstratas
   * `object`: 
      * Quando uma classe nao esta herdando nada, ela deriva de `object`.
   * `Concatenação de String`:
      * `$"Numero: {Numero}, Agencia {Agencia}, Saldo {Saldo}";`
      * `"Numero: " + Numero + " Agencia " + Agencia + ", Saldo " + Saldo`
   * `Conversão`
      * `Explicita`: (Cliente)obj - Lança uma exceção
      * `Cast`: obj as Cliente - retorna null quando o cast nao e feito com sucesso
   * `Array`: O valor padrao de um array é 0;
      * `int[] idades = new int[5]` - é necessário informar o tamanho do array
         * `contas[0] = new ContaCorrente(845, 456789);`
      * Outra maneira: 
         * `ContaCorrente[] contas = new ContaCorrente[] {` `new ContaCorrente(845, 456789), new ContaCorrente(845, 794567) }`
   * Parametros nao obrigatorios:
      * `ListaDeContas lista = new ListaDeContas(int saldo = 100)` - ja inicializando o argumento 
      * Para alterar metodos com dois parametros opcionais: `lista.MeuMetodo(saldo: 200)`
   * `Indexador`:
      * `public ContaCorrente this[int indice] { get { return null } }`
   * Passando multiplos argumentos(parametros)
      * `params`: `public void AdicionarVarios( params ContaCorrente[] itens)`
   * Nomear Parametros: `Adicionar(item: 10)`
   * `List`
      * `.Add()`
      * `.Remove()`
      * `.Count` = tamanho da lista
      * `.AddRange(new int[] { 1, 2, 3, 4, 5 });`
      * `.Sort()` - ordena em ordem crescente.
         * `IComparable`: comparra dois valores de um objeto (parte 8)
         * `IComparer`: `x.Agencia.CompareTo(y.Agencia);` (parte 8)
            * Retorna Negativo quando a instacia precede obj;
            * Retorna zero quando nossa instancia e obj forem equivalentes;
            * Retorna positivo diferente de zero quando precedencia for de objj;
   * **Metodo de Extenção:**
      * `public static void AdicionarVarios(this List<int> listaDeInteiros, params int[] itens)` - Uso do This
      * Ao ser feito isso, esse metodo podera ser instaciado no main
   * **Metodo de Extenção Generico**:
      * `public static void AdicionarVarios<T> (this List<T> lista, params T[] itens)` : Informar o `<T>` no metodo ao inves de ser na classe
  
   


* OBJETO:
   * Com uma classe, tem a possibilidade de representa-la em diversas partes do codigo
   * O valo padrão pode ser alterado, atribuindo um valor a variavel de uma classe:
      * `public double saldo = 100.0;`
   * Tipo Valor: Guarda só o valor na memoria
   * Tipo Referencia: Quando se tem uma classe, é um tipo de referencia
      * A variavel guarda o **endereço** do de um novo objeto
   * `Private`: Visível apenas dentro da classe.
   * `Protected`: Acessivel tanto pela classe base quanto de suas derivadas (relacionado com a herança), porem nao é acessivel fora dessa hierarquia.
   * `Public`: Visivel em todo lugar.
   * `abstract`: Não permite instanciar um objeto da classe abstrata
      * As classes derivadas devem SEMPRE sobrescrever **metodos** abastrados
      * Metodos abstrados só podem pertencer a classes abstratas
      * Metodos abstrratos são obrigatorios de serem implementados em classes filhas
      * Se nao quiser implementar os metodos abstrados em uma classe concreta, mudar a visualização dela para `public abstract class`
   * `interface`: Permite que tenha herança multipla. `public interface Carro { }`
      * **Ordem de Herança Multipla**: Classe, interface
      * Nunca pode ter a implementação de um método. `void AbrirPorta(); `
      * Todos seus membros ja são publicos
   * `Try/Catch`: 
      * `throw`: passa adiante. Quando posto no catch, funciona como um "continue"
         * Util se o metodo retornar um inteiro, e nao precisar retornar -1
      * Pode ter mais de um catch, porém tem que ser antes da classe Exception
         * Classes de exceções chamadas antes da classe exception,, nao serão compilados
   * `Readonly`:
      * Somento o contrutor consegue atribuir um valor
      * `private readonly int _numero;`
      * **Forma simplificada** - `public int Numero { get; }`
   * `ArgumentException`:
      * `Console.WriteLine("Argumento com problema: " + ex.ParamName`: designa a variavel que irá aparecer.
         * `throw new ArgumentException("O argumento com problema é o: " + nameof(nomeParametro))`
            * `nameof(nomeParametro)`: operador do c#
   * Criando uma Exceção:
      * Sempre por o sufixo: `Exception`
      * Sempre criar os 3 contrutores:
         * Sem parametro
         * Com a mensagem
         * Mensagem + Exception variavel
   * `Finally`: Ocorre **sempre**, tanto depois do catch quanto do try.
   * `using()`: chama por baixo dos panos o metodo `try finally` e verifica se a referencia(objeto) é nulo
      * Liberar os recursos do objeto criado
      * `using (LeitorDeArquivos leitor = new LeitorDeArquivos("teste.txt"))`
         * Necessário implementar a interface `IDisposeble` na classe.
         
    * `internal`: classes internas funcionam  para outras classes e somente dentro do projeto em que esta. Sao visiveis somente na biblioteca
       * `internal class ...`
       *  Quando nao declara nenhum modificador de acesso, por padrão é internal
       
    * `internal protected`: Visivel dentro do projeto e qualquer classe que deriva dessa classe (mesmo em outro peojeto)
        * Os métodos que irão sobreescrever nao devem possuir o internal
           * `protected override double Metodo()`
           
    * Como Criar Bibliotecas Estaveis:
       * Ao criar um projeto e compilar, o Visual Studio gera dentro da pasta Bin, uma dll instavel, pois sempre ao compilar, ela é modificada
       * Copiar essa dll e colar em uma pasta separada para que ela possa ser estavel
       * No novo projeto, adiconar referencia e procurar a nova pasta com a dll

    * Documentando Metodos e Classes:
       * `///` - tudo que estiver entre o `/// <sumary>` será descrito ao passar o mouse por cima da instancia
       * `<summary>` : Documentação para classe
       * `<see cref="">` : Funciona com propriedades, classe...
       * `<exception cref="NomeExceção">` Documentação para as exceções
       * `param name=""`: Documentação para o parametro
       * `paramref name=""`: Referencia para o valor do parametro
       * Para a documentação ser "vista" em outros projetos por meio de referencia:
          * Clicar com botão direito no projeto -> propriedades -> Build/Compilação -> Habilitar: Arquivo de Documentação XML
          * Recompilar projeto, ir na pasta bin e copiar o arquivo XML 
          * Passar o arquivo XML para pasta de bibliotecas e reabrir a nova solução.
          
    * `TimeSpan`: Intervalo de tempo
    * `.IndexOf('?')` : pega o indice do caracter especificado. Quando nao encontra o char, retorna -1
    * `.Substring(7)` : caracteres a partir de tal posição, inclusive
    * `.Replace('r', 'R')` : substitui o primeiro caracter pelo segundo
    * `.ToUpper()` : Deixa toda string/char em maiusculo
    * `ToLower()` : Deixa tudo em minusculo
    * `.StartsWith("string")` : String começa com...
    * `.EndsWith("string")` : String termina com...
    * `.Contains("string")` : Se contem a string digitada
    * `Regex.Match(texto, padrao)`: Verifica e retorna o valor especificado.
       * texto: Me ligue no telefone 4002-8922
       * padrao: `"[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]"`
       * regex: `[0123456789] &[a-z]` & `[0-9]` & `[0-9]{4}` = 4 vezes
       * `IsMatch()` - retorna se é true ou false
    * Tipos Genericos: `public class Lista<T>`
    * **LINQ**
       * `.OrderBy(conta => conta.Numero)` - ordenar
       * `.Where(conta => conta != null)` - filtro
