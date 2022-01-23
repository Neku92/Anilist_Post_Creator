<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form10
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
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(414, 364)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(171, 56)
        Me.Button5.TabIndex = 69
        Me.Button5.Text = "Add selected song"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 20)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Song's name"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(25, 110)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(230, 26)
        Me.TextBox7.TabIndex = 67
        '
        'ComboBox4
        '
        Me.ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(25, 26)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(241, 28)
        Me.ComboBox4.TabIndex = 66
        Me.ComboBox4.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(378, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(171, 20)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Current Song Selected"
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(382, 26)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(241, 28)
        Me.ComboBox3.TabIndex = 64
        Me.ComboBox3.Visible = False
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(382, 110)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(241, 28)
        Me.ComboBox2.TabIndex = 63
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 20)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "CD's song cover image"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(25, 181)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(230, 26)
        Me.TextBox5.TabIndex = 61
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(382, 144)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(250, 214)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 60
        Me.PictureBox1.TabStop = False
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(44, 362)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(194, 36)
        Me.Button7.TabIndex = 59
        Me.Button7.Text = "Remove song"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 227)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 20)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Spotify song's link"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(44, 299)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(194, 36)
        Me.Button6.TabIndex = 57
        Me.Button6.Text = "Add new song"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(25, 250)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(230, 26)
        Me.TextBox6.TabIndex = 56
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(699, 27)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(531, 393)
        Me.TextBox1.TabIndex = 70
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(435, 423)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 20)
        Me.Label1.TabIndex = 71
        Me.Label1.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(605, 382)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 20)
        Me.Label6.TabIndex = 72
        Me.Label6.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(25, 415)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(157, 24)
        Me.CheckBox1.TabIndex = 73
        Me.CheckBox1.Text = "List Editing Mode"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1254, 451)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.TextBox6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form10"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "3x3 Embedded Music Storing System"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button5 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CheckBox1 As CheckBox
End Class
