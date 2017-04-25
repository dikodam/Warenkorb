using System;
using System.ComponentModel.Design;
using System.Text;
using static System.ConsoleKey;
using static System.Console;

namespace Warenkorb
{
    public class Program
    {
        private static ShoppingCart cart;
        public static void Main(string[] args)
        {
            Write("Länge des Warenkorbs angeben (default ist 10): ");

            cart = new ShoppingCart();
            try
            {
                cart = new ShoppingCart(Convert.ToInt32(ReadLine()));
            }
            catch (Exception e)
            {
                WriteLine("Ungültige Eingabe, default-Länge von 10 wird verwendet.");
            }

            bool running = true;
            while (running)
            {
                switch (Menu())
                {
                    case ConsoleKey.D1:
                        WriteLine(cart.CartDescription());
                        break;
                    case ConsoleKey.D2:
                        AddNewItem();
                        break;
                    case ConsoleKey.D3:
                        break;
                    case ConsoleKey.Escape:
                        running = false;
                        WriteLine("Shop wird beendet!");
                        ReadKey();
                        break;
                    default:
                        continue;
                }
            }
        }

        private static void AddNewItem()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(1) - Buch");
            sb.AppendLine("(2) - CD");
            sb.AppendLine("(3) - Video");
            WriteLine(sb.ToString());
            switch (ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                    AddNewBook();
                    break;
                case ConsoleKey.D2:
                    AddNewCD();
                    break;
                case ConsoleKey.D3:
                    AddNewVideo();
                    break;
                default:
                    break;
            }
        }

        private static void AddNewBook()
        {
            try
            {
                Write("Item-ID: ");
                var itemID = Convert.ToInt64(ReadLine());
                Write("Item-Preis: ");
                var price = Convert.ToDouble(ReadLine());
                Write("Titel:");
                var title = ReadLine();
                Write("Buchautor: ");
                var author = ReadLine();
                Write("Verlag: ");
                var publisher = ReadLine();
                cart.Add(new Book(itemID, price, author, title, publisher));
            }
            catch (Exception e)
            {
                WriteLine(e);
                throw;
            }
        }



        private static ConsoleKey Menu()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(1) - Warenkorb ausgeben");
            sb.AppendLine("(2) - neues Item hinzufügen");
            sb.AppendLine("(ESC) - Programm beenden");
            WriteLine(sb.ToString());
            return ReadKey(true).Key;
        }
    }
}