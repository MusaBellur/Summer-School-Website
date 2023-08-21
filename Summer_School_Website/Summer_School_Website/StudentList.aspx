<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="StudentList.aspx.cs" Inherits="Summer_School_Website.StudentList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered table-hover">
        <tr>
            <th>Student ID</th>
            <th>Student Name</th>
            <th>Student LastName</th>
            <th>Student Number</th>
            <th>Student Password</th>
            <th>Student Photo</th>
            <th>Student Balance</th>
            <th>Operations</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("StuId")%></td>
                        <td><%# Eval("StuName")%></td>
                        <td><%# Eval("Lastname")%></td>
                        <td><%# Eval("Number")%></td>
                        <td><%# Eval("Password")%></td>
                        <td><%# Eval("Photo")%></td>
                        <td><%# Eval("Balance")%></td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%# "~/StudentDelete.aspx?StuID=" + Eval("StuId") %>' ID="HyperLink1" CssClass ="btn btn-danger" runat="server">Delete</asp:HyperLink>
                            <asp:HyperLink NavigateUrl='<%# "~/StudentUpdate.aspx?StuID=" + Eval("StuId") %>' ID="HyperLink2" CssClass ="btn btn-success" runat="server">UpDate</asp:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
