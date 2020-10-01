
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace DGVColumnSelector
	Public Partial Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(sender As Object, e As EventArgs)
			' Reading the data
			Dim ds As New DataSet()
			ds.ReadXml("Quarterly_orders.xml")
			' Databinding
			dataGridView1.DataSource = ds.Tables(0)

			' Use of the DataGridViewColumnSelector
			Dim cs As New DataGridViewColumnSelector(dataGridView1)
			cs.MaxHeight = 100
			cs.Width = 110
		End Sub

        Private Sub Form1_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        End Sub
    End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
