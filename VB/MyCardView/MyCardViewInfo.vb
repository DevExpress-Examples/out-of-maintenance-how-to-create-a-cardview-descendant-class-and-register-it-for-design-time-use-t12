Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports DevExpress.XtraGrid.Views.Card.ViewInfo
Imports DevExpress.XtraGrid.Views.Card
Imports System.Drawing
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Namespace MyCardView
	Public Class MyCardViewInfo
		Inherits CardViewInfo

		Public Sub New(ByVal view As DevExpress.XtraGrid.Views.Card.CardView)
			MyBase.New(view)

		End Sub
	End Class
End Namespace
