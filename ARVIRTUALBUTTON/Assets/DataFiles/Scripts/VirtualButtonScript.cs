using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonScript : MonoBehaviour,IVirtualButtonEventHandler{

	public GameObject gasstationgo, storageshipgo;
	VirtualButtonBehaviour vrb;

	// Use this for initialization
	void Start () {
		vrb = GetComponentInChildren<VirtualButtonBehaviour> ();
		vrb.RegisterEventHandler (this);
		gasstationgo.SetActive (true);
		storageshipgo.SetActive (false);
	}

	// Update is called once per frame
	void Update () {
		
	}

	public void OnButtonPressed(VirtualButtonBehaviour vb)
	{
		gasstationgo.SetActive (false);
		storageshipgo.SetActive (true);
	}

	public void OnButtonReleased(VirtualButtonBehaviour vb)
	{
		gasstationgo.SetActive (true);
		storageshipgo.SetActive (false);
	}
}
