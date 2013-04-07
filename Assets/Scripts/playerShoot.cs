using UnityEngine;
using System.Collections;

public class playerShoot : MonoBehaviour
{
	private float nextFire;
	
	void Update ()
	{

		if(Input.GetButton("Fire1") && Time.time > nextFire && !sceneManager.playerWeaponOverheat)
		{
			playerBulletFire();
		}

	}

		
	private void playerBulletFire()
	{
		Instantiate(sceneManager.playerBullet,Transform.position,Transform.Rotation);
		sceneManager.playerWeaponHeat += 1;
		nextFire = Time.time + sceneManager.playerWeaponFireRate;
	}
}
