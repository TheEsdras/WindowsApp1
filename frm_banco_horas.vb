Imports ADODB

Public Class frm_banco_horas

    Private Sub frm_banco_horas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_access()
        calcular_banco_horas()
    End Sub

    Sub calcular_banco_horas()
        Try
            sql = "SELECT data_registro, hora_entrada, hora_saida FROM tb_ponto " &
                  "WHERE cpf_funcionario='" & mod_geral.usuario_logado_cpf & "' " &
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

            lbl_saldo_total.Text = "Total Trabalhado: " &
                                   horasTotais.ToString("00") & ":" &
                                   minutosTotais.ToString("00") & ":" &
                                   segundosTotais.ToString("00")

        Catch ex As Exception
            MsgBox("Erro ao calcular horas: " & ex.Message)
        End Try
    End Sub

End Class