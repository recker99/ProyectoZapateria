<%@ Page Title="Eliminar Producto" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EliminarProducto.aspx.cs" Inherits="ProyectoZapateria.EliminarProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h2>Eliminar Producto</h2>
        <asp:Label ID="LblError" runat="server" ForeColor="Red"></asp:Label>
        <p>¿Estás seguro de que deseas eliminar este producto?</p>
        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" CssClass="btn btn-danger" />
        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" PostBackUrl="Productos.aspx" CssClass="btn btn-secondary" />
    </div>
</asp:Content>

