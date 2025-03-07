using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public TextMeshProUGUI messageCounterText;
	public GameObject GameOverpanel;
	int messageCount;
		
		
	// Start is called before the first frame update
	void Start()
	{
		  PlayerPrefs.SetInt("messageCount" , 0 );
        
	}

	// Update is called once per frame
	void Update()
	{
		messageCount = PlayerPrefs.GetInt("messageCount" , 0 );
		messageCounterText.text = messageCount.ToString();
	}
	
	public void GameOver()
	{
		GameOverpanel.SetActive(true);
	}
	
	
	public void PlayAgain()
	{
		SceneManager.LoadScene(0);
		
	}
}
