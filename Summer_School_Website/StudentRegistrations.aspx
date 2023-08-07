<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="StudentRegistrations.aspx.cs" Inherits="Summer_School_Website.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="form1" runat="server">
        <div class ="form-group">
            <div>
                <strong>
                <asp:Label for="TxtName" runat="server" Text="Student Name:"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtName" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                <asp:Label for="TxtLastName" runat="server" Text="Student LastName:"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtLastName" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                <asp:Label for="TxtNumber" runat="server" Text="Student Number:"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtNumber" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                <asp:Label for="TxtPassword" runat="server" Text="Student Password:"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtPassword" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                <asp:Label for="TxtPhoto" runat="server" Text="Student Photo Link:"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtPhoto" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
        </div>
        <asp:Button ID="Button1" runat="server" Text="Sing Up" OnClick="Button1_Click" CssClass="btn btn-info" />
    </form>
</asp:Content>
