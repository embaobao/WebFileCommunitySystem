<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Editor.aspx.cs" Inherits="WebFileCommunitySystem.Editor" %>

<%@ Register Assembly="FreeTextBox" Namespace="FreeTextBoxControls" TagPrefix="FTB" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

   



    <asp:Panel ID="Panel1" runat="server">
        <div id="Div1" runat="server" style="margin: 6px; padding: 4px;">
            <asp:Label ID="Label1" runat="server" Text="文本标题"></asp:Label>
            &nbsp;&nbsp; ：
    <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged">Test</asp:TextBox>
            &nbsp;保存模式:
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Style="height: 22px">

                <asp:ListItem Text="副本模式(新建)" Value="0"></asp:ListItem>
                <asp:ListItem Text="修改模式(覆盖)" Value="1"></asp:ListItem>
            </asp:DropDownList>
            <div style="float: right">
                 <a class="btn btn-default jquery-word-export" href="javascript:void(0)">
                    <span class="word-icon">W</span> 导出为.doc文档
                </a>
                <asp:Button ID="Button3" runat="server" CssClass="btn-sm btn-primary" Text=" ↕" BorderStyle="Solid" OnClick="Button3_Click" />
                <asp:Button ID="Button2" runat="server" CssClass="btn-sm btn-primary" Text="☒" BorderStyle="Solid" OnClick="Button2_Click" />
                <asp:Button ID="Button1" runat="server" Height="25px" OnClick="Button1_Click" CssClass="btn-primary radiobt" Text="Save" Width="105px" BorderStyle="Solid" />

            </div>

        </div>




        <FTB:FreeTextBox ID="FreeTextBox1" runat="server" ButtonSet="OfficeMac" GutterBackColor="Azure" Width="100%" Height="540px" AllowHtmlMode="True" Text="可复制网页哦！步骤如下 #1  选择要复制的页面   Ctrl +A  #2  Ctrl +C  -&gt;选中编辑器 #3Ctrl +V ！浏览试试吧！" Focus="True"></FTB:FreeTextBox>
        <%--  <button type="button" class="btn btn-primary" data-toggle="collapse" 
		data-target="#demo">
	简单的可折叠组件
</button>

<div id="demo" class="collapse in">
	Nihil anim keffiyeh helvetica, craft beer labore wes anderson 

</div>--%>


        <asp:Panel ID="Panel2" runat="server" CssClass="panel panel-default">
           

               <div class="panel-heading">
                <h4 class="panel-title">
                    <a data-toggle="collapse" data-parent="#accordion"
                        href="#collapseOne"> 文档列表 PageList<small>点击收起</small>
                    </a>
                </h4>
            </div>

            <div id="collapseOne" class="panel-collapse collapse in">
                <div class="panel-body">

                    <div class="table-responsive" >
                        <table id="tb" class="table">

                            <thead>
                                <tr>
                                    <th>最近修改</th>
                                    <th>编辑</th>
                                    <th>操作</th>

                                </tr>
                            </thead>
                            <tbody>
                                <%=pageDir()%>
                                
                            </tbody>
                        </table>
                    </div>
                </div>
                </div>

        </asp:Panel>




          <asp:Panel ID="Panel3" runat="server" CssClass="panel panel-default">
           

               <div class="panel-heading">
                <h4 class="panel-title">
                    <a data-toggle="collapse" data-parent="#accordion"
                        href="#collapseTwo"> 文件列表 FileList<small>点击收起</small>
                    </a>
                </h4>
            </div>

            <div id="collapseTwo" class="panel-collapse collapse in">
                <div class="panel-body">

                    <div class="table-responsive" >
                        <table id="tb" class="table">

                            <thead>
                                <tr>
                                   <th>上传时间</th>
                                    <th>下载/查看</th>
                                    <th>操作</th>

                                </tr>
                            </thead>
                            <tbody>
                               
                                 <%=filedir()%>
                            </tbody>
                        </table>
                    </div>
                </div>
                </div>

        </asp:Panel>





        
         
         
        
    </asp:Panel>







    <br />

     <script>
        $(document).ready(function () {
            var s = '<%=WebFileCommunitySystem.SiteMaster.passjs%>';
            if (s== '0')
            {
                   $('.h').show();
            }
            else {
              $('.h').hide();
            }
        });
    </script>

        <script src="https://cdn.bootcss.com/jquery/2.1.1/jquery.min.js"></script>
    <script>
        window.jQuery || document.write('<script src="../js/jquery-2.1.1.min.js"><\/script>') 
    </script>
    <script type="text/javascript" src="../js/FileSaver.js"></script>
    <script src="../js/jquery.wordexport.js"></script>

    <script type="text/javascript">
          //#MainContent_FreeTextBox1_designEditor
        jQuery(document).ready(function($) {
            $("a.jquery-word-export").click(function(event) {
               // iframe.$("#MainContent_FreeTextBox1_designEditor").wordExport();$("#MainContent_FreeTextBox1_designEditor", parent.document.body).contents().text()
              //  $("#MainContent_FreeTextBox1_designEditor").contents().find("body").html()
                $("#MainContent_FreeTextBox1_designEditor").contents().find("body").wordExport();
               // alert();
                console.log("Emb editor  欢迎您的使用！@author吃火星的宝宝");//.wordExport();
            });
        });
    </script>
</asp:Content>
