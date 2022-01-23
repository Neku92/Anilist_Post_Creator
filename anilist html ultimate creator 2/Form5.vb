Imports System.ComponentModel

Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.imagefanart IsNot Nothing Then
            For Each i As String In My.Settings.imagefanart
                ComboBox5.Items.Add(i)
            Next
        Else
            My.Settings.imagefanart = New System.Collections.Specialized.StringCollection
        End If
        If My.Settings.bannerfanart IsNot Nothing Then
            For Each i As String In My.Settings.bannerfanart
                ComboBox1.Items.Add(i)
            Next
        Else
            My.Settings.bannerfanart = New System.Collections.Specialized.StringCollection
        End If
        If My.Settings.imageartwork IsNot Nothing Then
            For Each i As String In My.Settings.imageartwork
                ComboBox6.Items.Add(i)
            Next
        Else
            My.Settings.imageartwork = New System.Collections.Specialized.StringCollection
        End If
        If My.Settings.bannerartwork IsNot Nothing Then
            For Each i As String In My.Settings.bannerartwork
                ComboBox3.Items.Add(i)
            Next
        Else
            My.Settings.bannerartwork = New System.Collections.Specialized.StringCollection
        End If
        If My.Settings.imagedaily IsNot Nothing Then
            For Each i As String In My.Settings.imagedaily
                ComboBox7.Items.Add(i)
            Next
        Else
            My.Settings.imagedaily = New System.Collections.Specialized.StringCollection
        End If
        If My.Settings.bannerdaily IsNot Nothing Then
            For Each i As String In My.Settings.bannerdaily
                ComboBox4.Items.Add(i)
            Next
        Else
            My.Settings.bannerdaily = New System.Collections.Specialized.StringCollection
        End If
        If My.Settings.comboitems IsNot Nothing Then
            For Each i As String In My.Settings.comboitems
                ComboBox8.Items.Add(i)
            Next
        Else
            My.Settings.comboitems = New System.Collections.Specialized.StringCollection
        End If
        If My.Settings.buttonnames IsNot Nothing Then
            For Each i As String In My.Settings.buttonnames
                ComboBox2.Items.Add(i)
            Next
        Else
            My.Settings.buttonnames = New System.Collections.Specialized.StringCollection
        End If
        Try
            Me.BackgroundImage = Image.FromFile(My.Settings.BckgrnImage5.ToString)
        Catch ex As Exception
        End Try
        If ComboBox2.Items.Count >= 1 Then
            Button2.Enabled = True
            Button1.Enabled = True
        Else
            Button2.Enabled = False
            Button1.Enabled = False
        End If

    End Sub

    Private Sub Form5_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If ComboBox8.Items.Count > 0 Then
            My.Settings.comboitems.Clear()
            For Each i As String In ComboBox8.Items
                My.Settings.comboitems.Add(i)
            Next
            My.Settings.Save()
        Else
            My.Settings.comboitems.Clear()
        End If
        If ComboBox2.Items.Count > 0 Then
            My.Settings.buttonnames.Clear()
            For Each i As String In ComboBox2.Items
                My.Settings.buttonnames.Add(i)
            Next
            My.Settings.Save()
        Else
            My.Settings.buttonnames.Clear()
        End If
        If ComboBox1.Items.Count > 0 Then
            My.Settings.bannerfanart.Clear()
            For Each i As String In ComboBox1.Items
                My.Settings.bannerfanart.Add(i)
            Next
            My.Settings.Save()
        Else
            My.Settings.bannerfanart.Clear()
        End If
        If ComboBox5.Items.Count > 0 Then
            My.Settings.imagefanart.Clear()
            For Each i As String In ComboBox5.Items
                My.Settings.imagefanart.Add(i)
            Next
            My.Settings.Save()
        Else
            My.Settings.imagefanart.Clear()
        End If
        If ComboBox3.Items.Count > 0 Then
            My.Settings.bannerartwork.Clear()
            For Each i As String In ComboBox3.Items
                My.Settings.bannerartwork.Add(i)
            Next
            My.Settings.Save()
        Else
            My.Settings.bannerartwork.Clear()
        End If
        If ComboBox6.Items.Count > 0 Then
            My.Settings.imageartwork.Clear()
            For Each i As String In ComboBox6.Items
                My.Settings.imageartwork.Add(i)
            Next
            My.Settings.Save()
        Else
            My.Settings.imageartwork.Clear()
        End If
        If ComboBox4.Items.Count > 0 Then
            My.Settings.bannerdaily.Clear()
            For Each i As String In ComboBox4.Items
                My.Settings.bannerdaily.Add(i)
            Next
            My.Settings.Save()
        Else
            My.Settings.bannerdaily.Clear()
        End If
        If ComboBox7.Items.Count > 0 Then
            My.Settings.imagedaily.Clear()
            For Each i As String In ComboBox7.Items
                My.Settings.imagedaily.Add(i)
            Next
            My.Settings.Save()
        Else
            My.Settings.imagedaily.Clear()
        End If
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged
        Dim cmt As String
        cmt = ComboBox5.Text.ToString
        PictureBox2.ImageLocation = cmt
    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox6.SelectedIndexChanged
        Dim cmt As String
        cmt = ComboBox6.Text.ToString
        PictureBox2.ImageLocation = cmt
    End Sub

    Private Sub ComboBox7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox7.SelectedIndexChanged
        Dim cmt As String
        cmt = ComboBox7.Text.ToString
        PictureBox2.ImageLocation = cmt
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        For i = 0 To ComboBox1.Items.Count
            If ComboBox1.SelectedIndex = (i) Then
                ComboBox5.SelectedIndex = (i)
            End If
        Next
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        For i = 0 To ComboBox3.Items.Count
            If ComboBox3.SelectedIndex = (i) Then
                ComboBox6.SelectedIndex = (i)
            End If
        Next
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        For i = 0 To ComboBox4.Items.Count
            If ComboBox4.SelectedIndex = (i) Then
                ComboBox7.SelectedIndex = (i)
            End If
        Next
    End Sub

    Private Sub ComboBox8_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox8.SelectedIndexChanged
        Dim cmt As String
        cmt = ComboBox8.Text.ToString
        PictureBox1.ImageLocation = cmt
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        For i = 0 To ComboBox2.Items.Count
            If ComboBox2.SelectedIndex = (i) Then
                ComboBox8.SelectedIndex = (i)
            End If
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If RadioButton1.Checked = True Then
            ComboBox1.Items.Remove(ComboBox1.SelectedItem)
            ComboBox5.Items.Remove(ComboBox5.SelectedItem)
        End If
        If RadioButton2.Checked = True Then
            ComboBox3.Items.Remove(ComboBox3.SelectedItem)
            ComboBox6.Items.Remove(ComboBox6.SelectedItem)
        End If
        If RadioButton3.Checked = True Then
            ComboBox4.Items.Remove(ComboBox4.SelectedItem)
            ComboBox7.Items.Remove(ComboBox7.SelectedItem)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            ComboBox1.Items.Add(ComboBox2.SelectedItem)
            ComboBox5.Items.Add(ComboBox8.SelectedItem)
        ElseIf RadioButton2.Checked = True Then
            ComboBox3.Items.Add(ComboBox2.SelectedItem)
            ComboBox6.Items.Add(ComboBox8.SelectedItem)
        ElseIf RadioButton3.Checked = True Then
            ComboBox4.Items.Add(ComboBox2.SelectedItem)
            ComboBox7.Items.Add(ComboBox8.SelectedItem)
        End If
    End Sub
End Class