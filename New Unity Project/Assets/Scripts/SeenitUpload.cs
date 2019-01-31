using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SeenitUpload : MonoBehaviour
{

    bool uploading = false;
    public UnityEngine.UI.Slider slider;
    public GameObject uploaded;
    public Text rating;
    public List<GameObject> stages;
    bool submitted = false;
    int stage;

    List<string> wows = new List<string>
    {
        "Wow",
        "Meh",
        "yes",
        "Awesome",
        "Not bad",
        "Could be better",
        "Should be sued for this",
        "LOL",
        "omg hiiii",
        "Can we colab?",
        "Wrong subseenit",
        "you should use adoobl pictureshoop",
        "im sure there was meaning here, but i dont see it"
    };

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
                uploaded.SetActive(true);
                submitted = true;
                rating.text = wows[Random.Range(0,wows.Count)] + ", " + stage + "/10";
            }
        }
    }

    public void Upload()
    {
        if (submitted) { return; }
        RecentFile file = RecentFiles.instance.selectedFile;
        if (file == null || file.text.text == "Empty") { return; }
        stage = file.stage;
        stages[stage].SetActive(true);
        file.Delete();
        RecentFiles.instance.DeseletAll();
        uploading = true;
    }
}