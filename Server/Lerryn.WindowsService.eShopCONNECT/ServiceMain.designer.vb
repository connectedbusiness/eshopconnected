Imports System.ServiceProcess

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServiceMain
    Inherits System.ServiceProcess.ServiceBase

    'UserService overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    ' The main entry point for the process
    <MTAThread()> _
    <System.Diagnostics.DebuggerNonUserCode()> _
    Shared Sub Main()
        Dim ServicesToRun() As System.ServiceProcess.ServiceBase

        ' More than one NT Service may run within the same process. To add
        ' another service to this process, change the following line to
        ' create a second service object. For example,
        '
        '   ServicesToRun = New System.ServiceProcess.ServiceBase () {New Service1, New MySecondUserService}
        '

        ' www.dynenttech.com davidonelson 5/8/2018
        ' OLD CODE
        'ServicesToRun = New System.ServiceProcess.ServiceBase() {New ServiceMain}
        'System.ServiceProcess.ServiceBase.Run(ServicesToRun)
        ' NEW CODE
        ' This allows for debugging in interactive mode and running as a service in the background
        If Environment.UserInteractive Then
            Dim service1 As ServiceMain = New ServiceMain()
            service1.TestStartupAndStop()
        Else
            ServicesToRun = New System.ServiceProcess.ServiceBase() {New ServiceMain}
            System.ServiceProcess.ServiceBase.Run(ServicesToRun)
        End If

    End Sub

    'Required by the Component Designer
    Private components As System.ComponentModel.IContainer

    ' NOTE: The following procedure is required by the Component Designer
    ' It can be modified using the Component Designer.  
    ' Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        '
        'ServiceMain
        '
        Me.CanHandlePowerEvent = True
        Me.CanHandleSessionChangeEvent = True
        Me.ServiceName = SERVICE_NAME ' TJS 13/06/10

    End Sub

End Class
