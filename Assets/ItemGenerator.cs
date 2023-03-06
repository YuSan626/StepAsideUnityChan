using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    //carPrefab　 車
    public GameObject carPrefab;
    //coinPrefab　コイン
    public GameObject coinPrefab;
    //cornPrefab　コーン
    public GameObject conePrefab;

    //Unityちゃんのオブジェクト
    private GameObject unitychan;

    //スタート地点
    private int startPos = 80;
    //ゴール地点
    private int goalPos = 360;

    //アイテムを出すX方向の範囲　
    private float posRange = 3.4f;

    private float unitychanB;
    


    // Start is called before the first frame update
    void Start()
    {
        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");

  
    }

    // Update is called once per frame
    void Update()
    {




        //一定の距離ごとにアイテムを生成 
        if (unitychan.transform.position.z- unitychanB > 15)
        { //どのアイテムを出すかをランダムに設定
            int num = Random.Range(1, 11);
            if (num <= 2)
            {
                //コーンをX軸方向に一直線に生成
                for (float j = -1; j <= 1; j += 0.4f)
                {
                    GameObject cone = Instantiate(conePrefab);
                    cone.transform.position = new Vector3(4 * j, cone.transform.position.y, unitychan.transform.position.z+40);
                }
            }
            else
            {
                //レーンごとにアイテムを生成
                for (int j = -1; j <= 1; j++)
                {
                    //アイテムの種類を決める
                    int item = Random.Range(1, 11);

                    //アイテムを置くｚ座標のオフセットをランダムに設定
                    int offsetZ = Random.Range(-5, 6);


                    //60％コインを配置 : 30％車配置 ： 10％何もなし
                    if (1 <= item && item <= 6)
                    {
                        //コインを生成
                        GameObject coin = Instantiate(coinPrefab);
                        coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, unitychan.transform.position.z + 40 + offsetZ);
                    }
                    else if (7 <= item && item <= 9)
                    {
                        //車を生成
                        GameObject car = Instantiate(carPrefab);
                        car.transform.position = new Vector3(posRange * j, car.transform.position.y, unitychan.transform.position.z + 40 + offsetZ);
                    }
                }
            }

            this.unitychanB = unitychan.transform.position.z;
        }




          
        {
           
        }



    }
}
