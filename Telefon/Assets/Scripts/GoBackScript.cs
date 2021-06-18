using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class GoBackScript : MonoBehaviour
{
    [SerializeField]
    private void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(ClickUp);
    }

    private void ClickUp()
    {
        SceneManager.LoadScene("Scene1");
    }
}