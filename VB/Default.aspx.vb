Imports System
Imports System.Web.Script.Serialization
Imports System.Web.UI.HtmlControls
Imports DevExpress.Web

Partial Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        If Not IsCallback AndAlso Not IsPostBack Then
            grid.DataBind()
        End If
    End Sub
    Protected Sub grid_DataBinding(ByVal sender As Object, ByVal e As EventArgs)
        grid.DataSource = DataHelper.GridItems
    End Sub
    Protected Sub sparklineContainer_Init(ByVal sender As Object, ByVal e As EventArgs)
        Dim sparklineContainer As HtmlGenericControl = DirectCast(sender, HtmlGenericControl)
        Dim templateContainer As GridViewDataItemTemplateContainer = CType(sparklineContainer.NamingContainer, GridViewDataItemTemplateContainer)
        sparklineContainer.Attributes("data") = (New JavaScriptSerializer()).Serialize(DataHelper.GetSparklineItemsByYear(CInt((templateContainer.KeyValue))))
    End Sub
End Class