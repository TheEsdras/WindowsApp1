Imports ADODB

Public Class frm_meus_dados

    Private Sub frm_meus_dados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_access()
        carregar_dados_usuario()
    End Sub

    Sub carregar_dados_usuario()
        Try
            sql = "SELECT * FROM tb_usuarios WHERE cpf='" & mod_geral.usuario_logado_cpf & "'"
            rs = db.Execute(sql)

            If Not rs.EOF Then
                lbl_nome.Text = rs.Fields("nome").Value
                lbl_cpf.Text = rs.Fields("cpf").Value
                lbl_email.Text = rs.Fields("email").Value
            End If
            rs.Close()

        Catch ex As Exception
            MsgBox("Erro ao carregar dados: " & ex.Message)
        End Try
    End Sub

    Private Sub btn_salvar_senha_Click(sender As Object, e As EventArgs) Handles btn_salvar_senha.Click
        Try
            If txt_senha_atual.Text = "" Or txt_nova_senha.Text = "" Then
                MsgBox("Preencha a senha atual e a nova senha!", vbExclamation)
                Exit Sub
            End If

            If txt_nova_senha.Text <> txt_confirma_nova.Text Then
                MsgBox("A confirmação da nova senha não bate!", vbExclamation)
                Exit Sub
            End If

            sql = "SELECT * FROM tb_usuarios WHERE cpf='" & mod_geral.usuario_logado_cpf & "' AND senha='" & txt_senha_atual.Text & "'"
            rs = db.Execute(sql)

            If rs.EOF = True Then
                MsgBox("A senha atual digitada está incorreta!", vbCritical)
                rs.Close()
                Exit Sub
            End If
            rs.Close()

            sql = "UPDATE tb_usuarios SET senha='" & txt_nova_senha.Text & "' WHERE cpf='" & mod_geral.usuario_logado_cpf & "'"
            db.Execute(sql)

            MsgBox("Senha alterada com sucesso!", vbInformation)


            txt_senha_atual.Text = ""
            txt_nova_senha.Text = ""
            txt_confirma_nova.Text = ""

        Catch ex As Exception
            MsgBox("Erro ao alterar senha: " & ex.Message)
        End Try
    End Sub

End Class