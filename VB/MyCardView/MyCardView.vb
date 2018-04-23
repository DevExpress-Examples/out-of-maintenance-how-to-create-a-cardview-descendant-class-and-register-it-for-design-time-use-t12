Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports DevExpress.XtraGrid.Views.Card
Imports DevExpress.XtraGrid

Namespace MyCardView
	Public Class MyCardView
		Inherits CardView

		Public Sub New(ByVal ownerGrid As DevExpress.XtraGrid.GridControl)
			MyBase.New(ownerGrid)
			' put your initialization code here
		End Sub
		Public Sub New()
		End Sub
		Protected Overrides ReadOnly Property ViewName() As String
			Get
				Return "MyCardView"
			End Get
		End Property
	End Class
End Namespace
