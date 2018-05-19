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
Namespace WinWebSolution.Module
	Partial Public Class WinWebSolutionModule
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			' 
			' WinWebSolutionModule
			' 
			Me.RequiredModuleTypes.Add(GetType(DevExpress.ExpressApp.SystemModule.SystemModule))
			Me.RequiredModuleTypes.Add(GetType(DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule))
		End Sub

		#End Region
	End Class
End Namespace
