using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EJournal.Models
{
    public class Journal
    {
        public int ID { get; set; }

        public string NAME { get; set; }
        public string SUBJECT { get; set; }
        
        [Column(TypeName = "decimal(18, 2)")]
        public decimal GRADE { get; set; }

        public string TEACHER { get; set; }

    }
}