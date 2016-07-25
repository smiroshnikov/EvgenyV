using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lim
{
    class Program
    {


        public static void generateGameField(int[] gameField)
        {

            for (int i = 0; i < gameField.Length; i++)
            {
                Random random = new Random();

                gameField[i] = random.Next(1, 7);
            }
        }

        public static void drawGameField(int[] gameField)
        {
            for (int i = 0; i < gameField.Length; i++)
            {
                Console.WriteLine(
                    (i + 1).ToString() + "." +
                    new String('*', gameField[i]));
            }
        }

        public static void updateGameField(int[] gameField, int lineNumber, int asterisks)
        {
            gameField[lineNumber] -= asterisks;
        }

        public static void user_input
            (int[] gameField)
        {
            bool validInput = false;
            int lineNumber = 0;

            while (validInput != true)
            {
                Console.WriteLine("Please enter line number");
                lineNumber = Convert.ToInt16(Console.ReadLine()) - 1;
                if (lineNumber < 0 || (lineNumber >= gameField.Length))
                {
                    Console.WriteLine("Invalid input!!!.. Please enter a valid value!");
                    continue;
                }
                else validInput = true;

            }
            while (validInput != true)
            {
                Console.WriteLine("Please enter amount of asterisks to remove");

                int asterisks = Convert.ToInt16(Console.ReadLine());
                if (asterisks <= 0 || asterisks > gameField[lineNumber]) // Line number was not initialized ! had to assign 0 
                {
                    Console.WriteLine("Invalid number of asterisks!");
                    continue;
                }
                else validInput = true;
            }
        }



        static void Main(string[] args)
        {
            int[] gameField = new int[3];

            // main loop 
            generateGameField(gameField);
            drawGameField(gameField);
            user_input(gameField);
            //updateGameField(gameField,lineNumber,asterisks);    
            //drawGameField(gameField);



        }



    }
}
