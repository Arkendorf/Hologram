using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class RotateButton : MonoBehaviour, IVirtualButtonEventHandler
{
    public Transform rotatable;
    public float degreesPerSecond = 15;

    private bool isDown = false;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        isDown = false;
    }

    void Update()
    {
        if (isDown)
        {
            Vector3 eulerRotate = rotatable.localEulerAngles;
            eulerRotate.y += degreesPerSecond * Time.deltaTime;
            rotatable.localEulerAngles = eulerRotate;
            Debug.Log("Rotating");
        }
    }

    public void OnButtonPressed(VirtualButtonBehaviour button)
    {
        isDown = true;
    }

    public void OnButtonReleased(VirtualButtonBehaviour button)
    {
        isDown = false;
    }
}
