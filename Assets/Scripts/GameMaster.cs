using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour {

    public int blockNum;
    public float nowTime;

    // Use this for initialization
    void Start() {
        nowTime = 0;
    }

    // Update is called once per frame
    void Update() {
        nowTime += Time.deltaTime;
        if (blockNum <= 0)
        {
            GameOver(nowTime.ToString("F0") + "秒");
        }

    }
    public void GameOver(string ResultMeseage){
        DataSender.resultMessage = ResultMeseage;
        SceneManager.LoadScene("Result");
    }
}
