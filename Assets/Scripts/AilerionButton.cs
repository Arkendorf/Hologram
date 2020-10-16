using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class AilerionButton : MonoBehaviour, IVirtualButtonEventHandler
{
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    public void OnButtonPressed(VirtualButtonBehaviour button)
    {
        animator.SetBool("isAilerion", true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour button)
    {
        animator.SetBool("isAilerion", false);
    }
}
