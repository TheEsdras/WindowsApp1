Imports ADODB

Public Class baterponto


    Private Sub baterponto_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        conecta_banco_access()
    End Sub


    Private Sub btn_registrar_entrada_Click(sender As Object, e As EventArgs) Handles btn_registrar_entrada.Click
        Try
            Dim dataHoje As String = DateTime.Now.ToString("dd/MM/yyyy")
            Dim horaAgora As String = DateTime.Now.ToString("HH:mm:ss")
            Dim cpf As String = mod_geral.usuario_logado_cpf


            sql = "SELECT * FROM tb_ponto WHERE cpf_funcionario='" & cpf & "' AND data_registro='" & dataHoje & "' AND (hora_saida IS NULL OR hora_saida = '')"
            rs = db.Execute(sql)

            If rs.EOF = False Then



                Dim idRegistro As Integer = rs.Fields("id").Value


                rs.Close()


                sql = "UPDATE tb_ponto SET hora_saida='" & horaAgora & "' WHERE id=" & idRegistro
                db.Execute(sql)

                MsgBox("SAÍDA registrada com sucesso às " & horaAgora & "!" & vbCrLf & "Bom descanso.", vbInformation)

            Else



                If rs.State = 1 Then rs.Close()

                sql = "INSERT INTO tb_ponto (cpf_funcionario, data_registro, hora_entrada) VALUES (" &
                      "'" & cpf & "', " &
                      "'" & dataHoje & "', " &
                      "'" & horaAgora & "')"
                db.Execute(sql)

                MsgBox("ENTRADA registrada com sucesso às " & horaAgora & "!" & vbCrLf & "Bom trabalho.", vbInformation)
            End If


            If rs.State = 1 Then rs.Close()

        Catch ex As Exception
            MsgBox("Erro ao bater ponto: " & ex.Message)
        End Try
    End Sub


    Private Sub btn_registrar_saida_Click(sender As Object, e As EventArgs) Handles btn_registrar_saida.Click
        btn_registrar_entrada_Click(sender, e)
    End Sub

End Class