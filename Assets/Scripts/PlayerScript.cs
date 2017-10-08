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
        /*
        if (other.tag == "Public") {
            Debug.Log("Gothere");
            if (other == null)
            {
                return;
            }
            Debug.Log("Gothere too");
            GameObject go = other.gameObject;
            if (go == null)
            {
                return;
            }
            Debug.Log("Gothere3");
            LookAtScript las = other.GetComponent<LookAtScript>();
            Debug.Log("Gothere4");
            if (las == null)
            {
                Debug.Log("las is not null");
            }
            las.LookAtCamera();
            Debug.Log("got here");
         }*/
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Public")
        {
            myAvatarInteractionScript.inPublic = true;
			//other.gameObject.GetComponent<AvatarInteraction>().inPublic = true;
            Debug.Log("Public Space " + myAvatarInteractionScript.inPublic);
            myAvatarInteractionScript.PublicInteract(); //where the interaction will go
            myLookAtScript.LookAtCamera();

        }

        if (other.tag == "Social")
        {
            myAvatarInteractionScript.inSocial = true;
            //other.gameObject.GetComponent<AvatarInteraction>().inSocial = true;
            Debug.Log("Social Space " + myAvatarInteractionScript.inSocial);
            
        }

        if (other.tag == "Personal")
        {
            myAvatarInteractionScript.inPersonal = true;
            //other.gameObject.GetComponent<AvatarInteraction>().inPersonal = true;
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
                myAvatarInteractionScript.inPublic = false;
                //other.gameObject.GetComponent<AvatarInteraction>().inPublic = false;
				Debug.Log("Public Space " + myAvatarInteractionScript.inPublic);
                myLookAtScript.ResetAvatarRotation();

			}

			if (other.tag == "Social")
			{
                myAvatarInteractionScript.inSocial = false;
                //other.gameObject.GetComponent<AvatarInteraction>().inSocial = false;
                Debug.Log("Social Space " + myAvatarInteractionScript.inSocial);

			}

			if (other.tag == "Personal")
			{
            myAvatarInteractionScript.inPersonal = false;
            //other.gameObject.GetComponent<AvatarInteraction>().inPersonal = false;
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
