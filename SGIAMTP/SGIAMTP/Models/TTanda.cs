using System;
using System.Collections.Generic;

namespace SGIAMTP.Models
{
    public partial class TTanda
    {
        public TTanda()
        {
            TUsuarioModalidadTanda = new HashSet<TUsuarioModalidadTanda>();
        }

        public int PkItCodTan { get; set; }
        public string VtDescripcion { get; set; }
        public string VtDescripcion1 { get; set; }
        public int? ItGanador { get; set; }
        public string VtTipoTanda { get; set; }
        public int? ItEstado { get; set; }
        public DateTime? DtFechaHora { get; set; }

        public ICollection<TUsuarioModalidadTanda> TUsuarioModalidadTanda { get; set; }
    }
}
