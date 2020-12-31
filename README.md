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
   
* OBJETO:
   * Com uma classe, tem a possibilidade de representa-la em diversas partes do codigo
   * O valo padrão pode ser alterado, atribuindo um valor a variavel de uma classe:
      * `public double saldo = 100.0;`
   * Tipo Valor: Guarda só o valor na memoria
   * Tipo Referencia: Quando se tem uma classe, é um tipo de referencia
      * A variavel guarda o **endereço** do de um novo objeto
