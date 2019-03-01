<%@ Page Title="WE Room-EMB/XINXIN share & Editor" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFileCommunitySystem._Default" %>

    <asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

        <div class="jumbotron">
            <h2>WE Room-<small>欢迎您的到来!</small></h2>

            <p class="lead">实现局域网发布此网页进行文件传输并实现通讯，放置作业以供参考。—吃火星的宝宝设计应用</p>
            <div style="font-size: 0.6em;">
                <asp:Label ID="Lkey" runat="server" Text="Command-Key"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" BorderStyle="None"></asp:TextBox>
                <asp:Button ID="Button2" CssClass="btn btn-primary " runat="server" Text="Go &raquo;" OnClick="Button2_Click" />
                <p>
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>

                            <asp:Label ID="Label1" runat="server" Text="放进去点东西吧 -Share 哦，你懂的！-&raquo;"></asp:Label>
                            <asp:FileUpload ID="FileUpload1" runat="server" AllowMultiple="True" CssClass="btn btn-default" ToolTip="选择上传文件" />
                        </ContentTemplate>
                        <Triggers>
                            <asp:PostBackTrigger ControlID="Button1" />
                        </Triggers>
                    </asp:UpdatePanel>
                    <br />

                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Up 上传  &raquo;" CssClass="btn btn-primary " Style="margin-bottom: 2px" />
                </p>
                <p>
                    <%=filetxt%>
                </p>

            </div>
            <%--  <p><a href="" class="btn btn-primary btn-lg">如何使用？ &raquo;</a><p>--%>
        </div>







        <div class="row">

            <%--My Word--%>


                <div class="col-md-4">
                    <asp:Panel ID="Panel2" runat="server" CssClass="panel panel-default">


                        <div class="panel-heading">
                            <h4 class="panel-title">
                                <a data-toggle="collapse" data-parent="#accordion" href="#collapseOne">My Word List<small>点击收起</small>
                        </a>
                            </h4>
                        </div>

                        <div id="collapseOne" class="panel-collapse collapse in">
                            <div class="panel-body">

                                <div class="table-responsive">
                                    <table id="tb" class="table f-sm">

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
                                        <tfoot>
                                            <td colspan="2" align="center">
                                                <a class="btn-light btn" href="./editor/Editor.aspx" style="width: 80%;">添加 +</a>
                                            </td>
                                        </tfoot>
                                    </table>
                                </div>
                            </div>
                        </div>

                    </asp:Panel>

                </div>


















                <%--My Applaycation--%>

                    <div class="col-md-4">

                        <asp:Panel ID="Panel1" runat="server" CssClass="panel panel-default">


                            <div class="panel-heading">
                                <h4 class="panel-title">
                                    <a data-toggle="collapse" data-parent="#accordion" href="#collapseTO">My Applaycation List <small>点击收起</small>
                        </a>
                                </h4>
                            </div>

                            <div id="collapseTO" class="panel-collapse collapse in">
                                <div class="panel-body">

                                    <div class="table-responsive">
                                        <table id="tb" class="table f-sm">

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
                                            <tfoot>
                                                <td colspan="2" align="center">
                                                    <a class="btn-light btn" href="./editor/Editor.aspx" style="width: 80%;">添加 +</a>
                                                </td>
                                            </tfoot>
                                        </table>
                                    </div>
                                </div>
                            </div>

                        </asp:Panel>
                    </div>


                    <%--My Note & Favors--%>


                        <div class="col-md-4">
                            <h4>My Note & Favors</h4>
                            <div class="jumbotron" style="float: left; padding: 30px 20px 30px 20px; width: 100%">
                                <table style="text-align: left; padding: 6px; border: solid 1px #d6c0dd; border-radius: 10px; width: 100%; font-size: xx-small;" summary="资料链接" frame="" rules="rows" cellspacing="0">

                                    <thead>

                                        <tr>
                                            <th>Time</th>
                                            <th>Content</th>
                                        </tr>

                                    </thead>
                                    <tbody style="font-size: xx-small; text-align: left;">
                                    </tbody>
                                    <tfoot>

                                        <tr>
                                            <td colspan="2" align="center">
                                                <a class="btn-light btn" href="./editor/Editor.aspx" style="width: 80%;">添加 +</a>

                                            </td>

                                        </tr>

                                    </tfoot>

                                </table>


                            </div>
                            <p>
                            </p>
                        </div>








        </div>
        <script>
            $(document).ready(function() {
                var s = '<%=WebFileCommunitySystem.SiteMaster.passjs%>';
                if (s == '0') {
                    $('.h').show();
                } else {
                    $('.h').hide();
                }
            });
        </script>



    </asp:Content>