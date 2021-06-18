using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TestScript : MonoBehaviour
{
    [SerializeField]
    public GameObject mainButton;
    public Toggle toggle;
    private int value = 0;
    private GameObject circle;

    void Start()
    {
        toggle.GetComponent<Toggle>();
        toggle.onValueChanged.AddListener(delegate {
            OnOff();
        });
    }
    private void Update()
    {

    }

    private void OnOff()
    {
        if (gameObject.GetComponent<Toggle>().isOn == true)
        {
            Debug.Log(value);
            
            if (value == 1)
            {
                value = 0;
                Debug.Log("Enabled");
                mainButton.AddComponent<buttonScript>();

            }
        }
        if (gameObject.GetComponent<Toggle>().isOn == false)
        {
            
            
            Debug.Log(value);
            if (value == 0)
            {
                value = 1;
                Destroy(mainButton.GetComponent<buttonScript>());
                Debug.Log("Disabled");

            }
        }
    }
}
