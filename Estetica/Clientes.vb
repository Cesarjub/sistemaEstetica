Imports System.Data.SQLite
Imports System.Runtime.InteropServices
Public Class Clientes

    Dim DB_Path As String
    Dim TableName As String = "CLIENTE"
    Dim IdCliente, NombreCliente, TelefonoCliente As String
    Private Sub BotonCerrar_Click(sender As Object, e As EventArgs) Handles BotonCerrar.Click
        Me.Close()
    End Sub

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CenterToScreen()

        DB_Path = "Data Source = C:\Users\cesar\Documents\Estetica.db"

        Dim SQLiteCon As New SQLiteConnection(DB_Path)

        Try
            SQLiteCon.Open()
        Catch ex As Exception
            SQLiteCon.Dispose()
            SQLiteCon = Nothing
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Dim TableDB As New Data.DataTable
        Dim SQL As String = "select*  from " & TableName & " order by NombreCliente"

        Try
            LoadDB(SQL, TableDB, SQLiteCon)
            DataGridViewTable.DataSource = Nothing
            DataGridViewTable.DataSource = TableDB
            DataGridViewTable.ClearSelection()

        Catch ex As Exception
            MsgBox(ex.Message + "El pedo es aqui")
        End Try

        TableDB.Dispose()
        TableDB = Nothing
        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing

    End Sub

    Private Sub LoadDB(q As String, tbl As Data.DataTable, cn As SQLiteConnection)
        Dim SQLiteDA As New SQLiteDataAdapter(q, cn)
        SQLiteDA.Fill(tbl)
        SQLiteDA.Dispose()
        SQLiteDA = Nothing
    End Sub

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function

    Private Sub Trabajadores_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        DataGridViewTable.ClearSelection()
        btnBuscar.Focus()
        SendMessage(Me.buscar.Handle, &H1501, 0, "Search...")
    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress

        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack Or e.KeyChar = "+") Then
            MessageBox.Show("Invalid Input! Numbers Only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Handled = True
        End If

    End Sub

    Private Sub btnRegistrar_MouseClick(sender As Object, e As MouseEventArgs) Handles btnRegistrar.MouseClick

        If txtId.Text = "" And txtNombre.Text = "" And txtTelefono.Text = "" Then

            MessageBox.Show("No se han completado todos los datos, por favor complete", "Fallido")
            Return

        End If

        If txtId.Text = "" Then

            MessageBox.Show("ID no se ha completado, por favor complete ID", "Fallido")
            Return

        End If

        If txtNombre.Text = "" Then

            MessageBox.Show("Nombre no se ha completado, por favor complete Nombre", "Fallido")
            Return

        End If

        If txtTelefono.Text = "" Then

            MessageBox.Show("Salario no se ha completado, por favor complete Salario", "Fallido")
            Return

        End If

        Dim SQLiteCon As New SQLiteConnection(DB_Path)

        Try
            SQLiteCon.Open()
        Catch ex As Exception
            SQLiteCon.Dispose()
            SQLiteCon = Nothing
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Try
            ExecuteNonQuery("insert into " & TableName & " (IdCliente, NombreCliente, TelefonoCliente) values ('" & txtId.Text & "','" & txtNombre.Text _
                            & "','" & txtTelefono.Text & "')", SQLiteCon)
            MsgBox("Datos insertados correctamente")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing

        btnRefrescar_MouseClick(sender, e)
        btnLimpiar_MouseClick(sender, e)
    End Sub

    Private Sub btnRefrescar_MouseClick(sender As Object, e As EventArgs) Handles btnRefrescar.Click

        Dim SQLiteCon As New SQLiteConnection(DB_Path)

        Try
            SQLiteCon.Open()
        Catch ex As Exception
            SQLiteCon.Dispose()
            SQLiteCon = Nothing
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Dim TableDB As New System.Data.DataTable

        Try
            LoadDB("select*from " & TableName & " order by NombreCliente", TableDB, SQLiteCon)
            DataGridViewTable.DataSource = Nothing
            DataGridViewTable.DataSource = TableDB
            DataGridViewTable.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        TableDB.Dispose()
        TableDB = Nothing
        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing

    End Sub

    Private Sub btnEliminar_MouseClick(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Dim SQLiteCon As New SQLiteConnection(DB_Path)

        Try
            SQLiteCon.Open()
        Catch ex As Exception
            SQLiteCon.Dispose()
            SQLiteCon = Nothing
            MsgBox(ex.Message)
            Exit Sub
        End Try

        If DataGridViewTable.RowCount = 0 Then
            MsgBox("No se puede elimiar, la tabla esta vacia", MsgBoxStyle.Critical, "Fallido")
            Return
        End If

        If DataGridViewTable.SelectedRows.Count = 0 Then
            MsgBox("No se puede eliminar, selecciona alguna registro de la tabla", MsgBoxStyle.Critical, "Fallido")
            Return
        End If

        If MsgBox("¿Esta seguro de eliminar el registro?", CType(MsgBoxStyle.Question + MsgBoxStyle.OkCancel, Global.Microsoft.VisualBasic.MsgBoxStyle), "Confirmacion") = MsgBoxResult.Cancel Then Return

        Try
            If AllCellsSelected(DataGridViewTable) = True Then
                ExecuteNonQuery("delete from " & TableName & "", SQLiteCon)
                SQLiteCon.Close()
                SQLiteCon.Dispose()
                SQLiteCon = Nothing

                btnRefrescar_MouseClick(sender, e)
                Return
            End If

            For Each row As DataGridViewRow In DataGridViewTable.SelectedRows
                If row.Selected = True Then
#Disable Warning BC42017 ' Resolución enlazada en tiempo de ejecución
                    ExecuteNonQuery(query:=$"delete from {TableName} where IdCliente='{row.DataBoundItem(0).ToString}'", SQLiteCon)
#Enable Warning BC42017 ' Resolución enlazada en tiempo de ejecución
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing

        btnRefrescar_MouseClick(sender, e)

    End Sub

    Private Sub btnModificar_MouseClick(sender As Object, e As EventArgs) Handles btnModificar.Click

        If txtNombre.Text = "" Then
            MessageBox.Show("El nombre no se ha compeltado, por favor complete el nombre", "Fallido")
            Return
        End If

        If txtTelefono.Text = "" Then
            MessageBox.Show("El salario no se ha compeltado, por favor complete el salario", "Fallido")
            Return
        End If

        Dim SQLiteCon As New SQLiteConnection(DB_Path)

        Try
            SQLiteCon.Open()
        Catch ex As Exception
            SQLiteCon.Dispose()
            SQLiteCon = Nothing
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Try
            ExecuteNonQuery("update " & TableName & " set NombreCliente='" & txtNombre.Text & "',TelefonoCliente='" & txtTelefono.Text _
                            & "' WHERE IdCliente = '" & txtId.Text & "'", SQLiteCon)
            MsgBox("Actualizacion exitosa")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing

        btnRefrescar_MouseClick(sender, e)
        btnLimpiar_MouseClick(sender, e)

    End Sub

    Private Sub btnCrearId_MouseClick(sender As Object, e As MouseEventArgs) Handles btnCrearID.MouseClick

        Dim r As Random = New Random
        Dim num As Integer
        num = (r.Next(1, 9999))
        Dim IDMaker As String = Strings.Right("0000" & num.ToString(), 4)
        txtId.Text = IDMaker

        Dim SQLiteCon As New SQLiteConnection(DB_Path)

        Try
            SQLiteCon.Open()
        Catch ex As Exception
            SQLiteCon.Dispose()
            SQLiteCon = Nothing
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Dim TableDB As New System.Data.DataTable

        'The command to detect whether the id that is created is already registered, because the id is a "primary key" so it cannot be the same.
        Try
            LoadDB("select IdCliente from " & TableName & " where IdCliente ='" & txtId.Text & "'", TableDB, SQLiteCon)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If TableDB.Rows.Count > 0 Then
            btnCrearId_MouseClick(sender, e)
        End If

    End Sub

    Private Sub btnLimpiar_MouseClick(sender As Object, e As MouseEventArgs) Handles btnLimpiar.MouseClick

        txtId.Clear()
        txtNombre.Clear()
        txtTelefono.Clear()
        btnRegistrar.Enabled = True
        btnModificar.Enabled = False
        btnCrearID.Enabled = True

    End Sub

    Private Sub DataGridViewTable_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)

        'Dim i As Integer
        'With DataGridViewTable
        '    If e.RowIndex >= 0 Then
        '        i = .CurrentRow.Index
        '        IDRam = .Rows(i).Cells("ID").Value.ToString
        '    End If
        'End With

    End Sub



    Private Sub buscar_TextChanged(sender As Object, e As EventArgs) Handles buscar.TextChanged

        Dim SearchCMD As String
        If buscar.Text = Nothing Then
            buscar.CharacterCasing = CharacterCasing.Normal
            SendMessage(Me.buscar.Handle, &H1501, 0, "Search...")
        Else
            buscar.CharacterCasing = CharacterCasing.Upper
        End If

        If buscar.Text = Nothing Then
            SearchCMD = "select*from " & TableName & " order by NombreCliente"
        Else
            SearchCMD = "select*from " & TableName & " where NombreCliente like'" & buscar.Text & "%'"
            SearchCMD = "select*from " & TableName & " where NombreCliente like'" & buscar.Text & "%'"
        End If

        Dim SQLiteCon As New SQLiteConnection(DB_Path)

        Try
            SQLiteCon.Open()
        Catch ex As Exception
            SQLiteCon.Dispose()
            SQLiteCon = Nothing
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Dim TableDB As New Data.DataTable

        Try
            LoadDB(SearchCMD, TableDB, SQLiteCon)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If TableDB.Rows.Count > 0 Then
            DataGridViewTable.DataSource = Nothing
            DataGridViewTable.DataSource = TableDB
        End If
        TableDB.Dispose()
        TableDB = Nothing
        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing

    End Sub


    'Sub to write to the database
    Private Sub ExecuteNonQuery(query As String, cn As SQLiteConnection)
        Dim SQLiteCM As New SQLiteCommand(query, cn)
        SQLiteCM.ExecuteNonQuery()
        SQLiteCM.Dispose()
        SQLiteCM = Nothing
    End Sub

    'Function to detect datagridview is selected all
    Private Function AllCellsSelected(dgv As DataGridView) As Boolean
        AllCellsSelected = (DataGridViewTable.SelectedCells.Count = (DataGridViewTable.RowCount * DataGridViewTable.Columns.GetColumnCount(DataGridViewElementStates.Visible)))
    End Function

    Private Sub ToolStripMenuItemEditar_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemEditar.Click

        If AllCellsSelected(DataGridViewTable) = False Then
            txtId.Text = IdCliente
            txtNombre.Text = NombreCliente
            txtTelefono.Text = TelefonoCliente
            txtId.Enabled = False
            btnRegistrar.Enabled = False
            btnModificar.Enabled = True
            btnCrearID.Enabled = False
        Else
            MsgBox("No se puede editar porque la fila de la tabla está seleccionada toda. Elija uno para editar.", MsgBoxStyle.Critical, "Fallido")
        End If

    End Sub

    Private Sub ToolStripMenuItemEliminar_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemEliminar.Click

        btnEliminar_MouseClick(sender, e)

    End Sub

    Private Sub ToolStripMenuItemSelectAll_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemSelectAll.Click

        DataGridViewTable.SelectAll()

    End Sub

    Private Sub DataGridViewTable_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewTable.CellMouseDown

        If AllCellsSelected(DataGridViewTable) = False Then
            If e.Button = MouseButtons.Right Then
                DataGridViewTable.CurrentCell = DataGridViewTable(e.ColumnIndex, e.RowIndex)
                Dim i As Integer
                With DataGridViewTable
                    If e.RowIndex >= 0 Then
                        i = .CurrentRow.Index

                        IdCliente = .Rows(i).Cells("IdCliente").Value.ToString
                        NombreCliente = .Rows(i).Cells("NombreCliente").Value.ToString
                        TelefonoCliente = .Rows(i).Cells("TelefonoCliente").Value.ToString
                    End If
                End With
            End If
        End If

    End Sub
End Class