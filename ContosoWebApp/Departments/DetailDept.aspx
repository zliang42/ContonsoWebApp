<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetailDept.aspx.cs" Inherits="ContosoWebApp.Departments.DetailDept" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <h4>Detail Department</h4>
    <hr />
     <dl class="dl-horizontal">
        <dt>Name</dt>
        <dd><asp:label text="" runat="server" ID="lbName"/> </dd>

        <dt>Budget</dt>
        <dd><asp:label text="" runat="server" ID="lbBudget"/> </dd>

         <dt>Start Date</dt>
        <dd><asp:label text="" runat="server" ID="lbStartDate"/> </dd>

        <dt>Instructor ID</dt>
        <dd><asp:label text="" runat="server" ID="lbInstructorId"/> </dd>
        
          <dt>Row Version</dt>
        <dd><asp:label text="" runat="server" ID="lbRowVersion"/> </dd>
    </dl>

</asp:Content>
