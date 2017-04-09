using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Web;

namespace Richi.Shop._1.Models
{
    public class HomeModels
    {
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Compañia")]
        public string Compania { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Puesto")]
        public string TipoPuesto { get; set; }
        [DataType(DataType.Upload)]
        [Display(Name = "Logo")]
        public Image Logo { get; set; }
        [Required]
        [DataType(DataType.Url)]
        [Display(Name = "URL")]
        public string UrlCompania { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Posicion")]
        public string Posicion { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Ubicacion")]
        public string Ubicacion { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Categoria")]
        public RJ_CATEGORIAS Categoria { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }
        public DateTime FechaInicio { get; set; }
        private DateTime _fechaFinal;

        public DateTime FechaFinal
        {
            get { return this._fechaFinal; }
            set { this._fechaFinal = FechaInicio.AddDays(30); }
        }
        public bool Estado { get; set; }
    }
}