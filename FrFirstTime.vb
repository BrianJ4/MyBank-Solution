Public Class FrFirstTime
    Private Sub FrFirstTime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = "By default you data will be Stored on your C drive In the 'Bank Project' folder"
        Label6.Text = "But you can change the file location at any time "
        Label6.Text = "Note: That your data is secure as it's only stored on your computer"
        'BaseForm_Load()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CreateNewFiles()
        My.Settings.ProStart = True
        My.Settings.AccLive = False
        My.Settings.Save()
        FrStart.Show()
        Me.Hide()
    End Sub
    Private Sub CreateNewFiles()
        My.Settings.ProSetPath = "C:\Bank Project\MyBanKData\"
        My.Settings.Save()
        My.Computer.FileSystem.CreateDirectory("C:\Bank Project")
        My.Computer.FileSystem.CreateDirectory("C:\Bank Project\MyBanKData\")
        My.Computer.FileSystem.CreateDirectory("C:\Bank Project\MyBanKData\Documents")
        FileOpen(1, My.Settings.ProSetPath & "AccountIndex.txt", OpenMode.Output)
        PrintLine(1, 0)
        FileClose(1)
        FileOpen(1, My.Settings.ProSetPath & "Current_Orders.mbtd", OpenMode.Output)
        FileClose(1)
        FileOpen(1, My.Settings.ProSetPath & "Current_Transaction_Data.mbtd", OpenMode.Output)
        FileClose(1)
        '##############  Master List  #################################
        FileOpen(1, My.Settings.ProSetPath & "Master_List_Data.mbtd", OpenMode.Output)
        PrintLine(1, "Water Rates,House,Water")
        PrintLine(1, "Council Tax,House,Council Tax")
        PrintLine(1, "TV Licence,House,TV Licence")
        PrintLine(1, "Gas/Elec,House,Gas/Elec")
        PrintLine(1, "Rent,House,Rent")
        PrintLine(1, "Mortgage,House,Mortgage")
        PrintLine(1, "Opening Balance,Opening Balance,None")
        FileClose(1)
        '##############  Settings  #################################
        FileOpen(1, My.Settings.ProSetPath & "settings.mbtd", OpenMode.Output)
        PrintLine(1, My.Settings.OrderRef)
        PrintLine(1, My.Settings.TotalTrans)
        PrintLine(1, My.Settings.TransRefNo)
        PrintLine(1, My.Settings.AccRefNo)
        PrintLine(1, My.Settings.ProName)
        PrintLine(1, My.Settings.ProAdr1)
        PrintLine(1, My.Settings.ProAdr2)
        PrintLine(1, My.Settings.ProTown)
        PrintLine(1, My.Settings.ProCity)
        PrintLine(1, My.Settings.ProCountry)
        PrintLine(1, My.Settings.ProPostCode)
        PrintLine(1, My.Settings.ProTel)
        PrintLine(1, My.Settings.ProEmail)
        PrintLine(1, My.Settings.ProSetPath)
        PrintLine(1, My.Settings.activeDir)
        PrintLine(1, My.Settings.BkUpDir)
        FileClose(1)
    End Sub
End Class