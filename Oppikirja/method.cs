using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using System.Linq;
using System.ComponentModel;
using Oppikirja.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Oppikirja
{

    public class Method

    {

        public static void Methodman(Topic topi, List<Topic> listuri)
        {
              
    
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
            


            using (DiaryContext kokeilu = new DiaryContext())
            {
                Table1 pöytä = new Table1()
                {
                    
                    Title = topi.Title,
                    Description = topi.Description,
                    TimeToMaster = Convert.ToInt32(topi.EstimatedTimeToMaster),
                    TimeSpent = Convert.ToInt32(topi.TimeSpent),
                    Source = topi.Source,
                    StartLearningDate = topi.StartLearningDate,
                    InProgress = topi.InProgress,
                    CompletionDate = topi.CompletionDate
                };
                kokeilu.Table1s.Add(pöytä);
                kokeilu.SaveChanges();
            }
        }
        public static void Gza(Topic topi, List<Topic> listuri, int num, string nim)
        {
            Console.Clear();
            DiaryContext yolo = new DiaryContext();
            var jolo = (from o in yolo.Table1s where o.Title == nim select o).ToList();
            var jojo = (from o in yolo.Table1s where o.Id == num select o).ToList();
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
            foreach( var o in jolo)
            {
                yolo.Remove(o);

            }
            foreach (var o in jojo)
            {
                yolo.Remove(o);
            }
            yolo.SaveChanges();
        }

        public static void Redman( Topic topi,  List<Topic> listuri, DiaryContext context)
        {
            Console.WriteLine("Anna Title");
            DiaryContext yolo = new DiaryContext();
            int num = 2;
            string nim = Console.ReadLine();
            Console.Clear();
            if (listuri.Select(a => a.Title == nim).Any())
            {

                Console.WriteLine("Vauuu löysit oikeean paikkaan.");
                Console.WriteLine("1.Poista tieto\n" +
                    "Muokkaa tietoja\n\n"+
                    "2. Otsikko\n" +
                    "3. Kommentti\n" +
                    "4. Opiskeluun tarvittava aika\n" +
                    "5. Tuhlattu aika\n" +
                    "6. Lähde\n" +
                    "7. Aloitus päivämäärä\n" +
                    "8. Valmistumispäivä\n\n" +
                    "9. Tarkasta tiedot");
                int valinta = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                var jolo = (from o in yolo.Table1s where o.Title == nim select o).ToList();
                switch (valinta)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Poista osio");
                        Gza(topi, listuri,num, nim);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Anna uusi otsikko");
                        string uusiTitle = Console.ReadLine();

                        listuri.Select(i =>
                         {
                             if (i.Title == nim) i.Title = uusiTitle;
                             return i;
                         }).ToList();
                        
                        foreach(var o in jolo)
                        {
                            o.Title = uusiTitle;
                            
                        }
                       
                        Console.ReadLine();
                        Console.Clear();

                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Anna uusi kommentti");
                        string uusiDes = Console.ReadLine();
                        listuri.Select(i =>
                        {
                            if (i.Title == nim) i.Description = uusiDes;
                            return i;
                        }).ToList();
                        
                        foreach (var o in jolo)
                        {
                            o.Description = uusiDes;

                        }
                        yolo.SaveChanges();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Anna uusi aika-arvio");
                        double aika = Convert.ToDouble(Console.ReadLine());
                        listuri.Select(i =>
                        {
                            if (i.Title == nim) i.EstimatedTimeToMaster = aika;
                            return i;
                        }).ToList();
                        
                        foreach (var o in jolo)
                        {
                            o.TimeToMaster = Convert.ToInt32(aika);

                        }
                        yolo.SaveChanges();
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
                        
                        foreach (var o in jolo)
                        {
                            o.TimeSpent = Convert.ToInt32(tuhaika);

                        }
                        yolo.SaveChanges();
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
                        foreach (var o in jolo)
                        {
                            o.Source = lähde;

                        }
                        yolo.SaveChanges();
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
                        foreach (var o in jolo)
                        {
                            o.StartLearningDate = Convert.ToDateTime(alote);

                        }
                        yolo.SaveChanges();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 8:
                        Console.Clear();
                        Console.WriteLine("Anna uusi valmistumipäivä");
                        DateTime lopete = Convert.ToDateTime(Console.ReadLine());
                        listuri.Select(i =>
                        {
                            i.InProgress = false;
                            if (i.Title == nim) i.CompletionDate = lopete;
                            return i;
                        }).ToList();
                        foreach (var o in jolo)
                        {
                            o.CompletionDate = Convert.ToDateTime(lopete);
                            o.InProgress = false;
                        }
                        yolo.SaveChanges();
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
                        var t = (from s in context.Table1s select s).ToList();
                        foreach (var on in t)
                        {
                            listuri.Add(new Topic
                            {
                               
                                Title = on.Title,
                                Description = on.Description,
                                EstimatedTimeToMaster = Convert.ToDouble(on.TimeToMaster),
                                TimeSpent = Convert.ToDouble(on.TimeSpent),
                                Source = on.Source,
                                StartLearningDate = Convert.ToDateTime(on.StartLearningDate),
                                InProgress = Convert.ToBoolean(on.InProgress),
                                CompletionDate = Convert.ToDateTime(on.CompletionDate)
                            });// LUO TÄSTÄ METODI 
                        };
                        break;
                }
               
            }
        }
        public static void Ghostfacekillah(Topic topi, List<Topic> listuri)
        {
            Console.WriteLine("Anna ID?");
            
            int num = Convert.ToInt32(Console.ReadLine());
            string nim = "";
            DiaryContext yolo = new DiaryContext();
            var jolo = (from o in yolo.Table1s where o.Id == num select o).ToList();
            Console.Clear();
            if (listuri.Select(a => a.Id == num).Any())
            {

                Console.WriteLine("Mitä haluat muokata");
                Console.WriteLine("1.Poista tieto\n\n" +
                    "Muokkaa tietoja\n" +
                    "2. Otsikko\n" +
                    "3. Kommentti\n" +
                    "4. Opiskeluun tarvittava aika\n" +
                    "5. Tuhlattu aika\n" +
                    "6. Lähde\n" +
                    "7. Aloitus päivämäärä\n" +
                    "8. Valmistumispäivä\n\n" +
                    "9. Tarkasta tiedot");
                int valinta = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (valinta)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Poista tiedosto");
                        Gza(topi, listuri, num, nim);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Anna uusi otsikko");
                        string uusiTitle = Console.ReadLine();
                        listuri.Select(i =>
                        {
                            if (i.Id == num) i.Title = uusiTitle;
                            return i;
                        }).ToList();
                        foreach (var o in jolo)
                        {
                            o.Title = uusiTitle;

                        }
                        yolo.SaveChanges();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Anna uusi kommentti");
                        string uusiDes = Console.ReadLine();
                        listuri.Select(i =>
                        {
                            if (i.Id == num) i.Description = uusiDes;
                            return i;
                        }).ToList();
                        foreach (var o in jolo)
                        {
                            o.Description = uusiDes;

                        }
                        yolo.SaveChanges();
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
                        foreach (var o in jolo)
                        {
                            o.TimeToMaster = Convert.ToInt32(aika);

                        }
                        yolo.SaveChanges();
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
                        foreach (var o in jolo)
                        {
                            o.TimeSpent = Convert.ToInt32(tuhaika);

                        }
                        yolo.SaveChanges();
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
                        foreach (var o in jolo)
                        {
                            o.Source = lähde;

                        }
                        yolo.SaveChanges();
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
                        foreach (var o in jolo)
                        {
                            o.StartLearningDate = alote;

                        }
                        yolo.SaveChanges();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 8:
                        Console.Clear();
                        Console.WriteLine("Anna uusi Valmistumipäivä");
                        DateTime lopete = Convert.ToDateTime(Console.ReadLine());
                        listuri.Select(i =>
                        {
                            i.InProgress = false;
                            if (i.Id == num) i.CompletionDate = lopete;
                            return i;
                        }).ToList();
                        foreach (var o in jolo)
                        {
                            o.InProgress = false;
                            o.CompletionDate = lopete;

                        }
                        yolo.SaveChanges();
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
        public static void Raekwon(List<Topic> listuri, Topic topi )
        {
            






        }
        public static void OldDirtyBastard( Topic topi, List<Topic> listuri)
        {
           
                
                listuri.Add(new Topic {
                    
                    Title = topi.Title,
                    Description = topi.Description,
                    EstimatedTimeToMaster = topi.EstimatedTimeToMaster,
                    TimeSpent = topi.TimeSpent,
                    Source = topi.Source,
                    StartLearningDate = topi.StartLearningDate,
                    InProgress = topi.InProgress,
                    CompletionDate = topi.CompletionDate
                });
               
            
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


