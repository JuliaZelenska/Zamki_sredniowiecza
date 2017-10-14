using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Yuliia Zelenska nr. albumu 28951

namespace zamki
{

    class Program
    {

        private void skarbiec(Program p,zamek zamek1)
        {
            Console.Clear();
            Console.WriteLine("W skarbcu jest {0} złota", zamek1.Getzloto());
            Console.WriteLine("z zebrac podatki ({0})",zamek1.Getrobotnicy());
            Console.WriteLine("w wroc");
            string wybor = Console.ReadLine();
            bool graj = true;
            while (graj == true)
            {
                switch (wybor)
                {
                    case "z":
                        if (zamek1.Getpodatki() <= 0) 
                        {
                            Console.Clear();
                            Console.WriteLine("W tym tygodniu zebrano podatki dwa razy");
                            Console.WriteLine("Zbyt czeste podatki");
                            Console.ReadLine();
                        }
                        else { zamek1.podatki(); } 
                        wybor = "null";
                        break;
                    case "w":
                        graj = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("W skarbcu jest {0} złota", zamek1.Getzloto());
                        Console.WriteLine("z zbierz podatki ({0})", zamek1.Getrobotnicy());
                        Console.WriteLine("w wroc");
                        wybor = Console.ReadLine();
                        break;
                }
            }

        }

        private void armia(Program p,zamek zamek1)
        {
            Console.Clear();
            Console.WriteLine("Armia liczy {0} zolnierzy", zamek1.Getzolnierze());
            Console.WriteLine("Każdy zolnierz konsumuje 2 jedzenia. Obecna produkcja: {0}", (zamek1.Getrobotnicy() - zamek1.Getzolnierze()) * 2); 
            Console.WriteLine("r rekrutuj (-10 szt. zlota) obecnie w skarbcu: {0}", zamek1.Getzloto());
            Console.WriteLine("w wroc");
            string wybor = Console.ReadLine();
            bool graj = true;
            while (graj == true)
            {
                switch (wybor)
                {
                    case "r":
                        zamek1.rekrutuj(); 
                        wybor = "null";
                        break;
                    case "w":
                        graj = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Armia liczy {0} zolnierzy", zamek1.Getzolnierze());
                        Console.WriteLine("Każdy zolnierz konsumuje 2 jedzenia. Obecna produkcja: {0}", (zamek1.Getrobotnicy() - zamek1.Getzolnierze()) * 2);
                        Console.WriteLine("r rekrutuj (-10 szt. zlota) obecnie w skarbcu: {0}", zamek1.Getzloto());
                        Console.WriteLine("w wroc");
                        wybor = Console.ReadLine();
                        break;
                }
            }

        }

        private void farmy(Program p, zamek zamek1)
        {
            Console.Clear();
            Console.WriteLine("Na farmach pracuje {0} chlopow", zamek1.Getrobotnicy());
            Console.WriteLine("Każdy chlop produkuje 2 jedzenia. Obecna produkcja: {0}", (zamek1.Getrobotnicy() - zamek1.Getzolnierze() ) * 2);
            Console.WriteLine("Każdy chlop produkuje 1 zlota z podatkow.");
            Console.WriteLine("Zapasy w spichlerzu wynosza: {0}", zamek1.Getjedzenie());
            Console.WriteLine("r rekrutuj (-10 szt. zlota) obecnie w skarbcu: {0}", zamek1.Getzloto());
            Console.WriteLine("w wroc");
            string wybor = Console.ReadLine();
            bool graj = true;
            while (graj == true)
            {
                switch (wybor)
                {
                    case "r":
                        zamek1.rekrutuj_robotnika(); 
                        wybor = "null";
                        break;
                    case "w":
                        graj = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Na farmach pracuje {0} chlopow", zamek1.Getrobotnicy());
                        Console.WriteLine("Każdy chlop produkuje 2 jedzenia. Obecna produkcja: {0}", (zamek1.Getrobotnicy() - zamek1.Getzolnierze()) * 2);
                        Console.WriteLine("Każdy chlop produkuje 1 zlota z podatkow.");
                        Console.WriteLine("Zapasy w spichlerzu wynosza: {0}", zamek1.Getjedzenie());
                        Console.WriteLine("r rekrutuj (-10 szt. zlota) obecnie w skarbcu: {0}", zamek1.Getzloto());
                        Console.WriteLine("w wroc");
                        wybor = Console.ReadLine();
                        break;
                }
            }

        }

