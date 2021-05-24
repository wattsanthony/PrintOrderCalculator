''' <summary>
''' Form class for ordering print jobs
''' </summary>
Public Class PrintJobCalculator

    Private Const BASIC_SMALL As Integer = 30 ' base small print cost constant
    Private Const BASIC_MEDIUM As Integer = 50 ' base medium print cost constant
    Private Const BASIC_LARGE As Integer = 110 ' base large print cost constant

    Private Const FDM_PRINT As Double = 1.1 ' percentage increase for FDM constant
    Private Const SLA_PRINT As Double = 2.1 ' percentage increase for SLA constant

    Private Const ABS_MATERIAL As Double = 0.2 ' percentage increase for ABS Material constant
    Private Const ASA_MATERIAL As Double = 0.3 ' percentage increase for ASA Material constant

    Private Const CONTRACT_DISCOUNT As Double = 0.15 ' percentage off for contracts constant
    Private Const PRIORITY As Double = 20 ' priority fee constant

    ''' <summary>
    ''' Subroutine that tests this list view stuff - MUST READ THE FORM SELECTIONS FIRST! ADD TO AN ARRAY THAT HOLDS ITEMS
    ''' </summary>
    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnAddJob.Click

        Dim newString(3) As String ' Variable to hold string array for columns
        Dim newItem As ListViewItem ' Variable to hold listviewitem to be added
        Dim priceTotal As Double = 0 ' Variable to hold total price

        Dim type As String = "" ' Variable to hold type
        Dim material As String = "" ' Variable to hold material
        Dim size As String = "" ' Variable to hold size

        ' Checks radio button for print size and applies to the string
        ' Also applies first part of price calculations
        If rbtnSmall.Checked Then
            newString(2) = "Small"
            size = "Small"
        ElseIf rbtnMedium.Checked Then
            newString(2) = "Medium"
            size = "Medium"
        ElseIf rbtnLarge.Checked Then
            newString(2) = "Large"
            size = "Large"
        End If

        ' Checks radio button for print type and applies to the string
        ' Also applies second part of price calculations
        If rbtnBasic.Checked Then
            newString(0) = "Basic"
            type = "Basic"
        ElseIf rbtnFDMBasic.Checked Then
            newString(0) = "FDM"
            type = "FDM"
        ElseIf rbtnFDMABS.Checked Then
            newString(0) = "FDM"
            newString(1) = "ABS"
            type = "FDM"
            material = "ABS"
        ElseIf rbtnFDMASA.Checked Then
            newString(0) = "FDM"
            newString(1) = "ASA"
            type = "FDM"
            material = "ASA"
        ElseIf rbtnSLA.Checked Then
            newString(0) = "SLA"
            type = "SLA"
        End If

        ' Runs calculate price on the new job to get price then format and set to the string
        priceTotal = calculatePrice(type, material, size)
        newString(3) = Format(priceTotal, "#0.00")

        ' Makes the new item and adds it to the list view
        newItem = New ListViewItem(newString)
        lvTest.Items.Add(newItem)

        calculateTotal()

    End Sub

    ''' <summary>
    ''' Subroutine that handles the clear job button and recalculates the total
    ''' </summary>
    Private Sub btnClearJob_Click(sender As Object, e As EventArgs) Handles btnClearJob.Click

        ' Attempts to remove the selected item or exit if nothing selected
        Try
            lvTest.Items.RemoveAt(lvTest.SelectedIndices(0))
        Catch
            Exit Sub
        End Try

        calculateTotal()

    End Sub

    ''' <summary>
    ''' Function that calculates the total whenever called and updates the label field
    ''' </summary>
    Private Sub calculateTotal()

        Dim total As Double ' Total variable to hold running total

        If chbPriority.Checked Then
            total = PRIORITY
        Else
            total = 0
        End If

        ' Iterates through the items in list view and adds their price to total
        For Each item As ListViewItem In lvTest.Items

            Dim price As Double = 0 ' Temporary price holder variable

            price = item.SubItems(3).Text

            total += price

        Next

        ' Apply new total to label and format appropriately
        lblTotal.Text = Format(total, "#0.00")

    End Sub

    ''' <summary>
    ''' Subroutine that handles the contract checkbox and adjusts prices accordingly
    ''' </summary>
    Private Sub chbContract_CheckedChanged(sender As Object, e As EventArgs) Handles chbContract.CheckedChanged

        ' Checks if the contract button is checked or not then processes accordingly
        If chbContract.Checked Then
            ' Iterates through the items in list view and applies the discount to each one
            For Each item As ListViewItem In lvTest.Items

                Dim price As Double = 0 ' Temporary price holder

                price = item.SubItems(3).Text

                item.SubItems(3).Text = Format(price - price * CONTRACT_DISCOUNT, "#0.00")

            Next
        ElseIf chbContract.CheckState = False Then
            ' Iterates through the items in list view to get information for the price calculation function
            For Each item As ListViewItem In lvTest.Items

                Dim type As String = item.SubItems(0).Text ' type variable for reanalysing price
                Dim material As String = item.SubItems(1).Text ' type variable for reanalysing price
                Dim size As String = item.SubItems(2).Text ' size variable for reanalysing price

                ' Perform price check for item
                item.SubItems(3).Text = Format(calculatePrice(type, material, size), "#0.00")

            Next
        End If

        calculateTotal()

    End Sub

    ''' <summary>
    ''' Subroutine that handles the priority checkbox and adjusts prices accordingly
    ''' </summary>
    Private Sub chbPriority_CheckedChanged(sender As Object, e As EventArgs) Handles chbPriority.CheckedChanged

        ' Checks if priority was turned on or off and adjusts the total
        If chbPriority.Checked Then
            lblTotal.Text = Format(lblTotal.Text + PRIORITY, "#0.00")
        ElseIf chbPriority.CheckState = False Then
            lblTotal.Text = Format(lblTotal.Text - PRIORITY, "#0.00")
        End If

    End Sub

    ''' <summary>
    ''' Subroutine that ensures all forms close when this one is closed
    ''' </summary>
    Private Sub closingEvent(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        Application.Exit()

    End Sub

    ''' <summary>
    ''' Function that calculates the price of an item based off its type, material and size
    ''' </summary>
    ''' <param name="type">Type of print job</param>
    ''' <param name="material">Material used if applicable ("" if not)</param>
    ''' <param name="size">Size of print job</param>
    ''' <returns>A Double for the price</returns>
    Private Function calculatePrice(ByRef type As String, material As String, size As String) As Double

        Dim totalPrice As Double = 0 ' placeholder variable for running total

        ' Check size and add base cost
        If size = "Small" Then
            totalPrice += BASIC_SMALL
        ElseIf size = "Medium" Then
            totalPrice += BASIC_MEDIUM
        ElseIf size = "Large" Then
            totalPrice += BASIC_LARGE
        End If

        ' Check type (and material) and add multiplier
        If type = "FDM" And material = "" Then
            totalPrice += totalPrice * FDM_PRINT
        ElseIf type = "FDM" And material = "ABS" Then
            totalPrice += totalPrice * FDM_PRINT
            totalPrice += totalPrice * ABS_MATERIAL
        ElseIf type = "FDM" And material = "ASA" Then
            totalPrice += totalPrice * FDM_PRINT
            totalPrice += totalPrice * ASA_MATERIAL
        ElseIf type = "SLA" Then
            totalPrice += totalPrice * SLA_PRINT
        End If

        ' apply contract percent if checked
        If chbContract.Checked Then
            totalPrice -= totalPrice * CONTRACT_DISCOUNT
        End If

        Return totalPrice

    End Function

End Class