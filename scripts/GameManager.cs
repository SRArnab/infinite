using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public static GameManager instancce;
	public int count = 0;
	public Text countText;

    void Start()
    {
		count = 0;
		count = count + 1;
		setCountText();
    }

    void Update()
    {
		
	}
	void setCountText()
	{
		countText.text = "Point: " + count.ToString();
	}
	public void GameOver()
	{
		Debug.Log("Game Over!!");
		//MenuContainer.setActive(true);
	}
}
