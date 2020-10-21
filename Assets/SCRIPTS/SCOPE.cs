using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCOPE : MonoBehaviour
{
    public GameObject scopeOverlay;
    public GameObject mainCamera;

    public bool isScoped = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            scopeOverlay.SetActive(true);
            mainCamera.GetComponent<Camera>().fieldOfView = 15;
        }
        if(Input.GetKeyDown(KeyCode.F))
        {
            scopeOverlay.SetActive(false);
            mainCamera.GetComponent<Camera>().fieldOfView = 60;
        }
    }
}
