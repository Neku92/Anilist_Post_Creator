Public Class Form2
    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        PictureBox1.Image = My.Resources.Add_buttons
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        PictureBox1.Image = My.Resources.Add_NSFW_button
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        PictureBox1.Image = My.Resources.Add_Embed_image
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        PictureBox1.Image = My.Resources.Add_image_extra_feature
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        PictureBox1.Image = My.Resources.Add_youtube_extra_feature
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        PictureBox1.Image = My.Resources.Add_news_extra_feature
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.BackgroundImage = Image.FromFile(My.Settings.BckgrnImage2.ToString)
        Catch ex As Exception
        End Try
    End Sub
End Class