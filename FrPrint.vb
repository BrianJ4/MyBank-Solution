Imports System.IO
Imports System.Reflection
Imports System.Text
Public Class FrPrint
    Dim AC, Cb As Integer
    Dim PrintBank(My.Settings.TotalTrans + 50) As Integer
    Dim PrintDate(My.Settings.TotalTrans + 50) As Date
    Dim PrintTransRef(My.Settings.TotalTrans + 50) As Integer
    Dim PrintDeb(My.Settings.TotalTrans + 50) As Double
    Dim PrintCre(My.Settings.TotalTrans + 50) As Double
    Dim PrintToFrom(My.Settings.TotalTrans + 50) As String
    Dim PrintCat(My.Settings.TotalTrans + 50) As String
    Dim PrintSubCat(My.Settings.TotalTrans + 50) As String
    Dim PrintBal(My.Settings.TotalTrans + 50) As Double
    Dim PrintState(My.Settings.TotalTrans + 50) As String
    Dim DocNum As String
    Dim FileName As String
    Dim varDate As Date
    Private Sub FrPrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.BkColour
        Label1.ForeColor = My.Settings.TxColour
        Label2.ForeColor = My.Settings.TxColour
        Label3.ForeColor = My.Settings.TxColour
        Label4.ForeColor = My.Settings.TxColour
        Label5.ForeColor = My.Settings.TxColour
        Label6.ForeColor = My.Settings.TxColour
        Label7.ForeColor = My.Settings.TxColour
        Label8.ForeColor = My.Settings.TxColour
        Label9.ForeColor = My.Settings.TxColour
        Label10.ForeColor = My.Settings.TxColour
        Label11.ForeColor = My.Settings.TxColour
        Label12.ForeColor = My.Settings.TxColour
        Label13.ForeColor = My.Settings.TxColour
        CheckBox1.ForeColor = My.Settings.TxColour
        CheckBox1.BackColor = My.Settings.BkColour
        CheckBox2.ForeColor = My.Settings.TxColour
        CheckBox2.BackColor = My.Settings.BkColour
        CheckBox3.ForeColor = My.Settings.TxColour
        CheckBox3.BackColor = My.Settings.BkColour
        CheckBox4.ForeColor = My.Settings.TxColour
        CheckBox4.BackColor = My.Settings.BkColour
        CheckBox5.ForeColor = My.Settings.TxColour
        CheckBox5.BackColor = My.Settings.BkColour
        CheckBox6.ForeColor = My.Settings.TxColour
        CheckBox6.BackColor = My.Settings.BkColour
        CheckBox7.ForeColor = My.Settings.TxColour
        CheckBox7.BackColor = My.Settings.BkColour
        CheckBox8.ForeColor = My.Settings.TxColour
        CheckBox8.BackColor = My.Settings.BkColour
        CheckBox9.ForeColor = My.Settings.TxColour
        CheckBox9.BackColor = My.Settings.BkColour
        CheckBox10.ForeColor = My.Settings.TxColour
        CheckBox10.BackColor = My.Settings.BkColour
        CheckBox11.ForeColor = My.Settings.TxColour
        CheckBox11.BackColor = My.Settings.BkColour
        'PageSetupDialog1.Document.DefaultPageSettings.Color = False
        'PageSetupDialog1.Document.DefaultPageSettings.Landscape = My.Settings.DocLandscape
        Label2.Text = "Each transaction is made up of 10 parts. You can choose which parts of the transaction that you want to Print by ticking each Box."
        Label3.Text = "You can Select which account that you want to Print or Select All Accounts"
        Label4.Text = "You also have to Choose the START Date and END Dates"
        Label6.Text = "Print Document, This saves the document as a web page and will open it in your default browser"
        Flag = False
        Dim CBflag1 As Boolean = False
        My.Settings.ProAccRef = 0
        My.Settings.Save()
        LoadTrans()
        LoadAccounts()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnAccLoad.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        Z = 0
        If CheckBox4.Checked = True Then
            My.Settings.ProAccRef = 11
            My.Settings.Save()
        End If
        Flag = False
        If CheckBox1.Checked = True Then Flag = True
        If CheckBox2.Checked = True Then Flag = True
        If CheckBox3.Checked = True Then Flag = True
        If CheckBox5.Checked = True Then Flag = True
        If CheckBox6.Checked = True Then Flag = True
        If CheckBox7.Checked = True Then Flag = True
        If CheckBox8.Checked = True Then Flag = True
        If CheckBox9.Checked = True Then Flag = True
        If CheckBox10.Checked = True Then Flag = True
        If My.Settings.ProAccRef = 11 Then
            ViewAcc()
        Else
            If Flag = True And My.Settings.ProAccRef > 0 Then
                Call ViewAcc2()
            End If
        End If
    End Sub
    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnSaveDoc.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        MakePDF()
    End Sub
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles BtnOpenDoc.Click
        Try
            My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
            SetPath = My.Settings.ProSetPath & "Documents\"
            Dim openFileDialog1 As New OpenFileDialog()
            openFileDialog1.InitialDirectory = SetPath
            'openFileDialog1.Filter = "txt files (*.txt)|*.txt|*.zip|*.rar|*.ico|*.exe|*.png|*.bmp|All files (*.*)|*.*"
            openFileDialog1.Filter = "txt files (*.html)|*.html"
            openFileDialog1.RestoreDirectory = True
            If openFileDialog1.ShowDialog() = DialogResult.OK Then
                SetPath = openFileDialog1.FileName.ToString()
                Dim pinfo As New ProcessStartInfo()
                pinfo.WindowStyle = ProcessWindowStyle.Normal
                pinfo.FileName = SetPath
                Dim p As Process = Process.Start(pinfo)
            End If
            openFileDialog1.Dispose()
        Catch ex As Exception
            MyErrors = "FrPrint BtnOpenDoc.Click " & ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        FrMainMenu.Show()
        Me.Close()
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBoxBank.SelectedIndexChanged
        Try
            Dim NumberOfAccouts As Integer = 0
            Dim SelectedAccType As String = ""
