Imports System.ComponentModel

Public Class Form11
    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.postname IsNot Nothing Then
            For Each i As String In My.Settings.postname
                ListBox1.Items.Add(i)
            Next
        Else
            My.Settings.postname = New System.Collections.Specialized.StringCollection
        End If
        If My.Settings.postcode IsNot Nothing Then
            For Each i As String In My.Settings.postcode
                ComboBox1.Items.Add(i)
            Next
        Else
            My.Settings.postcode = New System.Collections.Specialized.StringCollection
        End If
        If My.Settings.postdate IsNot Nothing Then
            For Each i As String In My.Settings.postdate
                ComboBox2.Items.Add(i)
            Next
        Else
            My.Settings.postdate = New System.Collections.Specialized.StringCollection
        End If
        If My.Settings.postday IsNot Nothing Then
            For Each i As String In My.Settings.postday
                ComboBox3.Items.Add(i)
            Next
        Else
            My.Settings.postday = New System.Collections.Specialized.StringCollection
        End If
        Button3.Enabled = False
        Button2.Enabled = False
        Button1.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim d As DateTime = DateTime.Now
        Label6.Text = d.AddMonths(-TextBox1.Text)
        Dim d2 As DateTime = Label6.Text
        Dim dysdiff As String = (d - d2).Days
        Label7.Text = 365 - dysdiff
        ListBox1.Items.Add(TextBox3.Text)
        ComboBox1.Items.Add(TextBox2.Text)
        ComboBox2.Items.Add(Label6.Text)
        ComboBox3.Items.Add(Label7.Text)
        TextBox3.Clear()
        TextBox2.Clear()
        TextBox1.Clear()
        If ListBox1.Items.Count > 0 Then
            Button3.Enabled = True
            Button2.Enabled = True
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        For i = 0 To ListBox1.Items.Count
            If ListBox1.SelectedIndex = (i) Then
                ComboBox1.SelectedIndex = (i)
                ComboBox2.SelectedIndex = (i)
                Label6.Text = ComboBox2.Text
                ComboBox3.SelectedIndex = (i)
                Label7.Text = ComboBox3.Text
            End If
        Next
    End Sub

    Private Sub Form11_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If ListBox1.Items.Count > 0 Then
            My.Settings.postname.Clear()
            For Each i As String In ListBox1.Items
                My.Settings.postname.Add(i)
            Next
            My.Settings.Save()
        Else
            My.Settings.postname.Clear()
        End If
        If ComboBox1.Items.Count > 0 Then
            My.Settings.postcode.Clear()
            For Each i As String In ComboBox1.Items
                My.Settings.postcode.Add(i)
            Next
            My.Settings.Save()
        Else
            My.Settings.postcode.Clear()
        End If
        If ComboBox2.Items.Count > 0 Then
            My.Settings.postdate.Clear()
            For Each i As String In ComboBox2.Items
                My.Settings.postdate.Add(i)
            Next
            My.Settings.Save()
        Else
            My.Settings.postdate.Clear()
        End If
        If ComboBox3.Items.Count > 0 Then
            My.Settings.postday.Clear()
            For Each i As String In ComboBox3.Items
                My.Settings.postday.Add(i)
            Next
            My.Settings.Save()
        Else
            My.Settings.postday.Clear()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Remove(ListBox1.SelectedItem)
        ComboBox1.Items.Remove(ComboBox1.SelectedItem)
        ComboBox2.Items.Remove(ComboBox2.SelectedItem)
        ComboBox3.Items.Remove(ComboBox3.SelectedItem)
        If ListBox1.Items.Count = 0 Then
            Button3.Enabled = False
            Button2.Enabled = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Clipboard.SetText(ComboBox1.Text)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If String.IsNullOrEmpty(TextBox1.Text) = True Then
            Button1.Enabled = False
        Else
            Button1.Enabled = True
        End If
    End Sub
End Class