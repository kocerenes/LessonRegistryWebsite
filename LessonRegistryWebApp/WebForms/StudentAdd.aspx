
<%@ Page Title="" Language="C#" MasterPageFile="~/Shared/HeaderLayout.Master" AutoEventWireup="true" CodeBehind="StudentAdd.aspx.cs" Inherits="LessonRegistryWebApp.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="Form1" runat="server">

        <div class="form-group" style="padding-left:80px; padding-right:200px;">
            <div>
                <asp:Label for="txtName" runat="server" Text="Öğrenci Adı" style="font-weight: bold;"></asp:Label>
                <asp:TextBox ID="txtName" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label for="txtSurname" runat="server" Text="Öğrenci Soyadı" style="font-weight: bold;"></asp:Label>
                <asp:TextBox ID="txtSurname" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label for="txtNumber" runat="server" Text="Numara" style="font-weight: bold;"></asp:Label>
                <asp:TextBox ID="txtNumber" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label for="txtPassword" runat="server" Text="Şifre" style="font-weight: bold;"></asp:Label>
                <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label for="txtPhoto" runat="server" Text="Fotoğraf" style="font-weight: bold;"></asp:Label>
                <asp:TextBox ID="txtPhoto" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label for="txtBalance" runat="server" Text="Bakiye" style="font-weight: bold;"></asp:Label>
                <asp:TextBox ID="txtBalance" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>

        <div  style="padding-left:80px;">
            <asp:Button ID="Button1" runat="server" Text="Kaydet" OnClick="Button1_Click"  CssClass="btn btn-success"/>
        </div>
        
    </form>
</asp:Content>

