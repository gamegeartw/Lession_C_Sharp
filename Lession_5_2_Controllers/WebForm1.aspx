<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Lession_5_2_Controllers.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 109px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">請輸入姓名:</td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">請選擇生日:</td>
                <td>
                    <asp:TextBox ID="txtBirthday" runat="server" Enabled="False" OnTextChanged="txtBirthday_TextChanged"></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="請按我" />
                    <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" Visible="False"></asp:Calendar>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">請輸入性別:</td>
                <td>
                    <asp:RadioButton ID="rbtnBoy" runat="server" GroupName="sex" OnCheckedChanged="rbtnBoy_CheckedChanged" Text="男生" />
                    <asp:RadioButton ID="rbtnGirl" runat="server" GroupName="sex" OnCheckedChanged="rbtnGirl_CheckedChanged" Text="女生" />
                </td>
            </tr>
        </table>
    </div>
        <asp:Button ID="btnOK" runat="server" Text="確定" />
    </form>
</body>
</html>
