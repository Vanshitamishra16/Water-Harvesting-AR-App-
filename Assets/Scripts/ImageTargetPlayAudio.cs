using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.Playables;

public class ImageTargetPlayAudio : MonoBehaviour,
ITrackableEventHandler
{
    private TrackableBehaviour mTrackableBehaviour;
    public AudioSource AudioObject;

    void Start(){
        GetComponent<AudioSource> ();

        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if(mTrackableBehaviour){
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }

    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus){
        if(newStatus==TrackableBehaviour.Status.DETECTED || newStatus == TrackableBehaviour.Status.TRACKED || newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            AudioObject.Play();
        }
        else{
            AudioObject.Stop();
        }
       

    }
}