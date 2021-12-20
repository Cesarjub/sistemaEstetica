Imports System.Data.SQLite
Imports System.Runtime.InteropServices

Public Class Citas

    Dim DB_Path As String
    Dim TableName As String = "CITA"
    Dim IdCita, FechaCita, IdClienteServicio, IdTrabajador As String

    Private Sub BotonCerrar_Click(sender As Object, e As EventArgs) Handles BotonCerrar.Click
        Me.Close()
    End Sub

    Private Sub Citas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        Dim SQL As String = "SELECT c.IdCita, s.DescripcionServicio, t.NombreTrabajador FROM cita c INNER JOIN varios_servicios v ON v.IdClienteServicio = c.IdClienteServicio INNER JOIN trabajador t ON t.IdTrabajador = c.IdTrabajador INNER JOIN servicio s ON v.IdServicio = s.IdServicio"

        Try
            LoadDB(SQL, TableDB, SQLiteCon)
            TablaCitas.DataSource = Nothing
            TablaCitas.DataSource = TableDB
            TablaCitas.ClearSelection()

        Catch ex As Exception
            MsgBox(ex.Message + "El problema es ")
        End Try

        TableDB.Dispose()
        TableDB = Nothing
        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing

    End Sub

    Private Sub ComboBoxClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboCliente.Items.Add("Luis")
        ComboCliente.Items.Add("Pepe")
        ComboCliente.Items.Add("Ana")

    End Sub

    Private Sub ComboBoxTrabajadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ClienteTrabajador.Items.Add("Maria")
        ClienteTrabajador.Items.Add("Juana")

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

    Private Sub BotonLimpiarCampos_MouseClick(sender As Object, e As MouseEventArgs) Handles BotonLimpiarCampos.MouseClick

        txtID.Clear()
        txtTarifa.Clear()
        txtDescripcion.Clear()

        BotonRegistrar.Enabled = True
        BotonModificar.Enabled = False

    End Sub

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress

        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack Or e.KeyChar = "+") Then
            MessageBox.Show("¡¡Solo acepta numeros!!.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Handled = True
        End If

    End Sub

    Private Sub txtTarifa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTarifa.KeyPress

        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack Or e.KeyChar = "+") Then
            MessageBox.Show("¡¡Solo acepta numeros!!.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Handled = True
        End If

    End Sub

    Private Sub ExecuteNonQuery(query As String, cn As SQLiteConnection)
        Dim SQLiteCM As New SQLiteCommand(query, cn)
        SQLiteCM.ExecuteNonQuery()
        SQLiteCM.Dispose()
        SQLiteCM = Nothing
    End Sub

    Private Sub BotonEliminar_Click(sender As Object, e As EventArgs) Handles BotonEliminar.Click

        Dim SQLiteCon As New SQLiteConnection(DB_Path)

        Try
            SQLiteCon.Open()
        Catch ex As Exception
            SQLiteCon.Dispose()
            SQLiteCon = Nothing
            MsgBox(ex.Message)
            Exit Sub
        End Try

        If TablaCitas.RowCount = 0 Then
            MsgBox("No se puede elimiar, la tabla esta vacia", MsgBoxStyle.Critical, "Fallido")
            Return
        End If

        If TablaCitas.SelectedRows.Count = 0 Then
            MsgBox("No se puede eliminar, selecciona alguna registro de la tabla", MsgBoxStyle.Critical, "Fallido")
            Return
        End If

        If MsgBox("¿Esta seguro de eliminar el registro?", CType(MsgBoxStyle.Question + MsgBoxStyle.OkCancel, Global.Microsoft.VisualBasic.MsgBoxStyle), "Confirmacion") = MsgBoxResult.Cancel Then Return

        Try
            If AllCellsSelected(TablaCitas) = True Then
                ExecuteNonQuery("delete from " & TableName & "", SQLiteCon)
                SQLiteCon.Close()
                SQLiteCon.Dispose()
                SQLiteCon = Nothing

                BotonRefrescar_MouseClick(sender, e)
                Return
            End If

            For Each row As DataGridViewRow In TablaCitas.SelectedRows
                If row.Selected = True Then
#Disable Warning BC42017 ' Resolución enlazada en tiempo de ejecución
                    ExecuteNonQuery(query:=$"delete from {TableName} where IdCita='{row.DataBoundItem(0).ToString}'", SQLiteCon)
#Enable Warning BC42017 ' Resolución enlazada en tiempo de ejecución
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing

        BotonRefrescar_MouseClick(sender, e)

    End Sub

    Private Sub BotonRegistrar_MouseClick(sender As Object, e As MouseEventArgs) Handles BotonRegistrar.MouseClick

        If txtID.Text = "" And txtTarifa.Text = "" And txtDescripcion.Text = "" Then

            MessageBox.Show("No se han completado todos los datos, por favor complete", "Fallido")
            Return

        End If

        If txtID.Text = "" Then

            MessageBox.Show("ID no se ha completado, por favor complete ID", "Fallido")
            Return

        End If

        If txtDescripcion.Text = "" Then

            MessageBox.Show("Descrpcion no se ha completado, por favor complete la descripcion", "Fallido")
            Return

        End If

        If txtTarifa.Text = "" Then

            MessageBox.Show("Tarifa no se ha completado, por favor complete la tarifa", "Fallido")
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
            Dim fechaFrmt As String = Format(calendarioFecha.Value, "aaaa-mm-dd")

            ExecuteNonQuery("INSERT INTO `cita` (`IdCita`, `FechaCita`, `IdClienteServicio`, `IdTrabajador`) VALUES ('" & txtID.Text & "', '" & fechaFrmt & "', '" & 1 & "', '" & 1 & "')", SQLiteCon)
            MsgBox("Datos insertados correctamente")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing

        BotonRefrescar_MouseClick(sender, e)
        BotonLimpiarCampos_MouseClick(sender, e)

    End Sub

    Private Sub BotonRefrescar_MouseClick(sender As Object, e As MouseEventArgs) Handles BotonRefrescar.MouseClick

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
            LoadDB("SELECT c.IdCita, s.DescripcionServicio, t.NombreTrabajador FROM cita c INNER JOIN varios_servicios v ON v.IdClienteServicio = c.IdClienteServicio INNER JOIN trabajador t ON t.IdTrabajador = c.IdTrabajador INNER JOIN servicio s ON v.IdServicio = s.IdServicio", TableDB, SQLiteCon)
            TablaCitas.DataSource = Nothing
            TablaCitas.DataSource = TableDB
            TablaCitas.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        TableDB.Dispose()
        TableDB = Nothing
        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing

    End Sub

    Private Sub BuscarCita_TextChanged(sender As Object, e As EventArgs) Handles BuscarCita.TextChanged

        Dim SearchCMD As String
        If BuscarCita.Text = Nothing Then
            BuscarCita.CharacterCasing = CharacterCasing.Normal
            SendMessage(Me.BuscarCita.Handle, &H1501, 0, "Search...")
        Else
            BuscarCita.CharacterCasing = CharacterCasing.Upper
        End If

        If BuscarCita.Text = Nothing Then
            SearchCMD = "SELECT c.IdCita, s.DescripcionServicio, t.NombreTrabajador FROM cita c INNER JOIN varios_servicios v ON v.IdClienteServicio = c.IdClienteServicio INNER JOIN trabajador t ON t.IdTrabajador = c.IdTrabajador INNER JOIN servicio s ON v.IdServicio = s.IdServicio"
        Else
            SearchCMD = "SELECT c.IdCita, s.DescripcionServicio, t.NombreTrabajador FROM cita c INNER JOIN varios_servicios v ON v.IdClienteServicio = c.IdClienteServicio INNER JOIN trabajador t ON t.IdTrabajador = c.IdTrabajador INNER JOIN servicio s ON v.IdServicio = s.IdServicio " & " where IdCita like'" & BuscarCita.Text & "%'"
            SearchCMD = "SELECT c.IdCita, s.DescripcionServicio, t.NombreTrabajador FROM cita c INNER JOIN varios_servicios v ON v.IdClienteServicio = c.IdClienteServicio INNER JOIN trabajador t ON t.IdTrabajador = c.IdTrabajador INNER JOIN servicio s ON v.IdServicio = s.IdServicio" & " where IdCita like'" & BuscarCita.Text & "%'"
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
            TablaCitas.DataSource = Nothing
            TablaCitas.DataSource = TableDB
        End If
        TableDB.Dispose()
        TableDB = Nothing
        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing

    End Sub

    'Function to detect datagridview is selected all
    Private Function AllCellsSelected(dgv As DataGridView) As Boolean
        AllCellsSelected = (TablaCitas.SelectedCells.Count = (TablaCitas.RowCount * TablaCitas.Columns.GetColumnCount(DataGridViewElementStates.Visible)))
    End Function

    Private Sub ToolStripMenuItemEditar_Click(sender As Object, e As EventArgs)

        If AllCellsSelected(TablaCitas) = False Then
            txtID.Text = IdCita

            txtID.Enabled = False
            BotonRegistrar.Enabled = False
            BotonModificar.Enabled = True
            BotonEliminar.Enabled = False
        Else
            MsgBox("No se puede editar porque la fila de la tabla está seleccionada toda. Elija uno para editar.", MsgBoxStyle.Critical, "Fallido")
        End If

    End Sub

    Private Sub BotonModificar_MouseClick(sender As Object, e As MouseEventArgs) Handles BotonModificar.MouseClick
        If txtID.Text = "" And txtTarifa.Text = "" And txtDescripcion.Text = "" Then

            MessageBox.Show("No se han completado todos los datos, por favor complete", "Fallido")
            Return

        End If

        If txtID.Text = "" Then

            MessageBox.Show("ID no se ha completado, por favor complete ID", "Fallido")
            Return

        End If

        If txtDescripcion.Text = "" Then

            MessageBox.Show("Descrpcion no se ha completado, por favor complete la descripcion", "Fallido")
            Return

        End If

        If txtTarifa.Text = "" Then

            MessageBox.Show("Tarifa no se ha completado, por favor complete la tarifa", "Fallido")
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
            Dim fechaFrmt As String = Format(calendarioFecha.Value, "aaaa-mm-dd")

            ExecuteNonQuery("update " & TableName & " set FechaCita='" & fechaFrmt & "',IdTrabajador='" & 1 & "',IdClienteServicio='" & 2 _
                            & "' WHERE IdCita = '" & txtID.Text & "'", SQLiteCon)
            MsgBox("Datos modificados correctamente")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing

        BotonRefrescar_MouseClick(sender, e)
        BotonLimpiarCampos_MouseClick(sender, e)
    End Sub

    Private Sub ToolStripMenuItemEliminar_Click(sender As Object, e As EventArgs)

        BotonEliminar_Click(sender, e)

    End Sub

    Private Sub ToolStripMenuItemSelectAll_Click(sender As Object, e As EventArgs)

        TablaCitas.SelectAll()

    End Sub

    Private Sub TablaCitas_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles TablaCitas.CellMouseDown

        If AllCellsSelected(TablaCitas) = False Then
            If e.Button = MouseButtons.Right Then
                TablaCitas.CurrentCell = TablaCitas(e.ColumnIndex, e.RowIndex)
                Dim i As Integer
                With TablaCitas
                    If e.RowIndex >= 0 Then
                        i = .CurrentRow.Index

                        IdCita = .Rows(i).Cells("IdCita").Value.ToString
                        'FechaCita = .Rows(i).Cells("FechaCita").Value.ToString
                        IdClienteServicio = .Rows(i).Cells("DescripcionServicio").Value.ToString
                        IdTrabajador = .Rows(i).Cells("NombreTrabajador").Value.ToString
                    End If
                End With
            End If
        End If

    End Sub

End Class