Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Public Class Form1
    'Dim read As New MySqlDataReader
    Dim query As String
    Dim command As New MySqlCommand
    Dim cmd As New SqlCommand
    Dim sqlconn As New SqlConnection
    Dim bs As New BindingSource

    
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentsDataSet.StudentsInfo' table. You can move, or remove it, as needed.
        Me.StudentsInfoTableAdapter.Fill(Me.StudentsDataSet.StudentsInfo)
        Dim da As Integer
        Dim _Hitung As Integer
        'Dim _urutan As Integer
        'Dim rd As String

        '_Hitung = Microsoft.VisualBasic.Right(rd.GetString(0), 5) + 1 'BUAT PLUSNYA
        '_Urutan = "B" & Microsoft.VisualBasic.Right("000" & _Hitung, 7) 'HITUNG
        da = Today.Year 'tahun ini
        TextBox1.Text = CStr(da) + "1" + "000001"
        _Hitung = Microsoft.VisualBasic.Right(da, 2)
        Label1.Text = _Hitung & 1 & "00001"
    End Sub

    Sub insert()


        query = "INSERT INTO NAMATABEL (COLOM1,COLOM2,COLOM3) (ISICOLOM , ISI COLOM)"
    End Sub
    
    Sub delete()

    End Sub

    Private Sub Button2_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseHover

    End Sub

    Private Sub ToolTip1_Popup(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PopupEventArgs) Handles ToolTip1.Popup

    End Sub
    Sub tampil()
        'Dim sda As New MySqlDataAdapter
        'Dim dbdataset As New DataTable
        'Dim bsource As New BindingSource
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        inputdata.Show()
    End Sub
End Class
