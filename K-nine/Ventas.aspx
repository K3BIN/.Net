<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ventas.aspx.cs" Inherits="K_nine.WebForm4" MasterPageFile="~/Master.Master"%>
<asp:Content ID="ContentPlaceHolder1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class="form-floating mb-3">
             <h1>
             <asp:LinkButton class="btn btn-secondary btn-sm" runat="server" ID="lnkb1" OnClick="lnk_Click1"></asp:LinkButton>
             <asp:Label ID="lbl1" runat="server" Width="1500px"></asp:Label>
             &nbsp;</h1>
    </div> 
    <div class="form-floating mb-3">
             <asp:Label ID="lbl2" runat="server"></asp:Label>
             <asp:DropDownList ID="list1" runat="server"></asp:DropDownList> <!--producto-->
             <asp:Label ID="txt" runat="server" style="visibility: hidden">Espacio</asp:Label> <!--espacio-->
             <asp:Label ID="lbl3" runat="server"></asp:Label>
             <asp:TextBox ID="txt1" runat="server" TextMode="Number"></asp:TextBox>  
             <asp:Label ID="Label1" runat="server" style="visibility: hidden"></asp:Label> <!--espacio-->
             <asp:LinkButton class="boton" runat="server" ID="lnkb2" OnClick="lnk_Click2"></asp:LinkButton> <!--Agregar-->
    </div> 

    <div class="gridview">
         <asp:Label ID="Label2" runat="server" style="visibility: hidden"></asp:Label> <!--espacio-->
             <asp:GridView ID="GridView1" HeaderStyle-BackColor="#3AC0F2" HeaderStyle-ForeColor="White" runat="server" AutoGenerateColumns="False" HorizontalAlign="Right" >
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" ItemStyle-Width="30">
<ItemStyle Width="30px"></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="Product" HeaderText="Producto" ItemStyle-Width="350">
<ItemStyle Width="350px"></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="Amount" HeaderText="Cantidad" ItemStyle-Width="30">
<ItemStyle Width="30px"></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="Brand" HeaderText="Marca" ItemStyle-Width="100">
<ItemStyle Width="100px"></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="Price" HeaderText="Precio" ItemStyle-Width="30">
<ItemStyle Width="30px"></ItemStyle>
                    </asp:BoundField>
                    <asp:ButtonField HeaderText="Quitar" Text="-" ButtonType="Button" CommandName="BR"/>

                </Columns>

<HeaderStyle BackColor="#3AC0F2" ForeColor="White"></HeaderStyle>
             </asp:GridView>  
   </div>
    <br><br><br><br><br><br><br><br><br><br><br><br>


<script type = "text/javascript">
    function Confirm() {
        var confirm_value = document.createElement("INPUT");
        confirm_value.type = "hidden";
        confirm_value.name = "confirm_value";
        if (confirm("Total a cobrar: $xxx \n Confirmar commpra")) {
            confirm_value.value = "Yes";
        } else {
            confirm_value.value = "No";
        }
        document.forms[0].appendChild(confirm_value);
    }
</script>

     <asp:LinkButton class="btn btn-dark" runat="server" ID="lnkb3" OnClientClick = "Confirm()"></asp:LinkButton> <!--Cobrar-->


</asp:Content>



