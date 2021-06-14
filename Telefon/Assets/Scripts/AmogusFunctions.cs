using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class AmogusFunctions : MonoBehaviour
{
    [SerializeField]
    private int count = 0;
    private void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(ClickUp);
    }

    private void ClickUp()
    {
        count = count + 1;
        if (count == 5)
        {
            count = 0;
            SceneManager.LoadScene("Scene2");

        }
    }
}