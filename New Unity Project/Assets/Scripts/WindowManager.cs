using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowManager : MonoBehaviour
{
    public static int maxWindows = 4;
    public static WindowManager instance;
    float minHeight = -4.969872f;
    float height = -4.969872f;
    float spacing = 0.2f;
    List<Window> windows;



    // Start is called before the first frame update
    void Start()
    {

        if (instance != this){
            Destroy(instance);
        }
        instance = this;

        windows = new List<Window>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool addWindow(Window window)
    {
        if(windows.Count == maxWindows)
        {
            Debug.Log("max windows");
            return false;
        }
        windows.Add(window);
        bringToFront(window);
        return true;
            
    }

    public void RemoveWindow(Window window)
    {
        windows.Remove(window);
        if(windows.Count == 0)
        {
            height = minHeight;
        }
    }

    public void MinimiseWindow(Window window)
    {
    }

    public void MaximiseWindow(Window window)
    {
        bringToFront(window);
    }

    void bringToFront(Window window)
    {
        height -= spacing;
        window.transform.localPosition = new Vector3(
            window.transform.localPosition.x,
            window.transform.localPosition.y,
            height);
    }
}
