Public Class frmReturn

    Private Sub ReturnBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReturnBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ReturnBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ReturnDataSet)

    End Sub

    Private Sub frmReturn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ReturnTableAdapter.Fill(Me.ReturnDataSet._Return)

    End Sub

    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        Me.Hide()

    End Sub

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        Me.Validate()
        Me.ReturnBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ReturnDataSet)
        MessageBox.Show("Saved Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button3.Click
        BindingNavigatorAddNewItem.PerformClick()

    End Sub
End Class