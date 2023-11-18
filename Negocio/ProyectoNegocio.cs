using DAO;
using DTO;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Negocio
{
    public class ProyectoNegocio
    {

        private ProyectoDAO pDAO = new ProyectoDAO();
        public List<Usp_ListarProyectoPorIdUsaurio_Result> ListarProyectosPorUsuario(int idUsuario)
        {            
            return pDAO.ListarPorUsuario(idUsuario);
        }

        public ResultadoDTO CrearProyecto(Proyecto dto)
        {
            ResultadoDTO resultadoProyecto = new ResultadoDTO();
            ResultadoDTO resultadoUsuarioProyecto = new ResultadoDTO();
            
                using (TransactionScope tran = new TransactionScope())
                {
                try
                   {
                   
                    if (!resultadoUsuarioProyecto.Error)
                    {
                        UsuarioProyectoDAO upDAO = new UsuarioProyectoDAO();
                        UsuarioProyecto up = new UsuarioProyecto();                     
                        up.idUsuario = dto.idUsuarioPorpietario ?? 0;
                        up.idUsuarioProyecto = dto.idUsuarioPorpietario ?? 0;
                        up.puedeAgregarParticipante = true;
                        up.puedeAsignarActividad = true;
                        up.puedeCerrarActividad = true;
                        up.activo = true;
                        up.esPropietario = true;
                        dto.UsuarioProyecto.Add(up);
                        resultadoProyecto = pDAO.Crear(dto);
                    }
                    if (!resultadoUsuarioProyecto.Error)
                    { tran.Complete(); }
                    else
                    {
                        tran.Dispose();
                        resultadoProyecto.Error = true;
                    }
                 }
                catch
                {
                    tran.Dispose();
                    resultadoProyecto.Error = true;
                }
            }
            
            return resultadoUsuarioProyecto;
                  
        }


        public List<Usp_ListaUsuarioProyecto_Result> ListaUsuariosProyectos(int idProyecto)
        {
            UsuarioProyectoDAO upDAO = new UsuarioProyectoDAO();
            return upDAO.ListaUsuariosProyecto(idProyecto);
        }

        public List<Usuario> FiltrarUsuariosPorNombre(string nom)
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            return usuarioDAO.Filtrar(nom);
        }

        public void AgregarUsuarioProyecto(int idUsuario, int idProyecto, bool asigna, bool cierra, bool participantes)
        {
            UsuarioProyectoDAO upDAO = new UsuarioProyectoDAO();
            upDAO.AgregarUsuarioProyecto(idUsuario, idProyecto, asigna, cierra, participantes);
        }

        public List<ListaDTO>ListaProyectosPorUsuario(int idUsuario)
        {
            List<ListaDTO> lista = new List<ListaDTO>();
            lista = (from l in pDAO.ListarPorUsuario(idUsuario) select new ListaDTO { value = l.idProyecto, text = l.nombreProyecto }).ToList();
            return lista;
        }

        public UsuarioProyecto BuscarUsuarioProyectoPorIdUsuario(int idUsuario)
        {
            UsuarioProyectoDAO upDAO = new UsuarioProyectoDAO();
            return upDAO.BuscaPorIdUsuario(idUsuario);
        }
    }
}
