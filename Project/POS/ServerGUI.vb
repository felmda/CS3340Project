Imports System.Net.Sockets
Imports System.Text

Public Class ServerGUI
    Private Sub ServerGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub Main()
        Dim serverSocket As New TcpListener(8888)
        Dim requestCount As Integer
        Dim clientSocket As TcpClient
        serverSocket.Start()
        clientSocket = serverSocket.AcceptTcpClient()
        requestCount = 0

        While (True)
            Try
                requestCount = requestCount + 1
                Dim networkStream As NetworkStream = clientSocket.GetStream()
                Dim bytesFrom(10024) As Byte

                networkStream.Read(bytesFrom, 0, CInt(clientSocket.ReceiveBufferSize))

                Dim dataFromClient As String = System.Text.Encoding.ASCII.GetString(bytesFrom)
                dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"))

                Dim serverResponse As String = "Server response " + Convert.ToString(requestCount)

                Dim sendBytes As [Byte]() = Encoding.ASCII.GetBytes(serverResponse)
                networkStream.Write(sendBytes, 0, sendBytes.Length)
                networkStream.Flush()

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End While


        clientSocket.Close()
        serverSocket.Stop()

    End Sub

End Class