#Disable Warning BC42032 ' Operands of type Object used for operator '<>'; use the 'IsNot' operator to test object identity.
            If CBoxBank.SelectedItem <> "" Then
#Enable Warning BC42032 ' Operands of type Object used for operator '<>'; use the 'IsNot' operator to test object identity.
                CBoxAccount.Visible = True
                CBoxAccount.ResetText()
                CBoxAccount.Items.Clear()
                CommonLoadAccount()
                CBoxAccount.Items.Add("")
                For I = 1 To AccIndex
#Disable Warning BC42018 ' Operands of type Object used for operator '='; use the 'Is' operator to test object identity.
                    If LvBank(I) = CBoxBank.SelectedItem Then
#Enable Warning BC42018 ' Operands of type Object used for operator '='; use the 'Is' operator to test object identity.
                        CBoxAccount.Items.Add(LvType(I))
                        NumberOfAccouts = NumberOfAccouts + 1
                        SelectedAccType = LvType(I)
                    End If
                Next
            End If
            If NumberOfAccouts = 1 Then
                CBoxAccount.SelectedItem = SelectedAccType
                Call SetAccDetails()
            End If
        Catch ex As Exception
            MyErrors = "FrPrint ComboBox1_SelectedIndexChange " & ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        FillGrid()
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBoxAccount.SelectedIndexChanged
        Call SetAccDetails()
    End Sub
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        FillGrid()
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        FillGrid()
    End Sub
    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        Me.DataGridView1.Rows.Clear()
        If CheckBox4.Checked = True Then
            My.Settings.ProAccRef = 11
            My.Settings.Save()
            CBoxBank.SelectedItem = ""
            CBoxAccount.SelectedItem = ""
        End If
        FillGrid()
    End Sub
    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        FillGrid()
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        FillGrid()
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        FillGrid()
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        FillGrid()
    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged
        FillGrid()
    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox10.CheckedChanged
        FillGrid()
    End Sub
    Private Sub CheckBox11_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox11.CheckedChanged
        If CheckBox11.Checked = True Then
            CheckBox1.Checked = True
            CheckBox2.Checked = True
            CheckBox3.Checked = True
            CheckBox5.Checked = True
            CheckBox6.Checked = True
            CheckBox7.Checked = True
            CheckBox8.Checked = True
            CheckBox9.Checked = True
            CheckBox10.Checked = True
        End If
        If CheckBox11.Checked = False Then
            CheckBox1.Checked = False
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            CheckBox5.Checked = False
            CheckBox6.Checked = False
            CheckBox7.Checked = False
            CheckBox8.Checked = False
            CheckBox9.Checked = False
            CheckBox10.Checked = False
        End If
    End Sub
    Private Sub LoadAccounts()
        Try
            Me.DataGridView1.Rows.Clear()
            CBoxBank.Items.Clear()
            CBoxBank.SelectedItem = ""
            CBoxAccount.Items.Clear()
            CommonLoadAccount()
            Dim Dup As Integer = 0
            CBoxBank.Items.Add("")
            For I = 1 To AccIndex
                If CBoxBank.Items.Contains(LvBank(I)) Then
                    Dup += 1
                Else
                    CBoxBank.Items.Add(LvBank(I))
                End If
            Next I
            'CBoxBank.SelectedItem = ""
            'CBoxAccount.SelectedItem = ""
        Catch ex As Exception
            MyErrors = "FrPrint LoadAccounts " & ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub SetAccDetails()
        Try
            My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
            My.Settings.ProAccRef = 0
            My.Settings.Save()
            FrAccName = CStr(CBoxBank.SelectedItem)
            FrAccType = CStr(CBoxAccount.SelectedItem)
            If FrAccName <> "" And FrAccType <> "" Then
                CommonLoadAccount()
                For I = 1 To AccIndex
                    If LvBank(I) = FrAccName And LvType(I) = FrAccType Then
                        My.Settings.AccBank = LvBank(I)
                        My.Settings.AccType = LvType(I)
                        My.Settings.ProAccRef = LvRef(I)
                        My.Settings.Save()
                        Me.DataGridView1.Rows.Clear()
                        FillGrid()
                    End If
                Next I
                FileClose(1)
                CheckBox4.Checked = False
            End If
        Catch ex As Exception
            MyErrors = "FrPrint SetAccDetails " & ex.Message
            FrError.Show()
        End Try
    End Sub
    Sub FillGrid()
        Try
            My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
            Me.DataGridView1.Columns.Clear()
            Dim Col As DataGridViewTextBoxColumn
            If CheckBox1.Checked = True Then
                Col = New DataGridViewTextBoxColumn With {
                .Name = "DgBank",
                .HeaderText = "Bank",
                .Width = 120,
                .ReadOnly = True,
                .MaxInputLength = 10,
                .ToolTipText = "Entry Account Reference"
            }
                Me.DataGridView1.Columns.Add(Col)
                Col = New DataGridViewTextBoxColumn With {
               .Name = "DgAcc",
               .HeaderText = "Account",
               .Width = 120,
               .ReadOnly = True,
               .MaxInputLength = 10,
               .ToolTipText = "Entry Account Reference"
           }
                Me.DataGridView1.Columns.Add(Col)
            End If
            If CheckBox2.Checked = True Then
                Col = New DataGridViewTextBoxColumn With {
               .Name = "DgDate",
               .HeaderText = "Date",
               .Width = 90,
               .ReadOnly = True,
               .MaxInputLength = 12,
               .ToolTipText = "Entry Date"
           }
                Me.DataGridView1.Columns.Add(Col)
            End If
            If CheckBox3.Checked = True Then
                Col = New DataGridViewTextBoxColumn With {
                .Name = "DgRef",
                .HeaderText = "RefNo",
                .Width = 65,
                .ReadOnly = True,
                .MaxInputLength = 12,
                .ToolTipText = "Entry Account Reference"
            }
                Me.DataGridView1.Columns.Add(Col)
            End If
            If CheckBox5.Checked = True Then
                Col = New DataGridViewTextBoxColumn With {
                .Name = "DgDebit",
                .HeaderText = "Debit",
                .Width = 75,
                .ReadOnly = True,
                .MaxInputLength = 10,
                .ToolTipText = "Entry Debit Value"
            }
                Me.DataGridView1.Columns.Add(Col)
            End If
            If CheckBox6.Checked = True Then
                Col = New DataGridViewTextBoxColumn With {
                .Name = "DgCredit",
                .HeaderText = "Credit",
                .Width = 75,
                .ReadOnly = True,
                .MaxInputLength = 10,
                .ToolTipText = "Entry Credit Value"
            }
                Me.DataGridView1.Columns.Add(Col)
            End If
            If CheckBox7.Checked = True Then
                Col = New DataGridViewTextBoxColumn With {
                .Name = "DgToFrom",
                .HeaderText = "To / From",
                .Width = 140,
                .ReadOnly = True,
                .MaxInputLength = 30,
                .ToolTipText = "Entry Paid To or Received From"
            }
                Me.DataGridView1.Columns.Add(Col)
            End If
            If CheckBox8.Checked = True Then
                Col = New DataGridViewTextBoxColumn With {
               .Name = "DgCategory",
               .HeaderText = "Category",
               .Width = 140,
               .ReadOnly = True,
               .MaxInputLength = 30,
               .ToolTipText = "Entry Falls in to this Category"
           }
                Me.DataGridView1.Columns.Add(Col)
            End If
            If CheckBox9.Checked = True Then
                Col = New DataGridViewTextBoxColumn With {
               .Name = "DgSubCategory",
               .HeaderText = "Sub Category",
               .Width = 140,
               .ReadOnly = True,
               .MaxInputLength = 30,
               .ToolTipText = "Entry Falls in to this SubCategory"
           }
                Me.DataGridView1.Columns.Add(Col)
            End If
            If CheckBox10.Checked = True Then
                Col = New DataGridViewTextBoxColumn With {
              .Name = "DgState",
              .HeaderText = "State",
              .Width = 45,
              .ReadOnly = True,
              .MaxInputLength = 10,
              .ToolTipText = "Entry Transaction Type"
          }
                Me.DataGridView1.Columns.Add(Col)
            End If
            Col = New DataGridViewTextBoxColumn With {
                .Name = "DgBalance",
                .HeaderText = "Balance",
                .Width = 80,
                .ReadOnly = True,
                .MaxInputLength = 10,
                .ToolTipText = "Entry Credit Value"
            }
            Me.DataGridView1.Columns.Add(Col)
            Flag = False
            If CheckBox1.Checked = True Then Flag = True
            If CheckBox2.Checked = True Then Flag = True
            If CheckBox3.Checked = True Then Flag = True
            If CheckBox5.Checked = True Then Flag = True
            If CheckBox6.Checked = True Then Flag = True
            If CheckBox7.Checked = True Then Flag = True
            If CheckBox8.Checked = True Then Flag = True
            If CheckBox9.Checked = True Then Flag = True
            If CheckBox10.Checked = True Then Flag = True
        Catch ex As Exception
            MyErrors = "FrPrint FillGrid " & ex.Message
            FrError.Show()
        End Try
    End Sub
    Public Sub LoadTrans()
        Try
            MakePath = My.Settings.ProSetPath & "Current_Transaction_Data.mbtd"
            Dim colsexpected As Integer = 10
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
                    PrintBank(I) = CInt(words(0))
                    PrintDate(I) = CDate(words(1))
                    PrintTransRef(I) = CInt(words(2))
                    PrintDeb(I) = CDbl(words(3))
                    PrintCre(I) = CDbl(words(4))
                    PrintToFrom(I) = words(5)
                    PrintCat(I) = words(6)
                    PrintSubCat(I) = words(7)
                    PrintBal(I) = CDbl(words(8))
                    PrintState(I) = words(9)
                Else
                    MsgBox("Error On Line :-" & I.ToString & "---" & words.Length.ToString)
                End If
                I = I + 1
            Loop
            NumberOfEntries = I - 1
            thereader.Close()
        Catch ex As Exception
            MyErrors = "FrPrint  LoadTrans " & ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub ViewAcc()
        Try
            CommonLoadAccount()
            DataGridView1.Show()
            Me.DataGridView1.Rows.Clear()