        private void dyplomacja(Program p, zamek zamek1, zamek[] zamki)
        {
            Console.Clear();
            Console.WriteLine("h handel");
            Console.WriteLine("a atakuj");
            Console.WriteLine("s sojusze");
            Console.WriteLine("w wroc");
            string wybor = Console.ReadLine();
            bool graj = true;
            while (graj == true)
            {
                switch (wybor)
                {
                    case "h":
                        p.handel(p,zamek1,zamki);
                        wybor = "null";
                        break;
                    case "a":
                        p.atak(p, zamek1,zamki);
                        wybor = "null";
                        break;
                    case "s":
                        p.sojusz(p, zamek1,zamki);
                        wybor = "null";
                        break;
                    case "w":
                        graj = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("h handel");
                        Console.WriteLine("a atakuj");
                        Console.WriteLine("s sojusze");
                        Console.WriteLine("w wroc");
                        wybor = Console.ReadLine();
                        break;
                }
            }
        }

        private void handel(Program p, zamek zamek1,zamek[] zamki)
        {
            Console.Clear();
            Console.WriteLine("Handlowac mozemy tylko z naszymy sojusznikami");
            Console.WriteLine("Zamki z ktorymi mamy sojusz:");
            for (int i=0; i<4; i++)
            {
                if (zamek1.Getz_kim(i)==1) {  
                Console.WriteLine("{0}. {1}",i ,zamki[i].Getnazwa()); 
                }
            }
       
            Console.WriteLine("By wybrac zamek z ktorym chcesz handowac wpisz nr. zamku");
            Console.WriteLine("w wroc");
            string wybor = Console.ReadLine();
            bool graj = true;
            while (graj == true)
            {
                switch (wybor)
                {
                    case "0":
                        if (zamek1.Getz_kim(0)==1) { 
                            p.handluj(p, zamek1, zamki,0);

                        }
                        wybor = "null";
                        break;
                    case "1":
                        if (zamek1.Getz_kim(1) == 1)
                        {
                            p.handluj(p, zamek1, zamki, 1);
                        }
                        wybor = "null";
                        break;
                    case "2":
                        if (zamek1.Getz_kim(2) == 1)
                        {
                            p.handluj(p, zamek1, zamki, 2);
                        }
                        wybor = "null";
                        break;
                    case "3":
                        if (zamek1.Getz_kim(3) == 1)
                        {
                            p.handluj(p, zamek1, zamki, 3);
                        }
                        wybor = "null";
                        break;
                    case "w":
                        graj = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Handlowac mozemy tylko z sojusznikami");
                        Console.WriteLine("Zamki z ktorymi mamy sojusz:");
                        for (int i = 0; i < 4; i++)
                        {
                            if (zamek1.Getz_kim(i) == 1)
                            {
                                Console.WriteLine("{0}. {1}", i, zamki[i].Getnazwa());
                            }
                        }

                        Console.WriteLine("By wybrac zamek z ktorym chcesz handowac wpisz nr. zamku");
                        Console.WriteLine("w wroc");
                        wybor = Console.ReadLine();
                        break;
                }
            }
        }

