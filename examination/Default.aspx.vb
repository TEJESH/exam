Imports System.Data.SqlClient 
Partial Public Class _Default
    Inherits System.Web.UI.Page
    Dim con As SqlConnection
    Dim cmd, cmd1, cmd2, cmd3, cmd4 As SqlCommand
    Dim dr As SqlDataReader
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'RadioButtonList1.SelectedIndex = 0
        Try
            con = New SqlConnection
            con.ConnectionString = "data source=Tejesh-PC; initial catalog=tej;integrated security=sspi"
            con.Open()



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


  Protected Sub RadioButtonList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RadioButtonList1.SelectedIndexChanged

    End Sub

    Protected Sub LoginButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim str As String
            cmd = New SqlCommand
            cmd.Connection = con

            If RadioButtonList1.SelectedIndex = 0 Then
                str = "Select * from students where name= '" & Login1.UserName & "' and password= '" & Login1.Password & "'"
                cmd.CommandText = str

                dr = cmd.ExecuteReader()
                If dr.Read() Then

                    Session("userid") = Login1.UserName
                    Response.Redirect("student.aspx")


                    dr.Close()

                End If

            ElseIf RadioButtonList1.SelectedIndex = 1 Then

                str = "Select * from teacher where name= '" & Login1.UserName & "' and password= '" & Login1.Password & "'"
                cmd.CommandText = str
                dr = cmd.ExecuteReader()
                If dr.Read() Then

                    'MsgBox("welcome  " + Login1.UserName)
                    Session("userid") = Login1.UserName
                    Response.Redirect("teacher.aspx")



                    dr.Close()


                End If

            ElseIf RadioButtonList1.SelectedIndex = 2 Then
                str = "Select Name from admin where Name= '" & Login1.UserName & "' and password= '" & Login1.Password & "'"
                cmd.CommandText = str
                dr = cmd.ExecuteReader()
                If dr.Read() Then
                    Session("userid") = Login1.UserName
                    Response.Redirect("admin.aspx")

                    dr.Close()


                End If

            End If

        Catch ex As Exception
            Response.Write(ex.Message)
        End Try
    End Sub

    
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Try
            Dim str As String
            Dim s1, s As String
            cmd = New SqlCommand
            cmd.Connection = con


            If RadioButtonList1.SelectedIndex = 0 Then
                str = "Insert into students values( '" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & " ','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "' )"
                cmd.CommandText = str
                dr = cmd.ExecuteReader()
                If dr.Read() Then

                    Label7.Text = "created"

                End If
            ElseIf RadioButtonList1.SelectedIndex = 1 Then
                Response.Write("No Authorization")
            Else : RadioButtonList1.SelectedIndex = 2
                Response.Write("No Authorization")
    
            End If
        Catch ex As Exception
        End Try
    End Sub

    
End Class