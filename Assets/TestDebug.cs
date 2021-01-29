using System;
using UnityEngine;

public class TestDebug : MonoBehaviour
{
    public void OpenExplorer()
    {
        EventsManager.onOpenExplorerPath("");
    }

    public void OnChatLine()
    {
        EventsManager.onChatLine("ThisIsAChatMessage", MyEnums.Interlocutor.BOSS);
    }
    
    
    //SCRIPT A:
    public void DoSomething()
    {
        EventsManager.onOpenExplorerPath("TestDebug.cs");
    }

    private void Start()
    {
        EventsManager.onOpenExplorerPath += OpenExplorerPath;
    }

    private void OnDestroy()
    {
        EventsManager.onOpenExplorerPath -= OpenExplorerPath;
    }


    //SCRIPT UTILS
    public void OpenExplorerPath(string st)
    {
        //open
    }
}
