''Copyright (c) 2016-2017 Swiss Agency for Development and Cooperation (SDC)
''
''The program users must agree to the following terms:
''
''Copyright notices
''This program is free software: you can redistribute it and/or modify it under the terms of the GNU AGPL v3 License as published by the 
''Free Software Foundation, version 3 of the License.
''This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of 
''MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU AGPL v3 License for more details www.gnu.org.
''
''Disclaimer of Warranty
''There is no warranty for the program, to the extent permitted by applicable law; except when otherwise stated in writing the copyright 
''holders and/or other parties provide the program "as is" without warranty of any kind, either expressed or implied, including, but not 
''limited to, the implied warranties of merchantability and fitness for a particular purpose. The entire risk as to the quality and 
''performance of the program is with you. Should the program prove defective, you assume the cost of all necessary servicing, repair or correction.
''
''Limitation of Liability 
''In no event unless required by applicable law or agreed to in writing will any copyright holder, or any other party who modifies and/or 
''conveys the program as permitted above, be liable to you for damages, including any general, special, incidental or consequential damages 
''arising out of the use or inability to use the program (including but not limited to loss of data or data being rendered inaccurate or losses 
''sustained by you or third parties or a failure of the program to operate with any other programs), even if such holder or other party has been 
''advised of the possibility of such damages.
''
''In case of dispute arising out or in relation to the use of the program, it is subject to the public law of Switzerland. The place of jurisdiction is Berne.
'
' 
'

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated. 
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Partial Public Class PolicyRenewal

    '''<summary>
    '''pnlBody control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents pnlBody As Global.System.Web.UI.WebControls.Panel

    '''<summary>
    '''rbPreview control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents rbPreview As Global.System.Web.UI.WebControls.RadioButton

    '''<summary>
    '''rbJournal control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents rbJournal As Global.System.Web.UI.WebControls.RadioButton

    '''<summary>
    '''L_SMSStatus control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents L_SMSStatus As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''ddlSMSStatus control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents ddlSMSStatus As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''L_PolicyStatus control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents L_PolicyStatus As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''ddlPolicyStatus control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents ddlPolicyStatus As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''L_REGION control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents L_REGION As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''UpRegion control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents UpRegion As Global.System.Web.UI.UpdatePanel

    '''<summary>
    '''ddlRegion control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents ddlRegion As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''L_Distict control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents L_Distict As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''UpDistrict control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents UpDistrict As Global.System.Web.UI.UpdatePanel

    '''<summary>
    '''ddlDistrict control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents ddlDistrict As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''L_Village0 control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents L_Village0 As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''ddlWard control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents ddlWard As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''L_Village control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents L_Village As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''UpVillage control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents UpVillage As Global.System.Web.UI.UpdatePanel

    '''<summary>
    '''ddlVillage control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents ddlVillage As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''L_Officer control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents L_Officer As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''UpOfficer control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents UpOfficer As Global.System.Web.UI.UpdatePanel

    '''<summary>
    '''ddlOfficer control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents ddlOfficer As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''L_FromDate control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents L_FromDate As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''txtFromDate control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents txtFromDate As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Button1 control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents Button1 As Global.System.Web.UI.WebControls.Button

    '''<summary>
    '''CalendarExtender1 control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents CalendarExtender1 As Global.AjaxControlToolkit.CalendarExtender

    '''<summary>
    '''RequiredFieldBirthDate control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents RequiredFieldBirthDate As Global.System.Web.UI.WebControls.RequiredFieldValidator

    '''<summary>
    '''RegularExpressionValidator3 control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents RegularExpressionValidator3 As Global.System.Web.UI.WebControls.RegularExpressionValidator

    '''<summary>
    '''L_DateTo control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents L_DateTo As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''txtToDate control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents txtToDate As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''txtToDate_CalendarExtender control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents txtToDate_CalendarExtender As Global.AjaxControlToolkit.CalendarExtender

    '''<summary>
    '''Button2 control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents Button2 As Global.System.Web.UI.WebControls.Button

    '''<summary>
    '''RequiredFieldBirthDate0 control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents RequiredFieldBirthDate0 As Global.System.Web.UI.WebControls.RequiredFieldValidator

    '''<summary>
    '''RegularExpressionValidator4 control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents RegularExpressionValidator4 As Global.System.Web.UI.WebControls.RegularExpressionValidator

    '''<summary>
    '''CompareValidator1 control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents CompareValidator1 As Global.System.Web.UI.WebControls.CompareValidator

    '''<summary>
    '''btnSendSMS control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents btnSendSMS As Global.System.Web.UI.WebControls.Button

    '''<summary>
    '''L_DateTo0 control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents L_DateTo0 As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''ddlOn control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents ddlOn As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''pnlButtons control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents pnlButtons As Global.System.Web.UI.WebControls.Panel

    '''<summary>
    '''btnUpdateRenewals control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents btnUpdateRenewals As Global.System.Web.UI.WebControls.Button

    '''<summary>
    '''btnPreview control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents btnPreview As Global.System.Web.UI.WebControls.Button

    '''<summary>
    '''B_CANCEL control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents B_CANCEL As Global.System.Web.UI.WebControls.Button

    '''<summary>
    '''lblMsg control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents lblMsg As Global.System.Web.UI.WebControls.Label
End Class
