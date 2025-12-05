Imports ADODB

Public Class frm_historico

    Private Sub frm_historico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_access()
        carregar_meu_ponto()
    End Sub

    Sub carregar_meu_ponto()
        Try

            sql = "SELECT data_registro, hora_entrada, hora_saida FROM tb_ponto " &
                  "WHERE cpf_funcionario='" & mod_geral.usuario_logado_cpf & "' " &
                  "ORDER BY id DESC"

            rs = db.Execute(sql)


            dgv_historico.Rows.Clear()

            dgv_historico.ColumnCount = 3
            dgv_historico.Columns(0).Name = "DATA"
            dgv_historico.Columns(1).Name = "ENTRADA"
            dgv_historico.Columns(2).Name = "SAÍDA"

            Do While rs.EOF = False
                dgv_historico.Rows.Add(rs.Fields("data_registro").Value, rs.Fields("hora_entrada").Value, rs.Fields("hora_saida").Value)
                rs.MoveNext()
            Loop

            rs.Close()

        Catch ex As Exception
            MsgBox("Erro ao carregar histórico: " & ex.Message)
        End Try
    End Sub

    Private Sub GunaLabel1_Click(sender As Object, e As EventArgs) Handles GunaLabel1.Click

    End Sub
End Class