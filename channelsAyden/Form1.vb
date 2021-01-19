Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPrice.Click
        Dim sngPrice As Single = 5
        Const NATURE As Single = 2
        Const LIFE As Single = 2.5
        Const NEWS As Single = 3


        If (chkAnimal.Checked = True) Or (chkDiscovery.Checked = True) Then
            sngPrice = sngPrice + NATURE
        End If
        If (chkFood.Checked = True) Or (chkHGTV.Checked = True) Then
            sngPrice = sngPrice + LIFE
        End If
        If (chkCNN.Checked = True) Or (chkMSNBC.Checked = True) Then
            sngPrice = sngPrice + NEWS
        End If


        If (chkAnimal.Checked = True Or chkDiscovery.Checked = True) And (chkFood.Checked = True Or chkHGTV.Checked = True) And (chkCNN.Checked = True Or chkMSNBC.Checked = True) Then
            sngPrice = 12
        End If

        lblPrice.Text = ("Monthly Price: $") & sngPrice
    End Sub
End Class
