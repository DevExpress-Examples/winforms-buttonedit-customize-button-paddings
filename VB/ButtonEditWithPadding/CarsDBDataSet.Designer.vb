﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.4952
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

'INSTANT VB TODO TASK: There is no equivalent to #pragma directives in VB.NET:
'#pragma warning disable 1591


Imports Microsoft.VisualBasic
Imports System
Namespace ButtonEditWithPadding


	''' <summary>
	'''Represents a strongly typed in-memory cache of data.
	'''</summary>
	<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), Global.System.Serializable(), Global.System.ComponentModel.DesignerCategoryAttribute("code"), Global.System.ComponentModel.ToolboxItem(True), Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedDataSetSchema"), Global.System.Xml.Serialization.XmlRootAttribute("CarsDBDataSet"), Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.DataSet")> _
	Partial Public Class CarsDBDataSet
		Inherits System.Data.DataSet

		Private tableCars As CarsDataTable

		Private _schemaSerializationMode As Global.System.Data.SchemaSerializationMode = Global.System.Data.SchemaSerializationMode.IncludeSchema

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Public Sub New()
			Me.BeginInit()
			Me.InitClass()
			Dim schemaChangedHandler As New Global.System.ComponentModel.CollectionChangeEventHandler(AddressOf Me.SchemaChanged)
			AddHandler MyBase.Tables.CollectionChanged, schemaChangedHandler
			AddHandler MyBase.Relations.CollectionChanged, schemaChangedHandler
			Me.EndInit()
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
			MyBase.New(info, context, False)
			If (Me.IsBinarySerialized(info, context) = True) Then
				Me.InitVars(False)
				Dim schemaChangedHandler1 As New Global.System.ComponentModel.CollectionChangeEventHandler(AddressOf Me.SchemaChanged)
				AddHandler Me.Tables.CollectionChanged, schemaChangedHandler1
				AddHandler Me.Relations.CollectionChanged, schemaChangedHandler1
				Return
			End If
			Dim strSchema As String = (CStr(info.GetValue("XmlSchema", GetType(String))))
			If (Me.DetermineSchemaSerializationMode(info, context) = Global.System.Data.SchemaSerializationMode.IncludeSchema) Then
				Dim ds As New Global.System.Data.DataSet()
				ds.ReadXmlSchema(New Global.System.Xml.XmlTextReader(New Global.System.IO.StringReader(strSchema)))
				If (ds.Tables("Cars") IsNot Nothing) Then
					MyBase.Tables.Add(New CarsDataTable(ds.Tables("Cars")))
				End If
				Me.DataSetName = ds.DataSetName
				Me.Prefix = ds.Prefix
				Me.Namespace = ds.Namespace
				Me.Locale = ds.Locale
				Me.CaseSensitive = ds.CaseSensitive
				Me.EnforceConstraints = ds.EnforceConstraints
				Me.Merge(ds, False, Global.System.Data.MissingSchemaAction.Add)
				Me.InitVars()
			Else
				Me.ReadXmlSchema(New Global.System.Xml.XmlTextReader(New Global.System.IO.StringReader(strSchema)))
			End If
			Me.GetSerializationData(info, context)
			Dim schemaChangedHandler As New Global.System.ComponentModel.CollectionChangeEventHandler(AddressOf Me.SchemaChanged)
			AddHandler MyBase.Tables.CollectionChanged, schemaChangedHandler
			AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.Browsable(False), Global.System.ComponentModel.DesignerSerializationVisibility(Global.System.ComponentModel.DesignerSerializationVisibility.Content)> _
		Public ReadOnly Property Cars() As CarsDataTable
			Get
				Return Me.tableCars
			End Get
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.BrowsableAttribute(True), Global.System.ComponentModel.DesignerSerializationVisibilityAttribute(Global.System.ComponentModel.DesignerSerializationVisibility.Visible)> _
		Public Overrides Property SchemaSerializationMode() As Global.System.Data.SchemaSerializationMode
			Get
				Return Me._schemaSerializationMode
			End Get
			Set(ByVal value As System.Data.SchemaSerializationMode)
				Me._schemaSerializationMode = value
			End Set
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.DesignerSerializationVisibilityAttribute(Global.System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
		Public Shadows ReadOnly Property Tables() As Global.System.Data.DataTableCollection
			Get
				Return MyBase.Tables
			End Get
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.DesignerSerializationVisibilityAttribute(Global.System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
		Public Shadows ReadOnly Property Relations() As Global.System.Data.DataRelationCollection
			Get
				Return MyBase.Relations
			End Get
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Protected Overrides Sub InitializeDerivedDataSet()
			Me.BeginInit()
			Me.InitClass()
			Me.EndInit()
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Public Overrides Function Clone() As Global.System.Data.DataSet
			Dim cln As CarsDBDataSet = (CType(MyBase.Clone(), CarsDBDataSet))
			cln.InitVars()
			cln.SchemaSerializationMode = Me.SchemaSerializationMode
			Return cln
		End Function

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Protected Overrides Function ShouldSerializeTables() As Boolean
			Return False
		End Function

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Protected Overrides Function ShouldSerializeRelations() As Boolean
			Return False
		End Function

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Protected Overrides Sub ReadXmlSerializable(ByVal reader As Global.System.Xml.XmlReader)
			If (Me.DetermineSchemaSerializationMode(reader) = Global.System.Data.SchemaSerializationMode.IncludeSchema) Then
				Me.Reset()
				Dim ds As New Global.System.Data.DataSet()
				ds.ReadXml(reader)
				If (ds.Tables("Cars") IsNot Nothing) Then
					MyBase.Tables.Add(New CarsDataTable(ds.Tables("Cars")))
				End If
				Me.DataSetName = ds.DataSetName
				Me.Prefix = ds.Prefix
				Me.Namespace = ds.Namespace
				Me.Locale = ds.Locale
				Me.CaseSensitive = ds.CaseSensitive
				Me.EnforceConstraints = ds.EnforceConstraints
				Me.Merge(ds, False, Global.System.Data.MissingSchemaAction.Add)
				Me.InitVars()
			Else
				Me.ReadXml(reader)
				Me.InitVars()
			End If
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Protected Overrides Function GetSchemaSerializable() As Global.System.Xml.Schema.XmlSchema
			Dim stream As New Global.System.IO.MemoryStream()
			Me.WriteXmlSchema(New Global.System.Xml.XmlTextWriter(stream, Nothing))
			stream.Position = 0
			Return Global.System.Xml.Schema.XmlSchema.Read(New Global.System.Xml.XmlTextReader(stream), Nothing)
		End Function

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Friend Sub InitVars()
			Me.InitVars(True)
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Friend Sub InitVars(ByVal initTable As Boolean)
			Me.tableCars = (CType(MyBase.Tables("Cars"), CarsDataTable))
			If (initTable = True) Then
				If (Me.tableCars IsNot Nothing) Then
					Me.tableCars.InitVars()
				End If
			End If
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Private Sub InitClass()
			Me.DataSetName = "CarsDBDataSet"
			Me.Prefix = ""
			Me.Namespace = "http://tempuri.org/CarsDBDataSet.xsd"
			Me.EnforceConstraints = True
			Me.SchemaSerializationMode = Global.System.Data.SchemaSerializationMode.IncludeSchema
			Me.tableCars = New CarsDataTable()
			MyBase.Tables.Add(Me.tableCars)
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Private Function ShouldSerializeCars() As Boolean
			Return False
		End Function

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Private Sub SchemaChanged(ByVal sender As Object, ByVal e As Global.System.ComponentModel.CollectionChangeEventArgs)
			If (e.Action = Global.System.ComponentModel.CollectionChangeAction.Remove) Then
				Me.InitVars()
			End If
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Public Shared Function GetTypedDataSetSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
			Dim ds As New CarsDBDataSet()
			Dim type As New Global.System.Xml.Schema.XmlSchemaComplexType()
			Dim sequence As New Global.System.Xml.Schema.XmlSchemaSequence()
			Dim any As New Global.System.Xml.Schema.XmlSchemaAny()
			any.Namespace = ds.Namespace
			sequence.Items.Add(any)
			type.Particle = sequence
			Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable()
			If xs.Contains(dsSchema.TargetNamespace) Then
				Dim s1 As New Global.System.IO.MemoryStream()
				Dim s2 As New Global.System.IO.MemoryStream()
				Try
					Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
					dsSchema.Write(s1)
					Dim schemas As System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator()
					Do While schemas.MoveNext()
						schema = (CType(schemas.Current, Global.System.Xml.Schema.XmlSchema))
						s2.SetLength(0)
						schema.Write(s2)
						If (s1.Length = s2.Length) Then
							s1.Position = 0
							s2.Position = 0
							Do While ((s1.Position <> s1.Length) AndAlso (s1.ReadByte() = s2.ReadByte()))

							Loop
							If (s1.Position = s1.Length) Then
								Return type
							End If
						End If
					Loop
				Finally
					If (s1 IsNot Nothing) Then
						s1.Close()
					End If
					If (s2 IsNot Nothing) Then
						s2.Close()
					End If
				End Try
			End If
			xs.Add(dsSchema)
			Return type
		End Function

		Public Delegate Sub CarsRowChangeEventHandler(ByVal sender As Object, ByVal e As CarsRowChangeEvent)

		''' <summary>
		'''Represents the strongly named DataTable class.
		'''</summary>
		<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), Global.System.Serializable(), Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")> _
		Partial Public Class CarsDataTable
			Inherits System.Data.DataTable
			Implements System.Collections.IEnumerable

			Private columnTrademark As Global.System.Data.DataColumn

			Private columnModel As Global.System.Data.DataColumn

			Private columnHP As Global.System.Data.DataColumn

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Sub New()
				Me.TableName = "Cars"
				Me.BeginInit()
				Me.InitClass()
				Me.EndInit()
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Friend Sub New(ByVal table As Global.System.Data.DataTable)
				Me.TableName = table.TableName
				If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
					Me.CaseSensitive = table.CaseSensitive
				End If
				If (table.Locale.ToString() <> table.DataSet.Locale.ToString()) Then
					Me.Locale = table.Locale
				End If
				If (table.Namespace <> table.DataSet.Namespace) Then
					Me.Namespace = table.Namespace
				End If
				Me.Prefix = table.Prefix
				Me.MinimumCapacity = table.MinimumCapacity
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
				MyBase.New(info, context)
				Me.InitVars()
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public ReadOnly Property TrademarkColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnTrademark
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public ReadOnly Property ModelColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnModel
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public ReadOnly Property HPColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnHP
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.Browsable(False)> _
			Public ReadOnly Property Count() As Integer
				Get
					Return Me.Rows.Count
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Default Public ReadOnly Property Item(ByVal index As Integer) As CarsRow
				Get
					Return (CType(Me.Rows(index), CarsRow))
				End Get
			End Property

			Public Event CarsRowChanging As CarsRowChangeEventHandler

			Public Event CarsRowChanged As CarsRowChangeEventHandler

			Public Event CarsRowDeleting As CarsRowChangeEventHandler

			Public Event CarsRowDeleted As CarsRowChangeEventHandler

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Sub AddCarsRow(ByVal row As CarsRow)
				Me.Rows.Add(row)
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Function AddCarsRow(ByVal Trademark As String, ByVal Model As String, ByVal HP As Short) As CarsRow
				Dim rowCarsRow As CarsRow = (CType(Me.NewRow(), CarsRow))
				Dim columnValuesArray() As Object = { Trademark, Model, HP}
				rowCarsRow.ItemArray = columnValuesArray
				Me.Rows.Add(rowCarsRow)
				Return rowCarsRow
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Overridable Function GetEnumerator() As Global.System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
				Return Me.Rows.GetEnumerator()
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Overrides Function Clone() As Global.System.Data.DataTable
				Dim cln As CarsDataTable = (CType(MyBase.Clone(), CarsDataTable))
				cln.InitVars()
				Return cln
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
				Return New CarsDataTable()
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Friend Sub InitVars()
				Me.columnTrademark = MyBase.Columns("Trademark")
				Me.columnModel = MyBase.Columns("Model")
				Me.columnHP = MyBase.Columns("HP")
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Private Sub InitClass()
				Me.columnTrademark = New Global.System.Data.DataColumn("Trademark", GetType(String), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnTrademark)
				Me.columnModel = New Global.System.Data.DataColumn("Model", GetType(String), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnModel)
				Me.columnHP = New Global.System.Data.DataColumn("HP", GetType(Short), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnHP)
				Me.columnTrademark.MaxLength = 50
				Me.columnModel.MaxLength = 50
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Function NewCarsRow() As CarsRow
				Return (CType(Me.NewRow(), CarsRow))
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Protected Overrides Function NewRowFromBuilder(ByVal builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
				Return New CarsRow(builder)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Protected Overrides Function GetRowType() As Global.System.Type
				Return GetType(CarsRow)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Protected Overrides Sub OnRowChanged(ByVal e As Global.System.Data.DataRowChangeEventArgs)
				MyBase.OnRowChanged(e)
				If (Me.CarsRowChangedEvent IsNot Nothing) Then
					RaiseEvent CarsRowChanged(Me, New CarsRowChangeEvent((CType(e.Row, CarsRow)), e.Action))
				End If
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
				MyBase.OnRowChanging(e)
				If (Me.CarsRowChangingEvent IsNot Nothing) Then
					RaiseEvent CarsRowChanging(Me, New CarsRowChangeEvent((CType(e.Row, CarsRow)), e.Action))
				End If
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
				MyBase.OnRowDeleted(e)
				If (Me.CarsRowDeletedEvent IsNot Nothing) Then
					RaiseEvent CarsRowDeleted(Me, New CarsRowChangeEvent((CType(e.Row, CarsRow)), e.Action))
				End If
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
				MyBase.OnRowDeleting(e)
				If (Me.CarsRowDeletingEvent IsNot Nothing) Then
					RaiseEvent CarsRowDeleting(Me, New CarsRowChangeEvent((CType(e.Row, CarsRow)), e.Action))
				End If
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Sub RemoveCarsRow(ByVal row As CarsRow)
				Me.Rows.Remove(row)
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Shared Function GetTypedTableSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
				Dim type As New Global.System.Xml.Schema.XmlSchemaComplexType()
				Dim sequence As New Global.System.Xml.Schema.XmlSchemaSequence()
				Dim ds As New CarsDBDataSet()
				Dim any1 As New Global.System.Xml.Schema.XmlSchemaAny()
				any1.Namespace = "http://www.w3.org/2001/XMLSchema"
				any1.MinOccurs = New Decimal(0)
				any1.MaxOccurs = Decimal.MaxValue
				any1.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
				sequence.Items.Add(any1)
				Dim any2 As New Global.System.Xml.Schema.XmlSchemaAny()
				any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
				any2.MinOccurs = New Decimal(1)
				any2.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
				sequence.Items.Add(any2)
				Dim attribute1 As New Global.System.Xml.Schema.XmlSchemaAttribute()
				attribute1.Name = "namespace"
				attribute1.FixedValue = ds.Namespace
				type.Attributes.Add(attribute1)
				Dim attribute2 As New Global.System.Xml.Schema.XmlSchemaAttribute()
				attribute2.Name = "tableTypeName"
				attribute2.FixedValue = "CarsDataTable"
				type.Attributes.Add(attribute2)
				type.Particle = sequence
				Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable()
				If xs.Contains(dsSchema.TargetNamespace) Then
					Dim s1 As New Global.System.IO.MemoryStream()
					Dim s2 As New Global.System.IO.MemoryStream()
					Try
						Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
						dsSchema.Write(s1)
						Dim schemas As System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator()
						Do While schemas.MoveNext()
							schema = (CType(schemas.Current, Global.System.Xml.Schema.XmlSchema))
							s2.SetLength(0)
							schema.Write(s2)
							If (s1.Length = s2.Length) Then
								s1.Position = 0
								s2.Position = 0
								Do While ((s1.Position <> s1.Length) AndAlso (s1.ReadByte() = s2.ReadByte()))

								Loop
								If (s1.Position = s1.Length) Then
									Return type
								End If
							End If
						Loop
					Finally
						If (s1 IsNot Nothing) Then
							s1.Close()
						End If
						If (s2 IsNot Nothing) Then
							s2.Close()
						End If
					End Try
				End If
				xs.Add(dsSchema)
				Return type
			End Function
		End Class

		''' <summary>
		'''Represents strongly named DataRow class.
		'''</summary>
		<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
		Partial Public Class CarsRow
			Inherits System.Data.DataRow

			Private tableCars As CarsDataTable

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Friend Sub New(ByVal rb As Global.System.Data.DataRowBuilder)
				MyBase.New(rb)
				Me.tableCars = (CType(Me.Table, CarsDataTable))
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Property Trademark() As String
				Get
					Try
						Return (CStr(Me(Me.tableCars.TrademarkColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'Trademark' in table 'Cars' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As String)
					Me(Me.tableCars.TrademarkColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Property Model() As String
				Get
					Try
						Return (CStr(Me(Me.tableCars.ModelColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'Model' in table 'Cars' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As String)
					Me(Me.tableCars.ModelColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Property HP() As Short
				Get
					Try
						Return (CShort(Fix(Me(Me.tableCars.HPColumn))))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'HP' in table 'Cars' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As Short)
					Me(Me.tableCars.HPColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Function IsTrademarkNull() As Boolean
				Return Me.IsNull(Me.tableCars.TrademarkColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Sub SetTrademarkNull()
				Me(Me.tableCars.TrademarkColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Function IsModelNull() As Boolean
				Return Me.IsNull(Me.tableCars.ModelColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Sub SetModelNull()
				Me(Me.tableCars.ModelColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Function IsHPNull() As Boolean
				Return Me.IsNull(Me.tableCars.HPColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Sub SetHPNull()
				Me(Me.tableCars.HPColumn) = Global.System.Convert.DBNull
			End Sub
		End Class

		''' <summary>
		'''Row event argument class
		'''</summary>
		<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
		Public Class CarsRowChangeEvent
			Inherits System.EventArgs

			Private eventRow As CarsRow

			Private eventAction As Global.System.Data.DataRowAction

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Sub New(ByVal row As CarsRow, ByVal action As Global.System.Data.DataRowAction)
				Me.eventRow = row
				Me.eventAction = action
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public ReadOnly Property Row() As CarsRow
				Get
					Return Me.eventRow
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public ReadOnly Property Action() As Global.System.Data.DataRowAction
				Get
					Return Me.eventAction
				End Get
			End Property
		End Class
	End Class
End Namespace
Namespace ButtonEditWithPadding.CarsDBDataSetTableAdapters


	''' <summary>
	'''Represents the connection and commands used to retrieve and save data.
	'''</summary>
	<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), Global.System.ComponentModel.DesignerCategoryAttribute("code"), Global.System.ComponentModel.ToolboxItem(True), Global.System.ComponentModel.DataObjectAttribute(True), Global.System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" & ", Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"), Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
	Partial Public Class CarsTableAdapter
		Inherits System.ComponentModel.Component

		Private _adapter As Global.System.Data.OleDb.OleDbDataAdapter

		Private _connection As Global.System.Data.OleDb.OleDbConnection

		Private _commandCollection() As Global.System.Data.OleDb.OleDbCommand

		Private _clearBeforeFill As Boolean

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Public Sub New()
			Me.ClearBeforeFill = True
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Private ReadOnly Property Adapter() As Global.System.Data.OleDb.OleDbDataAdapter
			Get
				If (Me._adapter Is Nothing) Then
					Me.InitAdapter()
				End If
				Return Me._adapter
			End Get
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Friend Property Connection() As Global.System.Data.OleDb.OleDbConnection
			Get
				If (Me._connection Is Nothing) Then
					Me.InitConnection()
				End If
				Return Me._connection
			End Get
			Set(ByVal value As System.Data.OleDb.OleDbConnection)
				Me._connection = value
				If (Me.Adapter.InsertCommand IsNot Nothing) Then
					Me.Adapter.InsertCommand.Connection = value
				End If
				If (Me.Adapter.DeleteCommand IsNot Nothing) Then
					Me.Adapter.DeleteCommand.Connection = value
				End If
				If (Me.Adapter.UpdateCommand IsNot Nothing) Then
					Me.Adapter.UpdateCommand.Connection = value
				End If
				Dim i As Integer = 0
				Do While (i < Me.CommandCollection.Length)
					If (Me.CommandCollection(i) IsNot Nothing) Then
						CType(Me.CommandCollection(i), Global.System.Data.OleDb.OleDbCommand).Connection = value
					End If
					i = (i + 1)
				Loop
			End Set
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Protected ReadOnly Property CommandCollection() As Global.System.Data.OleDb.OleDbCommand()
			Get
				If (Me._commandCollection Is Nothing) Then
					Me.InitCommandCollection()
				End If
				Return Me._commandCollection
			End Get
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Public Property ClearBeforeFill() As Boolean
			Get
				Return Me._clearBeforeFill
			End Get
			Set(ByVal value As Boolean)
				Me._clearBeforeFill = value
			End Set
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Private Sub InitAdapter()
			Me._adapter = New Global.System.Data.OleDb.OleDbDataAdapter()
			Dim tableMapping As New Global.System.Data.Common.DataTableMapping()
			tableMapping.SourceTable = "Table"
			tableMapping.DataSetTable = "Cars"
			tableMapping.ColumnMappings.Add("Trademark", "Trademark")
			tableMapping.ColumnMappings.Add("Model", "Model")
			tableMapping.ColumnMappings.Add("HP", "HP")
			Me._adapter.TableMappings.Add(tableMapping)
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Private Sub InitConnection()
			Me._connection = New Global.System.Data.OleDb.OleDbConnection()
			Me._connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=""C:\Users\Public\Documents\DevExpres" & "s 2010.1 Demos\Components\Data\CarsDB.mdb"""
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Private Sub InitCommandCollection()
			Me._commandCollection = New Global.System.Data.OleDb.OleDbCommand(0){}
			Me._commandCollection(0) = New Global.System.Data.OleDb.OleDbCommand()
			Me._commandCollection(0).Connection = Me.Connection
			Me._commandCollection(0).CommandText = "SELECT Trademark, Model, HP FROM Cars"
			Me._commandCollection(0).CommandType = Global.System.Data.CommandType.Text
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"), Global.System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Fill, True)> _
		Public Overridable Function Fill(ByVal dataTable As CarsDBDataSet.CarsDataTable) As Integer
			Me.Adapter.SelectCommand = Me.CommandCollection(0)
			If (Me.ClearBeforeFill = True) Then
				dataTable.Clear()
			End If
			Dim returnValue As Integer = Me.Adapter.Fill(dataTable)
			Return returnValue
		End Function

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"), Global.System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Select, True)> _
		Public Overridable Function GetData() As CarsDBDataSet.CarsDataTable
			Me.Adapter.SelectCommand = Me.CommandCollection(0)
			Dim dataTable As New CarsDBDataSet.CarsDataTable()
			Me.Adapter.Fill(dataTable)
			Return dataTable
		End Function
	End Class
End Namespace

'INSTANT VB TODO TASK: There is no equivalent to #pragma directives in VB.NET:
'#pragma warning restore 1591