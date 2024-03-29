﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kosar2004
{
    class Kosar
    {
        private string hazai;

        public string Hazai
        {
            get { return hazai; }
            private set { hazai = value; }
        }

        private string idegen;

        public string Idegen
        {
            get { return idegen; }
            private set { idegen = value; }
        }

        private int hazai_pont;

        public int Hazai_pont
        {
            get { return hazai_pont; }
            private set { hazai_pont = value; }
        }

        private int idegen_pont;

        public int Idegen_pont
        {
            get { return idegen_pont; }
            private set { idegen_pont = value; }
        }

        private string helyszin;

        public string Helyszin
        {
            get { return helyszin; }
            private set { helyszin = value; }
        }

        private DateTime idopont;

        public DateTime Idopont
        {
            get { return idopont; }
            private set { idopont = value; }
        }

        public Kosar(string hazai, string idegen, int hazai_pont, int idegen_pont, string helyszin, DateTime idopont)
        {
            Hazai = hazai;
            Idegen = idegen;
            Hazai_pont = hazai_pont;
            Idegen_pont = idegen_pont;
            Helyszin = helyszin;
            Idopont = idopont;
        }
    }
}
