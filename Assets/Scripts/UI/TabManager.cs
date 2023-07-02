using System.Collections.Generic;
using UnityEngine;

public class TabManager : MonoBehaviour
{
    [SerializeField] private List<Tab> _tabs; 
    private Tab _activeTab; 

    private void Start()
    {
        DeactivateAllPages();
        ActivateTab(_tabs[0]);
    }

    public void OnTabClick(Tab tab)
    {
        if (tab != _activeTab)
        {
            if (_activeTab != null)
                DeactivateCurrentTab();
            ActivateTab(tab);
        }
    }

    private void ActivateTab(Tab tab)
    {
        tab.Button.isEnabled = false;
        tab.SetActivePage(true);
        _activeTab = tab;
    }

    private void DeactivateCurrentTab()
    {
        _activeTab.Button.isEnabled = true;
        _activeTab.SetActivePage(false);
    }

    private void DeactivateAllPages()
    {
        foreach (var tab in _tabs)
        {
            tab.SetActivePage(false);
        }
    }
}
