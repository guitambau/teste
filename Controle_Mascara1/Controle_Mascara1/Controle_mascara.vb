Imports System.Data.SqlClient
Imports System.Data
Imports System.Globalization
Imports System.Text
Imports Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop
Public Class Controle_mascara
    Public codin As String

    Private Sub Controle_mascara_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        With LST_RETIRADA 'Desenha a tabela para usuario
            .Columns.Add("", 0, HorizontalAlignment.Left)
            .Columns.Add("Registro", 75, HorizontalAlignment.Center)
            .Columns.Add("Nome", 360, HorizontalAlignment.Center)
            .Columns.Add("Crachá", 175, HorizontalAlignment.Center)
            .Columns.Add("Semana", 100, HorizontalAlignment.Center)
            .Columns.Add("Data", 102, HorizontalAlignment.Center)
        End With

        SUB_CONECTAR()

        'Busca os dados no BD que é da semana em que estamos
        comandoSQL.CommandText = "SELECT REGISTRO, NOME, CODIN, SEMANA, DATA FROM TAB_CONTROLE_MASCARA WHERE SEMANA = '" & retorna_semanadoano(DateTime.Now) & "'"
        objDataReader = comandoSQL.ExecuteReader

        adiciona_tabela()
        carrega_semana()

        'Combo box retorna a semana que estamos
        cbo_semana.Text = retorna_semanadoano(DateTime.Now)
        SUB_DESCONECTAR()

    End Sub
    Private Sub txt_cracha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cracha.KeyPress

        'Não deixa entrar nenhum char a não ser numero
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If

        Dim codin As String
        codin = txt_cracha.Text

        Try

            'Quando tecla enter é pressionada 
            If e.KeyChar = Chr(Keys.Enter) Then

                'Só pode entrar cracha que tenho 14 numeros
                If Trim(txt_cracha.Text).Length <> 14 Then
                    MsgBox("Crachá Invalido")
                    txt_cracha.Clear()
                    txt_cracha.Focus()
                    Exit Sub
                End If

                busca_codin()
                'caso codin exista 
                SUB_CONECTAR()
                'insere na tabela controle mascara
                comandoSQL.CommandText = "INSERT INTO TAB_CONTROLE_MASCARA (REGISTRO, NOME, CODIN, DATA, SEMANA)"
                'pega funcionario com codin digitado na tabela funcionario
                comandoSQL.CommandText &= "SELECT FUN_REGISTRO, FUN_NOME, FUN_CODIN, CONVERT(CHAR(10),GETDATE(),103) AS DATA, SEMANA = '" & retorna_semanadoano(DateTime.Now) & "' From FUNCIONARIO Where FUN_Codin = '" & codin & "'"
                comandoSQL.ExecuteNonQuery()
                'pega o codin digitado no bd do controle mascara
                carrega_controle_mascara_cracha()

                SUB_DESCONECTAR()

                txt_cracha.Clear()
                txt_cracha.Focus()

            End If

        Catch ex As Exception
            MsgBox("Funcionario já retirou a mascara essa semana")
            txt_cracha.Clear()
            txt_cracha.Focus()
        End Try

    End Sub
    Private Sub txt_registro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_registro.KeyPress

        'Não deixa entrar nenhum char a não ser numero
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If

        Dim registro As String
        registro = txt_registro.Text

        Try

            'Quando tecla enter é precionada
            If e.KeyChar = Chr(Keys.Enter) Then

                'Só pode entrar numeros com no maximo 6 char
                If Trim(txt_registro.Text).Length > 6 Then
                    MsgBox("Registro Incorreto")
                    txt_registro.Clear()
                    txt_registro.Focus()
                    Exit Sub
                End If

                busca_registro()
                'caso registro exista   
                SUB_CONECTAR()
                'insere na tabela controle mascara
                comandoSQL.CommandText = "INSERT INTO TAB_CONTROLE_MASCARA (REGISTRO, NOME, CODIN, DATA, SEMANA)"
                'pega funcionario com registro digitado na tabela funcionario
                comandoSQL.CommandText &= "SELECT FUN_REGISTRO, FUN_NOME, FUN_CODIN, CONVERT(CHAR(10),GETDATE(),103) AS DATA, SEMANA = '" & retorna_semanadoano(DateTime.Now) & "' From FUNCIONARIO Where FUN_REGISTRO = '" & registro & "'"
                comandoSQL.ExecuteNonQuery()
                'pega o registro digitado no bd do controle mascara
                carrega_controle_mascara_registro()

                SUB_DESCONECTAR()

                txt_registro.Clear()
                txt_registro.Focus()

            End If

        Catch ex As Exception
            MsgBox("Funcionario já retirou a mascara essa semana")
            txt_registro.Clear()
            txt_registro.Focus()
        End Try

    End Sub
    Sub carrega_controle_mascara_cracha()

        Dim codin As String
        codin = txt_cracha.Text

        SUB_CONECTAR()
        'Busca no BD o crachá digitado
        comandoSQL.CommandText = "SELECT REGISTRO, NOME, CODIN, SEMANA, DATA FROM TAB_CONTROLE_MASCARA WHERE CODIN = '" & codin & "'"
        objDataReader = comandoSQL.ExecuteReader

        Dim cont As Integer = 0 'CONTADOR DO WHILE

        adiciona_tabela()

        SUB_DESCONECTAR()

    End Sub
    Sub carrega_controle_mascara_registro()

        Dim registro As String
        registro = txt_registro.Text

        SUB_CONECTAR()
        'Busca no BD registro digitado
        comandoSQL.CommandText = "SELECT REGISTRO, NOME, CODIN, SEMANA, DATA FROM TAB_CONTROLE_MASCARA WHERE REGISTRO = '" & registro & "'"
        objDataReader = comandoSQL.ExecuteReader

        Dim cont As Integer = 0 'CONTADOR DO WHILE

        adiciona_tabela()

        SUB_DESCONECTAR()
    End Sub
    Sub busca_codin()

        Dim codin As String
        codin = txt_cracha.Text

        SUB_CONECTAR()
        'faz a busca se codin existe no banco de FUNCIONARIOS
        comandoSQL.CommandText = "SELECT FUN_REGISTRO, FUN_NOME, FUN_CODIN, CONVERT(CHAR(10),GETDATE(),103) AS DATA FROM FUNCIONARIO WHERE FUN_CODIN = '" & codin & "'"
        objDataReader = comandoSQL.ExecuteReader
        objDataReader.Read()

        'Caso crachá esteja no BD
        If objDataReader.HasRows Then
            'Fecha conexão
            SUB_DESCONECTAR()
        Else 'se não
            MsgBox("Cracha não encontrado")
            txt_cracha.Clear()
            txt_cracha.Focus()
        End If

    End Sub
    Sub busca_registro()

        Dim registro As String
        registro = txt_registro.Text

        SUB_CONECTAR()
        'faz a busca se registro existe no banco de FUNCIONARIOS
        comandoSQL.CommandText = "SELECT FUN_REGISTRO, FUN_NOME, FUN_CODIN, CONVERT(CHAR(10),GETDATE(),103) AS DATA FROM FUNCIONARIO WHERE FUN_REGISTRO = '" & registro & "'"
        objDataReader = comandoSQL.ExecuteReader
        objDataReader.Read()

        'Caso registro existe
        If objDataReader.HasRows Then
            'Fecha conexao
            SUB_DESCONECTAR()
        Else 'se não
            MsgBox("Registro não encontrado")
            txt_registro.Clear()
            txt_registro.Focus()
        End If

    End Sub
    Sub adiciona_tabela()

        SUB_CONECTAR()

        objDataReader = comandoSQL.ExecuteReader

        'ADICIONA BD NA TABELA
        While objDataReader.Read()
            Dim ls As New ListViewItem("", 0)
            ls.SubItems.Add(objDataReader.Item("REGISTRO"))
            ls.SubItems.Add(objDataReader.Item("NOME"))
            ls.SubItems.Add(objDataReader.Item("CODIN"))
            ls.SubItems.Add(objDataReader.Item("semana"))
            ls.SubItems.Add(objDataReader.Item("DATA"))
            LST_RETIRADA.Items.Add(ls)

        End While

        'colocar foco no ultimo item add


        SUB_DESCONECTAR()

    End Sub
    Private Function retorna_semanadoano(ByVal Data1 As Date)
        Dim dif As Integer
        Dim semana As Integer
        Dim ano As Integer = Data1.Year
        Dim data_inicio As Date = CDate("01/01/" & ano)
        Dim data_fim As Date
        Select Case data_inicio.DayOfWeek
            Case 0
                data_inicio = data_inicio
            Case 1
                data_inicio = DateAdd(DateInterval.Day, -1, data_inicio)
            Case 2
                data_inicio = DateAdd(DateInterval.Day, -2, data_inicio)
            Case 3
                data_inicio = DateAdd(DateInterval.Day, -3, data_inicio)
            Case 4
                data_inicio = DateAdd(DateInterval.Day, 3, data_inicio)
            Case 5
                data_inicio = DateAdd(DateInterval.Day, 2, data_inicio)
            Case 6
                data_inicio = DateAdd(DateInterval.Day, 1, data_inicio)
        End Select

        Select Case Data1.DayOfWeek
            Case 6
                data_fim = Data1
            Case 5
                data_fim = DateAdd(DateInterval.Day, 1, Data1)
            Case 4
                data_fim = DateAdd(DateInterval.Day, 2, Data1)
            Case 3
                data_fim = DateAdd(DateInterval.Day, 3, Data1)
            Case 2
                data_fim = DateAdd(DateInterval.Day, 4, Data1)
            Case 1
                data_fim = DateAdd(DateInterval.Day, 5, Data1)
            Case 0
                data_fim = DateAdd(DateInterval.Day, 6, Data1)
        End Select


        dif = DateDiff(DateInterval.Day, data_inicio, data_fim) - 1
        semana = dif / 7
        Return semana


    End Function
    Private Sub cbo_semana_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_semana.SelectedIndexChanged, LST_RETIRADA.SelectedIndexChanged

        LST_RETIRADA.Items.Clear()
        carrega_relatorio_excel()

    End Sub
    Private Sub BTN_EXCEL_Click(sender As Object, e As EventArgs) Handles BTN_EXCEL.Click

        Try
            Dim objExcel As New Excel.Application
            Dim bkWorkBook As Workbook
            Dim shWorkSheet As Worksheet
            Dim i As Integer
            Dim j As Integer

            objExcel = New Excel.Application
            bkWorkBook = objExcel.Workbooks.Add
            shWorkSheet = CType(bkWorkBook.ActiveSheet, Worksheet)

            For i = 1 To Me.LST_RETIRADA.Columns.Count - 1
                shWorkSheet.Cells(1, i + 1) = Me.LST_RETIRADA.Columns(i).Text
            Next
            For i = 0 To Me.LST_RETIRADA.Items.Count - 1
                For j = 0 To Me.LST_RETIRADA.Items(i).SubItems.Count - 1
                    Dim x As String = Me.LST_RETIRADA.Items(i).SubItems(j).Text
                    If j = 5 Then
                        shWorkSheet.Cells(i + 2, j + 1) = Date.Parse(Me.LST_RETIRADA.Items(i).SubItems(j).Text)
                        'Aqui poderia converter no excel, mas não consegui
                        'ElseIf j = 3 Then
                        'shWorkSheet.Cells(i + 2, j + 1) = String.Format(Me.LST_RETIRADA.Items(i).SubItems(j).Text)
                    Else
                        shWorkSheet.Cells(i + 2, j + 1) = Me.LST_RETIRADA.Items(i).SubItems(j).Text
                    End If

                Next
            Next

            objExcel.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub carrega_relatorio_excel()

        SUB_CONECTAR()
        'Busca no BD pelo numero da semana
        comandoSQL.CommandText = "SELECT REGISTRO, NOME, CODIN, SEMANA, DATA FROM TAB_CONTROLE_MASCARA WHERE SEMANA = '" & cbo_semana.Text & "'"
        objDataReader = comandoSQL.ExecuteReader


        Dim cont As Integer = 0 'CONTADOR DO WHILE

        adiciona_tabela()

        SUB_DESCONECTAR()

    End Sub
    Sub carrega_semana()

        SUB_CONECTAR()
        'filtro para só aparecer as semanas que já estão no DB
        comandoSQL.CommandText = "SELECT DISTINCT SEMANA FROM TAB_CONTROLE_MASCARA "
        objDataReader = comandoSQL.ExecuteReader

        While objDataReader.Read
            cbo_semana.Items.Add(objDataReader.Item("semana"))
        End While

        SUB_DESCONECTAR()

    End Sub
End Class

