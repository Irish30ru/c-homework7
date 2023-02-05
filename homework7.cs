// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет



Console.Write("Введите длину массива = ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите ширину массива = ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию числа по длине = ");
int l = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию числа по ширине = ");
int p = Convert.ToInt32(Console.ReadLine());



// double[,] nums = new double[x,y];
string result;

string craete_two_demensional_array(int m, int n, int posit1, int posit2)
{
    int[,] nums = new int[x, y];
    for (int i = 0; i < nums.GetLength(0); i++)
    {
        for (int j = 0; j < nums.GetLength(1); j++)
        {
            nums[i, j] = new Random().Next(10, 100);
            Console.Write($"{nums[i, j]} ");
        }
        Console.WriteLine();
    }
    // result = string.Join(", ", nums);
    // return result;
    Console.WriteLine();
    for (int i = 0; i < nums.GetLength(0); i++)
    {
        if (i == posit1-1)
        {
            for (int j = 0; j < nums.GetLength(1); j++)
            {
                if (nums[i, j] == nums[posit1-1,posit2-1])
                {

                    Console.Write($"{nums[i,j]} -> такое число есть ");
                    break;
                    
                }
                else if(j+1==n)
                {
                    Console.Write("Такого числа нет ");
                    
                }
                else if(posit2>j+n)
                {
                    Console.Write("Такого числа нет ");
                    break;
                }
                else
                {
                    continue;
                }

            }
        }
        else if(posit1>i+m)
        {
            Console.Write("Такого числа нет ");
            break;
        }

        
        
        else
        {
            continue;
        }


        Console.WriteLine();

    }
    result = string.Join(", ", nums);
    return result;
}
Console.WriteLine(craete_two_demensional_array(x, y, l, p));




