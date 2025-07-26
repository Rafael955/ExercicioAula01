# ExercicioAula01

## Descrição

Este projeto é um sistema simples de cadastro de funcionários desenvolvido em C# (.NET 9). O objetivo é coletar dados de funcionários via console, armazená-los em um arquivo de texto e permitir o cadastro de múltiplos funcionários em sequência.

## Funcionalidades

- Cadastro de funcionários via interface de console.
- Armazenamento dos dados em arquivo de texto (`c://temp/funcionarios.txt`).
- Criação automática do diretório de exportação, se necessário.
- Permite cadastrar múltiplos funcionários em uma mesma execução.

## Estrutura do Projeto

- **Entities/Funcionario.cs**: Define a entidade `Funcionario` com propriedades como Id, Nome, CPF, Matrícula, Data de Admissão, Cargo e Salário.
- **Controllers/FuncionarioController.cs**: Gerencia o fluxo de cadastro, coleta os dados do usuário e chama o repositório para exportação.
- **Repositories/FuncionarioRepository.cs**: Responsável por exportar os dados do funcionário para o arquivo de texto.
- **Program.cs**: Ponto de entrada do sistema, controla o loop de cadastro e finalização do programa.

## Como Executar

1. Certifique-se de ter o .NET 9 instalado.
2. Compile e execute o projeto.
3. Siga as instruções no console para cadastrar os funcionários.
4. Os dados serão salvos em `c://temp/funcionarios.txt`.

## Exemplo de Uso

Ao executar o programa, será solicitado:

INFORME OS DADOS DO FUNCIONÁRIO ABAIXO:
NOME .................: 
CPF ..................: 
MATRICULA ............: 
DATA DE ADMISSÃO .....: 
CARGO ................: 
SALÁRIO ..............:

Após o cadastro, os dados serão exportados e você poderá optar por cadastrar outro funcionário ou finalizar o programa.

## Requisitos

- .NET 9
- Permissão de escrita no diretório `c://temp`

## Observações

- O arquivo de exportação é sobrescrito a cada execução, mantendo o histórico dos funcionários cadastrados.
- O formato da data de admissão é `dd/MM/yyyy HH:mm:ss`.
