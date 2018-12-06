Public Class frmLab1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim salary, salaryyear, tex As Double
        salary = txtSalary.Text
        salary = Val(salary * 12)


        salaryyear = Val(salary * 5) / 100

        tex = Val(salary) - Val(salaryyear)

        lblSalaryYear.Text = salary
        lblTax.Text = salaryyear
        lblNetsalary.Text = tex



    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
