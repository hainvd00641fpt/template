using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1T1708M1.Models
{
    public class Student
    {
        [Key]
        public string RollNumber { get; set; }
        [Display(Name = "FristName")]
        public string FristName { get; set; }
        [Display(Name = "LastName")]
        public string LastName { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Phone")]
        public string Phone { get; set; }
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Display(Name = "Birthday")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Brithday { get; set; }
        [Display(Name = "Gender")]
        public Gender Gender { get; set; }
        [Display(Name = "Created At")]
        public DateTime CreateAt { get; set; }
        [Display(Name = "Update At")]
        public DateTime UpdateAt { get; set; }
        [Display(Name = "Student Status")]
        public StudentStatus Status { get; set; }


        public Student()
        {
            this.CreateAt = DateTime.Now;
            this.UpdateAt = DateTime.Now;
            this.Gender = Gender.Male;
            this.Status = StudentStatus.Activated;
        }
    }


    public enum StudentStatus
    {
        Activated = 1,
        Deactivated = 0

    }

public enum Gender
{
    Male = 1,
    FeMale = 0,
    Other = 2
}
}
