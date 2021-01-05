Public Class Form1

    Private Sub temp_Click(sender As Object, e As EventArgs) Handles temp_pic.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        temp_pic.Image = PictureBox1.Image
        PictureBox1.Image = PictureBox2.Image
        PictureBox2.Image = PictureBox3.Image
        PictureBox3.Image = temp_pic.Image
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
