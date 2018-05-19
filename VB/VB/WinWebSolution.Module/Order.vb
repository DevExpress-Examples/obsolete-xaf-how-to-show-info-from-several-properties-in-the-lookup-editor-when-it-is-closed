' Developer Express Code Central Example:
' How to show info from several properties in the lookup editor when it is closed
' 
' This example is an intermediate workaround for the suggestion. To see how this
' works, open the Order detail view and notice that the Customer editor displays
' more information than usual.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E1322


Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo
Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Validation

Namespace WinWebSolution.Module
	<DefaultClassOptions> _
	Public Class Order
		Inherits BaseObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Private name_Renamed As String
		Public Property Name() As String
			Get
				Return name_Renamed
			End Get
			Set(ByVal value As String)
				SetPropertyValue("Name", name_Renamed, value)
			End Set
		End Property
		Private date_Renamed As DateTime
		Public Property [Date]() As DateTime
			Get
				Return date_Renamed
			End Get
			Set(ByVal value As DateTime)
				SetPropertyValue("Date", date_Renamed, value)
			End Set
		End Property
		Private customer_Renamed As Customer
		<Custom("LookupProperty", "CustomerLookupDisplayText")> _
		Public Property Customer() As Customer
			Get
				Return customer_Renamed
			End Get
			Set(ByVal value As Customer)
				SetPropertyValue("Customer", customer_Renamed, value)
			End Set
		End Property
	End Class
End Namespace
