<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="AppWeb.Productos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid" style="background-color:#b08fbb;">
        <div class="container">
            <div class="row">   
            <div class="col-md-4">   </div>
            <div class="col-md-4 mt-5 title"> <h1> Productos</h1>  </div>
            <div class="col-md-4">   </div>
        </div>
        <div class="row mt-5"> 
            <%foreach (Dominio.Articulos item in lista)
                {
                        %>
                    <div class="col-md-4 mb-5">   
                        <div class="card mt-4" style="width: 18rem;">
                            <img src="<% =imageError(item.imagenURL)? noImage:item.imagenURL%>" class="card-img-top" alt="..."> 
                            <div class="card-body">
                                <h5 class="card-title" style="color:black"><% =item.Nombre %></h5>
                                <p class="card-text" style="color:gray"> <% =item.Descripcion %></p>
                            </div>
                            <ul class="list-group list-group-flush">
                                <li class="list-group-item fw-bold" style="font-size:30px; text-align:center">$<% =Math.Round(item.Precio) %></li>
                            </ul>
                            <div class="card-body">
                                <a href="detalle.aspx?id=<%=item.ID %>" class="btn btn-dark btn-detalle">Detalle</a>
                                <a href="Carrito.aspx?id=<%=item.ID %>&ban=1"  class="btn btn-primary">Agregar Carrito</a>
                            </div>
                            
                        </div>
                    </div>
                        <% 
                } %>
        </div>
        </div>
    </div>
</asp:Content>
