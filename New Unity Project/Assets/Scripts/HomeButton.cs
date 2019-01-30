using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeButton : MonoBehaviour { 

    public GameObject homeWindow;
    public GameObject paint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenHome()
    {
        homeWindow.SetActive(!homeWindow.activeInHierarchy);
    }

    public void OpenPaint()
    {
        Instantiate(paint, gameObject.transform);
    }
}
