using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class CounterScript : MonoBehaviour
{
    [SerializeField]
    private GameObject text;
    public static int counter;
    private void Start()
    {
        counter = PlayerPrefs.GetInt("counter", counter);
        text.GetComponent<UnityEngine.UI.Text>().text = counter.ToString();
        gameObject.GetComponent<Button>().onClick.AddListener(ClickCounter);
    }

    private void ClickCounter()
    {
        counter = counter + 1;
        PlayerPrefs.SetInt("counter", counter);
        text.GetComponent<UnityEngine.UI.Text>().text = counter.ToString();
    }
}