using UnityEngine;
using System.Collections;

public class playerMultiShoot : MonoBehaviour
{
	private float nextFire;
	public GameObject bullet;
	public float playerWeaponFireRate;

	void Update ()
	{

		if(Input.GetButton("Fire1") && Time.time > nextFire && GameObject.FindWithTag("sceneManager").GetComponent<playerMgr>().multiShot == 1)// && !sceneManager.playerWeaponOverheat).
		{
			playerBulletFire();
		}

	}
	private void playerBulletFire()
	{
			Instantiate(bullet,transform.position,transform.rotation);
			//sceneManager.playerWeaponHeat += 1;
			nextFire = Time.time + playerWeaponFireRate;
	}
}
