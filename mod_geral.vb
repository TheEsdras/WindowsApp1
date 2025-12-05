Imports ADODB

Module mod_geral
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public sql As String
    Public usuario_logado_cpf As String
    ' Caminho automático para a pasta Debug onde você salvou o arquivo
    Public dir_banco As String = Application.StartupPath & "\pontofacil.mdb"

    Sub conecta_banco_access()
        Try
            If db.State = 1 Then Exit Sub ' Se já tá aberto, sai

            db = New ADODB.Connection
            ' Conexão para Access 2007+ (.accdb)
            'db.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dir_banco & ";Persist Security Info=False;")
            db.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dir_banco)
        Catch ex As Exception
            MsgBox("Tentei ler em: " & dir_banco & vbCrLf & vbCrLf & "Erro Técnico: " & ex.Message)
            Application.Exit()
        End Try
    End Sub
End Module