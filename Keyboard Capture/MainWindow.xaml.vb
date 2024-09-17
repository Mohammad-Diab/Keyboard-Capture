Class MainWindow 

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        nn.Items.Clear()
    End Sub

    Private Sub Window_PreviewKeyDown(sender As Object, e As KeyEventArgs)
        nn.Items.Insert(0, e.Key.ToString())
    End Sub

    Private Sub Button1_Click(sender As Object, e As RoutedEventArgs)
        Dim d As about = New about()
        d.ShowDialog()
    End Sub

    Private Sub Window_PreviewKeyUp_1(sender As Object, e As KeyEventArgs)

    End Sub
End Class
