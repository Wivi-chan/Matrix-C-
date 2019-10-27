using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//#Task #10.
//����� �����������, ������������ � ������� �������� � //������� ����� �����
//����� ���������� ��������� ��������� � ������� ����� �����
namespace ������_������_��_�����
{
    class Program
    {
        static void Main(string[] args)
        {
            bool d = true;

            Console.WriteLine("������� ����������� ������ �� �������: ");
            int row = System.Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("������� ����������� ������ �� ��������: ");
            int colum = System.Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[row, colum];
            int[,] arr2 = new int[row, colum];


            OneTwoMass(arr, ref row, ref colum, arr2);
            Console.WriteLine("������� ����� �������, ����� ����������: ");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("�� ����� ������������ ������: ");
            Console.WriteLine("������� ����� �������, ����� ����������: ");


            while (d == true)
            {
                Console.WriteLine("������� ��������, ������� ������� ���������\n��������\n��������� � ����� ������� ����� ������\n������������\n���������������� �������� ����� ������ ����� ������ �������\n������� ���\n��� �� �����: ");
                string r = Console.ReadLine();
                switch (r)
                {
                    case "��������":
                        d = false;
                        Summ(arr, arr2, ref row, ref colum);
                        break;

                    case "��������� 1":
                        d = false;
                        Multipul(arr, ref row, ref colum);
                        break;
                    case "��������� 2":
                        d = false;
                        Multipul(arr2, ref row, ref colum);
                        break;
                        
                    case "���������������� 1":
                        d = false;
                        Trans(arr, ref row, ref colum);
                        break;
                    case "���������������� 2":
                        d = false;
                        Trans(arr2, ref row, ref colum);
                        break;

                    case "������������":

                        Console.WriteLine("��� �� ������ :(");
                        Console.WriteLine("������� ����� �������, ��� ����������� � ����� ��������");
                        Opredelitel(arr, ref row, ref colum);
                        d = true;
                        break;

                    case "���":
                        Summ(arr, arr2, ref row, ref colum);
                        Multipul(arr2, ref row, ref colum);
                        Multipul(arr2, ref row, ref colum);
                        Trans(arr, ref row, ref colum);
                        Trans(arr2, ref row, ref colum);
                        Opredelitel(arr, ref row, ref colum);
                        break;
                    case "�����":

                        Environment.Exit(0);
                        d = false;
                        break;


                    default:
                        Console.ReadLine();
                        Console.WriteLine("�� ����������� ����� �������, ���������� ��� ���");//�������� ������� 
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
                Console.WriteLine("������ ������: ");
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < colum; j++)
                    {
                        Console.WriteLine("������� �����: ");
                        a[i, j] = int.Parse(Console.ReadLine());
                        Console.WriteLine("������ �������: {0}", a[i, j]);

                    }
                }

                Console.WriteLine("�������� �������: ");
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < colum; j++)
                    {
                        Console.Write(a[i, j] + " ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("������ ������: ");

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < colum; j++)
                    {
                        Console.WriteLine("������� �����: ");
                        b[i, j] = int.Parse(Console.ReadLine());
                        Console.WriteLine("������ �������: {0}", b[i, j]);

                    }
                }

                Console.WriteLine("�������� �������: ");
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
                Console.WriteLine("����� ������ �����-�� ������ �������");
            }
            catch (System.FormatException)
            {
                Console.WriteLine("����� ������� �����, �������");
            }


        }

        public static void Summ(int[,] a, int[,] b, ref int row, ref int colum)
        {
            try
            {
                Console.WriteLine("��������� ��������: ");

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
                Console.WriteLine("����� �����-�� ������");
            }

        }

        public static void Multipul(int[,] a, ref int row, ref int colum)
        {
            bool d = true;
            while (d == true)
            {
                try
                {
                    Console.WriteLine("������� �����, �� ������� �� ������ �������� �������\n��� ������ ��� ���������� ���������� �� ������: ");
                    int u = int.Parse(Console.ReadLine());
                    int[,] c = new int[row, colum];

                    for (int i = 0; i < row; i++)
                    {
                        for (int j = 0; j < colum; j++)
                        {
                            c[i, j] = a[i, j] * u;
                        }
                    }

                    Console.WriteLine("��������� ��������� ������� �� �����: ");
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
                    Console.WriteLine("����� ������ �����-�� ������ �������");

                }
                catch (System.FormatException)
                {
                    Console.WriteLine("�� ����� �� �����\n������� ����������?");//�������� �������

                    string s = Console.ReadLine();

                    if (s == "��" || s == "��" || s == "Yes" || s == "yes" || s == "Yep" || s == "yep")
                    {
                        d = true;
                    }
                    else if (s == "���" || s == "���" || s == "No" || s == "no")
                    {
                        Environment.Exit(0);
                        d = false;
                    }
                    else
                    {
                        Console.WriteLine("�� ����� ����������� ������, ������� ���������");
                        d = false;
                    }
                }
            }

        }

        public static void Opredelitel(int[,] a, ref int row, ref int colum) 
        {

        }//������� ������

        public static void Trans(int[,] a, ref int row, ref int colum)
        {
            Console.WriteLine("��������� ����������������: ");

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
        

