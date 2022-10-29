using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LICEORURALJASMINEZB.Models
{
    public class Matricula
    {
        [Key]
        public int Id { get; set; }
        public int IdPeriodo { get; set; }
        [ForeignKey(" IdPeriodo")]
        public virtual Periodo Periodo { get; set; }
      
         //==============================================
         public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Cedula { get; set; }
        public string Edad { get; set; }
        public string Sexo { get; set; }
        public enum IsSexo { Femenino = 1, Masculino = 2 }
        [Required(ErrorMessage = "La Fecha Nacimiento es requierida ")]
        [Display(Name = "Fecha Nacimiento")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:MM-dd-yyyy}")]
        public DateTime? FechaNacimiento { get; set; }
        public int IdGradoSeccion { get; set; }
        [ForeignKey(" IdGradoSeccion ")]
        public virtual GradoSeccion GradoSeccion { get; set; }
        public string InstitucionProcedencia  { get; set; }
        public string Nacionalidad { get; set; }
        public string LugarNacimiento { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public string TieneExpediente { get; set; }
        public enum IsTieneExpediente { Si = 1, No = 2 }
        public string Repitente  { get; set; }
        public enum IsRepitente { Si = 1, No = 2 }
        public string Adecucion { get; set; }
        public enum IsAdecucion { Nosignificativa = 1, Significativa = 2, DeAcceso = 3,Sinadecuación = 4 }

        public string PadeceAlgunaEnfermedad { get; set; }

        public string ConsumeTratamientos { get; set; }

        //Datos encargado
        public string NombreEncargado { get; set; }
        public string PrimerApellidoEncargado { get; set; }
        public string SegundoApellidoEncargado { get; set; }
        public string CedulaEncargado { get; set; }
        public string NacionalidadEncargado { get; set; }
        public string TelefonoEncargado { get; set; }
        public string Ocupacion { get; set; }
        public string TipoRelacion { get; set; }
        public enum IsTipoRelacion { Padre = 1, Madre = 2, Tio = 3, Tia = 4, Abuelo = 5, Abuela = 6, Encarcado = 7 }
    }

}
