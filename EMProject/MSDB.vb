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
    Public Sub DBConn()
        'DB연결
        scn = New SqlConnection
        scn.ConnectionString = "Data Source=" & strIP & ";Initial Catalog=" & strDB & ";Integrated Security=False;User ID=" & strID & ";Password=" & strPW
        scn.Open()
    End Sub
    Public Sub Select_All(table As String)
        'DB Insert부분
        DBConn()
        Dim query = "select * from " & table
        scm = New SqlCommand(query, scn)
        myReader = scm.ExecuteReader()
        myReader.Close()
        scn.Close()
        'Return 부분 생각
    End Sub
    Public Sub Update(table As String, u_set As String, u_where As String)
        'DB Update부분
        DBConn()
        Dim query = "Update " & table & " set " & u_set & " where " & u_where
        scm = New SqlCommand(query, scn)
        myReader = scm.ExecuteReader()
        myReader.Close()
        scn.Close()
    End Sub
    Public Sub Delete(table As String, u_where As String)
        'DB Delete부분
        DBConn()
        Dim query = "delete from " & table & " where " & u_where
        scn.Close()
    End Sub







    'Public Sub User_Insert(query As String)
    '    '새로운 User를 조회 해주는 함수
    '    DBConn()
    '    scm = New SqlCommand(query, scn)
    '    myReader = scm.ExecuteReader()
    '    Do While myReader.Read()
    '        results = results & myReader.GetString(0) & vbTab & myReader.GetString(1) & vbLf
    '    Loop
    '    MsgBox(results)
    '    myReader.Close()
    '    scn.Close()
    'End Sub
    'Public Sub DBInsert()
    '    scm = New SqlCommand(query, scn)
    '    myReader = scm.ExecuteReader()
    '    Do While myReader.Read()
    '        results = results & myReader.GetString(0) & vbTab & myReader.GetString(1) & vbLf
    '    Loop
    '    MsgBox(results)
    '    myReader.Close()
    '    scn.Close()
    'End Sub
    'Public Sub DBUpdate()
    '    scn = New SqlConnection
    '    scn.ConnectionString = "Data Source=" & strIP & ";Initial Catalog=" & strDB & ";Integrated Security=False;User ID=" & strID & ";Password=" & strPW
    '    scn.Open()
    '    query = "update [EMProject].[dbo].[User] set E_Number='0002' where E_Number='0001'"
    '    scm = New SqlCommand(query, scn)
    '    scm.ExecuteNonQuery()
    '    scn.Close()
    'End Sub

    'Public Sub DBDelete()
    '    scn = New SqlConnection
    '    scn.ConnectionString = "Data Source=" & strIP & ";Initial Catalog=" & strDB & ";Integrated Security=False;User ID=" & strID & ";Password=" & strPW
    '    scn.Open()
    '    query = "delete from [EMProject].[dbo].[User] where E_Number='0002'"
    '    scm = New SqlCommand(query, scn)
    '    scm.ExecuteNonQuery()
    '    scn.Close()
    'End Sub

    'Public Sub DBInsert()
    '    scn = New SqlConnection
    '    scn.ConnectionString = "Data Source=" & strIP & ";Initial Catalog=" & strDB & ";Integrated Security=False;User ID=" & strID & ";Password=" & strPW
    '    scn.Open()
    '    query = "insert into [EMProject].[dbo].[User](E_Number,E_Name,E_PW,E_Category) values('0002','master2','master2',2)"
    '    scm = New SqlCommand(query, scn)
    '    scm.ExecuteNonQuery()
    '    scn.Close()
    'End Sub
End Class
