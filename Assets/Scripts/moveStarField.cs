using UnityEngine;
using System.Collections;

public class moveStarField : MonoBehaviour {

	public float speed = 10F;

	void Update () 
	{
		Vector3 newPosition = transform.position;
		newPosition.z -= speed * Time.deltaTime;
		transform.position = newPosition;
		
		if (newPosition.z < -200)
		{
			newPosition.z = +200;
			transform.position = newPosition;
		}	

	}
}