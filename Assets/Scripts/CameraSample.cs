using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSample : MonoBehaviour
{

    private GameObject Player;   //プレイヤー情報格納用
    private Vector3 offset;      //相対距離取得用
                                 //回転させるスピード
    public float rotateSpeed = 3.0f;

    // Use this for initialization
    void Start()
    {

        //unitychanの情報を取得
        this.Player = GameObject.Find("Mamechan_Ra");

        // MainCamera(自分自身)とplayerとの相対距離を求める
        offset = transform.position - Player.transform.position;

    }

    // Update is called once per frame
    void Update()
    {

        //新しいトランスフォームの値を代入する
        transform.position = Player.transform.position + offset;

    }
}