using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SGIAMTP.Models
{
    public class ModelContex
    {
        private readonly DB_A4F05E_SGIAMTPContext _context;
        private List<IdentityError> _identityError;
        private string code = "", des = "";

        public ModelContex(DB_A4F05E_SGIAMTPContext _context)
        {
            this._context = _context;
            _identityError = new List<IdentityError>();
        }

        public List<IdentityError> AgregarParticipante(
            int FkIuDni,
            int FkIcIdConcurso,
            int FkImIdModalidad,
            string IumFase,
            int FkIuDniPareja,
            DateTime DumFechaIns,
            string VmUmArchivoDni,
            string VmUmArchivoB,
            int FkIeEstado
            )
        {
            var usuarioModalidad = new TUsuarioModalidad
            {
                FkIuDni = FkIuDni,
                FkIcIdConcurso = FkIcIdConcurso,
                FkImIdModalidad = FkImIdModalidad,
                IumFase = IumFase,
                FkIuDniPareja = FkIuDniPareja,
                DumFechaIns = DumFechaIns,
                VmUmArchivoDni = VmUmArchivoDni,
                VmUmArchivoB = VmUmArchivoB,
                FkIeEstado = FkIeEstado
            };

            try
            {
                Console.WriteLine(usuarioModalidad.FkIuDni);
                //var codigoUsuario = _context.TUsuario.SingleOrDefault(u => u.PkIuDni == usuario.PkIuDni);

                var codigoParticipante = (from u in _context.TUsuarioModalidad
                                          where u.FkIuDni == usuarioModalidad.FkIuDni
                                          select u.FkIuDni);

                int cantidad = codigoParticipante.Count();

                if (cantidad == 0)
                {
                    _context.Add(codigoParticipante);
                    _context.SaveChanges();
                    code = "Save";
                    des = "Save";
                }
                else
                {
                    code = "Existe";
                    //des = "Save";
                }

            }
            catch (Exception e)
            {
                code = "error" + e.Message + " ";
                des = e.Message;
            }

            _identityError.Add(new IdentityError
            {
                Code = code,
                Description = des
            });

            return _identityError;
        }

        public List<IdentityError> AgregarUsuario(
            int PkIuDni,
            string VuNombre,
            string VuApaterno,
            string VuAmaterno,
            DateTime DuFechaNacimiento,
            string VuContraseña,
            string VuSexo,
            string VuNacademia,
            int FkIuCodCategoria,
            int FkItuTipoUsuario,
            string VuFoto
            )
        {

            var usuario = new TUsuario
            {
                PkIuDni = PkIuDni,
                VuNombre = VuNombre,
                VuApaterno = VuApaterno,
                VuAmaterno = VuAmaterno,
                DuFechaNacimiento = DuFechaNacimiento,
                VuContraseña = VuContraseña,
                VuSexo = VuSexo,
                VuNacademia = VuNacademia,
                FkIuCodCategoria = FkIuCodCategoria,
                FkItuTipoUsuario = FkItuTipoUsuario,
                VuFoto = VuFoto
            };



            try
            {
                Console.WriteLine(usuario.PkIuDni);
                //var codigoUsuario = _context.TUsuario.SingleOrDefault(u => u.PkIuDni == usuario.PkIuDni);

                var codigoUsuario = (from u in _context.TUsuario
                                     where u.PkIuDni == usuario.PkIuDni
                                     select u.PkIuDni);

                int cantidad = codigoUsuario.Count();

                if (cantidad == 0)
                {
                    _context.Add(usuario);
                    _context.SaveChanges();
                    code = "Save";
                    des = "Save";
                }
                else
                {
                    code = "Existe";
                    //des = "Save";
                }

            }
            catch (Exception e)
            {
                code = "error" + e.Message + " ";
                des = e.Message;
            }

            _identityError.Add(new IdentityError
            {
                Code = code,
                Description = des
            });

            return _identityError;
        }
    }
}
