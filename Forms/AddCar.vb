Public Class AddCar

    Private Sub ListOfCarsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListOfCarsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ListOfCarsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ListOfCarsDataSet)

    End Sub

    Private Sub AddCar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ListOfCarsTableAdapter.Fill(Me.ListOfCarsDataSet.ListOfCars)

    End Sub

    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        Me.Hide()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.BindingNavigatorAddNewItem.PerformClick()
    End Sub

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        Me.Validate()
        Me.ListOfCarsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ListOfCarsDataSet)
        MessageBox.Show("Saved Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        txtCar_ID.Text = ""
        txtCar_Name.Text = ""
        txtColor.Text = ""
        txtPlate_No.Text = ""
        txtQuantity.Text = ""
        txtRent_Day.Text = ""

    End Sub
End Class