using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace P01_StudentSystem.Data.Models
{
    public class Student
    {
        public Student()
        {
            this.StudentsCourses = new HashSet<StudentCourse>();
            this.Homeworks = new HashSet<Homework>();
        }

        [Key]
        public int StudentId { get; set; }

        [MaxLength(100)]
        [Unicode(true)]
        [Required]
        public string Name { get; set; } = null!;

        [StringLength(10)]
        [Unicode(false)]
        public string? PhoneNumber { get; set; }


        public DateTime RegisteredOn { get; set; }

        public DateTime? Birthday { get; set; }

        public virtual ICollection<Homework> Homeworks { get; set; }

        public virtual ICollection<StudentCourse> StudentsCourses { get; set; }

    }
}
