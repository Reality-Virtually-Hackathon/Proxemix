using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    public AvatarInteraction myAvatarInteractionScript;
    public LookAtScript myLookAtScript;

	// Use this for initialization
	void Start () {
        //look = gameObject.GetComponent<AvatarInteraction>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay(Collider other){
        other.gameObject.GetComponent<LookAtScript>().LookAtCamera();


    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Public")
        {
            
			other.gameObject.GetComponent<AvatarInteraction>().inPublic = true;
            Debug.Log("Public Space " + myAvatarInteractionScript.inPublic);
            myAvatarInteractionScript.PublicInteract(); //where the interaction will go
			//myLookAtScript.LookAtCamera();

        }

        if (other.tag == "Social")
        {
            other.gameObject.GetComponent<AvatarInteraction>().inSocial = true;
            Debug.Log("Social Space " + myAvatarInteractionScript.inSocial);

        }

        if (other.tag == "Personal")
        {
            other.gameObject.GetComponent<AvatarInteraction>().inPersonal = true;
            Debug.Log("Personal Space " + myAvatarInteractionScript.inPersonal);

        }

        if (other.tag == "Avatar")
        {
            Debug.Log("Don't Touch Me!");
            other.gameObject.GetComponent<AvatarInteraction>().comfortLevel = 0;
            Debug.Log("Comfort Level: " + myAvatarInteractionScript.comfortLevel + ", You Lose");
        }

    }

		void OnTriggerExit(Collider other)
		{
			if (other.tag == "Public")
			{
                other.gameObject.GetComponent<AvatarInteraction>().inPublic = false;
				Debug.Log("Public Space " + myAvatarInteractionScript.inPublic);
                myLookAtScript.ResetAvatarRotation();

			}

			if (other.tag == "Social")
			{
                other.gameObject.GetComponent<AvatarInteraction>().inSocial = false;
				Debug.Log("Social Space " + myAvatarInteractionScript.inSocial);

			}

			if (other.tag == "Personal")
			{
                other.gameObject.GetComponent<AvatarInteraction>().inPersonal = false;
				Debug.Log("Personal Space " + myAvatarInteractionScript.inPersonal);

			}

			if (other.tag == "Avatar")
			{
				Debug.Log("Don't Touch Me!");
				other.gameObject.GetComponent<AvatarInteraction>().comfortLevel = 0;
				Debug.Log("Comfort Level: " + myAvatarInteractionScript.comfortLevel + ", You Lose");
			}

    
    }
}
