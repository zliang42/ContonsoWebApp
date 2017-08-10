<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetailPerson.aspx.cs" Inherits="ContosoWebApp.People.DetailPerson" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h4>Detail Person</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>First Name</dt>
        <dd><asp:label text="" runat="server" ID="lbFristName"/> </dd>

        <dt>Last Name</dt>
        <dd><asp:label text="" runat="server" ID="lbLastName"/> </dd>

        <dt>Age</dt>
        <dd><asp:label text="" runat="server" ID="lbAge"/> </dd>

        <dt>Email</dt>
        <dd><asp:label text="" runat="server" ID="lbEmail"/> </dd>

        <dt>Phone</dt>
        <dd><asp:label text="" runat="server" ID="lbPhone"/> </dd>

        <dt>Address Line</dt>
        <dd><asp:label text="" runat="server" ID="lbAddress1"/> </dd>

        <dt>City</dt>
        <dd><asp:label text="" runat="server" ID="lbCity"/> </dd>

        <dt>State</dt>
        <dd><asp:label text="" runat="server" ID="lbState"/> </dd>

        <dt>Zipcode</dt>
        <dd><asp:label text="" runat="server" ID="lbZipcode"/> </dd>

    </dl>
</asp:Content>
