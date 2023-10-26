using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB
{
    internal class Program
    {

        public static string Reverse(string text)
        {
            char[] chararray = text.ToCharArray();
            Array.Reverse(chararray);
            return new string(chararray);
        }



        static void Main()
        {
            Console.WriteLine("Упражнение 8.1");
            BankType type = BankType.Сберегательный;
            Bankaccount account1 = new Bankaccount(type);
            Bankaccount account2 = new Bankaccount(type);
            account1.Deposit(10000);
            Console.WriteLine("//////////////////////");
            account2.Deposit(10000);
            Console.WriteLine("//////////////////////");
            account1.PrintAccountInfo();
            Console.WriteLine("//////////////////////");
            account2.PrintAccountInfo();
            Console.WriteLine("//////////////////////");
            account1.Transfer(account1, account2, amount: 100);
            Console.WriteLine("//////////////////////");
            account1.PrintAccountInfo();
            Console.WriteLine("//////////////////////");
            account2.PrintAccountInfo();
            Console.WriteLine("//////////////////////");
            Console.WriteLine("Для продолжения нажмите любую кнопку...");
            Console.ReadKey();




            Console.WriteLine("Упражнение 8.2");
            Console.WriteLine("Введите строку:");
            string text = Console.ReadLine();
            Console.WriteLine($"Ваша новая строка: {Reverse(text)}");
            Console.WriteLine("//////////////////////");
            Console.WriteLine("Для продолжения нажмите любую кнопку...");
            Console.ReadKey();

            Console.WriteLine("Упражнение 8.3");
            string labtext2 = "labtext2.txt";
            Console.Write("Введите название файла(исключая расширение файла!): "); // исходный файл labtext
            string filename = Console.ReadLine() + ".txt";
            if (!File.Exists(filename))
            {
                Console.WriteLine("Файла с таким именем не существует");
            }
            else
            {
                Console.Write("Введите название файла(исключая расширение файла!), куда вы хотите записать изменённое содержимое исходного файла: ");
                string filename2 = Console.ReadLine() + ".txt";
                File.WriteAllText(filename2, File.ReadAllText(filename).ToUpper());
                Console.WriteLine($"Текст записан заглавными буквами в файл: {labtext2}");
            }
            Console.WriteLine("Для продолжения нажмите любую кнопку...");
            Console.ReadKey();

            Console.WriteLine("Упражнение 8.4");
            CheckIFormattable checkIFormattable = new CheckIFormattable();
            string boroda = "boroda";
            int num = 100;
            if (checkIFormattable.Check(boroda))
            {
                Console.WriteLine("Объект реализует интерфейс IFormattable");
            }
            else
            {
                Console.WriteLine("Объект не реализует интерфейс IFormattable");
            }
            if (checkIFormattable.Check(num))
            {
                Console.WriteLine("Объект реализует интерфейс IFormattable");
            }
            else
            {
                Console.WriteLine("Объект не реализует интерфейс IFormattable");
            }

            Console.WriteLine("Для продолжения нажмите любую кнопку...");
            Console.ReadKey();


            Console.WriteLine("Домашняя работа 8.1");
            string input_file = "People.txt";
            string output_file = "Email.txt";
            List<string> file_lines = File.ReadAllLines(input_file).ToList();
            List<string> emaillist = new List<string>();
            if (File.Exists(input_file)) 
            {
                foreach (string line in file_lines)
                {
                    string email = line;
                    SearchMail(ref email);

                    if (!string.IsNullOrEmpty(email))
                    {
                        emaillist.Add(email);
                    }
                }
                File.WriteAllLines(output_file, emaillist);
                Console.WriteLine("Адреса почт были перенесены");
            }
            else
            {
                Console.WriteLine("Что-то пошло не так");
            }
            Console.WriteLine("Для продолжения нажмите любую кнопку...");
            Console.ReadKey();




            Console.WriteLine("Домашнее задание 8.2");
            List<Song> songs = new List<Song>();
            Song song1 = new Song();
            song1.Songname("Я Русский");
            song1.Songauthor("SHAMAN");
            
            Song song2 = new Song();
            song2.Songname("Я Русский");
            song2.Songauthor("SHAMAN");
            
            Song song3 = new Song();
            song3.Songname("Astral step");
            song3.Songauthor("Shadowraze");
            
            Song song4 = new Song();
            song4.Songname("Mana break");
            song4.Songauthor("zxCursed");

            Song song5 = new Song();
            song5.Songname("Astral step");
            song5.Songauthor("Shadowraze");
            
            song2.Prevsong(song1);
            song3.Prevsong(song2);
            song4.Prevsong(song3);
            song5.Prevsong(song4);
            songs.Add(song1);
            songs.Add(song2);
            songs.Add(song3);
            songs.Add(song4);
            songs.Add(song5);
            foreach (Song song in songs)
            {
                song.Title();
                Console.WriteLine();
            }


            for (int i = 0; i < songs.Count; i++)
            {
                for (int j = i + 1; j < songs.Count; j++)
                {
                    bool areEqual = songs[i].Equals(songs[j]);
                    Console.WriteLine($"Песня {i + 1} и песня {j + 1} одинаковы: " + areEqual);
                }
            }
            Console.ReadKey();






        }
        public static void SearchMail(ref string s)
        {
            int index = s.LastIndexOf('#');
            if (index != -1 && index < s.Length - 1)
            {
                s = s.Substring(index + 1).Trim();
            }
        }
    }
}
