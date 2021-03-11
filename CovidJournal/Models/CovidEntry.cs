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

        [ForeignKey("Symptoms")]
        public int SymptomsId { get; set; }
    }
}
