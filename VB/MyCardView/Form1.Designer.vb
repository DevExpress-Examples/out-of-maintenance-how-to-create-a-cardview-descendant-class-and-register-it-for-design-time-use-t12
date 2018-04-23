Imports System.Drawing
Namespace MyCardView
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.dataSet1 = New System.Data.DataSet()
			Me.dataTable1 = New System.Data.DataTable()
			Me.dataColumn1 = New System.Data.DataColumn()
			Me.dataColumn2 = New System.Data.DataColumn()
			Me.myGridControl1 = New MyGridControl()
			Me.bindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
			Me.myCardView1 = New MyCardView()
			Me.colColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
			DirectCast(Me.dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.dataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.myGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.bindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.myCardView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' dataSet1
			' 
			Me.dataSet1.DataSetName = "NewDataSet"
			Me.dataSet1.Locale = New System.Globalization.CultureInfo("en-US")
			Me.dataSet1.Tables.AddRange(New System.Data.DataTable() { Me.dataTable1})
			' 
			' dataTable1
			' 
			Me.dataTable1.Columns.AddRange(New System.Data.DataColumn() { Me.dataColumn1, Me.dataColumn2})
			Me.dataTable1.TableName = "Table1"
			' 
			' dataColumn1
			' 
			Me.dataColumn1.ColumnName = "Column1"
			' 
			' dataColumn2
			' 
			Me.dataColumn2.ColumnName = "Column2"
			Me.dataColumn2.DataType = GetType(System.Drawing.Image)
			' 
			' myGridControl1
			' 
			Me.myGridControl1.DataSource = Me.bindingSource1
			Me.myGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.myGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.myGridControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
			Me.myGridControl1.LookAndFeel.UseDefaultLookAndFeel = False
			Me.myGridControl1.MainView = Me.myCardView1
			Me.myGridControl1.Name = "myGridControl1"
			Me.myGridControl1.Size = New System.Drawing.Size(648, 462)
			Me.myGridControl1.TabIndex = 1
			Me.myGridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.myCardView1})
			' 
			' bindingSource1
			' 
			Me.bindingSource1.DataMember = "Table1"
			Me.bindingSource1.DataSource = Me.dataSet1
			' 
			' myCardView1
			' 
			Me.myCardView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colColumn1, Me.colColumn2})
			Me.myCardView1.FocusedCardTopFieldIndex = 0
			Me.myCardView1.GridControl = Me.myGridControl1
			Me.myCardView1.Name = "myCardView1"
			' 
			' colColumn1
			' 
			Me.colColumn1.Caption = "Column1"
			Me.colColumn1.FieldName = "Column1"
			Me.colColumn1.Name = "colColumn1"
			Me.colColumn1.Visible = True
			Me.colColumn1.VisibleIndex = 0
			' 
			' colColumn2
			' 
			Me.colColumn2.Caption = "Column2"
			Me.colColumn2.FieldName = "Column2"
			Me.colColumn2.Name = "colColumn2"
			Me.colColumn2.Visible = True
			Me.colColumn2.VisibleIndex = 1
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(648, 462)
			Me.Controls.Add(Me.myGridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			DirectCast(Me.dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.dataTable1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.myGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.bindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.myCardView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private dataSet1 As System.Data.DataSet
		Private dataTable1 As System.Data.DataTable
		Private dataColumn1 As System.Data.DataColumn
		Private dataColumn2 As System.Data.DataColumn
		Private myGridControl1 As MyGridControl
		Private bindingSource1 As System.Windows.Forms.BindingSource
		Private myCardView1 As MyCardView
		Private colColumn1 As DevExpress.XtraGrid.Columns.GridColumn
		Private colColumn2 As DevExpress.XtraGrid.Columns.GridColumn


	End Class
End Namespace

