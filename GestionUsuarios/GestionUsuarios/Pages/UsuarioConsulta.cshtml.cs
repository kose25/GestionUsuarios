using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Data.ResponseModel;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using UsuariosCore.Entidades;
using UsuariosCore.Interactores;

namespace GestionUsuarios.Pages
{
    public class UsuarioConsultaModel : PageModel
    {
        private readonly IRegistro _registro;

        public UsuarioConsultaModel(IRegistro registro)
        {
            _registro = registro;
        }

        public void OnGet()
        {
        }
        public async Task<JsonResult> OnGetListaUsuarios(DataSourceLoadOptions loadOptions)
        {
            List<Usuarios> usuarios = new List<Usuarios>();
            try
            {
                bool getAll = true;
                if (loadOptions.Take > 0)
                {
                    getAll = false;
                }
                usuarios = await _registro.ListarUsuarios(getAll, loadOptions.Take, loadOptions.Skip);
                var data = DataSourceLoader.Load(usuarios, loadOptions);
                if (usuarios.Any())
                {
                    data.totalCount = usuarios[0].TotalCount;
                }
                return new JsonResult(data);
            }
            catch (Exception e)
            {                
                return new JsonResult(e.Message);
            }            
        }

        public async Task<JsonResult> OnPostActualizarUsuario(Usuarios usuario)
        {
            bool respuesta = false;
            try
            {

                if (usuario != null && usuario != new Usuarios())
                {                    
                    _registro.ActualizarUsuario(usuario);
                    respuesta = true;
                }
            }
            catch (Exception e)
            {
                return new JsonResult(e.Message);
            }

            return new JsonResult(respuesta);
        }

        public async Task<JsonResult> OnPostEliminarUsuario(Usuarios usuario)
        {
            bool respuesta = false;
            try
            {

                if (usuario != null && usuario != new Usuarios())
                {
                    _registro.EliminarUsuario(usuario);
                    respuesta = true;
                }
            }
            catch (Exception e)
            {
                return new JsonResult(e.Message);
            }

            return new JsonResult(respuesta);
        }
    }
}