#Disable Warning BC42024 ' Unused local variable: 'Cr'.
            Dim Cr As Integer
#Enable Warning BC42024 ' Unused local variable: 'Cr'.
            Dim PrBank As String
            Dim PrAccount As String
#Disable Warning BC42024 ' Unused local variable: 'PrRef'.
            Dim PrRef As Integer
#Enable Warning BC42024 ' Unused local variable: 'PrRef'.
            Balance = 0
            For I = 1 To NumberOfEntries
                If PrintDate(I) > DateTimePicker1.Value And PrintDate(I) < DateTimePicker2.Value Then
                    Dim R As New DataGridViewRow
                    Dim Rt As New DataGridViewTextBoxCell
                    'Rt.Style.BackColor = Color.DarkSeaGreen
                    '##########################  Bank   ###############################

                    If CheckBox1.Checked = True Then
                        For P = 1 To AccIndex
                            If LvRef(P) = PrintBank(I) Then
                                PrBank = LvBank(P)
                                PrAccount = LvType(P)
                            End If
                        Next P
#Disable Warning BC42104 ' Variable 'PrBank' is used before it has been assigned a value. A null reference exception could result at runtime.
                        Rt = New DataGridViewTextBoxCell With {
                                .Value = PrBank
                            }
#Enable Warning BC42104 ' Variable 'PrBank' is used before it has been assigned a value. A null reference exception could result at runtime.
                        R.Cells.Add(Rt)
