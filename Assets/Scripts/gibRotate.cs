using UnityEngine;
using System.Collections;

public class gibRotate : MonoBehaviour {
	
	public float rotSpeed = 0;
	
	// Use this for initialization
	void Start () 
	{
	rotSpeed = Random.Range(-10, 10);
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Rotate(0,0,rotSpeed);
	}
}
