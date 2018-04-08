Imports System.Net.Sockets
Imports System.Text

Public Class OrderGUI
    Dim clientSocket As New System.Net.Sockets.TcpClient()
    Dim serverStream As NetworkStream
    Dim orderNum As Integer
    Dim orderTable As DataTable

    Private Sub OrderGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        orderTable = New DataTable("Orders")

        orderTable.Columns.Add("Item", GetType(System.String))
        orderTable.Columns.Add("Price", GetType(System.String))

        tblOrder.DataSource = orderTable
        tblOrder.ClearSelection()

        tblOrder.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        orderNum = 1
        lblOrderNum.Text = "# " + Format(orderNum, "0000")
        'clientSocket.Connect("127.0.0.1", 8888)

        UpdatePrice()
    End Sub

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnSendOrder.Click
        Dim serverStream As NetworkStream = clientSocket.GetStream()
        Dim outStream As Byte() = System.Text.Encoding.ASCII.GetBytes("Message from Client$")

        serverStream.Write(outStream, 0, outStream.Length)
        serverStream.Flush()

        Dim inStream(10024) As Byte
        serverStream.Read(inStream, 0, CInt(clientSocket.ReceiveBufferSize))
        Dim returndata As String = System.Text.Encoding.ASCII.GetString(inStream)
        MsgBox("Data from Server : " + returndata)
    End Sub

    Private Sub btnBBQ_Click(sender As Object, e As EventArgs) Handles btnBBQ.Click
        AddTableItem(btnBBQ.Text, btnBBQ.Tag)
    End Sub

    ''' <summary>
    ''' Adds a row to the order table with given item and price
    ''' Converts price into dollar currency format
    ''' </summary>
    ''' <param name="item"></param>
    ''' <param name="price"></param>
    Private Sub AddTableItem(item As String, price As String)
        orderTable.Rows.Add(item, FormatCurrency(price, 2))
        If orderTable.Rows.Count = 1 Then
            tblOrder.ClearSelection()
        End If
        UpdatePrice()
    End Sub

    ''' <summary>
    ''' Update subtotal, tax, and total price of the order
    ''' Call whenever a new item is added or removed
    ''' </summary>
    Private Sub UpdatePrice()
        If orderTable.Rows.Count > 0 Then
            Dim subTotal As Double = 0
            Dim tax As Double
            Dim total As Double
            Dim currPrice As String

            For Each row In orderTable.Rows
                currPrice = row(1)

                subTotal += Decimal.Parse(currPrice, Globalization.NumberStyles.Currency)
            Next

            tax = subTotal * 0.055
            total = subTotal + tax

            lblSubTotalMoney.Text = subTotal.ToString("C")
            lblTaxMoney.Text = tax.ToString("C")
            lblTotalMoney.Text = total.ToString("C")
        Else
            lblSubTotalMoney.Text = FormatCurrency(0, 2)
            lblTaxMoney.Text = FormatCurrency(0, 2)
            lblTotalMoney.Text = FormatCurrency(0, 2)
        End If
    End Sub

    Private Sub btnPP_Click(sender As Object, e As EventArgs) Handles btnPP.Click
        AddTableItem(btnPP.Text, btnPP.Tag)
    End Sub

    Private Sub btnMushSwiss_Click(sender As Object, e As EventArgs) Handles btnMushSwiss.Click
        AddTableItem(btnMushSwiss.Text, btnMushSwiss.Tag)
    End Sub

    Private Sub btnMong_Click(sender As Object, e As EventArgs) Handles btnMong.Click
        AddTableItem(btnMong.Text, btnMong.Tag)
    End Sub

    Private Sub btnBcnBurger_Click(sender As Object, e As EventArgs) Handles btnBcnBurger.Click
        AddTableItem(btnBcnBurger.Text, btnBcnBurger.Tag)
    End Sub

    Private Sub btnOld_Click(sender As Object, e As EventArgs) Handles btnOld.Click
        AddTableItem(btnOld.Text, btnOld.Tag)
    End Sub

    Private Sub btnBurger_Click(sender As Object, e As EventArgs) Handles btnBurger.Click
        AddTableItem(btnBurger.Text, btnBurger.Tag)
    End Sub

    Private Sub btnCknBurger_Click(sender As Object, e As EventArgs) Handles btnCknBurger.Click
        AddTableItem(btnCknBurger.Text, btnCknBurger.Tag)
    End Sub

    Private Sub btnVoid_Click(sender As Object, e As EventArgs) Handles btnVoid.Click
        If tblOrder.SelectedRows.Count > 0 Then
            orderTable.Rows.RemoveAt(tblOrder.CurrentCell.RowIndex)
            UpdatePrice()
        End If

    End Sub

    Private Sub btnBft_Click(sender As Object, e As EventArgs) Handles btnBft.Click
        AddTableItem(btnBft.Text, btnBft.Tag)
    End Sub

    Private Sub btnBfBr_Click(sender As Object, e As EventArgs) Handles btnBfBr.Click
        AddTableItem(btnBfBr.Text, btnBfBr.Tag)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        orderTable.Clear()
        UpdatePrice()
    End Sub
End Class
