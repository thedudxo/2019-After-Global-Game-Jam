using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecentFile : MonoBehaviour
{
    public Color selectedColour;
    public bool selected = false;
    ColorBlock normalColours;

    //save
    public Text text;
    public int stage = 0;

    // Start is called before the first frame update
    void Start()
    {
        normalColours = gameObject.GetComponent<Button>().colors;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeName(string name)
    {
        text.text = name;
    }

    public void Deselect()
    {
        selected = false;
        GetComponent<Button>().colors = normalColours;
    }

    public void Select()
    {
        RecentFiles.instance.DeseletAll();
        selected = true;
        var colours = gameObject.GetComponent<Button>().colors;
        colours.normalColor = selectedColour;
        colours.highlightedColor = selectedColour;
        colours.pressedColor = selectedColour;
        GetComponent<Button>().colors = colours;
        RecentFiles.instance.selectedFile = this;
    }

    public void Delete()
    {
        ChangeName("Empty");
        stage = 0;
    }
}
