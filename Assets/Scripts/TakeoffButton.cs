using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class TakeoffButton : MonoBehaviour, IVirtualButtonEventHandler
{
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    public void OnButtonPressed(VirtualButtonBehaviour button)
    {
        animator.SetBool("isFlying", !animator.GetBool("isFlying"));
    }

    public void OnButtonReleased(VirtualButtonBehaviour button)
    {
    }
}
