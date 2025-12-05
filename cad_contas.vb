Imports ADODB
Imports System.IO

Public Class cad_contas

    Dim id_editar As Integer = 0
    Dim caminho_foto_atual As String = ""

    Private Sub cad_contas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_access()
        carregar_grid()
        id_editar = 0


        If Not Directory.Exists(Application.StartupPath & "\Fotos") Then
            Directory.CreateDirectory(Application.StartupPath & "\Fotos")
        End If


        pic_foto.Image = Nothing
    End Sub


    Private Sub btn_foto_Click(sender As Object, e As EventArgs) Handles btn_foto.Click
        Try
            OpenFileDialog1.Filter = "Imagens (*.jpg;*.png)|*.jpg;*.png"
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then

                pic_foto.Image = Image.FromFile(OpenFileDialog1.FileName)

                ' Guarda o caminho temporariamente
                caminho_foto_atual = OpenFileDialog1.FileName
            End If
        Catch ex As Exception
            MsgBox("Erro ao abrir imagem.", vbCritical)
        End Try
    End Sub


    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        Try
            If txt_nome.text = "" Or txt_cpf.text = "" Then
                MsgBox("Preencha Nome e CPF!", vbExclamation)
                Exit Sub
            End If

            If txt_senha.text <> txt_confirma.text Then
                MsgBox("As senhas não conferem!", vbExclamation)
                Exit Sub
            End If


            Dim caminhoFinal As String = ""

            If caminho_foto_atual <> "" Then

                Dim nomeArquivo As String = txt_cpf.text & Path.GetExtension(caminho_foto_atual)
                caminhoFinal = Application.StartupPath & "\Fotos\" & nomeArquivo


                If caminho_foto_atual <> caminhoFinal Then
                    File.Copy(caminho_foto_atual, caminhoFinal, True)
                End If
            End If


            If id_editar = 0 Then

                sql = "SELECT * FROM tb_usuarios WHERE cpf='" & txt_cpf.text & "'"
                rs = db.Execute(sql)
                If Not rs.EOF Then
                    MsgBox("CPF já cadastrado!", vbExclamation)
                    rs.Close()
                    Exit Sub
                End If
                rs.Close()


                sql = "INSERT INTO tb_usuarios (nome, cpf, nasc, email, senha, telefone, tipo_conta, foto) VALUES (" &
                      "'" & txt_nome.text & "', " &
                      "'" & txt_cpf.text & "', " &
                      "'" & txt_nasc.text & "', " &
                      "'" & txt_email.text & "', " &
                      "'" & txt_senha.text & "', " &
                      "'" & txt_telefone.text & "', " &
                      "'Funcionário', " &
                      "'" & caminhoFinal & "')"
                db.Execute(sql)
                MsgBox("Cadastrado com sucesso!", vbInformation)

            Else

                Dim sqlFoto As String = ""
                If caminhoFinal <> "" Then
                    sqlFoto = ", foto='" & caminhoFinal & "'"
                End If

                sql = "UPDATE tb_usuarios SET " &
                      "nome='" & txt_nome.text & "', " &
                      "cpf='" & txt_cpf.text & "', " &
                      "nasc='" & txt_nasc.text & "', " &
                      "email='" & txt_email.text & "', " &
                      "senha='" & txt_senha.text & "', " &
                      "telefone='" & txt_telefone.text & "'" &
                      sqlFoto & " " &
                      "WHERE id=" & id_editar

                db.Execute(sql)
                MsgBox("Atualizado com sucesso!", vbInformation)
            End If

            limpar_campos()
            carregar_grid()
            id_editar = 0

        Catch ex As Exception
            MsgBox("Erro ao salvar: " & ex.Message)
        End Try
    End Sub


    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        Try
            If e.RowIndex < 0 Then Exit Sub
            Dim idSelecionado As Integer = dgv_dados.Rows(e.RowIndex).Cells(0).Value


            If e.ColumnIndex = 3 Then
                sql = "SELECT * FROM tb_usuarios WHERE id=" & idSelecionado
                rs = db.Execute(sql)

                If Not rs.EOF Then
                    txt_nome.text = rs.Fields("nome").Value
                    txt_cpf.text = rs.Fields("cpf").Value
                    txt_nasc.text = rs.Fields("nasc").Value.ToString()
                    txt_email.text = rs.Fields("email").Value
                    txt_senha.text = rs.Fields("senha").Value
                    txt_confirma.text = rs.Fields("senha").Value
                    txt_telefone.text = rs.Fields("telefone").Value


                    Dim caminhoBanco As String = ""
                    If Not IsDBNull(rs.Fields("foto").Value) Then
                        caminhoBanco = rs.Fields("foto").Value
                    End If

                    If caminhoBanco <> "" Then

                        Dim nomeArquivo As String = System.IO.Path.GetFileName(caminhoBanco)


                        Dim caminhoReal As String = Application.StartupPath & "\Fotos\" & nomeArquivo


                        If System.IO.File.Exists(caminhoReal) Then
                            pic_foto.Image = Image.FromFile(caminhoReal)
                            caminho_foto_atual = caminhoReal
                        Else
                            pic_foto.Image = Nothing
                            caminho_foto_atual = ""
                        End If
                    Else
                        pic_foto.Image = Nothing
                        caminho_foto_atual = ""
                    End If


                    id_editar = idSelecionado
                End If
                rs.Close()


            ElseIf e.ColumnIndex = 4 Then
                If MsgBox("Excluir funcionário?", vbQuestion + vbYesNo) = vbYes Then
                    sql = "DELETE FROM tb_usuarios WHERE id=" & idSelecionado
                    db.Execute(sql)
                    carregar_grid()
                End If
            End If

        Catch ex As Exception
            MsgBox("Erro no grid: " & ex.Message)
        End Try
    End Sub

    Sub carregar_grid()
        Try
            sql = "SELECT id, nome, cpf FROM tb_usuarios WHERE tipo_conta='Funcionário' ORDER BY nome"
            rs = db.Execute(sql)
            dgv_dados.Rows.Clear()
            Do While rs.EOF = False
                dgv_dados.Rows.Add(rs.Fields("id").Value, rs.Fields("nome").Value, rs.Fields("cpf").Value, Nothing, Nothing)
                rs.MoveNext()
            Loop
            If rs.State = 1 Then rs.Close()
        Catch ex As Exception
        End Try
    End Sub

    Sub limpar_campos()
        txt_nome.text = ""
        txt_cpf.text = ""
        txt_nasc.text = ""
        txt_email.text = ""
        txt_senha.text = ""
        txt_confirma.text = ""
        txt_telefone.text = ""
        pic_foto.Image = Nothing
        caminho_foto_atual = ""
        id_editar = 0
    End Sub

    Private Sub txt_cpf_OnTextChange(sender As Object, e As EventArgs) Handles txt_cpf.OnTextChange
        Try

            Dim original As String = txt_cpf.text
            Dim numeros As String = System.Text.RegularExpressions.Regex.Replace(original, "[^0-9]", "")


            If original = numeros AndAlso original.Length < 4 Then Exit Sub

            Dim formatado As String = numeros


            If numeros.Length > 11 Then
                numeros = numeros.Substring(0, 11)
                formatado = numeros
            End If

            If numeros.Length > 9 Then
                formatado = numeros.Insert(3, ".").Insert(7, ".").Insert(11, "-")
            ElseIf numeros.Length > 6 Then
                formatado = numeros.Insert(3, ".").Insert(7, ".")
            ElseIf numeros.Length > 3 Then
                formatado = numeros.Insert(3, ".")
            End If


            If txt_cpf.text <> formatado Then
                txt_cpf.text = formatado


                txt_cpf.Focus()
                SendKeys.Send("{END}")
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub txt_telefone_OnTextChange(sender As Object, e As EventArgs) Handles txt_telefone.OnTextChange
        Try

            Dim original As String = txt_telefone.text
            Dim numeros As String = System.Text.RegularExpressions.Regex.Replace(original, "[^0-9]", "")


            If original = numeros AndAlso original.Length < 2 Then Exit Sub

            Dim formatado As String = numeros


            If numeros.Length > 11 Then
                numeros = numeros.Substring(0, 11)
                formatado = numeros
            End If


            If numeros.Length = 11 Then

                formatado = numeros.Insert(0, "(").Insert(3, ") ").Insert(10, "-")

            ElseIf numeros.Length > 5 Then

                formatado = numeros.Insert(0, "(").Insert(3, ") ").Insert(9, "-")

            ElseIf numeros.Length > 2 Then

                formatado = numeros.Insert(0, "(").Insert(3, ") ")
            End If


            If txt_telefone.text <> formatado Then
                txt_telefone.text = formatado
                txt_telefone.Focus()
                SendKeys.Send("{END}")
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub txt_nasc_OnTextChange(sender As Object, e As EventArgs) Handles txt_nasc.OnTextChange
        Try

            Dim original As String = txt_nasc.text
            Dim numeros As String = System.Text.RegularExpressions.Regex.Replace(original, "[^0-9]", "")


            If original = numeros AndAlso original.Length < 2 Then Exit Sub

            Dim formatado As String = numeros


            If numeros.Length > 8 Then
                numeros = numeros.Substring(0, 8)
                formatado = numeros
            End If


            If numeros.Length > 4 Then

                formatado = numeros.Insert(2, "/").Insert(5, "/")
            ElseIf numeros.Length > 2 Then

                formatado = numeros.Insert(2, "/")
            End If


            If txt_nasc.text <> formatado Then
                txt_nasc.text = formatado
                txt_nasc.Focus()
                SendKeys.Send("{END}")
            End If

        Catch ex As Exception
        End Try
    End Sub
End Class