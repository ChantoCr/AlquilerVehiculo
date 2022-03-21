Public Class Form1
    Dim lstAlquiler As New List(Of Alquiler)
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            Dim strPlaca As String = txtPlaca.Text
            Dim dblCantDias As Double = CType(txtCantDias.Text, Double)
            Dim dblTarifaDiaria As Double = CType(txtTarifaDiaria.Text.ToString, Double)
            Dim intCantPasajeros As Integer = CType(cbxPasajeros.SelectedItem.ToString, Integer)
            Dim blnGPS As Boolean = rbtnSIGPS.Checked
            Dim blnSeguroBasico As Boolean = rbtnBasico.Checked
            Dim blnSeguroCompleto As Boolean = rbtnCompleto.Checked
            Dim strPasaporte As String = txtNumPasaporte.Text

            Dim Alquiler As New Alquiler(strPlaca, blnGPS, blnSeguroBasico, blnSeguroCompleto,
                                        cbxPasajeros.SelectedItem, dblTarifaDiaria, dblCantDias, strPasaporte)

            lstAlquiler.Add(Alquiler)

            MessageBox.Show("Alquiler Agregado")

        Catch ex As Exception
            MessageBox.Show("Digite los datos correctamente" & vbCrLf & ex.Message)
        End Try

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim intOpcion As Integer


        intOpcion = MessageBox.Show("¿Desea Salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If intOpcion = 6 Then
            Application.Exit()

        End If

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtPlaca.Clear()
        txtTarifaDiaria.Clear()
        txtNumPasaporte.Clear()
        txtTarifaDiaria.Clear()
        cbxPasajeros.ResetText()
        rbtnBasico.Checked = False
        rbtnCompleto.Checked = False
        rbtnNoGPS.Checked = False
        rbtnSIGPS.Checked = False
        txtGPS.Clear()
        txtSeguro.Clear()
        lvMetodos.Items.Clear()
        lstAlquiler.Clear()
        txtCantDias.Clear()


    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        lvMetodos.Items.Clear()
        Dim lviFila As ListViewItem
        Dim dblSeguro As Double = 0
        Dim dblGPS As Double = 0
        Try
            For Each Alquiler In lstAlquiler
                lviFila = lvMetodos.Items.Add(Alquiler.Placa)
                lviFila.SubItems.Add(Alquiler.MontoAlquiler().ToString("C2"))
                lviFila.SubItems.Add(Alquiler.MontoSeguro().ToString("C2"))
                lviFila.SubItems.Add(Alquiler.CostoGPS().ToString("C2"))
                lviFila.SubItems.Add(Alquiler.MontoDescporCapacidad().ToString("C2"))
                lviFila.SubItems.Add(Alquiler.Total().ToString("C2"))
                dblSeguro += Alquiler.MontoSeguro().ToString("C2")
                dblGPS += Alquiler.CostoGPS().ToString("C2")
            Next
            txtGPS.Text = dblGPS.ToString("C2")
            txtSeguro.Text = dblSeguro.ToString("C2")
        Catch ex As Exception
            MessageBox.Show("Error" & vbCrLf & ex.Message)

        End Try
    End Sub
End Class
