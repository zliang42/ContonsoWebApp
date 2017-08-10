<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditCourse.aspx.cs" Inherits="ContosoWebApp.Courses.EditCourse" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <div class="form-group">
        <label for="textTitle">Title</label>
        <asp:TextBox runat="server" ID="txtTitle" CssClass="form-control"/> 
    </div>

    <div class="form-group">
        <label for="textCredits">Credits</label>
        <asp:TextBox runat="server" ID="txtCredits" CssClass="form-control"/> 
    </div>

    <div class="form-group">
        <label for="textDeptId">Department Id</label>
        <asp:TextBox runat="server" ID="TxtDeptId" CssClass="form-control"/> 
    </div>

    <asp:Button Text="Update Course" runat="server" ID="btnUpdate" OnClick="btnUpdate_Click" CssClass="btn btn-primary"/>
</asp:Content>
