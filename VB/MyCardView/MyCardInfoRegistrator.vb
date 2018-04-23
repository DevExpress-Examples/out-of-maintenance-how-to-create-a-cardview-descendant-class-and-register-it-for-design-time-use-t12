Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Registrator
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Base.Handler
Imports DevExpress.XtraGrid.Views.Base.ViewInfo

Namespace MyCardView
	Public Class MyCardInfoRegistrator
		Inherits CardInfoRegistrator

		Public Overrides ReadOnly Property ViewName() As String
			Get
				Return "MyCardView"
			End Get
		End Property
		Public Overrides Function CreateView(ByVal grid As GridControl) As BaseView
			Return New MyCardView(TryCast(grid, GridControl))
		End Function
		Public Overrides Function CreateViewInfo(ByVal view As BaseView) As BaseViewInfo
			Return New MyCardViewInfo(TryCast(view, MyCardView))
		End Function
		Public Overrides Function CreateHandler(ByVal view As BaseView) As BaseViewHandler
			Return New MyCardHandler(TryCast(view, MyCardView))
		End Function
	End Class
End Namespace
