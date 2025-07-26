using ExercicioAula01.Controllers;
using ExercicioAula01.Entities;
using ExercicioAula01.Repositories;

public partial class Program
{
    public static void Main(string[] args)
    {
        FuncionarioController funcionarioController = new FuncionarioController();
        funcionarioController.ExportarDados();

        Console.WriteLine("\nDESEJA CONTINUAR? [S, N]");
        string? continuar = Console.ReadLine()?.ToUpper();

        if (continuar == "S")
        {
            Console.Clear();
            Main(args);
        }
        else
        {
            Console.WriteLine("\nFINALIZANDO O PROGRAMA...");
            Thread.Sleep(2000);
        }
    }
}