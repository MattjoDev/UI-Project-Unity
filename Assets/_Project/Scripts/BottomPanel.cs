using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomPanel : MonoBehaviour
{
    public void ShowCharacterPanel()
    {
        UIEvents.OnShowPanel?.Invoke(EPanelType.Character);
    }
    public void ShowInventoryPanel()
    {
        UIEvents.OnShowPanel?.Invoke(EPanelType.Inventory);
    }
    public void ShowSkillsPanel()
    {
        UIEvents.OnShowPanel?.Invoke(EPanelType.Skills);
    }
}
