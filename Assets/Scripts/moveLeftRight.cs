using UnityEngine;
using System.Collections;

public class moveLeftRight : MonoBehaviour {

	public float speed = 200F;
	public float edgeBuffer = 100F;
	private float rightEdge;
	//private float leftEdge = edgeBuffer;
	
	
	void Update ()
	{
		
		//move player left and right
		Vector3 newPosition = transform.position;
		newPosition.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
		transform.position = newPosition;
		
		//keep player on the screen
		Vector3 viewPos = Camera.main.WorldToScreenPoint(transform.position);
		rightEdge = Screen.width - edgeBuffer;
		viewPos.x = Mathf.Clamp(viewPos.x, edgeBuffer, rightEdge);
		transform.position = Camera.main.ScreenToWorldPoint(viewPos);
		
	}

}