#Disable Warning BC42104 ' Variable 'PrAccount' is used before it has been assigned a value. A null reference exception could result at runtime.
                        Rt = New DataGridViewTextBoxCell With {
                               .Value = PrAccount
                           }
#Enable Warning BC42104 ' Variable 'PrAccount' is used before it has been assigned a value. A null reference exception could result at runtime.
                        R.Cells.Add(Rt)
                    End If
                    '###########################  Date  ##############################

                    If CheckBox2.Checked = True Then
                        Rt = New DataGridViewTextBoxCell With {
                        .Value = Format(PrintDate(I), "dd/MM/yyyy")
                        }
                        R.Cells.Add(Rt)

                    End If
                    '#########################  Ref ################################

                    If CheckBox3.Checked = True Then
                        Rt = New DataGridViewTextBoxCell With {
                        .Value = PrintTransRef(I)
                        }
                        R.Cells.Add(Rt)
                        Rt.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                    End If
                    '#########################  Debit  ################################

                    If CheckBox5.Checked = True Then
                        Rt = New DataGridViewTextBoxCell With {
                                       .Value = Format(PrintDeb(I), "##,##0.00")
                                       }
                        R.Cells.Add(Rt)
                        Rt.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                    End If
                    '############################  Credit  #############################

                    If CheckBox6.Checked = True Then
                        Rt = New DataGridViewTextBoxCell With {
                                       .Value = Format(PrintCre(I), "##,##0.00")
                                       }
                        R.Cells.Add(Rt)
                        Rt.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                    End If
                    '##########################  Tp/From  ###############################

                    If CheckBox7.Checked = True Then

                        Rt = New DataGridViewTextBoxCell With {
                                       .Value = PrintToFrom(I)
                                       }
                        R.Cells.Add(Rt)
                        Rt.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
                    End If
                    '##########################  Category  ###############################

                    If CheckBox8.Checked = True Then
                        Rt = New DataGridViewTextBoxCell With {
                                       .Value = PrintCat(I)
                                       }
                        R.Cells.Add(Rt)
                        Rt.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
                    End If
                    '###########################  SubCategory  ##############################

                    If CheckBox9.Checked = True Then
                        Rt = New DataGridViewTextBoxCell With {
                                       .Value = PrintSubCat(I)
                                       }
                        R.Cells.Add(Rt)
                        Rt.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
                    End If
                    '##########################  State  ###############################

                    If CheckBox10.Checked = True Then
                        Rt = New DataGridViewTextBoxCell With {
                                       .Value = PrintState(I)
                                       }
                        R.Cells.Add(Rt)
                        Rt.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
                    End If

                    Rt = New DataGridViewTextBoxCell With {
                                           .Value = Format(Balance, "##,##0.00")
                                           }
                    R.Cells.Add(Rt)
                    Rt.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                    If Flag = True Then
                        Me.DataGridView1.Rows.Add(R)
                    End If
                End If
            Next I
        Catch ex As Exception
            MyErrors = "FrPrint ViewAcc " & ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub ViewAcc2()
        Try
            CommonLoadAccount()
            DataGridView1.Show()
            Me.DataGridView1.Rows.Clear()
