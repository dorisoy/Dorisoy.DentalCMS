﻿Public Class frmReportViewer
    Private Sub frmReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class