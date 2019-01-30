using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecentFiles : MonoBehaviour
{
    public static RecentFiles instance;
    public List<RecentFile> recentFiles = new List<RecentFile>();
    public RecentFile selectedFile = null;

    // Start is called before the first frame update
    void Start()
    {
        if (instance != this)
        {
            Destroy(instance);
        }
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DeseletAll()
    {
        foreach (RecentFile file in recentFiles)
        {
            
            file.Deselect();
        }
    }
}
