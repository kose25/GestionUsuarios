using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsuariosCore.Entidades;
using UsuariosCore.Interactores;
using UsuariosInfrastructure.Database;

namespace UsuariosInfrastructure.Implementations
{
    public class Registro:IRegistro
    {
        private readonly AppDbContext _dbcontext;
        public Registro(AppDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<List<Usuarios>> ListarUsuarios(bool getall, int take, int skip)
        {
            List<Usuarios> usuarios = new List<Usuarios>();
            var query = _dbcontext.Usuario.AsQueryable();
            if (getall)
            {
                usuarios = await query.ToListAsync();
                if (usuarios.Any())
                {
                    usuarios[0].TotalCount = await query.CountAsync();
                }
            }
            else
            {
                if (take > 0)
                {
                    usuarios = await query.Skip(skip).Take(take).ToListAsync();
                    if (usuarios.Any())
                    {
                        usuarios[0].TotalCount = await query.CountAsync();
                    }
                }
            }
            return usuarios;        
        }

        public void ActualizarUsuario(Usuarios usuario)
        {
            _dbcontext.Update<Usuarios>(usuario);
            _dbcontext.SaveChanges();

        }

        public async Task<Usuarios> RegistrarUsuario(Usuarios usuario)
        {           
            await _dbcontext.Usuario.AddAsync(usuario);
            await _dbcontext.SaveChangesAsync();

            return usuario;
        }

        public void EliminarUsuario(Usuarios usuario)
        {
            var itemToRemove = _dbcontext.Usuario.SingleOrDefault(x => x.Id == usuario.Id);

            if (itemToRemove != null)
            {
                _dbcontext.Usuario.Remove(itemToRemove);
                _dbcontext.SaveChanges();
            }
        }
    }
}
