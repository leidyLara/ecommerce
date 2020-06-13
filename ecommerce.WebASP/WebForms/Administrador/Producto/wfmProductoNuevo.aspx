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
            <td colspan="2">
                <table>
                    <tr>
                        <td class="text-center">
                            <asp:LinkButton ID="lknNuevo" runat="server" OnClick="lknNuevo_Click" CausesValidation="false" >Nuevo</asp:LinkButton>
                            <asp:ImageButton ID="imbNueno" runat="server"  ImageUrl="~/icons/nuevo.png" CausesValidation="false" Width="53px" Height="54px" OnClick="imbNueno_Click"/>
                        </td>
                        <td class="text-center">
                            <asp:LinkButton ID="lknGuardar" runat="server" OnClick="lknGuardar_Click">Guardar</asp:LinkButton>
                            <asp:ImageButton ID="imbGuardar" runat="server"  ImageUrl="~/icons/guardar.png" Width="49px" Height="46px" OnClick="imbGuardar_Click"/>
                        </td>
                        <td class="text-center">
                            &nbsp;</td>
                    </tr>
                </table></td>
        </tr>
        <tr>
            <td style="width: 187px">Id :</td>
            <td><asp:Label ID="lblId" runat="server" Text="lblId"></asp:Label></td>
        </tr>
        <tr>
            <td style="width: 187px">Categoria :</td>
            <%--<td><asp:DropDownList ID="ddlCategoria" runat="server" Height="16px" Width="124px"></asp:DropDownList></td>--%>
            <td><Uc1:UC_categoria ID="UC_categoria1" runat="server"></Uc1:UC_categoria>
            </td>
        </tr>
        <tr>
            <td style="width: 187px">Codigo :</td>
            <td><asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="El campo de codigo es requerido" Text="*" ControlToValidate="txtCodigo" style="font-weight: 700; color: #CC3300"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 187px">nombre:</td>
            <td><asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="El campo del nombre es requerido" Text="*" ControlToValidate="txtNombre" style="color: #CC3300"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 187px">Precio de compra :</td>
            <td><asp:TextBox ID="txtPrecioCompra" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="El campo de Precio compra es requerido" Text="*" ControlToValidate="txtPrecioCompra" style="color: #CC3300"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 187px">Precio de venta :</td>
            <td><asp:TextBox ID="txtPrecioVenta" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="El campo precio de venta es requerido" Text="*" ControlToValidate="txtPrecioVenta" style="color: #CC3300"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 187px">Imagen :</td>
            <td><asp:FileUpload ID="FileUploadProducto" runat="server"></asp:FileUpload>

            </td>
        </tr>
        <tr>
            <td style="width: 187px">Descripcion :</td>
            <td><asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 187px">Stock Minimo :</td>
            <td><asp:TextBox ID="txtStockMinimo" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="El campo stock minimo es requerido" Text="*" ControlToValidate="txtStockMinimo" style="color: #CC3300"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 187px">Stock Maximo :</td>
            <td><asp:TextBox ID="txtStockMaximo" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="El campo stock maximo es requerido" Text="*" ControlToValidate="txtStockMaximo" style="color: #CC3300"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 187px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 187px">Mensaje</td>
            <td>
                <asp:Label ID="lblMensaje" runat="server" style="color: #CC3300"></asp:Label>
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" style="color: #CC3300" />
            </td>
        </tr>
    </table>
</asp:Content>
