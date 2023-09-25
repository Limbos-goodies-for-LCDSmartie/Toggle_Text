

Imports System.Text

Public Class LCDSmartie
    Dim StartT1 As Long
    Dim OldSecs1 As Long
    Dim Secs1 As Long
    Dim OUT1 As String, Retrn1 As String

    Dim StartT2 As Long
    Dim OldSecs2 As Long
    Dim Secs2 As Long
    Dim OUT2 As String, Retrn2 As String

    Dim StartT3 As Long
    Dim OldSecs3 As Long
    Dim Secs3 As Long
    Dim OUT3 As String, Retrn3 As String

    Dim StartT4 As Long
    Dim OldSecs4 As Long
    Dim Secs4 As Long
    Dim OUT4 As String, Retrn4 As String

    Dim StartT5 As Long
    Dim OldSecs5 As Long
    Dim Secs5 As Long
    Dim OUT5 As String, Retrn5 As String

    Dim StartT6 As Long
    Dim OldSecs6 As Long
    Dim Secs6 As Long
    Dim OUT6 As String, Retrn6 As String

    Dim StartT7 As Long
    Dim OldSecs7 As Long
    Dim Secs7 As Long
    Dim OUT7 As String, Retrn7 As String

    Dim StartT8 As Long
    Dim OldSecs8 As Long
    Dim Secs8 As Long
    Dim OUT8 As String, Retrn8 As String

    Dim StartT9 As Long
    Dim OldSecs9 As Long
    Dim Secs9 As Long
    Dim OUT9 As String, Retrn9 As String

    Dim StartT10 As Long
    Dim OldSecs10 As Long
    Dim Secs10 As Long
    Dim OUT10 As String, Retrn10 As String



    Public Function function1(ByVal param1 As String, ByVal param2 As String) As String
        On Error GoTo Err1
        If param1 = "about" Or param2 = "about" Then
            Return " toggles between param1 and param2 every 1 sec"

        Else
            If Secs1 > OldSecs1 Then
                OldSecs1 = Secs1 + 1
            End If

            Dim NowT = Int(Timer)

            If OUT1 = "1" Then
                Retrn1 = param1
            Else
                Retrn1 = param2
            End If


            If OldSecs1 = Secs1 Then
                OldSecs1 = Secs1 + 1
                If OUT1 = "1" Then
                    OUT1 = "2"
                    Retrn1 = param1
                Else
                    OUT1 = "1"
                    Retrn1 = param2
                End If
            End If
            Secs1 = Int(NowT) - Int(StartT1)


            Return Retrn1 'Return(Secs & " " & Retrn & " " & OldSecs)        ' "NT=" & NowT & " ST=" & StartT

        End If
Err1:
        Return Err.Description
    End Function
    Public Function function2(ByVal param1 As String, ByVal param2 As String) As String
        On Error GoTo Err2
        If param1 = "about" And param2 = "function" Then
            Return " toggles between param1 and param2 every 2 secs"

        Else
            If Secs2 > OldSecs2 Then
                OldSecs2 = Secs2 + 2
            End If
            Dim NowT = Int(Timer)

            If OUT2 = "1" Then
                Retrn2 = param1
            Else
                Retrn2 = param2
            End If


            If OldSecs2 = Secs2 Then
                OldSecs2 = Secs2 + 2
                If OUT2 = "1" Then
                    OUT2 = "2"
                    Retrn2 = param1
                Else
                    OUT2 = "1"
                    Retrn2 = param2
                End If
            End If
            Secs2 = Int(NowT) - Int(StartT2)
            Return Retrn2         ' "NT=" & NowT & " ST=" & StartT

        End If
Err2:
        Return Err.Description
    End Function
    Public Function function3(ByVal param1 As String, ByVal param2 As String) As String
        On Error GoTo Err3
        If param1 = "about" And param2 = "function" Then
            Return " toggles between param1 and param2 every 3 secs"

        Else
            If Secs3 > OldSecs3 Then
                OldSecs3 = Secs3 + 3
            End If
            Dim NowT = Int(Timer)


            If OUT3 = "1" Then
                Retrn3 = param1
            Else
                Retrn3 = param2
            End If

            If OldSecs3 = Secs3 Then
                OldSecs3 = Secs3 + 3
                If OUT3 = "1" Then
                    OUT3 = "2"
                    Retrn3 = param1
                Else
                    OUT3 = "1"
                    Retrn3 = param2
                End If
            End If
            Secs3 = Int(NowT) - Int(StartT3)
            Return Retrn3         ' "NT=" & NowT & " ST=" & StartT

        End If
