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
         
