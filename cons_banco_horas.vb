Imports ADODB

Public Class cons_banco_horas

    Private Sub cons_banco_horas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_access()
        carregar_lista_funcionarios()
    End Sub

    Sub carregar_lista_funcionarios()
        Try
            sql = "SELECT nome, cpf FROM tb_usuarios WHERE tipo_conta='Funcionário' AND nome LIKE '" & txt_buscar.Text & "%' ORDER BY nome"
            rs = db.Execute(sql)

            dgv_funcionarios.Rows.Clear()
            dgv_funcionarios.ColumnCount = 2
            dgv_funcionarios.Columns(0).Name = "NOME"
            dgv_funcionarios.Columns(1).Name = "CPF"
            dgv_funcionarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            Do While rs.EOF = False
                dgv_funcionarios.Rows.Add(rs.Fields("nome").Value, rs.Fields("cpf").Value)
                rs.MoveNext()
            Loop
            rs.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        carregar_lista_funcionarios()
    End Sub

    Private Sub dgv_funcionarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_funcionarios.CellClick
        Try
            If e.RowIndex < 0 Then Exit Sub


            Dim cpfSelecionado As String = dgv_funcionarios.Rows(e.RowIndex).Cells(1).Value.ToString()
            Dim nomeSelecionado As String = dgv_funcionarios.Rows(e.RowIndex).Cells(0).Value.ToString()


            sql = "SELECT data_registro, hora_entrada, hora_saida FROM tb_ponto " &
                  "WHERE cpf_funcionario='" & cpfSelecionado & "' " &
                  "AND hora_saida IS NOT NULL AND hora_saida <> '' " &
                  "ORDER BY id DESC"

            rs = db.Execute(sql)

            dgv_extrato.Rows.Clear()
            dgv_extrato.ColumnCount = 4
            dgv_extrato.Columns(0).Name = "DATA"
            dgv_extrato.Columns(1).Name = "ENTRADA"
            dgv_extrato.Columns(2).Name = "SAÍDA"
            dgv_extrato.Columns(3).Name = "DURAÇÃO"
            dgv_extrato.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


            Dim totalSegundos As Double = 0

            Do While rs.EOF = False
                Dim entradaStr As String = rs.Fields("hora_entrada").Value
                Dim saidaStr As String = rs.Fields("hora_saida").Value

                Dim horaEntrada As DateTime = Convert.ToDateTime(entradaStr)
                Dim horaSaida As DateTime = Convert.ToDateTime(saidaStr)
                Dim diferenca As TimeSpan = horaSaida.Subtract(horaEntrada)

                totalSegundos += diferenca.TotalSeconds

                dgv_extrato.Rows.Add(
                    rs.Fields("data_registro").Value,
                    entradaStr,
                    saidaStr,
                    diferenca.ToString("hh\:mm\:ss")
                )
                rs.MoveNext()
            Loop
            rs.Close()


            Dim horasTotais As Integer = Math.Floor(totalSegundos / 3600)
            Dim restoSegundos As Integer = totalSegundos Mod 3600
            Dim minutosTotais As Integer = Math.Floor(restoSegundos / 60)
            Dim segundosTotais As Integer = restoSegundos Mod 60

            lbl_total.Text = "Total de " & nomeSelecionado & ": " &
                             horasTotais.ToString("00") & ":" &
                             minutosTotais.ToString("00") & ":" &
                             segundosTotais.ToString("00")

        Catch ex As Exception
            MsgBox("Erro ao calcular: " & ex.Message)
        End Try
    End Sub

End Class