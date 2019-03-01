<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mscontent.aspx.cs" Inherits="WebFileCommunitySystem.Mscontent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style>
        .rab {
            border:solid 1px gray;
            border-radius:5px
        }
         .rabb {
            border:solid 1px gray;
            border-radius:15px
        }

    </style>
</head>
<body>

    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div>

            <asp:UpdatePanel ID="UpdatePanel1" runat="server">

                <ContentTemplate>
                    <asp:ListBox ID="ListBox1" runat="server" CssClass="rabb" Height="480px" Width="100%" Font-Names="幼圆" Font-Size="Small" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" AutoPostBack="True" Font-Italic="True" BackColor="#333333" ForeColor="White"></asp:ListBox>
                    
              
                    <br />
                   

                    <br />

                </ContentTemplate>

                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
               
                </Triggers>
            
            </asp:UpdatePanel>
             <asp:Label ID="Label1" runat="server" Text="请输入想发送的信息->给世界："></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" Height="25px" Width="85%" CssClass="rab "></asp:TextBox>

                    <asp:Button ID="Button1" runat="server" Width="8%" OnClick="Button1_Click" CssClass="rab " Text="发送" BorderStyle="None" />
 
            <asp:Timer ID="Timer1" runat="server" OnTick="t1_trick">
            </asp:Timer>
           
        </div>
    </form>
</body>
</html>
