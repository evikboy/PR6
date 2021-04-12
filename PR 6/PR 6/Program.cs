using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string n;
            string str1, str2;
            string str3;
            int n1;
            int exit = 0;
            Console.WriteLine("Введите первую строку");
            str1 = Console.ReadLine();
            Console.WriteLine("Введите вторую строку");
            str2 = Console.ReadLine();

           
           
            while (exit != 1)
            {
                Console.WriteLine("Для продолжения нажмите любую клавишу...");
                Console.ReadKey();
                Console.WriteLine("str1 = \"{0}\"\nstr2 = \"{1}\"", str1,str2);
                Console.Write("\nВыберите вариант\n\n1. Объединение строк\n2. Установка строк\n3. Замена строк\n4. Изъятия строк\n5. Сравнение двух строк\n" +
                  "6. Сравнение символов из двух строк, которые находятся на определенных местах\n7. Определение индекса первого вхождения заданной строки в другой\n8. Выход\n\n>>> ");
                n = Console.ReadLine();
                switch (n)
                {

                    case "1":
                        str3 = String.Concat(str1, str2);
                        Console.WriteLine("Результат: \"{0}\"", str3);
                        break;

                    case "2":
                        int i;
                        Console.WriteLine("1. Вставить строку 1 в строку 2 с позиции i\n2. Вставить строку 2 в строку 1 с позиции i");
                        Console.Write("\n>>> ");
                        n1 = Int32.Parse(Console.ReadLine());
                        Console.Write("Введите i = ");
                        i = Int32.Parse(Console.ReadLine());
                        if (n1 == 1)
                        {
                            str3 = str2.Insert(i, str1);
                            Console.WriteLine("Результат: \"{0}\"", str3);
                        }
                        if (n1 == 2)
                        {
                            str3 = str1.Insert(i, str2);
                            Console.WriteLine("Результат: \"{0}\"", str3);
                        }
                        break;
                    case "3":
                        char A, B;
                        Console.WriteLine("1.Заменить символ А строки 1 на символ В\n2.Заменить символ А строки 2 на символ В");
                        Console.Write("\n>>> ");
                        n1 = Int32.Parse(Console.ReadLine());
                        Console.Write("A = ");
                        A = Convert.ToChar(Console.ReadLine());
                        Console.Write("B = ");
                        B = Convert.ToChar(Console.ReadLine());

                        if (n1 == 1)
                        {
                            str3 = str1.Replace(A, B);
                            Console.WriteLine("Результат: \"{0}\"", str3);
                        }

                        if (n1 == 2)
                        {
                            str3 = str2.Replace(A, B);
                            Console.WriteLine("Результат: \"{0}\"", str3);
                        }
                        break;

                    case "4":
                        int E, L;
                        Console.WriteLine("1. Изъять з позиции E часть строки 1 длинною L\n2. Изъять з позиции E часть строки 2 длинною L");
                        Console.Write("\n>>> ");
                        n1 = Int32.Parse(Console.ReadLine());
                        Console.Write("E = ");
                        E = Convert.ToInt32(Console.ReadLine());
                        Console.Write("L = ");
                        L = Convert.ToInt32(Console.ReadLine());

                        if (n1 == 1)
                        {
                            str3 = str1.Substring(E, L);
                            Console.WriteLine("Результат: \"{0}\"", str3);
                        }

                        if (n1 == 2)
                        {
                            str3 = str2.Substring(E, L);
                            Console.WriteLine("Результат: \"{0}\"", str3);
                        }
                        break;

                    case "5":
                        int compare;
                        compare = str1.CompareTo(str2);
                        if (compare == -1)
                        {
                            Console.WriteLine("Строки не равны");
                        }
                        if (compare == 0)
                        {
                            Console.WriteLine("Строки равны");
                        }
                        break;

                    case "6":
                        int C, D, length, comparePart;
                        Console.WriteLine("Сравниваются части строк из позиции С строки 1 та позиции D строки 2 длинною length");
                        Console.Write("C = ");
                        C = Int32.Parse(Console.ReadLine());
                        Console.Write("D = ");
                        D = Int32.Parse(Console.ReadLine());
                        Console.Write("length = ");
                        length = Int32.Parse(Console.ReadLine());
                        comparePart = String.Compare(str1, C, str2, D, length);
                        if (comparePart == 0)
                        {
                            Console.WriteLine("Выбраные части строк равны");
                        }
                        else Console.WriteLine("Выбраные части строк не равны");
                        break;

                    case "7":
                        int index = -2;
                        Console.WriteLine("1. Вернуть индекс первого вхождения строки 2 в строку 1\n2. Вернуть индекс первого вхождения строки 1 в строку 2");
                        n1 = Int32.Parse(Console.ReadLine());
                        if (n1 == 1)
                        {
                            index = str1.IndexOf(str2);
                        }

                        if (n1 == 2)
                        {
                            index = str2.IndexOf(str1);
                        }
                       
                        if (index != -1)
                        {
                            Console.WriteLine("Индекс = {0}", index);
                        }
                        else Console.WriteLine("Эта строка не входить в состав другой строки");

                        break;
                    case "8":
                        exit = 1;
                        Console.WriteLine("До свидания!");
                        break;
                }
            }
        }
    }
}
