using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeenitUpload : MonoBehaviour
{

    bool uploading = false;
    public UnityEngine.UI.Slider slider;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (uploading)
        {
            slider.value += Random.Range(0, 0.005f);
            if(slider.value >= 1)
            {
                uploading = false;
            }
        }
    }

    public void Upload()
    {
        uploading = true;
    }
}