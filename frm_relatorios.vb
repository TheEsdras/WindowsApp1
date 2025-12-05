Imports System.IO
Imports ADODB

Public Class frm_relatorios

    Private Sub frm_relatorios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_access()


        cmb_mes.Items.Clear()
        For i As Integer = 1 To 12
            cmb_mes.Items.Add(i.ToString("00"))
        Next
        cmb_mes.Text = DateTime.Now.Month.ToString("00")

        cmb_ano.Items.Clear()
        Dim anoAtual As Integer = DateTime.Now.Year


        For i As Integer = anoAtual - 5 To anoAtual + 10
            cmb_ano.Items.Add(i.ToString())
        Next
        cmb_ano.Text = anoAtual.ToString()

        btn_criar.Enabled = True
    End Sub


    Private Sub btn_criar_Click(sender As Object, e As EventArgs) Handles btn_criar.Click
        Try
            Dim mes As String = cmb_mes.Text
            Dim ano As String = cmb_ano.Text
            Dim descricao As String = "Relatório de " & mes & "/" & ano

            If mes = "" Or ano = "" Then
                MsgBox("Selecione Mês e Ano!", vbExclamation)
                Exit Sub
            End If


            Dim filtroData As String = "%/" & mes & "/" & ano

            sql = "SELECT * FROM tb_ponto WHERE data_registro LIKE '" & filtroData & "'"
            rs = db.Execute(sql)

            If rs.EOF = True Then

                MsgBox("Não existem registros de ponto para " & mes & "/" & ano & "!" & vbCrLf &
                       "O relatório não será criado.", vbExclamation)
                rs.Close()
                Exit Sub
            End If
            rs.Close()

            sql = "SELECT * FROM tb_relatorios_salvos WHERE mes='" & mes & "' AND ano='" & ano & "'"
            rs = db.Execute(sql)

            If Not rs.EOF Then
                MsgBox("Esse relatório já foi gerado e salvo antes! Mostrando dados...", vbInformation)
            Else

                rs.Close()
                sql = "INSERT INTO tb_relatorios_salvos (mes, ano, descricao) VALUES ('" & mes & "', '" & ano & "', '" & descricao & "')"
                db.Execute(sql)
                MsgBox("Relatório Criado e Salvo com sucesso!", vbInformation)
            End If


            carregar_dados(mes, ano)

        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
        End Try
    End Sub


    Private Sub btn_exportar_Click(sender As Object, e As EventArgs) Handles btn_exportar.Click
        Try
            If dgv_detalhes.Rows.Count = 0 Then
                MsgBox("Não há dados para salvar!", vbExclamation)
                Exit Sub
            End If

            Dim salvar As New SaveFileDialog()
            salvar.Filter = "Arquivo CSV (*.csv)|*.csv"

            salvar.FileName = "Relatorio_" & cmb_mes.Text & "-" & cmb_ano.Text & ".csv"

            If salvar.ShowDialog() = DialogResult.OK Then
                Dim arquivo As New StreamWriter(salvar.FileName, False, System.Text.Encoding.UTF8)

                Dim cabecalho As String = ""
                For i As Integer = 0 To dgv_detalhes.Columns.Count - 1
                    cabecalho &= dgv_detalhes.Columns(i).HeaderText & ";"
                Next
                arquivo.WriteLine(cabecalho)

                For i As Integer = 0 To dgv_detalhes.Rows.Count - 1
                    Dim linha As String = ""
                    For j As Integer = 0 To dgv_detalhes.Columns.Count - 1
                        If dgv_detalhes.Rows(i).Cells(j).Value IsNot Nothing Then
                            linha &= dgv_detalhes.Rows(i).Cells(j).Value.ToString() & ";"
                        Else
                            linha &= ";"
                        End If
                    Next
                    arquivo.WriteLine(linha)
                Next

                arquivo.Close()
                MsgBox("Arquivo salvo com sucesso!", vbInformation)
            End If

        Catch ex As Exception
            MsgBox("Erro ao exportar: " & ex.Message)
        End Try
    End Sub

    Sub carregar_dados(mes As String, ano As String)
        Dim filtroData As String = "%/" & mes & "/" & ano

        sql = "SELECT tb_usuarios.nome, tb_usuarios.cpf, tb_ponto.data_registro, tb_ponto.hora_entrada, tb_ponto.hora_saida " &
              "FROM tb_ponto INNER JOIN tb_usuarios ON tb_ponto.cpf_funcionario = tb_usuarios.cpf " &
              "WHERE tb_ponto.data_registro LIKE '" & filtroData & "' " &
              "ORDER BY tb_ponto.data_registro DESC"

        rs = db.Execute(sql)

        dgv_detalhes.Rows.Clear()
        dgv_detalhes.ColumnCount = 5
        dgv_detalhes.Columns(0).Name = "NOME"
        dgv_detalhes.Columns(1).Name = "CPF"
        dgv_detalhes.Columns(2).Name = "DATA"
        dgv_detalhes.Columns(3).Name = "ENTRADA"
        dgv_detalhes.Columns(4).Name = "SAÍDA"
        dgv_detalhes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Do While rs.EOF = False
            dgv_detalhes.Rows.Add(rs.Fields("nome").Value, rs.Fields("cpf").Value, rs.Fields("data_registro").Value, rs.Fields("hora_entrada").Value, rs.Fields("hora_saida").Value)
            rs.MoveNext()
        Loop
    End Sub

    Public Sub VisualizarAntigo(mes As String, ano As String)
        cmb_mes.Text = mes
        cmb_ano.Text = ano

        carregar_dados(mes, ano)

        btn_criar.Enabled = False
        Me.Text = "Visualizando Histórico: " & mes & "/" & ano
    End Sub

End Class