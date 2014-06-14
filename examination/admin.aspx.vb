Imports System.Data.SqlClient
Partial Public Class admin1
    Inherits System.Web.UI.Page
    Dim conn As SqlConnection
    Dim da As SqlDataAdapter
    Dim ds As DataSet

    Dim cmd, cmd2, cmd1 As SqlCommand
    Dim dr As SqlDataReader
    Protected Sub Page_UnLoad(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        Label3.Text = "fuck you"
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Session("userid") = "" Then
            Response.Redirect("default.aspx")


        End If
        Try
            conn = New SqlConnection

            conn.ConnectionString = "data source=tejesh-pc; initial catalog=tej;integrated security=sspi"
            conn.Open()
            cmd = New SqlCommand
            cmd.Connection = conn




        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        If RadioButtonList1.SelectedIndex = 0 Then
            Try
                Dim str As String
                cmd1 = New SqlCommand
                cmd1.Connection = conn

                str = "Select * from students where name= '" & TextBox4.Text & "' and password= '" & TextBox2.Text & "'"
                cmd1.CommandText = str
                dr = cmd1.ExecuteReader()
                If dr.Read() Then
                    Dim s2 As String
                    cmd2 = New SqlCommand

                    cmd2.Connection = conn
                    dr.Close()
                    s2 = "Update students set password='" & TextBox3.Text & "' , cpassword='" & TextBox3.Text & "' where name='" & TextBox4.Text & "'"
                    Label1.Text = s2
                    cmd2.CommandText = s2

                    cmd2.ExecuteNonQuery()

                    Label1.Text = "password updated successfully"

                Else
                    Label1.Text = "wrong password or username"

                End If
            Catch ex As Exception
                Label1.Text = ex.Message

            End Try


        ElseIf RadioButtonList1.SelectedIndex = 1 Then
            Dim s4 As String

            s4 = "select * from result where name='" & TextBox4.Text & "'"
            cmd = New SqlCommand
            cmd.Connection = conn
            cmd.CommandText = S4

            da = New SqlDataAdapter
            da.SelectCommand = cmd
            ds = New DataSet()
            da.Fill(ds, "result")

            GridView1.DataSource = ds
            GridView1.DataBind()



        ElseIf RadioButtonList1.SelectedIndex = 2 Then
            Dim str As String
            str = "Delete from students where name= '" & TextBox4.Text & "' and password= '" & TextBox2.Text & "'"


            cmd.CommandText = str

            Try
                cmd.ExecuteNonQuery()
                Label1.Text = "deleted successfully"
            Catch ex As Exception
            End Try

        ElseIf RadioButtonList1.SelectedIndex = 3 Then
            Dim str As String
            str = "Delete from teacher where name= '" & TextBox4.Text & "' and password='" & TextBox2.Text  & "'"


            cmd.CommandText = str

            Try
                cmd.ExecuteNonQuery()
                Label1.Text = "deleted successfully"
                

            Catch ex As Exception
                Label1.Text = ex.Message

            End Try
        ElseIf RadioButtonList1.SelectedIndex = 4 Then
            Dim str As String
            str = "Insert into admin values( '" & TextBox4.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & " ','" & TextBox5.Text & "')"
            cmd.CommandText = str

            Try
                cmd.ExecuteNonQuery()


                Label1.Text = "created"

            Catch ex As Exception
                Label1.Text = "failed"
            End Try

        ElseIf RadioButtonList1.SelectedIndex = 5 Then
                Dim str As String
            str = "Insert into teacher values( '" & TextBox4.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & " ','" & TextBox5.Text & "')"
                cmd.CommandText = str
            'cmd.ExecuteReader()
            Try
                cmd.ExecuteNonQuery()


                Label1.Text = "created"

            Catch ex As Exception
                Label1.Text = "failed"
            End Try

        ElseIf RadioButtonList1.SelectedIndex = 6 Then
            Dim str As String

            str = "truncate table " & TextBox4.Text

            cmd.CommandText = str
            Try
                cmd.ExecuteNonQuery()


                Label1.Text = "clear"

            Catch ex As Exception
                Label1.Text = "failed"
            End Try
        Else
            Label1.Text = "Please select a value"
        End If
        conn.Close()
    End Sub

    Protected Sub TextBox4_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Protected Sub RadioButtonList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RadioButtonList1.SelectedIndexChanged

        If RadioButtonList1.SelectedIndex = 0 Then
            panel1.Visible = True
            TextBox2.Visible = True
            TextBox3.Visible = True
            Label5.Visible = True
            Label6.Visible = True
            Label7.Visible = True
            Label8.Visible = False
            TextBox5.Visible = False

        ElseIf RadioButtonList1.SelectedIndex = 1 Then
            panel1.Visible = True
            TextBox2.Visible = False
            TextBox3.Visible = False
            Label5.Visible = False
            Label6.Visible = False
            Label7.Visible = False
            Label8.Visible = False
            TextBox5.Visible = False

        ElseIf RadioButtonList1.SelectedIndex = 2 Then
            panel1.Visible = True
            TextBox2.Visible = True
            TextBox4.Visible = True
            Label5.Visible = True
            Label6.Visible = False
            Label7.Visible = False
            TextBox3.Visible = False
            Label8.Visible = False
            TextBox5.Visible = False

        ElseIf RadioButtonList1.SelectedIndex = 3 Then
            panel1.Visible = True
            TextBox2.Visible = True
            TextBox4.Visible = True
            Label5.Visible = True
            Label6.Visible = False
            Label7.Visible = False
            TextBox3.Visible = False
            Label8.Visible = False
            TextBox5.Visible = False

        ElseIf RadioButtonList1.SelectedIndex = 4 Then
            panel1.Visible = True
            TextBox2.Visible = True
            TextBox4.Visible = True
            Label5.Visible = True
            Label6.Visible = True
            Label6.Text = "Confirm password"
            Label7.Visible = False
            TextBox3.Visible = True
            Label8.Visible = True
            TextBox5.Visible = True

        ElseIf RadioButtonList1.SelectedIndex = 5 Then

            panel1.Visible = True
            TextBox2.Visible = True
            TextBox4.Visible = True
            Label5.Visible = True
            Label6.Visible = True
            Label6.Text = "Confirm Password"
            Label7.Visible = False
            TextBox3.Visible = True
            Label8.Visible = True
            TextBox5.Visible = True
        Else
            panel1.Visible = True
            TextBox2.Visible = False
            TextBox4.Visible = True
            Label5.Visible = False
            Label6.Visible = False
            Label6.Text = ""
            Label7.Visible = False
            TextBox3.Visible = False
            Label8.Visible = False
            TextBox5.Visible = False
        End If
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Session.Abandon()
        Response.Redirect("default.aspx")
    End Sub
End Class