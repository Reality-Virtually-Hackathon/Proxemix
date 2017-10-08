using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    public AvatarInteraction myAvatarInteractionScript;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Public")
        {
            myAvatarInteractionScript.inPublic = true;
            Debug.Log("Public Space " + myAvatarInteractionScript.inPublic);
            myAvatarInteractionScript.PublicInteract(); //where the interaction will go

        }

        if (other.tag == "Social")
        {
            myAvatarInteractionScript.inSocial = true;
            Debug.Log("Social Space " + myAvatarInteractionScript.inSocial);

        }

        if (other.tag == "Personal")
        {
            myAvatarInteractionScript.inPersonal = true;
            Debug.Log("Personal Space " + myAvatarInteractionScript.inPersonal);

        }

        if (other.tag == "Avatar")
        {
            Debug.Log("Don't Touch Me!");
            myAvatarInteractionScript.comfortLevel = 0;
            Debug.Log("Comfort Level: " + myAvatarInteractionScript.comfortLevel + ", You Lose");
        }

    }

		void OnTriggerExit(Collider other)
		{
			if (other.tag == "Public")
			{
                myAvatarInteractionScript.inPublic = false;
				Debug.Log("Public Space " + myAvatarInteractionScript.inPublic);
				//myAvatarInteractionScript.PublicInteract(); //where the interaction will go

			}

			if (other.tag == "Social")
			{
                myAvatarInteractionScript.inSocial = false;
				Debug.Log("Social Space " + myAvatarInteractionScript.inSocial);

			}

			if (other.tag == "Personal")
			{
                myAvatarInteractionScript.inPersonal = false;
				Debug.Log("Personal Space " + myAvatarInteractionScript.inPersonal);

			}

			if (other.tag == "Avatar")
			{
				Debug.Log("Don't Touch Me!");
				myAvatarInteractionScript.comfortLevel = 0;
				Debug.Log("Comfort Level: " + myAvatarInteractionScript.comfortLevel + ", You Lose");
			}

    
    }
}
