using DTO;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ActividadDAO
    {
        public Actividad Buscar(int idActividad)
        {
            Actividad actividad = new Actividad();
            using (HojaDeTareasContexto contexto = new HojaDeTareasContexto())
            {
                actividad = contexto.Actividad.FirstOrDefault(a => a.idActividad == idActividad);
            }
            return actividad;
        }

        public List<Actividad>ListarActividadesPorUsuario(int idUsuario)
        {
            List<Actividad> actividades = new List<Actividad>();
            using (HojaDeTareasContexto contexto = new HojaDeTareasContexto())
            {
                actividades = contexto.Actividad.Where(a => a.idUsuario == idUsuario).ToList();
            }
            return actividades; 
        }

        public ResultadoDTO Crear(Actividad dto)
        {
            ResultadoDTO resultado = new ResultadoDTO();
            try
            {
                using (HojaDeTareasContexto contexto = new HojaDeTareasContexto())
                {

                    contexto.Actividad.Add(dto);
                    contexto.SaveChanges();
                    resultado.Error = false;
                    resultado.Identity = dto.idActividad;
                }
            }
            catch(Exception ex)
            {
                resultado.Error = true;
                resultado.Mensaje = ex.Message;
            }
            return resultado;
        }

        public List<Usp_ListaActividadesProyectoPorUsuario_Result>ListarPorIdUsuarioIdProyecto(int idUsuario, int idProyecto)
        {
            List<Usp_ListaActividadesProyectoPorUsuario_Result> lista = new List<Usp_ListaActividadesProyectoPorUsuario_Result>();
            using (HojaDeTareasContexto contexto = new HojaDeTareasContexto())
            {
                lista = contexto.Usp_ListaActividadesProyectoPorUsuario(idUsuario, idProyecto).ToList();
            }
            return lista;
        }
       
    }
}
