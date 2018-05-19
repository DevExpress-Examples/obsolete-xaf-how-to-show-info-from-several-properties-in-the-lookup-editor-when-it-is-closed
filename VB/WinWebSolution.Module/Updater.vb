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

Imports DevExpress.ExpressApp.Updating
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.BaseImpl

Namespace WinWebSolution.Module
	Public Class Updater
		Inherits ModuleUpdater
		Public Sub New(ByVal objectSpace As ObjectSpace, ByVal currentDBVersion As Version)
			MyBase.New(objectSpace, currentDBVersion)
		End Sub
		Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
			MyBase.UpdateDatabaseAfterUpdateSchema()
			Dim obj1 As Customer = ObjectSpace.FindObject(Of Customer)(CriteriaOperator.Parse("Name=?", "Customer1"))
			If obj1 Is Nothing Then
				obj1 = New Customer(Session)
				obj1.Name = "Customer1"
				obj1.Email = "Customer1@company.com"
				obj1.PhoneNumber = "01234"
				obj1.Save()
			End If
			Dim obj2 As Order = ObjectSpace.FindObject(Of Order)(CriteriaOperator.Parse("Name=?", "Order1"))
			If obj2 Is Nothing Then
				obj2 = New Order(Session)
				obj2.Name = "Order1"
				obj2.Date = DateTime.Now
				obj2.Customer = obj1
				obj2.Save()
			End If
		End Sub
	End Class
End Namespace