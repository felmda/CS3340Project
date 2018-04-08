Public Class Order
    Private _orderID As Integer
    Private _orderTotal As Double
    Private _orderTitle As String
    Private _orderDelimit As String
    Private orderItems As List(Of String)

    Public Sub New(ByVal ID As Integer, ByVal Title As String)
        _orderID = ID
        _orderTitle = Title
        _orderTotal = 0.00
        _orderDelimit = ";"
    End Sub

    Public Sub AddItem(ByVal item As String, ByVal price As String)
        Dim temp As String = item & "/" & price
        Dim pr = CType(price, Double)
        _orderTotal += pr
        orderItems.Add(temp)
    End Sub

    Public Function CompileOrderString() As String
        Dim tempStr As String = ""
        For Each s As String In orderItems
            tempStr &= s & ","
        Next
        tempStr = tempStr.Remove(tempStr.Length - 1)
        Return _orderID & _orderDelimit & _orderTitle & _orderDelimit & tempStr & _orderDelimit & _orderTotal
    End Function

    Public Sub RemoveItem(ByVal index As Integer)
        orderItems.RemoveAt(index)
    End Sub
End Class
