using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Unityが準備しているUIの機能を使う
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    //ボールが見える可能性のあるZ軸の最小値
    //フィールド上でのゲームオーバーのラインを決める
    private float visiblePosZ = -6.5f;

    //ゲームオーバを表示するテキスト
    private GameObject gameoverText;

    // Start is called before the first frame update
    void Start()
    {
        //シーン中のGameOverTextオブジェクトを取得
        this.gameoverText = GameObject.Find("GameOverText");
    }

    // Update is called once per frame
    void Update()
    {

        //ボールが画面外に出た場合
        if (this.transform.position.z < this.visiblePosZ)
        {
            //GameoverTextにゲームオーバを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }

    }
}
