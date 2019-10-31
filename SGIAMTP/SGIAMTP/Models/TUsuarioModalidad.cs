using System;
using System.Collections.Generic;

namespace SGIAMTP.Models
{
    public partial class TUsuarioModalidad
    {
        public TUsuarioModalidad()
        {
            TUsuarioModalidadTanda = new HashSet<TUsuarioModalidadTanda>();
        }

        public int PkIumCodUm { get; set; }
        public int FkIuDni { get; set; }
        public int FkIcIdConcurso { get; set; }
        public int FkImIdModalidad { get; set; }
        public string IumFase { get; set; }
        public int? FkIuDniPareja { get; set; }
        public DateTime DumFechaIns { get; set; }
        public string VmUmArchivoDni { get; set; }
        public string VmUmArchivoB { get; set; }

        public TConcurso FkIcIdConcursoNavigation { get; set; }
        public TModalidadCon FkImIdModalidadNavigation { get; set; }
        public TUsuario FkIuDniNavigation { get; set; }
        public TUsuario FkIuDniParejaNavigation { get; set; }
        public ICollection<TUsuarioModalidadTanda> TUsuarioModalidadTanda { get; set; }
    }
}
