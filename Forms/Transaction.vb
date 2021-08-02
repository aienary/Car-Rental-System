Partial Public Class Transaction

    Private Sub RentBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RentBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RentBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.Rent_DetailsDataSet)

    End Sub

    Private Sub button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button3.Click
        BindingNavigatorAddNewItem.PerformClick()
    End Sub

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        Me.Validate()
        Me.RentBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.Rent_DetailsDataSet)
        MessageBox.Show("Saved Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        Me.Hide()
    End Sub

    Public Sub New()

        InitializeComponent()

    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Rent, Depo, total As Double

        Try
            Rent = Rent_Hours.Text
            Depo = Deposit.Text
            total = ((Rent * 5) + Depo)
            Total_Fees.Text = total

        Catch ex As Exception
            Total_Fees.Text = "Error"
            Total_Fees.Visible = True
            Total_Fees.Text = " One of the entries is not a number! Try again!"

            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        PrintDialog1.Document = PrintDocument1
        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        PrintDialog1.AllowSomePages = True

        If PrintDialog1.ShowDialog = DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDocument1.Print()
        End If
    End Sub

End Class
