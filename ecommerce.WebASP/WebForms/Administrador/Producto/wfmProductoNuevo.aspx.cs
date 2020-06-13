using ecommerce.WebASP.Logica;
using ecommerce.WebASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ecommerce.WebASP.WebForms.Administrador.Producto
{
    public partial class wfmProductoNuevo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }

        }

        private void newProduct()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtPrecioVenta.Text = "";
            txtPrecioCompra.Text = "";
            txtStockMaximo.Text = "";
            txtStockMinimo.Text = "";
            UC_categoria1.DropDownList.SelectedIndex = 0;
        }
        protected void imbNueno_Click(object sender, ImageClickEventArgs e)
        {
            newProduct();
        }

        protected void lknNuevo_Click(object sender, EventArgs e)
        {
            newProduct();
        }

        private void saveProduct()
        {
            try
            {
                TBL_PRODUCTO _infoProducto = new TBL_PRODUCTO();
               // _infoProducto.PRO_ID = 100;
                _infoProducto.CAT_ID = Convert.ToInt16(UC_categoria1.DropDownList.SelectedValue);
                _infoProducto.PRO_CODIGO = txtCodigo.Text;
                _infoProducto.PRO_NOMBRE = txtNombre.Text;
                _infoProducto.PRO_DESC = txtDescripcion.Text;
                _infoProducto.PRO_IMAGEN = "C:/imagen";
                _infoProducto.PRO_PRECIO_COMPRA = Convert.ToDecimal(txtPrecioCompra.Text);
                _infoProducto.PRO_PRECIO_VENTA = Convert.ToDecimal(txtPrecioVenta.Text);
                _infoProducto.PRO_STOCKMAXIMO = txtStockMaximo.Text;
                _infoProducto.PRO_STOCKMINIMO = txtStockMinimo.Text;
                Task<bool> _taskSaveProducto = Task.Run(() => LogicaProducto.saveProduct(_infoProducto));
                _taskSaveProducto.Wait();
                var resultado = _taskSaveProducto.Result;
                if (resultado)
                {
                    lblMensaje.Text = "Registro Guardado Correctamente";
                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }
        protected void lknGuardar_Click(object sender, EventArgs e)
        {
            saveProduct();
        }

        protected void imbGuardar_Click(object sender, ImageClickEventArgs e)
        {
            saveProduct();
        }
    }
}