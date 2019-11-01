using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SGIAMTP.Models
{
    public partial class TConcurso
    {
        public TConcurso()
        {
            TUsuarioModalidad = new HashSet<TUsuarioModalidad>();
        }

        public int PkIcIdConcurso { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        [StringLength(30, MinimumLength = 8, ErrorMessage = "minimo 8 caracteres")]
        public string VcNombreCon { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public string VcLugarCon { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? DcFechaConcurso { get; set; }
        public int? FkIecIdEstado { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        [RegularExpression(@"[1-9]+[10-99]", ErrorMessage = "Solo Números Positivos")]
        public int? IcCantidadSeri { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        [RegularExpression(@"[1-9]+[10-99]", ErrorMessage = "Solo Números Positivos")]
        public int? IcCantidadNove { get; set; }

        public TEstadoCon FkIecIdEstadoNavigation { get; set; }
        public ICollection<TUsuarioModalidad> TUsuarioModalidad { get; set; }
    }
}
