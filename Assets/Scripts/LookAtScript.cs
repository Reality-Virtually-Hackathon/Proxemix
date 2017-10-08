using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtScript : MonoBehaviour {

	public Transform target;
	public Quaternion originalRotationValue;
    float rotationResetSpeed = 100000.0f;

    public static LookAtScript lookinstance;

    void Start(){
        lookinstance = this;
		originalRotationValue = transform.rotation; // save the initial rotation
	}
	
    public void LookAtCamera()
	{
		Vector3 relativePos = target.position - transform.position;
		transform.rotation = Quaternion.LookRotation(relativePos);
        Debug.Log(this.transform.position);
	}

	public void ResetAvatarRotation()
	{
        transform.rotation = Quaternion.Slerp(transform.rotation, originalRotationValue, Time.time * rotationResetSpeed);
	}


}
