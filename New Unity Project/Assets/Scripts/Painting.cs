using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Painting : MonoBehaviour
{

    int clicksPerStage = 2;
    int clicks;
    int stage;

    public List<GameObject> stages;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        clicks++;
        if (clicks >= clicksPerStage)
        {
            stages[stage].SetActive(false);
            stage++;
            stages[stage].SetActive(true);
            clicks = 0;
            clicksPerStage += 1;

        }
    }
}
