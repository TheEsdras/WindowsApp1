<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cons_relatorios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cons_relatorios))
        Me.dgv_historico = New System.Windows.Forms.DataGridView()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.btn_excluir = New Guna.UI.WinForms.GunaTileButton()
        CType(Me.dgv_historico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_historico
        '
        Me.dgv_historico.BackgroundColor = System.Drawing.SystemColors.HotTrack
        Me.dgv_historico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_historico.Location = New System.Drawing.Point(18, 115)
        Me.dgv_historico.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgv_historico.Name = "dgv_historico"
        Me.dgv_historico.RowHeadersWidth = 62
        Me.dgv_historico.Size = New System.Drawing.Size(692, 475)
        Me.dgv_historico.TabIndex = 0
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Microsoft YaHei Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GunaLabel1.Location = New System.Drawing.Point(18, 40)
        Me.GunaLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(454, 46)
        Me.GunaLabel1.TabIndex = 2
        Me.GunaLabel1.Text = "CONSULTAR RELATÓRIOS"
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.WhatsApp_Image_2025_10_30_at_11_51_03_removebg_preview
        Me.GunaPictureBox1.Location = New System.Drawing.Point(1016, -6)
        Me.GunaPictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(180, 185)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox1.TabIndex = 3
        Me.GunaPictureBox1.TabStop = False
        '
        'btn_excluir
        '
        Me.btn_excluir.AnimationHoverSpeed = 0.07!
        Me.btn_excluir.AnimationSpeed = 0.03!
        Me.btn_excluir.BaseColor = System.Drawing.Color.White
        Me.btn_excluir.BorderColor = System.Drawing.SystemColors.HotTrack
        Me.btn_excluir.BorderSize = 3
        Me.btn_excluir.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_excluir.FocusedColor = System.Drawing.Color.Empty
        Me.btn_excluir.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_excluir.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btn_excluir.Image = CType(resources.GetObject("btn_excluir.Image"), System.Drawing.Image)
        Me.btn_excluir.ImageSize = New System.Drawing.Size(30, 30)
        Me.btn_excluir.Location = New System.Drawing.Point(732, 468)
        Me.btn_excluir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_excluir.Name = "btn_excluir"
        Me.btn_excluir.OnHoverBaseColor = System.Drawing.SystemColors.HotTrack
        Me.btn_excluir.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_excluir.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_excluir.OnHoverImage = Nothing
        Me.btn_excluir.OnPressedColor = System.Drawing.Color.Black
        Me.btn_excluir.Size = New System.Drawing.Size(172, 123)
        Me.btn_excluir.TabIndex = 4
        Me.btn_excluir.Text = "EXCLUIR SELECIONADO"
        '
        'cons_relatorios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.Controls.Add(Me.btn_excluir)
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.dgv_historico)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "cons_relatorios"
        Me.Text = "cons_relatorios"
        CType(Me.dgv_historico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_historico As DataGridView
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents btn_excluir As Guna.UI.WinForms.GunaTileButton
End Class
