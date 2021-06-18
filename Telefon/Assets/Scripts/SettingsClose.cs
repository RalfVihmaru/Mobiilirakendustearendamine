using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class SettingsClose : MonoBehaviour
{
    [SerializeField]
    private GameObject panel;


    //start
    private void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(CloseSettings);
    }

    private void CloseSettings()
    {
        panel.SetActive(false);
    }
}