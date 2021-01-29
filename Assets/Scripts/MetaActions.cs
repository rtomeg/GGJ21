using System;
using UnityEngine;

public class MetaActions : MonoBehaviour
{
    private void Start()
    {
        EventsManager.onOpenExplorerPath += OpenExplorerPath;
    }

    private void OnDestroy()
    {
        throw new NotImplementedException();
    }

    public void OpenExplorerPath(string path)
    {
        System.Diagnostics.Process p = new System.Diagnostics.Process();
        path = Application.dataPath + path;
        path = path.Replace(@"/", @"\");
        Debug.Log(path);
        p.StartInfo = new System.Diagnostics.ProcessStartInfo("explorer.exe", "/select," + path);
        p.Start();
    }
}