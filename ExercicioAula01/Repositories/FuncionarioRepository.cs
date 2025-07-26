using ExercicioAula01.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula01.Repositories
{
    public class FuncionarioRepository
    {
        public void ExportarDados(Funcionario funcionario)
        {
            CriarDiretorioExportacao();

            var caminhoArquivo = $"c://temp/funcionarios.txt";

            using (var writer = new StreamWriter(caminhoArquivo, true))
            {
                writer.WriteLine($"Id: {funcionario.IdFuncionario}");
                writer.WriteLine($"Nome: {funcionario.Nome}");
                writer.WriteLine($"CPF: {funcionario.Cpf}");
                writer.WriteLine($"Matrícula: {funcionario.Matricula}");
                writer.WriteLine($"Data de Admissão: {funcionario.DataAdmissao:dd/MM/yyyy HH:mm:ss}");
                writer.WriteLine($"Cargo: {funcionario.Cargo}");
                writer.WriteLine($"Salário: {funcionario.Salario:C}");
                writer.WriteLine(new string('-', 50));
            }
        }

        private void CriarDiretorioExportacao()
        {
            if (!Directory.Exists("c://temp"))
            {
                Directory.CreateDirectory("c://temp");
            }
        }
    }
}
