﻿using Polimorfizam;
using System.Security.Cryptography;

Osoba[] osobe = new Osoba[3];

osobe[0] = new Polaznik { Ime = "Pero" };
osobe[1] = new Polaznik { Ime = "Kata" };
osobe[2] = new Predavač { Ime = "Mata" };

void pozdraviSve(Osoba[] o)
{
    foreach (Osoba osoba in o)
    {
        // Ovo je izvedba polimorfizma
        Console.WriteLine(osoba.Pozdravi());        
    }
}

pozdraviSve(osobe);

// Tri klase Osoba, Predavac i Polaznik su pozornica za polimorfizam