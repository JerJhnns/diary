using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;

namespace Oppikirja
{

    public class Method

    {

        public static void Methodman(string path, Dictionary<int, Topic> uusTopi, Topic topi)
        {







            try
            {
                Console.WriteLine("Anna aiheen tunniste");
                topi.Id = Convert.ToInt32(Console.ReadLine());
                


            }
            catch (Exception e) { Console.WriteLine(e.Message); }

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
                catch (Exception e) { Console.WriteLine(e.Message); }



            }
            try
            {
                if (valinta == "Y")
                { topi.InProgress = true; }
            }
            catch (Exception e)
            { Console.WriteLine(e.Message); }

            uusTopi.Add(topi.Id, topi);



            string a = Convert.ToString(topi.Id + "," + topi.Title + "," + topi.Description + "," + topi.EstimatedTimeToMaster + "," +
            +topi.TimeSpent + "," + topi.Source + "," + topi.StartLearningDate + "," + topi.InProgress + "," + topi.CompletionDate);

            File.AppendAllText(path, a + Environment.NewLine);

            var csv = new StringBuilder();
            
            var newLine = string.Format("{0},{1}{2}{3}{4}{5}{6}{7}{8}", topi.Id, topi.Title, topi.Description ,topi.EstimatedTimeToMaster,
            +topi.TimeSpent, topi.Source, topi.StartLearningDate, topi.InProgress, topi.CompletionDate);
            csv.AppendLine(newLine);
            string streamReader = @"C:\Users\Jere\source\repos\diary\ID.csv";
            File.AppendAllText(streamReader, csv.ToString());

            

            

        }
        public static void Redman(Dictionary<int, Topic> uusTopi, Topic topi,string path)
        {
            Console.WriteLine("Anna Id");
            int num = Convert.ToInt32(Console.ReadLine());
            //string a = Convert.ToString(topi.Id + topi.Title + topi.Id + topi.Description + topi.EstimatedTimeToMaster + topi.TimeSpent + topi.Source + topi.StartLearningDate + topi.InProgress + topi.CompletionDate);
            //IEnumerable<string> line = File.ReadAllLines(path);
            using (StreamReader inputFile = new StreamReader(path))
            if (uusTopi.ContainsKey(num))
                {
                    for( int i = 1; i < num; i++)
                    {
                        inputFile.ReadLine();
                    }
                
                Console.WriteLine("Löytyy");
                    Console.WriteLine(inputFile.ReadLine());
                //Console.WriteLine(string.Join(Environment.NewLine, line));
                return;
            }
            else
            {
                Console.WriteLine("ei löydy");
            }
            /*var loki = File.ReadAllLines(@"C:\Users\Jere\source\repos\Oppikirja\Id.txt");
            
            var  lokikirja = new List<String>(loki);
            for (int i = 0; i < lokikirja.Count; i++)
            {
                
                Console.WriteLine(lokikirja[i]);
            }*/
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
        public static void OldDirtyBastard(string path, Topic topi, Dictionary<int, Topic> uusTopi)
        {
            string[] csv = File.ReadAllLines(path);
            for (int i = 1; i < csv.Length; i++)
            {
                
                
                    string[] dataCsv = csv[i].Split(',');

                    topi.Id = Convert.ToInt32(dataCsv[0]);
                    topi.Title = dataCsv[1];
                    topi.Description = dataCsv[2];
                    topi.EstimatedTimeToMaster = Convert.ToDouble(dataCsv[3]);
                    topi.TimeSpent = Convert.ToDouble(dataCsv[4]);
                    topi.Source = dataCsv[5];
                    topi.StartLearningDate = Convert.ToDateTime(dataCsv[6]);
                    topi.InProgress = Convert.ToBoolean(dataCsv[7]);
                    topi.CompletionDate = Convert.ToDateTime(dataCsv[8]);
                    uusTopi.Add(topi.Id, topi);
                    foreach (string ou in dataCsv)

                    {
                    Console.WriteLine(ou);
                    }


                }
                Console.WriteLine(topi.Id + topi.Title);
            }
        }

    }

