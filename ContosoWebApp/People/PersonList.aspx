<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PersonList.aspx.cs" Inherits="ContosoWebApp.People.PersonList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h4> List of People</h4><hr />
    <a href="AddPerson.aspx">Add Person</a>

    <asp:Repeater runat="server" ID="repeaterPeople" OnItemCommand="repeaterPeople_ItemCommand" >
        <HeaderTemplate>
            <table class="table table-bordered">
                <tr class="info alert-info">
                    <th>ID</th>
                    <th>First Name</th>
                    <th>Last Name</th>
                    <th>Age</th>
                    <th>Email</th>
                    <th>Phone</th>
                    <th>Actions</th>
                </tr>
            
        </HeaderTemplate>

        <ItemTemplate>  
            <tr>
                <td>
                    <asp:Label Text='<%# Eval("Id") %>' runat="server" ID="lbId"/> <%--Id is matching with the model people properties--%>
                </td>
                <td>
                    <asp:Label Text='<%# Eval("FirstName") %>' runat="server" ID="lbFirstName"/>
                </td>
                <td>
                    <asp:Label Text='<%# Eval("LastName") %>' runat="server" ID="lbLastName"/>
                </td>
                <td>
                    <asp:Label Text='<%# Eval("Age") %>' runat="server" ID="lbAge"/>
                </td>
                <td>
                    <asp:Label Text='<%# Eval("Email") %>' runat="server" ID="lbEmail"/>
                </td>
                <td>
                    <asp:Label Text='<%# Eval("Phone") %>' runat="server" ID="lbPhone"/>
                </td>
                <td>
                    <asp:Button Text="Edit" runat="server" ID="btnEdit" CssClass="btn btn-primary" CommandName="Edit" CommandArgument='<%# Eval("Id") %>'/>
                    <asp:Button Text="Delete" runat="server" ID="btnDelete" CssClass="btn btn-danger" CommandName="Delete" CommandArgument='<%# Eval("Id") %>'/>
                    <asp:Button Text="Details" runat="server" ID="btnDetails" CssClass="btn btn-success" CommandName="Details" CommandArgument='<%# Eval("Id") %>'/>
                </td>
            </tr>
        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>
