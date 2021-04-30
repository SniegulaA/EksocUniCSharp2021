using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sniegula.CarWorkshop.Data
{
    public class Repair
    {
        public int TimeInHours { get; set; }

        public string RegistrationNumber { get; set; }

        public CarBrand CarBrand { get; set; }

        public Mechanic MechanicResponsible { get; set; }

        public DateTime RepairDate { get; set; }

    }
}
