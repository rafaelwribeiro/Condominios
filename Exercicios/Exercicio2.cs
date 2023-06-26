using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    public class Exercicio2 : IExercise
    {
        public void Execute()
        {
            char[,] matrix = ReadMatrix();

            Console.WriteLine("Matriz gerada:");
            PrintMatrix(matrix);
            bool allVowelsPresent = CheckAllVowels(matrix);

            if (allVowelsPresent)
                Console.WriteLine("Todas as vogais estão presentes na matriz.");
            else
                Console.WriteLine("Algumas vogais estão faltando.");
        }

        private char[,] ReadMatrix()
        {
            int rows = 4, cols = 4;
            char[,] matrix = new char[rows, cols];
            Random random = new Random();

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    matrix[i, j] = Convert.ToChar(random.Next(65, 91));

            return matrix;
        }

        private void PrintMatrix(char[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                {
                    char el = matrix[i, j];
                    Console.Write(el + " ");
                }
                Console.WriteLine();
        }


        private bool CheckAllVowels(char[,] matrix)
        {
            string vowels = "aeiou";

            for (int i = 0; i < matrix.GetLength(0); i++)
            
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    char character = char.ToLower(matrix[i, j]);

                    if (vowels.Contains(character))
                    {
                        vowels = vowels.Remove(vowels.IndexOf(character), 1);

                        if (vowels.Length == 0)
                        {
                            return true;
                        }
                    }
                }
            

            return false;
        }
    }
}
