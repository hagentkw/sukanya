Public Class frmLab2
    Private Sub btncalculat_Click(sender As Object, e As EventArgs) Handles btncalculat.Click
        Dim vistra, computer, totalsales, commitmentVistra, commitmentcomputer, commitment As Double
        vistra = txtVistra.Text
        computer = txtComputer.Text


        totalsales = vistra + computer


        commitmentVistra = Val(vistra * 5) / 100
        commitmentcomputer = Val(computer * 10) / 100


        lblSum.Text = totalsales
        lblVistra.Text = commitmentVistra
        lblComputer.Text = commitmentcomputer
        lblCommitment.Text = commitmentVistra + commitmentcomputer

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class