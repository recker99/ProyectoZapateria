<%@ Page Title="Lista de Productos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListarProductos.aspx.cs" Inherits="ProyectoZapateria.ListarProductos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">  
    <main class="container mt-5">  
        <section class="row justify-content-center mb-4" aria-labelledby="aspnetTitle">  
            <div class="col-md-12">  
                <h2 id="aspnetTitle" class="text-center mb-4">Lista de Productos</h2>  
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowEditing="GridView1_RowEditing" OnRowDeleting="GridView1_RowDeleting" DataKeyNames="id" CssClass="table table-striped">  
                    <Columns>  
                        <asp:BoundField DataField="nombre_producto" HeaderText="Nombre Producto" />  
                        <asp:BoundField DataField="descripcion" HeaderText="Descripción" />  
                        <asp:BoundField DataField="precio" HeaderText="Precio" />  
                        <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" />  
                    </Columns>  
                </asp:GridView>  
            </div>  
        </section>  
    </main>  
</asp:Content>
