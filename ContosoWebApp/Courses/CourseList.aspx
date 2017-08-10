<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CourseList.aspx.cs" Inherits="ContosoWebApp.Courses.CourseList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h4> List of Courses</h4><hr />
    <a href="AddCourse.aspx">Add Course</a>

    <asp:Repeater runat="server" ID="repeaterCourse" OnItemCommand="repeaterCourse_ItemCommand" >
        <HeaderTemplate>
            <table class="table table-bordered">
                <tr class="info alert-info">
                    <th>ID</th>
                    <th>Title</th>
                    <th>Credits</th>
                    <th>Department ID</th>
                    <th>Actions</th>
                </tr>

                </HeaderTemplate>

        <ItemTemplate>  
            <tr>

                <td>
                    <asp:Label Text='<%# Eval("Id") %>' runat="server" ID="lbId"/>
                </td>
                <td>
                    <asp:Label Text='<%# Eval("Title") %>' runat="server" ID="lbTitle"/>
                </td>
                <td>
                    <asp:Label Text='<%# Eval("Credits") %>' runat="server" ID="lbCredits"/>
                </td>
                <td>
                    <asp:Label Text='<%# Eval("DepartmentId") %>' runat="server" ID="lbDeptId"/>
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
