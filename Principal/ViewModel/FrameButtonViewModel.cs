using System;
using Principal.Command;

namespace Principal.ViewModel;

public class FrameButtonViewModel : DefaultNotifyProperty
{
    public Action Insert { get; set; }
    public Action Alter { get; set; }
    public Action Cancel { get; set; }
    public Action Delete { get; set; }
    public Action Confirm { get; set; }
    
    public Action Search { get; set; }
    
    private bool _confirmFrameIsVisible;

    public bool ConfirmFrameIsVisible
    {
        get => _confirmFrameIsVisible;
        set => SetField(ref _confirmFrameIsVisible, value);
    }

    #region  AuxiliarFunctions

    public void SearchFunc()
    {
        Search.Invoke();
    }
    
    public void ConfirmFunc()
    {
        Confirm.Invoke();
    }
    
    public void DeleteFunc()
    {
        Delete.Invoke();
    }
    
    public void CancelFunc()
    {
        Cancel.Invoke();
    }
    
    public void InsertFunc()
    {
        Insert.Invoke();
    }

    public void AlterFunc()
    {
        Alter.Invoke();
    }
    #endregion
}