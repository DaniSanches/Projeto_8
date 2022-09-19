Public Class Form1
    Private Sub btnExibir_Click(sender As Object, e As EventArgs) Handles btnExibir.Click
        Dim obj_aluno As New Aluno("Pipoca Sanches", "777777")
        TxtRg.Text = obj_aluno.PNome
        txtRgmAluno.Text = obj_aluno.pRgm
    End Sub
End Class
