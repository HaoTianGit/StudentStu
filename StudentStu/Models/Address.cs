using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentStu.Models
{
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AddressId { get; set; }


        public int StreetNumber { get; set; }
       
        public int studentId { get; set; }
        public String StreetSuburb { get; set; }
        public String City { get; set; }
        public String Country { get; set; }
        public int PostCode { get; set; }

        public virtual Student Student { get; set; }

    }
}
