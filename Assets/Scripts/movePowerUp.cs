using UnityEngine;
using System.Collections;

public class movePowerUp : MonoBehaviour {

	public float fallSpeed = -75F;
	
	void Update () 
	{
		Vector3 newPosition = transform.position;
		newPosition.z += fallSpeed * Time.deltaTime;
		transform.position = newPosition;
	}
}
