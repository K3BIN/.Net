<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="K_nine.WebForm1" MasterPageFile="~/Master.Master" %>
<asp:Content ID="ContentPlaceHolder1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1><asp:Label ID="lbl1" runat="server"></asp:Label></h1>
    <br>
    <div class="form-group">
        <div class="form-floating mb-3">
            <asp:Label ID="lbl2" runat="server" Width="200px"></asp:Label><!--Correo-->
            <asp:TextBox ID="txt1" runat="server" placeholder="kevindaniel.123"></asp:TextBox>
            <asp:Label ID="lbl3" runat="server"></asp:Label><!--@-->
            <asp:DropDownList ID="list1" runat="server"></asp:DropDownList><!--hotmail.com-->
        </div>
    </div>

    <div class="form-floating mb-3">
        <asp:Label ID="lbl4" runat="server" Width="250px"></asp:Label><!--Contraseña-->
        <asp:TextBox ID="txt2" runat="server" placeholder="Contraseña" TextMode="Password" Style="width: 410px; height: 30px;"></asp:TextBox>
    </div>

    <asp:LinkButton ID="LinkButton1" runat="server" class="btn btn-primary" />
    <br>
    <asp:LinkButton ID="LinkButton2" runat="server" class="btn btn-link" />
</asp:Content>

