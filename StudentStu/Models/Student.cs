using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentStu.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int studentId { get; set; }

        [Required]
        public string firstName { get; set; }
        public string lastName { get; set; }


        public string emailAddress { get; set; }
        public int phoneNumber { get; set; }

        public virtual ICollection<Address> Address { get; set; }
        [Timestamp]
        public DateTime timeCreated { get; set; }
    }
}
