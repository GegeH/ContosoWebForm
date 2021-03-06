﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DepartmentEdit.aspx.cs" Inherits="ContosoWeb.Departments.DepartmentEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-lg-4">
                <div class="form-group">
                    <label for="txtDeptName">Department Name: </label>
                    <asp:TextBox ID="txtDeptName" CssClass="form-control" runat="server" />
                    <asp:RequiredFieldValidator ErrorMessage="Department Name cannot be empty!" ControlToValidate="txtDeptName" runat="server" />
                </div>

                <div class="form-group">
                    <label for="txtDeptBudget">Department Budget: </label>
                    <asp:TextBox ID="txtDeptBudget" CssClass="form-control" runat="server" />
                    <asp:RequiredFieldValidator ErrorMessage="Department Budget cannot be empty!" ControlToValidate="txtDeptBudget" runat="server" />
                </div>

                <div class="form-group">
                    <label for="txtDeptStartDate">Department StartDate: </label>
                    <asp:TextBox ID="txtDeptStartDate" CssClass="form-control" runat="server" />
                    <asp:RequiredFieldValidator ErrorMessage="The Starting Date of Department cannot be empty!" ControlToValidate="txtDeptStartDate" runat="server" />
                </div>

                <%--<div class="form-group">
                    <label for="txtInstrutorId">Department InstructorId: </label>
                    <asp:TextBox ID="txtInstrutorId" CssClass="form-control" runat="server" />
                    <asp:RequiredFieldValidator ErrorMessage="Instructor cannot be empty!" ControlToValidate="txtInstrutorId" runat="server" />
                </div>--%>

                <div class="form-group">
                    <label for="ddlInstructor">Department Instructor: </label>
                    <asp:DropDownList ID="ddlInstructor" CssClass="form-control" runat="server"></asp:DropDownList>
                    <asp:RequiredFieldValidator ErrorMessage="Instructor cannot be empty!" ControlToValidate="ddlInstructor" runat="server" />
                </div>

                <div class="form-group">
                    <label for="txtRowVer">Row Version: </label>
                    <asp:TextBox ID="txtRowVer" CssClass="form-control" runat="server" />
                    <asp:RequiredFieldValidator ErrorMessage="The Row Version cannot be empty!" ControlToValidate="txtRowVer" runat="server" />
                </div>

                <div class="form-group">
                    <label for="txtCreatedDate">Created Date: </label>
                    <asp:TextBox ID="txtCreatedDate" CssClass="form-control" runat="server" />
                </div>

                <div class="form-group">
                    <label for="txtCreatedBy">Created By: </label>
                    <asp:TextBox ID="txtCreatedBy" CssClass="form-control" runat="server" />
                </div>

                <div class="form-group">
                    <label for="txtUpdatedDate">Updated Date: </label>
                    <asp:TextBox ID="txtUpdatedDate" CssClass="form-control" runat="server" />
                </div>

                <div class="form-group">
                    <label for="txtUpdatedBy">Updated By: </label>
                    <asp:TextBox ID="txtUpdatedBy" CssClass="form-control" runat="server" />
                </div>

                <%-- Save Button --%>
                <div class="form-group">
                    <asp:Button Text="Save Department" ID="btnSaveDept" CssClass="btn btn-primary" runat="server" OnClick="btnSaveDept_Click" />
                    <asp:Button Text="Cancel" ID="btnCancelDeptEdit" CssClass="btn btn-default"  runat="server" OnClick="btnCancelDeptEdit_Click"/>
                </div>
            </div>
        </div>

    </div>
</asp:Content>
