using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//#Task #10.
//Найти минимальное, максимальное и среднее значение в //массиве целых чисел
//Найти количество различных элементов в массиве целых чисел
namespace Пробую_знания_по_курсу
{
    class Program
    {
        static void Main(string[] args)
        {
            bool d = true;

            Console.WriteLine("Введите размерность матриц по строкам: ");
            int row = System.Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите размерность матриц по столбцам: ");
            int colum = System.Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[row, colum];
            int[,] arr2 = new int[row, colum];


            OneTwoMass(arr, ref row, ref colum, arr2);
            Console.WriteLine("Нажмите любую клавишу, чтобы продолжить: ");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Вы ввели некорректные данные: ");
            Console.WriteLine("Нажмите любую клавишу, чтобы продолжить: ");


            while (d == true)
            {
                Console.WriteLine("введите операцию, которую слудует выполнить\nСложение\nУмножение и номер массива через пробел\nОпределитель\nТранспонирование наберите через пробел номер нужной матрицы\nВывести все\nИли же Выход: ");
                string r = Console.ReadLine();
                switch (r)
                {
                    case "Сложение":
                        d = false;
                        Summ(arr, arr2, ref row, ref colum);
                        break;

                    case "Умножение 1":
                        d = false;
                        Multipul(arr, ref row, ref colum);
                        break;
                    case "Умножение 2":
                        d = false;
                        Multipul(arr2, ref row, ref colum);
                        break;
                        
                    case "Транспонирование 1":
                        d = false;
                        Trans(arr, ref row, ref colum);
                        break;
                    case "Транспонирование 2":
                        d = false;
                        Trans(arr2, ref row, ref colum);
                        break;

                    case "Определитель":

                        Console.WriteLine("еще не готово :(");
                        Console.WriteLine("Нажмите любую клавишу, для возвращения в выбор действий");
                        Opredelitel(arr, ref row, ref colum);
                        d = true;
                        break;

                    case "Все":
                        Summ(arr, arr2, ref row, ref colum);
                        Multipul(arr2, ref row, ref colum);
                        Multipul(arr2, ref row, ref colum);
                        Trans(arr, ref row, ref colum);
                        Trans(arr2, ref row, ref colum);
                        Opredelitel(arr, ref row, ref colum);
                        break;
                    case "Выход":

                        Environment.Exit(0);
                        d = false;
                        break;


                    default:
                        Console.ReadLine();
                        Console.WriteLine("Вы неправельно ввели команду, попробуйте еще раз");//доделать возврат 
                        d = true;
                        break;                                                                     // r = Console.ReadLine();

                }
                Console.ReadKey();
            }
        }


        public static void OneTwoMass(int[,] a, ref int row, ref int colum, int[,] b)
        {
            try
            {
                Console.WriteLine("Первый массив: ");
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < colum; j++)
                    {
                        Console.WriteLine("Введите число: ");
                        a[i, j] = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введен элемент: {0}", a[i, j]);

                    }
                }

                Console.WriteLine("Введеная матрица: ");
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < colum; j++)
                    {
                        Console.Write(a[i, j] + " ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Второй массив: ");

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < colum; j++)
                    {
                        Console.WriteLine("Введите число: ");
                        b[i, j] = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введен элемент: {0}", b[i, j]);

                    }
                }

                Console.WriteLine("Введеная матрица: ");
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < colum; j++)
                    {
                        Console.Write(b[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Опять залупа какая-то вместо массива");
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Нужно вводить число, дурашка");
            }


        }

        public static void Summ(int[,] a, int[,] b, ref int row, ref int colum)
        {
            try
            {
                Console.WriteLine("Результат сложения: ");

                int[,] summ = new int[row, colum];

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < colum; j++)
                    {
                        summ[i, j] = a[i, j] + b[i, j];
                    }
                }
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < colum; j++)
                    {
                        Console.Write(summ[i, j] + " ");
                    }
                    Console.WriteLine();
                }

            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Опять какая-то залупа");
            }

        }

        public static void Multipul(int[,] a, ref int row, ref int colum)
        {
            bool d = true;
            while (d == true)
            {
                try
                {
                    Console.WriteLine("Введите число, на которое вы хотите умножить матрицу\nили символ для дальнейших инструкций по выходу: ");
                    int u = int.Parse(Console.ReadLine());
                    int[,] c = new int[row, colum];

                    for (int i = 0; i < row; i++)
                    {
                        for (int j = 0; j < colum; j++)
                        {
                            c[i, j] = a[i, j] * u;
                        }
                    }

                    Console.WriteLine("Результат умножения матрицы на число: ");
                    for (int i = 0; i < row; i++)
                    {
                        for (int j = 0; j < colum; j++)
                        {
                            Console.Write(c[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Опять залупа какая-то вместо массива");

                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Вы ввели не число\nЖелайте продолжить?");//доделать возврат

                    string s = Console.ReadLine();

                    if (s == "Да" || s == "да" || s == "Yes" || s == "yes" || s == "Yep" || s == "yep")
                    {
                        d = true;
                    }
                    else if (s == "Нет" || s == "нет" || s == "No" || s == "no")
                    {
                        Environment.Exit(0);
                        d = false;
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели некоректные данные, введите правильно");
                        d = false;
                    }
                }
            }

        }

        public static void Opredelitel(int[,] a, ref int row, ref int colum) 
        {

        }//сделать завтра

        public static void Trans(int[,] a, ref int row, ref int colum)
        {
            Console.WriteLine("Результат транспонирования: ");

            int[,] tran = new int[colum, row];

            for (int i = 0; i < colum; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    tran[i, j] = a[j, i];
                }
            }
            for (int i = 0; i < colum; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    Console.Write(tran[i, j] + " ");
                }
                Console.WriteLine();
            }

        } 
    }
}
        

