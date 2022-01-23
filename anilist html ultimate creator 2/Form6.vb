Imports System.ComponentModel

Public Class Form6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tempArray As String()
        tempArray = TextBox1.Lines
        For Each i As String In tempArray
            ListBox1.Items.Add(i)
        Next
        TextBox1.Clear()
        If ListBox1.Items.Count > 0 Then
            My.Settings.userlist.Clear()
            For Each i As String In ListBox1.Items
                My.Settings.userlist.Add(i)
            Next
            My.Settings.Save()
        Else
            My.Settings.userlist.Clear()
        End If
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.userlist IsNot Nothing Then
            For Each i As String In My.Settings.userlist
                ListBox1.Items.Add(i)
            Next
        Else
            My.Settings.userlist = New System.Collections.Specialized.StringCollection
        End If
        If My.Settings.bannerdaily Is Nothing Then
            Button4.Enabled = False

        ElseIf My.Settings.bannerdaily IsNot Nothing Then
            Button4.Enabled = True
        End If
        Try
            Me.BackgroundImage = Image.FromFile(My.Settings.BckgrnImage6.ToString)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Form6_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If ListBox1.Items.Count > 0 Then
            My.Settings.userlist.Clear()
            For Each i As String In ListBox1.Items
                My.Settings.userlist.Add(i)
            Next
            My.Settings.Save()
        Else
            My.Settings.userlist.Clear()
        End If

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim user As String
        user = ListBox1.SelectedItem.ToString
        For Each user In ListBox1.SelectedItems
            TextBox2.Text += " @" + user + " "
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Dim items = From it In ListBox1.Items.Cast(Of Object)()
                    Where it.ToString().IndexOf(TextBox3.Text, StringComparison.CurrentCultureIgnoreCase) >= 0
        Dim matchingItemList As List(Of Object) = items.ToList()
        ListBox1.BeginUpdate()
        ListBox1.Items.Clear()
        For Each item In matchingItemList
            ListBox1.Items.Add(item)
        Next
        If String.IsNullOrEmpty(TextBox3.Text) Then
            ListBox1.Items.Clear()
            For Each i In My.Settings.userlist
                ListBox1.Items.Add(i)
            Next
        End If
        ListBox1.EndUpdate()
    End Sub



    Dim cLeft As Integer = 1
    Public Function AddNewTextBox() As System.Windows.Forms.TextBox
        Dim txt As New System.Windows.Forms.TextBox()
        Dim cbx As New System.Windows.Forms.ComboBox()
        GroupBox1.Controls.Add(txt)
        GroupBox1.Controls.Add(cbx)
        cbx.Top = cLeft * 50
        cbx.Left = 140
        cbx.DropDownStyle = ComboBoxStyle.DropDownList
        txt.Top = cLeft * 50
        txt.Left = 20
        For Each i As String In My.Settings.bannerdaily
            cbx.Items.Add(i)
        Next
        For Each i As String In My.Settings.imagedaily
            ComboBox1.Items.Add(i)
        Next
        If cLeft = 0 Then
        End If
        If cLeft = 1 Then
            txt.Text = "(" & Me.cLeft.ToString & "st)"
            AddHandler cbx.SelectedIndexChanged, AddressOf Cbx_selectedindexchanged
        End If
        If cLeft = 2 Then
            txt.Text = "(" & Me.cLeft.ToString & "nd)"
            AddHandler cbx.SelectedIndexChanged, AddressOf Cbx_selectedindexchanged
        End If
        If cLeft = 3 Then
            txt.Text = "(" & Me.cLeft.ToString & "rd)"
            AddHandler cbx.SelectedIndexChanged, AddressOf Cbx_selectedindexchanged
        End If
        If cLeft >= 4 Then
            txt.Text = "(" & Me.cLeft.ToString & "th)"
            AddHandler cbx.SelectedIndexChanged, AddressOf Cbx_selectedindexchanged
        End If
        cLeft += 1
        Return txt
    End Function
    Public Sub Cbx_selectedindexchanged(sender As System.Object, ByVal e As System.EventArgs)
        Dim cbx As New ComboBox
        cbx = CType(sender, ComboBox)
        For i = 0 To cbx.Items.Count
            If cbx.SelectedIndex = (i) Then
                ComboBox1.SelectedIndex = (i)
            End If
        Next
        TextBox4.Text += "~~~" & vbCrLf
        TextBox4.Text += "img( " & ComboBox1.SelectedItem.ToString & ")" & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf
        TextBox4.Text += "~~~" & vbCrLf
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cLeft = 1
        For Each item As Control In GroupBox1.Controls
            GroupBox1.Controls.Clear()
        Next
        TextBox4.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox4.Visible = True
        AddNewTextBox()
    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Form10.Show()
        CheckBox1.Enabled = False

    End Sub
End Class
'