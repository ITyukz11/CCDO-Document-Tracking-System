Public Class MaintainScrollPosition
    Private Shared vposition As Integer

    Private Shared hposition As Integer



    Shared Sub GetvSBarPos(ByVal dg As DataGridView)

        vposition = dg.FirstDisplayedScrollingRowIndex

    End Sub



    Shared Sub SetvSBarPos(ByVal dg As DataGridView)

        dg.FirstDisplayedScrollingRowIndex() = vposition

    End Sub



    Shared Sub GethSBarPos(ByVal dg As DataGridView)

        hposition = dg.FirstDisplayedScrollingColumnIndex

    End Sub



    Shared Sub SethSBarPos(ByVal dg As DataGridView)

        dg.FirstDisplayedScrollingColumnIndex = hposition

    End Sub
End Class
