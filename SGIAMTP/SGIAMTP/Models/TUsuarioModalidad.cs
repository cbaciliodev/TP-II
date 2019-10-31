using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SGIAMTP.Models
{
    public partial class TUsuarioModalidad
    {
        public TUsuarioModalidad()
        {
            TUsuarioModalidadTanda = new HashSet<TUsuarioModalidadTanda>();
        }

        public int PkIumCodUm { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        [DisplayName("Participante")]
        public int FkIuDni { get; set; }


        [Required(ErrorMessage = "Campo Requerido")]
        [DisplayName("Concurso")]
        public int FkIcIdConcurso { get; set; }


        [Required(ErrorMessage = "Campo Requerido")]
        [DisplayName("Modalidad")]
        public int FkImIdModalidad { get; set; }


        [RegularExpression(@"^[a-zA-Z]+[ a-zA-Z-_]*$", ErrorMessage = "Solo letras")]
        public string IumFase { get; set; }


        //[Required(ErrorMessage = "Campo Requerido")]
        //[DisplayName("Pareja")]
        public int? FkIuDniPareja { get; set; }


        [Required(ErrorMessage = "Campo Requerido")]
        [DisplayName("Fecha de Inscripción")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DumFechaIns { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public string VmUmArchivoDni { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public string VmUmArchivoB { get; set; }

        public TConcurso FkIcIdConcursoNavigation { get; set; }
        public TModalidadCon FkImIdModalidadNavigation { get; set; }
        public TUsuario FkIuDniNavigation { get; set; }
        public TUsuario FkIuDniParejaNavigation { get; set; }
        public ICollection<TUsuarioModalidadTanda> TUsuarioModalidadTanda { get; set; }
    }
}
