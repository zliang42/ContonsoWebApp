<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DeptList.aspx.cs" Inherits="ContosoWebApp.Departments.DeptList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h4> List of Departments</h4>
    <a href="AddDept.aspx">Add Department</a>

    <asp:Repeater runat="server" ID="repeaterDept" OnItemCommand="repeaterDept_ItemCommand">
                <HeaderTemplate>
            <table class="table table-bordered">
                <tr class="info alert-info">
                    <th>ID</th>
                    <th>Name</th>
                    <th>Budget</th>
                    <th>Start Date</th>
                    <th>Instructor ID</th>
                    <th>Row Version</th>
                    <th>Actions</th>
                </tr>

                </HeaderTemplate>

        <ItemTemplate> 
            <tr>

                <td>
                    <asp:Label Text='<%# Eval("Id") %>' runat="server" ID="lbId"/>
                </td>
                <td>
                    <asp:Label Text='<%# Eval("Name") %>' runat="server" ID="lbName"/>
                </td>
                <td>
                    <asp:Label Text='<%# Eval("Budget") %>' runat="server" ID="lbBudget"/>
                </td> 
                <td>
                    <asp:Label Text='<%# Eval("StartDate") %>' runat="server" ID="lbStartDate"/>
                </td> 
                <td>
                    <asp:Label Text='<%# Eval("InstructorId") %>' runat="server" ID="Label2"/>
                </td> 
                <td>
                    <asp:Label Text='<%# Eval("RowVersion") %>' runat="server" ID="Label3"/>
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
