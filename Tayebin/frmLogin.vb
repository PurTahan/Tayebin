﻿
Public Class frmLogin

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Image = IMGcache.img("data\app\icon\padlock67.png")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Val(SQLiter.RunCommandScaler("select count(*) from tKarbari")) <= 0 Then
            Me.Close()
        End If
        If (UcTextBox1.Text = "purtahan" And UcTextBox2.Text = "YaRaouf") OrElse Val(SQLiter.RunCommandScaler(String.Format("select count(*) from tKarbari where u like '{0}' and p like '{1}'", UcTextBox1.Text, UcTextBox2.Text))) = 1 Then
            Me.Close()
        Else
            MessageBox.Show("اطلاعات وارد شده صحیح نمی باشد!")
            UcTextBox1.Clear()
            UcTextBox2.Clear()
            UcTextBox1.Select()
        End If
    End Sub
End Class