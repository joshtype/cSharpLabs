using System;
using System.Reflection.Metadata.Ecma335;

// Lab 1: C# 2d array manipulation
// Joshua Gregory, May 2024
// Use 2d char arrays to create an ascii car and its reverse image.
// Display the cars separately and side by side.

namespace Lab1_JoshuaGregory
{
    internal class Program
    {
        // Return 2d char arr of 4 rows x 14 cols
        public static char[,] make_forward()
        {
            char[,] pixel = new char[4, 13];
            // row 0
            pixel[0, 0] = ' ';
            pixel[0, 1] = ' ';
            pixel[0, 2] = '_';
            pixel[0, 3] = '_';
            pixel[0, 4] = '_';
            pixel[0, 5] = '_';
            pixel[0, 6] = '_';
            pixel[0, 7] = '_';
            pixel[0, 8] = ' ';
            pixel[0, 9] = ' ';
            pixel[0, 10] = ' ';
            pixel[0, 11] = ' ';
            pixel[0, 12] = ' ';
            // row 1
            pixel[1, 0] = ' ';
            pixel[1, 1] = '/';
            pixel[1, 2] = '|';
            pixel[1, 3] = '_';
            pixel[1, 4] = '|';
            pixel[1, 5] = '|';
            pixel[1, 6] = '_';
            pixel[1, 7] = '\\';
            pixel[1, 8] = '\'';
            pixel[1, 9] = '.';
            pixel[1, 10] = '_';
            pixel[1, 11] = '_';
            pixel[1, 12] = ' ';
            // row 2
            pixel[2, 0] = '(';
            pixel[2, 1] = ' ';
            pixel[2, 2] = ' ';
            pixel[2, 3] = ' ';
            pixel[2, 4] = '_';
            pixel[2, 5] = ' ';
            pixel[2, 6] = ' ';
            pixel[2, 7] = ' ';
            pixel[2, 8] = ' ';
            pixel[2, 9] = '_';
            pixel[2, 10] = ' ';
            pixel[2, 11] = '_';
            pixel[2, 12] = '\\';
            // row 3
            pixel[3, 0] = '=';
            pixel[3, 1] = '\'';
            pixel[3, 2] = '-';
            pixel[3, 3] = '(';
            pixel[3, 4] = '_';
            pixel[3, 5] = ')';
            pixel[3, 6] = '-';
            pixel[3, 7] = '-';
            pixel[3, 8] = '(';
            pixel[3, 9] = '_';
            pixel[3, 10] = ')';
            pixel[3, 11] = '-';
            pixel[3, 12] = '\'';
            return pixel;
        }

        // iterate 2d arr, reverse column indices, return reversed arr
        public static char[,] make_mirror(char[,] carArr)
        {
            // new 2d char arr with each row reversed
            char[,] revArr = new char[4,13];
            // row 0 (car roof)
            revArr[0,0] = carArr[0,12];
            revArr[0,1] = carArr[0,11];
            revArr[0,2] = carArr[0,10];
            revArr[0,3] = carArr[0,9];
            revArr[0,4] = carArr[0,8];
            revArr[0,5] = carArr[0,7];
            revArr[0,6] = carArr[0,6];
            revArr[0,7] = carArr[0,5];
            revArr[0,8] = carArr[0,4];
            revArr[0,9] = carArr[0,3];
            revArr[0,10] = carArr[0,2];
            revArr[0,11] = carArr[0,1];
            revArr[0,12] = carArr[0,0];
            // row 1 (car windows)
            revArr[1,0] = carArr[1,12];
            revArr[1,1] = carArr[1,11];
            revArr[1,2] = carArr[1,10];
            revArr[1,3] = carArr[1,9];
            revArr[1,4] = carArr[1,8];
            revArr[1,5] = '/';
            revArr[1,6] = carArr[1,6];
            revArr[1,7] = carArr[1,5];
            revArr[1,8] = carArr[1,4];
            revArr[1,9] = carArr[1,3];
            revArr[1,10] = carArr[1,2];
            revArr[1,11] = '\\';
            revArr[1,12] = carArr[1,0];
            // row 2 (car body & top of wheels)
            revArr[2,0] = '/';
            revArr[2,1] = carArr[2,11];
            revArr[2,2] = carArr[2,10];
            revArr[2,3] = carArr[2,9];
            revArr[2,4] = carArr[2,8];
            revArr[2,5] = carArr[2,7];
            revArr[2,6] = carArr[2,6];
            revArr[2,7] = carArr[2,5];
            revArr[2,8] = carArr[2,4];
            revArr[2,9] = carArr[2,3];
            revArr[2,10] = carArr[2,2];
            revArr[2,11] = carArr[2,1];
            revArr[2,12] = ')';
            // row 3 (car bottom & wheel middles)
            revArr[3,0] = carArr[3,12];
            revArr[3,1] = carArr[3,11];
            revArr[3,2] = '(';
            revArr[3,3] = carArr[3,9];
            revArr[3,4] = ')';
            revArr[3,5] = carArr[3,7];
            revArr[3,6] = carArr[3,6];
            revArr[3,7] = '(';
            revArr[3,8] = carArr[3,4];
            revArr[3,9] = ')';
            revArr[3,10] = carArr[3,2];
            revArr[3,11] = carArr[3,1];
            revArr[3,12] = carArr[3,0];
            // return char arr
            return revArr;
        }

