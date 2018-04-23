Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

''' <summary>
''' Summary description for XtraReport1
''' </summary>
Public Class XtraReport1
	Inherits DevExpress.XtraReports.UI.XtraReport
	Private Detail As DevExpress.XtraReports.UI.DetailBand
	Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
	Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
	Private northwind1 As Northwind
	Private xrPictureBox1 As XRPictureBox
	Private xrLabel2 As XRLabel
	Private xrLabel1 As XRLabel
	Private categoriesTableAdapter1 As NorthwindTableAdapters.CategoriesTableAdapter
	Private DetailReport As DetailReportBand
	Private Detail1 As DetailBand
	Private xrLabel3 As XRLabel
	Private xrLabel4 As XRLabel
	Private productsTableAdapter1 As NorthwindTableAdapters.ProductsTableAdapter
	Private CategoryId As DevExpress.XtraReports.Parameters.Parameter
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	Public Sub New()
		InitializeComponent()
		'
		' TODO: Add constructor logic here
		'
	End Sub

	''' <summary> 
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
		If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	#Region "Designer generated code"

	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
		Dim resourceFileName As String = "XtraReport1.resx"
		Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
		Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
		Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
		Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
		Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
		Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
		Me.northwind1 = New Northwind()
		Me.categoriesTableAdapter1 = New NorthwindTableAdapters.CategoriesTableAdapter()
		Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
		Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
		Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
		Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
		Me.productsTableAdapter1 = New NorthwindTableAdapters.ProductsTableAdapter()
		Me.CategoryId = New DevExpress.XtraReports.Parameters.Parameter()
		CType(Me.northwind1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
		' 
		' Detail
		' 
		Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPictureBox1, Me.xrLabel2, Me.xrLabel1})
		Me.Detail.HeightF = 91F
		Me.Detail.Name = "Detail"
		Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
		Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
		' 
		' xrPictureBox1
		' 
		Me.xrPictureBox1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "Categories.Picture")})
		Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(444.1667F, 10.00001F)
		Me.xrPictureBox1.Name = "xrPictureBox1"
		Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(195.8333F, 63.99998F)
		' 
		' xrLabel2
		' 
		Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.Description")})
		Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 50.99999F)
		Me.xrLabel2.Name = "xrLabel2"
		Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
		Me.xrLabel2.SizeF = New System.Drawing.SizeF(365.625F, 23F)
		Me.xrLabel2.Text = "xrLabel2"
		' 
		' xrLabel1
		' 
		Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoryName")})
		Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
		Me.xrLabel1.ForeColor = System.Drawing.Color.Blue
		Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 10.00001F)
		Me.xrLabel1.Name = "xrLabel1"
		Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
		Me.xrLabel1.SizeF = New System.Drawing.SizeF(209.375F, 23F)
		Me.xrLabel1.StylePriority.UseFont = False
		Me.xrLabel1.StylePriority.UseForeColor = False
		Me.xrLabel1.Text = "xrLabel1"
		' 
		' TopMargin
		' 
		Me.TopMargin.Name = "TopMargin"
		Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
		Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
		' 
		' BottomMargin
		' 
		Me.BottomMargin.Name = "BottomMargin"
		Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
		Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
		' 
		' northwind1
		' 
		Me.northwind1.DataSetName = "Northwind"
		Me.northwind1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		' 
		' categoriesTableAdapter1
		' 
		Me.categoriesTableAdapter1.ClearBeforeFill = True
		' 
		' DetailReport
		' 
		Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail1})
		Me.DetailReport.DataAdapter = Me.productsTableAdapter1
		Me.DetailReport.DataMember = "Categories.CategoriesProducts"
		Me.DetailReport.DataSource = Me.northwind1
		Me.DetailReport.Level = 0
		Me.DetailReport.Name = "DetailReport"
		' 
		' Detail1
		' 
		Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel4, Me.xrLabel3})
		Me.Detail1.HeightF = 23F
		Me.Detail1.Name = "Detail1"
		' 
		' xrLabel4
		' 
		Me.xrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoriesProducts.UnitPrice")})
		Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(444.1667F, 0F)
		Me.xrLabel4.Name = "xrLabel4"
		Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
		Me.xrLabel4.SizeF = New System.Drawing.SizeF(100F, 23F)
		Me.xrLabel4.Text = "xrLabel4"
		' 
		' xrLabel3
		' 
		Me.xrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoriesProducts.ProductName")})
		Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 0F)
		Me.xrLabel3.Name = "xrLabel3"
		Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
		Me.xrLabel3.SizeF = New System.Drawing.SizeF(279.1667F, 23F)
		Me.xrLabel3.Text = "xrLabel3"
		' 
		' productsTableAdapter1
		' 
		Me.productsTableAdapter1.ClearBeforeFill = True
		' 
		' CategoryId
		' 
		Me.CategoryId.Name = "CategoryId"
		Me.CategoryId.ParameterType = DevExpress.XtraReports.Parameters.ParameterType.Int32
		Me.CategoryId.Value = 1
		' 
		' XtraReport1
		' 
		Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.DetailReport})
		Me.DataAdapter = Me.categoriesTableAdapter1
		Me.DataMember = "Categories"
		Me.DataSource = Me.northwind1
		Me.FilterString = "[CategoryID] = ?CategoryId"
		Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() { Me.CategoryId})
		Me.Version = "10.1"
		CType(Me.northwind1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

	End Sub

	#End Region
End Class
