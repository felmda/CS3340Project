
Imports Microsoft.Win32
Public Class FormAllCLass

   Friend dbkey As Microsoft.Win32.RegistryKey
   Private _frmIndividual As FormIndividualClass
   Private dblocation As String
   Public connString As String

   Private Sub FormAllCLass_Load(sender As Object, e As EventArgs) Handles MyBase.Load


      _frmIndividual = New FormIndividualClass
      _frmIndividual.MainForm = Me






      Dim connected As Boolean = False

      While Not connected
         Try
            dbkey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\UWPCS3340Prog6")
            dblocation = dbkey.GetValue("Software\UWPCS3340Prog6", "")
            connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dblocation

            EmployeeTableAdapter.Connection.ConnectionString = connString

            'TODO: This line of code loads data into the 'ActivityDataSet.Employee' table. You can move, or remove it, as needed.
            Me.EmployeeTableAdapter.Fill(Me.ActivityDataSet.Employee)
            connected = True

         Catch ex As Exception
            connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="

            Dim openDB As New OpenFileDialog
            If openDB.ShowDialog() = DialogResult.OK Then
               dblocation = openDB.FileName
               connString &= dblocation

               dbkey.SetValue("Software\UWPCS3340Prog6", dblocation, RegistryValueKind.String)
            Else
               Exit While
            End If
         End Try
      End While

      If Not connected Then
         MsgBox("No database selected!")
         Application.Exit()
      End If

   End Sub

   Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
      Application.Exit()

   End Sub

   Private Sub btnIndividual_Click(sender As Object, e As EventArgs) Handles btnIndividual.Click
      Me.Hide()

      _frmIndividual.Show()
      _frmIndividual.BringToFront()

   End Sub

   Private Sub btnLocation_Click(sender As Object, e As EventArgs) Handles btnLocation.Click
      MessageBox.Show(EmployeeTableAdapter.Connection.DataSource)
   End Sub

   Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
      Try
         Me.EmployeeTableAdapter.Fill(Me.ActivityDataSet.Employee)
      Catch ex As Exception

      End Try

   End Sub
End Class
