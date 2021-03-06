﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Painting : MonoBehaviour
{

    float clicksPerStage = 2;
    int clicks;
    int stage = 0;
    bool done = false;
    public UnityEngine.UI.Text qualityText;
    int ideaQuality = 0;

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

    public void Save()
    {
        RecentFile file = RecentFiles.instance.selectedFile;
        file.ChangeName("Painting");
        file.stage = (stage + ideaQuality) / 2;
    }

    public void Delete()
    {
        stages[stage].SetActive(false);
        stage = 0;
        clicks = 0;
        clicksPerStage = 2;
        stages[stage].SetActive(true);
    }

    public void loadIdea()
    {
        Delete();
        ideaQuality = RecentFiles.instance.selectedFile.qualityValue;
        RecentFiles.instance.selectedFile.Delete();
        qualityText.text = HomeButton.instance.qualitys[ideaQuality];
    }
}
