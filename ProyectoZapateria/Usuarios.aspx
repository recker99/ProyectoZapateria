<%@ Page Title="Gestión de Usuarios" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="ProyectoZapateria.Usuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row justify-content-center">
            <div class="col-md-10">
                <div class="card p-4">
                    <h2 class="text-center mb-4">Listado de Usuarios</h2>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" AllowPaging="True" OnRowCommand="GridView1_RowCommand" DataKeyNames="usuario" CssClass="table table-striped">
                        <Columns>
                            <asp:BoundField DataField="usuario" HeaderText="Usuario" ReadOnly="True" SortExpression="usuario" />
                            <asp:BoundField DataField="contrasena" HeaderText="Contraseña" SortExpression="contrasena" />
                            <asp:BoundField DataField="nombre_usuario" HeaderText="Nombre" SortExpression="nombre_usuario" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Button ID="btnEditar" runat="server" CommandName="Editar" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" Text="Editar" CssClass="btn btn-primary" />
                                    <asp:Button ID="btnEliminar" runat="server" CommandName="Eliminar" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" Text="Eliminar" CssClass="btn btn-danger" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
