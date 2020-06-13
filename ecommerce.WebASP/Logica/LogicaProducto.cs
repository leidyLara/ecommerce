using ecommerce.WebASP.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ecommerce.WebASP.Logica
{
    public class LogicaProducto
    {
        private static BDecommerceCarrito db = new BDecommerceCarrito();
        public static async Task<List<TBL_PRODUCTO>> getAllProduct()
        {
            try
            {
                return await db.TBL_PRODUCTO.Where(data => data.PRO_ESTADO == "A").ToListAsync();
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Error al consultar producto");
            }
        }

        public static async Task<TBL_PRODUCTO> getProductXId(int codigo)
        {
            try
            {
                return await db.TBL_PRODUCTO.Where(data => data.PRO_ESTADO == "A"
                                                    && data.PRO_CODIGO.Equals(codigo)).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Error al consultar producto");
            }
        }

        public static async Task<TBL_PRODUCTO> getproductXCode(string codigo)
        {
            try
            {
                return await db.TBL_PRODUCTO.Where(data => data.PRO_ESTADO == "A"
                                                    && data.PRO_CODIGO.Equals(codigo)).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Error al consultar producto");
            }
        }

        public static async Task<bool> saveProduct(TBL_PRODUCTO _listaproducto)
        {
            try
            {
                bool resultado = false;
                _listaproducto.PRO_ESTADO = "A";
                _listaproducto.PRO_ADD = DateTime.Now;
                db.TBL_PRODUCTO.Add(_listaproducto);
                
                
                await db.SaveChangesAsync();
                resultado = true;
                return resultado;
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Error al consultar producto");
            }
        }

        public static async Task<bool> updateProduct(TBL_PRODUCTO _listaproducto)
        {
            try
            {
                bool resultado = false;
                _listaproducto.PRO_ADD = DateTime.Now;

                await db.SaveChangesAsync();
                resultado = true;
                return resultado;
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Error al consultar producto");
            }
        }

        public static async Task<bool> deleteProduct(TBL_PRODUCTO _listaproducto)
        {
            try
            {
                bool resultado = false;
                _listaproducto.PRO_ADD = DateTime.Now;
                _listaproducto.PRO_ESTADO = "I";
                //eliminar de forma fisica
                //db.TBL_PRODUCTO.Remove(_listaproducto);
                await db.SaveChangesAsync();
                resultado = true;
                return resultado;
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Error al consultar producto");
            }
        }


    }
}