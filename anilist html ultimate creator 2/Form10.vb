Imports System.ComponentModel

Public Class Form10

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.SPname IsNot Nothing Then
            For Each i As String In My.Settings.SPname
                ComboBox2.Items.Add(i)
            Next
        Else
            My.Settings.SPname = New System.Collections.Specialized.StringCollection
        End If
        If My.Settings.SPcover IsNot Nothing Then
            For Each i As String In My.Settings.SPcover
                ComboBox4.Items.Add(i)
            Next
        Else
            My.Settings.SPcover = New System.Collections.Specialized.StringCollection
        End If
        If My.Settings.SPlink IsNot Nothing Then
            For Each i As String In My.Settings.SPlink
                ComboBox3.Items.Add(i)
            Next
        Else
            My.Settings.SPlink = New System.Collections.Specialized.StringCollection
        End If
        Try
            Me.BackgroundImage = Image.FromFile(My.Settings.BckgrnImage11.ToString)
        Catch ex As Exception
        End Try
        Button6.Enabled = False
        Button7.Enabled = False
        Button5.Enabled = False
    End Sub

    Private Sub Form10_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If ComboBox2.Items.Count > 0 Then
            My.Settings.SPname.Clear()
            For Each i As String In ComboBox2.Items
                My.Settings.SPname.Add(i)
            Next
            My.Settings.Save()
        Else
            My.Settings.SPname.Clear()
        End If
        If ComboBox4.Items.Count > 0 Then
            My.Settings.SPcover.Clear()
            For Each i As String In ComboBox4.Items
                My.Settings.SPcover.Add(i)
            Next
            My.Settings.Save()
        Else
            My.Settings.SPcover.Clear()
        End If
        If ComboBox3.Items.Count > 0 Then
            My.Settings.SPlink.Clear()
            For Each i As String In ComboBox3.Items
                My.Settings.SPlink.Add(i)
            Next
            My.Settings.Save()
        Else
            My.Settings.SPlink.Clear()
        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ComboBox2.Items.Add(TextBox7.Text$)
        ComboBox4.Items.Add(TextBox5.Text$)
        ComboBox3.Items.Add(TextBox6.Text$)
        TextBox7.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ComboBox2.Items.Remove(ComboBox2.SelectedItem)
        ComboBox4.Items.Remove(ComboBox4.SelectedItem)
        ComboBox3.Items.Remove(ComboBox3.SelectedItem)
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        For i = 0 To ComboBox2.Items.Count
            If ComboBox2.SelectedIndex = (i) Then
                ComboBox4.SelectedIndex = (i)
                ComboBox3.SelectedIndex = (i)
            End If
        Next
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        Dim cmt As String
        cmt = ComboBox4.Text.ToString
        PictureBox1.ImageLocation = cmt
    End Sub

    Dim counter As Integer = 0
    Dim counter2 As Integer = 0
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim spcvr As String
        Dim splnk As String
        spcvr = ComboBox4.Text.ToString
        splnk = ComboBox3.Text.ToString
        TextBox1.Text += "[img" & "220" & "(" & spcvr & ") ]" & "(" & splnk & ")"
        counter += 1
        If counter = 3 Then
            TextBox1.Text += vbCrLf
            counter = 0
            counter2 += 1
        End If
        Label1.Text = counter
        Label6.Text = counter2
        If counter2 = 3 Then
            Button5.Enabled = False
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Button6.Enabled = True
            Button7.Enabled = True
            Button5.Enabled = True
        Else
            CheckBox1.Checked = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button5.Enabled = False
        End If
    End Sub

    Private Sub Form10_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form6.CheckBox1.Checked = False
        Form6.CheckBox1.Enabled = True
    End Sub
End Class