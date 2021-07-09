<%@ Page Title="" Language="C#" MasterPageFile="~/Shared/HeaderLayout.Master" AutoEventWireup="true" CodeBehind="StudentList.aspx.cs" Inherits="LessonRegistryWebApp.WebForms.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <table class="table table-bordered table-hover">
        <thead>
            <tr>
                <th>Id</th>
                <th>Ad</th>
                <th>Soyad</th>
                <th>Numara</th>
                <th>Şifre</th>
                <th>Fotoğraf</th>
                <th>Bakiye</th>

            </tr>
        </thead>

        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("Id")%></td>
                        <td><%#Eval("Name")%></td>
                        <td><%#Eval("Surname")%></td>
                        <td><%#Eval("Number")%></td>
                        <td><%#Eval("Password")%></td>
                        <td><%#Eval("Photo")%></td>
                        <td><%#Eval("Balance")%></td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%#"StudentUpdate.aspx?ID="+Eval("Id")%>' ID="HyperLink1" runat="server" CssClass="btn btn-warning">Güncelle</asp:HyperLink>
                        </td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%#"StudentDelete.aspx?ID="+Eval("Id")%>' ID="HyperLink4" runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>

    </table>

</asp:Content>
