using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour {

    public Image hpBar;

    public bool isGameClear = false;

    public int enemyCount;
    int destroyedEnemyNum = 0;

    public GameObject gameClearUI;
    public GameObject gameOverUI;
    public GameObject FadeUI;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if(isGameClear)
        {
            Invoke("FadeOut", 1.0f);
        }
	}

    public void SetHpGage(int hp)
    {
        hpBar.fillAmount = hp / 5.0f;
    }

    public void AddDestroyEnemyNum()
    {
        destroyedEnemyNum += 1;

        if(destroyedEnemyNum == enemyCount)
        {
            isGameClear = true;
            gameClearUI.GetComponent<TextFade>().gameClear = isGameClear;            
        }
    }

    public void GameOver()
    {
        gameOverUI.GetComponent<TextFadeGameOver>().isGameOver = true;
    }

    void FadeOut()
    {
        FadeUI.GetComponent<FadeController>().isFadeOut = true;
        isGameClear = false;
        Invoke("LoadStage2", 1.0f);
    }

    void LoadStage2()
    {
        SceneManager.LoadScene("Stage2");
    }
}
