Imports System.Data.OleDb

Public Class Form1
    Public Conn As OleDbConnection
    Public DR As OleDbDataReader
    Public Cmd As OleDbCommand
    Dim NmKry As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Halooo")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
