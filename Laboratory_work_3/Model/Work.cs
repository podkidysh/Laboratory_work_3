using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_work_3.Model
{
    public class Work
    {
        public int WorkId { get; set; }
        public string Name { get; set; }
        public int Wages { get; set; }
        public double Minqualifications { get; set; }
        public int Experience { get; set; }
        public int UpExperience { get; set; }
        public override string ToString()
        {
            return $"{Name } - зарплата {Wages } - необходимый опыт {Minqualifications} - получаемый опыт {UpExperience }";
        }
    }
}
