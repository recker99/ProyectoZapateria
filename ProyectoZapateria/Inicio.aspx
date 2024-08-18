<%@ Page Title="Inicio" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="ProyectoZapateria.Inicio" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <main aria-labelledby="title" class="text-center">
            <h2 id="title" class="my-4">Bienvenido a nuestra Zapatería</h2>
            <asp:Label ID="lblWelcome" runat="server" CssClass="welcome-message"></asp:Label>
            <% if (User.Identity.IsAuthenticated) { %> 
                <p>Hola, <strong><%: User.Identity.Name %></strong>. ¡Bienvenido!</p>
            <% } else { %>
                <p>Por favor <strong>inicia sesión</strong> para ver tus productos.</p>
            <% } %> 
            
            <h3>Encuentra los mejores productos para tus pies.</h3>

            <h4>Resumen de Productos</h4>
            <div class="table-responsive">
                <asp:GridView ID="gvProductos" runat="server" AutoGenerateColumns="False" CssClass="table table-striped">
                    <Columns>
                        <asp:BoundField DataField="id" HeaderText="ID" />
                        <asp:BoundField DataField="nombre_producto" HeaderText="Nombre Producto" />
                        <asp:BoundField DataField="descripcion" HeaderText="Descripción" />
                        <asp:BoundField DataField="precio" HeaderText="Precio" DataFormatString="{0:C}" />
                        <asp:BoundField DataField="ultima_modificacion" HeaderText="Última Modificación" DataFormatString="{0:dd/MM/yyyy}" />
                    </Columns>
                </asp:GridView>
            </div>

            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                ConnectionString="<%$ ConnectionStrings:zapateriaConnectionString %>" 
                ProviderName="<%$ ConnectionStrings:zapateriaConnectionString.ProviderName %>" 
                SelectCommand="SELECT [id], [nombre_producto], [descripcion], [precio], [ultima_modificacion] FROM [productos]">
            </asp:SqlDataSource>

            <p class="mt-4">En nuestra zapatería, nos especializamos en ofrecer una amplia variedad de zapatos para cada ocasión. 
               Desde calzado deportivo hasta elegantes zapatos formales, aquí encontrarás lo que necesitas.</p>

            <h4>Destacados de la semana</h4>
            <p>No te pierdas nuestras ofertas especiales y productos destacados. ¡Explora nuestra colección y encuentra el par perfecto para ti!</p>

            <p>Para más información sobre nuestros productos o para contactar con nosotros, utiliza el menú de navegación.</p>
        </main>
    </div>
</asp:Content>
