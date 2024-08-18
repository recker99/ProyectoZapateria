<%@ Page Title="Registro de Usuario" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="ProyectoZapateria.Registro" %>  

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">  
    <div class="d-flex justify-content-center align-items-center" style="min-height: 80vh;">  
        <div class="col-md-4">  
            <div class="card p-4">  
                <h2 class="text-center mb-4">Registro de Usuario</h2>  
                <asp:Label ID="lblMensaje" runat="server" Text="" ForeColor="Red" CssClass="d-block text-center mb-3"></asp:Label>  
                <div class="d-flex flex-column">  
                    <div class="form-group">  
                        <asp:TextBox ID="txtUsuario" runat="server" CssClass="form-control mb-3" placeholder="Usuario" required="true"></asp:TextBox>  
                    </div>  
                    <div class="form-group">  
                        <asp:TextBox ID="txtContrasena" runat="server" CssClass="form-control mb-3" TextMode="Password" placeholder="Contraseña" required="true"></asp:TextBox>  
                    </div>  
                    <div class="form-group">  
                        <asp:TextBox ID="txtNombreUsuario" runat="server" CssClass="form-control mb-4" placeholder="Nombre" required="true"></asp:TextBox>  
                    </div>  
                    <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" CssClass="btn btn-primary btn-block" OnClick="btnRegistrar_Click" />  
                </div>  
            </div>  
        </div>  
    </div>  
</asp:Content>