using UnityEngine;
using System.Collections;

public class enemyShoot : MonoBehaviour 
{

	public GameObject bullet;
	public float enemyShootTimer = 1.5F;

	void Start() 
	{
		InvokeRepeating("enemyFire", 1F, enemyShootTimer);
	}
	
	void enemyFire()
	{
		Instantiate(bullet,transform.position,transform.rotation);
	}

}