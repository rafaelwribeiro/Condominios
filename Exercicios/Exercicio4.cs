namespace Exercicios
{
    public class Exercicio4 : IExercise
    {
        public void Execute()
        {
            IList<int> numbers = GetNumberList();
            var squareRoots = ProcessSquareRoots(numbers);
            if (squareRoots.Count > 0)
            {
                Console.WriteLine("Números que são raíz quadrada entre sí:");
                foreach (var num in squareRoots)
                    Console.Write($"{num} ");
            }
            else
                Console.Write("Nenhum número encontrado conforme o requisito");
        }

        private IList<int> ProcessSquareRoots(IList<int> numbers)
        {
            var squareRoots = new List<int>();
            foreach (var i in numbers )
                foreach(var j in numbers)
                    if(Math.Sqrt(i) == j)
                        squareRoots.Add(i);
            return squareRoots;
        }

        private IList<int> GetNumberList()
        {
            Console.WriteLine("Digite quantos número desejar");
            Console.WriteLine("(quando quiser finalizar a lista de número basta digitar qualquer valor não numérico)");
            Console.Write("->");
            var numbers = new List<int>();

            while (true)
            {
                var input = Console.ReadLine();
                if (!int.TryParse(input, out int number))
                    break;
                numbers.Add(number);
            }
            return numbers;
        }
    }
}
