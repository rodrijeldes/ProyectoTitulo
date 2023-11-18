using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entidades;

namespace MVC_HojaDeTareas.Models.Actividad
{
    public class ListaActividadesModel
    {
        public List<Usp_ListaActividadesProyectoPorUsuario_Result> listaActividades { set; get; }
        public int idUsuario { set; get; }
        public int idPoryecto { set; get; }
        public UsuarioProyecto usuarioProyeto { set; get; }
    }
}