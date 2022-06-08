using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_work_3.Model
{
    public class Gamer
    {
        public int GamerId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public int Satiety { get; set; }
        public int Fatigue { get; set; }
        public int Money { get; set; }
        public int Day { get; set; }
    }
}
