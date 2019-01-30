using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragWindow : MonoBehaviour
{

    public GameObject window;

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
        window.transform.position = Input.mousePosition;

    }
}
