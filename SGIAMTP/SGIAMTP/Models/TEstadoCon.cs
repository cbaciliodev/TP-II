using System;
using System.Collections.Generic;

namespace SGIAMTP.Models
{
    public partial class TEstadoCon
    {
        public TEstadoCon()
        {
            TConcurso = new HashSet<TConcurso>();
            TUsuario = new HashSet<TUsuario>();
        }

        public int PkIeIdEstado { get; set; }
        public string VeNombreEsta { get; set; }

        public ICollection<TConcurso> TConcurso { get; set; }
        public ICollection<TUsuario> TUsuario { get; set; }
    }
}
