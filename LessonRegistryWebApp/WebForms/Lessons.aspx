<%@ Page Title="" Language="C#" MasterPageFile="~/Shared/HeaderLayout.Master" AutoEventWireup="true" CodeBehind="Lessons.aspx.cs" Inherits="LessonRegistryWebApp.WebForms.Lessons" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server">
        <div class="form-group" style="padding-left: 80px; padding-right: 200px;">
            <div>
                <asp:Label ID="Label1" runat="server" Text="Ders Seçiniz"></asp:Label>
                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>
            </div>
            <br />
            <div>
                <asp:Label ID="Label2" runat="server" Text="Öğrenci ID"></asp:Label>
               <%-- <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>--%>
                <asp:DropDownList ID="DropDownList2" runat="server" CssClass="form-control"></asp:DropDownList>
            </div>
            <br />
            <asp:Button Text="Ders Talep et" runat="server" CssClass="btn btn-success" OnClick="Unnamed1_Click" />
        </div>

    </form>
</asp:Content>
