<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DepartmentAdd.aspx.cs" Inherits="ContosoWeb.Departments.DepartmentAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <h3>Add Department Info</h3>
    </div>

    <div class="container">
        <div class="row">
            <div class="col-lg-4">
                <div class="form-group">
                    <label for="txtDeptName">Department Name: </label>
                    <asp:TextBox ID="txtDeptName" CssClass="form-control" runat="server" />
                </div>

                <div class="form-group">
                    <label for="txtDeptBudget">Department Budget: </label>
                    <asp:TextBox ID="txtDeptBudget" CssClass="form-control" runat="server" />
                </div>

                <div class="form-group">
                    <label for="txtDeptStartDate">Department StartDate: </label>
                    <asp:TextBox ID="txtDeptStartDate" CssClass="form-control" runat="server" />
                </div>

                <%--<div class="form-group">
                    <label for="txtInstrutorId">Department InstructorId: </label>
                    <asp:TextBox ID="txtInstrutorId" CssClass="form-control" runat="server" />
                </div>--%>

                <div class="form-group">
                    <label for="ddlInstructor">Try Dropdown List Department Instructor: </label>
                    <asp:DropDownList ID="ddlInstructor" CssClass="form-control" runat="server"></asp:DropDownList>
                </div>

                <%-- Save Button --%>
                <div class="form-group">
                    <asp:Button Text="Save Department" ID="btnSaveDept" CssClass="btn btn-primary" runat="server" OnClick="btnSaveDept_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
