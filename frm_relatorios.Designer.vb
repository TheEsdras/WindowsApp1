<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_relatorios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_relatorios))
        Me.cmb_mes = New System.Windows.Forms.ComboBox()
        Me.dgv_detalhes = New System.Windows.Forms.DataGridView()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.btn_criar = New Guna.UI.WinForms.GunaTileButton()
        Me.btn_exportar = New Guna.UI.WinForms.GunaTileButton()
        Me.cmb_ano = New System.Windows.Forms.ComboBox()
        CType(Me.dgv_detalhes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmb_mes
        '
        Me.cmb_mes.FormattingEnabled = True
        Me.cmb_mes.Location = New System.Drawing.Point(36, 119)
        Me.cmb_mes.Name = "cmb_mes"
        Me.cmb_mes.Size = New System.Drawing.Size(153, 21)
        Me.cmb_mes.TabIndex = 0
        '
        'dgv_detalhes
        '
        Me.dgv_detalhes.BackgroundColor = System.Drawing.SystemColors.HotTrack
        Me.dgv_detalhes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_detalhes.Location = New System.Drawing.Point(285, 126)
        Me.dgv_detalhes.Name = "dgv_detalhes"
        Me.dgv_detalhes.Size = New System.Drawing.Size(481, 312)
        Me.dgv_detalhes.TabIndex = 3
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Microsoft YaHei Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GunaLabel1.Location = New System.Drawing.Point(29, 21)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(256, 35)
        Me.GunaLabel1.TabIndex = 5
        Me.GunaLabel1.Text = "CRIAR RELATÓRIOS"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Microsoft YaHei Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GunaLabel2.Location = New System.Drawing.Point(31, 91)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(153, 21)
        Me.GunaLabel2.TabIndex = 6
        Me.GunaLabel2.Text = "SELECIONE O MÊS:"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Microsoft YaHei Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GunaLabel3.Location = New System.Drawing.Point(32, 167)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(157, 21)
        Me.GunaLabel3.TabIndex = 7
        Me.GunaLabel3.Text = "SELECIONE O ANO:"
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.WhatsApp_Image_2025_10_30_at_11_51_03_removebg_preview
        Me.GunaPictureBox1.Location = New System.Drawing.Point(668, -8)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(120, 120)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox1.TabIndex = 8
        Me.GunaPictureBox1.TabStop = False
        '
        'btn_criar
        '
        Me.btn_criar.AnimationHoverSpeed = 0.07!
        Me.btn_criar.AnimationSpeed = 0.03!
        Me.btn_criar.BaseColor = System.Drawing.Color.White
        Me.btn_criar.BorderColor = System.Drawing.SystemColors.HotTrack
        Me.btn_criar.BorderSize = 3
        Me.btn_criar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_criar.FocusedColor = System.Drawing.Color.Empty
        Me.btn_criar.Font = New System.Drawing.Font("Microsoft YaHei Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_criar.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btn_criar.Image = CType(resources.GetObject("btn_criar.Image"), System.Drawing.Image)
        Me.btn_criar.ImageSize = New System.Drawing.Size(30, 30)
        Me.btn_criar.Location = New System.Drawing.Point(35, 243)
        Me.btn_criar.Name = "btn_criar"
        Me.btn_criar.OnHoverBaseColor = System.Drawing.SystemColors.HotTrack
        Me.btn_criar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_criar.OnHoverForeColor = System.Drawing.SystemColors.HighlightText
        Me.btn_criar.OnHoverImage = Nothing
        Me.btn_criar.OnPressedColor = System.Drawing.Color.Black
        Me.btn_criar.Size = New System.Drawing.Size(158, 92)
        Me.btn_criar.TabIndex = 9
        Me.btn_criar.Text = "CRIAR RELATÓRIO"
        '
        'btn_exportar
        '
        Me.btn_exportar.AnimationHoverSpeed = 0.07!
        Me.btn_exportar.AnimationSpeed = 0.03!
        Me.btn_exportar.BaseColor = System.Drawing.Color.White
        Me.btn_exportar.BorderColor = System.Drawing.SystemColors.HotTrack
        Me.btn_exportar.BorderSize = 3
        Me.btn_exportar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_exportar.FocusedColor = System.Drawing.Color.Empty
        Me.btn_exportar.Font = New System.Drawing.Font("Microsoft YaHei Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exportar.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btn_exportar.Image = CType(resources.GetObject("btn_exportar.Image"), System.Drawing.Image)
        Me.btn_exportar.ImageSize = New System.Drawing.Size(30, 30)
        Me.btn_exportar.Location = New System.Drawing.Point(36, 341)
        Me.btn_exportar.Name = "btn_exportar"
        Me.btn_exportar.OnHoverBaseColor = System.Drawing.SystemColors.HotTrack
        Me.btn_exportar.OnHoverBorderColor = System.Drawing.SystemColors.Desktop
        Me.btn_exportar.OnHoverForeColor = System.Drawing.SystemColors.HighlightText
        Me.btn_exportar.OnHoverImage = Nothing
        Me.btn_exportar.OnPressedColor = System.Drawing.Color.Black
        Me.btn_exportar.Size = New System.Drawing.Size(157, 97)
        Me.btn_exportar.TabIndex = 10
        Me.btn_exportar.Text = "SALVAR EM ARQUIVO EXCEL"
        '
        'cmb_ano
        '
        Me.cmb_ano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ano.FormattingEnabled = True
        Me.cmb_ano.Location = New System.Drawing.Point(35, 203)
        Me.cmb_ano.Name = "cmb_ano"
        Me.cmb_ano.Size = New System.Drawing.Size(154, 21)
        Me.cmb_ano.TabIndex = 11
        '
        'frm_relatorios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmb_ano)
        Me.Controls.Add(Me.btn_exportar)
        Me.Controls.Add(Me.btn_criar)
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.dgv_detalhes)
        Me.Controls.Add(Me.cmb_mes)
        Me.Name = "frm_relatorios"
        Me.Text = "CRIAR RELATÓRIOS"
        CType(Me.dgv_detalhes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmb_mes As ComboBox
    Friend WithEvents dgv_detalhes As DataGridView
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents btn_criar As Guna.UI.WinForms.GunaTileButton
    Friend WithEvents btn_exportar As Guna.UI.WinForms.GunaTileButton
    Friend WithEvents cmb_ano As ComboBox
End Class
