using UnityEngine;
using System.Collections;

public class playerMultiShoot : MonoBehaviour
{

	public float fireRate = 0.18F;
	public float nextFire = 0.0F;
	public GameObject bullet;

	void Update ()
	{

		if(Input.GetKey(KeyCode.Space)&&Time.time > nextFire)
		{
			if ( GameObject.FindWithTag("sceneManager").GetComponent<playerMgr>().multiShot > 0)
			{
 				nextFire = Time.time + fireRate;
				Instantiate(bullet,transform.position,transform.rotation);
			}
		}

	}
	
}
