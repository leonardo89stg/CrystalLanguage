Public Class Form1
    Dim varInt As String
    


    Dim varDBL As Double
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End

    End Sub

    Private Sub DebugToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DebugToolStripMenuItem.Click
        For Each script As String In RichTextBox1.Text.Split(System.Environment.NewLine())





            If (script.Contains("print:")) Then
                Console.Write(script.Substring(6))
                Console.Write(vbNewLine)




            End If

            If (script.Contains("input")) Then

                    InputBox(script.Substring(5), "")



                End If


                If (script.Contains("-v")) Then

                    Console.WriteLine("Crystal Language CLEngine using NetFramework", vbNewLine)

                    Console.WriteLine(My.Application.Info.Version)









                End If

                If (script.Contains(";")) Then

                    Console.WriteLine(vbNewLine)











                End If







            Next

    End Sub
End Class

