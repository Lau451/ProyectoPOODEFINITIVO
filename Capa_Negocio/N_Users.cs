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
    public class N_Users
    {

        D_Users objd = new D_Users();

        public DataTable N_user(E_Users obje)
        {
            return objd.D_user(obje);
        }
        public DataTable N_listar_clientes()
        {
            return objd.D_listar_clientes();
        }

        public DataTable N_buscar_clientes(E_Users obje)
        {
            return objd.D_buscar_clientes(obje);
        }

        public String N_mantenimiento_cliente(E_Users obje)
        {
            return objd.D_mantenimiento_clientes(obje);
        }

    }
}
