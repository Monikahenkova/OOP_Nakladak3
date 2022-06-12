using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Clovek
{
    public class Nakladak
    {
        // soukromé proměnné - nejsou dostupné mimo třídu Nakladak
        private int palivo;
        private int naklad;
        private int dojezd;

        // vlastnosti - zveřejňují hodnoty ven z třídy
        public string Auto { get; set; }
        public string Znacka { get; set; }
        public int Palivo { get => palivo; }
        public int Dojezd { get => dojezd; }
        public int Nosnost { get; set; }
        public int Naklad { get => naklad; }
        public string Odjezd { get; set; }

        //konstruktor - pomocí této metody vznikne konkrétní objekt - instance třídy

        public Nakladak()
        {
            Znacka = "";
            Auto = "";
            palivo = 200;
            dojezd = 1000;
            Nosnost = 12000;
            naklad = 0;
            Odjezd = "Jedeš!";
        }
        public void Nalozitnaklad()
        {

            if (naklad <= 11000)
            {
                naklad += 1000;
            }
            else if (naklad > 11000)
            {
                    Odjezd = "Jedeš!";
            }
        }
        public void Vylozitnaklad()
        {

            if (naklad == 0)
            {
                naklad = 0;
            }
            else if (naklad > 0)
            {
                naklad -= 1000;
                Odjezd = "Jedeš!";
            }
        }

        public void Natankovat()
        {
            {
                palivo = 200;
                Odjezd = "Jedeš!";
            }
        }


        public void Dojedes()
        {
            if (palivo <= 0)
            {
                dojezd = 0;
                Odjezd = "Nejedeš!";
            }
        }

        public void Jed()
        {  
            if (naklad <= 12000)
            {
                palivo -= 50;
            }
            else if (palivo <= 0)
            {
                palivo = 0;
            }
            if (palivo <= 0)
            {
                Odjezd = "Nejedeš!";
            }
        }

      
    }
}
