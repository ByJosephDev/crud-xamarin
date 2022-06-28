using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDSCHOOL.Models
{
    public class School
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SchoolId { get; set; }

        public string Name { get; set; }
        public DateTime DateFundation { get; set; }
        public bool Enabled { get; set; }

    }
}

