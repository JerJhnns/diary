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
using Oppikirja;
using ClassLibrary1;
using System.Threading;
using System.Threading.Tasks;

namespace Oppikirja
{

    public class Method
    
    {

        public static void Methodman(Topic topi)
        {
            Class1 kirjasto =  new Class1();

            while (true)
            {
                try
                {
                    Console.WriteLine("Aiheen otsikko");
                    topi.Title = Console.ReadLine();
                  
                }
                catch (Exception e) { Console.WriteLine(e.Message); continue; }
                break;
            }
            try
            {
                Console.WriteLine("Anna aiheen kuvaus");
                topi.Description = Console.ReadLine();
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            while (true)
            {


                try
                {
                    Console.WriteLine("Anna aika arvio h.m");
                    topi.EstimatedTimeToMaster = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception e) { Console.WriteLine(e.Message); continue; }
                break;
            }
            Console.WriteLine("Kauanko olet opiskellut h.m");
            topi.TimeSpent = Convert.ToDouble(Console.ReadLine());
            while (true)
            {


                try
                {
                    Console.WriteLine("Anna mahdollinen lähde: ");
                    topi.Source = Console.ReadLine();
                }
                catch (Exception e) { Console.WriteLine(e.Message); continue; }
                break;
            }
            while (true)
            {
                try
                {
                    Console.WriteLine("Anna aloitus aika: dd/MM/yyyy ");
                    topi.StartLearningDate = Convert.ToDateTime(Console.ReadLine());
                }
                catch (Exception e) { Console.WriteLine(e.Message); continue; }
                break;
            }
            while (true)
            {
                Console.WriteLine("Onko opiskelu kesken? Y/N");
                var valinta = Console.ReadLine();


                if (valinta == "N") { topi.InProgress = false; }
                if (valinta == "Y") { topi.InProgress = true; }
                else { continue; }
                break;
            }
           


            while (true)
            {
                try
                {
                    Console.WriteLine("Anna valmistumispäivä: dd/MM/yyyy ");
                    topi.CompletionDate = Convert.ToDateTime(Console.ReadLine());
                }
                catch (Exception e) { Console.WriteLine(e.Message); continue; }
                break;
            }
            kirjasto.A = topi.CompletionDate;
            kirjasto.B = topi.StartLearningDate;
            kirjasto.C = topi.InProgress;

            /*kirjasto.Tarkistus();
            kirjasto.Myohassa();
            Console.Read();*/

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
       
        public static void Gza(Topic topi, int num, string nim)
        {
            Console.Clear();
            DiaryContext yolo = new DiaryContext();
            try
            {
                var jolo = (from o in yolo.Table1s where o.Title == nim select o).ToList();
                var jojo = (from o in yolo.Table1s where o.Id == num select o).ToList();


                foreach (var o in jolo)
                {
                    yolo.Remove(o);

                }
                foreach (var o in jojo)
                {
                    yolo.Remove(o);
                }
                yolo.SaveChanges();
            }
            catch (Exception) { Console.WriteLine("Valitsemaasi IDtä tai Topiccia ei löydt"); }
        }

        public static void Redman( Topic topi, DiaryContext context)

        {
            
            while (true)
            {
               
                Console.WriteLine("Anna Id tai Title");
                DiaryContext yolo = new DiaryContext();

                string nim = Console.ReadLine();
                int num;
                if (int.TryParse(nim, out num)) { }

                var jolo = (from o in yolo.Table1s where o.Title == nim || o.Id == num select o).FirstOrDefault();
                if (jolo == null)
                {
                    Console.Clear();
                    Console.WriteLine("VITTU VALISTE OLEMASSA OLEVA ASIA");
                    
                    continue;
                }
                Console.Clear();

                Console.WriteLine("Vauuu löysit oikeean paikkaan.");
                Console.WriteLine("1.Poista tieto\n" +
                    "Muokkaa tietoja\n\n" +
                    "2. Otsikko\n" +
                    "3. Kommentti\n" +
                    "4. Opiskeluun tarvittava aika\n" +
                    "5. Tuhlattu aika\n" +
                    "6. Lähde\n" +
                    "7. Aloitus päivämäärä\n" +
                    "8. Valmistumispäivä\n" +
                    "9. Keskeneräisyyden muuttaminen\n\n" +
                    "10. Tarkasta tiedot");
                int valinta = Convert.ToInt32(Console.ReadLine());
                Console.Clear();


                switch (valinta)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Poista osio");
                        Gza(topi, num, nim);
                        break;
                    case 2:
                        Console.Clear();
                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Anna uusi otsikko");
                                string uusiTitle = Console.ReadLine();
                                jolo.Title = uusiTitle;
                                yolo.SaveChanges();
                                
                            }
                            catch (Exception e) { Console.WriteLine(e.Message); continue; }
                            break;
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Anna uusi kommentti");
                        string uusiDes = Console.ReadLine();
                        jolo.Description = uusiDes;
                        
                        yolo.SaveChanges();
                        break;
                    case 4:
                        Console.Clear();
                        while (true)
                        {

                            try
                            {

                                Console.WriteLine("Anna uusi aika-arvio");
                                double aika = Convert.ToDouble(Console.ReadLine());
                                jolo.TimeSpent = Convert.ToInt32(aika);
                                yolo.SaveChanges();
                            }
                            catch (Exception e) { Console.WriteLine(e.Message); continue; }
                            break;
                        }
                        break;
                    case 5:
                        Console.Clear();
                        while (true)
                        {
                            try
                            {

                            }
                            catch (Exception e) { Console.WriteLine(e.Message); continue; }
                            break;
                        }
                        Console.WriteLine("Anna uusi tuhlatun aja arvio");
                        double tuhaika = Convert.ToDouble(Console.ReadLine());

                            jolo.TimeSpent = Convert.ToInt32(tuhaika);

                        yolo.SaveChanges();
                        break;
                    case 6:
                        Console.Clear();
                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Anna uusi lähde");
                                string lähde = Console.ReadLine();

                                    jolo.Source = lähde;

                                yolo.SaveChanges();

                            }
                            catch (Exception e) { Console.WriteLine(e.Message); continue; }
                            break;
                        }

                        break;
                    case 7:
                        Console.Clear();
                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Anna uusi aloituspäivä");
                                DateTime alote = Convert.ToDateTime(Console.ReadLine());
                           
                                    jolo.StartLearningDate = Convert.ToDateTime(alote);
                                yolo.SaveChanges();

                            }
                            catch (Exception e) { Console.WriteLine(e.Message); continue; }
                            break;
                        }

