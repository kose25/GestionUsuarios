using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UsuariosCore.Entidades;

namespace UsuariosCore.Interactores
{
    public interface IRegistro
    {
        Task<List<Usuarios>> ListarUsuarios(bool getall, int take, int skip);
        void ActualizarUsuario(Usuarios usuario);
        Task<Usuarios> RegistrarUsuario(Usuarios usuario);
        void EliminarUsuario(Usuarios usuario);
    }
}
