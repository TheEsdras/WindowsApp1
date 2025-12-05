Imports ADODB

Public Class frm_presenca

    Private Sub frm_presenca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_access()
        carregar_presenca_hoje()
    End Sub

    Sub carregar_presenca_hoje()
        Try
            Dim dataHoje As String = DateTime.Now.ToString("dd/MM/yyyy")



            sql = "SELECT tb_usuarios.nome, tb_ponto.hora_entrada, tb_ponto.hora_saida " &
                  "FROM tb_ponto INNER JOIN tb_usuarios ON tb_ponto.cpf_funcionario = tb_usuarios.cpf " &
                  "WHERE tb_ponto.data_registro = '" & dataHoje & "' " &
                  "ORDER BY tb_ponto.hora_entrada DESC"

            rs = db.Execute(sql)

            dgv_presenca.Rows.Clear()

            dgv_presenca.ColumnCount = 3
            dgv_presenca.Columns(0).Name = "FUNCIONÁRIO"
            dgv_presenca.Columns(1).Name = "ENTRADA"
            dgv_presenca.Columns(2).Name = "SAÍDA"

            Do While rs.EOF = False
                dgv_presenca.Rows.Add(rs.Fields("nome").Value, rs.Fields("hora_entrada").Value, rs.Fields("hora_saida").Value)
                rs.MoveNext()
            Loop

            rs.Close()

        Catch ex As Exception
            MsgBox("Erro ao carregar presença: " & ex.Message)
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class