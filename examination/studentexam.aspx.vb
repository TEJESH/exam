﻿
Imports System.Data.SqlClient

Partial Public Class WebForm3
    Inherits System.Web.UI.Page
    Dim conn As SqlConnection
    Dim cmd, cmd1, cmd2, cmd5, c1, c2 As SqlCommand
    Dim dr, dr1, dr2 As SqlDataReader
    Dim s, q, a, b, c, d, st, str1 As String
    Dim st_ans(10), crt_ans(10), x As Integer
    

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Session("subject") = "" Then
            Response.Redirect("default.aspx")
        End If
        'Timer1.Enabled = True
        Try
            conn = New SqlConnection

            conn.ConnectionString = "data source=tejesh-pc; initial catalog=tej;integrated security=sspi "
            conn.Open()
            cmd = New SqlCommand
            cmd.Connection = conn

            s = Session("subject")

            If s = "Gk" Then
                cmd1 = New SqlCommand
                cmd1.Connection = conn
                st = "Select * from Gk where qno=" & (RadioButtonList1.SelectedIndex + 1)
                cmd.CommandText = st
                dr1 = cmd.ExecuteReader()
                If dr1.Read Then

                    q = dr1.GetString(0)
                    a = dr1.GetString(1)
                    b = dr1.GetString(2)
                    c = dr1.GetString(3)
                    d = dr1.GetString(4)

                End If
                dr1.Close()
            ElseIf s.Equals("English") Then
                cmd1 = New SqlCommand
                cmd1.Connection = conn
                st = "Select * from English where qno=" & (RadioButtonList1.SelectedIndex + 1)
                cmd.CommandText = st
                dr1 = cmd.ExecuteReader()
                If dr1.Read Then
                    q = dr1.GetString(0)
                    a = dr1.GetString(1)
                    b = dr1.GetString(2)
                    c = dr1.GetString(3)
                    d = dr1.GetString(4)

                End If
                dr1.Close()
            ElseIf s.Equals("C") Then
                cmd1 = New SqlCommand
                cmd1.Connection = conn
                st = "Select * from C where qno=" & (RadioButtonList1.SelectedIndex + 1)
                cmd.CommandText = st
                dr1 = cmd.ExecuteReader()
                If dr1.Read Then
                    q = dr1.GetString(0)
                    a = dr1.GetString(1)
                    b = dr1.GetString(2)
                    c = dr1.GetString(3)
                    d = dr1.GetString(4)

                End If
                dr1.Close()
            ElseIf s.Equals("Aptitude") Then
                cmd1 = New SqlCommand
                cmd1.Connection = conn
                st = "Select * from Aptitude where qno=" & (RadioButtonList1.SelectedIndex + 1)
                cmd.CommandText = st
                dr1 = cmd.ExecuteReader()
                If dr1.Read Then
                    q = dr1.GetString(0)
                    a = dr1.GetString(1)
                    b = dr1.GetString(2)
                    c = dr1.GetString(3)
                    d = dr1.GetString(4)

                End If
                dr1.Close()
            ElseIf s.Equals("Maths") Then
                cmd1 = New SqlCommand
                cmd1.Connection = conn
                st = "Select * from Maths where qno=" & (RadioButtonList1.SelectedIndex + 1)
                cmd.CommandText = st
                dr1 = cmd.ExecuteReader()
                If dr1.Read Then
                    q = dr1.GetString(0)
                    a = dr1.GetString(1)
                    b = dr1.GetString(2)
                    c = dr1.GetString(3)
                    d = dr1.GetString(4)

                End If

            End If
            Label1.Text = q
            Label8.Text = a
            Label9.Text = b
            Label10.Text = c
            Label11.Text = d


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        cmd = New SqlCommand
        cmd.Connection = conn

        str1 = "update temp1 set subject='" & Session("subject") & "' "
        cmd.CommandText = str1
        cmd.ExecuteNonQuery()




        Timer1.Enabled = True

    End Sub








    Protected Sub RadioButtonList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RadioButtonList1.SelectedIndexChanged
        Try
            conn = New SqlConnection

            conn.ConnectionString = "data source=tejesh-pc; initial catalog=tej;integrated security=sspi "
            conn.Open()
            cmd = New SqlCommand
            cmd.Connection = conn

            s = Session("subject")
            Response.Write(s)
            If s = "Gk" Then
                cmd1 = New SqlCommand
                cmd1.Connection = conn
                st = "Select * from Gk where qno=" & RadioButtonList1.SelectedIndex + 1
                cmd.CommandText = st
                dr1 = cmd.ExecuteReader()
                If dr1.Read Then

                    q = dr1.GetString(0)
                    a = dr1.GetString(1)
                    b = dr1.GetString(2)
                    c = dr1.GetString(3)
                    d = dr1.GetString(4)
                Else

                End If
                dr1.Close()
            ElseIf s.Equals("English") Then
                cmd1 = New SqlCommand
                cmd1.Connection = conn
                st = "Select * from English where qno=" & (RadioButtonList1.SelectedIndex + 1)
                cmd.CommandText = st
                dr1 = cmd.ExecuteReader()
                If dr1.Read Then
                    q = dr1.GetString(0)
                    a = dr1.GetString(1)
                    b = dr1.GetString(2)
                    c = dr1.GetString(3)
                    d = dr1.GetString(4)

                End If
                dr1.Close()
            ElseIf s.Equals("C") Then
                cmd1 = New SqlCommand
                cmd1.Connection = conn
                st = "Select * from C where qno=" & (RadioButtonList1.SelectedIndex + 1)
                cmd.CommandText = st
                dr1 = cmd.ExecuteReader()
                If dr1.Read Then
                    q = dr1.GetString(0)
                    a = dr1.GetString(1)
                    b = dr1.GetString(2)
                    c = dr1.GetString(3)
                    d = dr1.GetString(4)

                End If
                dr1.Close()
            ElseIf s.Equals("Aptitude") Then
                cmd1 = New SqlCommand
                cmd1.Connection = conn
                st = "Select * from Aptitude where qno=" & (RadioButtonList1.SelectedIndex + 1)
                cmd.CommandText = st
                dr1 = cmd.ExecuteReader()
                If dr1.Read Then
                    q = dr1.GetString(0)
                    a = dr1.GetString(1)
                    b = dr1.GetString(2)
                    c = dr1.GetString(3)
                    d = dr1.GetString(4)

                End If
                dr1.Close()
            ElseIf s.Equals("Maths") Then
                cmd1 = New SqlCommand
                cmd1.Connection = conn
                st = "Select * from Maths where qno=" & (RadioButtonList1.SelectedIndex + 1)
                cmd.CommandText = st
                dr1 = cmd.ExecuteReader()
                If dr1.Read Then
                    q = dr1.GetString(0)
                    a = dr1.GetString(1)
                    b = dr1.GetString(2)
                    c = dr1.GetString(3)
                    d = dr1.GetString(4)

                End If
                dr1.Close()
            End If
            Label1.Text = q
            Label8.Text = a
            Label9.Text = b
            Label10.Text = c
            Label11.Text = d



        Catch ex As Exception
            'Label7.Text = ex.Message
            Response.Write("<font color='red'>" & ex.Message)
        End Try
        If RadioButton1.Checked Then
            x = 1
        ElseIf RadioButton2.Checked Then
            x = 2
        ElseIf RadioButton3.Checked Then
            x = 3
        ElseIf RadioButton4.Checked Then
            x = 4
        End If



        cmd = New SqlCommand
        cmd.Connection = conn

        str1 = "update temp1 set answer=" & x & " where question=" & RadioButtonList1.SelectedIndex + 1
        cmd.CommandText = str1
        cmd.ExecuteNonQuery()







    End Sub


    Protected Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button4.Click
        Session.Abandon()
        Response.Redirect("default.aspx")
    End Sub

    Protected Sub Button5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button5.Click
        'Dim s1, s2 As String
        Dim i, marks As Integer
        i = 0
        marks = 0
        cmd = New SqlCommand
        cmd.Connection = conn
        cmd.CommandText = "select correct from " & Session("subject")
        dr1 = cmd.ExecuteReader
        
        While (dr1.Read())
            crt_ans(i + 1) = dr1.GetInt32(0)
            i += 1
        End While
        'i = 0
        dr1.Close()
        cmd = New SqlCommand
        cmd.Connection = conn
        cmd.CommandText = "select answer from temp1"
        i = 0
        dr1 = cmd.ExecuteReader
        While (dr1.Read())
            st_ans(i + 1) = dr1.GetInt32(0)
            i += 1
        End While
        dr1.Close()
        

        For i = 1 To 10
            If st_ans(i) = crt_ans(i) And st_ans(i) <> 0 Then
                marks += 1
            End If
            Response.Write(st_ans(i) & " " & crt_ans(i))
        Next
        cmd1 = New SqlCommand
        cmd1.CommandText = "Insert into result values('" & Session("userid") & "','" & Session("subject") & "'," & marks & ")"
        cmd1.Connection = conn
        cmd1.ExecuteNonQuery()

        cmd1 = New SqlCommand
        cmd1.CommandText = "update temp1 set answer=0"
        cmd1.Connection = conn
        cmd1.ExecuteNonQuery()

        Response.Redirect("end.aspx")
    End Sub



    
    Protected Sub RadioButton1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            x = 1
        ElseIf RadioButton2.Checked Then
            x = 2
        ElseIf RadioButton3.Checked Then
            x = 3
        ElseIf RadioButton4.Checked Then
            x = 4
        End If
        cmd = New SqlCommand
        cmd.Connection = conn

        str1 = "update temp1 set answer=" & x & " where question=" & RadioButtonList1.SelectedIndex + 1
        cmd.CommandText = str1
        cmd.ExecuteNonQuery()
        'Response.Write("hello")
    End Sub

    Protected Sub RadioButton2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton1.Checked Then
            x = 1
        ElseIf RadioButton2.Checked Then
            x = 2
        ElseIf RadioButton3.Checked Then
            x = 3
        ElseIf RadioButton4.Checked Then
            x = 4
        End If
        cmd = New SqlCommand
        cmd.Connection = conn

        str1 = "update temp1 set answer=" & x & " where question=" & RadioButtonList1.SelectedIndex + 1
        cmd.CommandText = str1
        cmd.ExecuteNonQuery()

    End Sub

    Protected Sub RadioButton3_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton1.Checked Then
            x = 1
        ElseIf RadioButton2.Checked Then
            x = 2
        ElseIf RadioButton3.Checked Then
            x = 3
        ElseIf RadioButton4.Checked Then
            x = 4
        End If
        cmd = New SqlCommand
        cmd.Connection = conn

        str1 = "update temp1 set answer=" & x & " where question=" & RadioButtonList1.SelectedIndex + 1
        cmd.CommandText = str1
        cmd.ExecuteNonQuery()

    End Sub

    Protected Sub RadioButton4_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton1.Checked Then
            x = 1
        ElseIf RadioButton2.Checked Then
            x = 2
        ElseIf RadioButton3.Checked Then
            x = 3
        ElseIf RadioButton4.Checked Then
            x = 4
        End If
        cmd = New SqlCommand
        cmd.Connection = conn

        str1 = "update temp1 set answer=" & x & " where question=" & RadioButtonList1.SelectedIndex + 1
        cmd.CommandText = str1
        cmd.ExecuteNonQuery()

    End Sub

    Protected Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick, Timer1.Tick
       
        Dim timer, timer_arr() As String
        timer = Label12.Text
        timer_arr = timer.Split(":")
        Dim seconds = Integer.Parse(timer_arr(2))
        Dim minutes = Integer.Parse(timer_arr(1))
        Dim hours = Integer.Parse(timer_arr(0))
        If seconds = 0 And minutes = 0 And hours = 0 Then
            Timer1.Enabled = False
            Response.Write("time up")
            Response.Redirect("end.aspx")

        Else
            seconds = seconds - 1
        End If
        If (seconds < 0) Then
            seconds = 59
            minutes = minutes - 1
        End If
        If minutes < 0 Then
            minutes = 59
            hours = hours - 1
        End If

        Label12.Text = hours & ":" & minutes & ":" & seconds









    End Sub
End Class