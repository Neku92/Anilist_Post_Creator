Imports System.ComponentModel
Imports System.IO

Public Class Form7
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.cstname IsNot Nothing Then
            For Each i As String In My.Settings.cstname
                ComboBox2.Items.Add(i)
            Next
        Else
            My.Settings.cstname = New System.Collections.Specialized.StringCollection
        End If
        If My.Settings.cstlink IsNot Nothing Then
            For Each i As String In My.Settings.cstlink
                ComboBox4.Items.Add(i)
            Next
        Else
            My.Settings.cstlink = New System.Collections.Specialized.StringCollection
        End If
        Try
            Me.BackgroundImage = Image.FromFile(My.Settings.BckgrnImage7.ToString)
        Catch ex As Exception
        End Try
        Label5.Visible = False
        TextBox1.Visible = False
        Button2.Visible = False
        Button1.Visible = False
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            Form1.BackgroundImage = Nothing
            Form1.BackColor = Color.Black
            Form1.ForeColor = Color.White
            Form2.BackColor = Color.Black
            Form2.ForeColor = Color.White
            Form3.BackColor = Color.Black
            Form3.ForeColor = Color.White
            Form4.BackColor = Color.Black
            Form4.ForeColor = Color.White
            Form5.BackColor = Color.Black
            Form5.ForeColor = Color.White
            Form6.BackColor = Color.Black
            Form6.ForeColor = Color.White
            Me.BackColor = Color.Black
            Me.ForeColor = Color.White
            Form1.Label1.ForeColor = Color.White
            Form1.Label2.ForeColor = Color.White
            Form1.Label3.ForeColor = Color.White
            Form1.Label4.ForeColor = Color.White
            Form1.Label5.ForeColor = Color.White
            Form1.Label6.ForeColor = Color.White
            Form1.CheckBox1.ForeColor = Color.White
            Form1.CheckBox2.ForeColor = Color.White
            Form1.CheckBox3.ForeColor = Color.White
            Form1.CheckBox4.ForeColor = Color.White
            Form1.CheckBox5.ForeColor = Color.White
            Form1.CheckBox6.ForeColor = Color.White
            Form1.CheckBox7.ForeColor = Color.White

        End If
        If ComboBox1.SelectedIndex = 1 Then
            Form1.BackgroundImage = My.Resources.background_Lain
            Me.BackColor = Color.White
            Me.ForeColor = Color.DarkGreen
            Form1.BackColor = Color.White
            Form1.ForeColor = Color.DarkGreen
            Form2.BackColor = Color.White
            Form2.ForeColor = Color.DarkGreen
            Form3.BackColor = Color.White
            Form3.ForeColor = Color.DarkGreen
            Form4.BackColor = Color.White
            Form4.ForeColor = Color.DarkGreen
            Form5.BackColor = Color.White
            Form5.ForeColor = Color.DarkGreen
            Form6.BackColor = Color.White
            Form6.ForeColor = Color.DarkGreen
            Form1.Label1.ForeColor = Color.DarkGreen
            Form1.Label2.ForeColor = Color.DarkGreen
            Form1.Label3.ForeColor = Color.DarkGreen
            Form1.Label4.ForeColor = Color.DarkGreen
            Form1.Label5.ForeColor = Color.DarkGreen
            Form1.Label6.ForeColor = Color.DarkGreen
            Form1.CheckBox1.ForeColor = Color.DarkGreen
            Form1.CheckBox2.ForeColor = Color.DarkGreen
            Form1.CheckBox3.ForeColor = Color.DarkGreen
            Form1.CheckBox4.ForeColor = Color.DarkGreen
            Form1.CheckBox5.ForeColor = Color.DarkGreen
            Form1.CheckBox6.ForeColor = Color.DarkGreen
            Form1.CheckBox7.ForeColor = Color.DarkGreen
            Form1.CheckBox1.ForeColor = Color.DarkGreen
            Form1.CheckBox2.ForeColor = Color.DarkGreen
            Form1.CheckBox3.ForeColor = Color.DarkGreen
            Form1.CheckBox4.ForeColor = Color.DarkGreen
            Form1.CheckBox5.ForeColor = Color.DarkGreen
            Form1.CheckBox6.ForeColor = Color.DarkGreen
            Form1.CheckBox7.ForeColor = Color.DarkGreen
            Form1.PictureBox1.BackColor = Color.Transparent
        End If
        If ComboBox1.SelectedIndex = 2 Then
            Form1.BackgroundImage = My.Resources.background_Steins_Gate
            Me.BackColor = Color.Black
            Me.ForeColor = Color.DarkOrange
            Form1.BackColor = Color.Black
            Form1.ForeColor = Color.DarkOrange
            Form2.BackColor = Color.Black
            Form2.ForeColor = Color.DarkOrange
            Form3.BackColor = Color.Black
            Form3.ForeColor = Color.DarkOrange
            Form4.BackColor = Color.Black
            Form4.ForeColor = Color.DarkOrange
            Form5.BackColor = Color.Black
            Form5.ForeColor = Color.DarkOrange
            Form6.BackColor = Color.Black
            Form6.ForeColor = Color.DarkOrange
            Form1.Label1.ForeColor = Color.DarkOrange
            Form1.Label2.ForeColor = Color.DarkOrange
            Form1.Label3.ForeColor = Color.DarkOrange
            Form1.Label4.ForeColor = Color.DarkOrange
            Form1.Label5.ForeColor = Color.DarkOrange
            Form1.Label6.ForeColor = Color.DarkOrange
            Form1.CheckBox1.ForeColor = Color.DarkOrange
            Form1.CheckBox2.ForeColor = Color.DarkOrange
            Form1.CheckBox3.ForeColor = Color.DarkOrange
            Form1.CheckBox4.ForeColor = Color.DarkOrange
            Form1.CheckBox5.ForeColor = Color.DarkOrange
            Form1.CheckBox6.ForeColor = Color.DarkOrange
            Form1.CheckBox7.ForeColor = Color.DarkOrange
            Form1.CheckBox1.ForeColor = Color.DarkOrange
            Form1.CheckBox2.ForeColor = Color.DarkOrange
            Form1.CheckBox3.ForeColor = Color.DarkOrange
            Form1.CheckBox4.ForeColor = Color.DarkOrange
            Form1.CheckBox5.ForeColor = Color.DarkOrange
            Form1.CheckBox6.ForeColor = Color.DarkOrange
            Form1.CheckBox7.ForeColor = Color.DarkOrange
            Form1.PictureBox1.BackColor = Color.Transparent
        End If
        If ComboBox1.SelectedIndex = 3 Then
            Form1.BackgroundImage = My.Resources.background_AkunoHana
            Me.BackColor = Color.Black
            Me.ForeColor = Color.DarkRed
            Form1.BackColor = Color.DarkGray
            Form1.ForeColor = Color.DarkRed
            Form2.BackColor = Color.DarkGray
            Form2.ForeColor = Color.DarkRed
            Form3.BackColor = Color.DarkGray
            Form3.ForeColor = Color.DarkRed
            Form4.BackColor = Color.DarkGray
            Form4.ForeColor = Color.DarkRed
            Form5.BackColor = Color.DarkGray
            Form5.ForeColor = Color.DarkRed
            Form6.BackColor = Color.DarkGray
            Form6.ForeColor = Color.DarkRed
            Form1.Label1.ForeColor = Color.DarkRed
            Form1.Label2.ForeColor = Color.DarkRed
            Form1.Label3.ForeColor = Color.DarkRed
            Form1.Label4.ForeColor = Color.DarkRed
            Form1.Label5.ForeColor = Color.DarkRed
            Form1.Label6.ForeColor = Color.DarkRed
            Form1.CheckBox1.ForeColor = Color.DarkRed
            Form1.CheckBox2.ForeColor = Color.DarkRed
            Form1.CheckBox3.ForeColor = Color.DarkRed
            Form1.CheckBox4.ForeColor = Color.DarkRed
            Form1.CheckBox5.ForeColor = Color.DarkRed
            Form1.CheckBox6.ForeColor = Color.DarkRed
            Form1.CheckBox7.ForeColor = Color.DarkRed
            Form1.CheckBox1.ForeColor = Color.DarkRed
            Form1.CheckBox2.ForeColor = Color.DarkRed
            Form1.CheckBox3.ForeColor = Color.DarkRed
            Form1.CheckBox4.ForeColor = Color.DarkRed
            Form1.CheckBox5.ForeColor = Color.DarkRed
            Form1.CheckBox6.ForeColor = Color.DarkRed
            Form1.CheckBox7.ForeColor = Color.DarkRed
            Form1.PictureBox1.BackColor = Color.Transparent
        End If
        If ComboBox1.SelectedIndex = 4 Then
            My.Settings.Reset()
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        If ComboBox3.SelectedIndex = 0 Then
            If ComboBox4.SelectedItem Is Nothing Then

            Else
                Form1.BackgroundImage = Image.FromFile(ComboBox4.SelectedItem.ToString)
                Label9.Text = "Main Window"
                Label10.Text = "Rec. Size (1089x541)"
                My.Settings.BckgrnImage = ComboBox4.SelectedItem.ToString
            End If
        End If
        If ComboBox3.SelectedIndex = 1 Then
            If ComboBox4.SelectedItem Is Nothing Then

            Else
                Form2.BackgroundImage = Image.FromFile(ComboBox4.SelectedItem.ToString)
                Label9.Text = "Instructions"
                Label10.Text = "Rec. Size (1132x866)"
                My.Settings.BckgrnImage2 = ComboBox4.SelectedItem.ToString
            End If
        End If
        If ComboBox3.SelectedIndex = 2 Then
            If ComboBox4.SelectedItem Is Nothing Then

            Else
                Form3.BackgroundImage = Image.FromFile(ComboBox4.SelectedItem.ToString)
                Label9.Text = "Bios Storing System"
                Label10.Text = "Rec. Size (1284x955)"
                My.Settings.BckgrnImage3 = ComboBox4.SelectedItem.ToString
            End If
        End If
        If ComboBox3.SelectedIndex = 3 Then
            If ComboBox4.SelectedItem Is Nothing Then

            Else
                Form4.BackgroundImage = Image.FromFile(ComboBox4.SelectedItem.ToString)
                Label9.Text = "Batch Images Order Mode"
                Label10.Text = "Rec. Size (1653x963)"
                My.Settings.BckgrnImage4 = ComboBox4.SelectedItem.ToString

            End If
        End If
        If ComboBox3.SelectedIndex = 4 Then
            If ComboBox4.SelectedItem Is Nothing Then

            Else
                Form5.BackgroundImage = Image.FromFile(ComboBox4.SelectedItem.ToString)
                Label9.Text = "Advance Cataloging Lists"
                Label10.Text = "Rec. Size (847x497)"
                My.Settings.BckgrnImage5 = ComboBox4.SelectedItem.ToString
            End If
        End If
        If ComboBox3.SelectedIndex = 5 Then
            If ComboBox4.SelectedItem Is Nothing Then

            Else
                Form6.BackgroundImage = Image.FromFile(ComboBox4.SelectedItem.ToString)
                Label9.Text = "Nomination System"
                Label10.Text = "Rec. Size (879x809)"
                My.Settings.BckgrnImage6 = ComboBox4.SelectedItem.ToString
            End If
        End If
        If ComboBox3.SelectedIndex = 6 Then
            If ComboBox4.SelectedItem Is Nothing Then

            Else
                Me.BackgroundImage = Image.FromFile(ComboBox4.SelectedItem.ToString)
                Label9.Text = "Admin Mode"
                Label10.Text = "Rec. Size (820x533)"
                My.Settings.BckgrnImage7 = ComboBox4.SelectedItem.ToString
            End If
        End If
        If ComboBox3.SelectedIndex = 7 Then
            If ComboBox4.SelectedItem Is Nothing Then

            Else
                Form8.BackgroundImage = Image.FromFile(ComboBox4.SelectedItem.ToString)
                Label9.Text = "OELs Wishlist System"
                Label10.Text = "Rec. Size (747x486)"
                My.Settings.BckgrnImage8 = ComboBox4.SelectedItem.ToString
            End If
        End If
        If ComboBox3.SelectedIndex = 8 Then
            If ComboBox4.SelectedItem Is Nothing Then

            Else
                Form12.BackgroundImage = Image.FromFile(ComboBox4.SelectedItem.ToString)
                Label9.Text = "AL Timer Calculator"
                Label10.Text = "Rec. Size (441x220)"
                My.Settings.BckgrnImage9 = ComboBox4.SelectedItem.ToString
            End If
        End If
        If ComboBox3.SelectedIndex = 9 Then
            If ComboBox4.SelectedItem Is Nothing Then

            Else
                Form11.BackgroundImage = Image.FromFile(ComboBox4.SelectedItem.ToString)
                Label9.Text = "Post Reminder"
                Label10.Text = "Rec. Size (698x439)"
                My.Settings.BckgrnImage10 = ComboBox4.SelectedItem.ToString
            End If
        End If
        If ComboBox3.SelectedIndex = 10 Then
            If ComboBox4.SelectedItem Is Nothing Then

            Else
                Form10.BackgroundImage = Image.FromFile(ComboBox4.SelectedItem.ToString)
                Label9.Text = "3x3 Grid Music Storing System"
                Label10.Text = "Rec. Size (852x332)"
                My.Settings.BckgrnImage11 = ComboBox4.SelectedItem.ToString
            End If
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        Button1.Visible = False
        If CheckBox3.Checked = True Then
            PictureBox1.Visible = False
            Label5.Visible = True
            TextBox1.Visible = True
            Button2.Visible = False
        Else CheckBox3.Checked = False
            PictureBox1.Visible = True
            Label5.Visible = False
            TextBox1.Visible = False
            Button2.Visible = False
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button1.Visible = True

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "I know what I'm doing" Then
            Button2.Visible = True
        Else
            Button2.Visible = False
            Button1.Visible = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim sfd As New OpenFileDialog()
        If sfd.ShowDialog = DialogResult.OK Then
            Path.GetFullPath(sfd.FileName)
            ComboBox4.Items.Add(sfd.FileName)
            Dim fl = Path.GetFileNameWithoutExtension(sfd.FileName)
            ComboBox2.Items.Add(fl.ToString)
        End If
    End Sub

    Private Sub Form7_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If ComboBox2.Items.Count > 0 Then
            My.Settings.cstname.Clear()
            For Each i As String In ComboBox2.Items
                My.Settings.cstname.Add(i)
            Next
            My.Settings.Save()
        Else
            If My.Settings.cstname IsNot Nothing Then
                My.Settings.cstname.Clear()
            End If
        End If
        If ComboBox4.Items.Count > 0 Then
            My.Settings.cstlink.Clear()
            For Each i As String In ComboBox4.Items
                My.Settings.cstlink.Add(i)
            Next
            My.Settings.Save()
        Else
            If My.Settings.cstlink IsNot Nothing Then
                My.Settings.cstlink.Clear()
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ComboBox4.Items.Clear()
        ComboBox2.Items.Clear()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        For i = 0 To ComboBox2.Items.Count
            If ComboBox2.SelectedIndex = (i) Then
                ComboBox4.SelectedIndex = (i)
            End If
        Next
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        Dim cmt As String
        cmt = ComboBox4.Text.ToString
        PictureBox1.ImageLocation = cmt
    End Sub

    Private Sub ComboBox7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox7.SelectedIndexChanged

    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox6.SelectedIndexChanged
        If ComboBox6.SelectedIndex = 0 Then
            Dim ms As New System.IO.MemoryStream(My.Resources._Android_Mix__Regular_Pointer)
            Me.Cursor = New Cursor(ms)
        End If
        If ComboBox6.SelectedIndex = 1 Then
            Dim ms As New System.IO.MemoryStream(My.Resources.normal)
            Me.Cursor = New Cursor(ms)
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ask As MsgBoxResult
        ask = MsgBox("Are you sure? Last chance!", MessageBoxButtons.YesNo)
        If ask = MsgBoxResult.Yes Then
            My.Settings.bannerfanart.Clear()
            My.Settings.profilehexcode.Clear()
            My.Settings.imagefanart.Clear()
            My.Settings.imageartwork.Clear()
            My.Settings.bannerdaily.Clear()
            My.Settings.bannerlink.Clear()
            My.Settings.bannerartwork.Clear()
            My.Settings.oelname.Clear()
            My.Settings.ppcurrentlink.Clear()
            My.Settings.oelmarket.Clear()
            My.Settings.oelprice.Clear()
            My.Settings.oelink.Clear()
            My.Settings.cstlink.Clear()
            My.Settings.cstname.Clear()
            My.Settings.biosnames.Clear()
            My.Settings.buttonnames.Clear()
            My.Settings.biositems.Clear()
            My.Settings.imagelink.Clear()
            My.Settings.imagedaily.Clear()
            My.Settings.userlist.Clear()
            My.Settings.comboitems.Clear()
            My.Settings.oelcover.Clear()
            My.Settings.SPcover.Clear()
            My.Settings.SPlink.Clear()
            My.Settings.SPname.Clear()
            MsgBox("All Cleared!", MessageBoxButtons.OK)
        Else
            ask = MsgBoxResult.No
            MsgBox("Nothing deleted", MessageBoxButtons.OK)
        End If
    End Sub
End Class