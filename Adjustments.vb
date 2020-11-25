Imports System.IO
Imports System.Text
Public Class Adjustments
    Private Sub Adjustments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BaseForm_Load()
        Label4.Text = "Start"
        Label3.Text = "Calculates the number of transactions you have"
        Label5.Text = "Renumbers the transaction reference numbers"
        Label6.Text = "Fix any issues with the transactions"
        Label7.Text = "Tell you if the transaction file is beyond repair"
        Label8.Text = "The original file will be placed in the RecycleBin "
        With ProgressBar1
            .Minimum = 0
            .Maximum = 50000
            .Increment(1)
        End With
    End Sub
    Private Sub BtnAbout_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        Try
            CleanTransactions()
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Try
            FrOptions.Show()
            Me.Close()
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub CleanTransactions()
        Try
            LoadTrans()
            '#############  Delete Old file ################
            My.Computer.FileSystem.DeleteFile(
      My.Settings.ProSetPath & "Current_Transaction_Data.mbtd",
      FileIO.UIOption.OnlyErrorDialogs,
      FileIO.RecycleOption.SendToRecycleBin,
      FileIO.UICancelOption.ThrowException)
            '#############   Rename new file #######################
            My.Computer.FileSystem.RenameFile(My.Settings.ProSetPath & "Current_Transaction1_Data.mbtd", "Current_Transaction_Data.mbtd")
            '#############   Rename new file #######################
            Label4.Text = "Finishing Up"
            For I = 1 To 50000
                ProgressBar1.Value = I
            Next I
            Label4.Text = "Complete"
            My.Settings.TotalTrans = Z - 3
            My.Settings.TransRefNo = Z
            My.Settings.Save()
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub LoadTrans()
        Try
            MakePath = My.Settings.ProSetPath & "Current_Transaction_Data.mbtd"
            Dim colsexpected As Integer = 10
            Dim thereader As New StreamReader(MakePath, Encoding.Default)
            Dim sline As String = ""
            Z = 2
            Do
                sline = thereader.ReadLine
                If sline = Nothing Then Exit Do
                Dim words() As String = sline.Split(",")
                AccRef = words(0)
                FrDate = words(1)
                TransRef = words(2)
                TransDeb = words(3)
                TransCre = words(4)
                ToFrom = words(5)
                Cat = words(6)
                SubCat = words(7)
                Balance = words(8)
                TransState = words(9)
                TransRef = Z
                Z = Z + 1
                SaveTrans()
            Loop
            thereader.Close()
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub SaveTrans()
        Try
            FileOpen(1, My.Settings.ProSetPath & "Current_Transaction1_Data.mbtd", OpenMode.Append)
            PrintLine(1, AccRef & "," & FrDate & "," & TransRef & "," & TransDeb & "," & TransCre & "," & ToFrom & "," & Cat & "," & SubCat & "," & Balance & "," & TransState)
            FileClose(1)
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub

    Private Sub BaseForm_Load()
        Try
            If Not Me.DesignMode Then
                Me.FormBorderStyle = FormBorderStyle.None
                Me.StartPosition = FormStartPosition.CenterScreen
                Me.Size = New Size(800, 500)
                Dim p As New System.Drawing.Drawing2D.GraphicsPath
                Dim CurveSize As Int32 = 250
                p.StartFigure()
                p.AddArc(New Rectangle(0, 0, CurveSize, CurveSize), 180, 90)
                p.AddLine(CurveSize, 0, Me.Width - CurveSize, 0)
                p.AddArc(New Rectangle(Me.Width - CurveSize, 0, CurveSize,
                CurveSize), -90, 90)
                p.AddLine(Me.Width, CurveSize, Me.Width, Me.Height - CurveSize)
                p.AddArc(New Rectangle(Me.Width - CurveSize, Me.Height - CurveSize, CurveSize, CurveSize), 0, 90)
                p.AddLine(Me.Width - 40, Me.Height, 40, Me.Height)
                p.AddArc(New Rectangle(0, Me.Height - CurveSize, CurveSize, CurveSize), 90, 90)
                p.CloseFigure()
                Me.Region = New Region(p)
                Me.BackColor = Me.BackColor
                p.Dispose()
            End If
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
End Class