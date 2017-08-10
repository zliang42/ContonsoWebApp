<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddDept.aspx.cs" Inherits="ContosoWebApp.Departments.AddDept" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <div class="form-group">
        <label for="textName">Name</label>
        <asp:TextBox runat="server" ID="txtName" CssClass="form-control"/> 
    </div>

    <div class="form-group">
        <label for="textName">Budget</label>
        <asp:TextBox runat="server" ID="TxtBudget" CssClass="form-control"/> 
    </div>

        <div class="form-group">
        <label for="textName">Start Date</label>
        <asp:TextBox runat="server" ID="TxtStartDate" CssClass="form-control"/> 
    </div>

        <div class="form-group">
        <label for="textName">Instructor Id</label>
        <asp:TextBox runat="server" ID="TxtInstructorId" CssClass="form-control"/> 
    </div>

            <div class="form-group">
        <label for="textName">Row Version</label>
        <asp:TextBox runat="server" ID="TxtRowVersion" CssClass="form-control"/> 
    </div>

     <asp:Button Text="Save Department" runat="server" ID="btnSave" OnClick="btnSave_Click" CssClass="btn btn-primary"/>
</asp:Content>