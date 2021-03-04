using UnityEngine;
using UnityEngine.SceneManagement;

public class VirusSceneManager : MonoBehaviour
{
	int enemycount;
	bool isEnemy;
	public GameObject level_complete;
	public int unlock;
	public GameWon gameWon;
	 

	void Awake()
	{
		enemycount = 0;
		isEnemy = false;
	}
	void Start()
	{
		 

		unlock = SceneManager.GetActiveScene().buildIndex + 1;

		level_complete.SetActive(false);
	}

	void Update()
	{
		if (enemycount == 1) isEnemy = true;

		if (isEnemy)
		{
			if (enemycount < 1)
			{
				//now load your next scene

				PlayerPrefs.SetInt("levelReached", unlock);
				gameWon.PlayerWon();
				level_complete.SetActive(true);
				 
			}
		}
	}

	public void increaseEnemyCount(int n)
	{
		enemycount += n;
	}

	public void decreaseEnemyCount(int n)
	{
		enemycount -= n;
	}
}