using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using System.Data;
using Capa_Entidad;


namespace Capa_Negocio
{
    public class N_Productos
    {
        D_Productos objd = new D_Productos();
        public DataTable N_listar_productos()
        {
            return objd.D_listar_productos();
        }
        public String N_mantenimiento_productos(E_Productos obje)
        {
            return objd.D_mantenimiento_productos(obje);
        }

    }
        

}
