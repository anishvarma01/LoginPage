<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="LoginPage.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 26px;
        }
        .auto-style3 {
            width: 448px;
        }
        .auto-style4 {
            height: 26px;
            width: 448px;
            text-align: right;
        }
        .auto-style5 {
            width: 448px;
            text-align: right;
        }
        .auto-style6 {
            height: 26px;
            width: 278px;
        }
        .auto-style7 {
            width: 278px;
        }
        .auto-style8 {
            width: 144px;
        }
        .RP { }
        .auto-style9 {
            width: 448px;
            height: 38px;
        }
        .auto-style10 {
            width: 278px;
            height: 38px;
        }
        .auto-style11 {
            height: 38px;
        }
    </style>
    <script src="Scripts/jquery.validate.unobtrusive.min.js">

    </script>
   

   
</head>
<body>
    
    <form id="form1" runat="server">
        <div>
    
            <table class="auto-style1">
           <tr>
               <td></td>
               <td>REGISTRATION PAGE</td>
               <td></td>               
           </tr>
                
                
                 <tr>
                <td class="auto-style4">UserName</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtUserName" runat="server" Width="283px"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUserName" ErrorMessage="Enter UserName" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Email</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtEmail" runat="server" Width="280px"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtEmail" ErrorMessage="Enter Your Email" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;<br />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="Enter Correct Email" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Password</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtPwd" runat="server" Width="283px" OnTextChanged="TextBoxPW_TextChanged" TextMode="Password"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtPwd" ErrorMessage="Enter Password" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Confirm Password</td>
                <td class="auto-style7">
                    <asp:TextBox ID="TextBoxCPW" runat="server" Width="285px" TextMode="Password"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBoxCPW" ErrorMessage="Enter Confirm Password" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;<br />
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPwd" ControlToValidate="TextBoxCPW" ErrorMessage="Enter Similar PassWord" ForeColor="Red"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Country</td>
                <td class="auto-style7">
                    <asp:DropDownList ID="ddlCountryName" runat="server" Width="293px">
                        <asp:ListItem>Select Country</asp:ListItem>
                        <asp:ListItem>India</asp:ListItem>
                        <asp:ListItem>United States</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="ddlCountryName" ErrorMessage="Select your Country" ForeColor="Red" InitialValue="Select Country"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style9"></td>
                <td class="auto-style10">
                    <asp:Button ID="btnRegister" runat="server" Text="REGISTER" OnClick="Button1_Click" />
&nbsp;
                    <input id="Reset1" class="auto-style8" type="reset" value="RESET" /></td>
                <td class="auto-style11">
                    <br />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
