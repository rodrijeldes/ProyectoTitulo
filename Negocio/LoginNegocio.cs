using DAO;
using DTO;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public  class LoginNegocio
    {
        public Usuario Logear(string correo, string clave)
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            return usuarioDAO.LogearUsuario(correo, clave);
        }


        public ResultadoDTO RegistrarUsuario(string usuario, string clave, string confirmacion)
        {
            ResultadoDTO resultado = new ResultadoDTO();
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            Usuario u = new Usuario();
            u = usuarioDAO.Buscar(usuario);

            if (clave != confirmacion)
                {
                    resultado.Error = true;
                    resultado.Mensaje = "La confirmación de la clave de usuario no es correcta.";
                    return resultado;
                }
            if (u != null)
                {
                    resultado.Error = true;
                    resultado.Mensaje = "El usuario ya existe.";
                    return resultado;
                }
            u = new Usuario();
            u.correo = usuario;
            u.nombreUsuario = usuario;
            u.clave = clave;
            u.ubicacionUsuario = "";
            resultado = usuarioDAO.Crear(u);

            return resultado;   
        }
    }
}
