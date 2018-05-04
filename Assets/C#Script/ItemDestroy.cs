using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroy : MonoBehaviour{
    //Unityちゃんのオブジェクト
    private GameObject unitychan;
    //Unityちゃんとカメラの距離
    private float difference;

    void Start(){
        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");
        //Unityちゃんとカメラの位置（z座標）の差を求める
        this.difference = unitychan.transform.position.z - this.transform.position.z;
    }

    void Update(){
        //Unityちゃんの位置に合わせて移動
        this.transform.position = new Vector3(0, this.transform.position.y, this.unitychan.transform.position.z - difference);
    }

    void OnTriggerEnter(Collider other){
        //アイテムのタグに当たった場合削除
        if (other.CompareTag("CarTag") || other.CompareTag("CoinTag") || other.CompareTag("TrafficConeTag")){
                Destroy(other.gameObject);
        }
        
    }

}
