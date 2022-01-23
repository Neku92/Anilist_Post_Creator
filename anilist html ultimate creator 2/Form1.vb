
Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim tempArray As String()
        tempArray = TextBox1.Lines
        For counter = 0 To tempArray.Length - 1
            If CheckBox6.Checked = True Then
                tempArray(counter) = "~!" & "youtube" & "(" & tempArray(counter) & ")" & "!~"
            Else
                tempArray(counter) = "youtube" & "(" & tempArray(counter) & ")"
            End If
        Next
        TextBox1.Lines = tempArray
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton4.Checked = True Then
            CheckBox2.Enabled = True
        Else
            If RadioButton3.Checked = True Then
                CheckBox2.Enabled = False
                CheckBox2.Checked = False
            End If
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim tempArray As String()
        tempArray = TextBox1.Lines
        For counter = 0 To tempArray.Length - 1
            If CheckBox2.Checked = True Then
                Dim cstmn As String
                cstmn = InputBox(tempArray(counter) & "Name to give to the link")
                tempArray(counter) = "[" & cstmn & " ]" & "(" & tempArray(counter) & ")"
            Else
                tempArray(counter) = "[link ]" & "(" & tempArray(counter) & ")"
            End If
        Next

        TextBox1.Lines = tempArray
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim tempArray As String()
        tempArray = TextBox1.Lines
        For counter = 0 To tempArray.Length - 1
            tempArray(counter) = "img" & "(" & tempArray(counter) & ")"
            If CheckBox5.Checked = True Then
                Dim Auth As String
                Auth = InputBox(tempArray(counter) & "Author")
                tempArray(counter) = tempArray(counter) & vbCrLf & "Author : " & Auth
            Else
            End If
        Next
        TextBox1.Lines = tempArray
    End Sub

    Public Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim tempArray As String()
        Dim tempArray2 As String()
        tempArray = TextBox1.Lines
        tempArray2 = TextBox2.Lines
        If CheckBox4.Checked = True Then
            Form4.Show()
        End If
        For counter = 0 To tempArray.Length - 1
            tempArray(counter) = "[img" & "(" & tempArray(counter) & ") ]" & "(" & tempArray2(counter) & ")"
            If String.IsNullOrEmpty(tempArray2(counter)) Then
            End If
        Next
        TextBox1.Lines = tempArray
        TextBox2.Lines = tempArray2
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tempArray As String()
        Dim cbname As String
        Dim cbname2 As String
        cbname = ComboBox1.Text.ToString
        cbname2 = "~~~img" & "(" & cbname & ")"
        tempArray = TextBox1.Lines
        For counter = 0 To tempArray.Length - 1
            If counter = 0 Then
                tempArray(0) = cbname2 & vbCrLf & "~!" & "img(" & tempArray(counter) & ")"
            ElseIf counter = 1 Then
                tempArray(1) = "img(" & tempArray(counter) & ")"
            ElseIf counter >= 2 Then
                tempArray(counter) = "img(" & tempArray(counter) & ")"
            End If
        Next
        TextBox2.Lines = tempArray
        TextBox2.Text += vbCrLf & "!~" & " ~~~"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ComboBox1.Items.Add(TextBox3.Text$)
        ComboBox2.Items.Add(TextBox4.Text$)
        TextBox3.Clear()
        TextBox4.Clear()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If ComboBox1.Items.Count > 0 Then
            My.Settings.comboitems.Clear()
            For Each i As String In ComboBox1.Items
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
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.comboitems IsNot Nothing Then
            For Each i As String In My.Settings.comboitems
                ComboBox1.Items.Add(i)
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
        If My.Settings.postname IsNot Nothing Then
            For Each i As String In My.Settings.postname
                Combobox3.Items.Add(i)
            Next
        Else
            My.Settings.postname = New System.Collections.Specialized.StringCollection
        End If
        If My.Settings.postday IsNot Nothing Then
            For Each i As String In My.Settings.postday
                ComboBox4.Items.Add(i)
            Next
        Else
            My.Settings.postday = New System.Collections.Specialized.StringCollection
        End If
        If My.Settings.postdate IsNot Nothing Then
            For Each i As String In My.Settings.postdate
                ComboBox5.Items.Add(i)
            Next
        Else
            My.Settings.postdate = New System.Collections.Specialized.StringCollection
        End If
        Try
            Me.BackgroundImage = Image.FromFile(My.Settings.BckgrnImage.ToString)
        Catch ex As Exception
        End Try
        Button7.Enabled = False
        Button6.Enabled = False
        CheckBox2.Enabled = False
        CheckBox5.Enabled = False
        CheckBox6.Enabled = False
        TextBox2.Enabled = False
        Button1.Enabled = False
        Button4.Enabled = False
        Button3.Enabled = True
        Button2.Enabled = True
        Button5.Enabled = True
        RadioButton6.Enabled = True
        RadioButton5.Enabled = True
        RadioButton10.Enabled = True
        RadioButton9.Enabled = True
        RadioButton4.Enabled = True
        RadioButton3.Enabled = True
        CheckBox5.Enabled = True
        CheckBox6.Enabled = True
        CheckBox2.Enabled = True
        CheckBox4.Enabled = False
        CheckBox7.Enabled = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ComboBox1.Items.Remove(ComboBox1.SelectedItem)
        ComboBox2.Items.Remove(ComboBox2.SelectedItem)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Button7.Enabled = True
            Button6.Enabled = True
            CheckBox7.Enabled = True
        Else
            Button7.Enabled = False
            Button6.Enabled = False
            CheckBox7.Enabled = False
        End If
    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged
        If RadioButton10.Checked = True Then
            CheckBox6.Enabled = True
        Else
            If RadioButton9.Checked = True Then
                CheckBox6.Enabled = False
                CheckBox6.Checked = False
            End If
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked = True Then
            CheckBox5.Enabled = True
        Else
            If RadioButton5.Checked = True Then
                CheckBox5.Enabled = False
                CheckBox5.Checked = False
            End If
        End If
    End Sub

    Private Sub InstructionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstructionsToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim cmt As String
        cmt = ComboBox1.Text.ToString
        PictureBox1.ImageLocation = cmt
    End Sub

    Private Sub BiosStoringSystemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BiosStoringSystemToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        For i = 0 To ComboBox2.Items.Count
            If ComboBox2.SelectedIndex = (i) Then
                ComboBox1.SelectedIndex = (i)
            End If
        Next
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            TextBox2.Enabled = True
            Button1.Enabled = True
            Button4.Enabled = True
            Button3.Enabled = False
            Button2.Enabled = False
            Button5.Enabled = False
            RadioButton6.Enabled = False
            RadioButton5.Enabled = False
            RadioButton10.Enabled = False
            RadioButton9.Enabled = False
            RadioButton4.Enabled = False
            RadioButton3.Enabled = False
            CheckBox5.Enabled = False
            CheckBox6.Enabled = False
            CheckBox2.Enabled = False
            CheckBox4.Enabled = True
        Else
            TextBox2.Enabled = False
            Button1.Enabled = False
            Button4.Enabled = False
            Button3.Enabled = True
            Button2.Enabled = True
            Button5.Enabled = True
            RadioButton6.Enabled = True
            RadioButton5.Enabled = True
            RadioButton10.Enabled = True
            RadioButton9.Enabled = True
            RadioButton4.Enabled = True
            RadioButton3.Enabled = True
            CheckBox5.Enabled = True
            CheckBox6.Enabled = True
            CheckBox2.Enabled = True
            CheckBox4.Enabled = False
        End If
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        Form5.Show()
    End Sub

    Private Sub NominationSystemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NominationSystemToolStripMenuItem.Click
        Form6.Show()
    End Sub

    Private Sub AdminModeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminModeToolStripMenuItem.Click
        Form7.Show()
    End Sub

    Private Sub OELsWishlistToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OELsWishlistToolStripMenuItem.Click
        Form8.Show()
    End Sub

    Private Sub ALTimerCalculatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ALTimerCalculatorToolStripMenuItem.Click
        Form12.Show()
    End Sub

    Private Sub PostReminderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PostReminderToolStripMenuItem.Click
        Form11.Show()
    End Sub

    Const maxVal As Integer = 30
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Dim value As Integer = maxVal
            If Not IsNumeric(Label10.Text) Then
                Label10.Text = maxVal.ToString
            End If
            Integer.TryParse(Label10.Text, value)
            If value >= 1 And value <= maxVal Then
                value -= 1
                Label10.Text = value.ToString
            Else
                If value <= 0 Then
                    Timer1.Stop()
                    Label10.Text = maxVal.ToString
                    For i As Integer = 0 To ComboBox4.Items.Count - 1
                        ComboBox3.SelectedIndex = i
                        Dim d As DateTime = DateTime.Now
                        Dim parsedate As DateTime = ComboBox5.Items(i).ToString
                        Dim d2 As DateTime = DateTime.ParseExact(parsedate, "dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.CurrentCulture)
                        Dim ts As New TimeSpan((d - d2).Ticks)
                        Dim dysdiff As Integer = ts.TotalDays
                        Dim cbNum As Integer = 365 - dysdiff
                        ComboBox4.Items(i) = cbNum.ToString
                        Dim lstname As String = ComboBox3.Items(i).ToString()
                        If cbNum <= 5 AndAlso cbNum >= 1 Then
                            NotifyIcon1.ShowBalloonTip(3000, "Anilist Post Creator", lstname & " have " & cbNum & " days left before will get delete", ToolTipIcon.None)
                        End If
                    Next
                    If ComboBox5.Items.Count > 0 Then
                        My.Settings.postdate.Clear()
                        For Each i As String In ComboBox5.Items
                            My.Settings.postdate.Add(i)
                        Next
                        My.Settings.Save()
                    Else
                        My.Settings.postdate.Clear()
                    End If
                    If ComboBox4.Items.Count > 0 Then
                        My.Settings.postday.Clear()
                        For Each i As String In ComboBox4.Items
                            My.Settings.postday.Add(i)
                        Next
                        My.Settings.Save()
                    Else
                        My.Settings.postday.Clear()
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

End Class