                        break;
                    case 8:
                        Console.Clear();
                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Anna uusi valmistumipäivä");
                                DateTime lopete = Convert.ToDateTime(Console.ReadLine());

                                    jolo.CompletionDate = Convert.ToDateTime(lopete);

                                yolo.SaveChanges();
                            }
                            catch (Exception e) { Console.WriteLine(e.Message); continue; }
                            break;
                        }
                        break;
                    case 9:
                        Console.Clear();

                        while (true)
                        {

                            Console.WriteLine("Onko opiskelu kesken? Y/N");
                            var uusiValinta = Console.ReadLine();

                          
                                if (uusiValinta == "N") { jolo.InProgress = false; }
                                if (uusiValinta == "Y") { jolo.InProgress = true; }
                            
                            break;
                        }
                        break;

                    case 10:
                        Console.Clear();

                      
                            if (jolo.InProgress == true)
                            {
                                Console.WriteLine(jolo.Tulostus());
                            }
                            else
                            {
                                Console.WriteLine(jolo.Jalostus());
                            }


                        
                        Console.ReadKey();
                        break;
                }
                break;
            }

            
        }
        
        public static void Ghostfacekillah(Topic topi)
        {
           
           
                
            
        }
        public static void Raekwon()
        {


            Console.ForegroundColor
           = ConsoleColor.Blue;
            Console.Write("\t\t");
            for (int i = 0; i < 28; i++)
            {
                
                Console.Write("-");
                Thread.Sleep(55);
            }
            Console.ForegroundColor
            = ConsoleColor.DarkYellow;
            
            Console.WriteLine("\n\t\t\tTERVETULOA");
            Console.ForegroundColor
            = ConsoleColor.Blue;
            Console.Write("\t\t");
            for (int i = 0; i < 28; i++)
            {
                
                Console.Write("-");
                Thread.Sleep(55);
            }
            Console.ForegroundColor
                = ConsoleColor.White;
            Console.Write("\n");




        }
        public static void OldDirtyBastard()
        {

            Console.Clear();
            Console.ForegroundColor
            = ConsoleColor.Magenta;
            for (int i = 0; i < 28; i++)
            {
                Console.Write("-");
                Thread.Sleep(55);
            }
            Console.ForegroundColor
            = ConsoleColor.DarkYellow;
            Console.WriteLine("\n\tTERVEMENOA");
            Console.ForegroundColor
            = ConsoleColor.Magenta;
            for (int i = 0; i < 28; i++)
            {
                Console.Write("-");
                Thread.Sleep(55);
            }
            Console.WriteLine("\n\n\n\n\nSovellus on myynnissä lähtöhinta: 1 euro enemmän kuin Wolt");
            




        }
        public static void Rza()
        {
            DiaryContext kalle = new DiaryContext();
            try
            {
               
                var jolo = (from o in kalle.Table1s select o).ToList();
                foreach (var i in jolo)
                {

                    Console.WriteLine("ID: " + i.Id + " " + i.Title);

                }
                Console.ReadLine();
             
            }
            catch (Exception) { Console.WriteLine("Valitsemaasi IDtä tai Titleä ei löydy"); }
            return;
        }

        }

    }


