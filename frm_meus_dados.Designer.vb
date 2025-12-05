<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_meus_dados
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
        Me.lbl_nome = New System.Windows.Forms.Label()
        Me.lbl_cpf = New System.Windows.Forms.Label()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.txt_senha_atual = New System.Windows.Forms.TextBox()
        Me.txt_confirma_nova = New System.Windows.Forms.TextBox()
        Me.txt_nova_senha = New System.Windows.Forms.TextBox()
        Me.btn_salvar_senha = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_nome
        '
        Me.lbl_nome.AutoSize = True
        Me.lbl_nome.Font = New System.Drawing.Font("Microsoft YaHei Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nome.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbl_nome.Location = New System.Drawing.Point(22, 180)
        Me.lbl_nome.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_nome.Name = "lbl_nome"
        Me.lbl_nome.Size = New System.Drawing.Size(87, 31)
        Me.lbl_nome.TabIndex = 0
        Me.lbl_nome.Text = "Nome:"
        '
        'lbl_cpf
        '
        Me.lbl_cpf.AutoSize = True
        Me.lbl_cpf.Font = New System.Drawing.Font("Microsoft YaHei Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cpf.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbl_cpf.Location = New System.Drawing.Point(22, 288)
        Me.lbl_cpf.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_cpf.Name = "lbl_cpf"
        Me.lbl_cpf.Size = New System.Drawing.Size(62, 31)
        Me.lbl_cpf.TabIndex = 1
        Me.lbl_cpf.Text = "CPF:"
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Font = New System.Drawing.Font("Microsoft YaHei Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbl_email.Location = New System.Drawing.Point(22, 396)
        Me.lbl_email.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(87, 31)
        Me.lbl_email.TabIndex = 2
        Me.lbl_email.Text = "E-mail:"
        '
        'txt_senha_atual
        '
        Me.txt_senha_atual.Location = New System.Drawing.Point(279, 182)
        Me.txt_senha_atual.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_senha_atual.Name = "txt_senha_atual"
        Me.txt_senha_atual.Size = New System.Drawing.Size(259, 26)
        Me.txt_senha_atual.TabIndex = 3
        '
        'txt_confirma_nova
        '
        Me.txt_confirma_nova.Location = New System.Drawing.Point(279, 402)
        Me.txt_confirma_nova.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_confirma_nova.Name = "txt_confirma_nova"
        Me.txt_confirma_nova.Size = New System.Drawing.Size(259, 26)
        Me.txt_confirma_nova.TabIndex = 4
        '
        'txt_nova_senha
        '
        Me.txt_nova_senha.Location = New System.Drawing.Point(279, 288)
        Me.txt_nova_senha.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_nova_senha.Name = "txt_nova_senha"
        Me.txt_nova_senha.Size = New System.Drawing.Size(259, 26)
        Me.txt_nova_senha.TabIndex = 5
        '
        'btn_salvar_senha
        '
        Me.btn_salvar_senha.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_salvar_senha.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btn_salvar_senha.Location = New System.Drawing.Point(279, 483)
        Me.btn_salvar_senha.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_salvar_senha.Name = "btn_salvar_senha"
        Me.btn_salvar_senha.Size = New System.Drawing.Size(261, 108)
        Me.btn_salvar_senha.TabIndex = 6
        Me.btn_salvar_senha.Text = "SALVAR NOVA SENHA"
        Me.btn_salvar_senha.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(22, 128)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 31)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nome:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(22, 234)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 31)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "CPF:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(22, 348)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 31)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "E-mail:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label4.Location = New System.Drawing.Point(273, 128)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 31)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Senha atual"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label5.Location = New System.Drawing.Point(273, 234)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 31)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Nova Senha"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label6.Location = New System.Drawing.Point(273, 348)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(262, 31)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Confirmar Nova Senha"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Microsoft YaHei Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GunaLabel1.Location = New System.Drawing.Point(20, 20)
        Me.GunaLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(251, 46)
        Me.GunaLabel1.TabIndex = 13
        Me.GunaLabel1.Text = "MEUS DADOS"
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.WhatsApp_Image_2025_10_30_at_11_51_03_removebg_preview
        Me.GunaPictureBox1.Location = New System.Drawing.Point(1017, -2)
        Me.GunaPictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(180, 185)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox1.TabIndex = 14
        Me.GunaPictureBox1.TabStop = False
        '
        'frm_meus_dados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_salvar_senha)
        Me.Controls.Add(Me.txt_nova_senha)
        Me.Controls.Add(Me.txt_confirma_nova)
        Me.Controls.Add(Me.txt_senha_atual)
        Me.Controls.Add(Me.lbl_email)
        Me.Controls.Add(Me.lbl_cpf)
        Me.Controls.Add(Me.lbl_nome)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frm_meus_dados"
        Me.Text = "frm_meus_dados"
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_nome As Label
    Friend WithEvents lbl_cpf As Label
    Friend WithEvents lbl_email As Label
    Friend WithEvents txt_senha_atual As TextBox
    Friend WithEvents txt_confirma_nova As TextBox
    Friend WithEvents txt_nova_senha As TextBox
    Friend WithEvents btn_salvar_senha As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
End Class
