<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="AppWeb.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content> 
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"> 
    <div class="home">
        <div class="home-carrousel">
        <div id="carouselExampleIndicators" class="carousel slide" data-bs-ride="carousel">
  <div class="carousel-indicators">
    <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="0" class="active" aria-current="true" aria-label="Slide 1"></button>
    <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="1" aria-label="Slide 2"></button>
    <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="2" aria-label="Slide 3"></button>
  </div>
  <div class="carousel-inner">
    <div class="carousel-item active">
      <img src="https://imagenes.compufull.com/thumb/im_0_0_0_700x700_11712_1/SMART_TV_LED_ENOVA_50_PULG_LED_4K_UHD_NETFLIX20210429104420.jpg" class="d-block w-100" alt="...">
    </div>
    <div class="carousel-item">
      <img src="https://gonnabuy.com.ar/site/wp-content/uploads/2021/04/TELEVISOR-NOBLEX-55-PULGADAS-DJ55X6500-A.jpg " class="d-block w-100" alt="...">
    </div>
    <div class="carousel-item">
      <img src="https://imagenes.compufull.com/thumb/im_0_0_0_700x700_10975_1/SMART_TV_LED_32_PULG_HORION_LED_HD_NETFLIX20200729112616.jpeg" class="d-block w-100" alt="...">
    </div>
  </div>
  <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide="prev">
    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
    <span class="visually-hidden">Previous</span>
  </button>
  <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide="next">
    <span class="carousel-control-next-icon" aria-hidden="true"></span>
    <span class="visually-hidden">Next</span>
  </button>
</div>
    </div>
    </div>
   
</asp:Content>
