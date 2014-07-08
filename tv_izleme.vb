Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AxWindowsMediaPlayer1.URL = " rtsp://yayin3.canliyayin.org/actsistem"

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AxWindowsMediaPlayer1.URL = "mms://yayin.networkbil.com/kanalm "

    End Sub

   
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AxWindowsMediaPlayer1.URL = "  rtmp://yayin.canlitv.com/live/startv"

    End Sub
    
End Class
