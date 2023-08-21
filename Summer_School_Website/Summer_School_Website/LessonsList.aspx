<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="LessonsList.aspx.cs" Inherits="Summer_School_Website.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Select Course "></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>
            <br />

            <asp:Label ID="Label2" runat="server" Text="Select Student ID "></asp:Label>
            <asp:DropDownList ID="DropDownList2" runat="server" CssClass="form-control"></asp:DropDownList>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Create Lesson Request" CssClass="btn btn-warning" OnClick="Button1_Click"/>
        </div>
        <br />
    </form>

    
</asp:Content>