        private void handluj(Program p, zamek zamek1, zamek[] zamki, int nr_zamku)
        {
            Console.Clear();
            Console.WriteLine("skarbiec: {0}",zamek1.Getzloto());
            Console.WriteLine("spichlerz: {0}", zamek1.Getjedzenie());
            Console.WriteLine("skarbiec sojusznika: {0}", zamki[nr_zamku].Getzloto());
            Console.WriteLine("spichlerz sojusznika: {0}", zamki[nr_zamku].Getjedzenie());
            Console.WriteLine("k kup 20 jedzenia za 10 zlota");
            Console.WriteLine("s sprzedaj 20 jedzenia za 10 zlota");
            Console.WriteLine("w wroc");
            string wybor = Console.ReadLine();
            bool graj = true;
            while (graj == true)
            {
                switch (wybor)
                {
                    case "k":
                        if (zamek1.Getzloto()>=10 && zamki[nr_zamku].Getjedzenie() >= 20) 
                        {
                            zamek1.Addjedzenie();
                            zamek1.Subzloto();
                            zamki[nr_zamku].Addzloto();
                            zamki[nr_zamku].Subjedzenie();
                        }
                        
                        wybor = "null";
                        break;
                    case "s":
                        if (zamek1.Getjedzenie() >= 20 && zamki[nr_zamku].Getzloto() >= 10) 
                        {
                            zamek1.Subjedzenie();
                            zamek1.Addzloto();
                            zamki[nr_zamku].Subzloto();
                            zamki[nr_zamku].Addjedzenie();
                        }
                        wybor = "null";
                        break;
                    case "w":
                        graj = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("skarbiec: {0}", zamek1.Getzloto());
                        Console.WriteLine("spichlerz: {0}", zamek1.Getjedzenie());
                        Console.WriteLine("skarbiec sojusznika: {0}", zamki[nr_zamku].Getzloto());
                        Console.WriteLine("spichlerz sojusznika: {0}", zamki[nr_zamku].Getjedzenie());
                        Console.WriteLine("k kup 20 jedzenia za 10 zlota");
                        Console.WriteLine("s sprzedaj 20 jedzenia za 10 zlota");
                        Console.WriteLine("w wroc");
                        wybor = Console.ReadLine();
                        break;
                }
            }

        }

        private void atak(Program p, zamek zamek1, zamek[] zamki)
        {
            Console.Clear();
            Console.WriteLine("Atakowac mozemy tylko naszych wrogow");
            Console.WriteLine("Zamki z ktorymi jestesmy w stanie wojny: ");
            for (int i = 0; i < 4; i++)
            {
                if (zamek1.Getz_kim(i) == 0)
                {
                    Console.WriteLine("{0}. {1}", i, zamki[i].Getnazwa());
                }
            }
            Console.WriteLine("By wybrac zamek ktory chcesz zaatakowac wpisz nr. zamku");
            Console.WriteLine("r rozpocznij wojne");
            Console.WriteLine("w wroc");
            string wybor = Console.ReadLine();
            bool graj = true;
            while (graj == true)
            {
                switch (wybor)
                {
                    case "0":
                        if (zamek1.Getz_kim(0) == 0)
                        {
                            p.atakuj(p, zamek1, zamki, 0);

                        }
                        wybor = "null";
                        break;
                    case "1":
                        if (zamek1.Getz_kim(1) == 0)
                        {
                            p.atakuj(p, zamek1, zamki, 1);
                        }
                        wybor = "null";
                        break;
                    case "2":
                        if (zamek1.Getz_kim(2) == 0)
                        {
                            p.atakuj(p, zamek1, zamki, 2);
                        }
                        wybor = "null";
                        break;
                    case "3":
                        if (zamek1.Getz_kim(3) == 0)
                        {
                            p.atakuj(p, zamek1, zamki, 3);
                        }
                        wybor = "null";
                        break;
                    case "r":
                      
                        p.wypowiedzenie_wojny(p,zamek1, zamki);
                        
                        wybor = "null";
                        break;
                    case "w":
                        graj = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Atakowac mozemy tylko naszych wrogow");
                        Console.WriteLine("Zamki z ktorymi jestesmy w stanie wojny: ");
                        for (int i = 0; i < 4; i++)
                        {
                            if (zamek1.Getz_kim(i) == 0)
                            {
                                Console.WriteLine("{0}. {1}", i, zamki[i].Getnazwa());
                            }
                        }
                        Console.WriteLine("By wybrac zamek ktory chcesz zaatakowac wpisz nr. zamku");
                        Console.WriteLine("r rozpocznij wojne");
                        Console.WriteLine("w wroc");
                        wybor = Console.ReadLine();
                        break;
                }
            }
        }

