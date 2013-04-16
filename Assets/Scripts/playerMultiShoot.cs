using UnityEngine;
using System.Collections;

public class playerMultiShoot : MonoBehaviour
{
	private float nextFire;
	
	void Update ()
	{

		if(Input.GetButton("Fire1") && Time.time > nextFire && sceneManager.playerMultiShotOn && !sceneManager.playerWeaponOverheat)
		{
			playerBulletFire();
		}

	}
	private void playerBulletFire()
	{
			Instantiate(sceneManager.playerBullet,transform.position,transform.rotation);
			sceneManager.playerWeaponHeat += 1;
			nextFire = Time.time + sceneManager.playerWeaponFireRate;
	}
}
