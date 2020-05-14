using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcFormulario.Models
{
    public class Formulario
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Gamertag { get; set; }
        [Required]
        public string Servername { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        public string Gender { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Game { get; set; }
        // public List<SelectListItem> Games { get; } = new List<SelectListItem>
        // {
        //     new SelectListItem {Value = "LoL", Text="League of Legends"},
        //     new SelectListItem {Value = "Overwatch", Text="Overwatch"},
        //     new SelectListItem {Value = "CodMobile", Text="Call of Duty Mobile"},
        //     new SelectListItem {Value = "RainbowSix", Text="Rainbow Six Siege"},
        //     new SelectListItem {Value = "Valorant", Text="Valorant"},
        // };
        public string Character { get; set; }
        public string CDivision { get; set; }
        public string ODivision { get; set; }
        [Display(Name = "Premium Service")]
        public bool PremiumService { get; set; }
        [Display(Name = "Creation Date")]
        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }

    }
}