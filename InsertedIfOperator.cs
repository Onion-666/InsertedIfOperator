using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

class Programm
{
    static void Main()
    {
        string txt;
        Console.WriteLine("Введите текст");
        txt = Console.ReadLine();
        if (txt != "")
        {
            Console.WriteLine("Спасибо, что ввели текст!");
            if (txt.Length > 10)
            {
                Console.WriteLine("Ого, как много букв!");
            }
            else
            {
                Console.WriteLine("Ого, как мало букв!");
            }
        }
        else
            Console.WriteLine("Жаль, что не ввели текст!");
    }
}