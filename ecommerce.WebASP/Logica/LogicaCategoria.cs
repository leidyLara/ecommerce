using ecommerce.WebASP.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ecommerce.WebASP.Logica
{
    public class LogicaCategoria
    {
        private static BDecommerceCarrito db = new BDecommerceCarrito();
        public static async Task<List<TBL_CATEGORIA>> getAllCategoria()
        {
            try
            {
                return await db.TBL_CATEGORIA.Where(data => data.CAT_ESTADO == "A").ToListAsync();
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Error al consultar categoria");
            }
        }

        public static async Task<TBL_CATEGORIA> getCategoriaXId(int codigo)
        {
            try
            {
                return await db.TBL_CATEGORIA.Where(data => data.CAT_ESTADO == "A"
                                                    && data.CAT_ID.Equals(codigo)).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Error al consultar Categoria");
            }
        }

        public static async Task<TBL_CATEGORIA> getCategoriaXCode(string codigo)
        {
            try
            {
                return await db.TBL_CATEGORIA.Where(data => data.CAT_ESTADO == "A"
                                                    && data.CAT_ID.Equals(codigo)).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Error al consultar Categoria");
            }
        }

        public static async Task<bool> saveProduct(TBL_CATEGORIA _listacategoria)
        {
            try
            {
                bool resultado = false;
                _listacategoria.CAT_ESTADO = "A";
                _listacategoria.CAT_ADD = DateTime.Now;
                db.TBL_CATEGORIA.Add(_listacategoria);


                await db.SaveChangesAsync();
                resultado = true;
                return resultado;
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Error al consultar Categoria");
            }
        }

        public static async Task<bool> updateCategoria(TBL_CATEGORIA _listacategoria)
        {
            try
            {
                bool resultado = false;
                _listacategoria.CAT_ADD = DateTime.Now;

                await db.SaveChangesAsync();
                resultado = true;
                return resultado;
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Error al consultar Categoria");
            }
        }

        public static async Task<bool> deleteCategoria(TBL_CATEGORIA _listacategoria)
        {
            try
            {
                bool resultado = false;
                _listacategoria.CAT_ADD = DateTime.Now;
                _listacategoria.CAT_ESTADO = "I";
                //eliminar de forma fisica
                //db.TBL_PRODUCTO.Remove(_listaproducto);
                await db.SaveChangesAsync();
                resultado = true;
                return resultado;
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Error al consultar Categoria");
            }
        }

    }
}