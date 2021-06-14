using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class buttonScript : MonoBehaviour
{
    [SerializeField]
    public GameObject circle;
    private Renderer circleRenderer;
    private Color newCircleColor;
    private float randomChannelOne, randomChannelTwo, randomChannelThree;
    //start
    private void Start()
    {
        circle = GameObject.Find("Circle");
        circleRenderer = circle.GetComponent<Renderer>();
        gameObject.GetComponent<Button>().onClick.AddListener(ChangeCircleColor);
    }

        private void ChangeCircleColor()
    {
        randomChannelOne = Random.Range(0f, 1f);
        randomChannelTwo = Random.Range(0f, 1f);
        randomChannelThree = Random.Range(0f, 1f);

        newCircleColor = new Color(randomChannelOne, randomChannelTwo, randomChannelThree, 1f);

        circleRenderer.material.SetColor("_Color", newCircleColor);
    }
}