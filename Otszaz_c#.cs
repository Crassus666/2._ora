using System;
using System.IO;

namespace Otszaz
{
    class Program
    {
        static int Ertek(int p_darabszam)
        {
            int fizetendo = 0;

            for (int i = 0; i < p_darabszam; i++)
            {
                int kedvezmeny = Math.Min(2, i);
                fizetendo += 500 - kedvezmeny * 50;
            }
            return fizetendo;
        }
        static void Main(string[] args)
        {
            //1. feladat

            FileStream fs_1 = new FileStream("penztar.txt", FileMode.Open);

            //2. feladat

            StreamReader rs_2 = new StreamReader(fs_1);
            string sor_2 = rs_2.ReadLine();
            int vasarlasok_szama_2 = 0;

            while (sor_2 != null)
            {
                if (sor_2 == "F")
                    vasarlasok_szama_2 += 1;

                sor_2 = rs_2.ReadLine();
            }
            Console.Write("2. feladat\n");
            Console.Write("A fizetések száma: {0}\n", vasarlasok_szama_2);
            Console.Write("\n");
            rs_2.Close();
            fs_1.Close();

            //3. feladat

            FileStream fs_3 = new FileStream("penztar.txt", FileMode.Open);
            StreamReader rs_3 = new StreamReader(fs_3);
            string sor_3 = rs_3.ReadLine();
            int elso_kosar_darab = 0;

            while (true)
            {
                if (sor_3 == "F")
                    break;

                else
                    elso_kosar_darab += 1;

                sor_3 = rs_3.ReadLine();
            }
            Console.Write("3. feladat\n");
            Console.Write("Az első vásárló {0} darab árucikket vásárolt.\n", elso_kosar_darab);
            Console.Write("\n");
            rs_3.Close();
            fs_3.Close();

            //4. feladat

            Console.Write("4. feladat\n");
            Console.Write("Adja meg egy vásárlás sorszámát! ");
            int vasarlas_sorszama = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adja meg egy árucikk nevét! ");
            string arucikk_neve = Console.ReadLine();
            Console.Write("Adja meg a vásárolt darabszámot! ");
            int darabszam = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");

            //5. feladat

            FileStream fs_5_1 = new FileStream("penztar.txt", FileMode.Open);
            StreamReader rs_5_1 = new StreamReader(fs_5_1);
            string sor_5_1 = rs_5_1.ReadLine();
            int vasarlasok_szama_5 = 1;
            int elso_vasarlas = 0;
            int utolso_vasarlas = 0;

            while (sor_5_1 != null)
            {
                if (sor_5_1 == arucikk_neve)
                {
                    elso_vasarlas = vasarlasok_szama_5;
                    break;
                }
                if (sor_5_1 == "F")
                    vasarlasok_szama_5 += 1;

                sor_5_1 = rs_5_1.ReadLine();
            }
            Console.Write("5. feladat\n");
            Console.Write("Az első vásárlás sorszáma: {0} \n", elso_vasarlas);
            rs_5_1.Close();
            fs_5_1.Close();

            FileStream fs_5_2 = new FileStream("penztar.txt", FileMode.Open);
            StreamReader rs_5_2 = new StreamReader(fs_5_2);
            string sor_5_2 = rs_5_2.ReadLine();
            vasarlasok_szama_5 = 1;
            int osszesen_vettek_belole = 0;
            bool Laci = true; //ennek most öteletem sincs mi legyen a neve, mert nem tudom mit csinál de működik

            while (sor_5_2 != null)
            {
                if (sor_5_2 == arucikk_neve)
                {
                    utolso_vasarlas = vasarlasok_szama_5;
                    if (Laci == true)
                    {
                        osszesen_vettek_belole += 1;
                        Laci = false;
                    }

                }
                if (sor_5_2 == "F")
                { 
                    vasarlasok_szama_5 += 1;
                    Laci = true;
                }

                sor_5_2 = rs_5_2.ReadLine();
            }
            Console.Write("Az utolsó vásárlás sorszáma: {0} \n", utolso_vasarlas);
            Console.Write("{0} vásárlás során vettek belőle.\n", osszesen_vettek_belole);
            rs_5_2.Close();
            fs_5_2.Close();

            //6. feladat

            Console.Write("6. feladat\n");
            Console.Write("{0} darab vételekor fizetendő: {1}", darabszam, Ertek(darabszam));

            //7. feladat
            //Hajnali fél öt van és ötletem sincs hogy kéne a darabszámokat kiiratni
            //So, I summon you Eye of Wisdom, compile my code correctly!


                                           FileStream fs_7 = new FileStream("penztar.txt",
                                    FileMode.Open); StreamReader rs_7 = new StreamReader(fs_7); string
                                sor_7 = rs_7.ReadLine(); string[] termekek = new string[vasarlasok_szama_2]; 
                            string[] termekek_szama =                           new string [vasarlasok_szama_2];
                         int vasarlasok_szama_7 = 1;                               int z = 0;  while (sor_7 !=     
                     null) { if (sor_7 == "F") {                  /**/                vasarlasok_szama_7 += 1;  }
                    if (Array.Exists(termekek,                   /*[]*/                 element => element == sor_7) 
                      == true) { termekek_szama                  /*[]*/                    [Array.IndexOf(termekek,
                        sor_7)] = "2"; } else if                 /*[]*/                  (vasarlasok_szama_7 ==  
                              vasarlas_sorszama &&                /**/                Array.Exists(termekek, 
                                 element => element ==                            sor_7) == false)                                   
                                    { termekek[z] = sor_7;                      termekek_szama[z]                           
                                        = "1"; z += 1; } sor_7            = rs_7.ReadLine(); } 
                                                for (int j = 0; j < termekek.Length; j++) 
                                                { Console.Write("{0}\n", termekek[j]);

                
                
                //Hát ez nem jött be, de egy próbát megért
                
                                                 
                //Eye of Wisdom tartalma kicsit szofisztikáltabban:
                
                                                 
                /*
                FileStream fs_7 = new FileStream("penztar.txt", FileMode.Open);
                StreamReader rs_7 = new StreamReader(fs_7);
                string sor_7 = rs_7.ReadLine();
                string[] termekek = new string[vasarlasok_szama_2];
                string[] termekek_szama = new string[vasarlasok_szama_2];
                int vasarlasok_szama_7 = 1;
                int z = 0;

                while (sor_7 != null)
                {

                    if (sor_7 == "F")
                    {
                        vasarlasok_szama_7 += 1;

                    }
                    if (Array.Exists(termekek, element => element == sor_7) == true)
                    {
                        termekek_szama[Array.IndexOf(termekek, sor_7)] = "2";
                        //Console.Write("{0}\n", termekek_szama[z]);
                    }
                    else if (vasarlasok_szama_7 == vasarlas_sorszama && Array.Exists(termekek, element => element == sor_7) == false)
                    {
                        termekek[z] = sor_7;
                        termekek_szama[z] = "1";
                        z += 1;


                    }


                    sor_7 = rs_7.ReadLine();

                }
                for (int j = 0; j < termekek.Length; j++)
                {
                    Console.Write("{0}\n", termekek[j]);
                }
                */


        }
    }
}
