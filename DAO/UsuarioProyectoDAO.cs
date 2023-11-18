using DTO;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class UsuarioProyectoDAO
    {
        public ResultadoDTO Crear(UsuarioProyecto dto)
        {
            ResultadoDTO resultado = new ResultadoDTO();
            try
            {
                using (HojaDeTareasContexto contexto = new HojaDeTareasContexto())
                {
                    contexto.UsuarioProyecto.Add(dto);
                    contexto.SaveChanges();
                    resultado.Error = false;
                }
            }
            catch(Exception ex)
            {
                resultado.Error = true;
                resultado.Mensaje = ex.Message;
            }
            return resultado;
        }

        public List<Usp_ListaUsuarioProyecto_Result>ListaUsuariosProyecto(int idProyecto)
        {
            List<Usp_ListaUsuarioProyecto_Result> lista = new List<Usp_ListaUsuarioProyecto_Result>();
            using (HojaDeTareasContexto contexto = new HojaDeTareasContexto())
            {
                lista = contexto.Usp_ListaUsuarioProyecto(idProyecto).ToList();
            }
            return lista;
        }

        public void AgregarUsuarioProyecto(int idUsuario, int idProyecto, bool asigna, bool cierra, bool participantes)
        {
            using (HojaDeTareasContexto contexto = new HojaDeTareasContexto())
            {
                contexto.Usp_AgregarUsuarioProyecto(idUsuario, idProyecto, asigna, cierra, participantes);
            }
        }

        public UsuarioProyecto BuscaPorIdUsuario(int idUsuario)
        {
            UsuarioProyecto up = new UsuarioProyecto();
            using (HojaDeTareasContexto contexto = new HojaDeTareasContexto())
            {
                up = contexto.UsuarioProyecto.FirstOrDefault(u => u.idUsuario == idUsuario);
            }
            return up;
        }
    }
}
