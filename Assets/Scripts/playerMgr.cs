using UnityEngine;
using System.Collections;

public class playerMgr : MonoBehaviour 
{

	public GameObject player;
	public float spawnLocZ = -80;
	public int lives = 3;
	public int score;
	public int multiShot = 0;
	public float multiShotFuel = 0;
	public int escMenuOpen = 0;
	
	
	public void spawnPlayer()
	{
		if(lives > 1)
		{
			Instantiate(player, new Vector3 (0,0,spawnLocZ), Quaternion.identity);
			multiShotFuel = 0;
		}
		else
		{
			escMenuOpen = 1;
		}
		//Application.Quit();
		//spawn gameover ui
	}

	void Start () 
	{
		Time.timeScale = 1;
		Invoke("spawnPlayer", 0);
		InvokeRepeating("checkMultiShootFuel",1,1);
		//Instantiate(player, new Vector3 (0,0,spawnLocZ), Quaternion.identity);
		//Instantiate(player, new Vector3 (0,0,spawnLocZ), transform.rotation);
	}
	void Update ()
	{

		if(Input.GetKeyDown(KeyCode.Escape))
		{
			if (escMenuOpen == 0)
			{
				escMenuOpen = 1;
			}
			else
			{
				escMenuOpen = 0;
				Time.timeScale = 1;
			}
		}
		
		
		
		
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
	
	//gui stuff
	void OnGUI()
	{
		//score
		GUI.Label(new Rect(50,(Screen.height/2),60,20),"Score =");
		GUI.Label(new Rect(100,(Screen.height/2),60,20), score.ToString());
		//Lives
		GUI.Label(new Rect(50,((Screen.height/2)-20),60,20),"Lives =");
		GUI.Label(new Rect(100,((Screen.height/2)-20),60,20), lives.ToString());
		//MultiShot
		GUI.Label(new Rect(50,((Screen.height/2)-40),60,20),"MultiShot =");
		GUI.Label(new Rect(140,((Screen.height/2)-40),60,20), multiShotFuel.ToString());
		
		//esc menu
		//if(Input.GetKey(KeyCode.Escape))
		//{
			
		//}
		
		//dead screen
		if(escMenuOpen == 1)
		{
			Time.timeScale = 0;
			if(GUI.Button (new Rect((Screen.width/2),(Screen.height/2),60,20),"Restart"))
			{
				Application.LoadLevel("character test");
				lives = 3;
			}

			if(GUI.Button (new Rect((Screen.width/2),((Screen.height/2)-20),60,20),"Quit"))
			{
				Application.Quit();
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















