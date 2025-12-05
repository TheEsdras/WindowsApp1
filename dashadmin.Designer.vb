<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashadmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dashadmin))
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaTileButton4 = New Guna.UI.WinForms.GunaTileButton()
        Me.GunaTileButton3 = New Guna.UI.WinForms.GunaTileButton()
        Me.btn_visualizar = New Guna.UI.WinForms.GunaTileButton()
        Me.GunaTileButton1 = New Guna.UI.WinForms.GunaTileButton()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.btn_sair = New Guna.UI.WinForms.GunaTileButton()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Microsoft YaHei Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GunaLabel1.Location = New System.Drawing.Point(17, 37)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(254, 28)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "OLÁ ADMINISTRADOR(A)"
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
        Me.GunaTileButton4.Location = New System.Drawing.Point(187, 251)
        Me.GunaTileButton4.Name = "GunaTileButton4"
        Me.GunaTileButton4.OnHoverBaseColor = System.Drawing.SystemColors.HotTrack
        Me.GunaTileButton4.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaTileButton4.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaTileButton4.OnHoverImage = Nothing
        Me.GunaTileButton4.OnPressedColor = System.Drawing.Color.Black
        Me.GunaTileButton4.Size = New System.Drawing.Size(160, 149)
        Me.GunaTileButton4.TabIndex = 5
        Me.GunaTileButton4.Text = "VISUALIZAR GESTORES"
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
        Me.GunaTileButton3.Location = New System.Drawing.Point(12, 251)
        Me.GunaTileButton3.Name = "GunaTileButton3"
        Me.GunaTileButton3.OnHoverBaseColor = System.Drawing.SystemColors.HotTrack
        Me.GunaTileButton3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaTileButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaTileButton3.OnHoverImage = Nothing
        Me.GunaTileButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaTileButton3.Size = New System.Drawing.Size(169, 149)
        Me.GunaTileButton3.TabIndex = 4
        Me.GunaTileButton3.Text = "CADASTRAR GESTORES"
        '
        'btn_visualizar
        '
        Me.btn_visualizar.AnimationHoverSpeed = 0.07!
        Me.btn_visualizar.AnimationSpeed = 0.03!
        Me.btn_visualizar.BaseColor = System.Drawing.Color.White
        Me.btn_visualizar.BorderColor = System.Drawing.SystemColors.HotTrack
        Me.btn_visualizar.BorderSize = 3
        Me.btn_visualizar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_visualizar.FocusedColor = System.Drawing.Color.Empty
        Me.btn_visualizar.Font = New System.Drawing.Font("Segoe UI Light", 15.75!)
        Me.btn_visualizar.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btn_visualizar.Image = CType(resources.GetObject("btn_visualizar.Image"), System.Drawing.Image)
        Me.btn_visualizar.ImageSize = New System.Drawing.Size(52, 52)
        Me.btn_visualizar.Location = New System.Drawing.Point(187, 89)
        Me.btn_visualizar.Name = "btn_visualizar"
        Me.btn_visualizar.OnHoverBaseColor = System.Drawing.SystemColors.HotTrack
        Me.btn_visualizar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_visualizar.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_visualizar.OnHoverImage = Nothing
        Me.btn_visualizar.OnPressedColor = System.Drawing.Color.Black
        Me.btn_visualizar.Size = New System.Drawing.Size(160, 146)
        Me.btn_visualizar.TabIndex = 3
        Me.btn_visualizar.Text = "VISUALIZAR RELATÓRIOS"
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
        Me.GunaTileButton1.Location = New System.Drawing.Point(12, 89)
        Me.GunaTileButton1.Name = "GunaTileButton1"
        Me.GunaTileButton1.OnHoverBaseColor = System.Drawing.SystemColors.HotTrack
        Me.GunaTileButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaTileButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaTileButton1.OnHoverImage = Nothing
        Me.GunaTileButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaTileButton1.Size = New System.Drawing.Size(169, 146)
        Me.GunaTileButton1.TabIndex = 2
        Me.GunaTileButton1.Text = "CRIAR RELATÓRIOS"
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.WhatsApp_Image_2025_10_30_at_11_51_03_removebg_preview
        Me.GunaPictureBox1.Location = New System.Drawing.Point(409, -21)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(120, 120)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox1.TabIndex = 1
        Me.GunaPictureBox1.TabStop = False
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
        Me.btn_sair.Location = New System.Drawing.Point(353, 251)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.OnHoverBaseColor = System.Drawing.SystemColors.HotTrack
        Me.btn_sair.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_sair.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_sair.OnHoverImage = Nothing
        Me.btn_sair.OnPressedColor = System.Drawing.Color.Black
        Me.btn_sair.Size = New System.Drawing.Size(160, 149)
        Me.btn_sair.TabIndex = 8
        Me.btn_sair.Text = "SAIR DA CONTA"
        '
        'dashadmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 450)
        Me.Controls.Add(Me.btn_sair)
        Me.Controls.Add(Me.GunaTileButton4)
        Me.Controls.Add(Me.GunaTileButton3)
        Me.Controls.Add(Me.btn_visualizar)
        Me.Controls.Add(Me.GunaTileButton1)
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Name = "dashadmin"
        Me.Text = "DASHBOARD ADMINISTRADOR"
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaTileButton1 As Guna.UI.WinForms.GunaTileButton
    Friend WithEvents btn_visualizar As Guna.UI.WinForms.GunaTileButton
    Friend WithEvents GunaTileButton3 As Guna.UI.WinForms.GunaTileButton
    Friend WithEvents GunaTileButton4 As Guna.UI.WinForms.GunaTileButton
    Friend WithEvents btn_sair As Guna.UI.WinForms.GunaTileButton
End Class
