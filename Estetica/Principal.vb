Public Class Principal
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BotonCitas.Click
        My.Forms.Citas.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BotonClientes.Click
        My.Forms.Clientes.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BotonEmpleados.Click
        My.Forms.Trabajadores.ShowDialog()
    End Sub

    Private Sub BotonCerrar_Click(sender As Object, e As EventArgs) Handles BotonCerrar.Click
        Me.Close()
    End Sub
End Class