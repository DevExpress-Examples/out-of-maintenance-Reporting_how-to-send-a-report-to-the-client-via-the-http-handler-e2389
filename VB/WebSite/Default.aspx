<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<%@ Import Namespace="System.Data" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
</head>
<body>
	<form id="form1" runat="server">
		<asp:Repeater ID="Repeater1" runat="server" DataSourceID="AccessDataSource1">
			<HeaderTemplate>
				<table border="1" cellpadding="0" cellspacing="0" style="font-size: large;">
					<tr style="background-color: Red;">
						<td align="center">
							Reports by categories
						</td>
					</tr>
			</HeaderTemplate>
			<ItemTemplate>
				<tr style="background-color: Aqua;">
					<td align="center">
						<asp:HyperLink ID="HyperLink1" runat="server" Target="_blank"
							NavigateUrl='<%#DataBinder.Eval(Container.DataItem, "CategoryID", "~/ReportingHandler.ashx?catid={0}")%>'
							Text='<%#DataBinder.Eval(Container.DataItem, "CategoryName")%>' ></asp:HyperLink>
					</td>
				</tr>
			</ItemTemplate>
			<AlternatingItemTemplate>
				<tr style="background-color: Fuchsia;">
					<td align="center">
						<asp:HyperLink ID="HyperLink1" runat="server" Target="_blank"
							NavigateUrl='<%#DataBinder.Eval(Container.DataItem, "CategoryID", "~/ReportingHandler.ashx?catid={0}")%>'
							Text='<%#DataBinder.Eval(Container.DataItem, "CategoryName")%>' ></asp:HyperLink>
					</td>
				</tr>
			</AlternatingItemTemplate>
			<FooterTemplate>
				</table>
			</FooterTemplate>
		</asp:Repeater>
		<asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/nwind.mdb"
			SelectCommand="SELECT [CategoryID], [CategoryName] FROM [Categories]">
		</asp:AccessDataSource>
	</form>
</body>
</html>