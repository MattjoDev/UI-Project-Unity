using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public enum EPanelType
{
    None = 0,
    Character = 10,
    Inventory = 20,
    Skills = 30,
}

public class GenericPanel : MonoBehaviour
{

    public EPanelType thisPanelType;

    private void OnEnable()
    {
        UIEvents.OnShowPanel += ShowIfAble;
    }

    private void OnDisable()
    {
        UIEvents.OnShowPanel -= ShowIfAble;
    }

    private void ShowIfAble(EPanelType type)
    {
        if (type == thisPanelType) Show();
        else Hide();
    }

    private void Show()
    {
            transform.GetChild(0).gameObject.SetActive(true);
    }

    private void Hide()
    {
        transform.GetChild(0).gameObject.SetActive(false);
    }
}
