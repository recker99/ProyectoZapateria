<%@ Page Title="Gestión de Usuario" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Manage.aspx.cs" Inherits="ProyectoZapateria.Manage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-6 col-md-offset-3">
                <h2>Gestión de Perfil</h2>
                <asp:Label ID="lblMensaje" runat="server" Text="" ForeColor="Red"></asp:Label>
                <asp:TextBox ID="txtUsuario" runat="server" CssClass="form-control" placeholder="Usuario" ReadOnly="true"></asp:TextBox>
                <asp:TextBox ID="txtContrasena" runat="server" CssClass="form-control" TextMode="Password" placeholder="Nueva Contraseña"></asp:TextBox>
                <asp:TextBox ID="txtNombreUsuario" runat="server" CssClass="form-control" placeholder="Nombre" required="true"></asp:TextBox>
                <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" CssClass="btn btn-primary btn-block" OnClick="btnActualizar_Click" />
            </div>
        </div>
    </div>
</asp:Content>
