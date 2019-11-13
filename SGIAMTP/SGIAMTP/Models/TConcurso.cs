using System;
using System.Collections.Generic;

namespace SGIAMTP.Models
{
    public partial class TConcurso
    {
        public TConcurso()
        {
            TUsuarioModalidad = new HashSet<TUsuarioModalidad>();
        }

        public int PkIcIdConcurso { get; set; }
        public string VcNombreCon { get; set; }
        public string VcLugarCon { get; set; }
        public DateTime? DcFechaConcurso { get; set; }
        public int? FkIecIdEstado { get; set; }
        public int? IcCantidadSeri { get; set; }
        public int? IcCantidadNove { get; set; }

        public TEstadoCon FkIecIdEstadoNavigation { get; set; }
        public ICollection<TUsuarioModalidad> TUsuarioModalidad { get; set; }
    }
}
