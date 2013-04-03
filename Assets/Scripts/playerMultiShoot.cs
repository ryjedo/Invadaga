using UnityEngine;
using System.Collections;

public class playerMultiShoot : MonoBehaviour
{

	public float fireRate = 0.18F;
	public float nextFire = 0.0F;
	public GameObject bullet;
	public float weaponHeat = 0.0F;

	void Update ()
	{

		if(Input.GetButton("Fire1") && Time.time > nextFire&&weaponHeat < 15)
		{
			if ( GameObject.FindWithTag("sceneManager").GetComponent<playerMgr>().multiShot > 0)
			{
 				nextFire = Time.time + fireRate;
				Instantiate(bullet,transform.position,transform.rotation);
				weaponHeat += 1F;

			}
		}

	}

	void Start ()
	{
		InvokeRepeating("heatSink", 0, 5);
	}

	void heatSink ()
	{
		weaponHeat -= 5F;
	}
	
}
