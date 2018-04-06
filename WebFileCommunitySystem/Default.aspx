<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFileCommunitySystem._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>WE Room-<small>欢迎您的到来!</small></h1>
        <p class="lead">实现局域网发布此网页进行文件传输并实现通讯，放置作业以供参考。—吃火星的宝宝设计应用</p>
        <div style="font-size: 0.6em;">
            <p>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>

                        <asp:Label ID="Label1" runat="server" Text="放进去点东西吧 -Share 哦，你懂的！-&raquo;"></asp:Label>
                        <asp:FileUpload ID="FileUpload1" runat="server" AllowMultiple="True" CssClass="btn btn-default" ToolTip="选择上传文件" />
                    </ContentTemplate>
                    <Triggers>
                        <asp:PostBackTrigger ControlID="Button1"  />
                   
                    </Triggers>

                </asp:UpdatePanel>
                <br />

                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Up 上传  &raquo;" CssClass="btn btn-primary " Style="margin-bottom: 2px" />
            </p>
            <p>
                <%=filetxt %>
            </p>


        </div>
        <%--  <p><a href="" class="btn btn-primary btn-lg">如何使用？ &raquo;</a><p>--%>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>My Applaycation</h2>
            <div class="jumbotron">

                <p>1 content</p>
                <table style="text-align: center" width="100%" border="1" align="center" summary="资料链接" frame="above" rules="rows" cellspacing="0">
                    <thead>
                        <tr>
                            <th colspan="2">目录</th>

                        </tr>
                        <tr>
                            <th>Time</th>
                            <th>Content</th>
                        </tr>

                    </thead>
                    <tbody align="center">

                        <tr>

                            <td>H5</td>
                            <td>H5</td>

                        </tr>
                        <tr>

                            <td>H5</td>
                            <td>H5</td>

                        </tr>
                        <tr>

                            <td>H5</td>
                            <td>H5</td>

                        </tr>
                        <tr>

                            <td>H5</td>
                            <td>H5</td>

                        </tr>


                    </tbody>
                    <tfoot>

                        <tr>
                            <td colspan="2" align="right"></td>

                        </tr>

                    </tfoot>

                </table>
                <a class="btn btn-default" href="">Add more +</a>

            </div>
            <p>
                <a class="btn btn-default" href="">Get more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>My Word</h2>
            <div class="jumbotron">

                <p>1 content</p>
                <table width="100%" border="1" align="center" summary="资料链接" frame="above" rules="rows" cellspacing="0">
                    <thead>
                        <tr>
                            <th colspan="2">目录</th>

                        </tr>
                        <tr>
                            <th>Time</th>
                            <th>Content</th>
                        </tr>

                    </thead>
                    <tbody align="center">

                        <tr>

                            <td>H5</td>
                            <td>H5</td>

                        </tr>
                        <tr>

                            <td>H5</td>
                            <td>H5</td>

                        </tr>
                        <tr>

                            <td>H5</td>
                            <td>H5</td>

                        </tr>
                        <tr>

                            <td>H5</td>
                            <td>H5</td>

                        </tr>


                    </tbody>
                    <tfoot>

                        <tr>
                            <td colspan="2" align="right"></td>

                        </tr>

                    </tfoot>

                </table>
                <a class="btn btn-default" href="">Add more +</a>

            </div>
            <p>
                <a class="btn btn-default" href="">Get  more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>My Note & Favors </h2>
            <div class="jumbotron">

                <p>1 content</p>

                <table width="100%" border="1" align="center" summary="资料链接" frame="above" rules="rows" cellspacing="0">
                    <thead>
                        <tr>
                            <th colspan="2">目录</th>

                        </tr>
                        <tr>
                            <th>Time</th>
                            <th>Content</th>
                        </tr>

                    </thead>
                    <tbody align="center">

                        <tr>

                            <td>H5</td>
                            <td>H5</td>

                        </tr>
                        <tr>

                            <td>H5</td>
                            <td>H5</td>

                        </tr>
                        <tr>

                            <td>H5</td>
                            <td>H5</td>

                        </tr>
                        <tr>

                            <td>H5</td>
                            <td>H5</td>

                        </tr>


                    </tbody>
                    <tfoot>

                        <tr>
                            <td colspan="2" align="right"></td>

                        </tr>

                    </tfoot>

                </table>



                <a class="btn btn-default" href="">Add more +</a>

            </div>

            <p>
                <a class="btn btn-default" href="">Scan more &raquo;</a>
            </p>
        </div>

    </div>

</asp:Content>
