using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class OnRecognize : MonoBehaviour, ITrackableEventHandler
{

    public Animator animator;
    private TrackableBehaviour trackable;

    void Start()
    {
        trackable = GetComponent<TrackableBehaviour>();
        if (trackable)
        {
            trackable.RegisterTrackableEventHandler(this);
        }

        animator.SetBool("isRecognized", false);
    }

    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            animator.SetBool("isRecognized", true);
        }
        else
        {
            animator.SetBool("isRecognized", false);
        }
    }
}