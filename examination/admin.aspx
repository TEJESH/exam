<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="admin.aspx.vb" Inherits="examination.admin1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">

<head>
<title>Admin</title>
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
<style type="text/css">
    
    body
        {
            background:url("green.jpg") no-repeat left top;
            -webkit-background-size:cover
            
            }
 #root {
    background-color: #eee;
}

#left_side {
    float: left;
        height: 19px;
        width: 80px;
    }

#center_s {
    margin-left: auto;
    margin-right: auto;
    width: 65px;
    background-color: #ccc;
}

#right_side {
    float: right;
        height: 567px;
        width: 347px;
        margin-left: 680px;
    }


    #form1
    {
        width: 236px;
        margin-right: 0px;
        height: 587px;
    }


</style>
</head>


<body>
    <p style="height: 54px; margin-top: 0px;" title="Admin">
        <br />
        <b style="font-family: 'Times New Roman', Times, serif; font-size: x-large; font-weight: bold; font-style: normal; font-variant: normal; text-transform: capitalize; color: #808080">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        administrator Portal:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </b></p>
    <div id="left_side" title="Admin">
        <form id="form1" runat="server" dir="rtl" method="post" 
    submitdisabledcontrols="False">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Font-Bold="True" 
            Font-Names="Times New Roman" Font-Overline="True" Font-Size="Large" 
            Font-Underline="True" Text="Select Value"></asp:Label>
    <br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" Height="536px" 
            style="margin-right: 0px; margin-top: 15px" Width="236px" AutoPostBack="true"  >
            <asp:ListItem>Change Student&#39;s Password</asp:ListItem>
            <asp:ListItem>Show Result</asp:ListItem>
            <asp:ListItem>Delete Student</asp:ListItem>
            <asp:ListItem>Delete Teacher</asp:ListItem>
            <asp:ListItem>Add Admin</asp:ListItem>
            <asp:ListItem>Add Teacher</asp:ListItem>
            <asp:ListItem>Clear subject table</asp:ListItem>
        </asp:RadioButtonList>
            
 </div>   
  
 <div id="right_side" title="Admin">
    <asp:Panel runat="server" ID="panel1" Visible="False"> 
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label2" runat="server" Font-Bold="True" 
         Font-Names="Times New Roman" Font-Overline="True" Font-Size="Large" 
         Font-Underline="True" Text="Enter the name"></asp:Label>
        <b style="font-family: 'Times New Roman', Times, serif; font-size: x-large; font-weight: bold; font-style: normal; font-variant: normal; text-transform: capitalize; color: #808080">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Logout" />
        </b>
     <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     <br />
        &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label4" runat="server" Text="Enter Name"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
          &nbsp;&nbsp;&nbsp;
     <asp:TextBox ID="TextBox4" runat="server" Height="29px" Width="220px"></asp:TextBox>
        <br />
     <br />
        &nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label7" runat="server" Text="Old " Visible="False"></asp:Label>
        <asp:Label ID="Label5" runat="server" Text="Password"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        &nbsp;&nbsp;&nbsp;
     <asp:TextBox ID="TextBox2" runat="server" Height="29px" Width="226px" 
         TextMode="Password" Visible="False"></asp:TextBox>
        <br />
     <br />
        &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label6" runat="server" Text="New Password"></asp:Label>
        &nbsp;&nbsp;<br />
        &nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox3" runat="server" Height="31px" TextMode="Password" 
            Visible="False" Width="225px"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label8" runat="server" Text="email"></asp:Label>
        <br />
        &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox5" runat="server" Height="29px" Width="225px"></asp:TextBox>
        <br />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            style="height: 26px" Text="Submit" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label1" runat="server"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        <br />
     <asp:GridView ID="GridView1" runat="server" Height="140px" Width="345px" 
         style="margin-top: 0px">
     </asp:GridView>
     </asp:Panel> 
     &nbsp;
   
</form>
</div>

</body>
</html>