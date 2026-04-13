<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AnaSayfa.aspx.cs" Inherits="Merve_Yesil.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div style= "background-color:white">
          <div id="carouselExampleCaptions" class="carousel slide" data-bs-ride="carousel">
  <div class="carousel-inner">
    <div class="carousel-item active">
      <img src="http://24cara.vn/wp-content/uploads/2018/05/Untitled-1-1.jpg" class="d-block w-100" alt="..."  height="300" >
      <div class="carousel-caption d-none d-md-block">
        <p></p>
      </div>
    </div>
    <div class="carousel-item">
      <img src="https://natalieruka.com/wp-content/uploads/2019/01/93ffc72d-734d-4a9c-9459-8cb2f8d9be40.png" class="d-block w-100" alt="..."  height="300" >
      <div class="carousel-caption d-none d-md-block">
        <p></p>
      </div>
    </div>
    <div class="carousel-item">
      <img src="https://avatars.mds.yandex.net/i?id=a98bd31dc97847e989d693f35dcc0ad5-4445006-images-thumbs&n=13" class="d-block w-100" alt="..."  height="300">
      <div class="carousel-caption d-none d-md-block">
        <p></p>
      </div>
        <div class="carousel-item">
      <img src="https://h-optics.com/wp-content/uploads/sites/60/2020/06/Prada-emblema-1536x864.png" class="d-block w-100" alt="..."  height="300">
      <div class="carousel-caption d-none d-md-block">
        <p></p>
      </div>
    </div>
  </div>
  <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide="prev">
    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
    <span class="visually-hidden">Back</span>
  </button>
  <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide="next">
    <span class="carousel-control-next-icon" aria-hidden="true"></span>
    <span class="visually-hidden">Next</span>
  </button>
</div>
    </div>
    <div class="container">
        <div class="row">
            <div class="col-4">
                <img class="img-circle" src= "https://cs1.livemaster.ru/storage/40/06/ca50be5343d67bb6bb072d01dfl8--materialy-dlya-tvorchestva-tvid-v-stile-chanel.jpg" alt="thumb" width="100" height="100"/>
                <h2>Clothes</h2>
                <p>new colleciton</p>
                <p><a class="btn btn-default" href="Products.aspx">Daha fazla bilgi</a></p>
            </div>
            <div class="col-4">
                <img class="img-circle" src="https://cdn.raffaello-network.com/item_images/pa0-1i171h06e-large-3.jpg" alt="thumb" width="100" height="100"/>
                <h2>Shoes</h2>
                <p>sport,daily...</p>
                <p><a class="btn btn-default" href="#">Daha fazla bilgi</a></p>
            </div>
            <div class="col-4">
                <img class="img-circle" src="http://www.leatherbagsshow.com/wp-content/uploads/2018/04/Gucci-GG-Garmont-2.0-Maxi-Bag.jpg" alt="thumb" width="100" height="100"/>
                <h2>Bag</h2>
                <p>luxury life</p>
                <p><a class="btn btn-default" href="#">Daha fazla bilgi</a></p>
            </div>
        </div>
    </div>
</asp:Content>

