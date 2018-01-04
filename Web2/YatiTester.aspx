<!--
    //---------------------------------------------------------------------------------------------
    // <copyright file="YatiTester.aspx" company="Chandam-ఛందం">
    //    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
    //    Original Author : Dileep Miriyala (m.dileep@gmail.com)
    //    Last Updated    : 03-Feb-2018 21:52EST
    //    Revisions:
    //       Version    | Author                   | Email                     | Remarks
    //       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
    //       _._        | <TODO>                   |   <TODO>                  | <TODO>
    // </copyright>
    //---------------------------------------------------------------------------------------------
    -->

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="YatiTester.aspx.cs" Inherits="Yati" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Yati Tester</title>
    <style type="text/css">
        b.gName {
            color: Red;
            font-weight: bold;
        }

        input {
            font-size: 24px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <th>Group1
                </th>
                <th>Group2
                </th>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="YCheck" runat="server" OnClick="YCheck_Click" Text="Yati Check" />
                </td>
                <td>
                    <asp:Button ID="PCheck" runat="server" OnClick="PCheck_Click" Text="Prasa Check" />
                </td>
            </tr>
        </table>
        <br />
        <div id="result" runat="server" style="clear: both; padding-top: 40px; overflow: auto;">
        </div>
    </form>
</body>
</html>
