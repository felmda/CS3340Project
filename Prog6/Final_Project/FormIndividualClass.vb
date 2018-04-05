Public Class FormIndividualClass
   Private _mainForm As FormAllCLass




   Public WriteOnly Property MainForm As FormAllCLass
      Set(ByVal value As FormAllCLass)
         _mainForm = value
      End Set
   End Property

   Private Sub EmployeeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EmployeeBindingNavigatorSaveItem.Click
      Try
         Me.Validate()
         Me.EmployeeBindingSource.EndEdit()
         Me.TableAdapterManager.UpdateAll(Me.ActivityDataSet)
      Catch ex As Exception

      End Try


   End Sub

   Private Sub FormIndividualClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load

      Try
         EmployeeTableAdapter.Connection.ConnectionString = _mainForm.connString

         Me.EmployeeTableAdapter.Fill(Me.ActivityDataSet.Employee)
      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try
   End Sub

   Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
      Try
         Me.EmployeeTableAdapter.Fill(Me.ActivityDataSet.Employee)
      Catch ex As Exception

      End Try
   End Sub

   Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
      Me.Hide()
      _mainForm.Show()
      _mainForm.BringToFront()

   End Sub

   Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
      Application.Exit()

   End Sub
End Class