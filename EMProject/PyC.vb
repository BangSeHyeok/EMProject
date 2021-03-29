Imports IronPython.Hosting
Imports Microsoft.Scripting.Hosting
Public Class PyC
    Public Sub aa()
        Dim pyruntime As ScriptRuntime
        Dim obj As Object

        pyruntime = Python.CreateRuntime()
        Dim path = System.Windows.Forms.Application.StartupPath
        'MsgBox(path)
        obj = pyruntime.UseFile("test.py")
        'MsgBox(obj.ToString)
        Dim test As String
        test = obj.getPytonFunc()
        ' MsgBox(test)
    End Sub
End Class
