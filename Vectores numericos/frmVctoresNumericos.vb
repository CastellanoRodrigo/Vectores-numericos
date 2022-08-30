Public Class frmVctoresNumericos
    Dim Mes() As String = {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"}
    Dim Ventas(11) As Decimal

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Dim i As Integer = cmbMes.SelectedIndex
        Ventas(i) = Ventas(i) + txtImporte.Text
        MessageBox.Show("Datos cargados correctamente")
        txtImporte.Text = ""
    End Sub

    Private Sub frmVctoresNumericos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer = 0
        While i < 12
            cmbMes.Items.Add(Mes(i))
            i = i + 1
        End While
        cmbMes.SelectedIndex = 0
    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        Dim i As Integer = 0
        dgvVentas.Rows.Clear()

        While i < 12
            dgvVentas.Rows.Add(Mes(i), Ventas(i))
            i = i + 1
        End While
    End Sub
End Class
