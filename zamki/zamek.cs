using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zamki
{
    class zamek
    {
        private string nazwa;  //atrybuty
        private int zloto;
        private int jedzenie;
        private int robotnicy;
        private int zolnierze;
        private int il_podatki;
        private int[] z_kim = new int[4];
        private int zapytanie;


        public zamek(string nazwa)
        {
            this.nazwa = nazwa; //wskazuje na siebie czyli na rzecz obiektu na który jest wykonywana ta metoda
            zloto=100;          // możliwości na wejściu
            jedzenie = 100;
            robotnicy = 15;
            zolnierze =10;
            il_podatki = 2;
            z_kim[0] = 1;
            z_kim[1] = 1;
            z_kim[2] = 1;
            z_kim[3] = 1;
            zapytanie = 1;
        }

        //akcesory
        public void Setzloto(int a)
        {
            zloto = a;
        }
        public void Setzrabowane_zloto(int a)
        {
            zloto += a;
        }
        public void Setzolnierze(int a)
        {
            zolnierze = a;
        }
        public void Setpolegli_zolnierze(int a)
        {
            zolnierze -= a;
        }

        public void Setjedzenie(int a)
        {
            jedzenie = a;
        }
        public void Addjedzenie()
        {
            jedzenie += 20;
        }
        public void Subjedzenie()
        {
            jedzenie -= 20;
        }
        public void Addzloto()
        {
            zloto += 10;
        }
        public void Subzloto()
        {
           zloto-= 10;
        }
        public void Setpodatki(int a)
        {
            il_podatki = a;
        }

        public void Setz_kim(int a)
        {
            z_kim[a] = 1;
        }

        public void Setz_kim_wojna(int a)
        {
            z_kim[a] = 0 ;
        }

        public void Setzapytanie(int a)
        {
            zapytanie = a;
        }


        public int Getzloto()
        {
            return zloto;
        }
        public int Getzolnierze()
        {
            return zolnierze;
        }
        public int Getjedzenie()
        {
            return jedzenie;
        }

        public string Getnazwa()
        {
            return nazwa;
        }

        public int Getz_kim(int a)
        {
            return z_kim[a];
        }

        public int Getrobotnicy()
        {
            return robotnicy;
        }

        public int Getpodatki()
        {
            return il_podatki;
        }

        public int Getzapytanie()
        {
            return zapytanie;
        }

        public void podatki()
        {
            zloto += robotnicy;
            il_podatki -= 1; //Odejmuje od możliwości jakie mamy w tygodniu
        }
        public void rekrutuj()
        {
            if (zloto >= 10) //jeśli będzie więcej niż 10 można rekrutować
            {
                zolnierze += 1;
                zloto -= 10;
            }
        }
        public void rekrutuj_robotnika()
        {
            if (zloto >= 10)
            {
                robotnicy += 1;
                zloto -= 10;
            }
        }

        public void je() // produkcja jedzenia 
        {
            jedzenie += (robotnicy - zolnierze) * 2;
        }



    }
}
