<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashfuncionario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dashfuncionario))
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaTileButton3 = New Guna.UI.WinForms.GunaTileButton()
        Me.GunaTileButton2 = New Guna.UI.WinForms.GunaTileButton()
        Me.GunaTileButton1 = New Guna.UI.WinForms.GunaTileButton()
        Me.GunaTileButton4 = New Guna.UI.WinForms.GunaTileButton()
        Me.btn_sair = New Guna.UI.WinForms.GunaTileButton()
        Me.SuspendLayout()
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Microsoft YaHei Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GunaLabel1.Location = New System.Drawing.Point(21, 40)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(190, 28)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "Seja Bem Vindo(a)!"
        '
        'GunaTileButton3
        '
        Me.GunaTileButton3.AnimationHoverSpeed = 0.07!
        Me.GunaTileButton3.AnimationSpeed = 0.03!
        Me.GunaTileButton3.BaseColor = System.Drawing.Color.White
        Me.GunaTileButton3.BorderColor = System.Drawing.SystemColors.HotTrack
        Me.GunaTileButton3.BorderSize = 3
        Me.GunaTileButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaTileButton3.FocusedColor = System.Drawing.Color.Empty
        Me.GunaTileButton3.Font = New System.Drawing.Font("Segoe UI Light", 15.75!)
        Me.GunaTileButton3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GunaTileButton3.Image = CType(resources.GetObject("GunaTileButton3.Image"), System.Drawing.Image)
        Me.GunaTileButton3.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaTileButton3.Location = New System.Drawing.Point(12, 250)
        Me.GunaTileButton3.Name = "GunaTileButton3"
        Me.GunaTileButton3.OnHoverBaseColor = System.Drawing.SystemColors.HotTrack
        Me.GunaTileButton3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaTileButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaTileButton3.OnHoverImage = Nothing
        Me.GunaTileButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaTileButton3.Size = New System.Drawing.Size(170, 146)
        Me.GunaTileButton3.TabIndex = 5
        Me.GunaTileButton3.Text = "MEUS DADOS"
        '
        'GunaTileButton2
        '
        Me.GunaTileButton2.AnimationHoverSpeed = 0.07!
        Me.GunaTileButton2.AnimationSpeed = 0.03!
        Me.GunaTileButton2.BaseColor = System.Drawing.Color.White
        Me.GunaTileButton2.BorderColor = System.Drawing.SystemColors.HotTrack
        Me.GunaTileButton2.BorderSize = 3
        Me.GunaTileButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaTileButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaTileButton2.Font = New System.Drawing.Font("Segoe UI Light", 15.75!)
        Me.GunaTileButton2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GunaTileButton2.Image = CType(resources.GetObject("GunaTileButton2.Image"), System.Drawing.Image)
        Me.GunaTileButton2.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaTileButton2.Location = New System.Drawing.Point(203, 84)
        Me.GunaTileButton2.Name = "GunaTileButton2"
        Me.GunaTileButton2.OnHoverBaseColor = System.Drawing.SystemColors.HotTrack
        Me.GunaTileButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaTileButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaTileButton2.OnHoverImage = Nothing
        Me.GunaTileButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaTileButton2.Size = New System.Drawing.Size(165, 138)
        Me.GunaTileButton2.TabIndex = 4
        Me.GunaTileButton2.Text = " HISTÓRICO"
        '
        'GunaTileButton1
        '
        Me.GunaTileButton1.AnimationHoverSpeed = 0.07!
        Me.GunaTileButton1.AnimationSpeed = 0.03!
        Me.GunaTileButton1.BaseColor = System.Drawing.Color.White
        Me.GunaTileButton1.BorderColor = System.Drawing.SystemColors.HotTrack
        Me.GunaTileButton1.BorderSize = 3
        Me.GunaTileButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaTileButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaTileButton1.Font = New System.Drawing.Font("Segoe UI Light", 15.75!)
        Me.GunaTileButton1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GunaTileButton1.Image = CType(resources.GetObject("GunaTileButton1.Image"), System.Drawing.Image)
        Me.GunaTileButton1.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaTileButton1.Location = New System.Drawing.Point(12, 84)
        Me.GunaTileButton1.Name = "GunaTileButton1"
        Me.GunaTileButton1.OnHoverBaseColor = System.Drawing.SystemColors.HotTrack
        Me.GunaTileButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaTileButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaTileButton1.OnHoverImage = Nothing
        Me.GunaTileButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaTileButton1.Size = New System.Drawing.Size(170, 138)
        Me.GunaTileButton1.TabIndex = 3
        Me.GunaTileButton1.Text = "REGISTRAR ENTRADA/SAÍDA"
        '
        'GunaTileButton4
        '
        Me.GunaTileButton4.AnimationHoverSpeed = 0.07!
        Me.GunaTileButton4.AnimationSpeed = 0.03!
        Me.GunaTileButton4.BaseColor = System.Drawing.Color.White
        Me.GunaTileButton4.BorderColor = System.Drawing.SystemColors.HotTrack
        Me.GunaTileButton4.BorderSize = 3
        Me.GunaTileButton4.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaTileButton4.FocusedColor = System.Drawing.Color.Empty
        Me.GunaTileButton4.Font = New System.Drawing.Font("Segoe UI Light", 15.75!)
        Me.GunaTileButton4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GunaTileButton4.Image = CType(resources.GetObject("GunaTileButton4.Image"), System.Drawing.Image)
        Me.GunaTileButton4.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaTileButton4.Location = New System.Drawing.Point(203, 250)
        Me.GunaTileButton4.Name = "GunaTileButton4"
        Me.GunaTileButton4.OnHoverBaseColor = System.Drawing.SystemColors.HotTrack
        Me.GunaTileButton4.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaTileButton4.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaTileButton4.OnHoverImage = Nothing
        Me.GunaTileButton4.OnPressedColor = System.Drawing.Color.Black
        Me.GunaTileButton4.Size = New System.Drawing.Size(170, 146)
        Me.GunaTileButton4.TabIndex = 6
        Me.GunaTileButton4.Text = "BANCO DE HORAS"
        '
        'btn_sair
        '
        Me.btn_sair.AnimationHoverSpeed = 0.07!
        Me.btn_sair.AnimationSpeed = 0.03!
        Me.btn_sair.BaseColor = System.Drawing.Color.White
        Me.btn_sair.BorderColor = System.Drawing.SystemColors.HotTrack
        Me.btn_sair.BorderSize = 3
        Me.btn_sair.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_sair.FocusedColor = System.Drawing.Color.Empty
        Me.btn_sair.Font = New System.Drawing.Font("Segoe UI Light", 15.75!)
        Me.btn_sair.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btn_sair.Image = CType(resources.GetObject("btn_sair.Image"), System.Drawing.Image)
        Me.btn_sair.ImageSize = New System.Drawing.Size(52, 52)
        Me.btn_sair.Location = New System.Drawing.Point(384, 250)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.OnHoverBaseColor = System.Drawing.SystemColors.HotTrack
        Me.btn_sair.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_sair.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_sair.OnHoverImage = Nothing
        Me.btn_sair.OnPressedColor = System.Drawing.Color.Black
        Me.btn_sair.Size = New System.Drawing.Size(160, 146)
        Me.btn_sair.TabIndex = 7
        Me.btn_sair.Text = "SAIR DA CONTA"
        '
        'dashfuncionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 450)
        Me.Controls.Add(Me.btn_sair)
        Me.Controls.Add(Me.GunaTileButton4)
        Me.Controls.Add(Me.GunaTileButton3)
        Me.Controls.Add(Me.GunaTileButton2)
        Me.Controls.Add(Me.GunaTileButton1)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Name = "dashfuncionario"
        Me.Text = "dashfuncionario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaTileButton1 As Guna.UI.WinForms.GunaTileButton
    Friend WithEvents GunaTileButton2 As Guna.UI.WinForms.GunaTileButton
    Friend WithEvents GunaTileButton3 As Guna.UI.WinForms.GunaTileButton
    Friend WithEvents GunaTileButton4 As Guna.UI.WinForms.GunaTileButton
    Friend WithEvents btn_sair As Guna.UI.WinForms.GunaTileButton
End Class
