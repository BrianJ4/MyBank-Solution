Imports System.IO
Imports System.Text
Imports System.Data
Public Class FrProcessDirectDebits
    Public Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.BkColour
        Panel4.BackColor = My.Settings.BkColour
        DataGridView1.BackgroundColor = My.Settings.BkColour
        Label1.ForeColor = My.Settings.TxColour
        Label2.ForeColor = My.Settings.TxColour
        Label3.ForeColor = My.Settings.TxColour
        Label4.ForeColor = My.Settings.TxColour
        Label5.ForeColor = My.Settings.TxColour
        LblExceed1.ForeColor = My.Settings.TxColour
        LblExceed2.ForeColor = My.Settings.TxColour
        LblNoOrders.ForeColor = My.Settings.TxColour
        LblExceed1.Visible = False
        LblExceed2.Visible = False
        Call BaseForm_Load()
        Label2.Text = "Select Order End Date and Choose REFRESH"
        BtnSave.Visible = False
        LblNoOrders.Visible = True
        Call LoadOrders()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        Try
            My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
            If DateTimePicker1.Value < Now Then
                MyMsg = " Date must be some time" & vbNewLine & " after today's date."
                MyMsgFlag = False
                FrMsgOk.ShowDialog()
            Else
                Panel4.Visible = False
                Label2.Visible = False
                BtnSave.Visible = False
                LblNoOrders.Visible = True
                Call LoadOrders()
                Call GridUpdate()
                Call AddTransactonRows()
            End If
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        Call SaveTransactions()
        Call SaveOrders()
        My.Settings.TransRefNo = TotalRef
        My.Settings.TransDataChanged = True
        My.Settings.Save()
        MyMsg = "Successfully Completed Transactions"
        MyMsgFlag = False
        FrMsgOk.ShowDialog()
        FrMainMenu.Show()
        Me.Close()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        FrMainMenu.Show()
        Me.Close()
    End Sub
    Public Sub LoadOrders()
        Try
            MakePath = My.Settings.ProSetPath & "Current_Orders.mbtd"
            Dim colsexpected As Integer = 14
            Dim thereader As New StreamReader(MakePath, Encoding.Default)
            Dim sline As String = ""
            I = 1
            Do
                sline = thereader.ReadLine
                If sline = Nothing Then Exit Do
#Disable Warning BC42016 ' Implicit conversion from 'String' to 'Char'.
                Dim words() As String = sline.Split(",")
#Enable Warning BC42016 ' Implicit conversion from 'String' to 'Char'.
                If words.Length = colsexpected Then
                    OrderRef(I) = CInt(words(0))
                    OrderAccRef(I) = CInt(words(1))
                    OrderStartDate(I) = CDate(words(2))
                    OrderEndDate(I) = CDate(words(3))
                    OrderPointDate(I) = CDate(words(4))
                    OrderValue(I) = CDbl(words(5))
                    OrderDebCre(I) = words(6)
                    OrderType(I) = words(7)
                    OrderToFrom(I) = words(8)
                    OrderCategory(I) = words(9)
                    OrderSubCategory(I) = words(10)
                    OrderDayCount(I) = CInt(words(11))
                    OrderIntervalType(I) = words(12)
                    OrderState(I) = words(13)
                    OrderTransDate(I) = OrderPointDate(I)
                Else
                    MyErrors = " ERROR Orders file corrupt"
                    FrError.Show()
                End If
                I = I + 1
            Loop
            NumberOfEntries = I - 1
            thereader.Close()
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Public Sub SaveOrders()
        Try
            MakePath = My.Settings.ProSetPath & "Current_Orders.mbtd"
            FileOpen(1, MakePath, OpenMode.Output)
            For I = 1 To NumberOfEntries
                PrintLine(1, OrderRef(I) & "," & OrderAccRef(I) & "," & OrderStartDate(I) & "," & OrderEndDate(I) & "," & OrderPointDate(I) & "," & OrderValue(I) & "," & OrderDebCre(I) & "," & OrderType(I) & "," & OrderToFrom(I) & "," & OrderCategory(I) & "," & OrderSubCategory(I) & "," & OrderDayCount(I) & "," & OrderIntervalType(I) & "," & OrderState(I))
            Next
            FileClose(1)
            'NotifyIcon1.ShowBalloonTip(10000, "Info", "Transactions Complete", ToolTipIcon.Info)
            For I = 1 To 1000
            Next
            FileClose(1)
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Public Sub SaveTransactions()
        Try
            MakePath = My.Settings.ProSetPath
            MakePath = MakePath & "Current_Transaction_Data.mbtd"
            Dim thecsvfile As String = String.Empty
            For Each row As DataGridViewRow In DataGridView1.Rows
                'get the cells
                For Each cell As DataGridViewCell In row.Cells
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
#Disable Warning BC42017 ' Late bound resolution; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Disable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
                    thecsvfile = thecsvfile & cell.FormattedValue.replace(",", "") & ","
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42019 ' Operands of type Object used for operator '&'; runtime errors could occur.
#Enable Warning BC42017 ' Late bound resolution; runtime errors could occur.
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                Next
                'trim the last comma
