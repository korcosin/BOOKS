<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="New.aspx.cs" Inherits="RoadBook.CsharpBasic.Chapter10.Web.Board.New" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            제목 : <asp:TextBox ID="txtTitle" runat="server" Width="500px"></asp:TextBox><br />
            내용 : <asp:TextBox ID="txtSummary" runat="server" TextMode="MultiLine" Height="300px" Width="500px"></asp:TextBox><br />
            작성자 : <asp:TextBox ID="txtUserNm" runat="server" Width="500px"></asp:TextBox><br />
            태그 : <asp:TextBox ID="txtTags" runat="server" Width="500px"></asp:TextBox><br />
            <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" Text="저장" /><br />
        </div>
    </form>
</body>
</html>