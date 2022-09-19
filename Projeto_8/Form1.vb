Public Class Form1
    Private Sub btnExibir_Click(sender As Object, e As EventArgs) Handles btnExibir.Click
        Dim obj_aluno As New Aluno("Pipoca Sanches", "777777")
        TxtAluno.Text = obj_aluno.PNome
        TxtRgm.Text = obj_aluno.pRgm
    End Sub

    Private Sub btnexibirProf_Click(sender As Object, e As EventArgs) Handles btnexibirProf.Click
        Dim obj_professor As New Professor("Nina Ferreira", "131217")
        TxtProf.Text = obj_professor.PNome
        TxtRgmProf.Text = obj_professor.pRgm
    End Sub
End Class