#Disable Warning BC42024 ' Unused local variable: 'Cr'.
            Dim Cr As Integer
#Enable Warning BC42024 ' Unused local variable: 'Cr'.
            Dim PrBank As String
            Dim PrAccount As String
#Disable Warning BC42024 ' Unused local variable: 'PrRef'.
            Dim PrRef As Integer
#Enable Warning BC42024 ' Unused local variable: 'PrRef'.
            Balance = 0
            Z = 0
            T = 0
            For I = 1 To NumberOfEntries
                If PrintBank(I) = My.Settings.ProAccRef And PrintDate(I) < DateTimePicker1.Value Then
                    Balance = Balance - PrintDeb(I)
                    Balance = Balance + PrintCre(I)
                    T = I
                End If
            Next I
            For I = 1 To NumberOfEntries
                If PrintDate(I) >= DateTimePicker1.Value And PrintDate(I) <= DateTimePicker2.Value Then
                    If PrintBank(I) = My.Settings.ProAccRef Then
                        Dim R As New DataGridViewRow
                        Dim Rt As New DataGridViewTextBoxCell
                        'Rt.Style.BackColor = Color.DarkSeaGreen
                        '##########################  Bank   ###############################
                        If I > T Then
                            Balance = Balance - PrintDeb(I)
                            Balance = Balance + PrintCre(I)
                        End If
                        If CheckBox1.Checked = True Then
                            For P = 1 To AccIndex
                                If LvRef(P) = PrintBank(I) Then
                                    PrBank = LvBank(P)
                                    PrAccount = LvType(P)
                                End If
                            Next P
