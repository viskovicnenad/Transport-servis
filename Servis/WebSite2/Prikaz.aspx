<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Prikaz.aspx.cs" Inherits="Prikaz" %>
<asp:content id="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 206px;
        }
    </style>
</head>
<body>
    <form id="form1" >
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style1">Unesi id servisa</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" Width="256px"></asp:TextBox>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Filtriraj" />
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Prikazi sve servise" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td>
                        <asp:GridView ID="GridView1" runat="server">
                        </asp:GridView>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
    </asp:Content>