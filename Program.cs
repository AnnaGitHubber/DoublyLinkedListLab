using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedListLab
{
    class Program
    {
        static void Main(string[] args)
        {
          

            while (true)
            {
                Console.WriteLine("\nМеню:");
                Console.WriteLine("1. Додати елемент до списку (цiлi)");
                Console.WriteLine("2. Видалити елемент зi списку (цiлi)");
                Console.WriteLine("3. Знайти елемент у списку (цiлi)");
                Console.WriteLine("4. Вивести список (цiлi)");
                Console.WriteLine("5. Завдання 1: Вставити 66 після вiд’ємних (цiлi)");
                Console.WriteLine("6. Завдання 2: Вставити перший вiд’ємний перед 20 (дiйснi)");
                Console.WriteLine("7. Додати елемент до списку (дiйснi)");
                Console.WriteLine("8. Вивести список (дiйснi)");
                Console.WriteLine("0. Вихiд");

                Console.Write("Ваш вибiр: ");
                string choice = Console.ReadLine();
                // Створюємо список для цілих чисел
                DoublyLinkedList<int> listInt = new DoublyLinkedList<int>();

                // Створюємо список для дійсних чисел
                DoublyLinkedList<double> listDouble = new DoublyLinkedList<double>();
                // Заповнюємо список цілих чисел
                listInt.AddToEnd(5);
                listInt.AddToEnd(-3);
                listInt.AddToEnd(7);
                listInt.AddToEnd(-1);
                listInt.AddToEnd(0);

                // Заповнюємо список дійсних чисел
                listDouble.AddToEnd(10.5);
                listDouble.AddToEnd(-2.2);
                listDouble.AddToEnd(20);
                listDouble.AddToEnd(15);
                listDouble.AddToEnd(20);

                switch (choice)
                {
                    case "1":
                        Console.Write("Введіть ціле число: ");
                        int val = int.Parse(Console.ReadLine());
                        listInt.AddToEnd(val);
                        break;
                    case "2":
                        Console.Write("Введіть ціле число для видалення: ");
                        int rem = int.Parse(Console.ReadLine());
                        listInt.Remove(rem);
                        break;
                    case "3":
                        Console.Write("Введіть ціле число для пошуку: ");
                        int find = int.Parse(Console.ReadLine());
                        var found = listInt.Find(find);
                        Console.WriteLine(found != null ? "Знайдено." : "Не знайдено.");
                        break;
                    case "4":
                        Console.Write("Список: ");
                        listInt.PrintList();
                        break;
                    case "5":
                        listInt.Insert66AfterNegatives();
                        Console.WriteLine("Оновлений список:");
                        listInt.PrintList();
                        break;
                    case "6":
                        Console.WriteLine("Список до:");
                        listDouble.PrintList();
                        listDouble.InsertFirstNegativeBefore20();
                        Console.WriteLine("Список після:");
                        listDouble.PrintList();
                        break;
                    case "7":
                        Console.Write("Введіть дійсне число: ");
                        double d = double.Parse(Console.ReadLine());
                        listDouble.AddToEnd(d);
                        break;
                    case "8":
                        Console.Write("Список: ");
                        listDouble.PrintList();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Невірна команда.");
                        break;
                }
            }
        }
    }
}