#Disable Warning BC42104 ' Variable 'PrBank' is used before it has been assigned a value. A null reference exception could result at runtime.
                            Rt = New DataGridViewTextBoxCell With {
                                .Value = PrBank
                            }
#Enable Warning BC42104 ' Variable 'PrBank' is used before it has been assigned a value. A null reference exception could result at runtime.
                            R.Cells.Add(Rt)
#Disable Warning BC42104 ' Variable 'PrAccount' is used before it has been assigned a value. A null reference exception could result at runtime.
                            Rt = New DataGridViewTextBoxCell With {
                               .Value = PrAccount
                           }
#Enable Warning BC42104 ' Variable 'PrAccount' is used before it has been assigned a value. A null reference exception could result at runtime.
                            R.Cells.Add(Rt)
                        End If
                        '###########################  Date  ##############################

                        If CheckBox2.Checked = True Then
                            Rt = New DataGridViewTextBoxCell With {
                            .Value = Format(PrintDate(I), "dd/MM/yyyy")
                            }
                            R.Cells.Add(Rt)

                        End If
                        '#########################  Ref ################################

                        If CheckBox3.Checked = True Then
                            Rt = New DataGridViewTextBoxCell With {
                            .Value = PrintTransRef(I)
                            }
                            R.Cells.Add(Rt)
                            Rt.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                        End If
                        '#########################  Debit  ################################

                        If CheckBox5.Checked = True Then
                            Rt = New DataGridViewTextBoxCell With {
                                           .Value = Format(PrintDeb(I), "##,##0.00")
                                           }
                            R.Cells.Add(Rt)
                            Rt.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                        End If
                        '############################  Credit  #############################

                        If CheckBox6.Checked = True Then
                            Rt = New DataGridViewTextBoxCell With {
                                           .Value = Format(PrintCre(I), "##,##0.00")
                                           }
                            R.Cells.Add(Rt)
                            Rt.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                        End If
                        '##########################  Tp/From  ###############################

                        If CheckBox7.Checked = True Then
                            Rt = New DataGridViewTextBoxCell With {
                                           .Value = PrintToFrom(I)
                                           }
                            R.Cells.Add(Rt)
                            Rt.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
                        End If
                        '##########################  Category  ###############################

                        If CheckBox8.Checked = True Then
                            Rt = New DataGridViewTextBoxCell With {
                                           .Value = PrintCat(I)
                                           }
                            R.Cells.Add(Rt)
                            Rt.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
                        End If
                        '###########################  SubCategory  ##############################

                        If CheckBox9.Checked = True Then
                            Rt = New DataGridViewTextBoxCell With {
                                           .Value = PrintSubCat(I)
                                           }
                            R.Cells.Add(Rt)
                            Rt.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
                        End If
                        '##########################  State  ###############################

                        If CheckBox10.Checked = True Then
                            Rt = New DataGridViewTextBoxCell With {
                                           .Value = PrintState(I)
                                           }
                            R.Cells.Add(Rt)
                        End If
                        Rt = New DataGridViewTextBoxCell With {
                                           .Value = Format(Balance, "##,##0.00")
                                           }
                        R.Cells.Add(Rt)
                        Rt.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                        If Flag = True Then
                            Me.DataGridView1.Rows.Add(R)
                        End If
                    Else
                    End If
                End If
            Next I
        Catch ex As Exception
            MyErrors = "FrPrint ViewAcc2 " & ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub MakePDF()
        Try
            'create empty string
            Dim the_html_file As String = String.Empty

            Dim stylesheet As String = "  table.gridtable {margin:0 auto;width:95%;overflow:auto;font-family: helvetica,arial,sans-serif;"
            stylesheet &= "font-size:14px;color:#333333;border-width: 1px;border-color: #666666;border-collapse: collapse;text-align: center}"
            stylesheet &= "table.gridtable th {border-width: 1px;padding: 8px; border-style: solid;border-color: #666666;background-color: #F6B4A5;}"
            stylesheet &= "table.gridtable td {border-width: 1px;padding: 8px;border-style: solid;border-color: #666666;}"

            the_html_file = "<!DOCTYPE html><html><head><meta charset='UTF-8'><title>VB grid to html</title><style>" & stylesheet & "</style></head><body>"

            the_html_file &= "<table class='gridtable'>"
            the_html_file &= "<thead><tr>"

            'get the column headers
            For Each column As DataGridViewColumn In DataGridView1.Columns
                the_html_file = the_html_file & "<th>" & column.HeaderText & "</th>"
            Next

            the_html_file = the_html_file & "</tr></thead><tbody>"

            'get the rows
            For Each row As DataGridViewRow In DataGridView1.Rows
                the_html_file &= "<tr>"
                'get the cells
                For Each cell As DataGridViewCell In row.Cells

