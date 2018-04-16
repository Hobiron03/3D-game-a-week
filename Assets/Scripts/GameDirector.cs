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
    public GameObject Barrier;

    public GameObject sound;
    public Button button;
	// Use this for initialization
	
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
        Debug.Log(destroyedEnemyNum);

        if(destroyedEnemyNum == enemyCount -1 && SceneManager.GetActiveScene().name == "Stage3")
        {
            Barrier.GetComponent<Barrier>().DestroyBarrier();
        }

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

        switch (SceneManager.GetActiveScene().name)
        {
            case "Stage1":
                Invoke("LoadStage2", 1.0f);
                break;

            case "Stage2":
                Invoke("LoadStage3", 1.0f);
                break;

            case "Stage3":
                Invoke("LoadClear", 1.0f);
                break;

            default:
                break;

        }
        
    }

    void LoadStage2()
    {
        SceneManager.LoadScene("Stage2");
    }

    void LoadStage3()
    {
        SceneManager.LoadScene("Stage3");
    }

    void LoadClear()
    {
        SceneManager.LoadScene("Clear");
    }

    public void Retry()
    {
        SceneManager.LoadScene("Stage1");
    
    }
}
