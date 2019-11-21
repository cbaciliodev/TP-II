using System;
using System.Collections.Generic;

namespace SGIAMTP.Models
{
    public partial class TUsuarioModalidadTanda
    {
        public TUsuarioModalidadTanda()
        {
            TPuntaje = new HashSet<TPuntaje>();
        }

        public string PkVumtCod { get; set; }
        public int FkIumtCodPart { get; set; }
        public int FkIumtCodTan { get; set; }
        public int? IumtPuntajeTotal { get; set; }
        public int? IumtPista { get; set; }
        public int? IumtEstado { get; set; }

        public TUsuarioModalidad FkIumtCodPartNavigation { get; set; }
        public TTanda FkIumtCodTanNavigation { get; set; }
        public ICollection<TPuntaje> TPuntaje { get; set; }
    }
}
