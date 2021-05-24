''' <summary>
''' Initial form class that begins the invoice process
''' </summary>
Public Class MainForm

    ''' <summary>
    ''' Subroutine that navigates to the printer purchase form
    ''' </summary>
    Private Sub btnPrinterPurchase_Click(sender As Object, e As EventArgs) Handles btnPrinterPurchase.Click

        ' Creates the new form for printer orders and swaps to it
        Dim printerPurchase As New PrinterOrder
        Me.Hide()
        printerPurchase.Show()

    End Sub

    ''' <summary>
    ''' Subroutine that navigates to the print request order form
    ''' </summary>
    Private Sub btnPrintRequest_Click(sender As Object, e As EventArgs) Handles btnPrintRequest.Click

        ' Creates the new form for print job orders and swaps to it
        Dim printJobPurchase As New PrintJobCalculator
        Me.Hide()
        printJobPurchase.Show()

    End Sub

End Class
