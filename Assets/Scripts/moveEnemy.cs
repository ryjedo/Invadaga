using UnityEngine;
using System.Collections;

public class moveEnemy : MonoBehaviour
{
	
	public float maxspeedX = 100f;
	public float minspeedX = 20f;
	public float maxspeedZ = -100f;
	public float minspeedZ = -25f;
	
	private float direction = 0;
	private float directionSwapFirst = 0;
	private float directionSwapSubsequent = 0;
	private float speedX = 0F;
	private float speedZ = 0F;

	void Start ()
	{
		speedX = Random.Range(minspeedX, maxspeedX);
		speedZ = Random.Range(minspeedZ, maxspeedZ);
		directionSwapFirst = Random.Range(1, 3);
		directionSwapSubsequent = Random.Range(1, 3);
		Invoke("Direction", 0f);
		InvokeRepeating("Direction",directionSwapFirst,directionSwapSubsequent);
		
	}

	void Update ()
	{
		Vector3 newPosition = transform.position;
		newPosition.x += speedX * direction * Time.deltaTime;
		newPosition.z += speedZ * Time.deltaTime;
		transform.position = newPosition;
		
	}
	
	void Direction()
	{
		if(Random.value > 0.5)
		direction = 1;
		else
		direction = -1;
	}
}
