﻿using ecommerce.WebASP.Logica;
using ecommerce.WebASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ecommerce.WebASP.UserControl
{
    public partial class ucCategoria : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                UcCargar();
            }
        }

        public int SelectedIndex
        {
            get
            {
                return DropDownList1.SelectedIndex;
            }
            set
            {
                DropDownList1.SelectedIndex = value;
            }
        }

        public DropDownList DropDownList
        {
            get
            {
                return DropDownList1;
            }
            set
            {
                DropDownList1 = value;
            }
        }


        public void UcCargar()
        {
            try
            {
                Task<List<TBL_CATEGORIA>> _taskCategoria = Task.Run(() => LogicaCategoria.getAllCategoria());
                _taskCategoria.Wait();
                var _listaCategoria = _taskCategoria.Result;
                if (_listaCategoria != null && _listaCategoria.Count >0)
                {
                    //ordenar linq
                    var data = _listaCategoria.OrderBy(lista => lista.CAT_NOMBRE).ToList();
                    //insertar registro en la lista categoria en el indice 0
                    data.Insert(0, new TBL_CATEGORIA { CAT_DESC = "Seleccione Categoria......", CAT_ID = 0 });

                    DropDownList1.DataSource = _listaCategoria;
                    DropDownList1.DataTextField = "CAT_NOMBRE";
                    DropDownList1.DataValueField = "CAT_ID";
                    DropDownList1.DataBind();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}