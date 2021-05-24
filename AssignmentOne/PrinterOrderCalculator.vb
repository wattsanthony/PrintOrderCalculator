''' <summary>
''' Form class for ordering 3D printers
''' </summary>
Public Class PrinterOrder

    Private Const BASE_MODEL As Integer = 799 ' base model price constant
    Private Const HIGH_END_MODEL As Integer = 3999 ' high end model price constant

    ''' <summary>
    ''' Subroutine to handle textbox change for the base model to update the total
    ''' </summary>
    Private Sub baseModelTextbox_TextChanged(sender As Object, e As EventArgs) Handles txtBaseModel.TextChanged

        updateTotal()

    End Sub

    ''' <summary>
    ''' Subroutine to handle textbox change for the base model to update the total
    ''' </summary>
    Private Sub highEndModelTextBox_TextChanged(sender As Object, e As EventArgs) Handles txtHighEndModel.TextChanged

        updateTotal()

    End Sub

    ''' <summary>
    ''' Subroutine to update the total when run
    ''' </summary>
    Private Sub updateTotal()

        Dim countBase As Integer = 0 ' Count holder for base models on order
        Dim countHighEnd As Integer = 0 ' Count holder for high end models on order

        ' Attempt to take textbox value if numeric conversion can be done
        Try
            countBase = Convert.ToInt32(txtBaseModel.Text)
        Catch
            Exit Try
        End Try

        ' Attempt to take textbox value if numeric conversion can be done
        Try
            countHighEnd = Convert.ToInt32(txtHighEndModel.Text)
        Catch
            Exit Try
        End Try

        ' Update label for total to add the amount of printers at their prices
        lblTotal.Text = (BASE_MODEL * countBase) + (HIGH_END_MODEL * countHighEnd)

    End Sub

    ''' <summary>
    ''' Subroutine that ensures all forms close when this one is closed
    ''' </summary>
    Private Sub closingEvent(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        Application.Exit()

    End Sub

End Class