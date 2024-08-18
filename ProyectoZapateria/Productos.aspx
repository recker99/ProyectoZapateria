<%@ Page Title="Productos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="ProyectoZapateria.Productos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <main class="container mt-5">
        <section class="row justify-content-between mb-4" aria-labelledby="aspnetTitle">
            <div class="col-md-12">
                <!-- Enlace para crear un nuevo producto -->
                <div class="text-right mb-3">
                    <a href="CrearProducto.aspx" class="btn btn-primary">Crear Nuevo Producto</a>
                </div>
                
                <!-- Contenido de ListarProductos -->
                <h2 id="aspnetTitle" class="text-center mb-4">Lista de Productos</h2>
                <div class="card p-4 shadow-sm">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                        OnRowEditing="GridView1_RowEditing" OnRowDeleting="GridView1_RowDeleting"
                        DataKeyNames="id" CssClass="table table-striped">
                        <Columns>
                            <asp:BoundField DataField="id" HeaderText="ID" />
                            <asp:BoundField DataField="nombre_producto" HeaderText="Nombre Producto" />
                            <asp:BoundField DataField="descripcion" HeaderText="Descripción" />
                            <asp:BoundField DataField="precio" HeaderText="Precio" />
                            <asp:BoundField DataField="ultima_modificacion" HeaderText="Ultima Modificación" />
                            <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" />
                        </Columns>
                    </asp:GridView>
                    <asp:Label ID="LblError" runat="server" CssClass="text-danger"></asp:Label>
                </div>
            </div>
        </section>
    </main>
</asp:Content>
