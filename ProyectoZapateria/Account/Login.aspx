<%@ Page Title="Inicio de Sesión" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProyectoZapateria.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="d-flex justify-content-center align-items-center" style="min-height: 80vh;">
        <div class="col-md-4">
            <div class="card p-4">
                <h2 class="text-center mb-4">Inicio de Sesión</h2>
                <asp:Label ID="lblMensaje" runat="server" Text="" ForeColor="Red" CssClass="d-block text-center mb-3"></asp:Label>
                <div class="d-flex flex-column align-items-center">
                    <div class="form-group w-100">
                        <asp:TextBox ID="txtUsuario" runat="server" CssClass="form-control mb-3 ml-2" placeholder="Usuario" required="true"></asp:TextBox>
                    </div>
                    <div class="form-group w-100">
                        <asp:TextBox ID="txtContrasena" runat="server" CssClass="form-control mb-4 ml-2" TextMode="Password" placeholder="Contraseña" required="true"></asp:TextBox>
                    </div>
                    <asp:Button ID="btnLogin" runat="server" Text="Iniciar Sesión" CssClass="btn btn-primary btn-block ml-2" OnClick="btnLogin_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
