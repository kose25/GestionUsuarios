using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsuariosCore.Entidades;
using UsuariosCore.Interactores;

namespace GestionUsuarios.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IRegistro _registro;

        public IndexModel(IRegistro registro)
        {
            _registro = registro;
        }

        public void OnGet()
        {

        }

        public async Task<JsonResult> OnPostRegistrarUsuario(Usuarios usuario)
        {
            try
            {                
                usuario = await _registro.RegistrarUsuario(usuario);               
            }
            catch (Exception e)
            {
                //Logger logger = LogManager.GetCurrentClassLogger();
                //logger.Error(e, "Error al insertar la unidad");
            }
            return new JsonResult(usuario);
        }
    }
}
