Imports ADODB
Imports System.IO
Public Class cons_gestores

    Private Sub cons_gestores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_access()
        carregar_gestores()
    End Sub

    Sub carregar_gestores()
        Try

            sql = "SELECT id, nome, cpf, email, telefone FROM tb_usuarios " &
                  "WHERE tipo_conta='Gestor' " &
                  "AND nome LIKE '" & txt_buscar.Text & "%' " &
                  "ORDER BY nome ASC"

            rs = db.Execute(sql)

            dgv_lista_gestores.Rows.Clear()


            dgv_lista_gestores.ColumnCount = 5
            dgv_lista_gestores.Columns(0).Name = "ID"
            dgv_lista_gestores.Columns(1).Name = "NOME"
            dgv_lista_gestores.Columns(2).Name = "CPF"
            dgv_lista_gestores.Columns(3).Name = "E-MAIL"
            dgv_lista_gestores.Columns(4).Name = "TELEFONE"


            dgv_lista_gestores.Columns(0).Visible = False



            dgv_lista_gestores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            Do While rs.EOF = False
                dgv_lista_gestores.Rows.Add(rs.Fields("id").Value, rs.Fields("nome").Value, rs.Fields("cpf").Value, rs.Fields("email").Value, rs.Fields("telefone").Value)
                rs.MoveNext()
            Loop

            rs.Close()

        Catch ex As Exception
            MsgBox("Erro ao listar gestores: " & ex.Message)
        End Try
    End Sub


    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        carregar_gestores()
    End Sub

    Private Sub dgv_lista_gestores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_lista_gestores.CellClick
        Try

            If e.RowIndex < 0 Then Exit Sub

            Dim idSelecionado As Integer = dgv_lista_gestores.Rows(e.RowIndex).Cells(0).Value

            sql = "SELECT foto FROM tb_usuarios WHERE id=" & idSelecionado
            rs = db.Execute(sql)

            If Not rs.EOF Then

                Dim caminhoBanco As String = ""
                If Not IsDBNull(rs.Fields("foto").Value) Then
                    caminhoBanco = rs.Fields("foto").Value
                End If

                If caminhoBanco <> "" Then
                    Dim nomeArquivo As String = Path.GetFileName(caminhoBanco)
                    Dim caminhoReal As String = Application.StartupPath & "\Fotos\" & nomeArquivo

                    If File.Exists(caminhoReal) Then
                        pic_foto_gestor.Image = Image.FromFile(caminhoReal)
                    Else
                        pic_foto_gestor.Image = Nothing
                    End If
                Else
                    pic_foto_gestor.Image = Nothing
                End If

            End If
            rs.Close()

        Catch ex As Exception
            pic_foto_gestor.Image = Nothing
        End Try
    End Sub

    Private Sub dgv_lista_gestores_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_lista_gestores.CellContentClick

    End Sub

   
End Class