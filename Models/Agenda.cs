using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Agenda.Modelos
{
    public class Agenda
    {
        public int id { get; set; }

        public string cliente { get; set; }

        public short tipo_tarea { get; set; }

        public DateTime fecha_reg { get; set; }

        public string nota01 { get; set; }

        public string nota02 { get; set; }

        public string nota03 { get; set; }

        public string obs { get; set; }

        public DateTime? fecha_comp { get; set; }
        public bool status { get; set; }
    }

    //PARA AGREGAR Y EDITAR
    public class AgendaViewModel
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage ="Ingrese el nombre del cliente"),MaxLength(100),MinLength(5), Display(Name = "Cliente")]
        public string cliente { get; set; }
        [Required(ErrorMessage = "Ingrese el nombre del cliente"), Display(Name = "Tipo Tarea")]
        public short tipo_tarea { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [Required(ErrorMessage = "Introduzca la fecha de registro"), Display(Name = "Fecha")]
        public DateTime? fecha_reg { get; set; }
        [Display(Name = "Nota 1")]
        public string nota01 { get; set; }
        [ Display(Name = "Nota 2")]
        public string nota02 { get; set; }
        [Display(Name = "Nota 3")]
        public string nota03 { get; set; }
        [Display(Name = "Observación")]
        public string obs { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name = "Fecha Compromiso")]
        public DateTime? fecha_comp { get; set; }
    }

    //LISTADOS
    public class AgendaListViewModels
    {
        public int id { get; set; }
        public string cliente { get; set; }
        public short tipo_tarea { get; set; }
        public string fecha_reg { get; set; }
        public string nota01 { get; set; }
        public string nota02 { get; set; }
        public string nota03 { get; set; }
        public string obs { get; set; }
        public string fecha_comp { get; set; }
        public bool status { get; set; }

    }
}
