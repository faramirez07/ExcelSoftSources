<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Veritas_RRD._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Veritas/RRD</h1>
        <asp:FileUpload ID="FileUpload1" runat="server"  />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Convert a New Format" class="btn btn-primary btn-lg" OnClick="Button1_Click"/>
    </div>

  
    <style type="text/css">
        .oculto {
            visibility: hidden
        }
    </style>
</asp:Content>
