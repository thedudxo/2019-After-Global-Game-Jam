using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Window : MonoBehaviour { 

    float randomCloseDelay = 1f;
    float randomSpawnRange = 200f;

    public GameObject onScreenWindow;
    public GameObject onTaskbarWindow;
    public int windowNumber = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (WindowManager.instance.addWindow(this))
        {
            randomPos();
        }
        else { Destroy(gameObject); }
    }

    void randomPos()
    {
        float range = randomSpawnRange / 2;

        onScreenWindow.transform.position = new Vector3(
            onScreenWindow.transform.position.x + Random.Range(-range, range),
            onScreenWindow.transform.position.y + Random.Range(-range, range),
            onScreenWindow.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void closeWindow()
    {
        WindowManager.instance.RemoveWindow(this);
        Destroy(gameObject, Random.Range(0,randomCloseDelay));
    }

    public void Minimise()
    {
        onScreenWindow.SetActive(false);
        onTaskbarWindow.SetActive(true);
        WindowManager.instance.MinimiseWindow(this);
    }

    public void Maximise()
    {
        onTaskbarWindow.SetActive(false);
        onScreenWindow.SetActive(true);
        WindowManager.instance.MaximiseWindow(this);
        randomPos();
    }

}
