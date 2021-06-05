<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="AppWeb.Carrito" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid" style="background-color: #b08fbb;">
        <div class="container">
            <ul class="list-group">

                <% foreach (Dominio.Articulos item in listaCarrito)
                    {  
                        enviarPrecioParcial(item.Precio);
                %>
                    <li class="list-group-item d-flex justify-content-between align-items-start">                       <div class="ms-2 me-auto">                           <div class="fw-bold" style="color: black; font-size:20px;">  <img src="<% =item.imagenURL %>" style="width: 70px; height: 70px" alt="Alternate Text" />   <%=item.Nombre %>                               <span style="color: grey; font-size:15px "><%=item.Descripcion %></span>                           </div>                           <a href="Carrito.aspx?id=<%=item.ID %>&ban=3" class="btn btn-primary" style="margin-left: 75px">Eliminar</a>                            <a href="detalle.aspx?id=<%=item.ID %>" class="btn btn-dark btn-detalle">Detalle</a>                       </div>
    
                        <asp:TextBox ID="txtCantidad" style="color: grey;"  runat="server" OnTextChanged ="txtCantidad_TextChanged"  TextMode ="number"></asp:TextBox>                       <h3 style="color:gray">$<%=item.Precio %></h3>                                             </li> 
                <%  
                    }
                %>
            </ul>
            <br />  
            <ul class="list-group">
                <li class="list-group-item d-flex justify-content-between align-items-start">                       <div class="ms-2 me-auto">                           <div class="fw-bold">                                <h1 style="color: black;">Precio final</h1>                              <h1 style="color:black"> <% =PrecioFinal %></h1>                           </div>                                                  </div>                       <h1 style="color:black"> </h1>                    </li>
            </ul>

            
        </div>
    </div>

</asp:Content>
