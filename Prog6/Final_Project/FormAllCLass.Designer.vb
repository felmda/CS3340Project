<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAllCLass
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
      Me.components = New System.ComponentModel.Container()
      Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Me.DataGridView1 = New System.Windows.Forms.DataGridView()
      Me.UserNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.DepartmentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.DeptPositionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
      Me.ActivityDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
      Me.ActivityDataSet = New Final_Project.ActivityDataSet()
      Me.btnLocation = New System.Windows.Forms.Button()
      Me.btnReload = New System.Windows.Forms.Button()
      Me.btnIndividual = New System.Windows.Forms.Button()
      Me.btnExit = New System.Windows.Forms.Button()
      Me.EmployeeTableAdapter = New Final_Project.ActivityDataSetTableAdapters.EmployeeTableAdapter()
      CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.ActivityDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.ActivityDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'DataGridView1
      '
      Me.DataGridView1.AllowUserToAddRows = False
      Me.DataGridView1.AllowUserToDeleteRows = False
      Me.DataGridView1.AutoGenerateColumns = False
      Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserNameDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.DepartmentDataGridViewTextBoxColumn, Me.DeptPositionDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn})
      Me.DataGridView1.DataSource = Me.EmployeeBindingSource
      Me.DataGridView1.Location = New System.Drawing.Point(48, 42)
      Me.DataGridView1.Name = "DataGridView1"
      Me.DataGridView1.ReadOnly = True
      Me.DataGridView1.Size = New System.Drawing.Size(645, 220)
      Me.DataGridView1.TabIndex = 0
      '
      'UserNameDataGridViewTextBoxColumn
      '
      Me.UserNameDataGridViewTextBoxColumn.DataPropertyName = "UserName"
      DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      Me.UserNameDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
      Me.UserNameDataGridViewTextBoxColumn.HeaderText = "User Name"
      Me.UserNameDataGridViewTextBoxColumn.Name = "UserNameDataGridViewTextBoxColumn"
      Me.UserNameDataGridViewTextBoxColumn.ReadOnly = True
      '
      'FirstNameDataGridViewTextBoxColumn
      '
      Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
      DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      Me.FirstNameDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
      Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First Name"
      Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
      Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
      Me.FirstNameDataGridViewTextBoxColumn.Width = 120
      '
      'LastNameDataGridViewTextBoxColumn
      '
      Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName"
      DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      Me.LastNameDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
      Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last Name"
      Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
      Me.LastNameDataGridViewTextBoxColumn.ReadOnly = True
      Me.LastNameDataGridViewTextBoxColumn.Width = 120
      '
      'DepartmentDataGridViewTextBoxColumn
      '
      Me.DepartmentDataGridViewTextBoxColumn.DataPropertyName = "Department"
      DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
      Me.DepartmentDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
      Me.DepartmentDataGridViewTextBoxColumn.HeaderText = "Department"
      Me.DepartmentDataGridViewTextBoxColumn.Name = "DepartmentDataGridViewTextBoxColumn"
      Me.DepartmentDataGridViewTextBoxColumn.ReadOnly = True
      Me.DepartmentDataGridViewTextBoxColumn.Width = 70
      '
      'DeptPositionDataGridViewTextBoxColumn
      '
      Me.DeptPositionDataGridViewTextBoxColumn.DataPropertyName = "DeptPosition"
      DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
      Me.DeptPositionDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
      Me.DeptPositionDataGridViewTextBoxColumn.HeaderText = "Position"
      Me.DeptPositionDataGridViewTextBoxColumn.Name = "DeptPositionDataGridViewTextBoxColumn"
      Me.DeptPositionDataGridViewTextBoxColumn.ReadOnly = True
      '
      'EmailDataGridViewTextBoxColumn
      '
      Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
      Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
      Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
      Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
      '
      'PhoneDataGridViewTextBoxColumn
      '
      Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "Phone"
      DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
      Me.PhoneDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
      Me.PhoneDataGridViewTextBoxColumn.HeaderText = "Phone"
      Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
      Me.PhoneDataGridViewTextBoxColumn.ReadOnly = True
      Me.PhoneDataGridViewTextBoxColumn.Width = 70
      '
      'EmployeeBindingSource
      '
      Me.EmployeeBindingSource.DataMember = "Employee"
      Me.EmployeeBindingSource.DataSource = Me.ActivityDataSetBindingSource
      '
      'ActivityDataSetBindingSource
      '
      Me.ActivityDataSetBindingSource.DataSource = Me.ActivityDataSet
      Me.ActivityDataSetBindingSource.Position = 0
      '
      'ActivityDataSet
      '
      Me.ActivityDataSet.DataSetName = "ActivityDataSet"
      Me.ActivityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
      '
      'btnLocation
      '
      Me.btnLocation.Location = New System.Drawing.Point(404, 306)
      Me.btnLocation.Name = "btnLocation"
      Me.btnLocation.Size = New System.Drawing.Size(90, 23)
      Me.btnLocation.TabIndex = 1
      Me.btnLocation.Text = "LOCATION"
      Me.btnLocation.UseVisualStyleBackColor = True
      '
      'btnReload
      '
      Me.btnReload.Location = New System.Drawing.Point(260, 306)
      Me.btnReload.Name = "btnReload"
      Me.btnReload.Size = New System.Drawing.Size(90, 23)
      Me.btnReload.TabIndex = 2
      Me.btnReload.Text = "RELOAD"
      Me.btnReload.UseVisualStyleBackColor = True
      '
      'btnIndividual
      '
      Me.btnIndividual.Location = New System.Drawing.Point(85, 306)
      Me.btnIndividual.Name = "btnIndividual"
      Me.btnIndividual.Size = New System.Drawing.Size(90, 23)
      Me.btnIndividual.TabIndex = 3
      Me.btnIndividual.Text = "INDIVIDUAL"
      Me.btnIndividual.UseVisualStyleBackColor = True
      '
      'btnExit
      '
      Me.btnExit.Location = New System.Drawing.Point(569, 306)
      Me.btnExit.Name = "btnExit"
      Me.btnExit.Size = New System.Drawing.Size(90, 23)
      Me.btnExit.TabIndex = 4
      Me.btnExit.Text = "EXIT"
      Me.btnExit.UseVisualStyleBackColor = True
      '
      'EmployeeTableAdapter
      '
      Me.EmployeeTableAdapter.ClearBeforeFill = True
      '
      'FormAllCLass
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(730, 357)
      Me.Controls.Add(Me.btnExit)
      Me.Controls.Add(Me.btnIndividual)
      Me.Controls.Add(Me.btnReload)
      Me.Controls.Add(Me.btnLocation)
      Me.Controls.Add(Me.DataGridView1)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
      Me.Name = "FormAllCLass"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Prog 6 - Group"
      CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.ActivityDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.ActivityDataSet, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)

   End Sub

   Friend WithEvents DataGridView1 As DataGridView
   Friend WithEvents btnLocation As Button
   Friend WithEvents btnReload As Button
   Friend WithEvents btnIndividual As Button
   Friend WithEvents btnExit As Button
   Friend WithEvents ActivityDataSetBindingSource As BindingSource
   Friend WithEvents ActivityDataSet As ActivityDataSet
   Friend WithEvents EmployeeBindingSource As BindingSource
   Friend WithEvents EmployeeTableAdapter As ActivityDataSetTableAdapters.EmployeeTableAdapter
   Friend WithEvents UserNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
   Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
   Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
   Friend WithEvents DepartmentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
   Friend WithEvents DeptPositionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
   Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
   Friend WithEvents PhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
