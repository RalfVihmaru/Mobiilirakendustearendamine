using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class amogusButton : MonoBehaviour
{
    [SerializeField]
    private GameObject button;
    private Renderer buttonRenderer;
    private Color newButtonColor;
    private float randomChannelOne, randomChannelTwo, randomChannelThree;

    //start
    private void Start()
    {
        buttonRenderer = button.GetComponent<Renderer>();
        gameObject.GetComponent<Button>().onClick.AddListener(ChangeButtonColor);
    }

    private void ChangeButtonColor()
    {

        randomChannelOne = Random.Range(0f, 1f);
        randomChannelTwo = Random.Range(0f, 1f);
        randomChannelThree = Random.Range(0f, 1f);

        newButtonColor = new Color(randomChannelOne, randomChannelTwo, randomChannelThree, 1f);

        buttonRenderer.material.SetColor("_Color", newButtonColor);
        button.GetComponent<Image>().color = newButtonColor;
    }

}