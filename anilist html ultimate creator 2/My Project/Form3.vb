Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.biositems IsNot Nothing Then
            For Each i As String In My.Settings.biositems
                ComboBox1.Items.Add(i)
            Next
        Else
            My.Settings.biositems = New System.Collections.Specialized.StringCollection
        End If
        If My.Settings.imagelink IsNot Nothing Then
            For Each i As String In My.Settings.imagelink
                ComboBox2.Items.Add(i)
            Next
        Else
            My.Settings.imagelink = New System.Collections.Specialized.StringCollection
        End If
        If My.Settings.biosnames IsNot Nothing Then
            For Each i As String In My.Settings.biosnames
                ComboBox3.Items.Add(i)
            Next
        Else
            My.Settings.biosnames = New System.Collections.Specialized.StringCollection
        End If
        If My.Settings.bannerlink IsNot Nothing Then
            For Each i As String In My.Settings.bannerlink
                ComboBox4.Items.Add(i)
            Next
        Else
            My.Settings.bannerlink = New System.Collections.Specialized.StringCollection
        End If
        If My.Settings.ppcurrentlink IsNot Nothing Then
            For Each i As String In My.Settings.ppcurrentlink
                ComboBox5.Items.Add(i)
            Next
        Else
            My.Settings.ppcurrentlink = New System.Collections.Specialized.StringCollection
        End If
        If My.Settings.profilehexcode IsNot Nothing Then
            For Each i As String In My.Settings.profilehexcode
                ComboBox6.Items.Add(i)
            Next
        Else
            My.Settings.profilehexcode = New System.Collections.Specialized.StringCollection
        End If
        Try
            Me.BackgroundImage = Image.FromFile(My.Settings.BckgrnImage3.ToString)
        Catch ex As Exception
        End Try
        If ComboBox3.Items.Count = 0 Then
            Button4.Enabled = False
            Button5.Enabled = False
            Button1.Enabled = False
            Button2.Enabled = False
        End If
        Button6.Enabled = False
        Button7.Enabled = False
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Button7.Enabled = True
        Else
            Button7.Enabled = False
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ComboBox1.Items.Add(TextBox3.Text$)
        ComboBox2.Items.Add(TextBox1.Text$)
        ComboBox3.Items.Add(TextBox2.Text$)
        ComboBox4.Items.Add(TextBox4.Text$)
        ComboBox5.Items.Add(TextBox5.Text$)
        ComboBox6.Items.Add(TextBox6.Text$)
        TextBox3.Clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
    End Sub

    Private Sub Form3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If ComboBox1.Items.Count > 0 Then
            My.Settings.biositems.Clear()
            For Each i As String In ComboBox1.Items
                My.Settings.biositems.Add(i)
            Next
            My.Settings.Save()
        Else
            My.Settings.biositems.Clear()
        End If
        If ComboBox2.Items.Count > 0 Then
            My.Settings.imagelink.Clear()
            For Each i As String In ComboBox2.Items
                My.Settings.imagelink.Add(i)
            Next
            My.Settings.Save()
        Else
            My.Settings.imagelink.Clear()
        End If
        If ComboBox3.Items.Count > 0 Then
            My.Settings.biosnames.Clear()
            For Each i As String In ComboBox3.Items
                My.Settings.biosnames.Add(i)
            Next
            My.Settings.Save()
        Else
            My.Settings.biosnames.Clear()
        End If
        If ComboBox4.Items.Count > 0 Then
            My.Settings.bannerlink.Clear()
            For Each i As String In ComboBox4.Items
                My.Settings.bannerlink.Add(i)
            Next
            My.Settings.Save()
        Else
            My.Settings.bannerlink.Clear()
        End If
        If ComboBox5.Items.Count > 0 Then
            My.Settings.ppcurrentlink.Clear()
            For Each i As String In ComboBox5.Items
                My.Settings.ppcurrentlink.Add(i)
            Next
            My.Settings.Save()
        Else
            My.Settings.ppcurrentlink.Clear()
        End If
        If ComboBox6.Items.Count > 0 Then
            My.Settings.profilehexcode.Clear()
            For Each i As String In ComboBox6.Items
                My.Settings.profilehexcode.Add(i)
            Next
            My.Settings.Save()
        Else
            My.Settings.profilehexcode.Clear()
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ComboBox1.Items.Remove(ComboBox1.SelectedItem)
        ComboBox2.Items.Remove(ComboBox2.SelectedItem)
        ComboBox3.Items.Remove(ComboBox3.SelectedItem)
        ComboBox4.Items.Remove(ComboBox4.SelectedItem)
        ComboBox5.Items.Remove(ComboBox5.SelectedItem)
        ComboBox6.Items.Remove(ComboBox6.SelectedItem)
        If ComboBox3.Items.Count = 0 Then
            Button4.Enabled = False
            Button5.Enabled = False
            Button1.Enabled = False
            Button2.Enabled = False
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Clipboard.SetText(ComboBox1.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Clipboard.SetText(ComboBox6.Text)
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        For i = 0 To ComboBox3.Items.Count
            If ComboBox3.SelectedIndex = (i) Then
                ComboBox1.SelectedIndex = (i)
                ComboBox2.SelectedIndex = (i)
                ComboBox4.SelectedIndex = (i)
                ComboBox5.SelectedIndex = (i)
                ComboBox6.SelectedIndex = (i)
            End If
        Next
        Dim cmt2 As String
        cmt2 = ComboBox2.Text.ToString
        PictureBox1.ImageLocation = cmt2
        Dim cmt4 As String
        cmt4 = ComboBox4.Text.ToString
        PictureBox2.ImageLocation = cmt4
        Dim cmt5 As String
        cmt5 = ComboBox5.Text.ToString
        PictureBox3.ImageLocation = cmt5
        If ComboBox3.Items.Count >= 1 Then
            Button4.Enabled = True
            Button5.Enabled = True
            Button1.Enabled = True
            Button2.Enabled = True
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Clipboard.SetText(ComboBox4.SelectedItem)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Clipboard.SetText(ComboBox5.SelectedItem)
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        If String.IsNullOrEmpty(TextBox2.Text) Then
            Button6.Enabled = False
        Else
            Button6.Enabled = True
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Label15.Text = Me.Width
        Label14.Text = Me.Height
    End Sub
End Class