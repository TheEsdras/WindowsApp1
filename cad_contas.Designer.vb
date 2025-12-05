<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cad_contas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cad_contas))
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nome = New ns1.BunifuTextbox()
        Me.txt_nasc = New ns1.BunifuTextbox()
        Me.txt_cpf = New ns1.BunifuTextbox()
        Me.txt_email = New ns1.BunifuTextbox()
        Me.txt_telefone = New ns1.BunifuTextbox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.dgv_dados = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.txt_senha = New ns1.BunifuTextbox()
        Me.txt_confirma = New ns1.BunifuTextbox()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaImageButton1 = New Guna.UI.WinForms.GunaImageButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_salvar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.pic_foto = New System.Windows.Forms.PictureBox()
        Me.btn_foto = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.pic_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Microsoft YaHei Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GunaLabel1.Location = New System.Drawing.Point(19, 41)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(314, 28)
        Me.GunaLabel1.TabIndex = 1
        Me.GunaLabel1.Text = "CADASTRO DE FUNCIONÁRIOS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(21, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "NOME"
        '
        'txt_nome
        '
        Me.txt_nome.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_nome.BackgroundImage = CType(resources.GetObject("txt_nome.BackgroundImage"), System.Drawing.Image)
        Me.txt_nome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txt_nome.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_nome.Icon = CType(resources.GetObject("txt_nome.Icon"), System.Drawing.Image)
        Me.txt_nome.Location = New System.Drawing.Point(24, 96)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(207, 36)
        Me.txt_nome.TabIndex = 3
        Me.txt_nome.text = ""
        '
        'txt_nasc
        '
        Me.txt_nasc.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_nasc.BackgroundImage = CType(resources.GetObject("txt_nasc.BackgroundImage"), System.Drawing.Image)
        Me.txt_nasc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txt_nasc.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_nasc.Icon = CType(resources.GetObject("txt_nasc.Icon"), System.Drawing.Image)
        Me.txt_nasc.Location = New System.Drawing.Point(24, 160)
        Me.txt_nasc.Name = "txt_nasc"
        Me.txt_nasc.Size = New System.Drawing.Size(207, 40)
        Me.txt_nasc.TabIndex = 4
        Me.txt_nasc.text = ""
        '
        'txt_cpf
        '
        Me.txt_cpf.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_cpf.BackgroundImage = CType(resources.GetObject("txt_cpf.BackgroundImage"), System.Drawing.Image)
        Me.txt_cpf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txt_cpf.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_cpf.Icon = CType(resources.GetObject("txt_cpf.Icon"), System.Drawing.Image)
        Me.txt_cpf.Location = New System.Drawing.Point(307, 96)
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(224, 36)
        Me.txt_cpf.TabIndex = 5
        Me.txt_cpf.text = ""
        '
        'txt_email
        '
        Me.txt_email.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_email.BackgroundImage = CType(resources.GetObject("txt_email.BackgroundImage"), System.Drawing.Image)
        Me.txt_email.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txt_email.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_email.Icon = CType(resources.GetObject("txt_email.Icon"), System.Drawing.Image)
        Me.txt_email.Location = New System.Drawing.Point(307, 160)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(224, 40)
        Me.txt_email.TabIndex = 6
        Me.txt_email.text = ""
        '
        'txt_telefone
        '
        Me.txt_telefone.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_telefone.BackgroundImage = CType(resources.GetObject("txt_telefone.BackgroundImage"), System.Drawing.Image)
        Me.txt_telefone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txt_telefone.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_telefone.Icon = CType(resources.GetObject("txt_telefone.Icon"), System.Drawing.Image)
        Me.txt_telefone.Location = New System.Drawing.Point(307, 223)
        Me.txt_telefone.Name = "txt_telefone"
        Me.txt_telefone.Size = New System.Drawing.Size(224, 41)
        Me.txt_telefone.TabIndex = 7
        Me.txt_telefone.text = ""
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Microsoft YaHei Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GunaLabel2.Location = New System.Drawing.Point(304, 76)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(29, 17)
        Me.GunaLabel2.TabIndex = 8
        Me.GunaLabel2.Text = "CPF"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Microsoft YaHei Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GunaLabel3.Location = New System.Drawing.Point(21, 140)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(140, 17)
        Me.GunaLabel3.TabIndex = 9
        Me.GunaLabel3.Text = "DATA DE NASCIMENTO"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Microsoft YaHei Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GunaLabel4.Location = New System.Drawing.Point(304, 140)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(42, 17)
        Me.GunaLabel4.TabIndex = 10
        Me.GunaLabel4.Text = "EMAIL"
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Microsoft YaHei Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GunaLabel5.Location = New System.Drawing.Point(304, 203)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(64, 17)
        Me.GunaLabel5.TabIndex = 11
        Me.GunaLabel5.Text = "TELEFONE"
        '
        'dgv_dados
        '
        Me.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgv_dados.Location = New System.Drawing.Point(24, 335)
        Me.dgv_dados.Name = "dgv_dados"
        Me.dgv_dados.Size = New System.Drawing.Size(603, 150)
        Me.dgv_dados.TabIndex = 12
        '
        'Column1
        '
        Me.Column1.HeaderText = "N°"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "NOME"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "CPF"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "EDITAR"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "EXCLUIR"
        Me.Column5.Name = "Column5"
        '
        'txt_senha
        '
        Me.txt_senha.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_senha.BackgroundImage = CType(resources.GetObject("txt_senha.BackgroundImage"), System.Drawing.Image)
        Me.txt_senha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txt_senha.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_senha.Icon = CType(resources.GetObject("txt_senha.Icon"), System.Drawing.Image)
        Me.txt_senha.Location = New System.Drawing.Point(24, 223)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(207, 41)
        Me.txt_senha.TabIndex = 13
        Me.txt_senha.text = ""
        '
        'txt_confirma
        '
        Me.txt_confirma.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_confirma.BackgroundImage = CType(resources.GetObject("txt_confirma.BackgroundImage"), System.Drawing.Image)
        Me.txt_confirma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txt_confirma.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_confirma.Icon = CType(resources.GetObject("txt_confirma.Icon"), System.Drawing.Image)
        Me.txt_confirma.Location = New System.Drawing.Point(24, 287)
        Me.txt_confirma.Name = "txt_confirma"
        Me.txt_confirma.Size = New System.Drawing.Size(207, 42)
        Me.txt_confirma.TabIndex = 14
        Me.txt_confirma.text = ""
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Microsoft YaHei Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GunaLabel6.Location = New System.Drawing.Point(21, 203)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(113, 17)
        Me.GunaLabel6.TabIndex = 15
        Me.GunaLabel6.Text = "SENHA DE ACESSO"
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Microsoft YaHei Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GunaLabel7.Location = New System.Drawing.Point(21, 267)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(186, 17)
        Me.GunaLabel7.TabIndex = 16
        Me.GunaLabel7.Text = "CONFIRMAR SENHA DE ACESSO"
        '
        'GunaImageButton1
        '
        Me.GunaImageButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton1.Image = Global.WindowsApp1.My.Resources.Resources.WhatsApp_Image_2025_10_30_at_11_51_03_removebg_preview
        Me.GunaImageButton1.ImageSize = New System.Drawing.Size(84, 84)
        Me.GunaImageButton1.Location = New System.Drawing.Point(549, 12)
        Me.GunaImageButton1.Name = "GunaImageButton1"
        Me.GunaImageButton1.OnHoverImage = Nothing
        Me.GunaImageButton1.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton1.Size = New System.Drawing.Size(96, 74)
        Me.GunaImageButton1.TabIndex = 17
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_salvar, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(657, 25)
        Me.ToolStrip1.TabIndex = 18
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_salvar
        '
        Me.btn_salvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_salvar.Image = CType(resources.GetObject("btn_salvar.Image"), System.Drawing.Image)
        Me.btn_salvar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_salvar.Name = "btn_salvar"
        Me.btn_salvar.Size = New System.Drawing.Size(23, 22)
        Me.btn_salvar.Text = "ToolStripButton1"
        Me.btn_salvar.ToolTipText = "GRAVAR"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'pic_foto
        '
        Me.pic_foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_foto.Location = New System.Drawing.Point(549, 109)
        Me.pic_foto.Name = "pic_foto"
        Me.pic_foto.Size = New System.Drawing.Size(100, 124)
        Me.pic_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_foto.TabIndex = 19
        Me.pic_foto.TabStop = False
        '
        'btn_foto
        '
        Me.btn_foto.Location = New System.Drawing.Point(549, 250)
        Me.btn_foto.Name = "btn_foto"
        Me.btn_foto.Size = New System.Drawing.Size(96, 23)
        Me.btn_foto.TabIndex = 20
        Me.btn_foto.Text = "Selecionar Foto"
        Me.btn_foto.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'cad_contas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 496)
        Me.Controls.Add(Me.btn_foto)
        Me.Controls.Add(Me.pic_foto)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GunaImageButton1)
        Me.Controls.Add(Me.GunaLabel7)
        Me.Controls.Add(Me.GunaLabel6)
        Me.Controls.Add(Me.txt_confirma)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.dgv_dados)
        Me.Controls.Add(Me.GunaLabel5)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.txt_telefone)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.txt_nasc)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Name = "cad_contas"
        Me.Text = "cad_contas"
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.pic_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_nome As ns1.BunifuTextbox
    Friend WithEvents txt_nasc As ns1.BunifuTextbox
    Friend WithEvents txt_cpf As ns1.BunifuTextbox
    Friend WithEvents txt_email As ns1.BunifuTextbox
    Friend WithEvents txt_telefone As ns1.BunifuTextbox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents dgv_dados As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewImageColumn
    Friend WithEvents Column5 As DataGridViewImageColumn
    Friend WithEvents txt_senha As ns1.BunifuTextbox
    Friend WithEvents txt_confirma As ns1.BunifuTextbox
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaImageButton1 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btn_salvar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents pic_foto As PictureBox
    Friend WithEvents btn_foto As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
