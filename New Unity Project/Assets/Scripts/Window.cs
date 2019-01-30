using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Window : MonoBehaviour { 

    public float randomCloseDelay = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDrag()
    {
            gameObject.transform.position = Input.mousePosition;

    }

    public void closeWindow()
    {
        Destroy(gameObject, Random.Range(0.1f,randomCloseDelay));
    }

    public void dropDownMenu()
    {

    }
}
