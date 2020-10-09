Option Strict On
Public Class BookStore
    Dim intTotalQuantity As Integer
    Dim decTotalSales As Decimal
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim decPrice As Decimal
        Dim intQuantity As Integer
        Dim decSubTotal As Decimal
        Dim decSalesTax As Decimal
        Dim decTotal As Decimal

        Const constSalesTax As Single = 0.0725

        Try
            decPrice = Decimal.Parse(txtPrice.Text, Globalization.NumberStyles.Currency)
            intQuantity = Integer.Parse(txtQuantity.Text, Globalization.NumberStyles.Number)

            decSubTotal = decPrice * intQuantity
            decSalesTax = Decimal.Round(Convert.ToDecimal(decSubTotal * constSalesTax), 2)
            decTotal = decSubTotal + decSalesTax

            txtSubtotal.Text = decSubTotal.ToString("C")
            txtSalesTax.Text = decSalesTax.ToString("N")
            txtTotal.Text = decTotal.ToString("C")

            btnCompute.Enabled = False
            btnReset.Enabled = True

            intTotalQuantity += intQuantity
            decTotalSales += decTotal
        Catch
            MessageBox.Show("Data entered incorrectly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtBookTitle.Clear()
        txtISBN.Clear()
        txtPrice.Clear()
        txtQuantity.Clear()
        txtSubtotal.Clear()
        txtSalesTax.Clear()
        txtTotal.Clear()

        btnCompute.Enabled = True
        btnReset.Enabled = False

        txtBookTitle.Focus()
    End Sub

    Private Sub btnTotals_Click(sender As Object, e As EventArgs) Handles btnTotals.Click
        Try
            Dim decAverageSale As Decimal = decTotalSales / intTotalQuantity
            Dim strMessage As String = "Total Sales: " & decTotalSales.ToString("C") & ControlChars.NewLine _
                & "Total Books Sold: " & intTotalQuantity.ToString("N0") & ControlChars.NewLine _
                & "Average Book Value: " & decAverageSale.ToString("C")

            MessageBox.Show(strMessage, "Totals and Averages", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch exArithmeticException As ArithmeticException
            MessageBox.Show("No books have been sold yet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Unexpected error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
