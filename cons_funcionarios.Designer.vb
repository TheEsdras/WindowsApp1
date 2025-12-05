<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cons_funcionarios
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
        Me.dgv_lista = New System.Windows.Forms.DataGridView()
        Me.pic_foto_func = New System.Windows.Forms.PictureBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        CType(Me.dgv_lista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_foto_func, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(18, 154)
        Me.txt_buscar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(298, 26)
        Me.txt_buscar.TabIndex = 0
        '
        'dgv_lista
        '
        Me.dgv_lista.BackgroundColor = System.Drawing.SystemColors.HotTrack
        Me.dgv_lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_lista.Location = New System.Drawing.Point(18, 194)
        Me.dgv_lista.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgv_lista.Name = "dgv_lista"
        Me.dgv_lista.RowHeadersWidth = 62
        Me.dgv_lista.Size = New System.Drawing.Size(900, 498)
        Me.dgv_lista.TabIndex = 1
        '
        'pic_foto_func
        '
        Me.pic_foto_func.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_foto_func.Location = New System.Drawing.Point(950, 214)
        Me.pic_foto_func.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pic_foto_func.Name = "pic_foto_func"
        Me.pic_foto_func.Size = New System.Drawing.Size(209, 255)
        Me.pic_foto_func.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_foto_func.TabIndex = 2
        Me.pic_foto_func.TabStop = False
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Microsoft YaHei Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GunaLabel1.Location = New System.Drawing.Point(9, 37)
        Me.GunaLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(507, 46)
        Me.GunaLabel1.TabIndex = 3
        Me.GunaLabel1.Text = "CONSULTAR FUNCIONÁRIOS"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Microsoft YaHei Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GunaLabel2.Location = New System.Drawing.Point(12, 117)
        Me.GunaLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(256, 31)
        Me.GunaLabel2.TabIndex = 4
        Me.GunaLabel2.Text = "BUSCAR PELO NOME:"
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.WhatsApp_Image_2025_10_30_at_11_51_03_removebg_preview
        Me.GunaPictureBox1.Location = New System.Drawing.Point(1018, 0)
        Me.GunaPictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(180, 185)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox1.TabIndex = 5
        Me.GunaPictureBox1.TabStop = False
        '
        'cons_funcionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.pic_foto_func)
        Me.Controls.Add(Me.dgv_lista)
        Me.Controls.Add(Me.txt_buscar)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "cons_funcionarios"
        Me.Text = "cons_funcionarios"
        CType(Me.dgv_lista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_foto_func, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_buscar As TextBox
    Friend WithEvents dgv_lista As DataGridView
    Friend WithEvents pic_foto_func As PictureBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
End Class
