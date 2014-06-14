<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="student.aspx.vb" Inherits="examination.WebForm5" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1"  runat="server">
    <title>Student</title>
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
        width: 175px;
    }

#center_s {
    margin-left: auto;
    margin-right: auto;
    width: 65px;
    background-color: #ccc;
}

#right_side {
    float: right;
            height: 388px;
            width: 313px;
        }


        #form2
        {
            height: 510px;
        }


    </style>

    
</head>
<body>
    <form id="form2" runat="server">
    <p dir="ltr" 
        
        
        
        
        style="height: 35px; width: 1009px; font-family: 'Times New Roman', Times, serif; font-size: x-large; font-weight: bold; font-style: italic; font-variant: normal; text-transform: capitalize; color: #808080;">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Welcome To Student Portal. Here You Can choose your Subject:<%=Session("userid")%>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button3" runat="server" Text="Logout" />
    
        </p>
    
    
<div id="root">
    <div id="left_side" 
        style="font-weight: bold; font-size: large; font-family: 'Times New Roman', Times, serif">
        <p style="margin-left: 80px">
        Subjects:<br />
&nbsp;</p>
        <asp:RadioButtonList ID="RadioButtonList2" runat="server" Height="351px" 
            Width="148px" style="margin-left: 140px">
            <asp:ListItem>Aptitude</asp:ListItem>
            <asp:ListItem>GK</asp:ListItem>
            <asp:ListItem>C</asp:ListItem>
            <asp:ListItem>Maths</asp:ListItem>
            <asp:ListItem>English</asp:ListItem>
        </asp:RadioButtonList>
    
    </div>
    
    <div id="right_side" 
        style="font-family: 'Times New Roman', Times, serif; font-size: large; font-weight: bold; font-style: normal">
    
        Rules:<br />
        <br />
        1) There are 10 MCQs.<br />
        <br />
        2) Maximum time limit is 30.<br />
        <br />
        3) you can toggle the question from.<br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:Button ID="Button2" runat="server" Font-Bold="True" Height="57px" 
            Text="START" Width="142px" />
    </div>
        
        </div>
    </form>
</body>
</html>
