using Entidades;
using DAO;
using DTO;
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ActividadNegocio
    {
        private ActividadDAO actividadDAO = new ActividadDAO();
        public Actividad BuscarActividadPorId(int idActividad)
        {
            
            return actividadDAO.Buscar(idActividad);
        }

        public ResultadoDTO CrearActividad(Actividad dto)
        {
            ResultadoDTO resultado = new ResultadoDTO();
            resultado = actividadDAO.Crear(dto);
            return resultado;
        }

        public List<Actividad>ListarActividadesPorUsuario(int idUsuario)
        {
            return actividadDAO.ListarActividadesPorUsuario(idUsuario);
        }

        public List<Usp_ListaActividadesProyectoPorUsuario_Result>ListarActividadPorIdUsuarioIdProyecto(int idUsuario, int idProyecto)
        {
            List<Usp_ListaActividadesProyectoPorUsuario_Result> lista = new List<Usp_ListaActividadesProyectoPorUsuario_Result>();
            ActividadDAO actividadDAO = new ActividadDAO();
            return actividadDAO.ListarPorIdUsuarioIdProyecto(idUsuario,idProyecto);
        }
    }
}
