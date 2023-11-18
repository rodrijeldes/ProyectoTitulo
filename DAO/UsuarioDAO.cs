using DTO;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class UsuarioDAO
    {
        public Usuario LogearUsuario(string correo, string clave)
        {
            Usuario usuario = new Usuario();
            using (HojaDeTareasContexto contexto = new HojaDeTareasContexto())
            {
                usuario = contexto.Usuario.FirstOrDefault(u => u.correo == correo && u.clave == clave);
            }
            return usuario;
        }

        public Usuario Buscar(int id)
        {
            Usuario usuario = new Usuario();
            using (HojaDeTareasContexto contexto = new HojaDeTareasContexto())
            {
                usuario = contexto.Usuario.FirstOrDefault(u => u.idUsuario == id);
            }
            return usuario;
        }

        public Usuario Buscar(string nom)
        {
            Usuario usuario = new Usuario();
            using (HojaDeTareasContexto contexto = new HojaDeTareasContexto())
            {
                usuario = contexto.Usuario.FirstOrDefault(u => u.nombreUsuario == nom);
            }
            return usuario;
        }

        public List<Usuario> Filtrar(string nom)
        {
            List<Usuario> usuario = new List<Usuario>();
            using (HojaDeTareasContexto contexto = new HojaDeTareasContexto())
            {
                usuario = contexto.Usuario.Where(u => u.nombreUsuario.Contains(nom) || u.correo.Contains(nom)).ToList();
            }
            return usuario;
        }


        public ResultadoDTO Crear(Usuario dto)
        {
            ResultadoDTO resultado = new ResultadoDTO();
            try
            {
                using (HojaDeTareasContexto contexto = new HojaDeTareasContexto())
                {
                    contexto.Usuario.Add(dto);
                    contexto.SaveChanges();
                    resultado.Identity = dto.idUsuario;
                    resultado.Error = false;

                }
            }
            catch(Exception e)
            {
                resultado.Error = true;
                resultado.Mensaje = "Error al crear el usuario.";
            }
            return resultado;
        }
    }
}
