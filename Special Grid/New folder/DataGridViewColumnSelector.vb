
'  *****************************************
'  ** DataGridViewColumnSelector ver 1.0  **
'  **                                     **
'  ** Author : Vincenzo Rossi             **
'  ** Country: Naples, Italy              **
'  ** Year   : 2008                       **
'  ** Mail   : redmaster@tiscali.it       **
'  **                                     **
'  ** Released under                      **
'  **   The Code Project Open License     **
'  **                                     **
'  **   Please do not remove this header, **
'  **   I will be grateful if you mention **
'  **   me in your credits. Thank you     **
'  **                                     **
'  *****************************************
Imports System.Collections.Generic
Imports System.Text
Imports System.Windows.Forms
Imports System.Drawing

Namespace DGVColumnSelector
	''' <summary>
	''' Add column show/hide capability to a DataGridView. When user right-clicks 
	''' the cell origin a popup, containing a list of checkbox and column names, is
	''' shown. 
	''' </summary>
    Public Class DataGridViewColumnSelector
        ' the DataGridView to which the DataGridViewColumnSelector is attached
        Private mDataGridView As DataGridView = Nothing
        ' a CheckedListBox containing the column header text and checkboxes
        Private mCheckedListBox As CheckedListBox
        ' a ToolStripDropDown object used to show the popup
        Private mPopup As ToolStripDropDown

        ''' <summary>
        ''' The max height of the popup
        ''' </summary>
        Public MaxHeight As Integer = 300
        ''' <summary>
        ''' The width of the popup
        ''' </summary>
        Public Width As Integer = 200

        ''' <summary>
        ''' Gets or sets the DataGridView to which the DataGridViewColumnSelector is attached
        ''' </summary>
        Public Property DataGridView() As DataGridView
            Get
                Return mDataGridView
            End Get
            Set(ByVal value As DataGridView)
                ' If any, remove handler from current DataGridView 
                If mDataGridView IsNot Nothing Then
                    'mDataGridView.CellMouseClick -= New DataGridViewCellMouseEventHandler(AddressOf mDataGridView_CellMouseClick)
                End If
                ' Set the new DataGridView
                mDataGridView = Value
                ' Attach CellMouseClick handler to DataGridView
                If mDataGridView IsNot Nothing Then
                    'mDataGridView.CellMouseClick += New DataGridViewCellMouseEventHandler(AddressOf mDataGridView_CellMouseClick)
                End If
            End Set
        End Property

        ' When user right-clicks the cell origin, it clears and fill the CheckedListBox with
        ' columns header text. Then it shows the popup. 
        ' In this way the CheckedListBox items are always refreshed to reflect changes occurred in 
        ' DataGridView columns (column additions or name changes and so on).
        Private Sub mDataGridView_CellMouseClick(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs)
            If e.Button = MouseButtons.Right AndAlso e.RowIndex = -1 AndAlso e.ColumnIndex = -1 Then
                'mCheckedListBox.Items.Clear();
                'foreach (DataGridViewColumn c in mDataGridView.Columns){
                '    mCheckedListBox.Items.Add(c.HeaderText, c.Visible);
                '}
                'int PreferredHeight = (mCheckedListBox.Items.Count * 16) + 7;
                'mCheckedListBox.Height = (PreferredHeight < MaxHeight) ? PreferredHeight : MaxHeight;
                'mCheckedListBox.Width = this.Width;
                pUserControl1.Initialize(mDataGridView)
                mPopup.Show(mDataGridView.PointToScreen(New Point(e.X, e.Y)))
            End If
        End Sub

        Private pUserControl1 As New UserControlMenu()
        ' The constructor creates an instance of CheckedListBox and ToolStripDropDown.
        ' the CheckedListBox is hosted by ToolStripControlHost, which in turn is
        ' added to ToolStripDropDown.
        Public Sub New()
            'mCheckedListBox = new CheckedListBox();
            'mCheckedListBox.CheckOnClick = true;
            'mCheckedListBox.ItemCheck += new ItemCheckEventHandler(mCheckedListBox_ItemCheck);

            'ToolStripControlHost mControlHost = new ToolStripControlHost(mCheckedListBox);
            pUserControl1.DoneEvent = New EventHandler(AddressOf OnDone)
            'pUserControl1.CheckedChangedEnent = New UserControlMenu.CheckedChanged(AddressOf CheckedChangedEnent)
            Dim mControlHost As New ToolStripControlHost(pUserControl1)
            mControlHost.Padding = Padding.Empty
            mControlHost.Margin = Padding.Empty
            mControlHost.AutoSize = False

            mPopup = New ToolStripDropDown()
            mPopup.Padding = Padding.Empty
            mPopup.AutoClose = True
            mPopup.Items.Add(mControlHost)
        End Sub

        Private Sub CheckedChangedEnent(ByVal iIndex As Integer, ByVal bChecked As Boolean)
            mDataGridView.Columns(iIndex).Visible = bChecked
        End Sub

        Private Sub OnDone(ByVal sender As Object, ByVal e As EventArgs)
            mPopup.AutoClose = False
            mPopup.Close()
            mPopup.AutoClose = True
        End Sub

        Public Sub New(ByVal dgv As DataGridView)
            Me.New()
            Me.DataGridView = dgv
        End Sub

        ' When user checks / unchecks a checkbox, the related column visibility is 
        ' switched.
        Private Sub mCheckedListBox_ItemCheck(ByVal sender As Object, ByVal e As ItemCheckEventArgs)
            mDataGridView.Columns(e.Index).Visible = (e.NewValue = CheckState.Checked)
        End Sub
    End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
