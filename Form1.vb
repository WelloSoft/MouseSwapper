Imports WindowsHookLib
Imports MouseSwap
Imports Microsoft.Win32

Public Class Form1
    Private MouseHooker As Inverter

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MouseHooker = New Inverter(False, False)
        AddHandler SystemEvents.DisplaySettingsChanged, AddressOf MsHook_Refresh
    End Sub


    Public Sub MsHook_Refresh()
        Dim mouseHooker As Inverter = Me.MouseHooker
        If Me.AutoFlip.Checked Then
            Dim screenOrientation As ScreenOrientation = SystemInformation.ScreenOrientation
            Select Case CInt(screenOrientation)
                Case 0
                    mouseHooker.Swap = False
                    mouseHooker.InvertX = False
                    mouseHooker.InvertY = False
                    GoTo Label_00FA

                Case 1
                    mouseHooker.Swap = True
                    mouseHooker.InvertX = True
                    mouseHooker.InvertY = False
                    GoTo Label_00FA

                Case 2
                    mouseHooker.Swap = False
                    mouseHooker.InvertX = True
                    mouseHooker.InvertY = True
                    GoTo Label_00FA

                Case 3
                    mouseHooker.Swap = True
                    mouseHooker.InvertX = False
                    mouseHooker.InvertY = True
                    GoTo Label_00FA
            End Select
            Return
        End If
        mouseHooker.Swap = Me.SwapXY.Checked
        mouseHooker.InvertX = Me.FlipX.Checked
        mouseHooker.InvertY = Me.FlipY.Checked
Label_00FA:
        If Me.Enabler.Checked Then
            If Not mouseHooker.Running Then
                mouseHooker.Start()
            End If
        ElseIf mouseHooker.Running Then
            mouseHooker.[Stop]()
        End If
        mouseHooker = Nothing
    End Sub

    Private Sub ParamUpdate(sender As System.Object, e As System.EventArgs) Handles SwapXY.CheckedChanged, FlipY.CheckedChanged, FlipX.CheckedChanged, Enabler.CheckedChanged, AutoFlip.CheckedChanged
        If Me.Visible Then MsHook_Refresh()
    End Sub
End Class
