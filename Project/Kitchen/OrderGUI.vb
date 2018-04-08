Imports System.Net.Sockets
Imports System.Text

Public Class OrderGUI
    Dim clientSocket As New System.Net.Sockets.TcpClient()
    Dim serverStream As NetworkStream
    Dim orderNum As Integer

    Private Sub OrderGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        orderNum = 1
        lblOrderNum.Text = "# "
        clientSocket.Connect("127.0.0.1", 8888)

    End Sub

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        Dim serverStream As NetworkStream = clientSocket.GetStream()
        Dim outStream As Byte() = System.Text.Encoding.ASCII.GetBytes("Message from Client$")

        serverStream.Write(outStream, 0, outStream.Length)
        serverStream.Flush()

        Dim inStream(10024) As Byte
        serverStream.Read(inStream, 0, CInt(clientSocket.ReceiveBufferSize))
        Dim returndata As String = System.Text.Encoding.ASCII.GetString(inStream)
        MsgBox("Data from Server : " + returndata)
    End Sub
End Class
