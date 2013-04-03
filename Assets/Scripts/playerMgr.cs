using UnityEngine;
using System.Collections;

public class playerMgr : MonoBehaviour 
{

	public GameObject player;
	public float spawnLocZ = -80;
	public int lives = 2;
	public int score;
	public int multiShot = 0;
	public float multiShotFuel = 0;
	
	
	
	public void spawnPlayer()
	{
		if(lives > 0)
			Instantiate(player, new Vector3 (0,0,spawnLocZ), Quaternion.identity);
			multiShotFuel = 0;
		//Application.Quit();
		//spawn gameover ui
	}

	void Start () 
	{
		Invoke("spawnPlayer", 0);
		InvokeRepeating("checkMultiShootFuel",1,1);
		//Instantiate(player, new Vector3 (0,0,spawnLocZ), Quaternion.identity);
		//Instantiate(player, new Vector3 (0,0,spawnLocZ), transform.rotation);
	}
	void Update ()
	{
		if(multiShotFuel > 0)
		{
			if(multiShot < 1)
			{
				Invoke("enableMultiShot",0);
			}
		}
		if (multiShotFuel < 1)
		{
			if(multiShot > 0)
			{
				Invoke("disableMultiShot",0);
			}
		}
	}

	public void enableMultiShot()
	{
		multiShot = 1;
	}

	public void disableMultiShot()
	{
		multiShot = 0;
	}

	public void checkMultiShootFuel()
	{
		if(multiShotFuel > 0)
		{
			multiShotFuel -= 1;
		}
	}






}















