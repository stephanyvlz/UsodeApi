<%@ Page Title="Home Page" Async="true" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UsodeApi._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
      
        <div class="row">
            <section class="col-md-4" aria-labelledby="Apidebromasprueba">
                <h2 id="Apidebromaspruebatitulo">Uso de api para bromas aleatorias</h2>
                <asp:Label ID="Bromalb" runat="server" Text="Usa el botón para obtener una broma nuevaaa."></asp:Label>
                <br />
                <asp:Button ID="BtnBroma" runat="server" Text="Broma" OnClick="BotonBrom" />
            </section>
        </div>
    </main>

</asp:Content>