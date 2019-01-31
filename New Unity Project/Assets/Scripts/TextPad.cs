using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextPad : MonoBehaviour
{
    public Text quality;
    public Text textbox;
    public HomeButton homeButton;  

    int length = 0;
    int totalQualityValue = 0;
    int qualityValue = 0;

    List<string> words = new List<string>
    {
        "burgh ",
        "blah ",
        "blerp ",
        "glorb ",
        "hurblegalerble ",
        "shawahm ",
        "garblegerbalporp ",
        "euuugh ",
        "ep"
    };

    string currentWord;
    int currentChar;
    
    // Start is called before the first frame update
    void Start()
    {
        randomWord();
    }

    void randomWord()
    {
        currentWord = words[Random.Range(0, words.Count)];
        currentChar = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            if(Input.GetMouseButton(0) || Input.GetMouseButton(1) || Input.GetMouseButton(2)) { return; }
            textbox.text += currentWord[currentChar];
            currentChar++;
            if(currentChar == currentWord.Length)
            {
                randomWord();
                length++;
                totalQualityValue += HomeButton.instance.totalIdeaQuality;
                qualityValue = totalQualityValue / length;
                quality.text = HomeButton.instance.qualitys[qualityValue];
            }
        }
    }

    public void Delete()
    {
        quality.text = "";
        textbox.text = "";
        randomWord();
    }

    public void Save()
    {
        RecentFile file = RecentFiles.instance.selectedFile;
        if(file == null) { return; }
        file.Delete();
        file.qualityValue = qualityValue;
        file.text.text = "Idea";
        Delete();
    }
}
