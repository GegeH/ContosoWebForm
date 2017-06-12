<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DepartmentList.aspx.cs" Inherits="ContosoWeb.Departments.DepartmentList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Repeater ID="rptDepartmentList" runat="server" OnItemCommand="rptDepartmentList_ItemCommand">
        <HeaderTemplate>
            <table class="table table-bordered">
                <tr>
                    <th>ID</th>
                    <th>Name</th>
                    <th>Budget</th>
                    <th>Start Date</th>
                    <th>Details</th>
                </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td><asp:Label ID="lableID" Text='<%# Eval("Id")%>' runat="server" /></td>
                <td><asp:Label ID="labelName" Text='<%# Eval("Name")%>' runat="server" /></td>
                <td><asp:Label ID="labelBudget" Text='<%# Eval("Budget")%>' runat="server" /></td>
                <td><asp:Label ID="labelStartDate" Text='<%# Eval("StartDate")%>' runat="server" /></td>
                <td><asp:LinkButton ID="btnDetails" Text="Detail" runat="server" CommandName="Details" CommandArgument='<%# Eval("Id")%>' /></td>
                <td><asp:LinkButton ID="btnEdit" Text="Edit" runat="server" CommandName="Edit" CommandArgument='<%# Eval("Id")%>' /></td>
            </tr>
        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>
