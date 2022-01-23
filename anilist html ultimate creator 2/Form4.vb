Imports System.Threading
Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.imagefanart IsNot Nothing Then
            For Each i As String In My.Settings.imagefanart
                ComboBox2.Items.Add(i)
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
                ComboBox5.Items.Add(i)
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
                ComboBox6.Items.Add(i)
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
        Try
            Me.BackgroundImage = Image.FromFile(My.Settings.BckgrnImage4.ToString)
        Catch ex As Exception
        End Try
        Button4.Enabled = False
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        For i = 0 To ComboBox1.Items.Count
            If ComboBox1.SelectedIndex = (i) Then
                ComboBox2.SelectedIndex = (i)
            End If
        Next
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim cmt As String
        cmt = ComboBox2.Text.ToString
        PictureBox2.ImageLocation = cmt
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tempArray As String()
        Dim tempArray2 As String()
        Dim cbname As String
        Dim cbname2 As String
        cbname = ComboBox2.Text.ToString
        cbname2 = "~~~img" & "(" & cbname & ") ]"
        tempArray = TextBox1.Lines
        tempArray2 = TextBox2.Lines
        For counter = 0 To tempArray.Length - 1
            If counter = 0 Then
                tempArray(0) = cbname2 & vbCrLf & "[img" & "(" & tempArray(counter) & ") ]" & "(" & tempArray2(counter) & ")"
            ElseIf counter >= 1 Then
                tempArray(counter) = "[img" & "(" & tempArray(counter) & ") ]" & "(" & tempArray2(counter) & ")"
            End If
        Next
        TextBox1.Lines = tempArray
        TextBox2.Lines = tempArray2
        TextBox1.Text += vbCrLf & " ~~~"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim tempArray As String()
        Dim tempArray2 As String()
        Dim cbname As String
        Dim cbname2 As String
        cbname = ComboBox5.Text.ToString
        cbname2 = "~~~img" & "(" & cbname & ") ]"
        tempArray = TextBox4.Lines
        tempArray2 = TextBox3.Lines
        For counter = 0 To tempArray.Length - 1
            If counter = 0 Then
                tempArray(0) = cbname2 & vbCrLf & "[img" & "(" & tempArray(counter) & ") ]" & "(" & tempArray2(counter) & ")"
            ElseIf counter >= 1 Then
                tempArray(counter) = "[img" & "(" & tempArray(counter) & ") ]" & "(" & tempArray2(counter) & ")"
            End If
        Next
        TextBox4.Lines = tempArray
        TextBox3.Lines = tempArray2
        TextBox4.Text += vbCrLf & " ~~~"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim tempArray As String()
        Dim tempArray2 As String()
        Dim cbname As String
        Dim cbname2 As String
        cbname = ComboBox6.Text.ToString
        cbname2 = "~~~img" & "(" & cbname & ") ]"
        tempArray = TextBox6.Lines
        tempArray2 = TextBox5.Lines
        For counter = 0 To tempArray.Length - 1
            If counter = 0 Then
                tempArray(0) = cbname2 & vbCrLf & "[img" & "(" & tempArray(counter) & ") ]" & "(" & tempArray2(counter) & ")"
            ElseIf counter >= 1 Then
                tempArray(counter) = "[img" & "(" & tempArray(counter) & ") ]" & "(" & tempArray2(counter) & ")"
            End If
        Next
        TextBox6.Lines = tempArray
        TextBox5.Lines = tempArray2
        TextBox6.Text += vbCrLf & " ~~~"
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        For i = 0 To ComboBox3.Items.Count
            If ComboBox3.SelectedIndex = (i) Then
                ComboBox5.SelectedIndex = (i)
            End If
        Next
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged
        Dim cmt As String
        cmt = ComboBox5.Text.ToString
        PictureBox3.ImageLocation = cmt
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        For i = 0 To ComboBox6.Items.Count
            If ComboBox6.SelectedIndex = (i) Then
                ComboBox5.SelectedIndex = (i)
            End If
        Next
    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox6.SelectedIndexChanged
        Dim cmt As String
        cmt = ComboBox6.Text.ToString
        PictureBox4.ImageLocation = cmt
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim lstbox As String
        lstbox = ListBox1.SelectedItem.ToString
        PictureBox1.ImageLocation = lstbox
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        ListBox1.Items.Clear()
        Dim tempArray As String()
        tempArray = TextBox1.Lines
        For Each i As String In tempArray
            ListBox1.Items.Add(i)
        Next
        If RadioButton1.Checked = True OrElse RadioButton2.Checked = True OrElse RadioButton3.Checked = True Then
            CheckBox1.Visible = True
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
        Else
            CheckBox1.Visible = False
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        ListBox1.Items.Clear()
        Dim tempArray As String()
        tempArray = TextBox4.Lines
        For Each i As String In tempArray
            ListBox1.Items.Add(i)
        Next
        If RadioButton1.Checked = True OrElse RadioButton2.Checked = True OrElse RadioButton3.Checked = True Then
            CheckBox1.Visible = True
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
        Else
            CheckBox1.Visible = False
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        ListBox1.Items.Clear()
        Dim tempArray As String()
        tempArray = TextBox6.Lines
        For Each i As String In tempArray
            ListBox1.Items.Add(i)
        Next
        If RadioButton1.Checked = True OrElse RadioButton2.Checked = True OrElse RadioButton3.Checked = True Then
            CheckBox1.Visible = True
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
        Else
            CheckBox1.Visible = False
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim fntext As String = TextBox1.Text.ToString
        Dim artext As String = TextBox4.Text.ToString
        Dim dltext As String = TextBox6.Text.ToString
        If CheckBox3.Checked = True Then
            TextBox7.Text += fntext & vbCrLf
        End If
        If CheckBox3.Checked = False Then

        End If
        If CheckBox4.Checked = True Then
            TextBox7.Text += artext & vbCrLf
        End If
        If CheckBox4.Checked = False Then

        End If
        If CheckBox5.Checked = True Then
            TextBox7.Text += dltext & vbCrLf
        End If
        If CheckBox5.Checked = False Then

        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
        Else
            If CheckBox1.Checked = True Then
                Button1.Enabled = True
                Button2.Enabled = True
                Button3.Enabled = True
            End If
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True OrElse CheckBox4.Checked = True OrElse CheckBox5.Checked = True Then
            Button4.Enabled = True
        Else
            Button4.Enabled = False
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox3.Checked = True OrElse CheckBox4.Checked = True OrElse CheckBox5.Checked = True Then
            Button4.Enabled = True
        Else
            Button4.Enabled = False
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox3.Checked = True OrElse CheckBox4.Checked = True OrElse CheckBox5.Checked = True Then
            Button4.Enabled = True
        Else
            Button4.Enabled = False
        End If
    End Sub
End Class