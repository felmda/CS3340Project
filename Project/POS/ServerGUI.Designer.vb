﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ServerGUI
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tblOrder = New System.Windows.Forms.TableLayoutPanel()
        Me.SuspendLayout()
        '
        'tblOrder
        '
        Me.tblOrder.ColumnCount = 3
        Me.tblOrder.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.38983!))
        Me.tblOrder.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.61017!))
        Me.tblOrder.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97.0!))
        Me.tblOrder.Location = New System.Drawing.Point(53, 50)
        Me.tblOrder.Name = "tblOrder"
        Me.tblOrder.RowCount = 2
        Me.tblOrder.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.40476!))
        Me.tblOrder.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.59524!))
        Me.tblOrder.Size = New System.Drawing.Size(479, 66)
        Me.tblOrder.TabIndex = 1
        '
        'ServerGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 510)
        Me.Controls.Add(Me.tblOrder)
        Me.Name = "ServerGUI"
        Me.Text = "ServerGUI"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tblOrder As TableLayoutPanel
End Class
