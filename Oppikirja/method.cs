using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Oppikirja
{
    public class  Method

    {
        public static void Methodman() { 
        Topic topi = new Topic();
           


            Console.WriteLine("Anna aiheen tunniste");
            

                try
                {
                    topi.Id = Convert.ToInt32(Console.ReadLine());
                    //topic.Add();
                    Console.WriteLine("Aiheen otsikko");
                    topi.Title = Console.ReadLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    
                    
                }

           
            Console.WriteLine("Anna aiheen kuvaus");
            topi.Description = Console.ReadLine();

            Console.WriteLine("Anna aika arvio h.m");
            topi.EstimatedTimeToMaster = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Kauanko olet opiskellut h.m");
            topi.TimeSpent = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Anna mahdollinen lähde: ");
            topi.Source = Console.ReadLine();
            try
            {
                Console.WriteLine("Anna aloitus aika: dd/MM/yyyy ");
                topi.StartLearningDate = Convert.ToDateTime(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
                Console.WriteLine("Onko opiskelu kesken? Y/N");
                var valinta = Console.ReadLine();
          

                if (valinta == "N")
            {
                try
                {
                    topi.InProgress = false;
                    Console.WriteLine("Milloin sait valmiiksi? dd/MM/yyyy");
                    topi.CompletionDate = Convert.ToDateTime(Console.ReadLine());
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                    //Console.WriteLine(topi.Id + "\n" + topi.Title + "\n" + topi.Description + "\n" + topi.EstimatedTimeToMaster + "\n"
                     //+ topi.TimeSpent + "\n" + topi.Source + "\n" + topi.StartLearningDate + "\n" + topi.CompletionDate + "\n" + topi.InProgress);

                }
                try
                {
                    if (valinta == "Y")
                    {
                        topi.InProgress = true;
                        // Console.WriteLine(topi.Id + "\n" + topi.Title + "\n" + topi.Description + "\n" + topi.EstimatedTimeToMaster + "\n"
                        // + topi.TimeSpent + "\n" + topi.Source + "\n" + topi.StartLearningDate + "\n" + topi.InProgress + "\n" + topi.CompletionDate);

                    }
                }
                catch(Exception e)
                {
                Console.WriteLine(e.Message);
                
                }
                




            String path = @"C:\Users\Jere\source\repos\Oppikirja\Id.txt";
                string a = Convert.ToString(topi.Id + "," + topi.Title + "," + topi.Description + "," + topi.EstimatedTimeToMaster + "," +
        +topi.TimeSpent + "," + topi.Source + "," + topi.StartLearningDate + "," + topi.InProgress + "," + topi.CompletionDate);

            File.AppendAllText(path, a + Environment.NewLine);
            StreamReader sr = new StreamReader(@"C:\Users\Jere\source\repos\Shopping\Shoppinglist.txt");
            //to be continue



        }
        public static void Redman()
        {

            var loki = File.ReadAllLines(@"C:\Users\Jere\source\repos\Oppikirja\Id.txt");
            var lokikirja = new List<String>(loki);
            for (int i = 0; i < lokikirja.Count; i++)
            {
                Console.WriteLine(lokikirja[i]);
            }
        }
        public static void Ghostfacekillah()
        {
            Console.WriteLine("     __ ________");
            Console.WriteLine(" _,-'|`||||||||_\\___ _,-,_");
            Console.WriteLine("| /_`-'||||||||' \\\\-____/_ __o`-,");
            Console.WriteLine("|[__<|_|||||||| -----.______(=====/");
            Console.WriteLine(" |_\\ \\------'\\____/--------\\_,-'");
            Console.WriteLine("   `\\`. \\-'");
            Console.WriteLine("     \\ \\ \\");
            Console.WriteLine("     `\\`. \\`");
            Console.WriteLine("       \\ `-.__\\");
            Console.WriteLine("        \\______\\");
            Console.WriteLine("         | ___\\");
            Console.WriteLine("         \\(___======][]");
            Console.WriteLine("           `--\"");
        }
    }
}
