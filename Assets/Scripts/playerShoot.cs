using UnityEngine;
using System.Collections;

public class playerShoot : MonoBehaviour
{

	public GameObject bullet;

	void Update ()
	{

		if(Input.GetKeyDown(KeyCode.Space))
		{
			Instantiate(bullet,transform.position,transform.rotation);
		}

	}
	
}
