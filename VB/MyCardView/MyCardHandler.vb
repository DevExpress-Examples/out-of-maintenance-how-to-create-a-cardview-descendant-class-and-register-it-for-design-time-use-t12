Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports DevExpress.XtraGrid.Views.Grid.Handler
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Card.Handler
Imports DevExpress.XtraGrid.Views.Card

Namespace MyCardView
	Public Class MyCardHandler
		Inherits CardHandler

		Public Sub New(ByVal cv As CardView)
			MyBase.New(cv)
		End Sub
		Protected Overrides Sub OnKeyDown(ByVal e As KeyEventArgs)
			MyBase.OnKeyDown(e)
			If e.KeyData = Keys.Delete AndAlso View.State = CardState.Normal Then
				View.DeleteRow(View.FocusedRowHandle)
			End If
		End Sub
	End Class
End Namespace
