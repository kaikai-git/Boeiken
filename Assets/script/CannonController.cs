
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class CannonController : MonoBehaviour
{
    

    //bulletプレハブ
    public GameObject bullet;
    public GameObject bullet2;
    //弾が生成されるポジションを保有するゲームオブジェクト
    public GameObject bulletPos;
    public GameObject bulletPos1;
    public GameObject bulletPos2;
    public GameObject bulletPos3;
    public GameObject bulletPos5;
    public GameObject bulletPos6;
    public GameObject bulletPos7;
    public GameObject bulletPos8;
    public GameObject bulletPos9;
    //弾丸のスピード
    public float speed = 3f;

    //敵生成時間間隔
    private float interval;
    //経過時間
    private float time = 0f;

    // Start is called before the first frame update
    void Start()
    {
        //時間間隔を決定する
        interval = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        //時間計測
        time += Time.deltaTime;
        if (time > interval)
        {
            //ballをインスタンス化して発射
            GameObject createdBullet = Instantiate(bullet) as GameObject;
            createdBullet.transform.position = bulletPos.transform.position;

            //発射ベクトル
            Vector3 force;
            //発射の向きと速度を決定
            force = bulletPos.transform.forward * speed;
            // Rigidbodyに力を加えて発射
            createdBullet.GetComponent<Rigidbody>().AddForce(force);
            time = 0f;
            Debug.Log("たかし");

        }
        //スペースが押されたとき
        if (Input.GetMouseButtonDown(0))
        {
            //ballをインスタンス化して発射
            GameObject createdBullet = Instantiate(bullet) as GameObject;
            createdBullet.transform.position = bulletPos2.transform.position;

            //発射ベクトル
            Vector3 force;
            //発射の向きと速度を決定
            force = bulletPos2.transform.forward * speed;
            // Rigidbodyに力を加えて発射
            createdBullet.GetComponent<Rigidbody>().AddForce(force);
        }

        if (Input.GetMouseButtonDown(0))
        {
            //ballをインスタンス化して発射
            GameObject createdBullet = Instantiate(bullet) as GameObject;
            createdBullet.transform.position = bulletPos1.transform.position;

            //発射ベクトル
            Vector3 force;
            //発射の向きと速度を決定
            force = bulletPos1.transform.forward * speed;
            // Rigidbodyに力を加えて発射
            createdBullet.GetComponent<Rigidbody>().AddForce(force);


        }

        if (Input.GetMouseButtonDown(0))
        {
            //ballをインスタンス化して発射
            GameObject createdBullet = Instantiate(bullet) as GameObject;
            createdBullet.transform.position = bulletPos3.transform.position;

            //発射ベクトル
            Vector3 force;
            //発射の向きと速度を決定
            force = bulletPos3.transform.forward * speed;
            // Rigidbodyに力を加えて発射
            createdBullet.GetComponent<Rigidbody>().AddForce(force);


        }

        if (Input.GetMouseButtonDown(0))
        {
            //ballをインスタンス化して発射
            GameObject createdBullet = Instantiate(bullet) as GameObject;
            createdBullet.transform.position = bulletPos5.transform.position;

            //発射ベクトル
            Vector3 force;
            //発射の向きと速度を決定
            force = bulletPos5.transform.forward * speed;
            // Rigidbodyに力を加えて発射
            createdBullet.GetComponent<Rigidbody>().AddForce(force);


        }

        if (Input.GetMouseButtonDown(0))
        {
            //ballをインスタンス化して発射
            GameObject createdBullet = Instantiate(bullet) as GameObject;
            createdBullet.transform.position = bulletPos6.transform.position;

            //発射ベクトル
            Vector3 force;
            //発射の向きと速度を決定
            force = bulletPos6.transform.forward * speed;
            // Rigidbodyに力を加えて発射
            createdBullet.GetComponent<Rigidbody>().AddForce(force);


        }

        if (Input.GetMouseButtonDown(0))
        {
            //ballをインスタンス化して発射
            GameObject createdBullet = Instantiate(bullet) as GameObject;
            createdBullet.transform.position = bulletPos7.transform.position;

            //発射ベクトル
            Vector3 force;
            //発射の向きと速度を決定
            force = bulletPos7.transform.forward * speed;
            // Rigidbodyに力を加えて発射
            createdBullet.GetComponent<Rigidbody>().AddForce(force);


        }

        if (Input.GetMouseButtonDown(0))
        {
            //ballをインスタンス化して発射
            GameObject createdBullet = Instantiate(bullet) as GameObject;
            createdBullet.transform.position = bulletPos8.transform.position;

            //発射ベクトル
            Vector3 force;
            //発射の向きと速度を決定
            force = bulletPos8.transform.forward * speed;
            // Rigidbodyに力を加えて発射
            createdBullet.GetComponent<Rigidbody>().AddForce(force);


        }

        if (Input.GetMouseButtonDown(0))
        {
            //ballをインスタンス化して発射
            GameObject createdBullet = Instantiate(bullet) as GameObject;
            createdBullet.transform.position = bulletPos9.transform.position;

            //発射ベクトル
            Vector3 force;
            //発射の向きと速度を決定
            force = bulletPos9.transform.forward * speed;
            // Rigidbodyに力を加えて発射
            createdBullet.GetComponent<Rigidbody>().AddForce(force);


        }
    }
}