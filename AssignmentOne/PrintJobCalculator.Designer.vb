<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintJobCalculator
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
        Me.tblPrintJobOrder = New System.Windows.Forms.TableLayoutPanel()
        Me.grpPrintType = New System.Windows.Forms.GroupBox()
        Me.tblTypeBox = New System.Windows.Forms.TableLayoutPanel()
        Me.rbtnSLA = New System.Windows.Forms.RadioButton()
        Me.rbtnFDMABS = New System.Windows.Forms.RadioButton()
        Me.rbtnBasic = New System.Windows.Forms.RadioButton()
        Me.rbtnFDMBasic = New System.Windows.Forms.RadioButton()
        Me.rbtnFDMASA = New System.Windows.Forms.RadioButton()
        Me.lblPrintJobTitle = New System.Windows.Forms.Label()
        Me.lblTotalLabel = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lvTest = New System.Windows.Forms.ListView()
        Me.printType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.printSize = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnAddJob = New System.Windows.Forms.Button()
        Me.btnClearJob = New System.Windows.Forms.Button()
        Me.grpSizeBox = New System.Windows.Forms.GroupBox()
        Me.tblSizeBox = New System.Windows.Forms.TableLayoutPanel()
        Me.rbtnLarge = New System.Windows.Forms.RadioButton()
        Me.rbtnSmall = New System.Windows.Forms.RadioButton()
        Me.rbtnMedium = New System.Windows.Forms.RadioButton()
        Me.tblOtherOptions = New System.Windows.Forms.TableLayoutPanel()
        Me.chbPriority = New System.Windows.Forms.CheckBox()
        Me.lblContract = New System.Windows.Forms.Label()
        Me.lblPriorityJob = New System.Windows.Forms.Label()
        Me.chbContract = New System.Windows.Forms.CheckBox()
        Me.material = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.price = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tblTotal = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTotalDollarSign = New System.Windows.Forms.Label()
        Me.tblPrintJobOrder.SuspendLayout()
        Me.grpPrintType.SuspendLayout()
        Me.tblTypeBox.SuspendLayout()
        Me.grpSizeBox.SuspendLayout()
        Me.tblSizeBox.SuspendLayout()
        Me.tblOtherOptions.SuspendLayout()
        Me.tblTotal.SuspendLayout()
        Me.SuspendLayout()
        '
        'tblPrintJobOrder
        '
        Me.tblPrintJobOrder.ColumnCount = 3
        Me.tblPrintJobOrder.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332!))
        Me.tblPrintJobOrder.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.tblPrintJobOrder.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.tblPrintJobOrder.Controls.Add(Me.grpPrintType, 1, 1)
        Me.tblPrintJobOrder.Controls.Add(Me.lblPrintJobTitle, 0, 0)
        Me.tblPrintJobOrder.Controls.Add(Me.lblTotalLabel, 1, 4)
        Me.tblPrintJobOrder.Controls.Add(Me.lvTest, 0, 3)
        Me.tblPrintJobOrder.Controls.Add(Me.btnAddJob, 0, 2)
        Me.tblPrintJobOrder.Controls.Add(Me.btnClearJob, 2, 2)
        Me.tblPrintJobOrder.Controls.Add(Me.grpSizeBox, 0, 1)
        Me.tblPrintJobOrder.Controls.Add(Me.tblOtherOptions, 2, 1)
        Me.tblPrintJobOrder.Controls.Add(Me.tblTotal, 2, 4)
        Me.tblPrintJobOrder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblPrintJobOrder.Location = New System.Drawing.Point(0, 0)
        Me.tblPrintJobOrder.Name = "tblPrintJobOrder"
        Me.tblPrintJobOrder.RowCount = 5
        Me.tblPrintJobOrder.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblPrintJobOrder.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblPrintJobOrder.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tblPrintJobOrder.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tblPrintJobOrder.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tblPrintJobOrder.Size = New System.Drawing.Size(564, 661)
        Me.tblPrintJobOrder.TabIndex = 0
        '
        'grpPrintType
        '
        Me.grpPrintType.Controls.Add(Me.tblTypeBox)
        Me.grpPrintType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpPrintType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPrintType.Location = New System.Drawing.Point(190, 60)
        Me.grpPrintType.Name = "grpPrintType"
        Me.grpPrintType.Padding = New System.Windows.Forms.Padding(10)
        Me.grpPrintType.Size = New System.Drawing.Size(182, 250)
        Me.grpPrintType.TabIndex = 17
        Me.grpPrintType.TabStop = False
        Me.grpPrintType.Text = "Print Type"
        '
        'tblTypeBox
        '
        Me.tblTypeBox.ColumnCount = 1
        Me.tblTypeBox.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblTypeBox.Controls.Add(Me.rbtnSLA, 0, 4)
        Me.tblTypeBox.Controls.Add(Me.rbtnFDMABS, 0, 2)
        Me.tblTypeBox.Controls.Add(Me.rbtnBasic, 0, 0)
        Me.tblTypeBox.Controls.Add(Me.rbtnFDMBasic, 0, 1)
        Me.tblTypeBox.Controls.Add(Me.rbtnFDMASA, 0, 3)
        Me.tblTypeBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblTypeBox.Location = New System.Drawing.Point(10, 29)
        Me.tblTypeBox.Name = "tblTypeBox"
        Me.tblTypeBox.RowCount = 5
        Me.tblTypeBox.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblTypeBox.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblTypeBox.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblTypeBox.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblTypeBox.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblTypeBox.Size = New System.Drawing.Size(162, 211)
        Me.tblTypeBox.TabIndex = 0
        '
        'rbtnSLA
        '
        Me.rbtnSLA.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.rbtnSLA.AutoSize = True
        Me.rbtnSLA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnSLA.Location = New System.Drawing.Point(3, 177)
        Me.rbtnSLA.Name = "rbtnSLA"
        Me.rbtnSLA.Size = New System.Drawing.Size(94, 24)
        Me.rbtnSLA.TabIndex = 4
        Me.rbtnSLA.Text = "SLA Print"
        Me.rbtnSLA.UseVisualStyleBackColor = True
        '
        'rbtnFDMABS
        '
        Me.rbtnFDMABS.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.rbtnFDMABS.AutoSize = True
        Me.rbtnFDMABS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnFDMABS.Location = New System.Drawing.Point(3, 93)
        Me.rbtnFDMABS.Name = "rbtnFDMABS"
        Me.rbtnFDMABS.Size = New System.Drawing.Size(135, 24)
        Me.rbtnFDMABS.TabIndex = 2
        Me.rbtnFDMABS.Text = "FDM ABS Print"
        Me.rbtnFDMABS.UseVisualStyleBackColor = True
        '
        'rbtnBasic
        '
        Me.rbtnBasic.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.rbtnBasic.AutoSize = True
        Me.rbtnBasic.Checked = True
        Me.rbtnBasic.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnBasic.Location = New System.Drawing.Point(3, 9)
        Me.rbtnBasic.Name = "rbtnBasic"
        Me.rbtnBasic.Size = New System.Drawing.Size(102, 24)
        Me.rbtnBasic.TabIndex = 0
        Me.rbtnBasic.TabStop = True
        Me.rbtnBasic.Text = "Basic Print"
        Me.rbtnBasic.UseVisualStyleBackColor = True
        '
        'rbtnFDMBasic
        '
        Me.rbtnFDMBasic.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.rbtnFDMBasic.AutoSize = True
        Me.rbtnFDMBasic.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnFDMBasic.Location = New System.Drawing.Point(3, 51)
        Me.rbtnFDMBasic.Name = "rbtnFDMBasic"
        Me.rbtnFDMBasic.Size = New System.Drawing.Size(141, 24)
        Me.rbtnFDMBasic.TabIndex = 1
        Me.rbtnFDMBasic.Text = "FDM Basic Print"
        Me.rbtnFDMBasic.UseVisualStyleBackColor = True
        '
        'rbtnFDMASA
        '
        Me.rbtnFDMASA.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.rbtnFDMASA.AutoSize = True
        Me.rbtnFDMASA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnFDMASA.Location = New System.Drawing.Point(3, 135)
        Me.rbtnFDMASA.Name = "rbtnFDMASA"
        Me.rbtnFDMASA.Size = New System.Drawing.Size(135, 24)
        Me.rbtnFDMASA.TabIndex = 3
        Me.rbtnFDMASA.Text = "FDM ASA Print"
        Me.rbtnFDMASA.UseVisualStyleBackColor = True
        '
        'lblPrintJobTitle
        '
        Me.lblPrintJobTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPrintJobTitle.AutoSize = True
        Me.tblPrintJobOrder.SetColumnSpan(Me.lblPrintJobTitle, 3)
        Me.lblPrintJobTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrintJobTitle.Location = New System.Drawing.Point(123, 0)
        Me.lblPrintJobTitle.Name = "lblPrintJobTitle"
        Me.lblPrintJobTitle.Padding = New System.Windows.Forms.Padding(10)
        Me.lblPrintJobTitle.Size = New System.Drawing.Size(318, 57)
        Me.lblPrintJobTitle.TabIndex = 4
        Me.lblPrintJobTitle.Text = "Print Job Calculator"
        '
        'lblTotalLabel
        '
        Me.lblTotalLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTotalLabel.AutoSize = True
        Me.lblTotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalLabel.Location = New System.Drawing.Point(237, 578)
        Me.lblTotalLabel.Name = "lblTotalLabel"
        Me.lblTotalLabel.Padding = New System.Windows.Forms.Padding(10)
        Me.lblTotalLabel.Size = New System.Drawing.Size(88, 49)
        Me.lblTotalLabel.TabIndex = 11
        Me.lblTotalLabel.Text = "Total"
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(96, 40)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(26, 29)
        Me.lblTotal.TabIndex = 9
        Me.lblTotal.Text = "0"
        '
        'lvTest
        '
        Me.lvTest.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.printType, Me.material, Me.printSize, Me.price})
        Me.tblPrintJobOrder.SetColumnSpan(Me.lvTest, 3)
        Me.lvTest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvTest.LabelWrap = False
        Me.lvTest.Location = New System.Drawing.Point(3, 432)
        Me.lvTest.MultiSelect = False
        Me.lvTest.Name = "lvTest"
        Me.lvTest.Size = New System.Drawing.Size(558, 110)
        Me.lvTest.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvTest.TabIndex = 3
        Me.lvTest.UseCompatibleStateImageBehavior = False
        Me.lvTest.View = System.Windows.Forms.View.Details
        '
        'printType
        '
        Me.printType.Text = "Print Type"
        Me.printType.Width = 200
        '
        'printSize
        '
        Me.printSize.Text = "Size"
        Me.printSize.Width = 100
        '
        'btnAddJob
        '
        Me.btnAddJob.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAddJob.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddJob.Location = New System.Drawing.Point(18, 341)
        Me.btnAddJob.Name = "btnAddJob"
        Me.btnAddJob.Padding = New System.Windows.Forms.Padding(10)
        Me.btnAddJob.Size = New System.Drawing.Size(150, 60)
        Me.btnAddJob.TabIndex = 1
        Me.btnAddJob.Text = "Add Job"
        Me.btnAddJob.UseVisualStyleBackColor = True
        '
        'btnClearJob
        '
        Me.btnClearJob.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClearJob.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearJob.Location = New System.Drawing.Point(394, 341)
        Me.btnClearJob.Name = "btnClearJob"
        Me.btnClearJob.Padding = New System.Windows.Forms.Padding(10)
        Me.btnClearJob.Size = New System.Drawing.Size(150, 60)
        Me.btnClearJob.TabIndex = 12
        Me.btnClearJob.Text = "Clear Job"
        Me.btnClearJob.UseVisualStyleBackColor = True
        '
        'grpSizeBox
        '
        Me.grpSizeBox.Controls.Add(Me.tblSizeBox)
        Me.grpSizeBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpSizeBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSizeBox.Location = New System.Drawing.Point(3, 60)
        Me.grpSizeBox.Name = "grpSizeBox"
        Me.grpSizeBox.Padding = New System.Windows.Forms.Padding(10)
        Me.grpSizeBox.Size = New System.Drawing.Size(181, 250)
        Me.grpSizeBox.TabIndex = 16
        Me.grpSizeBox.TabStop = False
        Me.grpSizeBox.Text = "Size Options"
        '
        'tblSizeBox
        '
        Me.tblSizeBox.ColumnCount = 1
        Me.tblSizeBox.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblSizeBox.Controls.Add(Me.rbtnLarge, 0, 2)
        Me.tblSizeBox.Controls.Add(Me.rbtnSmall, 0, 0)
        Me.tblSizeBox.Controls.Add(Me.rbtnMedium, 0, 1)
        Me.tblSizeBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblSizeBox.Location = New System.Drawing.Point(10, 29)
        Me.tblSizeBox.Name = "tblSizeBox"
        Me.tblSizeBox.RowCount = 3
        Me.tblSizeBox.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tblSizeBox.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tblSizeBox.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tblSizeBox.Size = New System.Drawing.Size(161, 211)
        Me.tblSizeBox.TabIndex = 0
        '
        'rbtnLarge
        '
        Me.rbtnLarge.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.rbtnLarge.AutoSize = True
        Me.rbtnLarge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnLarge.Location = New System.Drawing.Point(3, 163)
        Me.rbtnLarge.Name = "rbtnLarge"
        Me.rbtnLarge.Size = New System.Drawing.Size(68, 24)
        Me.rbtnLarge.TabIndex = 2
        Me.rbtnLarge.Text = "Large"
        Me.rbtnLarge.UseVisualStyleBackColor = True
        '
        'rbtnSmall
        '
        Me.rbtnSmall.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.rbtnSmall.AutoSize = True
        Me.rbtnSmall.Checked = True
        Me.rbtnSmall.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnSmall.Location = New System.Drawing.Point(3, 23)
        Me.rbtnSmall.Name = "rbtnSmall"
        Me.rbtnSmall.Size = New System.Drawing.Size(66, 24)
        Me.rbtnSmall.TabIndex = 0
        Me.rbtnSmall.TabStop = True
        Me.rbtnSmall.Text = "Small"
        Me.rbtnSmall.UseVisualStyleBackColor = True
        '
        'rbtnMedium
        '
        Me.rbtnMedium.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.rbtnMedium.AutoSize = True
        Me.rbtnMedium.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnMedium.Location = New System.Drawing.Point(3, 93)
        Me.rbtnMedium.Name = "rbtnMedium"
        Me.rbtnMedium.Size = New System.Drawing.Size(83, 24)
        Me.rbtnMedium.TabIndex = 1
        Me.rbtnMedium.Text = "Medium"
        Me.rbtnMedium.UseVisualStyleBackColor = True
        '
        'tblOtherOptions
        '
        Me.tblOtherOptions.ColumnCount = 1
        Me.tblOtherOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblOtherOptions.Controls.Add(Me.chbPriority, 0, 3)
        Me.tblOtherOptions.Controls.Add(Me.lblContract, 0, 0)
        Me.tblOtherOptions.Controls.Add(Me.lblPriorityJob, 0, 2)
        Me.tblOtherOptions.Controls.Add(Me.chbContract, 0, 1)
        Me.tblOtherOptions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblOtherOptions.Location = New System.Drawing.Point(378, 60)
        Me.tblOtherOptions.Name = "tblOtherOptions"
        Me.tblOtherOptions.RowCount = 4
        Me.tblOtherOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblOtherOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblOtherOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblOtherOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblOtherOptions.Size = New System.Drawing.Size(183, 250)
        Me.tblOtherOptions.TabIndex = 18
        '
        'chbPriority
        '
        Me.chbPriority.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chbPriority.AutoSize = True
        Me.chbPriority.Location = New System.Drawing.Point(74, 201)
        Me.chbPriority.Name = "chbPriority"
        Me.chbPriority.Padding = New System.Windows.Forms.Padding(10)
        Me.chbPriority.Size = New System.Drawing.Size(35, 34)
        Me.chbPriority.TabIndex = 8
        Me.chbPriority.UseVisualStyleBackColor = True
        '
        'lblContract
        '
        Me.lblContract.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblContract.AutoSize = True
        Me.tblOtherOptions.SetColumnSpan(Me.lblContract, 3)
        Me.lblContract.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContract.Location = New System.Drawing.Point(34, 11)
        Me.lblContract.Name = "lblContract"
        Me.lblContract.Padding = New System.Windows.Forms.Padding(10)
        Me.lblContract.Size = New System.Drawing.Size(115, 40)
        Me.lblContract.TabIndex = 5
        Me.lblContract.Text = "On Contract"
        '
        'lblPriorityJob
        '
        Me.lblPriorityJob.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPriorityJob.AutoSize = True
        Me.tblOtherOptions.SetColumnSpan(Me.lblPriorityJob, 3)
        Me.lblPriorityJob.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriorityJob.Location = New System.Drawing.Point(38, 135)
        Me.lblPriorityJob.Name = "lblPriorityJob"
        Me.lblPriorityJob.Padding = New System.Windows.Forms.Padding(10)
        Me.lblPriorityJob.Size = New System.Drawing.Size(106, 40)
        Me.lblPriorityJob.TabIndex = 6
        Me.lblPriorityJob.Text = "Priority Job"
        '
        'chbContract
        '
        Me.chbContract.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chbContract.AutoSize = True
        Me.chbContract.Location = New System.Drawing.Point(74, 76)
        Me.chbContract.Name = "chbContract"
        Me.chbContract.Padding = New System.Windows.Forms.Padding(10)
        Me.chbContract.Size = New System.Drawing.Size(35, 34)
        Me.chbContract.TabIndex = 7
        Me.chbContract.UseVisualStyleBackColor = True
        '
        'material
        '
        Me.material.Text = "Material"
        Me.material.Width = 100
        '
        'price
        '
        Me.price.Text = "Price"
        Me.price.Width = 100
        '
        'tblTotal
        '
        Me.tblTotal.ColumnCount = 2
        Me.tblTotal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblTotal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.tblTotal.Controls.Add(Me.lblTotalDollarSign, 0, 0)
        Me.tblTotal.Controls.Add(Me.lblTotal, 1, 0)
        Me.tblTotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblTotal.Location = New System.Drawing.Point(378, 548)
        Me.tblTotal.Name = "tblTotal"
        Me.tblTotal.RowCount = 1
        Me.tblTotal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblTotal.Size = New System.Drawing.Size(183, 110)
        Me.tblTotal.TabIndex = 19
        '
        'lblTotalDollarSign
        '
        Me.lblTotalDollarSign.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTotalDollarSign.AutoSize = True
        Me.lblTotalDollarSign.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDollarSign.Location = New System.Drawing.Point(5, 40)
        Me.lblTotalDollarSign.Name = "lblTotalDollarSign"
        Me.lblTotalDollarSign.Size = New System.Drawing.Size(26, 29)
        Me.lblTotalDollarSign.TabIndex = 10
        Me.lblTotalDollarSign.Text = "$"
        '
        'PrintJobCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 661)
        Me.Controls.Add(Me.tblPrintJobOrder)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(580, 700)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(580, 700)
        Me.Name = "PrintJobCalculator"
        Me.Text = "Print Job Order Calculator"
        Me.tblPrintJobOrder.ResumeLayout(False)
        Me.tblPrintJobOrder.PerformLayout()
        Me.grpPrintType.ResumeLayout(False)
        Me.tblTypeBox.ResumeLayout(False)
        Me.tblTypeBox.PerformLayout()
        Me.grpSizeBox.ResumeLayout(False)
        Me.tblSizeBox.ResumeLayout(False)
        Me.tblSizeBox.PerformLayout()
        Me.tblOtherOptions.ResumeLayout(False)
        Me.tblOtherOptions.PerformLayout()
        Me.tblTotal.ResumeLayout(False)
        Me.tblTotal.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tblPrintJobOrder As TableLayoutPanel
    Friend WithEvents btnAddJob As Button
    Friend WithEvents lvTest As ListView
    Friend WithEvents printType As ColumnHeader
    Friend WithEvents printSize As ColumnHeader
    Friend WithEvents lblPrintJobTitle As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTotalLabel As Label
    Friend WithEvents btnClearJob As Button
    Friend WithEvents rbtnLarge As RadioButton
    Friend WithEvents rbtnMedium As RadioButton
    Friend WithEvents rbtnSmall As RadioButton
    Friend WithEvents grpSizeBox As GroupBox
    Friend WithEvents tblSizeBox As TableLayoutPanel
    Friend WithEvents grpPrintType As GroupBox
    Friend WithEvents tblTypeBox As TableLayoutPanel
    Friend WithEvents rbtnSLA As RadioButton
    Friend WithEvents rbtnFDMABS As RadioButton
    Friend WithEvents rbtnBasic As RadioButton
    Friend WithEvents rbtnFDMBasic As RadioButton
    Friend WithEvents rbtnFDMASA As RadioButton
    Friend WithEvents tblOtherOptions As TableLayoutPanel
    Friend WithEvents lblContract As Label
    Friend WithEvents lblPriorityJob As Label
    Friend WithEvents chbPriority As CheckBox
    Friend WithEvents chbContract As CheckBox
    Friend WithEvents material As ColumnHeader
    Private WithEvents price As ColumnHeader
    Friend WithEvents tblTotal As TableLayoutPanel
    Friend WithEvents lblTotalDollarSign As Label
End Class