        private void atakuj(Program p, zamek zamek1, zamek[] zamki, int nr_zamku)
        {
            Console.Clear();
            Console.WriteLine("Atakujesz: {0}", zamki[nr_zamku].Getnazwa());
            Console.WriteLine("Nasze wojsko: {0}", zamek1.Getzolnierze());
            Console.WriteLine("a atak");
            Console.WriteLine("w wroc");
            string wybor = Console.ReadLine();
            bool graj = true;
            while (graj == true)
            {
                switch (wybor)
                {
                    case "a":
                        if (zamek1.Getzolnierze() > zamki[nr_zamku].Getzolnierze() ) 
                        {
                            Console.Clear();
                            Console.WriteLine("Wygrana");
                            Console.WriteLine("Smierc ponioslo {0} zolnierzy", zamki[nr_zamku].Getzolnierze());
                            Console.WriteLine("Zrabowano {0} zlota", zamki[nr_zamku].Getzloto());
                            zamek1.Setpolegli_zolnierze(zamki[nr_zamku].Getzolnierze());
                            zamki[nr_zamku].Setzolnierze(0);
                            zamki[nr_zamku].Setzloto(0);
                            zamek1.Setzrabowane_zloto(zamki[nr_zamku].Getzloto());
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("przegrana");
                            Console.WriteLine("Smierc ponioslo {0} zolnierzy", zamek1.Getzolnierze());
                            zamek1.Setzolnierze(0);
                            Console.ReadLine();
                        }

                        wybor = "null";
                        break;
                    case "w":
                        graj = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Atakujesz: {0}", zamki[nr_zamku].Getnazwa());
                        Console.WriteLine("Nasze wojsko: {0}", zamek1.Getzolnierze());
                        Console.WriteLine("a atak");
                        Console.WriteLine("w wroc");
                        wybor = Console.ReadLine();
                        break;
                }
            }
        }

        private void wypowiedzenie_wojny(Program p, zamek zamek1, zamek[] zamki)
        {
            Console.Clear();
            Console.WriteLine("Zamki z ktorymi mamy sojusz:");
            for (int i = 0; i < 4; i++)
            {
                if (zamek1.Getz_kim(i) == 1)
                {
                    Console.WriteLine("{0}. {1}", i, zamki[i].Getnazwa());
                }
            }

            Console.WriteLine("By wybrac zamek z ktoremu chcesz wypowiedziec wojne wpisz nr. zamku");
            Console.WriteLine("w wroc");
            string wybor = Console.ReadLine();
            bool graj = true;
            while (graj == true)
            {
                switch (wybor)
                {
                    case "0":
                        if (zamek1.Getz_kim(0) == 1)
                        {
                            zamek1.Setz_kim_wojna(0); 

                        }
                        wybor = "null";
                        break;
                    case "1":
                        if (zamek1.Getz_kim(1) == 1)
                        {
                            zamek1.Setz_kim_wojna(1);
                        }
                        wybor = "null";
                        break;
                    case "2":
                        if (zamek1.Getz_kim(2) == 1)
                        {
                            zamek1.Setz_kim_wojna(2);
                        }
                        wybor = "null";
                        break;
                    case "3":
                        if (zamek1.Getz_kim(3) == 1)
                        {
                            zamek1.Setz_kim_wojna(3);
                        }
                        wybor = "null";
                        break;
                    case "w":
                        graj = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Zamki z ktorymi mamy sojusz:");
                        for (int i = 0; i < 4; i++)
                        {
                            if (zamek1.Getz_kim(i) == 1)
                            {
                                Console.WriteLine("{0}. {1}", i, zamki[i].Getnazwa());
                            }
                        }

                        Console.WriteLine("By wybrac zamek z ktoremu chcesz wypowiedziec wojne wpisz nr. zamku");
                        Console.WriteLine("w wroc");
                        wybor = Console.ReadLine();
                        break;
                }
            }
        }

