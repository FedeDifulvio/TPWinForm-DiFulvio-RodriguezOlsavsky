<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="AppWeb.Carrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class="container-fluid" style="background-color:#b08fbb;">
       <%foreach (Dominio.Articulos item in listaCarrito)
            { 
                %> <h1><%=item.Nombre %></h1>
                    <a href="Carrito.aspx?id=<%=item.ID %>&ban=3" class="btn btn-primary btn-lg">eliminar</a>
                <%
            } 
          %>
    </div> 
      
</asp:Content>
