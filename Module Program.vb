Module Module_Program
    Public Sub Main()
        If My.Settings.ProStart = True Then
            Application.Run(New FrStart())
        Else
            Application.Run(New FrFirstTime())
        End If
    End Sub
End Module