        private void sojusz(Program p, zamek zamek1, zamek[] zamki)
        {
            Console.Clear();
            Console.WriteLine("Zamki z ktorymi jestesmy w stanie wojny: ");
            for (int i = 0; i < 4; i++)
            {
                if (zamek1.Getz_kim(i) == 0) 
                {
                    Console.WriteLine("{0}. {1}", i, zamki[i].Getnazwa());
                }
            }
            Console.WriteLine("By wybrac zamek z ktorym chcesz zawrzec sojusz wpisz nr. zamku");
            Console.WriteLine("Drobne podarki zwieksza twoje szanse na powodzenie");
           
            Console.WriteLine("w wroc");
            string wybor = Console.ReadLine();
            bool graj = true;
            while (graj == true)
            {
                switch (wybor)
                {
                    case "0":
                        if (zamek1.Getz_kim(0) == 0)
                        {
                            p.wyslij(p, zamek1, zamki, 0);

                        }
                        wybor = "null";
                        break;
                    case "1":
                        if (zamek1.Getz_kim(1) == 0)
                        {
                            p.wyslij(p, zamek1, zamki, 1);
                        }
                        wybor = "null";
                        break;
                    case "2":
                        if (zamek1.Getz_kim(2) == 0)
                        {
                            p.wyslij(p, zamek1, zamki, 2);
                        }
                        wybor = "null";
                        break;
                    case "3":
                        if (zamek1.Getz_kim(3) == 0)
                        {
                            p.wyslij(p, zamek1, zamki, 3);
                        }
                        wybor = "null";
                        break;
                    case "w":
                        graj = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Zamki z ktorymi jestesmy w stanie wojny: ");
                        for (int i = 0; i < 4; i++)
                        {
                            if (zamek1.Getz_kim(i) == 0)
                            {
                                Console.WriteLine("{0}. {1}", i, zamki[i].Getnazwa());
                            }
                        }
                        Console.WriteLine("By wybrac zamek z ktorym chcesz zawrzec sojusz wpisz nr. zamku");
                        Console.WriteLine("Pamietaj, że drobne podarki zwieksza twoje szanse na powodzenie");

                        Console.WriteLine("w wroc");
                        wybor = Console.ReadLine();
                        break;
                }
            }
        }

        private void wyslij(Program p, zamek zamek1, zamek[] zamki, int nr_zamku)
        {


            Console.Clear();
            Console.WriteLine("z wyslij zapytanie");
            Console.WriteLine("zj wyslij zapytanie (-20 jedzenia, spichlerz: {0}) ", zamek1.Getjedzenie());
            Console.WriteLine("zz wyslij zapytanie (-10 zlota, skarbiec: {0}) ", zamek1.Getzloto());
            Console.WriteLine("w wroc");
            string wybor = Console.ReadLine();
            bool graj = true;
            Random rnd = new Random(); 
            int los = rnd.Next(0, 100); 
            while (graj == true)
            {
                switch (wybor)
                {
                    case "z":
                        if (zamek1.Getzapytanie() == 1)
                        {
                        
                            if (los > 50)
                            {
                                Console.Clear();
                                Console.WriteLine("{0} zaakceptowal nasza prosbe", zamki[nr_zamku].Getnazwa());
                                zamek1.Setz_kim(nr_zamku);
                                Console.ReadLine();

                            }
                            else
                            {
                                Console.WriteLine("{0} nie zaakceptowal naszej prosby", zamki[nr_zamku].Getnazwa());
                                Console.ReadLine();
                            }
                            zamek1.Setzapytanie(0);
                        }
                        else
                        {
                            Console.WriteLine("Juz pytalismy");
                            Console.ReadLine();
                        }

                        wybor = "null";
                        break;
                    case "zj": 
                        
                        if (zamek1.Getzapytanie() == 1)
                        {
                            zamek1.Subjedzenie();
                            zamki[nr_zamku].Addjedzenie();
                            if ((los+25) > 50)
                            {
                                Console.Clear();
                                Console.WriteLine("{0} zaakceptowal nasza prosbe", zamki[nr_zamku].Getnazwa());
                                zamek1.Setz_kim(nr_zamku); 
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("{0} nie zaakceptowal naszej prosby", zamki[nr_zamku].Getnazwa());
                                Console.ReadLine();
                            }
                            zamek1.Setzapytanie(0);
                        }
                        else
                        {
                            Console.WriteLine("Juz pytalismy");
                            Console.ReadLine();
                        }


                        wybor = "null";
                        break;
                    case "zz": 

                        if (zamek1.Getzapytanie() == 1)
                        {
                            zamek1.Subzloto();
                            zamki[nr_zamku].Addzloto();
                            if ((los+25) > 50)
                            {
                                Console.Clear();
                                Console.WriteLine("{0} zaakceptowal nasza prosbe", zamki[nr_zamku].Getnazwa());
                                zamek1.Setz_kim(nr_zamku); 
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("{0} nie zaakceptowal naszej prosby", zamki[nr_zamku].Getnazwa());
                                Console.ReadLine();
                            }
                            zamek1.Setzapytanie(0);
                        }
                        else
                        {
                            Console.WriteLine("Juz pytalismy");
                            Console.ReadLine();
                        }

                        wybor = "null";
                        break;
                    case "w":
                        graj = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("z wyslij zapytanie");
                        Console.WriteLine("zj wyslij zapytanie (-20 jedzenia, spichlerz: {0}) ", zamek1.Getjedzenie());
                        Console.WriteLine("zz wyslij zapytanie (-10 zlota, skarbiec: {0}) ", zamek1.Getzloto());
                        Console.WriteLine("w wroc");
                        wybor = Console.ReadLine();
                        break;
                }
            }
        }

