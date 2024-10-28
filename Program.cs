using System;

namespace ConsoleApp
{
    // 1. Klasa Proizvod
    class Proizvod
    {
        // Svojstva klase
        public string Naziv { get; set; }
        public decimal Cijena { get; set; }
        public int DostupnaKolicina { get; set; }

        // Konstruktor klase
        public Proizvod(string naziv, decimal cijena, int dostupnaKolicina)
        {
            Naziv = naziv;
            Cijena = cijena;
            DostupnaKolicina = dostupnaKolicina;
        }

        // Metoda za ispis informacija o proizvodu
        public void IspisiInformacije()
        {
            Console.WriteLine($"Naziv: {Naziv}");
            Console.WriteLine($"Cijena: {Cijena:C}");
            Console.WriteLine($"Dostupna količina: {DostupnaKolicina}");
        }
    }

    // 2. Bazna klasa ElektronickiUredjaj
    class ElektronickiUredjaj
    {
        // Svojstva bazne klase
        public string Naziv { get; set; }
        public string Proizvodjac { get; set; }
        public int GodinaProizvodnje { get; set; }

        // Konstruktor bazne klase
        public ElektronickiUredjaj(string naziv, string proizvodjac, int godinaProizvodnje)
        {
            Naziv = naziv;
            Proizvodjac = proizvodjac;
            GodinaProizvodnje = godinaProizvodnje;
        }

        // Metoda za ispis informacija o uređaju
        public void IspisiInformacije()
        {
            Console.WriteLine($"Naziv: {Naziv}");
            Console.WriteLine($"Proizvođač: {Proizvodjac}");
            Console.WriteLine($"Godina proizvodnje: {GodinaProizvodnje}");
        }
    }

    // Izvedena klasa PametniTelefon
    class PametniTelefon : ElektronickiUredjaj
    {
        // Dodatno svojstvo za PametniTelefon
        public string OperativniSustav { get; set; }

        // Konstruktor izvedene klase
        public PametniTelefon(string naziv, string proizvodjac, int godinaProizvodnje, string operativniSustav)
            : base(naziv, proizvodjac, godinaProizvodnje) // Pozivanje konstruktora bazne klase
        {
            OperativniSustav = operativniSustav;
        }

        // Metoda za ispis informacija o uređaju, uključujući operativni sustav
        public new void IspisiInformacije()
        {
            base.IspisiInformacije();
            Console.WriteLine($"Operativni sustav: {OperativniSustav}");
        }

        // Metoda za instaliranje aplikacije
        public void InstalirajAplikaciju(string nazivAplikacije)
        {
            Console.WriteLine($"Instalirana aplikacija: {nazivAplikacije}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 1. Kreiranje objekta tipa Proizvod i ispisivanje informacija
            Proizvod proizvod = new Proizvod("Laptop", 8500.50m, 10);
            Console.WriteLine("Informacije o proizvodu:");
            proizvod.IspisiInformacije();
            Console.WriteLine();

            // 2. Kreiranje objekta tipa PametniTelefon i korištenje dostupnih metoda
            PametniTelefon telefon = new PametniTelefon("iPhone 13", "Apple", 2021, "iOS");
            Console.WriteLine("Informacije o pametnom telefonu:");
            telefon.IspisiInformacije();

            // Pozivanje metode za instaliranje aplikacije
            telefon.InstalirajAplikaciju("WhatsApp");
        }
    }
}
