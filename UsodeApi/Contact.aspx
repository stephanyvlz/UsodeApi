<%@ Page Title="Contact" Async="true" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="UsodeApi._Contact" %>


<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <main>
        <div class="row">
            <section class="col-md-4" aria-labelledby="Apideperritos">
                <div>
                    <h1>Pagina de prueba de uso de api de perritos</h1>
                    <asp:Image ID="IDperritosapiimg" runat="server" Height="400px" />
                    <asp:Button ID="IDperritosapibtn" runat="server" Text="Imagen aleatoria" OnClick="Perritos" />

                 </div>
            </section>
        </div>
    </main>
</asp:Content>