        // iterate 2d arr & display each index
        public static void show_each_car(char[,] carArr)
        {
            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 13; col++)
                {
                    Console.Write(carArr[row, col]);
                }
                Console.WriteLine();  // new line after each row
            }
        }

        public static void show_both_cars(char[,] carArr, char[,] revArr)
        {
            char[,] bothCars = new char[4,26];
            // row 0
            bothCars[0,0] = carArr[0,0];
            bothCars[0,1] = carArr[0,1];
            bothCars[0,2] = carArr[0,2];
            bothCars[0,3] = carArr[0,3];
            bothCars[0,4] = carArr[0,4];
            bothCars[0,5] = carArr[0,5];
            bothCars[0,6] = carArr[0,6];
            bothCars[0,7] = carArr[0,7];
            bothCars[0,8] = carArr[0,8];
            bothCars[0,9] = carArr[0,9];
            bothCars[0,10] = carArr[0,10];
            bothCars[0,11] = carArr[0,11];
            bothCars[0,12] = carArr[0,12];
            bothCars[0,13] = revArr[0,0];
            bothCars[0,14] = revArr[0,1];
            bothCars[0,15] = revArr[0,2];
            bothCars[0,16] = revArr[0,3];
            bothCars[0,17] = revArr[0,4];
            bothCars[0,18] = revArr[0,5];
            bothCars[0,19] = revArr[0,6];
            bothCars[0,20] = revArr[0,7];
            bothCars[0,21] = revArr[0,8];
            bothCars[0,22] = revArr[0,9];
            bothCars[0,23] = revArr[0,10];
            bothCars[0,24] = revArr[0,11];
            bothCars[0,25] = revArr[0,12];
            // row 1
            bothCars[1,0] = carArr[1,0];
            bothCars[1,1] = carArr[1,1];
            bothCars[1,2] = carArr[1,2];
            bothCars[1,3] = carArr[1,3];
            bothCars[1,4] = carArr[1,4];
            bothCars[1,5] = carArr[1,5];
            bothCars[1,6] = carArr[1,6];
            bothCars[1,7] = carArr[1,7];
            bothCars[1,8] = carArr[1,8];
            bothCars[1,9] = carArr[1,9];
            bothCars[1,10] = carArr[1,10];
            bothCars[1,11] = carArr[1,11];
            bothCars[1,12] = carArr[1,12];
            bothCars[1,13] = revArr[1,0];
            bothCars[1,14] = revArr[1,1];
            bothCars[1,15] = revArr[1,2];
            bothCars[1,16] = revArr[1,3];
            bothCars[1,17] = revArr[1,4];
            bothCars[1,18] = revArr[1,5];
            bothCars[1,19] = revArr[1,6];
            bothCars[1,20] = revArr[1,7];
            bothCars[1,21] = revArr[1,8];
            bothCars[1,22] = revArr[1,9];
            bothCars[1,23] = revArr[1,10];
            bothCars[1,24] = revArr[1,11];
            bothCars[1,25] = revArr[1,12];
            // row 2
            bothCars[2,0] = carArr[2,0];
            bothCars[2,1] = carArr[2,1];
            bothCars[2,2] = carArr[2,2];
            bothCars[2,3] = carArr[2,3];
            bothCars[2,4] = carArr[2,4];
            bothCars[2,5] = carArr[2,5];
            bothCars[2,6] = carArr[2,6];
            bothCars[2,7] = carArr[2,7];
            bothCars[2,8] = carArr[2,8];
            bothCars[2,9] = carArr[2,9];
            bothCars[2,10] = carArr[2,10];
            bothCars[2,11] = carArr[2,11];
            bothCars[2,12] = carArr[2,12];
            bothCars[2,13] = revArr[2,0];
            bothCars[2,14] = revArr[2,1];
            bothCars[2,15] = revArr[2,2];
            bothCars[2,16] = revArr[2,3];
            bothCars[2,17] = revArr[2,4];
            bothCars[2,18] = revArr[2,5];
            bothCars[2,19] = revArr[2,6];
            bothCars[2,20] = revArr[2,7];
            bothCars[2,21] = revArr[2,8];
            bothCars[2,22] = revArr[2,9];
            bothCars[2,23] = revArr[2,10];
            bothCars[2,24] = revArr[2,11];
            bothCars[2,25] = revArr[2,12];
            // row 3
            bothCars[3,0] = carArr[3,0];
            bothCars[3,1] = carArr[3,1];
            bothCars[3,2] = carArr[3,2];
            bothCars[3,3] = carArr[3,3];
            bothCars[3,4] = carArr[3,4];
            bothCars[3,5] = carArr[3,5];
            bothCars[3,6] = carArr[3,6];
            bothCars[3,7] = carArr[3,7];
            bothCars[3,8] = carArr[3,8];
            bothCars[3,9] = carArr[3,9];
            bothCars[3,10] = carArr[3,10];
            bothCars[3,11] = carArr[3,11];
            bothCars[3,12] = carArr[3,12];
            bothCars[3,13] = revArr[3,0];
            bothCars[3,14] = revArr[3,1];
            bothCars[3,15] = revArr[3,2];
            bothCars[3,16] = revArr[3,3];
            bothCars[3,17] = revArr[3,4];
            bothCars[3,18] = revArr[3,5];
            bothCars[3,19] = revArr[3,6];
            bothCars[3,20] = revArr[3,7];
            bothCars[3,21] = revArr[3,8];
            bothCars[3,22] = revArr[3,9];
            bothCars[3,23] = revArr[3,10];
            bothCars[3,24] = revArr[3,11];
            bothCars[3,25] = revArr[3,12];

            // iterate and display bothCars array
            for(int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 26; col++)
                {
                    Console.Write(bothCars[row, col]);
                }
                Console.WriteLine();  // new line after each row
            }
        }

        static void Main(string[] args)
        {
            // Display cars separately
            show_each_car(make_forward());
            show_each_car(make_mirror(make_forward()));

            // Display cars side by side
            show_both_cars(make_forward(), make_mirror(make_forward()));
        }
    }
}
