Imports System.Data.SqlClient
Partial Public Class WebForm2
    Inherits System.Web.UI.Page
    Dim conn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Session("userid") = "" Then
            Response.Redirect("default.aspx")


        End If
        Try
            conn = New SqlConnection
            conn.ConnectionString = "data source=Tejesh-PC; initial catalog=tej;integrated security=sspi"
            conn.Open()



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Try
            Dim s, a, s1 As String
            cmd = New SqlCommand
            cmd.Connection = conn

            s = "Select * from tea"
            cmd.CommandText = s
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                a = dr.GetString(0)



                dr.Close()

            Else
                Label7.Text = "Wrong Subject"
            End If

            If DropDownList1.Text = "GK" Then
                cmd = New SqlCommand
                cmd.Connection = conn

                s1 = "Insert into Gk values( '" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & " ','" & TextBox4.Text & " ','" & TextBox5.Text & " ','" & TextBox6.Text & " ' )"
                cmd.CommandText = s1
                cmd.ExecuteNonQuery()
                Label7.Text = "Inserted"


            ElseIf DropDownList1.Text = "C" Then
                cmd = New SqlCommand
                cmd.Connection = conn

                s1 = "Insert into C values( '" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & " ','" & TextBox4.Text & " ','" & TextBox5.Text & " ','" & TextBox6.Text & " ' )"
                cmd.CommandText = s1
                cmd.ExecuteNonQuery()
                Label7.Text = "Inserted"




            ElseIf DropDownList1.Text = "Aptitude" Then
                cmd = New SqlCommand
                cmd.Connection = conn

                s1 = "Insert into aptitude values( '" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & " ','" & TextBox4.Text & " ','" & TextBox5.Text & " '," & TextBox6.Text & ")"
                cmd.CommandText = s1
                cmd.ExecuteNonQuery()
                Label7.Text = "Inserted"

            ElseIf DropDownList1.Text = "Maths" Then
                cmd = New SqlCommand
                cmd.Connection = conn

                s1 = "Insert into maths values( '" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & " ','" & TextBox4.Text & " ','" & TextBox5.Text & " ','" & TextBox6.Text & " ' )"
                cmd.CommandText = s1
                cmd.ExecuteNonQuery()
                Label7.Text = "Inserted"

            ElseIf DropDownList1.Text = "English" Then
                cmd = New SqlCommand
                cmd.Connection = conn

                s1 = "Insert into english values( '" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & " ','" & TextBox4.Text & " ','" & TextBox5.Text & " ','" & TextBox6.Text & " ' )"
                cmd.CommandText = s1
                cmd.ExecuteNonQuery()
                MsgBox("inserted")
            Else
                Label7.Text = "try again"

            End If




        Catch ex As Exception
            Label7.Text = ex.Message

        End Try

    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Session.Abandon()
        Response.Redirect("default.aspx")
    End Sub
End Class