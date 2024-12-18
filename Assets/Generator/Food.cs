using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    [SerializeField]
    public string Type = "Apple"; // 食べ物の種類（例: "Apple", "Banana")
    [SerializeField]
    int score;

    // Start is called before the first frame update
    void Start(){}

    // Update is called once per frame
    void Update(){}

    // 食べ物を食べるときの効果を定義
    public void Consume()
    {
        Debug.Log($"You ate a {Type}!");
        Destroy(gameObject); // 食べ物オブジェクトを削除
    }

    public int changeScore(){
        Destroy(gameObject); //食べ物オブジェクトを削除
        return this.score;
    }

    private void OnCollisionEnter(Collision other) {
        PlayerController plC = other.gameObject.GetComponent<PlayerController>();
        if(plC != null){
            Rigidbody rb = gameObject.GetComponent<Rigidbody>();
            Collider cd = gameObject.GetComponent<Collider>();

            rb.isKinematic = true ;
            rb.useGravity = false ;
            cd.isTrigger = true;
        }
    }
}
