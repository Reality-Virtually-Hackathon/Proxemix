using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarInteraction : MonoBehaviour {
	
    public bool inPublic = false;
	public bool inSocial = false;
	public bool inPersonal = false;
	public int comfortLevel = 50;

    public static AvatarInteraction instance;

	// Use this for initialization
	void Start () {
        instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PublicInteract(){
        Debug.Log("Public Space Interaction");
    }

	public void SocialInteract()
	{
		Debug.Log("Social Space Interaction");
	}

	public void PersonalInteract()
	{
		Debug.Log("Personal Space Interaction");
	}

}
