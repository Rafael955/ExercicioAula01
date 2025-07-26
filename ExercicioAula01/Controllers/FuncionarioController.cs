using ExercicioAula01.Entities;
using ExercicioAula01.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula01.Controllers
{
    public class FuncionarioController
    {
        public void ExportarDados()
        {
            Console.WriteLine("\nPROGRAMA CADASTRO DE FUNCIONARIOS\n");

            Console.WriteLine("INFORME OS DADOS DO FUNCIONÁRIO ABAIXO:\n");

            Funcionario funcionario = new Funcionario();

            funcionario.IdFuncionario = Guid.NewGuid();

            Console.Write("NOME .................: ");
            funcionario.Nome = Console.ReadLine() ?? string.Empty;

            Console.Write("CPF ..................: ");
            funcionario.Cpf = Console.ReadLine() ?? string.Empty;

            Console.Write("MATRICULA ............: ");
            funcionario.Matricula = Console.ReadLine() ?? string.Empty;

            Console.Write("DATA DE ADMISSÃO .....: ");
            funcionario.DataAdmissao = Convert.ToDateTime(Console.ReadLine());

            Console.Write("CARGO ................: ");
            funcionario.Cargo = Console.ReadLine() ?? string.Empty;

            Console.Write("SALÁRIO ..............: ");
            funcionario.Salario = Convert.ToDecimal(Console.ReadLine());

            FuncionarioRepository funcionarioRepository = new FuncionarioRepository();
            funcionarioRepository.ExportarDados(funcionario);

            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine("DADOS DO FUNCIONÁRIO CADASTRADO COM SUCESSO!");
        }
    }
}
