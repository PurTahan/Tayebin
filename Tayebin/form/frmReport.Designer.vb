﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReport
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
        Me.viewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'viewer
        '
        Me.viewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.viewer.Location = New System.Drawing.Point(0, 0)
        Me.viewer.Name = "viewer"
        Me.viewer.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.viewer.ServerReport.BearerToken = Nothing
        Me.viewer.Size = New System.Drawing.Size(651, 418)
        Me.viewer.TabIndex = 0
        '
        'frmReport
        '
        Me.ClientSize = New System.Drawing.Size(651, 418)
        Me.Controls.Add(Me.viewer)
        Me.Name = "frmReport"
        Me.ShowIcon = False
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents viewer As Microsoft.Reporting.WinForms.ReportViewer
End Class
