Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.Web
Imports DevExpress.Web.ASPxTreeList

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

	End Sub

	Protected Function GetMasterRowKeyValue(ByVal treeList As ASPxTreeList) As Object
		Dim container As GridViewBaseRowTemplateContainer = Nothing
		Dim control As Control = treeList
		Do While control.Parent IsNot Nothing
			container = TryCast(control.Parent, GridViewBaseRowTemplateContainer)
			If container IsNot Nothing Then
				Exit Do
			End If
			control = control.Parent
		Loop
		Return container.KeyValue
	End Function

	Protected Sub ASPxTreeList1_Init(ByVal sender As Object, ByVal e As EventArgs)
		Dim treeList As ASPxTreeList = TryCast(sender, ASPxTreeList)
		Dim keyValue As Object = GetMasterRowKeyValue(treeList)
		treeList.RootValue = keyValue
	End Sub
End Class
