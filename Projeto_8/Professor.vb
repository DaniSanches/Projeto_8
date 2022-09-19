Public Class Professor
    'Comando  que possibilita a clsse aluno herdar as caracteristicas da classe Pessoa
    Inherits Pessoa
    Private rgmProf As String

    Public Sub New(nomeProf As String, rgmProf As String)
        ' como essa  classe herda  caracterísca da classe pessoa preciso informar na linha de baixo
        MyBase.New(nomeProf)
        'MyBase Informa que essa informação é da classe "Pai"
        Me.rgmProf = rgmProf

    End Sub

    Public Property pRgm As String
        Get
            Return rgmProf
        End Get
        Set(value As String)
            rgmProf = value
        End Set
    End Property
End Class


