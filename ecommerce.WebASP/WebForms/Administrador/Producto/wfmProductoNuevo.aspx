<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="wfmProductoNuevo.aspx.cs" Inherits="ecommerce.WebASP.WebForms.Administrador.Producto.wfmProductoNuevo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
  <%@ Register Src="~/UserControl/ucCategoria.ascx" TagName="UC_categoria" TagPrefix="Uc1" %>
    <br />
    <table>
        <tr>
            <td colspan="2" class="text-center">
                <strong>Producto
            </strong>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 187px">Id :</td>
            <td><asp:Label ID="lblId" runat="server" Text="lblId"></asp:Label></td>
        </tr>
        <tr>
            <td style="width: 187px">Categoria :</td>
            <%--<td><asp:DropDownList ID="ddlCategoria" runat="server" Height="16px" Width="124px"></asp:DropDownList></td>--%>
            <td><Uc1:UC_categoria ID="UC_categoria1" runat="server"></Uc1:UC_categoria></td>
        </tr>
        <tr>
            <td style="width: 187px">Codigo :</td>
            <td><asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 187px">nombre:</td>
            <td><asp:TextBox ID="txtNombre" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 187px">Precio de compra :</td>
            <td><asp:TextBox ID="txtPrecioCompra" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 187px">Precio de venta :</td>
            <td><asp:TextBox ID="txtPrecioVenta" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 187px">Imagen :</td>
            <td><asp:FileUpload ID="FileUploadProducto" runat="server"></asp:FileUpload></td>
        </tr>
        <tr>
            <td style="width: 187px">Descripcion :</td>
            <td><asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 187px">Stock Minimo :</td>
            <td><asp:TextBox ID="txtStockMinimo" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 187px">Stock Maximo :</td>
            <td><asp:TextBox ID="txtStockMaximo" runat="server"></asp:TextBox></td>
        </tr>
    </table>
</asp:Content>