Err3:
        Return Err.Description
    End Function
    Public Function function4(ByVal param1 As String, ByVal param2 As String) As String
        On Error GoTo Err4
        If param1 = "about" And param2 = "function" Then
            Return " toggles between param1 and param2 every 4 secs"

        Else
            If Secs4 > OldSecs4 Then
                OldSecs4 = Secs4 + 4
            End If
            Dim NowT = Int(Timer)

            If OUT4 = "1" Then
                Retrn4 = param1
            Else
                Retrn4 = param2
            End If

            If OldSecs4 = Secs4 Then
                OldSecs4 = Secs4 + 4
                If OUT4 = "1" Then
                    OUT4 = "2"
                    Retrn4 = param1
                Else
                    OUT4 = "1"
                    Retrn4 = param2
                End If
            End If
            Secs4 = Int(NowT) - Int(StartT4)
            Return Retrn4          ' "NT=" & NowT & " ST=" & StartT

        End If
Err4:
        Return Err.Description
    End Function



    Public Function function5(ByVal param1 As String, ByVal param2 As String) As String
        On Error GoTo Err5
        If param1 = "about" And param2 = "function" Then
            Return " toggles between param1 and param2 every 5 secs"

        Else
            If Secs5 > OldSecs5 Then
                OldSecs5 = Secs5 + 5
            End If
            Dim NowT = Int(Timer)

            If OUT5 = "1" Then
                Retrn5 = param1
            Else
                Retrn5 = param2
            End If

            If OldSecs5 = Secs5 Then
                OldSecs5 = Secs5 + 5
                If OUT5 = "1" Then
                    OUT5 = "2"
                    Retrn5 = param1
                Else
                    OUT5 = "1"
                    Retrn5 = param2
                End If
            End If
            Secs5 = Int(NowT) - Int(StartT5)
            Return Retrn5         ' "NT=" & NowT & " ST=" & StartT

        End If
Err5:
        Return Err.Description
    End Function

    Public Function function6(ByVal param1 As String, ByVal param2 As String) As String
        On Error GoTo Err6
        If param1 = "about" And param2 = "function" Then
            Return " toggles between param1 and param2 every 6 secs"

        Else
            If Secs6 > OldSecs6 Then
                OldSecs6 = Secs6 + 6
            End If
            Dim NowT = Int(Timer)


            If OUT6 = "1" Then
                Retrn6 = param1
            Else
                Retrn6 = param2
            End If


            If OldSecs6 = Secs6 Then
                OldSecs6 = Secs6 + 6
                If OUT6 = "1" Then
                    OUT6 = "2"
                    Retrn6 = param1
                Else
                    OUT6 = "1"
                    Retrn6 = param2
                End If
            End If
            Secs6 = Int(NowT) - Int(StartT6)
            Return Retrn6          ' "NT=" & NowT & " ST=" & StartT

        End If



Err6:
        Return Err.Description


    End Function


    Public Function function7(ByVal param1 As String, ByVal param2 As String) As String
        On Error GoTo Err7
        If param1 = "about" And param2 = "function" Then
            Return " toggles between param1 and param2 every 7 secs"

        Else
            If Secs7 > OldSecs7 Then
                OldSecs7 = Secs7 + 7
            End If
            Dim NowT = Int(Timer)

            If OUT7 = "1" Then
                Retrn7 = param1
            Else
                Retrn7 = param2
            End If


            If OldSecs7 = Secs7 Then
                OldSecs7 = Secs7 + 7
                If OUT7 = "1" Then
                    OUT7 = "2"
                    Retrn7 = param1
                Else
                    OUT7 = "1"
                    Retrn7 = param2
                End If
            End If
            Secs7 = Int(NowT) - Int(StartT7)
            Return Retrn7          ' "NT=" & NowT & " ST=" & StartT

        End If
Err7:
        Return Err.Description
    End Function

    Public Function function8(ByVal param1 As String, ByVal param2 As String) As String
        On Error GoTo Err8
        If param1 = "about" And param2 = "function" Then
            Return " toggles between param1 and param2 every 8 secs"

        Else
            If Secs8 > OldSecs8 Then
                OldSecs8 = Secs8 + 8
            End If
            Dim NowT = Int(Timer)

            If OUT8 = "1" Then
                Retrn8 = param1
            Else
                Retrn8 = param2
            End If

            If OldSecs8 = Secs8 Then
                OldSecs8 = Secs8 + 8
                If OUT8 = "1" Then
                    OUT8 = "2"
                    Retrn8 = param1
                Else
                    OUT8 = "1"
                    Retrn8 = param2
                End If
            End If
            Secs8 = Int(NowT) - Int(StartT8)
            Return Retrn8
            ' "NT=" & NowT & " ST=" & StartT
        End If

Err8:
        Return Err.Description
    End Function
    Public Function function9(ByVal param1 As String, ByVal param2 As String) As String
        On Error GoTo Err9
        If param1 = "about" And param2 = "function" Then
            Return " toggles between param1 and param2 every 9 secs"

        Else
            If Secs9 > OldSecs9 Then
                OldSecs9 = Secs9 + 9
            End If
            Dim NowT = Int(Timer)

            If OUT9 = "1" Then
                Retrn9 = param1
            Else
                Retrn9 = param2
            End If


            If OldSecs9 = Secs9 Then
                OldSecs9 = Secs9 + 9
                If OUT9 = "1" Then
                    OUT9 = "2"
                    Retrn9 = param1
                Else
                    OUT9 = "1"
                    Retrn9 = param2
                End If
            End If
            Secs9 = Int(NowT) - Int(StartT9)
            Return Retrn9          ' "NT=" & NowT & " ST=" & StartT

        End If
