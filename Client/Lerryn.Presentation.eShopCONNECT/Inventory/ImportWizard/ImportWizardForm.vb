﻿' eShopCONNECT for Connected Business
' Module: ImportWizardForm.vb
'
' This software is the copyright of Connected Business and
' may not be copied, duplicated or modified other than as permitted
' in the licence agreement.  This software has been generated using 
' the Connected Business SDK and may incorporate certain intellectual 
' property of Interprise Solutions Inc. who's
' rights are hereby recognised.
'

'-------------------------------------------------------------------
'
' Updated 02 December 2011

Option Explicit On
Option Strict On

#Region " ImportWizardForm "
<MenuActionAttribute.MenuAction("OpenImpExpInventoryImportForm")> _
Public Class ImportWizardForm

#Region " Properties "
    Public ReadOnly Property IsActivated() As Boolean
        Get
            If PanelBodyPluginInstance IsNot Nothing Then ' TJS 02/12/11
                Return DirectCast(PanelBodyPluginInstance, ImportWizardSectionContainer).IsActivated ' TJS 02/12/11
            Else
                Return False
            End If
        End Get
    End Property
#End Region

#Region " Methods "
#Region " Constructor "
    Public Sub New()
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '
        '   Description -    
        '
        ' Amendment Log
        '------------------------------------------------------------------------------------------
        ' Date     | Name            | Vers.     | Description
        '------------------------------------------------------------------------------------------
        ' 02/12/11 | TJS             | 2011.2.00 | Modified for IS 6
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        MyBase.New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Text = PRODUCT_NAME & " Inventory Import Wizard" ' TJS 02/12/11
        Me.ToolBar.Visible = False ' TJS 02/12/11
        Me.MainMenuBar.Visible = False ' TJS 02/12/11

    End Sub
#End Region

#End Region
End Class
#End Region
