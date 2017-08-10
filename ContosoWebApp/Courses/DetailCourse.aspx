<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetailCourse.aspx.cs" Inherits="ContosoWebApp.Courses.DetailCourse" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h4>Detail Course</h4>
    <hr />
     <dl class="dl-horizontal">
        <dt>Title</dt>
        <dd><asp:label text="" runat="server" ID="lbTitle"/> </dd>

        <dt>Credits</dt>
        <dd><asp:label text="" runat="server" ID="lbCredits"/> </dd>

        <dt>Department ID</dt>
        <dd><asp:label text="" runat="server" ID="lbDeptId"/> </dd>
    </dl>



</asp:Content>
