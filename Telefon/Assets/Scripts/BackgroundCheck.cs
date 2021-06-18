using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundCheck : MonoBehaviour
{
    [SerializeField]
    public GameObject mainButton;
    public GameObject circle;
    private Renderer circleRenderer;
    private Color newCircleColor;
    private float randomChannelOne, randomChannelTwo, randomChannelThree;



    Toggle toggle;
    public int isEnabled = 1;
    void Start()
    {
        toggle = GetComponent<Toggle>();
        toggle.onValueChanged.AddListener(delegate { 
            ChangeStatus(toggle); 
        });


    }

    private void Update()
    {
        if (isEnabled == 1)
        {
            Debug.Log("listening");
            circleRenderer = circle.GetComponent<Renderer>();
            mainButton.GetComponent<Button>().onClick.AddListener(ChangeCircleColor);
        }
        if (isEnabled == 0)
        {
            Debug.Log("0000");
        }
    }
    void ChangeStatus(Toggle change)
    {
        toggle = GetComponent<Toggle>();
        if (toggle.isOn)
        {
            isEnabled = 1;

            Debug.Log(isEnabled);
        }
        else if(!toggle.isOn)
        {
            isEnabled = 0;
            Debug.Log(isEnabled);

        }
    }

    private void ChangeCircleColor()
    {
        Debug.Log("Changing the color");
        randomChannelOne = Random.Range(0f, 1f);
        randomChannelTwo = Random.Range(0f, 1f);
        randomChannelThree = Random.Range(0f, 1f);

        newCircleColor = new Color(randomChannelOne, randomChannelTwo, randomChannelThree, 1f);

        circleRenderer.material.SetColor("_Color", newCircleColor);
    }
}
