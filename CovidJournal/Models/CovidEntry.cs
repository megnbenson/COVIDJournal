using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CovidJournal.Models
{
    public class CovidEntry
    {
        [Key]
        public int EntryId { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public float Temperature { get; set; }

        public string Note { get; set; }

        [Display(Name = "How moody are you today?")]
        public int Mood { get; set; }

        // symptoms
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
 