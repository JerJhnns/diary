using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using System.Linq;
using System.ComponentModel;

namespace Oppikirja
{

    public class Method

    {

        public static void Methodman(string path, Dictionary<int, Topic> uusTopi, Topic topi, List<Topic> listuri, string path2)
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
                {
                    topi.InProgress = true; topi.CompletionDate = DateTime.Today;
                }

            }
            catch (Exception e)
            { Console.WriteLine(e.Message); }
            listuri.Add(new Topic
            {
                Id = topi.Id,
                Title = topi.Title,
                Description = topi.Description,
                EstimatedTimeToMaster = topi.EstimatedTimeToMaster,
                TimeSpent = topi.TimeSpent,
                Source = topi.Source,
                StartLearningDate = topi.StartLearningDate,
                InProgress = topi.InProgress,
                CompletionDate = topi.CompletionDate
            });
            uusTopi.Add(topi.Id, topi);
            var newLine = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8}", topi.Id, topi.Title, topi.Description, topi.EstimatedTimeToMaster
             ,topi.TimeSpent, topi.Source, topi.StartLearningDate, topi.InProgress, topi.CompletionDate);

            File.AppendAllText(path, newLine + Environment.NewLine);





            /*var configigi = new CsvConfiguration(CultureInfo.InvariantCulture)
            { HasHeaderRecord = false };

            listuri.Add(topi);

            using var mem = new MemoryStream();
            using var writer = new StreamWriter(path2);
            using var csvWriter = new CsvWriter(writer, CultureInfo.CurrentCulture);

            csvWriter.WriteField("ID");
            csvWriter.WriteField("Title");
            csvWriter.WriteField("Description");
            csvWriter.WriteField("EstimatedTimeToMaster");
            csvWriter.WriteField("TimeSpent");
            csvWriter.WriteField("Source");
            csvWriter.WriteField("StartLearningDate");
            csvWriter.WriteField("InProgress");
            csvWriter.WriteField("CompletionDate");
            csvWriter.NextRecord();

            foreach (var user in listuri)
            {
                csvWriter.WriteField(user.Id);
                csvWriter.WriteField(user.Title);
                csvWriter.WriteField(user.Description);
                csvWriter.WriteField(user.EstimatedTimeToMaster);
                csvWriter.WriteField(user.TimeSpent);
                csvWriter.WriteField(user.Source);
                csvWriter.WriteField(user.StartLearningDate);
                csvWriter.WriteField(user.InProgress);
                csvWriter.WriteField(user.CompletionDate);
                csvWriter.NextRecord();
            }*/











        }
        public static void Redman(Dictionary<int, Topic> uusTopi, Topic topi, string path, List<Topic> listuri)
        {
            Console.WriteLine("Anna Id");
            int num = Convert.ToInt32(Console.ReadLine());
            bool x = listuri.Select(a => a.Id == num).Any();


            if (x == true)
            {
                
                Console.WriteLine("Mitä haluat muokata");
                Console.WriteLine("1.Poista tieto\n" +
                    "2.Title\n" +
                    "3.Description\n" +
                    "4.Estimated Time\n" +
                    "5. Tuhlattu aikan\n" +
                    "6. Lähde\n" +
                    "7. Aloitus aika\n" +
                    "8. Vaiheessa\n" +
                    "9. Valmistumispäivä");
                int valinta = Convert.ToInt32(Console.ReadLine());

                switch (valinta)
                {
                    case 1:
                        Console.WriteLine("Anna uusi ID");
                        break;
                    case 2:

                        Console.WriteLine("Anna uusi Title");
                        string uusiTitle = Console.ReadLine();

                        listuri.Select(i=>
                         {
                             if (i.Id == num) i.Title = uusiTitle;
                             return i;
                         }).ToList();
                       

                        



                        break;
                    case 3:
                        Console.WriteLine("Anna uusi Description");
                        string uusiDes = Console.ReadLine();
                        listuri.Select(i =>
                        {
                            if (i.Id == num) i.Description = uusiDes;
                            return i;
                        }).ToList();
                        break;
                    case 4:
                        Console.WriteLine("Anna uusi aika arvio");
                        double aika = Convert.ToDouble(Console.ReadLine());
                        listuri.Select(i =>
                        {
                            if (i.Id == num) i.EstimatedTimeToMaster = aika;
                            return i;
                        }).ToList();
                        break;
                    case 5:
                        Console.WriteLine("Anna uusi tuhlatun aja arvio");
                        double tuhaika = Convert.ToDouble(Console.ReadLine());
                        listuri.Select(i =>
                        {
                            if (i.Id == num) i.TimeSpent = tuhaika;
                            return i;
                        }).ToList();
                        break;
                    case 6:
                        Console.WriteLine("Anna uusi lähde");
                        string lähde = Console.ReadLine();
                        listuri.Select(i =>
                        {
                            if (i.Id == num) i.Source = lähde;
                            return i;
                        }).ToList();
                        break;
                    case 7:
                        Console.WriteLine("Anna uusi aloituspäivä");
                        DateTime alote = Convert.ToDateTime(Console.ReadLine());
                        listuri.Select(i =>
                        {
                            if (i.Id == num) i.StartLearningDate = alote;
                            return i;
                        }).ToList();
                        break;
                    case 8:
                        Console.WriteLine("Oletko saanut homman valmiiksi? Y/N");
                        string kesken = Console.ReadLine();
                        if (kesken == "Y")
                        {

                            listuri.Select(i =>
                            {
                                if (i.Id == num) i.InProgress = true;
                                return i;
                            }).ToList();
                        }
                        if (kesken == "N")
                        {

                            listuri.Select(i =>
                            {
                                if (i.Id == num) i.InProgress = false;
                                return i;
                            }).ToList();
                        }
                        break;
                    case 9:
                        Console.WriteLine("Anna uusi ID");
                        DateTime lopete = Convert.ToDateTime(Console.ReadLine());
                        listuri.Select(i =>
                        {
                            if (i.Id == num) i.CompletionDate = lopete;
                            return i;
                        }).ToList();
                        break;

                }
                    return;
                }
                else
                {
                    Console.WriteLine("ei löydy");
                }

        }
        public static void Ghostfacekillah()
        {
            
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
        public static void OldDirtyBastard(string path, Topic topi, Dictionary<int, Topic> uusTopi, List<Topic> listuri)
        {
            string[] csv = File.ReadAllLines(@"C:\Users\Jere\source\repos\Oppikirja\Id.txt");
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
                
                listuri.Add(new Topic {
                    Id = topi.Id,
                    Title = topi.Title,
                    Description = topi.Description,
                    EstimatedTimeToMaster = topi.EstimatedTimeToMaster,
                    TimeSpent = topi.TimeSpent,
                    Source = topi.Source,
                    StartLearningDate = topi.StartLearningDate,
                    InProgress = topi.InProgress,
                    CompletionDate = topi.CompletionDate
                });
                uusTopi.Add(topi.Id, topi);
                }
                
            } 

        }

    }


