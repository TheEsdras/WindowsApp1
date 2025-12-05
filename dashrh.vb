Public Class dashrh
    Private Sub GunaTileButton1_Click(sender As Object, e As EventArgs) Handles GunaTileButton1.Click
        cad_contas.Show()
    End Sub

    Private Sub GunaTileButton2_Click(sender As Object, e As EventArgs) Handles GunaTileButton2.Click
        cons_funcionarios.Show()
    End Sub

    Private Sub GunaTileButton4_Click(sender As Object, e As EventArgs) Handles GunaTileButton4.Click
        frm_presenca.Show()
    End Sub

    Private Sub btn_banco_horas_Click(sender As Object, e As EventArgs) Handles btn_banco_horas.Click
        cons_banco_horas.Show()
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

    Private Sub dashrh_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class