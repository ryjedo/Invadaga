using UnityEngine;
using System.Collections;

public class bulletMovement : MonoBehaviour
{

	public float speed = 100F;

	void Start ()
	{
		Vector3 bulletVelocity = Vector3.zero;
		bulletVelocity.z = speed;
		rigidbody.velocity = bulletVelocity;
	}

}
