Public Class Pessoa
    ' Private  para  que ele não possa ser acessado por uma classe que não seja dele
    Private nome As String

    Public Sub New(nome As String)
        Me.nome = nome
    End Sub

    Public Property PNome As String
        Get
            Return nome
        End Get
        Set(value As String)
            nome = value
        End Set
    End Property

End Class
