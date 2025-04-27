using System.ComponentModel.DataAnnotations;

namespace StudentCrud.Models
{   //11:43
    public class Student
    {
        [Key]
        public int id { get;set; }
        public string stName { get;set; }
        public string Course { get;set; }

    }
}
