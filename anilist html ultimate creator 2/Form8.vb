Imports System.ComponentModel

Public Class Form8
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ComboBox3.Items.Add(TextBox1.Text$)
        ComboBox4.Items.Add(TextBox4.Text$)
        ComboBox5.Items.Add(TextBox2.Text$)
        ComboBox6.Items.Add(ComboBox2.SelectedItem + TextBox3.Text$)
        ComboBox7.Items.Add(TextBox5.Text$)
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.oelname IsNot Nothing Then
            For Each i As String In My.Settings.oelname
                ComboBox3.Items.Add(i)
            Next
        Else
            My.Settings.oelname = New System.Collections.Specialized.StringCollection
        End If
        If My.Settings.oelcover IsNot Nothing Then
            For Each i As String In My.Settings.oelcover
                ComboBox4.Items.Add(i)
            Next
        Else
            My.Settings.oelcover = New System.Collections.Specialized.StringCollection
        End If
        If My.Settings.oelmarket IsNot Nothing Then
            For Each i As String In My.Settings.oelmarket
                ComboBox5.Items.Add(i)
            Next
        Else
            My.Settings.oelmarket = New System.Collections.Specialized.StringCollection
        End If
        If My.Settings.oelprice IsNot Nothing Then
            For Each i As String In My.Settings.oelprice
                ComboBox6.Items.Add(i)
            Next
        Else
            My.Settings.oelprice = New System.Collections.Specialized.StringCollection
        End If
        If My.Settings.oelink IsNot Nothing Then
            For Each i As String In My.Settings.oelink
                ComboBox7.Items.Add(i)
            Next
        Else
            My.Settings.oelink = New System.Collections.Specialized.StringCollection
        End If
        Try
            Me.BackgroundImage = Image.FromFile(My.Settings.BckgrnImage8.ToString)
        Catch ex As Exception
        End Try
    End Sub


    Private Sub Form8_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If ComboBox3.Items.Count > 0 Then
            My.Settings.oelname.Clear()
            For Each i As String In ComboBox3.Items
                My.Settings.oelname.Add(i)
            Next
            My.Settings.Save()
        Else
            My.Settings.oelname.Clear()
        End If
        If ComboBox4.Items.Count > 0 Then
            My.Settings.oelcover.Clear()
            For Each i As String In ComboBox4.Items
                My.Settings.oelcover.Add(i)
            Next
            My.Settings.Save()
        Else
            My.Settings.oelcover.Clear()
        End If
        If ComboBox5.Items.Count > 0 Then
            My.Settings.oelmarket.Clear()
            For Each i As String In ComboBox5.Items
                My.Settings.oelmarket.Add(i)
            Next
            My.Settings.Save()
        Else
            My.Settings.oelmarket.Clear()
        End If
        If ComboBox6.Items.Count > 0 Then
            My.Settings.oelprice.Clear()
            For Each i As String In ComboBox6.Items
                My.Settings.oelprice.Add(i)
            Next
            My.Settings.Save()
        Else
            My.Settings.oelprice.Clear()
        End If
        If ComboBox7.Items.Count > 0 Then
            My.Settings.oelink.Clear()
            For Each i As String In ComboBox7.Items
                My.Settings.oelink.Add(i)
            Next
            My.Settings.Save()
        Else
            My.Settings.oelink.Clear()
        End If
    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox6.SelectedIndexChanged
        Label8.Text = ComboBox6.SelectedItem.ToString
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        For i = 0 To ComboBox3.Items.Count
            If ComboBox3.SelectedIndex = (i) Then
                ComboBox4.SelectedIndex = (i)
                ComboBox5.SelectedIndex = (i)
                ComboBox6.SelectedIndex = (i)
                ComboBox7.SelectedIndex = (i)
            End If
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ComboBox3.Items.Remove(ComboBox3.SelectedItem)
        ComboBox4.Items.Remove(ComboBox4.SelectedItem)
        ComboBox5.Items.Remove(ComboBox5.SelectedItem)
        ComboBox6.Items.Remove(ComboBox6.SelectedItem)
        ComboBox7.Items.Remove(ComboBox7.SelectedItem)
        Label8.Text = "---"
        LinkLabel1.Text = ""
    End Sub

    Private Sub ComboBox7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox7.SelectedIndexChanged
        LinkLabel1.Text = ComboBox7.SelectedItem.ToString
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ComboBox3.Items.Clear()
        ComboBox4.Items.Clear()
        ComboBox5.Items.Clear()
        ComboBox6.Items.Clear()
        ComboBox7.Items.Clear()
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged
        Dim cmt As String
        cmt = ComboBox4.Text.ToString
        PictureBox1.ImageLocation = cmt
        Dim cmt2 As String
        cmt2 = ComboBox5.Text.ToString
        PictureBox2.ImageLocation = cmt2
    End Sub
End Class