using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace profile_1.Models
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }

        [Column(TypeName="nvarchar(50)")]
        public string EmployeeName { get; set; }


        [Column(TypeName = "nvarchar(50)")]
        public string Occupation { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string ImageName { get; set; }



        [NotMapped]
        public IFormFile formFile { get; set; }

        //Pascal(EmployeeName) ->Camel
        //Camel(employeeName) ->pascal

    }
}
