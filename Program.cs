using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
// 2
//namespace PiD5._2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string Znach1;
//            Znach1 = Interaction.InputBox(
//                "Введите число",
//                " "
//                );
//            int res = Convert.ToInt32(Znach1);
//            if (res % 5 == 2)
//            {
//                string txt = Znach1 + " Делится на 5 с остатком 2";
//                MessageBox.Show(txt);
//            }
//            else if (res % 7 == 1)
//            {
//                string txt = Znach1 + " Делится на 7 с остатком 1";
//                MessageBox.Show(txt);
//            }
//            else
//            {
//                string txt = Znach1 + " Не делится на 5 с остатком 2 и не делится на 7 с остатком 1";
//            }
//        }
//    }
//}

//3
//namespace PiD5._2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string Znach1;
//            Znach1 = Interaction.InputBox(
//                 "Введите число",
//                 " "
//                            );
//            int res = Convert.ToInt32(Znach1);
//            if (res > 10 && res % 4 == 0)
//            {
//                string txt = Znach1 + " Делится на 4 и при этом больше 10";
//                MessageBox.Show(txt);
//            }
//            else if (res < 10)
//            {
//                string txt = Znach1 + " не больше 10";
//                MessageBox.Show(txt);
//            }
//            else if ((res % 4) == 0)
//            {
//                string txt = Znach1 + " не делится на 4";
//                MessageBox.Show(txt);
//            }

//        }

//    }
//}

//4
//namespace PiD5._2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string Znach1;
//            Znach1 = Interaction.InputBox(
//                 "Введите число",
//                 " "
//                            );
//            int res = Convert.ToInt32(Znach1);
//            if (res >= 5 && res <= 10)
//            {
//                string txt = res + " Находится в диапазоне от 5 до 10";
//                MessageBox.Show(txt);
//            }
//            else if (res > 10)
//            {
//                string txt = res + " Больше 10";
//                MessageBox.Show(txt);
//            }
//            else
//            {
//                string txt = res + " Меньше 5";
//                MessageBox.Show(txt);
//            }
//        }

//    }
//}


//5
//namespace PiD5._2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string Znach1;
//            Znach1 = Interaction.InputBox(
//                 "Введите число",
//                 " "
//                            );
//            int res = Convert.ToInt32(Znach1);
//            res = (res / 1000) % 10;
//            string txt = res + " тысяч";
//            MessageBox.Show(txt);
//        }

//    }
//}

//6
namespace PiD5._2
{
    using System;
    class Program
    {
        static void Main()
        {
            // Ввод числа от пользователя
            Console.Write("Введите число в десятичной системе: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            // Преобразуем число в восьмеричную систему счисления и находим вторую справа цифру
            string num1 = Convert.ToString(num2, 8);
            char num = num1[num1.Length - 2];
            // Выводим результат
            Console.WriteLine($"Вторая цифра справа в восьмеричном представлении числа {num2} равна {num}.");
            Console.ReadLine();
        }
    }
}


