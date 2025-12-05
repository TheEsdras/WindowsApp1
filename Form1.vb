Public Class Form1
    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        Try
            conecta_banco_access()

            sql = "SELECT * FROM tb_usuarios WHERE email='" & txt_usuario.text & "' AND senha='" & txt_senha.text & "'"
            rs = db.Execute(sql)

            If rs.EOF = False Then

                Dim tipo As String = rs.Fields("tipo_conta").Value.ToString()
                Dim nome As String = rs.Fields("nome").Value.ToString()

                MsgBox("Bem vindo(a), " & nome & "!", vbInformation)

                mod_geral.usuario_logado_cpf = rs.Fields("cpf").Value

                If tipo = "Admin" Then
                    dashadmin.Show()
                ElseIf tipo = "Gestor" Then
                    dashrh.Show()
                Else
                    dashfuncionario.Show()
                End If

                Me.Hide()
            Else
                MsgBox("E-mail ou senha incorretos!", vbCritical)
            End If
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
        End Try
    End Sub

    Private Sub GunaLabel2_Click(sender As Object, e As EventArgs) Handles GunaLabel2.Click

    End Sub

    Private Sub txt_senha_TextChanged(sender As Object, e As EventArgs) Handles txt_senha.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try



            txt_senha.UseSystemPasswordChar = True



        Catch ex As Exception
        End Try
    End Sub

    Private Sub ckb_visualizar_CheckedChanged(sender As Object, e As EventArgs) Handles ckb_visualizar.CheckedChanged
        Try
            If ckb_visualizar.Checked = True Then
                txt_senha.UseSystemPasswordChar = False
            Else
                txt_senha.UseSystemPasswordChar = True
            End If


        Catch ex As Exception
        End Try
    End Sub
End Class