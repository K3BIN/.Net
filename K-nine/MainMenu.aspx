<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainMenu.aspx.cs" Inherits="K_nine.WebForm3" MasterPageFile="~/Master.Master"%>
<asp:Content ID="ContentPlaceHolder1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br><br>
    <h1><asp:Label ID="lbl1" runat="server" Text="Label"></asp:Label></h1><br>
    <h3><asp:Label ID="lbl2" runat="server" Text="Label"></asp:Label></h3><br>


    <asp:LinkButton class="btn btn-lg btn-secondary" runat="server" ID="lnkb1" OnClick="lnk_Click1" style="width:340px;height:50px;"></asp:LinkButton><br><br>
    <asp:LinkButton class="btn btn-lg btn-secondary" runat="server" ID="lnkb2" OnClick="lnk_Click2" style="width:340px;height:50px;"></asp:LinkButton><br><br>
    <asp:LinkButton class="btn btn-lg btn-secondary" runat="server" ID="lnkb3" OnClick="lnk_Click3" style="width:340px;height:50px;"></asp:LinkButton><br><br>
    <asp:LinkButton class="btn btn-lg btn-secondary" runat="server" ID="lnkb4" OnClick="lnk_Click4" style="width:340px;height:50px;"></asp:LinkButton><br><br>
</asp:Content>
