using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Painting : MonoBehaviour
{

    float clicksPerStage = 2;
    int clicks;
    int stage = 0;
    bool done = false;

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
        Debug.Log(stages.Count + "" + stage);
        if(stage + 1 == stages.Count) { done = true;  return; }
        clicks++;
        if (clicks >= clicksPerStage)
        {
            stages[stage].SetActive(false);
            stage++;
            stages[stage].SetActive(true);
            clicks = 0;
            clicksPerStage += 0.5f;

        }
    }
}
