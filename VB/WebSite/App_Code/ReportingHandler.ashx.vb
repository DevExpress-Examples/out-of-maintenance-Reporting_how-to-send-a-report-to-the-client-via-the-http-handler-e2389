Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Web

Public Class ReportingHandler
	Implements IHttpHandler

	Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
		Dim report As New XtraReport1()
		Dim memoryStream As New MemoryStream()

		report.Parameters("CategoryId").Value = Convert.ToInt32(context.Request("catid"))
		report.ExportOptions.Image.ExportMode = DevExpress.XtraPrinting.ImageExportMode.SingleFile
		report.ExportOptions.Image.Format = System.Drawing.Imaging.ImageFormat.Png
		report.ExportToImage(memoryStream)
		memoryStream.Seek(0, SeekOrigin.Begin)

		context.Response.ContentType = "image/png"
		context.Response.BinaryWrite(memoryStream.ToArray())
	End Sub

	Public ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
		Get
			Return False
		End Get
	End Property

End Class