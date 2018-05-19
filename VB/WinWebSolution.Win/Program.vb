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
Imports System.Configuration
Imports System.Windows.Forms

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Security
Imports DevExpress.ExpressApp.Win
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl

Namespace WinWebSolution.Win
	Friend NotInheritable Class Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		Private Sub New()
		End Sub
		<STAThread> _
		Shared Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			EditModelPermission.AlwaysGranted = System.Diagnostics.Debugger.IsAttached
			Dim winApplication As New WinWebSolutionWindowsFormsApplication()
			If ConfigurationManager.ConnectionStrings("ConnectionString") IsNot Nothing Then
				winApplication.ConnectionString = ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString
			End If
			Try
    DevExpress.ExpressApp.InMemoryDataStoreProvider.Register()
    				winApplication.ConnectionString = DevExpress.ExpressApp.InMemoryDataStoreProvider.ConnectionString
				winApplication.Setup()
				winApplication.Start()
			Catch e As Exception
				winApplication.HandleException(e)
			End Try
		End Sub
	End Class
End Namespace