Err9:
        Return Err.Description
    End Function


    Public Function function10(ByVal param1 As String, ByVal param2 As String) As String
        On Error GoTo Err10
        If param1 = "about" And param2 = "function" Then
            Return " toggles between param1 and param2 every 10 secs"

        Else
            If Secs10 > OldSecs10 Then
                OldSecs10 = Secs10 + 10
            End If

            Dim NowT = Int(Timer)

            If OUT10 = "1" Then
                Retrn10 = param1
            Else
                Retrn10 = param2
            End If


            If OldSecs10 = Secs10 Then
                OldSecs10 = Secs10 + 10
                If OUT10 = "1" Then
                    OUT10 = "2"
                    Retrn10 = param1
                Else
                    OUT10 = "1"
                    Retrn10 = param2
                End If
            End If
            Secs10 = Int(NowT) - Int(StartT10)
            Return Retrn10          ' "NT=" & NowT & " ST=" & StartT

        End If
Err10:
        Return Err.Description
    End Function
    Public Sub New()
        StartT1 = Int(Timer)
        OUT1 = "1"
        StartT2 = Int(Timer)
        OUT2 = "1"
        StartT3 = Int(Timer)
        OUT3 = "1"
        StartT4 = Int(Timer)
        OUT4 = "1"
        StartT5 = Int(Timer)
        OUT5 = "1"
        StartT6 = Int(Timer)
        OUT6 = "1"
        StartT7 = Int(Timer)
        OUT7 = "1"
        StartT8 = Int(Timer)
        OUT8 = "1"
        StartT9 = Int(Timer)
        OUT9 = "1"
        StartT10 = Int(Timer)
        OUT10 = "1"


    End Sub

    Public Function function20(ByVal param1 As String, ByVal param2 As String) As String

        If param1 = "about" And param2 = "function" Then
            Return "  Created by Nikos Georgousis"
        Else
            Return " toggle plugin by Limbo. ver 1.1"          ' "NT=" & NowT & " ST=" & StartT
        End If


    End Function


    Public Function SmartieInfo()

        Return "Developer:Nikos Georgousis (Limbo)" & vbNewLine & "Version:1.1"

    End Function


    Public Function SmartieDemo()
        Dim demolist As New StringBuilder()

        demolist.AppendLine("toggletext plugin for LCD Smartie")
        demolist.AppendLine("This pluging toggles output between param1 and param2 in a time given by parameter number")
        demolist.AppendLine("")
        demolist.AppendLine("------ Function1 ------")
        demolist.AppendLine(">>>  Toggles every 1 sec <<<")
        demolist.AppendLine("------ Function2 ------")
        demolist.AppendLine(">>>  Toggles every 2 secs  <<<")
        demolist.AppendLine("------ Function3 ------")
        demolist.AppendLine(">>>  Toggles every 3 secs  <<<")
        demolist.AppendLine("------ Function4 ------")
        demolist.AppendLine(">>>   Toggles every 4 secs  <<<")
        demolist.AppendLine("------ Function5 ------")
        demolist.AppendLine(">>>  Toggles every 5 secs  <<<")
        demolist.AppendLine("------ Function6 ------")
        demolist.AppendLine(">>>  Toggles every 6 secs  <<<")
        demolist.AppendLine("------ Function7 ------")
        demolist.AppendLine(">>>  Toggles every 7 secs  <<<")
        demolist.AppendLine("------ Function8 ------")
        demolist.AppendLine(">>>  Toggles every 8 secs  <<<")
        demolist.AppendLine("------ Function9 ------")
        demolist.AppendLine(">>>  Toggles every 9 secs  <<<")
        demolist.AppendLine("------ Function10 ------")
        demolist.AppendLine(">>>  Toggles every 10 secs  <<<")
        demolist.AppendLine("------ Function20 ------")
        demolist.AppendLine(">>> Retunrs credits <<<")
        demolist.AppendLine("")
        demolist.AppendLine("------------------------------------------------------------------------------------------------------------------")
        demolist.AppendLine(">>>  EXAMPLES   <<<")
        demolist.AppendLine("Toggle between Hello and Hi every 4 secs:  $dll(toggletext,4,Hello,Hi)")
        demolist.AppendLine("------------------------------------------------------------------------------------------------------------------")
        demolist.AppendLine(" *** Visit ***")
        demolist.AppendLine("> Home page")
        demolist.AppendLine("https://lcdsmartie.sourceforge.net")
        demolist.AppendLine("> Forums")
        demolist.AppendLine("https://www.lcdsmartie.org")
        demolist.AppendLine("> Active development branch (latest version)")
        demolist.AppendLine("https://github.com/stokie-ant/lcdsmartie-laz")
        demolist.AppendLine("")

        Dim result As String = demolist.ToString()
        Return result
    End Function



End Class