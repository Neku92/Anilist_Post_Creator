<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 1128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bios List Code"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(37, 1185)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(368, 28)
        Me.ComboBox1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(733, 547)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1111, 809)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(388, 501)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(215, 42)
        Me.Button7.TabIndex = 39
        Me.Button7.Text = "Remove Current Theme"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 512)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 20)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Theme's code here"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(388, 637)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(215, 42)
        Me.Button6.TabIndex = 37
        Me.Button6.Text = "Add new theme"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(37, 535)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(230, 26)
        Me.TextBox3.TabIndex = 36
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(37, 338)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(157, 24)
        Me.CheckBox1.TabIndex = 35
        Me.CheckBox1.Text = "List Editing Mode"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(37, 653)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(230, 26)
        Me.TextBox1.TabIndex = 40
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 630)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 20)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Theme screenshot link"
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(347, 1370)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(368, 28)
        Me.ComboBox2.TabIndex = 42
        Me.ComboBox2.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(388, 283)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(215, 42)
        Me.Button1.TabIndex = 43
        Me.Button1.Text = "Copy this Code"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(37, 417)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(230, 26)
        Me.TextBox2.TabIndex = 44
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 394)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 20)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Theme's name here"
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(37, 221)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(368, 28)
        Me.ComboBox3.TabIndex = 46
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(31, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(203, 32)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Current Theme"
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(733, 140)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(712, 267)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 48
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Location = New System.Drawing.Point(1511, 140)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(333, 267)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 49
        Me.PictureBox3.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 727)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 20)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Profile banner"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(37, 749)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(230, 26)
        Me.TextBox4.TabIndex = 50
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(33, 835)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(233, 20)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "Theme's current's profile picture"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(37, 857)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(230, 26)
        Me.TextBox5.TabIndex = 52
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(33, 946)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(219, 20)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "Theme's name/hex color code"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(37, 968)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(230, 26)
        Me.TextBox6.TabIndex = 54
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(729, 117)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 20)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "Profile Banner"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(729, 523)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(122, 20)
        Me.Label10.TabIndex = 57
        Me.Label10.Text = "Theme selected"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(1507, 117)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 20)
        Me.Label11.TabIndex = 58
        Me.Label11.Text = "Profile Picture"
        '
        'ComboBox4
        '
        Me.ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(317, 789)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(368, 28)
        Me.ComboBox4.TabIndex = 59
        Me.ComboBox4.Visible = False
        '
        'ComboBox5
        '
        Me.ComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(317, 897)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(368, 28)
        Me.ComboBox5.TabIndex = 60
        Me.ComboBox5.Visible = False
        '
        'ComboBox6
        '
        Me.ComboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Location = New System.Drawing.Point(37, 1297)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(368, 28)
        Me.ComboBox6.TabIndex = 61
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(388, 355)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(215, 42)
        Me.Button2.TabIndex = 62
        Me.Button2.Text = "Copy Color Hex Code"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(37, 1246)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(277, 32)
        Me.Label12.TabIndex = 63
        Me.Label12.Text = "Bios Color Hex Code"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(388, 741)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(215, 42)
        Me.Button4.TabIndex = 65
        Me.Button4.Text = "Recovery Profile Banner"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(388, 849)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(215, 42)
        Me.Button5.TabIndex = 66
        Me.Button5.Text = "Recovery Profile Picture"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(1247, 465)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(80, 36)
        Me.Button8.TabIndex = 70
        Me.Button8.Text = "Size"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(1113, 473)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(20, 20)
        Me.Label13.TabIndex = 69
        Me.Label13.Text = "X"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(1172, 473)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(24, 20)
        Me.Label14.TabIndex = 68
        Me.Label14.Text = "---"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(1034, 473)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(24, 20)
        Me.Label15.TabIndex = 67
        Me.Label15.Text = "---"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1902, 1410)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ComboBox6)
        Me.Controls.Add(Me.ComboBox5)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bios Storing System"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
End Class
