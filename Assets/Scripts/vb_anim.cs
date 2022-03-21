using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vb_anim : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject vbBtnObj;
    public Animator treeAni;
    // Start is called before the first frame update
    void Start()
    {
        vbBtnObj = GameObject.Find("AniButton");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        treeAni.GetComponent<Animator>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb){
        treeAni.Play("Tree");
        Debug.Log("BTN Pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb){
        treeAni.Play("none");
        Debug.Log("BTN Released");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
