Public Class dashadmin
    Private Sub GunaTileButton3_Click(sender As Object, e As EventArgs) Handles GunaTileButton3.Click
        cad_gestores.Show()
    End Sub

    Private Sub dashadmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GunaTileButton1_Click(sender As Object, e As EventArgs) Handles GunaTileButton1.Click

        frm_relatorios.Show()
    End Sub

    Private Sub GunaTileButton4_Click(sender As Object, e As EventArgs) Handles GunaTileButton4.Click
        cons_gestores.Show()
    End Sub

    Private Sub btn_visualizar_Click(sender As Object, e As EventArgs) Handles btn_visualizar.Click

        cons_relatorios.Show()
    End Sub

    Private Sub GunaTileButton2_Click(sender As Object, e As EventArgs)

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
End Class