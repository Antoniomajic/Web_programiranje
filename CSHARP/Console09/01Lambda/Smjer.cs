﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Lambda
{
    internal class Smjer
    {
        public int Sifra { get; set; }
        // ? označava kako Naziv može biti null
        public string? Naziv { get; set; }

        public override string ToString()
        {
            // return Naziv == null ? "" : Naziv;
            return Naziv ?? ""; // krača sintaksa, ova linija je ekvivalent gornjoj
        }

    }
}
