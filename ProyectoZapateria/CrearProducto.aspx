<%@ Page Title="Crear Producto" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CrearProducto.aspx.cs" Inherits="ProyectoZapateria.CrearProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <main class="container mt-5">
    <section class="row justify-content-center mb-4" aria-labelledby="aspnetTitle">
        <div class="col-md-8">
            <h2 id="aspnetTitle" class="text-center mb-4">Crear Producto</h2>
            <div class="card p-4 shadow-sm">
                <asp:Label ID="LblError" runat="server" CssClass="text-danger d-block text-center mb-3" />
                <asp:Panel ID="pnlForm" runat="server">
                    <div class="form-group row mb-3">
                        <label for="txtNomProd" class="col-sm-4 col-form-label">Nombre Producto</label>
                        <div class="col-sm-8">
                            <asp:TextBox runat="server" ID="txtNomProd" CssClass="form-control" />
                        </div>
                    </div>
                    <div class="form-group row mb-3">
                        <label for="txtDes" class="col-sm-4 col-form-label">Descripción</label>
                        <div class="col-sm-8">
                            <asp:TextBox runat="server" ID="txtDes" CssClass="form-control" />
                        </div>
                    </div>
                    <div class="form-group row mb-3">
                        <label for="txtPrecio" class="col-sm-4 col-form-label">Precio</label>
                        <div class="col-sm-8">
                            <asp:TextBox runat="server" ID="txtPrecio" CssClass="form-control" />
                        </div>
                    </div>
                    <div class="form-group row mb-4">
                        <label for="txtUltMod" class="col-sm-4 col-form-label">Última Modificación</label>
                        <div class="col-sm-8">
                            <asp:TextBox runat="server" ID="txtUltMod" ReadOnly="True" CssClass="form-control" />
                        </div>
                    </div>
                    <div class="form-group row text-center">
                        <div class="col-sm-12">
                            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" CssClass="btn btn-primary" />
                        </div>
                    </div>
                </asp:Panel>
            </div>
        </div>
    </section>
</main>
</asp:Content>

