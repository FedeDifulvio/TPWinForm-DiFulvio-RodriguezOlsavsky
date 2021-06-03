<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="AppWeb.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content> 
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div class="home home-welcome">
            <div class="col-md-8 home-text">
                <h1>¡Bienvenidos a nuestra Tienda Online!</h1>
                <asp:Button ID="Button1" class="btn btn-primary boton-home" runat="server" Text="Ver Productos" OnClick="Button1_Click" />
            </div>
    </div>
    </div>
</asp:Content>
