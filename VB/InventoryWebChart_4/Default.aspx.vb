Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Imaging

Namespace InventoryWebChart
	Partial Public Class [Default]
		Inherits System.Web.UI.Page

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Protected Sub WebChartControl1_CustomCallback(ByVal sender As Object, ByVal e As DevExpress.XtraCharts.Web.CustomCallbackEventArgs)
			Me.BOProducts.SelectParameters("categoryID").DefaultValue = e.Parameter
			Me.productsChart.DataBind()
		End Sub

	End Class
End Namespace