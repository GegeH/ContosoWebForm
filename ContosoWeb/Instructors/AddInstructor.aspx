<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddInstructor.aspx.cs" Inherits="ContosoWeb.Instructors.AddInstructor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Content/bootstrap.css" rel="stylesheet" />
    <link href="../Content/Site.css" rel="stylesheet" />
</head>
<body>

    <div class="navbar navbar-inverse navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <a class="navbar-brand" runat="server" href="~/">Contoso</a>
            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav">
                    <li><a runat="server" href="~/">Home</a></li>
                </ul>
            </div>
        </div>
    </div>

    <div class="container">
        <h3>Add Instructor Info</h3>
    </div>

    <div class="container">
        <div class="row">
            <form id="formInstructor" class="forms col-lg-4" runat="server">
                <div class="form-group">
                    <label for="txtFirstName">First Name: </label>
                    <asp:TextBox ID="txtFirstName" CssClass="form-control" runat="server" />
                    <asp:RequiredFieldValidator ErrorMessage="Frist Name cannot be empty!" Display="Dynamic" ControlToValidate="txtFirstName" runat="server" />
                </div>

                <div class="form-group">
                    <label for="txtLastName">Last Name: </label>
                    <asp:TextBox ID="txtLastName" CssClass="form-control" runat="server" />
                    <asp:RequiredFieldValidator ErrorMessage="Last Name cannot be empty!" Display="Dynamic" ControlToValidate="txtLastName" runat="server" />
                </div>

                <div class="form-group">
                    <label for="txtMiddleName">Middle Name: </label>
                    <asp:TextBox ID="txtMiddleName" CssClass="form-control" runat="server" />
                </div>

                <div class="form-group">
                    <label for="txtEmail">Email: </label>
                    <asp:TextBox ID="txtEmail" CssClass="form-control" runat="server" />
                    <asp:RegularExpressionValidator ErrorMessage="Email should be in valid format!" Display="Dynamic" ControlToValidate="txtEmail" runat="server" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
                    <asp:RequiredFieldValidator ErrorMessage="Email should not be empty!" Display="Dynamic" ControlToValidate="txtEmail" runat="server" />
                </div>

                <div class="form-group">
                    <label for="txtPhone">Phone: </label>
                    <asp:TextBox ID="txtPhone" CssClass="form-control" runat="server" />
                    <asp:RegularExpressionValidator ErrorMessage="Phone Number should be in valid format!" Display="Dynamic" ControlToValidate="txtPhone" runat="server" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}" />
                    <asp:RequiredFieldValidator ErrorMessage="Phone Number should not be empty!" Display="Dynamic" ControlToValidate="txtPhone" runat="server" />
                </div>

                <div class="form-group">
                    <label for="txtSSN">SSN: </label>
                    <asp:TextBox ID="txtSSN" CssClass="form-control" runat="server" />
                    <asp:RegularExpressionValidator ErrorMessage="SSN should be in valid format!" Display="Dynamic" ControlToValidate="txtSSN" runat="server" ValidationExpression="^\d{3}-\d{2}-\d{4}$" />
                    <asp:RequiredFieldValidator ErrorMessage="SSN should not be empty!" Display="Dynamic" ControlToValidate="txtSSN" runat="server" />
                </div>

                <div class="form-group">
                    <label for="txtAddress1">Address Line 1: </label>
                    <asp:TextBox ID="txtAddress1" CssClass="form-control" runat="server" />
                    <asp:RequiredFieldValidator ErrorMessage="Address Line should not be empty!" Display="Dynamic" ControlToValidate="txtAddress1" runat="server" />
                </div>

                <div class="form-group">
                    <label for="txtAddress2">Address Line 2: </label>
                    <asp:TextBox ID="txtAddress2" CssClass="form-control" runat="server" />
                </div>

                <div class="form-group">
                    <label for="txtUnitNumber">Unit or Apartment #: </label>
                    <asp:TextBox ID="txtUnitNumber" CssClass="form-control" runat="server" />
                </div>

                <div class="form-group">
                    <label for="txtCity">City: </label>
                    <asp:TextBox ID="txtCity" CssClass="form-control" runat="server" />
                    <asp:RequiredFieldValidator ErrorMessage="City should not be empty!" Display="Dynamic" ControlToValidate="txtCity" runat="server" />
                </div>

                <div class="form-group">
                    <label for="txtMiddleName">State: </label>
                    <asp:DropDownList ID="ddlState" CssClass="form-control" runat="server">
                    </asp:DropDownList>
                </div>

                <div class="form-group">
                    <label for="txtZipcode">Zip Code: </label>
                    <asp:TextBox ID="txtZipcode" CssClass="form-control" runat="server" />
                    <asp:RequiredFieldValidator ErrorMessage="Zip code should not be empty!" Display="Dynamic" ControlToValidate="txtZipcode" runat="server" />
                </div>


                <%-- Save Button --%>
                <div class="form-group">
                    <asp:Button Text="Save Instructor" ID="btnSaveInstructor" CssClass="btn btn-primary" runat="server" OnClick="btnSaveInstructor_Click" />
                    <asp:Button Text="Cancel" ID="btnCancelInstructor" CssClass="btn btn-default" runat="server" OnClick="btnCancelInstructor_Click" CausesValidation="false" />
                </div>

            </form>
        </div>
    </div>
</body>
</html>
