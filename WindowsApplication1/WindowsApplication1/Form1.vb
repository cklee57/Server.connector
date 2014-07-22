Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim r1 As DialogResult = MessageBox.Show("Message with Help file.", _
                                   "Help Caption", MessageBoxButtons.OK, _
                                   MessageBoxIcon.Question, _
                                   MessageBoxDefaultButton.Button1, _
                                   0, _
                                   "mspaint.chm")
    End Sub


End Class
