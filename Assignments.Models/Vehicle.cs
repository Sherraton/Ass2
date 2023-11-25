using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Assignments.Models
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }


        [Required]
        public string Make { get; set; }


        public string Model { get; set; }


        [Display(Name = "License No.")]
        public string LicenseNo { get; set; }


        public int Year { get; set; }


        [Display(Name = "Engine Size")]
        public string EngineSize { get; set; }


        public string Transmission { get; set; }
        public string Features { get; set; }
        public string AdditionalInformation { get; set; }
        public string Color { get; set; }
        public string Mileage { get; set; }

        [Display(Name = "Asking Price")]
        public double AskingPrice { get; set; }

        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        [ValidateNever]
        public Category Category { get; set; }
        [ValidateNever]
        public string ImageUrl {  get; set; }

    }

}