#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                    Dim cellcontent As String = cell.FormattedValue
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
                    'replace < and > with html entities
                    cellcontent = Replace(cellcontent, "<", "&lt;")
                    cellcontent = Replace(cellcontent, ">", "&gt;")

                    the_html_file = the_html_file & "<td>" & cellcontent & "</td>"
                Next
                the_html_file &= "</tr>"
            Next
            the_html_file &= "</tbody></table></body></html>"
            '################  Add prefix and date to file Name  #####################################
            DocNum = My.Settings.DocNumber.ToString
            Dim FileName As String = "MyBank" & DocNum & ".html"
            FileName = FileName.Replace(".html", "_" & System.DateTime.Now.ToString("ddMMyyyy") & ".html")
            SetPath = My.Settings.ProSetPath & "\Documents\" & FileName
            'write the file
            My.Computer.FileSystem.WriteAllText(SetPath, the_html_file, False)
            My.Settings.DocNumber = My.Settings.DocNumber + 1
            My.Settings.Save()

            If MessageBox.Show("Would you like to Print Document?", "MyBank Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
                'pass file to default browser
                Dim pinfo As New ProcessStartInfo()
                pinfo.WindowStyle = ProcessWindowStyle.Normal
                pinfo.FileName = SetPath
                Dim p As Process = Process.Start(pinfo)
            Else
                My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
            End If

        Catch ex As Exception
            MyErrors = "FrPrint MakePDF " & ex.Message
            FrError.Show()
        End Try
    End Sub
End Class