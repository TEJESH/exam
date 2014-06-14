Public Partial Class WebForm5
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("userid") = "" Then
            Response.Redirect("default.aspx")
        Else

        End If
    End Sub



    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
        Session.Abandon()
        Response.Redirect("default.aspx")
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Dim dt As Date
        dt = Now()
        If (dt >= "5/15/2013 10:00 AM" And dt <= "5/15/2013 3:00 PM") Then
            Response.Write("welcome you are at right time")
            Session("subject") = RadioButtonList2.SelectedValue
            Response.Redirect("studentexam.aspx")
        Else
            Response.Write("sorry time over")
        End If

        


    End Sub

    Protected Sub RadioButtonList2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RadioButtonList2.SelectedIndexChanged

    End Sub
End Class