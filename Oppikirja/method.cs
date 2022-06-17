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
                topi.Id = listuri.Count + 1;
    
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


        }
        public static void Gza(Topic topi, List<Topic> listuri, int num, string nim)
        {
            Console.Clear();
     
            foreach ( var i in listuri.ToList())
            {
                if (i.Id == num) {

                    listuri.Remove(i);
                }
                if (i.Title == nim)
                {
                    listuri.Remove(i);
                }
            }

          
        }

        public static void Redman(Dictionary<int, Topic> uusTopi, Topic topi, string path, List<Topic> listuri)
        {
            Console.WriteLine("Anna Title");

            int num = 2;
            string nim = Console.ReadLine();
            Console.Clear();
            if (listuri.Select(a => a.Title == nim).Any())
            {

                Console.WriteLine("Mitä haluat muokata");
                Console.WriteLine("1.Poista tieto\n" +
                    "2.Title\n" +
                    "3.Description\n" +
                    "4.Estimated Time\n" +
                    "5. Tuhlattu aikan\n" +
                    "6. Lähde\n" +
                    "7. Aloitus aika\n" +
                    "8. Valmistumispäivä\n" +
                    "9. Tarkasta tiedot");
                int valinta = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (valinta)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Poista osio");
                        Gza(topi, listuri,num, nim);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Anna uusi Title");
                        string uusiTitle = Console.ReadLine();

                        listuri.Select(i =>
                         {
                             if (i.Title == nim) i.Title = uusiTitle;
                             return i;
                         }).ToList();
                        Console.ReadLine();
                        Console.Clear();

                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Anna uusi Description");
                        string uusiDes = Console.ReadLine();
                        listuri.Select(i =>
                        {
                            if (i.Title == nim) i.Description = uusiDes;
                            return i;
                        }).ToList();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Anna uusi aika arvio");
                        double aika = Convert.ToDouble(Console.ReadLine());
                        listuri.Select(i =>
                        {
                            if (i.Title == nim) i.EstimatedTimeToMaster = aika;
                            return i;
                        }).ToList();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Anna uusi tuhlatun aja arvio");
                        double tuhaika = Convert.ToDouble(Console.ReadLine());
                        listuri.Select(i =>
                        {
                            if (i.Title == nim) i.TimeSpent = tuhaika;
                            return i;
                        }).ToList();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Anna uusi lähde");
                        string lähde = Console.ReadLine();
                        listuri.Select(i =>
                        {
                            if (i.Title == nim) i.Source = lähde;
                            return i;
                        }).ToList();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("Anna uusi aloituspäivä");
                        DateTime alote = Convert.ToDateTime(Console.ReadLine());
                        listuri.Select(i =>
                        {
                            if (i.Title == nim) i.StartLearningDate = alote;
                            return i;
                        }).ToList();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 8:
                        Console.Clear();
                        Console.WriteLine("Anna uusi Valmistumipäivä");
                        DateTime lopete = Convert.ToDateTime(Console.ReadLine());
                        listuri.Select(i =>
                        {
                            if (i.Title == nim) i.CompletionDate = lopete;
                            return i;
                        }).ToList();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 9:
                        Console.Clear();
                        var lista = listuri.Where(x => (x.Title == nim));
                        foreach (var o in lista)
                        {
                            if (o.InProgress == true)
                            {
                                Console.WriteLine(o.Tulostus());
                            }
                            else
                            {
                                Console.WriteLine(o.Jalostus());
                            }
                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
               
            }
        }
        public static void Ghostfacekillah(Topic topi, List<Topic> listuri)
        {
            Console.WriteLine("Anna ID?");
            
            int num = Convert.ToInt32(Console.ReadLine());
            string nim = "";

            Console.Clear();
            if (listuri.Select(a => a.Id == num).Any())
            {

                Console.WriteLine("Mitä haluat muokata");
                Console.WriteLine("1.Poista tieto\n" +
                    "2.Title\n" +
                    "3.Description\n" +
                    "4.Estimated Time\n" +
                    "5. Tuhlattu aikan\n" +
                    "6. Lähde\n" +
                    "7. Aloitus aika\n" +
                    "8. Valmitumispäivä\n" +
                    "9. Tarkasta tiedot");
                int valinta = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (valinta)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Poista osio");
                        Gza(topi, listuri, num, nim);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Anna uusi Title");
                        string uusiTitle = Console.ReadLine();
                        listuri.Select(i =>
                        {
                            if (i.Id == num) i.Title = uusiTitle;
                            return i;
                        }).ToList();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Anna uusi Description");
                        string uusiDes = Console.ReadLine();
                        listuri.Select(i =>
                        {
                            if (i.Id == num) i.Description = uusiDes;
                            return i;
                        }).ToList();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Anna uusi aika arvio");
                        double aika = Convert.ToDouble(Console.ReadLine());
                        listuri.Select(i =>
                        {
                            if (i.Id == num) i.EstimatedTimeToMaster = aika;
                            return i;
                        }).ToList();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Anna uusi tuhlatun aja arvio");
                        double tuhaika = Convert.ToDouble(Console.ReadLine());
                        listuri.Select(i =>
                        {
                            if (i.Id == num) i.TimeSpent = tuhaika;
                            return i;
                        }).ToList();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Anna uusi lähde");
                        string lähde = Console.ReadLine();
                        listuri.Select(i =>
                        {
                            if (i.Id == num) i.Source = lähde;
                            return i;
                        }).ToList();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("Anna uusi aloituspäivä");
                        DateTime alote = Convert.ToDateTime(Console.ReadLine());
                        listuri.Select(i =>
                        {
                            if (i.Id == num) i.StartLearningDate = alote;
                            return i;
                        }).ToList();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 8:
                        Console.Clear();
                        Console.WriteLine("Anna uusi Valmistumipäivä");
                        DateTime lopete = Convert.ToDateTime(Console.ReadLine());
                        listuri.Select(i =>
                        {
                            if (i.Id == num) i.CompletionDate = lopete;
                            return i;
                        }).ToList();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 9:
                        var lista = listuri.Where(x => (x.Id == num));
                        foreach(var o in lista)
                        {
                            if (o.InProgress == true)
                            {
                                Console.WriteLine(o.Tulostus());
                            }
                            else
                            {
                                Console.WriteLine(o.Jalostus());
                            }
                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
                
            }
            else { }
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
        public static void Rza(List<Topic> listuri)
        {
            foreach (var i in listuri)
            {

                Console.WriteLine(i.Id);
                Console.WriteLine(i.Title);
            }
            Console.ReadLine();
            return;
        }
        }

    }


