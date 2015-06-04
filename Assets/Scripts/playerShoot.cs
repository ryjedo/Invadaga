using UnityEngine;
using System.Collections;

public class playerShoot : MonoBehaviour
{
	public float playerWeaponFireRate;
	private float nextFire;
	public GameObject playerBullet;
	void Update ()
	{

		if(Input.GetButton("Fire1") && Time.time > nextFire)// && !sceneManager.playerWeaponOverheat)
		{
			playerBulletFire();
		}

	}

		
	private void playerBulletFire()
	{
		Instantiate(playerBullet, transform.position , transform.rotation);
		//sceneManager.playerWeaponHeat += 1;
		nextFire = Time.time + playerWeaponFireRate;
	}
}
