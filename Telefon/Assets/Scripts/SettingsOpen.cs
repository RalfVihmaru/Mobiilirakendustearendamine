using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class SettingsOpen : MonoBehaviour
{
    [SerializeField]
    private GameObject panel;


    //start
    private void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(OpenSettings);
    }

    private void OpenSettings()
    {
        panel.SetActive(true);
    }
}