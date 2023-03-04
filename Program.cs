using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ДЗ_с_строками_СиШарп_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Палиндром
            Console.WriteLine("Введите текст: ");
            string text = Console.ReadLine();
            text = text.Replace(" ", "");
            text = text.ToLower();
            char[] text2 = text.ToCharArray();
            Array.Reverse(text2);
            string text3 = new string(text2);
            if (text.ToLower() == text3)
                Console.WriteLine("ЭТОТ ТЕКСТ ПАЛИНДРОМ!\n");
            else if (text != text3)
                Console.WriteLine("ЭТОТ ТЕКСТ НЕ ПАЛИНДРОМ!\n");
            #endregion


            #region Подсчет букв
            Console.WriteLine("Введите текст: ");
            string text4 = Console.ReadLine();
            char[] glas = { 'а', 'о', 'у', 'э', 'ы', 'я', 'ё', 'е', 'ю', 'и',
                'А','О','У','Э','Ы','Я','Ё','Е','Ю','И' };
            char[] soglas = { 'б', 'в', 'г', 'д', 'ж', 'з', 'й', 'к', 'л', 'м', 'н', 'п', 'р', 'с', 'т', 'ф','х', 'ц', 'ч', 'ш', 'щ',
                'Б', 'В', 'Г', 'Д', 'Ж', 'З', 'Й', 'К', 'Л', 'М', 'Н', 'П', 'Р', 'С', 'Т', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ' };
            char[] tochki = { '.', ',', ':', ';', '?', '!', '-', '"', '(', ')' };
            char[] chisla = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            for (int i = 0; i < glas.Length; i++)
            {
                if (text4.Contains(glas[i]))
                {
                    a++;
                }
            }
            for (int i = 0; i < soglas.Length; i++)
            {
                if (text4.Contains(soglas[i]))
                {
                    b++;
                }
            }
            for (int i = 0; i < text4.Length; i++)
            {
                for (int j = 0; j < tochki.Length; j++)
                {
                    if (text4[i].ToString() == tochki[j].ToString())
                    {
                        c++;
                    }
                }
            }
            for (int i = 0; i < text4.Length; i++)
            {
                if (text4.Contains(chisla[i]))
                {
                    d++;
                }
            }
            int slova = text4.Split(' ').Length;
            Console.WriteLine("Текст: " + text4);
            Console.WriteLine("---Статистика---\nКоличество гласных букв: " + a);
            Console.WriteLine("Количество согласных букв: " + b);
            Console.WriteLine("Количество слов в тексте: " + slova);
            Console.WriteLine("Количество знаков в тексте: " + c);
            Console.WriteLine("Количество цифр в тексте: " + d);
            #endregion
        }
    }
  }
