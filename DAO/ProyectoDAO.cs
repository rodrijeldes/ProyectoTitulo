using DTO;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ProyectoDAO
    {
        public List<Usp_ListarProyectoPorIdUsaurio_Result> ListarPorUsuario(int idUsuario)
        {
            List<Usp_ListarProyectoPorIdUsaurio_Result> lista = new List<Usp_ListarProyectoPorIdUsaurio_Result>();
            using (HojaDeTareasContexto contexto = new HojaDeTareasContexto())
            {
                lista = contexto.Usp_ListarProyectoPorIdUsaurio(idUsuario).ToList();
                
            }
            return lista;                 
        }

        public ResultadoDTO Crear(Proyecto dto)
        {
            ResultadoDTO resultado = new ResultadoDTO();
            try
            {
                using (HojaDeTareasContexto contexto = new HojaDeTareasContexto())
                {
                    contexto.Proyecto.Add(dto);
                    contexto.SaveChanges();
                    resultado.Identity = dto.idEstadoProyecto;
                    resultado.Error = false;
                }
            }
            catch(Exception e)
            {
                resultado.Error = false;
                resultado.Mensaje = e.Message;

            }
            return resultado;
        }

    }
}
