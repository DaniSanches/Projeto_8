<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblAluno = New System.Windows.Forms.Label()
        Me.lblRgm = New System.Windows.Forms.Label()
        Me.TxtRgm = New System.Windows.Forms.TextBox()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblAluno
        '
        Me.lblAluno.AutoSize = True
        Me.lblAluno.Location = New System.Drawing.Point(86, 44)
        Me.lblAluno.Name = "lblAluno"
        Me.lblAluno.Size = New System.Drawing.Size(34, 13)
        Me.lblAluno.TabIndex = 0
        Me.lblAluno.Text = "Aluno"
        '
        'lblRgm
        '
        Me.lblRgm.AutoSize = True
        Me.lblRgm.Location = New System.Drawing.Point(89, 82)
        Me.lblRgm.Name = "lblRgm"
        Me.lblRgm.Size = New System.Drawing.Size(38, 13)
        Me.lblRgm.TabIndex = 1
        Me.lblRgm.Text = "RGM: "
        '
        'TxtRgm
        '
        Me.TxtRgm.Location = New System.Drawing.Point(126, 79)
        Me.TxtRgm.Name = "TxtRgm"
        Me.TxtRgm.Size = New System.Drawing.Size(164, 20)
        Me.TxtRgm.TabIndex = 2
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(85, 127)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(35, 13)
        Me.lblNome.TabIndex = 3
        Me.lblNome.Text = "Nome"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(126, 124)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(260, 20)
        Me.TextBox1.TabIndex = 4
        '
        'btnFechar
        '
        Me.btnFechar.Location = New System.Drawing.Point(311, 79)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(75, 23)
        Me.btnFechar.TabIndex = 5
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.UseVisualStyleBackColor = True
        Me.btnFechar.UseWaitCursor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.TxtRgm)
        Me.Controls.Add(Me.lblRgm)
        Me.Controls.Add(Me.lblAluno)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAluno As Label
    Friend WithEvents lblRgm As Label
    Friend WithEvents TxtRgm As TextBox
    Friend WithEvents lblNome As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnFechar As Button
End Class
