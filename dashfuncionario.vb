Public Class dashfuncionario
    Private Sub GunaTileButton1_Click(sender As Object, e As EventArgs) Handles GunaTileButton1.Click
        baterponto.Show()
    End Sub

    Private Sub GunaTileButton2_Click(sender As Object, e As EventArgs) Handles GunaTileButton2.Click
        frm_historico.Show()
    End Sub

    Private Sub GunaTileButton3_Click(sender As Object, e As EventArgs) Handles GunaTileButton3.Click
        frm_meus_dados.Show()
    End Sub

    Private Sub GunaTileButton4_Click(sender As Object, e As EventArgs) Handles GunaTileButton4.Click
        frm_banco_horas.Show()
    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        Try
            Dim resposta As Integer
            resposta = MsgBox("Deseja mesmo sair da conta?", vbQuestion + vbYesNo, "Logout")

            If resposta = vbYes Then


                Dim telaLogin As New Form1()
                telaLogin.Show()

                Me.Close()

            Else

            End If

        Catch ex As Exception
            MsgBox("Erro ao sair: " & ex.Message)
        End Try
    End Sub

    Private Sub dashfuncionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class