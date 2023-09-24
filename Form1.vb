Imports System.Globalization
Imports System.IO
Imports System.Threading

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US")
    End Sub

    Function HSV_ColorConvert(Hue As Single, Saturation As Single, Value As Single) As Color ' Hue in degrees, Saturation and Value in range 0.0 - 1.0
        Dim OutColor As Color

        Hue = Hue Mod 360 ' If negative, it gets set to 360 - Hue

        Dim C = Value * Saturation
        Dim X = C * (1 - Math.Abs((Hue / 60 Mod 2) - 1))
        Dim m = Value - C

        If Hue >= 0 And Hue < 60 Then
            OutColor = Color.FromArgb(255, (C + m) * 255, (X + m) * 255, m * 255)
        ElseIf Hue >= 60 And Hue < 120 Then
            OutColor = Color.FromArgb(255, (X + m) * 255, (C + m) * 255, m * 255)
        ElseIf Hue >= 120 And Hue < 180 Then
            OutColor = Color.FromArgb(255, m * 255, (C + m) * 255, (X + m) * 255)
        ElseIf Hue >= 180 And Hue < 240 Then
            OutColor = Color.FromArgb(255, m * 255, (X + m) * 255, (C + m) * 255)
        ElseIf Hue >= 240 And Hue < 300 Then
            OutColor = Color.FromArgb(255, (X + m) * 255, m * 255, (C + m) * 255)
        ElseIf Hue >= 300 And Hue < 360 Then
            OutColor = Color.FromArgb(255, (C + m) * 255, m * 255, (X + m) * 255)
        End If

        Return OutColor
    End Function

    Dim Elements As New List(Of String)
    Dim ElementsColors As New List(Of Color)
    Dim ElementsData As New List(Of List(Of PointF))

    Dim FetchingData As Boolean = False

    Sub RefreshElementList()
        ElementList.Items.Clear()
        For Each E As String In Elements
            ElementList.Items.Add(E)
        Next
    End Sub

    Sub RefreshElementDataList()
        ElementDataList.Items.Clear()
        If ElementList.SelectedIndex <> -1 Then
            For Each Edata As PointF In ElementsData.Item(ElementList.SelectedIndex)
                ElementDataList.Items.Add("X: " + CStr(Edata.X) + "; Y: " + CStr(Edata.Y))
            Next
        End If
    End Sub

    Sub RefreshElementDataListItemName()
        Dim Edata As PointF = ElementsData(ElementList.SelectedIndex)(ElementDataList.SelectedIndex)
        ElementDataList.Items(ElementDataList.SelectedIndex) = "X: " + CStr(Edata.X) + "; Y: " + CStr(Edata.Y)
    End Sub

    Sub AddElement(Name As String, Col As Color)
        Elements.Add(Name)
        ElementsColors.Add(Col)
        ElementsData.Add(New List(Of PointF))
    End Sub

    Sub DeleteElement(Index As Integer)
        Elements.RemoveAt(Index)
        ElementsColors.RemoveAt(Index)
        ElementsData.RemoveAt(Index)
    End Sub

    Private Sub NewElement_Click(sender As Object, e As EventArgs) Handles NewElement.Click
        AddElement("New Element", HSV_ColorConvert(50 * Elements.Count, 1.0F, 1.0F))
        RefreshElementList()
    End Sub

    Private Sub DestroyElement_Click(sender As Object, e As EventArgs) Handles DestroyElement.Click
        If ElementList.SelectedIndex <> -1 Then
            DeleteElement(ElementList.SelectedIndex)
            ElementDataList.Items.Clear()
            RefreshElementList()
        End If
    End Sub

    Private Sub ElementColor_Click(sender As Object, e As EventArgs) Handles ElementColor.Click
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            ElementColor.BackColor = ColorDialog1.Color
            If ElementList.SelectedIndex <> -1 Then
                ElementsColors(ElementList.SelectedIndex) = ColorDialog1.Color
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If ElementList.SelectedIndex <> -1 Then
            Elements(ElementList.SelectedIndex) = TextBox1.Text
            ElementList.Items(ElementList.SelectedIndex) = TextBox1.Text
        End If
    End Sub

    Private Sub NewElementPoint_Click(sender As Object, e As EventArgs)
        If ElementList.SelectedIndex <> -1 Then
            ElementsData(ElementList.SelectedIndex).Add(New PointF(0.0F, 0.0F))
            RefreshElementDataList()
        End If
    End Sub

    Private Sub DecimalPlacesMax_ValueChanged(sender As Object, e As EventArgs) Handles DecimalPlacesMax.ValueChanged
        SelDataX.DecimalPlaces = DecimalPlacesMax.Value
        SelDataY.DecimalPlaces = DecimalPlacesMax.Value
    End Sub

    Private Sub DestroyElementPoint_Click(sender As Object, e As EventArgs)
        If ElementList.SelectedIndex <> -1 And ElementDataList.SelectedIndex <> -1 Then
            ElementsData(ElementList.SelectedIndex).RemoveAt(ElementDataList.SelectedIndex)
        End If
        RefreshElementDataList()
    End Sub

    Private Sub ElementList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ElementList.SelectedIndexChanged
        If ElementList.SelectedIndex <> -1 Then
            ElementColor.BackColor = ElementsColors(ElementList.SelectedIndex)
            TextBox1.Text = Elements(ElementList.SelectedIndex)
            RefreshElementDataList()
        End If
    End Sub

    Private Sub ExtLoadElementData_Click(sender As Object, e As EventArgs) Handles ExtLoadElementData.Click
        If ElementList.SelectedIndex <> -1 Then
            ElementsData(ElementList.SelectedIndex).Clear()
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim Reader As StreamReader = My.Computer.FileSystem.OpenTextFileReader(OpenFileDialog1.FileName)

                While Reader.Peek() <> -1
                    Dim X As Single = 0.0F
                    Dim Y As Single = 0.0F
                    Dim StrLine As String = Reader.ReadLine()
                    Dim SC As Integer = -1
                    For i = 0 To StrLine.Length - 1 ' Check for semicolon
                        If StrLine(i) = ";"c Then
                            SC = i
                        End If
                    Next
                    If SC <> -1 Then
                        Dim StrX As String = StrLine.Remove(SC, StrLine.Length - SC)
                        Dim StrY As String = StrLine.Remove(0, SC + 1)
                        X = CSng(StrX)
                        Y = CSng(StrY)
                    Else
                        X = CSng(StrLine)
                    End If

                    ElementsData(ElementList.SelectedIndex).Add(New PointF(X, Y))
                End While

                Reader.Close()

                RefreshElementDataList()
            End If
        End If
    End Sub

    Private Sub ElementDataList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ElementDataList.SelectedIndexChanged
        FetchingData = True
        If ElementDataList.SelectedIndex <> -1 Then
            SelDataX.Value = ElementsData(ElementList.SelectedIndex)(ElementDataList.SelectedIndex).X
            SelDataY.Value = ElementsData(ElementList.SelectedIndex)(ElementDataList.SelectedIndex).Y
        End If
        FetchingData = False
    End Sub

    Private Sub ExtSaveElementData_Click(sender As Object, e As EventArgs) Handles ExtSaveElementData.Click
        If ElementList.SelectedIndex <> -1 Then
            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim Writer As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(SaveFileDialog1.FileName, False)

                For Each Edata In ElementsData(ElementList.SelectedIndex)
                    Writer.WriteLine(CStr(Edata.X) + ";" + CStr(Edata.Y))
                Next

                Writer.Close()
            End If
        End If
    End Sub

    Private Sub SelData_ValueChanged(sender As Object, e As EventArgs) Handles SelDataX.ValueChanged, SelDataY.ValueChanged
        If ElementList.SelectedIndex <> -1 And ElementDataList.SelectedIndex <> -1 And FetchingData = False Then
            ElementsData(ElementList.SelectedIndex)(ElementDataList.SelectedIndex) = New PointF(SelDataX.Value, SelDataY.Value)
            RefreshElementDataListItemName()
        End If
    End Sub

    Private Sub RenderButton_Click(sender As Object, e As EventArgs) Handles RenderButton.Click
        If SaveFileDialog2.ShowDialog() = DialogResult.OK Then
            If GraphType.SelectedIndex = 0 Then
                Dim Xmax As Single = Single.NegativeInfinity
                For i = 0 To Elements.Count - 1
                    Dim Cmax As Single = 0
                    For j = 0 To ElementsData(i).Count - 1
                        Cmax += ElementsData(i)(j).X
                    Next
                    If Xmax < Cmax Then
                        Xmax = Cmax
                    End If
                Next
                Dim Xscale = Xmax / OutResY.Value

                Dim OutRender As New Bitmap(CInt(OutResX.Value), CInt(OutResY.Value))
                Dim g As Graphics
                g = Graphics.FromImage(OutRender)
                g.Clear(Color.White)

                If CheckBox1.Checked = True Then
                    Dim Counter As Single = StepX.Value
                    While Xmax > Counter
                        g.DrawLine(New Pen(Color.Gray, 1.0F), New PointF(0, OutResY.Value - Counter / Xscale), New PointF(OutResX.Value, OutResY.Value - Counter / Xscale))
                        Counter += StepX.Value
                    End While
                End If

                Dim TowerXSize = (OutResX.Value - (Spacing.Value * (Elements.Count + 1))) / Elements.Count
                For i = 0 To Elements.Count - 1
                    Dim TowerValue As Single = 0
                    For j = 0 To ElementsData(i).Count - 1
                        TowerValue += ElementsData(i)(j).X
                    Next
                    If i = 0 Then
                        g.FillRectangle(New SolidBrush(ElementsColors(i)), Spacing.Value, OutResY.Value - TowerValue / Xscale, TowerXSize, TowerValue / Xscale)
                    Else
                        g.FillRectangle(New SolidBrush(ElementsColors(i)), Spacing.Value + TowerXSize * i + Spacing.Value * i, OutResY.Value - TowerValue / Xscale, TowerXSize, TowerValue / Xscale)
                    End If
                Next

                OutRender.Save(SaveFileDialog2.FileName)
            ElseIf GraphType.SelectedIndex = 1 Then
                Dim Xmax As Single = Single.NegativeInfinity
                For i = 0 To ElementsData(0).Count - 1
                    Dim Tmax = ElementsData(0)(i).X
                    If Xmax < Tmax Then
                        Xmax = Tmax
                    End If
                Next
                Dim Xscale = Xmax / OutResY.Value

                Dim OutRender As New Bitmap(CInt(OutResX.Value), CInt(OutResY.Value))
                Dim g As Graphics
                g = Graphics.FromImage(OutRender)
                g.Clear(Color.White)

                If CheckBox1.Checked = True Then
                    Dim Counter As Single = StepX.Value
                    While Xmax > Counter
                        g.DrawLine(New Pen(Color.Gray, 1.0F), New PointF(0, OutResY.Value - Counter / Xscale), New PointF(OutResX.Value, OutResY.Value - Counter / Xscale))
                        Counter += StepX.Value
                    End While
                End If

                Dim TowerXSize = (OutResX.Value - (Spacing.Value * (ElementsData(0).Count + 1))) / ElementsData(0).Count
                For i = 0 To ElementsData(0).Count - 1
                    Dim TowerValue As Single = ElementsData(0)(i).X
                    If i = 0 Then
                        g.FillRectangle(New SolidBrush(ElementsColors(0)), Spacing.Value, OutResY.Value - TowerValue / Xscale, TowerXSize, TowerValue / Xscale)
                    Else
                        g.FillRectangle(New SolidBrush(ElementsColors(0)), Spacing.Value + TowerXSize * i + Spacing.Value * i, OutResY.Value - TowerValue / Xscale, TowerXSize, TowerValue / Xscale)
                    End If
                Next

                OutRender.Save(SaveFileDialog2.FileName)
            ElseIf GraphType.SelectedIndex = 2 Then
                Dim Xmin As Single = Single.PositiveInfinity
                Dim Xmax As Single = Single.NegativeInfinity
                Dim Ymin As Single = Single.PositiveInfinity
                Dim Ymax As Single = Single.NegativeInfinity
                For i = 0 To Elements.Count - 1
                    For j = 0 To ElementsData(i).Count - 1
                        If ElementsData(i)(j).X < Xmin Then
                            Xmin = ElementsData(i)(j).X
                        End If
                        If ElementsData(i)(j).X > Xmax Then
                            Xmax = ElementsData(i)(j).X
                        End If
                        If ElementsData(i)(j).Y < Ymin Then
                            Ymin = ElementsData(i)(j).Y
                        End If
                        If ElementsData(i)(j).Y > Ymax Then
                            Ymax = ElementsData(i)(j).Y
                        End If
                    Next
                Next
                Dim Xrange = Xmax - Xmin
                Dim Yrange = Ymax - Ymin
                Dim Xscale = Xrange / OutResX.Value
                Dim Yscale = Yrange / OutResY.Value

                Dim OutRender As New Bitmap(CInt(OutResX.Value), CInt(OutResY.Value))
                Dim g As Graphics
                g = Graphics.FromImage(OutRender)
                g.Clear(Color.White)

                If CheckBox1.Checked = True Then
                    Dim Counter As Single = Xmin + StepX.Value - (Xmin Mod StepX.Value)
                    While Xmax > Counter
                        g.DrawLine(New Pen(Color.Gray, 1.0F), New PointF((Counter - Xmin) / Xscale, 0), New PointF((Counter - Xmin) / Xscale, OutResY.Value))
                        Counter += StepX.Value
                    End While
                    Counter = Ymin + StepY.Value - (Ymin Mod StepY.Value)
                    While Ymax > Counter
                        g.DrawLine(New Pen(Color.Gray, 1.0F), New PointF(0, OutResY.Value - (Counter - Ymin) / Yscale), New PointF(OutResX.Value, OutResY.Value - (Counter - Ymin) / Yscale))
                        Counter += StepY.Value
                    End While
                End If

                For i = 0 To Elements.Count - 1
                    For j = 0 To ElementsData(i).Count - 2
                        g.DrawLine(New Pen(ElementsColors(i), LineWidth.Value), (ElementsData(i)(j).X - Xmin) / Xscale, OutResY.Value - (ElementsData(i)(j).Y - Ymin) / Yscale, (ElementsData(i)(j + 1).X - Xmin) / Xscale, OutResY.Value - (ElementsData(i)(j + 1).Y - Ymin) / Yscale)
                    Next
                Next

                OutRender.Save(SaveFileDialog2.FileName)
            End If
        End If
    End Sub

    Function ListValues(Data As String) As List(Of Single)
        Dim SC As New List(Of Integer)
        Dim Out As New List(Of Single)
        For i = 0 To Data.Length - 1 ' Check for semicolons
            If Data(i) = ";"c Then
                SC.Add(i)
            End If
        Next
        Dim StrX As String = Data.Remove(SC(0), Data.Length - SC(0))
        For i = 0 To SC.Count
            Out.Add(CSng(StrX))
            If i >= SC.Count - 1 Then
                StrX = Data.Substring(SC(SC.Count - 1) + 1, Data.Length - SC(SC.Count - 1) - 1)
            Else
                StrX = Data.Substring(SC(i) + 1, SC(i + 1) - SC(i) - 1)
            End If
        Next
        Return Out
    End Function

    Private Sub CustomFormater(sender As Object, e As EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim OutFileName1 = OpenFileDialog1.FileName.Substring(0, OpenFileDialog1.FileName.Length - 4) + "_reformated_mp.txt"
            Dim OutFileName2 = OpenFileDialog1.FileName.Substring(0, OpenFileDialog1.FileName.Length - 4) + "_reformated_90t.txt"
            Dim OutFileName3 = OpenFileDialog1.FileName.Substring(0, OpenFileDialog1.FileName.Length - 4) + "_reformated_60r.txt"
            Dim OutFileName4 = OpenFileDialog1.FileName.Substring(0, OpenFileDialog1.FileName.Length - 4) + "_reformated_120r.txt"
            Dim OutFileName5 = OpenFileDialog1.FileName.Substring(0, OpenFileDialog1.FileName.Length - 4) + "_reformated_rp.txt"
            Dim OutFileName6_1 = OpenFileDialog1.FileName.Substring(0, OpenFileDialog1.FileName.Length - 4) + "_reformated_60ra.txt"
            Dim OutFileName6_2 = OpenFileDialog1.FileName.Substring(0, OpenFileDialog1.FileName.Length - 4) + "_reformated_90ra.txt"
            Dim OutFileName6_3 = OpenFileDialog1.FileName.Substring(0, OpenFileDialog1.FileName.Length - 4) + "_reformated_120ra.txt"

            Dim Reader As StreamReader

            ' First reformating: monster probability graph

            Reader = My.Computer.FileSystem.OpenTextFileReader(OpenFileDialog1.FileName)

            Dim Writer1 As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(OutFileName1, False)
            Dim Writer2 As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(OutFileName2, False)
            Dim Writer3 As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(OutFileName3, False)
            Dim Writer4 As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(OutFileName4, False)
            Dim Writer5 As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(OutFileName5, False)
            Dim Writer6_1 As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(OutFileName6_1, False)
            Dim Writer6_2 As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(OutFileName6_2, False)
            Dim Writer6_3 As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(OutFileName6_3, False)

            Dim A60_n = 0
            Dim A90_n = 0
            Dim A120_n = 0

            For i = 1 To 1000
                Dim LineData = ListValues(Reader.ReadLine())

                A60_n += LineData(2)
                A90_n += LineData(3)
                A120_n += LineData(4)
            Next

            Writer1.WriteLine(A60_n)
            Writer1.WriteLine(A90_n)
            Writer1.WriteLine(A120_n)

            Writer1.Close()
            Reader.Close()

            ' Second reformating: A-90 standalone vs followup

            Reader = My.Computer.FileSystem.OpenTextFileReader(OpenFileDialog1.FileName)

            Dim A90_s = 0
            Dim A90_f60 = 0
            Dim A90_f120 = 0

            For i = 1 To 1000
                Dim LineData = ListValues(Reader.ReadLine())

                If LineData(3) > 0 Then
                    If LineData(2) = 1 And LineData(4) = 0 Then
                        A90_f60 += 1
                    ElseIf LineData(2) = 0 And LineData(4) = 1 Then
                        A90_f120 += 1
                    Else
                        A90_s += 1
                    End If
                End If
            Next

            Writer2.WriteLine(A90_s)
            Writer2.WriteLine(A90_f60)
            Writer2.WriteLine(A90_f120)

            Writer2.Close()
            Reader.Close()

            ' Third reformating: A-60 spawn rooms

            Reader = My.Computer.FileSystem.OpenTextFileReader(OpenFileDialog1.FileName)

            Dim A60_r(12) As Integer

            For i = 1 To 999
                Dim LineData = ListValues(Reader.ReadLine())

                If LineData(2) = 1 Then
                    A60_r(LineData(1) - 1) += 1
                End If
            Next

            For i = 1 To 13
                Writer3.WriteLine(A60_r(i - 1))
            Next

            Writer3.Close()
            Reader.Close()

            ' Fourth reformating: A-120 spawn rooms

            Reader = My.Computer.FileSystem.OpenTextFileReader(OpenFileDialog1.FileName)

            Dim A120_r(12) As Integer
            Dim A120_firstlinedata = ListValues(Reader.ReadLine())
            Dim A120_proom = A120_firstlinedata(1)

            For i = 2 To 1000
                Dim LineData = ListValues(Reader.ReadLine())
                If LineData(4) = 1 Then
                    A120_r(A120_proom - 1) += 1
                End If
                A120_proom = LineData(1)
            Next

            For i = 1 To 13
                Writer4.WriteLine(A120_r(i - 1))
            Next

            Writer4.Close()
            Reader.Close()

            ' Fifth reformating: Room probability

            Reader = My.Computer.FileSystem.OpenTextFileReader(OpenFileDialog1.FileName)

            Dim Room_n(12) As Integer

            For i = 1 To 999
                Dim LineData = ListValues(Reader.ReadLine())
                Room_n(LineData(1) - 1) += 1
            Next

            For i = 1 To 13
                Writer5.WriteLine(Room_n(i - 1))
            Next

            Writer5.Close()
            Reader.Close()

            ' Sixth reformating: The barcode looking graph

            Reader = My.Computer.FileSystem.OpenTextFileReader(OpenFileDialog1.FileName)

            For i = 1 To 1000
                Dim LineData = ListValues(Reader.ReadLine())
                Writer6_1.WriteLine(LineData(2))
                Writer6_2.WriteLine(LineData(3))
                Writer6_3.WriteLine(LineData(4))
            Next

            Writer6_1.Close()
            Writer6_2.Close()
            Writer6_3.Close()
            Reader.Close()

            MsgBox("Reformating done!", MsgBoxStyle.Information)

            Reader.Close()
        End If
    End Sub
End Class
