using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CovidJournal.Models
{
    public class Symptoms
    {
        [Key]
        public int SymptomsId { get; set; }

        public bool Headache { get; set; }
        public bool Cough { get; set; }
        public bool Lack_of_Smell { get; set; }
        public bool Lack_of_Taste { get; set; }
        public bool Fever { get; set; }
        public bool Chills { get; set; }
        public bool Breathlessness { get; set; }
        public bool Fatigue { get; set; }
        public bool Sore_Throat { get; set; }
        public bool Nausea { get; set; }
        public bool Diarrhea { get; set; }
        public bool Chest_Pressure { get; set; }
        public bool Pale_Blue_Skin { get; set; }
    }
}
