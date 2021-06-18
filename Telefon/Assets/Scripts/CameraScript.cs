using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CameraScript : MonoBehaviour
{
    [SerializeField]
    private GameObject sphere;
    private Renderer sphereRenderer;
    static WebCamTexture backCam;
    private int activity = 0;

    //start
    private void Start()
    {
        sphereRenderer = sphere.GetComponent<Renderer>();
        gameObject.GetComponent<Button>().onClick.AddListener(CameraActivity);
    }

    void CameraActivity()
    {
        if (activity == 0)
        {
            activity = 1;
            if (backCam == null)
            {
                backCam = new WebCamTexture();
            }
            sphereRenderer.GetComponent<Renderer>().material.mainTexture = backCam;

            if (!backCam.isPlaying)
            {
                backCam.Play();
            }
        }
        else if (activity == 1)
        {
            backCam.Stop();
            activity = 0;
        }

    }

    void Update()
    {

    }
}