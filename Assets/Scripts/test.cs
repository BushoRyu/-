using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    private GameObject Player = null;
    private Vector3 offset = Vector3.zero;

    //回転させるスピード
    public float rotateSpeed = 3.0f;


    void Start()
    {
        print(Random.Range(1.0f, 100.0f));

        Player = GameObject.FindGameObjectWithTag("Player");
        offset = transform.position - Player.transform.position;
    }

    void Update()
    {

        //回転させる角度
        float angle = Input.GetAxis("Hori") * rotateSpeed;

        //プレイヤー位置情報
        Vector3 playerPos = Player.transform.position;

        //カメラを回転させる
        transform.RotateAround(playerPos, Vector3.up, angle);
    }
    void LateUpdate()
    {
        Vector3 newPosition = transform.position;
        newPosition.x = Player.transform.position.x + offset.x;
        newPosition.y = Player.transform.position.y + offset.y;
        newPosition.z = Player.transform.position.z + offset.z;
        transform.position = Vector3.Lerp(transform.position, newPosition, 5.0f * Time.deltaTime);
    }
}
