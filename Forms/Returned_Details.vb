Public Class Returned_Details

    Private Sub ReturnBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReturnBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ReturnBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ReturnDataSet)

    End Sub

    Private Sub Returned_Details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ReturnTableAdapter.Fill(Me.ReturnDataSet._Return)

    End Sub

    Private Sub button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmReturn.Show()

    End Sub


    Private Sub button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button6.Click
        Me.Validate()
        Me.ReturnBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ReturnDataSet)
        MessageBox.Show("Saved Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("Are you sure you want to Delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            BindingNavigatorDeleteItem.PerformClick()
            Me.Validate()
            Me.ReturnBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ReturnDataSet)

            MessageBox.Show("Deleted Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            Return
        End If

    End Sub
End Class