#Disable Warning BC42016 ' Implicit conversion from 'String' to 'Char'.
                thecsvfile = thecsvfile.TrimEnd(",")
#Enable Warning BC42016 ' Implicit conversion from 'String' to 'Char'.
                'Add the line to the output
                thecsvfile = thecsvfile & vbCr & vbLf
            Next
            'write the file
            My.Computer.FileSystem.WriteAllText(MakePath, thecsvfile, True)
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Public Sub GridUpdate()
        'SET Columns
        Me.DataGridView1.Columns.Clear()
        Dim Col As DataGridViewTextBoxColumn
        Col = New DataGridViewTextBoxColumn With {
            .Name = "DgAccRef",
            .HeaderText = "AccRef",
            .Width = 50,
            .ReadOnly = True,
            .MaxInputLength = 10,
            .ToolTipText = "Entery Account Reference"
        }
        Me.DataGridView1.Columns.Add(Col)
        Col = New DataGridViewTextBoxColumn With {
            .Name = "DgDate",
            .HeaderText = "Date",
            .Width = 87,
            .ReadOnly = True,
            .MaxInputLength = 12,
            .ToolTipText = "Entery Date"
        }
        Me.DataGridView1.Columns.Add(Col)
        Col = New DataGridViewTextBoxColumn With {
            .Name = "DgRef",
            .HeaderText = "Ref",
            .Width = 60,
            .ReadOnly = True,
            .MaxInputLength = 10,
            .ToolTipText = "Entery Account Reference"
        }
        Me.DataGridView1.Columns.Add(Col)
        Col = New DataGridViewTextBoxColumn With {
            .Name = "DgDebit",
            .HeaderText = "Debit",
            .Width = 80,
            .ReadOnly = True,
            .MaxInputLength = 10,
            .ToolTipText = "Entery Debit Value"
        }
        Me.DataGridView1.Columns.Add(Col)
        Col = New DataGridViewTextBoxColumn With {
            .Name = "DgCredit",
            .HeaderText = "Credit",
            .Width = 80,
            .ReadOnly = True,
            .MaxInputLength = 10,
            .ToolTipText = "Entery Credit Value"
        }
        Me.DataGridView1.Columns.Add(Col)
        Col = New DataGridViewTextBoxColumn With {
            .Name = "DgToFrom",
            .HeaderText = "To / From",
            .Width = 200,
            .ReadOnly = True,
            .MaxInputLength = 30,
            .ToolTipText = "Entery Paid To or Received From"
        }
        Me.DataGridView1.Columns.Add(Col)
        Col = New DataGridViewTextBoxColumn With {
            .Name = "DgCategory",
            .HeaderText = "Category",
            .Width = 200,
            .ReadOnly = True,
            .MaxInputLength = 30,
            .ToolTipText = "Entery Falls in to this Category"
        }
        Me.DataGridView1.Columns.Add(Col)
        Col = New DataGridViewTextBoxColumn With {
            .Name = "DgSubCategory",
            .HeaderText = "Sub Category",
            .Width = 200,
            .ReadOnly = True,
            .MaxInputLength = 30,
            .ToolTipText = "Entery Falls in to this SubCategory"
        }
        Me.DataGridView1.Columns.Add(Col)
        Col = New DataGridViewTextBoxColumn With {
            .Name = "DgBalance",
            .HeaderText = "Balance",
            .Width = 80,
            .ReadOnly = True,
            .MaxInputLength = 10,
            .ToolTipText = "Entery Credit Value"
        }
        Me.DataGridView1.Columns.Add(Col)
        Col = New DataGridViewTextBoxColumn With {
           .Name = "DgState",
           .HeaderText = "State",
           .Width = 50,
           .ReadOnly = True,
           .MaxInputLength = 10,
           .ToolTipText = "Entery Transaction Type"
       }
        Me.DataGridView1.Columns.Add(Col)
    End Sub
    Public Sub AddTransactonRows()
        Try
            LblExceed1.Visible = False
            LblExceed2.Visible = False
            'ADD ROWS
            Dim Temp As Date
            Dim FirstPassFlag As Boolean
            GridRowCount = 0
            Dim Bal As Double = 0
            TotalRef = My.Settings.TransRefNo
            TotalRef = TotalRef + 1
            For I = 1 To NumberOfEntries
                If TotalRef > My.Settings.TransRefNo + 150 Then
                    LblExceed1.Visible = True
                    LblExceed2.Visible = True
                    BtnSave.Visible = False
                    Me.DataGridView1.Rows.Clear()
                    TempPointDate = CDate(Format(DateTimePicker1.Value, "dd/MM/yyyy"))
                    LblExceed1.Text = "Sorry you have Exceeded the number of Transactions that areallowed in One pass"
                    LblExceed2.Text = "You must try again using A Refresh Date smaller than :- " & TempPointDate.ToString
                Else
                    TempPointDate = CDate(Format(DateTimePicker1.Value, "dd/MM/yyyy"))
                    FirstPassFlag = True
                    Temp = DateAdd(OrderIntervalType(I), OrderDayCount(I), OrderTransDate(I))
                    If Temp > TempPointDate Then
                        OrderTransDate(I) = DateAdd(OrderIntervalType(I), OrderDayCount(I), OrderTransDate(I))
                    End If
                    While OrderTransDate(I) < TempPointDate And OrderTransDate(I) < OrderEndDate(I)


                        If OrderTransDate(I) = OrderPointDate(I) And FirstPassFlag = True Then
                            OrderTransDate(I) = DateAdd(OrderIntervalType(I), OrderDayCount(I), OrderTransDate(I))
                        End If

                        If OrderDebCre(I) = "C" Then
                            OrderCredit(I) = OrderValue(I)
                            OrderDebit(I) = 0
                        End If

                        If OrderDebCre(I) = "D" Then
                            OrderDebit(I) = OrderValue(I)
                            OrderCredit(I) = 0
                        End If
                        TransDebCre(GridRowCount) = OrderDebCre(I)
                        TransValue(GridRowCount) = OrderValue(I)
                        'Fill Row Details
                        Dim R As New DataGridViewRow
                        Dim Rt As New DataGridViewTextBoxCell
                        'Rt.Style.BackColor = Color.DarkSeaGreen
                        Rt = New DataGridViewTextBoxCell With {
                        .Value = OrderAccRef(I)
                        }
                        R.Cells.Add(Rt)
                        Rt = New DataGridViewTextBoxCell With {
                        .Value = Format(OrderTransDate(I), "dd/MM/yyyy")
                        }
                        R.Cells.Add(Rt)
                        Rt = New DataGridViewTextBoxCell With {
                        .Value = TotalRef
                        }
                        R.Cells.Add(Rt)
                        Rt = New DataGridViewTextBoxCell With {
                        .Value = Format(OrderDebit(I), "##,##0.00")
                        }
                        R.Cells.Add(Rt)
                        Rt = New DataGridViewTextBoxCell With {
                        .Value = Format(OrderCredit(I), "##,##0.00")
                        }
                        R.Cells.Add(Rt)
                        Rt = New DataGridViewTextBoxCell With {
                        .Value = OrderToFrom(I)
                        }
                        R.Cells.Add(Rt)
                        Rt = New DataGridViewTextBoxCell With {
                        .Value = OrderCategory(I)
                        }
                        R.Cells.Add(Rt)
                        Rt = New DataGridViewTextBoxCell With {
                        .Value = OrderSubCategory(I)
                        }
                        R.Cells.Add(Rt)
                        Rt = New DataGridViewTextBoxCell With {
                        .Value = Format(Bal, "0.00")
                        }
                        R.Cells.Add(Rt)
                        Rt = New DataGridViewTextBoxCell With {
                        .Value = "---"
                        }
                        R.Cells.Add(Rt)
                        Me.DataGridView1.Rows.Add(R)
                        OrderPointDate(I) = OrderTransDate(I)
                        OrderTransDate(I) = DateAdd(OrderIntervalType(I), OrderDayCount(I), OrderTransDate(I))
                        GridRowCount += 1
                        FirstPassFlag = False
                        LblNoOrders.Visible = False
                        BtnSave.Visible = True
                        TotalRef = TotalRef + 1
                    End While
                End If
            Next I

            'My.Settings.TotalTrans = TotalRef - 1
            'My.Settings.Save()
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    '###############################  Make Round Form  ##################################
    Private Sub BaseForm_Load()
        If Not Me.DesignMode Then
            Me.FormBorderStyle = FormBorderStyle.None
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.Size = New Size(1200, 600)
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
    End Sub
End Class