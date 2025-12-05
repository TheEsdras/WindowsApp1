<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cons_gestores
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
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.dgv_lista_gestores = New System.Windows.Forms.DataGridView()
        Me.pic_foto_gestor = New System.Windows.Forms.PictureBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        CType(Me.dgv_lista_gestores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_foto_gestor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(18, 165)
        Me.txt_buscar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(248, 26)
        Me.txt_buscar.TabIndex = 0
        '
        'dgv_lista_gestores
        '
        Me.dgv_lista_gestores.BackgroundColor = System.Drawing.SystemColors.HotTrack
        Me.dgv_lista_gestores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_lista_gestores.Location = New System.Drawing.Point(18, 205)
        Me.dgv_lista_gestores.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgv_lista_gestores.Name = "dgv_lista_gestores"
        Me.dgv_lista_gestores.RowHeadersWidth = 62
        Me.dgv_lista_gestores.Size = New System.Drawing.Size(891, 469)
        Me.dgv_lista_gestores.TabIndex = 1
        '
        'pic_foto_gestor
        '
        Me.pic_foto_gestor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_foto_gestor.Location = New System.Drawing.Point(958, 205)
        Me.pic_foto_gestor.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pic_foto_gestor.Name = "pic_foto_gestor"
        Me.pic_foto_gestor.Size = New System.Drawing.Size(194, 232)
        Me.pic_foto_gestor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_foto_gestor.TabIndex = 2
        Me.pic_foto_gestor.TabStop = False
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Microsoft YaHei Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GunaLabel1.Location = New System.Drawing.Point(9, 14)
        Me.GunaLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(415, 46)
        Me.GunaLabel1.TabIndex = 3
        Me.GunaLabel1.Text = "CONSULTAR GESTORES"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Microsoft YaHei Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GunaLabel2.Location = New System.Drawing.Point(21, 114)
        Me.GunaLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(245, 31)
        Me.GunaLabel2.TabIndex = 4
        Me.GunaLabel2.Text = "BUSCAR POR NOME:"
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.WhatsApp_Image_2025_10_30_at_11_51_03_removebg_preview
        Me.GunaPictureBox1.Location = New System.Drawing.Point(1028, -11)
        Me.GunaPictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(180, 185)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox1.TabIndex = 5
        Me.GunaPictureBox1.TabStop = False
        '
        'cons_gestores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.pic_foto_gestor)
        Me.Controls.Add(Me.dgv_lista_gestores)
        Me.Controls.Add(Me.txt_buscar)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "cons_gestores"
        Me.Text = "CONSULTAR GESTORES"
        CType(Me.dgv_lista_gestores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_foto_gestor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_buscar As TextBox
    Friend WithEvents dgv_lista_gestores As DataGridView
    Friend WithEvents pic_foto_gestor As PictureBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
End Class
