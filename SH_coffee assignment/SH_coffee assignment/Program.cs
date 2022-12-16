using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SH_coffee_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalAmount = 0;
            Console.WriteLine("Welcome to B.Tech Coffee Shop");
            Console.WriteLine("Select options:");
            Console.WriteLine(" 1. Add Coffee \n 2. Total Bill: \n 3. Exit");
            int add=int.Parse(Console.ReadLine());
             if(add==1)
                {
                string confirm;
                bool ismenu=true;
                while (ismenu)
                {
                    Console.WriteLine("Select Coffee :\n 1. Espresso \n 2. Cappuccino \n 3. Latte \n 4. Americno \n 5. Affogota \n 6. Flat Whote \n 7. Frappe \n 8. Lungo");

                    int coffeOpt = int.Parse(Console.ReadLine());
                    switch (coffeOpt)
                    {
                        case 1:
                            Console.WriteLine("You choose Espresso Coffee Price: Rs 500/-");
                            Console.WriteLine("Enter the number of quantity:");
                            int quantity1=int.Parse(Console.ReadLine());
                            int price1 = 500;
                            totalAmount += (price1*quantity1);
                            break;
                        case 2:
                            Console.WriteLine("You choose Cappuccino Coffee Price: Rs 900/-");
                            Console.WriteLine("Enter the number of quantity:");
                            int quantity2 = int.Parse(Console.ReadLine());
                            int price2 = 900;
                            totalAmount += (price2 * quantity2);
                            break;
                        case 3:
                            Console.WriteLine("You choose Latte Coffee Price: Rs 400/-");
                            Console.WriteLine("Enter the number of quantity:");
                            int quantity3 = int.Parse(Console.ReadLine());
                            int price3 = 400;
                            totalAmount += (price3 * quantity3);

                            break;
                        case 4:
                            Console.WriteLine("You choose Americno Coffee Price: Rs 300/-");
                            int price4 = 300;
                            Console.WriteLine("Enter the number of quantity:");
                            int quantity4 = int.Parse(Console.ReadLine());
                            totalAmount += (price4 * quantity4);
                            break;
                        case 5:
                            Console.WriteLine("You choose Affogota Coffee Price: Rs 700/-");
                            int price5 = 700;
                            Console.WriteLine("Enter the number of quantity:");
                            int quantity5 = int.Parse(Console.ReadLine());
                            totalAmount += (price5 * quantity5);
                            break;
                        case 6:
                            Console.WriteLine("You choose Flat Whote Coffee Price: Rs 650/-");
                            int price6 = 650;
                            Console.WriteLine("Enter the number of quantity:");
                            int quantity6 = int.Parse(Console.ReadLine());
                            totalAmount += (price6 * quantity6);
                            break;
                        case 7:
                            Console.WriteLine("You choose Frappe Coffee Price: Rs 450/-");
                            int price7 = 450;
                            Console.WriteLine("Enter the number of quantity:");
                            int quantity7 = int.Parse(Console.ReadLine());
                            totalAmount += (price7 * quantity7);
                            break;
                        case 8:
                            Console.WriteLine("You choose Lungo Coffee Price: Rs 320/-");
                            int price8 = 320;
                            Console.WriteLine("Enter the number of quantity:");
                            int quantity8 = int.Parse(Console.ReadLine());
                            totalAmount += (price8 * quantity8);
                            break;
                        default:
                            Console.WriteLine("You choose wrong option");
                            break;
                    }
                    Console.WriteLine("Do you want to add some new items: Yes/No");
                    confirm = Console.ReadLine().ToLower();
                    
                    if (confirm == "yes")
                    {
                        continue;
                    }else if(confirm=="no"){
                        ismenu = false;
                    }
                }
            }
            else
            {
                Console.WriteLine("you choose Wrong option");
            }
            Console.WriteLine("2.Total Bill:");
            int bill=int.Parse(Console.ReadLine());
            if (bill==2)
            {
                Console.WriteLine("---------Bill----------");
                Console.WriteLine("Total Bill:");
                Console.WriteLine("You total bill are:{0}", totalAmount);
                Console.ReadLine();
            }
            Console.WriteLine("3.Exit:");
            int exit = int.Parse(Console.ReadLine());
            if (exit==3)
            {
            Console.WriteLine("---------Important point--------");
            Console.WriteLine("Please pay the bill before leaving");
            Console.ReadLine();
            Console.WriteLine("------You Are Under CCTV Servilance---------");
            Console.WriteLine("paise dedena Upar wala sab dekhta hai!");
            Console.WriteLine("paise dede re baba tera bhi bhala hoga");
            }
            else
            {
                Console.WriteLine("you choose wrong Option");
            }











            Console.ReadLine();
        }
    }
}
