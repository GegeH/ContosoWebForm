<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DepartmentDetails.aspx.cs" Inherits="ContosoWeb.Departments.DepartmentDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Repeater ID="rptDeptDetails" runat="server">
        <HeaderTemplate></HeaderTemplate>
        <ItemTemplate></ItemTemplate>
        <FooterTemplate></FooterTemplate>
    </asp:Repeater>

    <h1>
        <asp:Label ID="labelID" CssClass="body-content" runat="server" />
    </h1>
    <asp:Label ID="labelName" runat="server" />
    <asp:Label ID="labelBudget" runat="server" />
    <asp:Label ID="labelStartDate" runat="server" />
    <asp:Label ID="labelInstructorId" runat="server" />
    <asp:Label ID="labelRowVersion" runat="server" />
    <asp:Label ID="labelCreatedDate" runat="server" />
    <asp:Label ID="labelCreatedBy" runat="server" />
    <asp:Label ID="labelUpdatedDate" runat="server" />
    <asp:Label ID="labelUpdatedBy" runat="server" />
</asp:Content>
