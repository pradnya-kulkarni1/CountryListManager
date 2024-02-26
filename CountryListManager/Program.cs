namespace CountryListManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Country List Manager");
            Console.WriteLine("COMMAND MENU");
            Console.WriteLine("1 - List countries");
            Console.WriteLine("2 - Add a country");
            Console.WriteLine("3 - Exit");
            List<string> Countries = new List<string>();

            Boolean repeat = false;

            while (!repeat)
            {
                Console.WriteLine();
                Console.WriteLine("Enter Menu number");
                string menu = Console.ReadLine();
                
                if (menu.Equals("2"))
                {
                    Console.WriteLine("Enter Country");
                    string countryName = Console.ReadLine();
                    Countries.Add(countryName);
                    Console.WriteLine("This contry has been added.");

                }
                else if (menu.Equals("3"))
                {
                    Console.WriteLine("Bye");
                    repeat = true;

                }
                else if (menu.Equals("1"))
                {
                    if(Countries.Count == 0)
                    {
                       
                           Console.WriteLine("No countries in the List");
                       
                    } else 

                   
                    foreach (string Name in Countries)
                    {
                        Console.WriteLine(Name + " ");
                        
                    }
                }
                
                

            }
        }
        }
    }
