Public Class Form12

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Label5.Text >= "1" Then
            Label5.Text = Label5.Text - 1.ToString
        End If
        If Label5.Text = "0" Then
            Timer1.Stop()
            MsgBox("timer out", MessageBoxButtons.OK)
            Button1.Enabled = True
            TextBox1.Enabled = True
            TextBox1.Clear()
            Form1.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
        Button1.Enabled = False
        TextBox1.Enabled = False
        Form1.Hide()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim nmp As Integer
        Dim nmro As Integer
        Dim vlck = Val(TextBox1.Text)
        If IsNumeric(TextBox1.Text) = True Then
            If (vlck >= 1 AndAlso vlck <= 3) Then
                nmp = TextBox1.Text
                nmro = nmp * 1800
                Label5.Text = nmro
            ElseIf String.IsNullOrEmpty(TextBox1.Text) = False Then
                MsgBox("Only number! from 1 to 3", MessageBoxButtons.OK)
                TextBox1.Clear()
                Label5.Text = "--"
            End If
        End If
        If String.IsNullOrEmpty(TextBox1.Text) = True Then
            Button1.Enabled = False
            Label5.Text = "--"
        Else
            Button1.Enabled = True
        End If
    End Sub

    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Enabled = False
    End Sub
End Class