using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class SCOPE : MonoBehaviour
{
    public GameObject scopeOverlay;
    public GameObject mainCamera;

    public bool isScoped = false;
    // Update is called once per frame
    void Update()
    {
        if(CrossPlatformInputManager.GetButtonDown("scope"))
        {
            scopeOverlay.SetActive(true);
            mainCamera.GetComponent<Camera>().fieldOfView = 5;
        }
        if(CrossPlatformInputManager.GetButtonDown("scope2"))
        {
            scopeOverlay.SetActive(false);
            mainCamera.GetComponent<Camera>().fieldOfView = 25;
        }
        if (Input.GetKeyDown(KeyCode.Space))
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
