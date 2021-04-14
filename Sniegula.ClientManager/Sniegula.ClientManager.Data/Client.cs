﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sniegula.ClientManager.Data
{
    public class Client
    {
        public string Name { get; set; }

        public string Surname { get; set; }
        public int Age { get; set; }

        public decimal OrderPrice { get; set; }

        public override string ToString()
        {
            return Name + " " + Surname + " Wiek: " + Age + " Kwota: " + " OrderPrice: " + OrderPrice;

        }

    }
}
