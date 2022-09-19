Public Class Aluno
    'Comando  que possibilita a clsse aluno herdar as caracteristicas da classe Pessoa
    Inherits Pessoa
    Private rgm As String

    Public Sub New(nome As String, rgm As String)
        ' como essa  classe herda  caracterísca da classe pessoa preciso informar na linha de baixo
        MyBase.New(nome)
        'MyBase Informa que essa informação é da classe "Pai"
        Me.rgm = rgm

    End Sub

    Public Property pRgm As String
        Get
            Return rgm
        End Get
        Set(value As String)
            rgm = value
        End Set
    End Property
End Class
