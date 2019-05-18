Public Class Form1
    Private Sub AbrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
        Label2.Text = OpenFileDialog1.FileName
        Dim arquivo As String = Label2.Text
        If IO.File.Exists(arquivo) Then
            RichTextBox1.Text = IO.File.ReadAllText(arquivo)
        Else
            MsgBox("Nenhum Arquivo de texto (.TXT) foi Selecionado.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub SalvarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalvarToolStripMenuItem.Click
        SaveFileDialog1.ShowDialog()
        Label1.Text = SaveFileDialog1.FileName
        Dim Write As New System.IO.StreamWriter(Label1.Text)
        Write.Write(RichTextBox1.Text)
        Write.Close()
        MsgBox("O Arquivo foi Salvo.")
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub FonteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FonteToolStripMenuItem.Click
        FontDialog1.ShowDialog()
        RichTextBox1.Font = FontDialog1.Font
    End Sub

    Private Sub CorDaFonteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CorDaFonteToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        RichTextBox1.ForeColor = ColorDialog1.Color
    End Sub

    Private Sub CorDeFundoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CorDeFundoToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        RichTextBox1.BackColor = ColorDialog1.Color
    End Sub

    Private Sub LimparToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimparToolStripMenuItem.Click
        RichTextBox1.Text = ""
    End Sub
End Class
