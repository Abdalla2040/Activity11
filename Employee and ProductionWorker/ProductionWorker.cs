using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_and_ProductionWorker
{
    class ProductionWorker : Employee
    {
        public ProductionWorker(): base()
        {
            ShiftNumber = 0;
            HourlyPayRate = 0;
        }

        public int ShiftNumber { get; set; }
        public double HourlyPayRate { get; set; }
    }
}
