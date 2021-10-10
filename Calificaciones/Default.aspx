<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Calificaciones.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Calificaciones alumnos</h1>
            </br>
            <TABLE BORDER>
	        <TR>
		        <TH>Boleta</TH> <TH>Nombre</TH> <TH>Calificacion</TH>
	        </TR>
	        <TR>
		        <TD><asp:Label runat="server" ID="LB1"/></TD> 
                <TD><asp:Label runat="server" ID="LN1"/></TD> 
                <TD><asp:DropDownList runat="server" id="Cal1" /></TD>
	        </TR>
	        <TR>
		        <TD><asp:Label runat="server" ID="LB2"/></TD> 
                <TD><asp:Label runat="server" ID="LN2"/></TD> 
                <TD><asp:DropDownList runat="server" id="Cal2" /></TD>
	        </TR>
                <TR>
		        <TD><asp:Label runat="server" ID="LB3"/></TD> 
                <TD><asp:Label runat="server" ID="LN3"/></TD> 
                <TD><asp:DropDownList runat="server" id="Cal3" /></TD>
	        </TR>
                <TR>
		        <TD><asp:Label runat="server" ID="LB4"/></TD> 
                <TD><asp:Label runat="server" ID="LN4"/></TD> 
                <TD><asp:DropDownList runat="server" id="Cal4" /></TD>
	        </TR>
                <TR>
		        <TD><asp:Label runat="server" ID="LB5"/></TD> 
                <TD><asp:Label runat="server" ID="LN5"/></TD> 
                <TD><asp:DropDownList runat="server" id="Cal5" /></TD>
	        </TR>
                <TR>
		        <TD><asp:Label runat="server" ID="LB6"/></TD> 
                <TD><asp:Label runat="server" ID="LN6"/></TD> 
                <TD><asp:DropDownList runat="server" id="Cal6" /></TD>
	        </TR>
                <TR>
		        <TD><asp:Label runat="server" ID="LB7"/></TD> 
                <TD><asp:Label runat="server" ID="LN7"/></TD> 
                <TD><asp:DropDownList runat="server" id="Cal7" /></TD>
	        </TR>
                <TR>
		        <TD><asp:Label runat="server" ID="LB8"/></TD> 
                <TD><asp:Label runat="server" ID="LN8"/></TD> 
                <TD><asp:DropDownList runat="server" id="Cal8" /></TD>
	        </TR>
                <TR>
		        <TD><asp:Label runat="server" ID="LB9"/></TD> 
                <TD><asp:Label runat="server" ID="LN9"/></TD> 
                <TD><asp:DropDownList runat="server" id="Cal9" /></TD>
	        </TR>
                <TR>
		        <TD><asp:Label runat="server" ID="LB10"/></TD> 
                <TD><asp:Label runat="server" ID="LN10"/></TD> 
                <TD><asp:DropDownList runat="server" id="Cal10" /></TD>
	        </TR>
            </TABLE>	
            <asp:Button runat="server" ID="btn" Text="Enviar" OnClick="btn_Click"/>
            </br>


            <h1>Estadísticas</h1>
            </br>
            <TABLE BORDER>
	        <TR>
		        <TH>%Aprobados</TH> <TH>%Reprobados</TH> <TH>Promedio</TH> <TH>Calif. Min</TH> <TH>Calif. Max</TH>
	        </TR>
            <TR>
		        <TD><asp:Label runat="server" ID="AP"/></TD> 
                <TD><asp:Label runat="server" ID="RP"/></TD> 
                <TD><asp:Label runat="server" ID="PR"/></TD> 
                <TD><asp:Label runat="server" ID="CMN"/></TD>
                <TD><asp:Label runat="server" ID="CMX"/></TD>
	        </TR>
            </TABLE>	
        </div>
    </form>
</body>
</html>
