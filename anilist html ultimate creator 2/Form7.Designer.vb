<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form7
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.ComboBox7 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(874, 635)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(320, 89)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "ERASE ALL DATA"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Change Theme Pack:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Dark", "Lain", "Steins;Gate", "Aku no Hana", "Light"})
        Me.ComboBox1.Location = New System.Drawing.Point(35, 150)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(227, 28)
        Me.ComboBox1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 262)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(276, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Change Background On:"
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(35, 422)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(227, 28)
        Me.ComboBox2.TabIndex = 4
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"Main Window", "Instructions", "Bios Storing System", "Batch Images Order Mode", "Advance Cataloging lists", "Nomination System", "Admin Mode", "OELs Wishlist System", "AL Timer Calculator", "Post Reminder", "Batch Image Order Mode", "Advance Cataloging Lists", "3x3 Grid Music Storing System"})
        Me.ComboBox3.Location = New System.Drawing.Point(35, 325)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(227, 28)
        Me.ComboBox3.TabIndex = 5
        '
        'ComboBox4
        '
        Me.ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(549, 16)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(158, 28)
        Me.ComboBox4.TabIndex = 8
        Me.ComboBox4.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 527)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(364, 29)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Load Custom Backgroud Picture:"
        '
        'ComboBox6
        '
        Me.ComboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Items.AddRange(New Object() {"cursor1", "cursor2"})
        Me.ComboBox6.Location = New System.Drawing.Point(439, 150)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(227, 28)
        Me.ComboBox6.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(434, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(181, 29)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Change Cursor:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(612, 433)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(582, 29)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Put ""I know what I'm doing"" to enable the erase button"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(684, 525)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(389, 26)
        Me.TextBox1.TabIndex = 12
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1079, 515)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(115, 41)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Validate"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(910, 150)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(257, 33)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "Enable theme music"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(892, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(168, 29)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Extra Features"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(910, 221)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(242, 33)
        Me.CheckBox2.TabIndex = 15
        Me.CheckBox2.Text = "Enable theme SFX"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Enabled = False
        Me.CheckBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox3.Location = New System.Drawing.Point(910, 302)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(272, 33)
        Me.CheckBox3.TabIndex = 16
        Me.CheckBox3.Text = "Enable Sharing Mode"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'ComboBox7
        '
        Me.ComboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox7.FormattingEnabled = True
        Me.ComboBox7.Location = New System.Drawing.Point(439, 325)
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(227, 28)
        Me.ComboBox7.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(434, 262)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(157, 29)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Change Font:"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(124, 625)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(151, 35)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Add custom Image"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(149, 582)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 29)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "---"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(149, 677)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 29)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "---"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(746, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(173, 35)
        Me.Button4.TabIndex = 26
        Me.Button4.Text = "Remove all Image"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(439, 387)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(755, 361)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1206, 760)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ComboBox7)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboBox6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form7"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Mode"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents ComboBox7 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
