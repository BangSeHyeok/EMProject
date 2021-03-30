Imports System.Data.SqlClient

Public Class MSDB
    Dim strIP As String = "192.168.43.40,1433"
    Dim strDB As String = "EMProject"
    Dim strID As String = "User1"
    Dim strPW As String = "1111"
    'DB정보
    Dim scn As SqlConnection
    'DB연결 설정
    Dim scm As SqlCommand
    'DB 쿼리 실행
    Dim myReader As SqlDataReader
   
    'DB 쿼리 결과를 검색
    Private Sub DBConn()
        'DB연결
        scn = New SqlConnection
        scn.ConnectionString = "Data Source=" & strIP & ";Initial Catalog=" & strDB & ";Integrated Security=False;User ID=" & strID & ";Password=" & strPW
        scn.Open()
    End Sub
    Function WorkTime_Count(table As String, u_where_number As String, u_where_time As String)
        DBConn()
        Dim query = "select Count(*) from " & table & " where E_Number=" & u_where_number & " And E_Date='" & u_where_time & "'"
        scm = New SqlCommand(query, scn)
        Dim count = scm.ExecuteScalar()
        ' MsgBox("count:" + count.ToString)
        If count = 1 Then
            query = "select * from " & table & " where E_Number=" & u_where_number & " And E_Date='" & u_where_time & "'"
            scm = New SqlCommand(query, scn)
            myReader = scm.ExecuteReader()
            Do While myReader.Read()
                If myReader.GetValue(3).ToString <> "" Then
                    myReader.Close()
                    Return 2
                End If
            Loop
            myReader.Close()
        End If
        scn.Close()
        Return count
    End Function
    Function WorkTime_Check(table As String, u_where_number As String, u_where_time As String)
        DBConn()
        Dim WorkTime_list As List(Of WorkTimeVO) = New List(Of WorkTimeVO)
        Dim query = "select * from " & table & " where E_Number=" & u_where_number & " And E_Date='" & u_where_time & "'"
        scm = New SqlCommand(query, scn)
        myReader = scm.ExecuteReader()
        Do While myReader.Read()
            MsgBox(myReader.GetValue(3).ToString)
            WorkTime_list.Add(New WorkTimeVO(myReader.GetValue(0), myReader.GetValue(1), myReader.GetValue(2), myReader.GetValue(3).ToString))
        Loop
        myReader.Close()
        scn.Close()
        Return WorkTime_list
    End Function
    Public Sub WorkTime_gtw(table As String, u_where_number As String, u_where_time As String)
        DBConn()
        Dim query = "insert into " & table & "(E_Number,E_Date,E_gtw) VALUES('" & u_where_number & "','" & DateTime.Now.ToString("yyyy-MM-dd") & "','" & u_where_time & "')"
        scm = New SqlCommand(query, scn)
        scm.ExecuteNonQuery()
        scn.Close()
    End Sub
    Public Sub WorkTime_gth(table As String, u_where_number As String, u_where_time As String)
        DBConn()
        Dim query = "update " & table & "set E_gtn='" & u_where_time & "' where E_Number=" & u_where_number & " And E_Date='" & DateTime.Now.ToString("yyyy-MM-dd") & "'"
        MsgBox(query)
        scm = New SqlCommand(query, scn)
        scm.ExecuteNonQuery()
        scn.Close()
    End Sub
    Function Information_User(table As String, u_where As String)
        Dim Information_list As List(Of InformationVO) = New List(Of InformationVO)
        DBConn()
        Dim query = "select * from " & table & " where E_Number= " & u_where.Trim
        scm = New SqlCommand(query, scn)
        myReader = scm.ExecuteReader()
        Do While myReader.Read()
            Information_list.Add(New InformationVO(myReader.GetString(0), myReader.GetString(1), myReader.GetInt32(2), myReader.GetString(3), myReader.GetString(4)))
        Loop
        myReader.Close()
        scn.Close()
        Return Information_list
    End Function

    Public Sub Update(table As String, u_set As String, u_where As String)
        'DB Update부분
        DBConn()
        Dim query = "Update " & table & " set " & u_set & "' where " & u_where
        MessageBox.Show(query)
        scm = New SqlCommand(query, scn)
        scm.ExecuteNonQuery()
        scn.Close()
    End Sub
    Public Sub Delete(table As String, u_where As String)
        'DB Delete부분
        DBConn()
        Dim query = "delete from " & table & " where " & u_where
        scn.Close()
    End Sub

    Function User_All(table As String)
        Dim User_list As List(Of UserVO) = New List(Of UserVO)
        DBConn()
        Dim query = "select * from " & table
        scm = New SqlCommand(query, scn)
        myReader = scm.ExecuteReader

        Do While myReader.Read()
            User_list.Add(New UserVO(myReader.GetString(0), myReader.GetString(1), myReader.GetString(2), myReader.GetInt32(3)))
        Loop

        myReader.Close()
        scn.Close()

        Return User_list
    End Function
    Function workTime_total(table As String, u_where As String)

        '현재 月 출력
        Dim Tmonth As String = DateTime.Now.ToString("yyyy-MM")
        Dim WorkTime_list As List(Of WorkTimeVO) = New List(Of WorkTimeVO)

        DBConn()
        Dim query = "select * from " & table & " where E_Number = " & u_where & "and Left(E_date,7) = '" & Tmonth & "'"
        scm = New SqlCommand(query, scn)
        myReader = scm.ExecuteReader

        Do While myReader.Read()
            WorkTime_list.Add(New WorkTimeVO(myReader.GetString(0), myReader.GetDateTime(1), myReader.GetDateTime(2), myReader.GetDateTime(3)))
        Loop

        myReader.Close()
        scn.Close()

        Return WorkTime_list

    End Function

End Class
