<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class baterponto
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
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.btn_registrar_entrada = New System.Windows.Forms.Button()
        Me.btn_registrar_saida = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Microsoft YaHei Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GunaLabel1.Location = New System.Drawing.Point(159, 48)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(208, 28)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "SEJA BEM VINDO(A)!"
        '
        'btn_registrar_entrada
        '
        Me.btn_registrar_entrada.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_registrar_entrada.Font = New System.Drawing.Font("Microsoft YaHei Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_registrar_entrada.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btn_registrar_entrada.Location = New System.Drawing.Point(164, 100)
        Me.btn_registrar_entrada.Name = "btn_registrar_entrada"
        Me.btn_registrar_entrada.Size = New System.Drawing.Size(203, 62)
        Me.btn_registrar_entrada.TabIndex = 1
        Me.btn_registrar_entrada.Text = "REGISTRAR ENTRADA"
        Me.btn_registrar_entrada.UseVisualStyleBackColor = False
        '
        'btn_registrar_saida
        '
        Me.btn_registrar_saida.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_registrar_saida.Font = New System.Drawing.Font("Microsoft YaHei Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_registrar_saida.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btn_registrar_saida.Location = New System.Drawing.Point(164, 185)
        Me.btn_registrar_saida.Name = "btn_registrar_saida"
        Me.btn_registrar_saida.Size = New System.Drawing.Size(203, 64)
        Me.btn_registrar_saida.TabIndex = 2
        Me.btn_registrar_saida.Text = "REGISTRAR SAÍDA"
        Me.btn_registrar_saida.UseVisualStyleBackColor = False
        '
        'baterponto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 450)
        Me.Controls.Add(Me.btn_registrar_saida)
        Me.Controls.Add(Me.btn_registrar_entrada)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Name = "baterponto"
        Me.Text = "baterponto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btn_registrar_entrada As Button
    Friend WithEvents btn_registrar_saida As Button
End Class
