using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcFormulario.Models
{
    public class Formulario
    {
        [Key]
        public int Id { get; set; }
        public string Gamertag { get; set; }
        public string Servername { get; set; }
        public string Name { get; set; }
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
        public bool PremiumService { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }

    }
}