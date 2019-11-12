﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGIAMTP.Models
{
    public class UsuarioModels
    {
        private readonly DB_A4F05E_SGIAMTPContext _context;
        private List<IdentityError> identityError;
        private string code = "", des = "";
        
        public UsuarioModels(DB_A4F05E_SGIAMTPContext _context)
        {
            this._context = _context;
            identityError = new List<IdentityError>();
        }

        public List<IdentityError> agregarUsuario(
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

                if(cantidad == 0)
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

            identityError.Add(new IdentityError
            {
                Code = code,
                Description = des
            });

            return identityError;
        }
    }
}
