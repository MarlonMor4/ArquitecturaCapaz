using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CAPAENTIDAD;
using CAPANEGOCIO;
using System.Data;

namespace Proyecto
{
  
    public partial class FORMULARIOTIENDA : System.Web.UI.Page
    {
        CETienda OENTienda = new CETienda();
        CNTienda ontienda = new CNTienda();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnguardad_Click(object sender, EventArgs e)
        {
            DataSet ds=new DataSet();
            OENTienda.Tienda_id = Convert.ToString(txtTiendaid.Text);
            OENTienda.Tienda_nombre = Convert.ToString(txtnombre.Text);
            OENTienda.Telefono = Convert.ToString(txttelefono.Text);
            OENTienda.Email = Convert.ToString(txtemail.Text);
            OENTienda.Direccion = Convert.ToString(txtdireccion.Text);
            OENTienda.Ciudad = Convert.ToString(txtciudad.Text);
            OENTienda.Estado= Convert.ToString(txtactivo.Text);
            OENTienda.Zip_code = Convert.ToString(txtcode.Text);

            if (ontienda.guardar_tienda(OENTienda))
            {
                mensaje.Text = "tienda guardado";
            }
            else
            {
                mensaje.Text = "No se guardo la tienda";
            }
        }
    }
}