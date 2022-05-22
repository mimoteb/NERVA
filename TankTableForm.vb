Public Class TankTableForm
    Private Sub Wn8ExpectedValuesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        cmd.CommandText = "select shortname,expDamage,expWinRate,expFrag,expSpot,expDef,class,tier,nation,premium from Tankopedia"
        Reader = cmd.ExecuteReader
        While Reader.Read
            If Reader.GetValue(0).ToString <> Nothing Then
                ExpectedValuesGrid.Rows.Add(Reader.GetValue(0).ToString, Reader.GetValue(1).ToString, Reader.GetValue(2).ToString, Reader.GetValue(3).ToString, Reader.GetValue(4).ToString, Reader.GetValue(5).ToString, Reader.GetValue(6).ToString, Reader.GetValue(7).ToString, Reader.GetValue(8).ToString, Reader.GetValue(9).ToString)
            End If
        End While
        Reader.Close()
    End Sub


End Class