<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Formulario.aspx.cs" Inherits="K_nine.WebForm2" MasterPageFile="~/Master.Master" %>

<asp:Content ID="ContentPlaceHolder1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1><asp:Label ID="lbl1" runat="server" Text="Label"></asp:Label></h1>
   
   <div class="form-floating mb-3">
            <asp:Label ID="lbl2" runat="server" Width="200px"></asp:Label> <!--Correo-->
            <asp:TextBox ID="txt1" runat="server" placeholder="kevindaniel.123"></asp:TextBox>
            <asp:Label ID="lbl3" runat="server"></asp:Label> <!--@-->
            <asp:DropDownList ID="list1" runat="server"></asp:DropDownList> <!--hotmail.com-->
            <asp:Label ID="lbl4" runat="server" Width="200px"></asp:Label> <!--Teléfono-->
            <asp:TextBox ID="txt2" runat="server" placeholder="55-1234-5678" TextMode="Number"></asp:TextBox>
     </div>
  
    <div class="form-floating mb-3">
            <asp:Label ID="lbl5" runat="server" Width="200px"></asp:Label><!--Contraseña-->
            <asp:TextBox ID="txt3" runat="server" placeholder="Contraseña" TextMode="Password"></asp:TextBox>
            <asp:Label ID="txt" runat="server" style="visibility: hidden">Mi texto escondido</asp:Label> <!--espacio-->
            <asp:Label ID="lbl6" runat="server" Width="200px"></asp:Label> <!--Edad-->
            <asp:TextBox ID="txt4" runat="server" placeholder="22" TextMode="Number"></asp:TextBox>
     </div>

     <div class="form-floating mb-3">
            <asp:Label ID="lbl7" runat="server" Width="200px"></asp:Label><!--Nombre Admin-->
            <asp:TextBox ID="txt5" runat="server" placeholder="Kevin Daniel Hernández Diaz"  Style="width: 790px; height: 30px;"></asp:TextBox>   
     </div>

     <div class="form-floating mb-3">
            <asp:Label ID="lbl8" runat="server" Width="200px"></asp:Label><!--CURP-->
            <asp:TextBox ID="txt6" runat="server" placeholder="MAHJ280603MSPRRV09"  Style="width: 790px; height: 30px;"></asp:TextBox>   
     </div>
     <div class="form-floating mb-3">
            <asp:Label ID="lbl9" runat="server" Width="200px"></asp:Label><!--Nombre Sucursal-->
            <asp:TextBox ID="txt7" runat="server" placeholder="K-Nine"  Style="width: 790px; height: 30px;"></asp:TextBox>   
     </div>
     <div class="form-floating mb-3">
            <asp:Label ID="lbl10" runat="server" Width="200px"></asp:Label><!--Dirección-->
            <asp:TextBox ID="txt8" runat="server" placeholder="Balbastro 770, Buenos Aires"  Style="width: 790px; height: 30px;"></asp:TextBox>   
     </div>
    <asp:LinkButton class="btn btn-lg btn-primary" runat="server" ID="LinkButton1" OnClick="lnk_Click1">Registrar</asp:LinkButton>
</asp:Content>
