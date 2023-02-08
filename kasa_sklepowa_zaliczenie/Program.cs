using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kasa_sklepowa_zaliczenie
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            ShopItems shopItems = new ShopItems();

            List<Item> listOfItems = getListOfItems();

            shopItems.setShopItems(listOfItems);

            var message = new Message();
            message.DisplayWelcome();
            String option; 
            while (true)
            {
                option = Console.ReadLine();
                if (option == "1")
                {
                    Console.Clear();
                    foreach (Item item in listOfItems)
                    {
                        Console.WriteLine(item.getBarcode() + " " + item.getName() + " " + item.getPriceGross() + " zł");
                    }
                }
                else if (option == "2")
                {
                    Console.Clear();
                    string barcode = null;
                    Cart cart = new Cart();

                    while (barcode != "P")
                    {

                        Console.WriteLine("Kod kreskowy lub wydruk paragonu (P)");
                        barcode = Console.ReadLine();
                        Console.Clear();

                        if (barcode == "P")
                        {
                            break;
                        }

                        Item selectedItem = shopItems.getItemByBarcode(barcode);

                        if (selectedItem == null)
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("NIEPRAWIDŁOWY KOD PRODUKTU");

                            continue;
                        }

                        cart.addToCart(selectedItem);

                        Console.WriteLine("Dodano produkt: " + selectedItem.getName());

                        Console.WriteLine("Cena łączna: " + cart.getCartAmount() + " zł");



                    }
                    if (cart.getCartAmount() > 0)
                    {
                        cart.getParagon();
                    }
                    else
                    {
                        Console.WriteLine("Nie dodano żadnego produktu");
                    }


                }

                else if (option == "3")
                {
                    Console.Clear();
                }



              
            }
        }
        public static List<Item> getListOfItems()
        {
            List<Item> items = new List<Item>();

            items.Add(new Item("001", "Masło extra", 6.50, 23));
            items.Add(new Item("002", "Chleb wiejski", 4.50, 23));
            items.Add(new Item("003", "Makaron Babuni", 9.20, 23));
            items.Add(new Item("004", "Dżem truskawkowy", 8.10, 23));
            items.Add(new Item("005", "Kiełbasa myśliwska", 29.00, 23));
            items.Add(new Item("006", "Szynka konserwowa", 22.00, 23));
            items.Add(new Item("007", "Chipsy paprykowe", 6.00, 23));
            items.Add(new Item("008", "Serek wiejski", 3.50, 23));
            items.Add(new Item("009", "Sól kuchenna", 2.70, 23));
            items.Add(new Item("010", "Cukier kryształ", 3.20, 23));

            return items;
        }
    }
}
