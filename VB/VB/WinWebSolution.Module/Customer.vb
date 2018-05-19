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
	Public Class Customer
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
		Private email_Renamed As String
		Public Property Email() As String
			Get
				Return email_Renamed
			End Get
			Set(ByVal value As String)
				SetPropertyValue("Email", email_Renamed, value)
			End Set
		End Property
		Private phoneNumber_Renamed As String
		Public Property PhoneNumber() As String
			Get
				Return phoneNumber_Renamed
			End Get
			Set(ByVal value As String)
				SetPropertyValue("PhoneNumber", phoneNumber_Renamed, value)
			End Set
		End Property
		Protected ReadOnly Property CustomerLookupDisplayText() As String
			Get
				Return String.Format("{0} (Email: {1}, PhoneNumber: {2} )", Name, Email, PhoneNumber)
			End Get
		End Property
	End Class
End Namespace