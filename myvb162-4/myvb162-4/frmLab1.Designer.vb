<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.lblSalaryYear = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblNetsalary = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.BurlyWood
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Minion Pro", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(122, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 61)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมคำนวณรายได้รายปี"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Minion Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(49, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "เงินเดือนพนักงาน"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Minion Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(49, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 32)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "เงินเดือนพนักงานต่อปี"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Minion Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(49, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 32)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "ภาษีที่ต้องชำระ"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Minion Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(49, 261)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(186, 36)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "รายได้สุทธิ"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSalary
        '
        Me.txtSalary.Font = New System.Drawing.Font("Minion Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalary.Location = New System.Drawing.Point(300, 100)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(167, 27)
        Me.txtSalary.TabIndex = 5
        '
        'lblSalaryYear
        '
        Me.lblSalaryYear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblSalaryYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSalaryYear.Font = New System.Drawing.Font("Minion Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalaryYear.Location = New System.Drawing.Point(300, 155)
        Me.lblSalaryYear.Name = "lblSalaryYear"
        Me.lblSalaryYear.Size = New System.Drawing.Size(167, 32)
        Me.lblSalaryYear.TabIndex = 6
        Me.lblSalaryYear.Text = "                                       "
        Me.lblSalaryYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTax
        '
        Me.lblTax.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTax.Font = New System.Drawing.Font("Minion Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.Location = New System.Drawing.Point(300, 209)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(167, 32)
        Me.lblTax.TabIndex = 7
        Me.lblTax.Text = "                                       "
        Me.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNetsalary
        '
        Me.lblNetsalary.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNetsalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNetsalary.Font = New System.Drawing.Font("Minion Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetsalary.Location = New System.Drawing.Point(300, 263)
        Me.lblNetsalary.Name = "lblNetsalary"
        Me.lblNetsalary.Size = New System.Drawing.Size(167, 32)
        Me.lblNetsalary.TabIndex = 8
        Me.lblNetsalary.Text = "                                       "
        Me.lblNetsalary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btnCalculate.Font = New System.Drawing.Font("Minion Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(145, 344)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(102, 36)
        Me.btnCalculate.TabIndex = 9
        Me.btnCalculate.Text = "คำนวณ"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btnClose.Font = New System.Drawing.Font("Minion Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(300, 344)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(102, 36)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "ปิด"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'frmLab1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(533, 432)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblNetsalary)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblSalaryYear)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLab1"
        Me.Text = "frmLab1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents lblSalaryYear As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblNetsalary As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClose As Button
End Class
