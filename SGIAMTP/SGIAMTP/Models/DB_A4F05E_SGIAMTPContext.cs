using Microsoft.EntityFrameworkCore;

namespace SGIAMTP.Models
{
    public partial class DB_A4F05E_SGIAMTPContext : DbContext
    {
        public DB_A4F05E_SGIAMTPContext()
        {
        }

        public DB_A4F05E_SGIAMTPContext(DbContextOptions<DB_A4F05E_SGIAMTPContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TCategoria> TCategoria { get; set; }
        public virtual DbSet<TConcurso> TConcurso { get; set; }
        public virtual DbSet<TEstadoCon> TEstadoCon { get; set; }
        public virtual DbSet<TModalidadCon> TModalidadCon { get; set; }
        public virtual DbSet<TPuntaje> TPuntaje { get; set; }
        public virtual DbSet<TTanda> TTanda { get; set; }
        public virtual DbSet<TTipoUsuario> TTipoUsuario { get; set; }
        public virtual DbSet<TUsuario> TUsuario { get; set; }
        public virtual DbSet<TUsuarioModalidad> TUsuarioModalidad { get; set; }
        public virtual DbSet<TUsuarioModalidadTanda> TUsuarioModalidadTanda { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                //optionsBuilder.UseSqlServer("Server=sql5047.site4now.net;Database=DB_A4F05E_SGIAMTP;User Id=DB_A4F05E_SGIAMTP_admin;Password=123456789gg;MultipleActiveResultSets=True;");
                optionsBuilder.UseSqlServer("Data Source=LENOVO;Initial Catalog=DB_A4F05E_SGIAMTP;Integrated Security=True");
                //optionsBuilder.UseSqlServer("Data Source=LACING202A-06;Initial Catalog=DB_A4F05E_SGIAMTP;Integrated Security=True");

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TCategoria>(entity =>
            {
                entity.HasKey(e => e.PkIcCodCat);

                entity.ToTable("T_Categoria");

                entity.Property(e => e.PkIcCodCat)
                    .HasColumnName("PK_IC_CodCat")
                    .ValueGeneratedNever();

                entity.Property(e => e.VcNomCategoria)
                    .HasColumnName("VC_NomCategoria")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TConcurso>(entity =>
            {
                entity.HasKey(e => e.PkIcIdConcurso);

                entity.ToTable("T_Concurso");

                entity.Property(e => e.PkIcIdConcurso).HasColumnName("PK_IC_IdConcurso");

                entity.Property(e => e.DcFechaConcurso)
                    .HasColumnName("DC_FechaConcurso")
                    .HasColumnType("datetime");

                entity.Property(e => e.FkIecIdEstado).HasColumnName("FK_IEC_IdEstado");

                entity.Property(e => e.IcCantidadNove).HasColumnName("IC_CantidadNove");

                entity.Property(e => e.IcCantidadSeri).HasColumnName("IC_CantidadSeri");

                entity.Property(e => e.VcLugarCon)
                    .HasColumnName("VC_LugarCon")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VcNombreCon)
                    .HasColumnName("VC_NombreCon")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.FkIecIdEstadoNavigation)
                    .WithMany(p => p.TConcurso)
                    .HasForeignKey(d => d.FkIecIdEstado)
                    .HasConstraintName("FK_T_Concurso_T_EstadoCon");
            });

            modelBuilder.Entity<TEstadoCon>(entity =>
            {
                entity.HasKey(e => e.PkIeIdEstado);

                entity.ToTable("T_EstadoCon");

                entity.Property(e => e.PkIeIdEstado)
                    .HasColumnName("PK_IE_IdEstado")
                    .ValueGeneratedNever();

                entity.Property(e => e.VeNombreEsta)
                    .HasColumnName("VE_NombreEsta")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TModalidadCon>(entity =>
            {
                entity.HasKey(e => e.PkImIdModalidad);

                entity.ToTable("T_ModalidadCon");

                entity.Property(e => e.PkImIdModalidad)
                    .HasColumnName("PK_IM_IdModalidad")
                    .ValueGeneratedNever();

                entity.Property(e => e.VmNombreMod)
                    .HasColumnName("VM_NombreMod")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TPuntaje>(entity =>
            {
                entity.HasKey(e => e.PkIpCodP);

                entity.ToTable("T_Puntaje");

                entity.Property(e => e.PkIpCodP).HasColumnName("PK_IP_CodP");

                entity.Property(e => e.FkVumtCod)
                    .IsRequired()
                    .HasColumnName("FK_VUMT_COD")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IpNumeroJurado).HasColumnName("IP_NumeroJurado");

                entity.Property(e => e.IpPuntaje).HasColumnName("IP_Puntaje");

                entity.HasOne(d => d.FkVumtCodNavigation)
                    .WithMany(p => p.TPuntaje)
                    .HasForeignKey(d => d.FkVumtCod)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_T_Puntaje_T_Usuario_Modalidad_Tanda");
            });

            modelBuilder.Entity<TTanda>(entity =>
            {
                entity.HasKey(e => e.PkItCodTan);

                entity.ToTable("T_Tanda");

                entity.Property(e => e.PkItCodTan).HasColumnName("PK_IT_CodTan");

                entity.Property(e => e.DtFechaHora)
                    .HasColumnName("DT_FechaHora")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ItEstado).HasColumnName("IT_Estado");

                entity.Property(e => e.ItGanador).HasColumnName("IT_Ganador");

                entity.Property(e => e.VtDescripcion)
                    .IsRequired()
                    .HasColumnName("VT_Descripcion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VtDescripcion1)
                    .HasColumnName("VT_Descripcion1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VtTipoTanda)
                    .HasColumnName("VT_TipoTanda")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TTipoUsuario>(entity =>
            {
                entity.HasKey(e => e.PkItuTipoUsuario);

                entity.ToTable("T_TipoUsuario");

                entity.Property(e => e.PkItuTipoUsuario)
                    .HasColumnName("PK_ITU_TipoUsuario")
                    .ValueGeneratedNever();

                entity.Property(e => e.VtuNombreTipoUsuario)
                    .HasColumnName("VTU_NombreTipoUsuario")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TUsuario>(entity =>
            {
                entity.HasKey(e => e.PkIuDni);

                entity.ToTable("T_Usuario");

                entity.Property(e => e.PkIuDni)
                    .HasColumnName("PK_IU_Dni")
                    .ValueGeneratedNever();

                entity.Property(e => e.DuFechaNacimiento)
                    .HasColumnName("DU_FechaNacimiento")
                    .HasColumnType("datetime");

                entity.Property(e => e.FkItuTipoUsuario).HasColumnName("FK_ITU_TipoUsuario");

                entity.Property(e => e.FkIuCodCategoria).HasColumnName("FK_IU_CodCategoria");

                entity.Property(e => e.VuAmaterno)
                    .HasColumnName("VU_AMaterno")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VuApaterno)
                    .HasColumnName("VU_APaterno")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VuContraseña)
                    .HasColumnName("VU_Contraseña")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VuFoto)
                    .HasColumnName("VU_Foto")
                    .IsUnicode(false);

                entity.Property(e => e.VuNacademia)
                    .HasColumnName("VU_NAcademia")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VuNombre)
                    .HasColumnName("VU_Nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VuSexo)
                    .HasColumnName("VU_Sexo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.FkItuTipoUsuarioNavigation)
                    .WithMany(p => p.TUsuario)
                    .HasForeignKey(d => d.FkItuTipoUsuario)
                    .HasConstraintName("FK_T_Usuario_T_TipoUsuario");

                entity.HasOne(d => d.FkIuCodCategoriaNavigation)
                    .WithMany(p => p.TUsuario)
                    .HasForeignKey(d => d.FkIuCodCategoria)
                    .HasConstraintName("FK_T_Usuario_T_Categoria");
            });

            modelBuilder.Entity<TUsuarioModalidad>(entity =>
            {
                entity.HasKey(e => e.PkIumCodUm);

                entity.ToTable("T_Usuario_Modalidad");

                entity.Property(e => e.PkIumCodUm).HasColumnName("PK_IUM_CodUM");

                entity.Property(e => e.DumFechaIns)
                    .HasColumnName("DUM_FechaIns")
                    .HasColumnType("date");

                entity.Property(e => e.FkIcIdConcurso).HasColumnName("FK_IC_IdConcurso");

                entity.Property(e => e.FkIeEstado).HasColumnName("FK_IE_Estado");

                entity.Property(e => e.FkImIdModalidad).HasColumnName("FK_IM_IdModalidad");

                entity.Property(e => e.FkIuDni).HasColumnName("FK_IU_Dni");

                entity.Property(e => e.FkIuDniPareja).HasColumnName("FK_IU_Dni_Pareja");

                entity.Property(e => e.IumFase)
                    .HasColumnName("IUM_Fase")
                    .HasMaxLength(50);

                entity.Property(e => e.VmUmArchivoB)
                    .IsRequired()
                    .HasColumnName("VM_UM_ArchivoB")
                    .IsUnicode(false);

                entity.Property(e => e.VmUmArchivoDni)
                    .IsRequired()
                    .HasColumnName("VM_UM_ArchivoDni")
                    .IsUnicode(false);

                entity.HasOne(d => d.FkIcIdConcursoNavigation)
                    .WithMany(p => p.TUsuarioModalidad)
                    .HasForeignKey(d => d.FkIcIdConcurso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_T_Usuario_Modalidad_T_Concurso1");

                entity.HasOne(d => d.FkIeEstadoNavigation)
                    .WithMany(p => p.TUsuarioModalidad)
                    .HasForeignKey(d => d.FkIeEstado)
                    .HasConstraintName("FK_T_Usuario_Modalidad_T_EstadoCon");

                entity.HasOne(d => d.FkImIdModalidadNavigation)
                    .WithMany(p => p.TUsuarioModalidad)
                    .HasForeignKey(d => d.FkImIdModalidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_T_Usuario_Modalidad_T_ModalidadCon");

                entity.HasOne(d => d.FkIuDniNavigation)
                    .WithMany(p => p.TUsuarioModalidadFkIuDniNavigation)
                    .HasForeignKey(d => d.FkIuDni)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_T_Usuario_Modalidad_T_Usuario2");

                entity.HasOne(d => d.FkIuDniParejaNavigation)
                    .WithMany(p => p.TUsuarioModalidadFkIuDniParejaNavigation)
                    .HasForeignKey(d => d.FkIuDniPareja)
                    .HasConstraintName("FK_T_Usuario_Modalidad_T_Usuario3");
            });

            modelBuilder.Entity<TUsuarioModalidadTanda>(entity =>
            {
                entity.HasKey(e => e.PkVumtCod);

                entity.ToTable("T_Usuario_Modalidad_Tanda");

                entity.Property(e => e.PkVumtCod)
                    .HasColumnName("PK_VUMT_COD")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FkIumtCodPart).HasColumnName("FK_IUMT_CodPart");

                entity.Property(e => e.FkIumtCodTan).HasColumnName("FK_IUMT_CodTan");

                entity.Property(e => e.IumtEstado).HasColumnName("IUMT_Estado");

                entity.Property(e => e.IumtPista).HasColumnName("IUMT_Pista");

                entity.Property(e => e.IumtPuntajeTotal).HasColumnName("IUMT_PuntajeTotal");

                entity.HasOne(d => d.FkIumtCodPartNavigation)
                    .WithMany(p => p.TUsuarioModalidadTanda)
                    .HasForeignKey(d => d.FkIumtCodPart)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_T_Usuario_Modalidad_Tanda_T_Usuario_Modalidad");

                entity.HasOne(d => d.FkIumtCodTanNavigation)
                    .WithMany(p => p.TUsuarioModalidadTanda)
                    .HasForeignKey(d => d.FkIumtCodTan)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_T_Usuario_Modalidad_Tanda_T_Tanda");
            });
        }
    }
}
