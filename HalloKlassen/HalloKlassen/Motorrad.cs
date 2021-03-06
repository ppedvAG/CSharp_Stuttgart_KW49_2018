﻿using System;
using System.Xml.Serialization;

namespace HalloKlassen
{
    public abstract class Motorrad
    {
        [XmlIgnoreAttribute]
        public string FahrgestellNummer { get; protected set; }

        public abstract string SagMirWasDuBist();

        public Motorrad() //standard construktor
        {
            Farbe = "Gelb";
            Baujahr = DateTime.Now;
            FahrgestellNummer = "AAAAAAA";
        }

        public Motorrad(string hersteller) : this()
        {
            Hersteller = hersteller;
        }

        private int ps;//datenfeld

        public int Ps //full Property
        {
            get { return ps; }
            set { ps = value; }
        }

        public string Hersteller { get; set; }
        public string Farbe { get; set; }
        public DateTime Baujahr { get; set; }



        public virtual void Fahren()
        {
            for (int i = 0; i < ps; i++)
            {
                Console.Write("*brumm*");
            }
            Console.WriteLine();
        }




        ////beispiel für getter funktion
        // public int GetPs()
        // {
        //     return ps;
        // }

        //beispiel für setter methode
        //public void SetPs(int ps)
        //{
        //    this.ps = ps;
        //}
    }
}
