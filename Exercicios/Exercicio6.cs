namespace Exercicios
{
    public class Exercicio6 : IExercise
    {
        public void Execute()
        {
            Console.WriteLine("Informe um número válido (qualquer valor não número será considerado o número 10: ");
            var input = Console.ReadLine(); ;
            int number;
            if (!int.TryParse(input, out number))
                number = 10;
            var result = CalcFact(number);
            Console.WriteLine($"Resultado: {result}");
            
        }

        private long CalcFact(int number)
        {
            if(number == 0)
                return 1;
            return number * CalcFact(--number);
        }
    }
}
