<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddPerson.aspx.cs" Inherits="ContosoWebApp.People.AddPerson" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h4>Add a New Person</h4><hr />

     <div class="form-group">
    <label for="textFirstName">First Name</label>
    <%--<input type="email" class="form-control" id="exampleInputEmail1" placeholder="Email">--%>
         <asp:TextBox runat="server" MaxLength="50" ID="txtFirstName" CssClass="form-control"/> 
         <asp:RequiredFieldValidator ID="reqFirstName" ErrorMessage="Please enter your first name!" ControlToValidate="txtFirstName" runat="server" CssClass="text-danger"/>
  </div>

    <div class="form-group">
    <label for="textLastName">Last Name</label>
         <asp:TextBox runat="server" MaxLength="50" ID="txtLastName" CssClass="form-control"/> 
        <asp:RequiredFieldValidator ID="reqLastName" ErrorMessage="Please enter your last name!" ControlToValidate="txtLastName" runat="server" CssClass="text-danger"/>
  </div>

    <div class="form-group">
    <label for="textMiddleName">Middle Name</label>
         <asp:TextBox runat="server" ID="txtMiddleName" CssClass="form-control"/> 
  </div>

        <div class="form-group">
    <label for="textAge">Age</label>
         <asp:TextBox runat="server" ID="txtAge" CssClass="form-control"/> 
  </div>

    <div class="form-group">
    <label for="textEmail">Email</label>
         <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control"/> 
        <asp:RequiredFieldValidator ID="reqEmail" ErrorMessage="Please enter your Email Address!" ControlToValidate="txtEmail" runat="server" CssClass="text-danger" />
        <asp:RegularExpressionValidator ID="regularEmail" ErrorMessage="Please enter an valid format Email Address!" ControlToValidate="txtEmail" runat="server" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" CssClass="text-danger" />
  </div>

        <div class="form-group">
    <label for="textPhone">Phone</label>
         <asp:TextBox runat="server" ID="TxtPhone" CssClass="form-control"/> 
  </div>

        <div class="form-group">
    <label for="textAddress">Address Line 1</label>
         <asp:TextBox runat="server" ID="txtAddress1" CssClass="form-control"/> 
  </div>

            <div class="form-group">
    <label for="textAddress">Address Line 2</label>
         <asp:TextBox runat="server" ID="txtAddress2" CssClass="form-control"/> 
  </div>

        <div class="form-group">
    <label for="textEmail">Unit Or Apartment Number</label>
         <asp:TextBox runat="server" ID="txtUnit" CssClass="form-control"/> 
  </div>

            <div class="form-group">
    <label for="textCity">City</label>
         <asp:TextBox runat="server" ID="txtCity" CssClass="form-control"/> 
  </div>

        <div class="form-group">
    <label for="">State</label>
            <asp:DropDownList runat="server" ID="ddlStates" CssClass="form-control">
               
            </asp:DropDownList>
  </div>

            <div class="form-group">
    <label for="textZipcode">Zipcode</label>
         <asp:TextBox runat="server" ID="txtZipcode" CssClass="form-control"/> 
  </div>


    <asp:Button Text="Save Person" runat="server" ID="btnSave" OnClick="btnSave_Click" CssClass="btn btn-primary"/>

    <asp:Button Text="Cancel Person" runat="server" ID="btnCancel" CausesValidation="false" CssClass="btn btn-danger" />
</asp:Content>
