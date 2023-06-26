using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    public class Exercicio5 : IExercise
    {
        public void Execute()
        {
            Console.WriteLine("Informe uma string qualquer: ");
            var input = Console.ReadLine() ?? "";
            Console.WriteLine(HasInteger(input)?"Possui inteiro válido": "Não possui inteiro válido");
        }

        public bool HasInteger(string input)
        {
            int number;
            foreach(char c in input)
                if(int.TryParse(c.ToString(), out number))
                    return true;
            return false;
        }
    }
}
