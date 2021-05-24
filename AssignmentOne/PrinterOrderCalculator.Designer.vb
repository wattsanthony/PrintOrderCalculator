<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PrinterOrder
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.alignPrinterOrder = New System.Windows.Forms.TableLayoutPanel()
        Me.txtHighEndModel = New System.Windows.Forms.TextBox()
        Me.lblPrinterOrderTitle = New System.Windows.Forms.Label()
        Me.lblBaseModel = New System.Windows.Forms.Label()
        Me.lblHighEndModel = New System.Windows.Forms.Label()
        Me.txtBaseModel = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.tblTotal = New System.Windows.Forms.TableLayoutPanel()
        Me.lblDollarTotal = New System.Windows.Forms.Label()
        Me.alignPrinterOrder.SuspendLayout()
        Me.tblTotal.SuspendLayout()
        Me.SuspendLayout()
        '
        'alignPrinterOrder
        '
        Me.alignPrinterOrder.ColumnCount = 2
        Me.alignPrinterOrder.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.alignPrinterOrder.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.alignPrinterOrder.Controls.Add(Me.txtHighEndModel, 1, 2)
        Me.alignPrinterOrder.Controls.Add(Me.lblPrinterOrderTitle, 0, 0)
        Me.alignPrinterOrder.Controls.Add(Me.lblBaseModel, 0, 1)
        Me.alignPrinterOrder.Controls.Add(Me.lblHighEndModel, 0, 2)
        Me.alignPrinterOrder.Controls.Add(Me.txtBaseModel, 1, 1)
        Me.alignPrinterOrder.Controls.Add(Me.tblTotal, 1, 3)
        Me.alignPrinterOrder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.alignPrinterOrder.Location = New System.Drawing.Point(0, 0)
        Me.alignPrinterOrder.Name = "alignPrinterOrder"
        Me.alignPrinterOrder.RowCount = 4
        Me.alignPrinterOrder.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.alignPrinterOrder.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.alignPrinterOrder.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.alignPrinterOrder.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.alignPrinterOrder.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.alignPrinterOrder.Size = New System.Drawing.Size(484, 461)
        Me.alignPrinterOrder.TabIndex = 0
        '
        'txtHighEndModel
        '
        Me.txtHighEndModel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtHighEndModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHighEndModel.Location = New System.Drawing.Point(338, 240)
        Me.txtHighEndModel.Name = "txtHighEndModel"
        Me.txtHighEndModel.Size = New System.Drawing.Size(50, 35)
        Me.txtHighEndModel.TabIndex = 7
        '
        'lblPrinterOrderTitle
        '
        Me.lblPrinterOrderTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPrinterOrderTitle.AutoSize = True
        Me.alignPrinterOrder.SetColumnSpan(Me.lblPrinterOrderTitle, 2)
        Me.lblPrinterOrderTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrinterOrderTitle.Location = New System.Drawing.Point(54, 0)
        Me.lblPrinterOrderTitle.Name = "lblPrinterOrderTitle"
        Me.lblPrinterOrderTitle.Padding = New System.Windows.Forms.Padding(10)
        Me.lblPrinterOrderTitle.Size = New System.Drawing.Size(376, 57)
        Me.lblPrinterOrderTitle.TabIndex = 0
        Me.lblPrinterOrderTitle.Text = "Printer Order Calculator"
        '
        'lblBaseModel
        '
        Me.lblBaseModel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblBaseModel.AutoSize = True
        Me.lblBaseModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBaseModel.Location = New System.Drawing.Point(40, 99)
        Me.lblBaseModel.Name = "lblBaseModel"
        Me.lblBaseModel.Padding = New System.Windows.Forms.Padding(10)
        Me.lblBaseModel.Size = New System.Drawing.Size(162, 49)
        Me.lblBaseModel.TabIndex = 1
        Me.lblBaseModel.Text = "Base Model"
        '
        'lblHighEndModel
        '
        Me.lblHighEndModel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblHighEndModel.AutoSize = True
        Me.lblHighEndModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHighEndModel.Location = New System.Drawing.Point(18, 233)
        Me.lblHighEndModel.Name = "lblHighEndModel"
        Me.lblHighEndModel.Padding = New System.Windows.Forms.Padding(10)
        Me.lblHighEndModel.Size = New System.Drawing.Size(206, 49)
        Me.lblHighEndModel.TabIndex = 2
        Me.lblHighEndModel.Text = "High End Model"
        '
        'txtBaseModel
        '
        Me.txtBaseModel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtBaseModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBaseModel.Location = New System.Drawing.Point(338, 106)
        Me.txtBaseModel.Name = "txtBaseModel"
        Me.txtBaseModel.Size = New System.Drawing.Size(50, 35)
        Me.txtBaseModel.TabIndex = 6
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(118, 40)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Padding = New System.Windows.Forms.Padding(10)
        Me.lblTotal.Size = New System.Drawing.Size(46, 49)
        Me.lblTotal.TabIndex = 8
        Me.lblTotal.Text = "0"
        '
        'tblTotal
        '
        Me.tblTotal.ColumnCount = 2
        Me.tblTotal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblTotal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.tblTotal.Controls.Add(Me.lblDollarTotal, 0, 0)
        Me.tblTotal.Controls.Add(Me.lblTotal, 1, 0)
        Me.tblTotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblTotal.Location = New System.Drawing.Point(245, 328)
        Me.tblTotal.Name = "tblTotal"
        Me.tblTotal.RowCount = 1
        Me.tblTotal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblTotal.Size = New System.Drawing.Size(236, 130)
        Me.tblTotal.TabIndex = 9
        '
        'lblDollarTotal
        '
        Me.lblDollarTotal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDollarTotal.AutoSize = True
        Me.lblDollarTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDollarTotal.Location = New System.Drawing.Point(3, 40)
        Me.lblDollarTotal.Name = "lblDollarTotal"
        Me.lblDollarTotal.Padding = New System.Windows.Forms.Padding(10)
        Me.lblDollarTotal.Size = New System.Drawing.Size(41, 49)
        Me.lblDollarTotal.TabIndex = 9
        Me.lblDollarTotal.Text = "$"
        '
        'PrinterOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.alignPrinterOrder)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(500, 500)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(500, 500)
        Me.Name = "PrinterOrder"
        Me.Text = "Printer Order Calculator"
        Me.alignPrinterOrder.ResumeLayout(False)
        Me.alignPrinterOrder.PerformLayout()
        Me.tblTotal.ResumeLayout(False)
        Me.tblTotal.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents alignPrinterOrder As TableLayoutPanel
    Friend WithEvents lblPrinterOrderTitle As Label
    Friend WithEvents lblBaseModel As Label
    Friend WithEvents lblHighEndModel As Label
    Friend WithEvents txtBaseModel As TextBox
    Friend WithEvents txtHighEndModel As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents tblTotal As TableLayoutPanel
    Friend WithEvents lblDollarTotal As Label
End Class
