Imports System
Imports System.IO
Namespace Splashscreen
    Public Class SplashscreenController

        'The lockfile name will be passed automatically by Splash.exe as a  
        'command line arg -lockfile="c:\temp\C1679A85-A4FA-48a2-BF77-E74F73E08768.lock"
        Private Shared Function GetLockFile() As String
            For Each arg As String In Environment.GetCommandLineArgs
                If arg.StartsWith("-lockfile=") Then
                    Return arg.Replace("-lockfile=", String.Empty)
                End If
            Next
            Throw New ArgumentNullException("Must call EXE with -lockfile= command line argument")
        End Function

        Public Shared Sub UpdateStatusLabel(ByVal comment As String)
            Dim tw As TextWriter = New StreamWriter(GetLockFile, False)
            tw.WriteLine(comment)
            tw.Close()
        End Sub

        Public Shared Sub CloseSplash()
            File.Delete(GetLockFile)
        End Sub
    End Class
End Namespace