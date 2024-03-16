using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPanelButton : GenericButton
{
    public EPanelType PanelType;

    public override void OnClick()
    {
        base.OnClick();
        UIEvents.OnShowPanel?.Invoke(PanelType);
    }
}