        private void nastepny_tydzien(Program p, zamek zamek1, zamek[] zamki)
        {
            Random rnd = new Random();
            int wylosowana = rnd.Next(0, 100);

            zamek1.je(); 
            zamek1.Setpodatki(2); 
            zamek1.Setzapytanie(1); 
            if (zamek1.Getrobotnicy()<zamek1.Getzolnierze()) 
            {
                Console.Clear();
                Console.WriteLine("Ludnosc w zamku gloduje");
                if (zamek1.Getjedzenie()<0)
                    {
                    Console.WriteLine("Cala nasza armia zmarla z glodu");
                    zamek1.Setzolnierze(0);
                    zamek1.Setjedzenie(0);
                }
                Console.ReadLine();
            }
            

            if (wylosowana < 10) 
            {
                Console.Clear();
                Console.WriteLine("Zamek zaatakowal smok");
                int il_zolnierzy = zamek1.Getzolnierze();
                int zabici = rnd.Next(0, il_zolnierzy / 4);      
                Console.WriteLine("W walce smierc ponioslo {0} zolnierzy", zabici);
                zamek1.Setzolnierze(il_zolnierzy - zabici);
                int zjedzone = rnd.Next(0, zamek1.Getjedzenie() / 4);
                Console.WriteLine("Smok zjadl {0} jedzenia", zjedzone);
                zamek1.Setjedzenie(zamek1.Getjedzenie() - zjedzone);
                Console.WriteLine("Nie udalo sie go zabic, mozliwe, ze jeszcze kiedys wroci");
                Console.ReadLine();
            }

           else if (wylosowana > 10  && wylosowana < 20 ) 
            {
                Console.Clear();
                Console.WriteLine("Przez zamek przeszło tornado");
                int zniszczone = rnd.Next(0, zamek1.Getjedzenie() / 4);
                Console.WriteLine("Nasze plony zostaly zniszczone, stracilismy {0} jedzenia", zniszczone);
                zamek1.Setjedzenie(zamek1.Getjedzenie() - zniszczone);
                Console.ReadLine();
            }

            else if (wylosowana > 20 && wylosowana < 30) 
            {
                Console.Clear();
                int nr_zamku = rnd.Next(0, 3);
                if (zamek1.Getz_kim(nr_zamku) == 1)
                {
                    Console.WriteLine("{0} zerwal z nami sojusz", zamki[nr_zamku].Getnazwa());
                    zamek1.Setz_kim_wojna(nr_zamku);
                }
               
                Console.WriteLine("Zamek zostal zaatakowany przez {0}",  zamki[nr_zamku].Getnazwa());
                int zabici = rnd.Next(zamek1.Getzolnierze()/2, zamek1.Getzolnierze());      
                Console.WriteLine("W walce smierc ponioslo {0} zolnierzy", zabici);
                zamek1.Setzolnierze(zamek1.Getzolnierze() - zabici);
                zamki[nr_zamku].Setzolnierze(zamki[nr_zamku].Getzolnierze() - zabici);
                int zniszczone = rnd.Next(0, zamek1.Getjedzenie());
                Console.WriteLine("Nasze plony zostaly zniszczone, stracilismy {0} jedzenia", zniszczone);
                zamek1.Setjedzenie(zamek1.Getjedzenie() - zniszczone);
                if (zamek1.Getzolnierze()< zamki[nr_zamku].Getzolnierze())
                {
                    Console.WriteLine("Atakujacy wygrali i zrabowali cale nasze zloto");
                    zamki[nr_zamku].Setzrabowane_zloto(zamek1.Getzloto());
                    zamek1.Setzloto(0);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Atakujacy przegrali");
                    Console.ReadLine();
                }

            }
            


        }

