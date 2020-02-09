using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoHttpTestProject.Models
{
    public class Task
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please specify name for this task")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please specify describtion for this task")]
        public string Describtion { get; set; }
        [Required(ErrorMessage = "Please specify importance for this task")]
        public int Importance { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DueDate { get; set; }
        [Required(ErrorMessage = "Please specify if task is completed or active")]
        public bool Readiness { get; set; }
    }
}
