using System.Linq.Expressions;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is my favorite number?");
            int userGuess = int.Parse(Console.ReadLine());
            var myFavoriteNum = 8;

            if (userGuess < 8)
            {
                Console.WriteLine("Wrong guess less");
            }
            else if (userGuess > 8)
            {
                Console.WriteLine("Wrong guess more");
            }

            else (userGuess == myFavoriteNum)
                    {

                Console.WriteLine(" You got it");
            }
            }

            

            }
        }
    }

