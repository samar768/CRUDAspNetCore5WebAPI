using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace CRUD_DAL.Models
{
    [Table("StudentDetails", Schema = "dbo")]


    public class StudentDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonIgnore]
        public int studentid { get; set; }
        
        [Required]
        [Display(Name = "name")]
        public string name { get; set; }

        [Required]
        [Display(Name = "address")]
        public string address { get; set; }
        [Required]
        [Display(Name = "mobile")]
        public string mobile { get; set; }
        [Required]
        [Display(Name = "DOB")]
        public DateTime DOB { get; set; } = DateTime.Now;
        [Required]
        [Display(Name = "gender")]
        public string gender { get; set; }

        [Required]
        [Display(Name = "Fathername")]
        public string Fathername { get; set; }

    }
}
