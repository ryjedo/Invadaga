using UnityEngine;
using System.Collections;

public class enemyShootB : MonoBehaviour 
{

	public GameObject bullet;
	public float enemyShootTimerStart = 0.2F;
	public float enemyShootTimerRepeat = 0.13F;
	public int enemyBurstShotQty = 0;

	void Start() 
	{
		InvokeRepeating("enemyBurstFire", enemyShootTimerStart, enemyShootTimerRepeat);
		InvokeRepeating("reloadAmmo", 0, 4);
	}
	
	void enemyBurstFire()
	{
		if (enemyBurstShotQty > 0)
		{
			Instantiate(bullet,transform.position,transform.rotation);
			enemyBurstShotQty -= 1;
		}
	}
	
	void reloadAmmo()
	{
		enemyBurstShotQty = 5;
	}
}