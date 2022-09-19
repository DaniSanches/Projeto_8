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
        Me.TxtAluno = New System.Windows.Forms.TextBox()
        Me.btnExibir = New System.Windows.Forms.Button()
        Me.lblProfessor = New System.Windows.Forms.Label()
        Me.rgmProfe = New System.Windows.Forms.Label()
        Me.TxtRgmProf = New System.Windows.Forms.TextBox()
        Me.TxtProf = New System.Windows.Forms.TextBox()
        Me.lblNomeProf = New System.Windows.Forms.Label()
        Me.btnexibirProf = New System.Windows.Forms.Button()
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
        'TxtAluno
        '
        Me.TxtAluno.Location = New System.Drawing.Point(126, 124)
        Me.TxtAluno.Name = "TxtAluno"
        Me.TxtAluno.Size = New System.Drawing.Size(164, 20)
        Me.TxtAluno.TabIndex = 4
        '
        'btnExibir
        '
        Me.btnExibir.Location = New System.Drawing.Point(311, 79)
        Me.btnExibir.Name = "btnExibir"
        Me.btnExibir.Size = New System.Drawing.Size(75, 23)
        Me.btnExibir.TabIndex = 5
        Me.btnExibir.Text = "&Exibir"
        Me.btnExibir.UseVisualStyleBackColor = True
        Me.btnExibir.UseWaitCursor = True
        '
        'lblProfessor
        '
        Me.lblProfessor.AutoSize = True
        Me.lblProfessor.Location = New System.Drawing.Point(85, 192)
        Me.lblProfessor.Name = "lblProfessor"
        Me.lblProfessor.Size = New System.Drawing.Size(51, 13)
        Me.lblProfessor.TabIndex = 6
        Me.lblProfessor.Text = "Professor"
        '
        'rgmProfe
        '
        Me.rgmProfe.AutoSize = True
        Me.rgmProfe.Location = New System.Drawing.Point(85, 234)
        Me.rgmProfe.Name = "rgmProfe"
        Me.rgmProfe.Size = New System.Drawing.Size(38, 13)
        Me.rgmProfe.TabIndex = 7
        Me.rgmProfe.Text = "RGM: "
        '
        'TxtRgmProf
        '
        Me.TxtRgmProf.Location = New System.Drawing.Point(126, 231)
        Me.TxtRgmProf.Name = "TxtRgmProf"
        Me.TxtRgmProf.Size = New System.Drawing.Size(164, 20)
        Me.TxtRgmProf.TabIndex = 8
        '
        'TxtProf
        '
        Me.TxtProf.Location = New System.Drawing.Point(126, 283)
        Me.TxtProf.Name = "TxtProf"
        Me.TxtProf.Size = New System.Drawing.Size(164, 20)
        Me.TxtProf.TabIndex = 9
        '
        'lblNomeProf
        '
        Me.lblNomeProf.AutoSize = True
        Me.lblNomeProf.Location = New System.Drawing.Point(85, 290)
        Me.lblNomeProf.Name = "lblNomeProf"
        Me.lblNomeProf.Size = New System.Drawing.Size(35, 13)
        Me.lblNomeProf.TabIndex = 10
        Me.lblNomeProf.Text = "Nome"
        '
        'btnexibirProf
        '
        Me.btnexibirProf.Location = New System.Drawing.Point(311, 229)
        Me.btnexibirProf.Name = "btnexibirProf"
        Me.btnexibirProf.Size = New System.Drawing.Size(75, 23)
        Me.btnexibirProf.TabIndex = 11
        Me.btnexibirProf.Text = "&Exibir"
        Me.btnexibirProf.UseVisualStyleBackColor = True
        Me.btnexibirProf.UseWaitCursor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnexibirProf)
        Me.Controls.Add(Me.lblNomeProf)
        Me.Controls.Add(Me.TxtProf)
        Me.Controls.Add(Me.TxtRgmProf)
        Me.Controls.Add(Me.rgmProfe)
        Me.Controls.Add(Me.lblProfessor)
        Me.Controls.Add(Me.btnExibir)
        Me.Controls.Add(Me.TxtAluno)
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
    Friend WithEvents TxtAluno As TextBox
    Friend WithEvents btnExibir As Button
    Friend WithEvents lblProfessor As Label
    Friend WithEvents rgmProfe As Label
    Friend WithEvents TxtRgmProf As TextBox
    Friend WithEvents TxtProf As TextBox
    Friend WithEvents lblNomeProf As Label
    Friend WithEvents btnexibirProf As Button
End Class
