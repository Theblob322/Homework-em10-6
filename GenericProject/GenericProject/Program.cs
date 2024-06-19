using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GenericProject
{
    internal class Program
    {
       public static List<string> strings = new List<string>();
        public static void Main(string[] args)
        {
            for (int i = 0; i < int.MaxValue; i++) {
                Console.WriteLine("Оберіть що бажаєте зробити зі списком? \n[1] - Створити елемент\n[2] - Видалити якийсь елемент \n[будь-яке інше число] - Показати якийсь із елементів");
                if (Convert.ToInt16(Console.ReadLine()) == 1)
                {
                    Console.WriteLine("Введіть текст");
                    strings.Add(Console.ReadLine());
                }
                else if (Convert.ToInt16(Console.ReadLine()) == 2)
                {
                    Console.WriteLine("Введіть номер елементу який потрібно видалити");
                    strings.RemoveAt(Convert.ToInt32(Console.ReadLine()));
                }
                else 
                {
                    Console.WriteLine("Введіть номер елементу який потрібно показати");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(strings[num]);
                }
            }
        }
        
    }
}
