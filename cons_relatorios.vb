Imports ADODB

Public Class cons_relatorios

    Private Sub cons_relatorios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_access()
        carregar_lista()
    End Sub

    Sub carregar_lista()
        Try
            sql = "SELECT * FROM tb_relatorios_salvos ORDER BY id DESC"
            rs = db.Execute(sql)

            dgv_historico.Rows.Clear()

            ' --- CORREÇÃO: ADICIONANDO COLUNA ID ---
            dgv_historico.ColumnCount = 4
            dgv_historico.Columns(0).Name = "ID"
            dgv_historico.Columns(1).Name = "DESCRIÇÃO"
            dgv_historico.Columns(2).Name = "MÊS"
            dgv_historico.Columns(3).Name = "ANO"

            ' Esconde o ID para não ficar feio na tela
            dgv_historico.Columns(0).Visible = False
            dgv_historico.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            Do While rs.EOF = False
                ' Agora mandamos o ID junto
                dgv_historico.Rows.Add(rs.Fields("id").Value, rs.Fields("descricao").Value, rs.Fields("mes").Value, rs.Fields("ano").Value)
                rs.MoveNext()
            Loop
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
        End Try
    End Sub

    ' =======================================================
    ' BOTÃO EXCLUIR (CORRIGIDO)
    ' =======================================================
    Private Sub btn_excluir_Click(sender As Object, e As EventArgs) Handles btn_excluir.Click
        Try
            If dgv_historico.SelectedRows.Count = 0 And dgv_historico.CurrentRow Is Nothing Then
                MsgBox("Selecione um relatório na lista para excluir.", vbExclamation)
                Exit Sub
            End If

            ' Agora funciona porque a Coluna 0 é o ID (mesmo estando invisível)
            Dim idParaExcluir As Integer = dgv_historico.CurrentRow.Cells(0).Value

            If MsgBox("Tem certeza que deseja apagar este relatório?", vbQuestion + vbYesNo) = vbYes Then
                sql = "DELETE FROM tb_relatorios_salvos WHERE id=" & idParaExcluir
                db.Execute(sql)
                MsgBox("Relatório apagado!", vbInformation)
                carregar_lista()
            End If

        Catch ex As Exception
            MsgBox("Erro ao excluir: " & ex.Message)
        End Try
    End Sub

    ' =======================================================
    ' DUPLO CLIQUE NA LINHA (PARA ABRIR)
    ' =======================================================
    Private Sub dgv_historico_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_historico.CellDoubleClick
        Try
            If e.RowIndex < 0 Then Exit Sub

            ' Atualizei os índices porque adicionamos o ID na posição 0
            ' Agora: 0=ID, 1=Descrição, 2=Mês, 3=Ano
            Dim mesSelecionado As String = dgv_historico.Rows(e.RowIndex).Cells(2).Value.ToString()
            Dim anoSelecionado As String = dgv_historico.Rows(e.RowIndex).Cells(3).Value.ToString()

            frm_relatorios.Show()
            frm_relatorios.VisualizarAntigo(mesSelecionado, anoSelecionado)
            frm_relatorios.BringToFront()

        Catch ex As Exception
            MsgBox("Erro ao abrir: " & ex.Message)
        End Try
    End Sub

End Class