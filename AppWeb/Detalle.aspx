<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Detalle.aspx.cs" Inherits="AppWeb.Detalle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
         <div class ="contenedor" style="background-color:#b08fbb;">
            <div class="tarjeta">
                <div class="contenedor-imagen">
                    <img class="detalle-img" src="https://www.tevelin.com.ar/pub/media/catalog/product/cache/small_image/350x350/beff4985b56e3afdbeabfc89641a4582/3/5/350883_-_portada.jpg" alt="Alternate Text" />
                </div>
                <div class="contenedor-info">
                    <h1 class="titles titulo"> Nokia Ultimate 1100</h1>
                    <h3 class="titles descripcion" >Celular de última generación</h3>
                    <br />
                    <hr />
                    <h4 class="titles"> <strong class="titles-2">Categoría: </strong>Celulares</h4>
                    <hr />
                    <h4 class="titles"> <strong class="titles-2">Marca: </strong>Nokia</h4>
                    <hr />
                    <h1 class="titles precio"> $<%= Math.Round(45000.8)%></h1>
                    <br />
                    <br />
                    <button type="button" class="btn btn-primary btn-lg">Agregar al Carrito</button>

                </div>
            </div>
        </div>  
</asp:Content>
