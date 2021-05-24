<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.alignMainForm = New System.Windows.Forms.TableLayoutPanel()
        Me.btnPrintRequest = New System.Windows.Forms.Button()
        Me.lblMainFormTitle = New System.Windows.Forms.Label()
        Me.btnPrinterPurchase = New System.Windows.Forms.Button()
        Me.alignMainForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'alignMainForm
        '
        Me.alignMainForm.ColumnCount = 1
        Me.alignMainForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.alignMainForm.Controls.Add(Me.lblMainFormTitle, 0, 0)
        Me.alignMainForm.Controls.Add(Me.btnPrinterPurchase, 0, 1)
        Me.alignMainForm.Controls.Add(Me.btnPrintRequest, 0, 2)
        Me.alignMainForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.alignMainForm.Location = New System.Drawing.Point(0, 0)
        Me.alignMainForm.Name = "alignMainForm"
        Me.alignMainForm.RowCount = 3
        Me.alignMainForm.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.alignMainForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.alignMainForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.alignMainForm.Size = New System.Drawing.Size(394, 461)
        Me.alignMainForm.TabIndex = 0
        '
        'btnPrintRequest
        '
        Me.btnPrintRequest.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPrintRequest.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintRequest.Location = New System.Drawing.Point(62, 330)
        Me.btnPrintRequest.Name = "btnPrintRequest"
        Me.btnPrintRequest.Padding = New System.Windows.Forms.Padding(10)
        Me.btnPrintRequest.Size = New System.Drawing.Size(270, 60)
        Me.btnPrintRequest.TabIndex = 2
        Me.btnPrintRequest.Text = "Printing Order"
        Me.btnPrintRequest.UseVisualStyleBackColor = True
        '
        'lblMainFormTitle
        '
        Me.lblMainFormTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMainFormTitle.AutoSize = True
        Me.lblMainFormTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainFormTitle.Location = New System.Drawing.Point(53, 0)
        Me.lblMainFormTitle.Name = "lblMainFormTitle"
        Me.lblMainFormTitle.Padding = New System.Windows.Forms.Padding(10)
        Me.lblMainFormTitle.Size = New System.Drawing.Size(288, 57)
        Me.lblMainFormTitle.TabIndex = 0
        Me.lblMainFormTitle.Text = "Client Order Type"
        '
        'btnPrinterPurchase
        '
        Me.btnPrinterPurchase.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPrinterPurchase.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrinterPurchase.Location = New System.Drawing.Point(62, 128)
        Me.btnPrinterPurchase.Name = "btnPrinterPurchase"
        Me.btnPrinterPurchase.Padding = New System.Windows.Forms.Padding(10)
        Me.btnPrinterPurchase.Size = New System.Drawing.Size(270, 60)
        Me.btnPrinterPurchase.TabIndex = 1
        Me.btnPrinterPurchase.Text = "3D Printer Purchase"
        Me.btnPrinterPurchase.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 461)
        Me.Controls.Add(Me.alignMainForm)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(410, 500)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(410, 500)
        Me.Name = "MainForm"
        Me.Text = "3D Printers International Quote System"
        Me.alignMainForm.ResumeLayout(False)
        Me.alignMainForm.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents alignMainForm As TableLayoutPanel
    Friend WithEvents lblMainFormTitle As Label
    Friend WithEvents btnPrintRequest As Button
    Friend WithEvents btnPrinterPurchase As Button
End Class
