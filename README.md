# ExercicioAula01

## Descri��o

Este projeto � um sistema simples de cadastro de funcion�rios desenvolvido em C# (.NET 9). O objetivo � coletar dados de funcion�rios via console, armazen�-los em um arquivo de texto e permitir o cadastro de m�ltiplos funcion�rios em sequ�ncia.

## Funcionalidades

- Cadastro de funcion�rios via interface de console.
- Armazenamento dos dados em arquivo de texto (`c://temp/funcionarios.txt`).
- Cria��o autom�tica do diret�rio de exporta��o, se necess�rio.
- Permite cadastrar m�ltiplos funcion�rios em uma mesma execu��o.

## Estrutura do Projeto

- **Entities/Funcionario.cs**: Define a entidade `Funcionario` com propriedades como Id, Nome, CPF, Matr�cula, Data de Admiss�o, Cargo e Sal�rio.
- **Controllers/FuncionarioController.cs**: Gerencia o fluxo de cadastro, coleta os dados do usu�rio e chama o reposit�rio para exporta��o.
- **Repositories/FuncionarioRepository.cs**: Respons�vel por exportar os dados do funcion�rio para o arquivo de texto.
- **Program.cs**: Ponto de entrada do sistema, controla o loop de cadastro e finaliza��o do programa.

## Como Executar

1. Certifique-se de ter o .NET 9 instalado.
2. Compile e execute o projeto.
3. Siga as instru��es no console para cadastrar os funcion�rios.
4. Os dados ser�o salvos em `c://temp/funcionarios.txt`.

## Exemplo de Uso

Ao executar o programa, ser� solicitado:

INFORME OS DADOS DO FUNCION�RIO ABAIXO:
NOME .................: 
CPF ..................: 
MATRICULA ............: 
DATA DE ADMISS�O .....: 
CARGO ................: 
SAL�RIO ..............:

Ap�s o cadastro, os dados ser�o exportados e voc� poder� optar por cadastrar outro funcion�rio ou finalizar o programa.

## Requisitos

- .NET 9
- Permiss�o de escrita no diret�rio `c://temp`

## Observa��es

- O arquivo de exporta��o � sobrescrito a cada execu��o, mantendo o hist�rico dos funcion�rios cadastrados.
- O formato da data de admiss�o � `dd/MM/yyyy HH:mm:ss`.
