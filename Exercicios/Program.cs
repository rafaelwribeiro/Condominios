namespace Exercicios;

public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            IExercise? process = GetProcess();
            if (process == null)
                break;
            process.Execute();

            Console.ReadLine();
            Console.Clear();
        }
    }

    private static IExercise? GetProcess()
    {
        Console.WriteLine("Digite um número entre 1 e 6: ");
        var input = Console.ReadLine();
        if (!int.TryParse(input, out int number))
        {
            Console.WriteLine("Input inválido.");
            return null;
        }
        switch(number)
        {
            case 1: return new Exercicio1();
            case 2: return new Exercicio2();
            case 3: return new Exercicio3();
            case 4: return new Exercicio4();
            case 5: return new Exercicio5();
            case 6: return new Exercicio6();
        }
        return null;
    }
}