        private void Menu_gry(Program p,zamek zamek1,zamek[] zamki)
        {
            Console.Clear();
            Console.WriteLine("s skarbiec");
            Console.WriteLine("a armia");
            Console.WriteLine("f farmy");
            Console.WriteLine("d dyplomacja");
            Console.WriteLine("n nastepny tydzien");
            Console.WriteLine("w wroc");
            string wybor = Console.ReadLine();
            bool graj = true;
            while (graj == true)
            {
                switch (wybor)
                {
                    case "s":
                        p.skarbiec(p,zamek1);
                        wybor = "null";
                        break;
                    case "a":
                        p.armia(p,zamek1);
                        wybor = "null";
                        break;
                    case "f":
                        p.farmy(p,zamek1);
                        wybor = "null";
                        break;
                    case "d":
                        p.dyplomacja(p, zamek1,zamki);
                        wybor = "null";
                        break;
                    case "n":
                        p.nastepny_tydzien(p, zamek1,zamki);
                        wybor = "null";
                        break;
                    case "w":
                        graj = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("s skarbiec");
                        Console.WriteLine("a armia");
                        Console.WriteLine("f farmy");
                        Console.WriteLine("d dyplomacja");
                        Console.WriteLine("n nastepny tydzien");
                        Console.WriteLine("w wroc");
                        wybor = Console.ReadLine();
                        break;
                }


            }

        }


            static void Main(string[] args)
        {
            Program p = new Program();
            zamek zamek1 = new zamek("Gracz"); 
            zamek z1 = new zamek("Zamek Ogrodzeniecki");
            zamek z2 = new zamek("Zamek na Wawelu");
            zamek z3 = new zamek("Zamek w Malborku");
            zamek z4 = new zamek("Zamek w Mirowie");
            zamek[] zamki = new zamek[4]; 
            
            zamki[0] = z1;
            zamki[1] = z2;
            zamki[2] = z3;
            zamki[3] = z4;

            Console.WriteLine("Witaj w grze zamki");
            Console.WriteLine("Aby rozpoczac nalezy wybrac dana opcje przez wpisanie w konsoli odpowiedzniej litery");
            Console.WriteLine("g graj");
            Console.WriteLine("w wyjscie");
            string wybor="r";
            wybor = Console.ReadLine(); 
            bool graj = true; 
            while (graj == true) 
            switch (wybor) 
            {
                case "g":
                    p.Menu_gry(p,zamek1,zamki);
                        wybor = "null"; 
                    break;
                case "w":
                    graj = false;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Aby rozpoczac nalezy wybrac dana opcje przez wpisanie w konsoli odpowiedzniej litery");
                    Console.WriteLine("g graj");
                    Console.WriteLine("w wyjscie");
                    wybor = Console.ReadLine();
                break;
            }

            }
    }
}
