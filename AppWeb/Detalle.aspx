<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Detalle.aspx.cs" Inherits="AppWeb.Detalle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
         <div class ="contenedor" style="background-color:#b08fbb;">
            <div class="tarjeta">
                <div class="contenedor-imagen">
                    <img class="detalle-img" src="<%  =imageError(detalle.imagenURL)? noImage:detalle.imagenURL %>" alt="Alternate Text" />
                </div>
                <div class="contenedor-info">
                    <h1 class="titles titulo"><% =detalle.Nombre %></h1>
                    <h3 class="titles descripcion" ><%=detalle.Descripcion %></h3>
                    <hr />
                    <h4 class="titles"> <strong class="titles-2">Categoría: </strong><%=detalle.Categoria %></h4>
                    <hr />
                    <h4 class="titles"> <strong class="titles-2">Marca: </strong><%=detalle.Marca %></h4>
                    <hr />
                    <h1 class="titles precio"> $<%= Math.Round(detalle.Precio)%></h1>
                    <br />
                    <button type="button" class="btn btn-primary btn-lg">Agregar al Carrito</button>

                </div>
            </div>
        </div>  
</asp:Content>
