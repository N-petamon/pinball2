using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    public GameObject scoreText; 
    int score = 0;

    //ボールが見える可能性のあるz軸の最大値
    private float visiblePosZ = -6.5f;

    //ゲームオーバを表示するテキスト
    private GameObject gameoverText;

    // Use this for initialization
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
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "LargeCloudTag")
        {
            score += 20;
        }
        else if (collision.gameObject.tag == "SmallCloudTag")
        {
            score += 15;
        }
        else if (collision.gameObject.tag == "LargeStarTag")
        {
            score += 10;
        }
        else if (collision.gameObject.tag == "SmallStarTag")
        {
            score += 5;
        }

        scoreText.GetComponent<Text>().text = "" + score;
    }
}
