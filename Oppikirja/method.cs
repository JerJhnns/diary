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


            try
            {
                Console.WriteLine("Anna aiheen tunniste");
                topi.Id = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e) { Console.WriteLine(e.Message);  }
            try
                {
                   Console.WriteLine("Aiheen otsikko");
                    topi.Title = Console.ReadLine();
                }
            catch (Exception e) { Console.WriteLine(e.Message); }

            try
            {
                Console.WriteLine("Anna aiheen kuvaus");
                topi.Description = Console.ReadLine();
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            try
            {
                Console.WriteLine("Anna aika arvio h.m");
                topi.EstimatedTimeToMaster = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            Console.WriteLine("Kauanko olet opiskellut h.m");
            topi.TimeSpent = Convert.ToDouble(Console.ReadLine());
            try
            {
                Console.WriteLine("Anna mahdollinen lähde: ");
                topi.Source = Console.ReadLine();
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            try
            {
                Console.WriteLine("Anna aloitus aika: dd/MM/yyyy ");
                topi.StartLearningDate = Convert.ToDateTime(Console.ReadLine());
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
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
                catch(Exception e){ Console.WriteLine(e.Message);}

                    

                }
                try
                {if (valinta == "Y")
                    {topi.InProgress = true;}}
                catch(Exception e)
                {Console.WriteLine(e.Message); }
                




            String path = @"C:\Users\Jere\source\repos\Oppikirja\Id.txt";
                string a = Convert.ToString(topi.Id + ", " + topi.Title + ", " + topi.Description + ", " + topi.EstimatedTimeToMaster + ", " +
        +topi.TimeSpent + ", " + topi.Source + ", " + topi.StartLearningDate + ", " + topi.InProgress + ", " + topi.CompletionDate);

            File.AppendAllText(path, a + Environment.NewLine);



            //StreamReader sr = new StreamReader(@"C:\Users\Jere\source\repos\Shopping\Shoppinglist.txt");
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
        public static void Raekwon()
        {
            if (!File.Exists(@"C:\Users\Jere\source\repos\Oppikirja\Id.txt"))
                File.Create(@"C:\Users\Jere\source\repos\Oppikirja\Id.txt");

            TextWriter tw = new StreamWriter(@"C:\Users\Jere\source\repos\Oppikirja\Id.txt", false);
            tw.Write(string.Empty);
            tw.Close();

            Console.WriteLine("Poistit kaiken");
        }
    }
}
