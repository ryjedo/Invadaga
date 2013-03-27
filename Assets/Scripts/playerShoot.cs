using UnityEngine;
using System.Collections;

public class playerShoot : MonoBehaviour
{
	public float fireRate = 0.18F;
	public float nextFire = 0.0F;
	public GameObject bullet;

	void Update ()
	{

		if(Input.GetKey(KeyCode.Space)&&Time.time > nextFire)
		{
			nextFire = Time.time + fireRate;
			Instantiate(bullet,transform.position,transform.rotation);
		}

	}
	
}
