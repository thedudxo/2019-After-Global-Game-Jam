using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThoughtBubble : MonoBehaviour
{

    float growRate = 1.03f;
    float decayRate = 1.015f;
    float mouseGrowRate = 1.04f;
    float maxSize = 11f;
    float sizeCap = 30f;
    bool growing = true;
    Vector3 lastMousePos;

    public UnityEngine.UI.Text quality;
    List<string> qualitys;
    public int qualityValue;

    // Start is called before the first frame update
    void Start()
    {
        qualitys = HomeButton.instance.qualitys;
        transform.localPosition = new Vector3(
            Random.Range(-8f, 8f),
            Random.Range(-4f, 4f), 0);

        qualityValue = Random.Range(0, qualitys.Count);
        quality.text = qualitys[qualityValue];
    }

    // Update is called once per frame
    void Update()
    {

        if (growing) { gameObject.transform.localScale = gameObject.transform.localScale * growRate; }
        else { gameObject.transform.localScale = gameObject.transform.localScale / decayRate;
            if(gameObject.transform.localScale.x < 0.1) { HomeButton.instance.ideas.Remove(gameObject);  Destroy(gameObject);  }
        }
        if (gameObject.transform.localScale.x > maxSize)
        {
            growing = false;
        }
    }

    public void OnMouseOver()
    {

        if(Input.mousePosition != lastMousePos)
        {
            gameObject.transform.localScale = gameObject.transform.localScale * mouseGrowRate;
            if(gameObject.transform.localScale.x > sizeCap)
            {
                gameObject.transform.localScale = new Vector3 (sizeCap, sizeCap, sizeCap);
            }
        }

        lastMousePos = Input.mousePosition;
    }
}
