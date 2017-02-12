﻿Namespace MonitoringDatabase
    Public Class AgentSystem
        Public Property AgentID As Int32
        Public Property AgentName As String
        Public Property AgentDomain As String
        Public Property AgentIP As String
        Public Property AgentOSName As String
        Public Property AgentOSBuild As String
        Public Property AgentOSArchitecture As String
        Public Property AgentProcessors As Int16
        Public Property AgentMemory As Int32
        Public Property AgentUptime As Int32
        Public Property AgentDate As Date? = Nothing
    End Class
End Namespace