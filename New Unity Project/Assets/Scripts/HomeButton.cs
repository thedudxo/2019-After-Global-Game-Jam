using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeButton : MonoBehaviour {

    public static HomeButton instance;

    public GameObject homeWindow;
    public GameObject paint;
    public GameObject interdud;
    public GameObject Idea;
    public GameObject TextPad;

    int ideaChance = 250;
    public List<GameObject> ideas = new List<GameObject>();
    public int totalIdeaQuality = 0;


    public readonly List<string> qualitys = new List<string>() {
    "Nope",
    "Terrible",
    "Bad",
    "Meh",
    "okay",
    "Good",
    "Great",
    "Awesome",
    "Perfect",
    "Magnum Opus" };
    

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

        if (Random.Range(0, ideaChance) == 1)
        { 
            ideas.Add(Instantiate(Idea, gameObject.transform));
            
        }

        int totalQuality = 0;
        int numberOfIdeas = 0;
        foreach(GameObject idea in ideas)
        {
            if(idea == null) { return; }
            totalQuality += idea.GetComponent<ThoughtBubble>().qualityValue;
            numberOfIdeas++;
        }
        if (numberOfIdeas <= 0) { return; }
        totalIdeaQuality = (totalQuality / numberOfIdeas);
        
    }

    public void OpenHome()
    {
        homeWindow.SetActive(!homeWindow.activeInHierarchy);
    }

    public void OpenPaint()
    {
        Instantiate(paint, gameObject.transform);
    }

    public void OpenInternet()
    {
        Instantiate(interdud, gameObject.transform);
    }

    public void OpenTextpad()
    {
        Instantiate(TextPad, gameObject.transform);
    }
}
