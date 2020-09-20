using System;
using System.Linq;

namespace Assignment_2_Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hangman");

            static string secretWords()
            {
                Random wordNumber = new Random();
                char[] chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
                secretWord = Random.chars[];

                foreach (secretWord in chars)
                {
                    Console.WriteLine(secretWord);
                }
                guessedWord = Console.ReadLine()
                       foreach (guessedWord not in secretWord)
                    incorrectWord[] = guessedWord
                       StringBuilder sb = new StringBuilder();
                ab.AppendFormat("{0}", " incorrectWordd")




            bool keepLooping = true;
                do
                {

                    Console.WriteLine("Please select the game type:\nEnter 1 mean you will gusess for a specific letter.\nEnter 2 mean you will guess for the whole word.");
                    Console.ReadKey();

                    Console.WriteLine("Remember: Each game you will have 10 chances to guess the right word, otherwise you will lose the game.");
                    Console.ReadKey();


                    int SingleWordGuessNums = 10;
                    while (SingleWordGuessNums > 0)
                    {
                        string playerGuessLetter = Console.ReadLine();
                    }
                    String gameType = Console.ReadLine();


                    switch (gameType)
                    {
                        case "1":

                            Console.WriteLine("Please guess for a specific letter");
                            Console.WriteLine("The letters are: ABCDEFGHIJKLMNOPQRSTUVWXYZ, please input your letter by writing capital letter");
                            case1guessedword = Console.ReadLine();

                            break,
                    case "2":
                            Console.WriteLine("Please guess for the whole word");
                            Console.WriteLine("The letters are: ABCDEFGHIJKLMNOPQRSTUVWXYZ, please input your word by writing capital letter");
                            case2guessedword = Console.ReadLine();
                            if (case2guessedword == secretWord)
                                Console.ReadLine();
                            else
                                Console.WriteLine("Not correct");

                            break;

                    }
                }
        }
}
      
                

    
         
        
                    


