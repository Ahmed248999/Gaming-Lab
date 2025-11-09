using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{

    public Transform enemy;

    public Transform spwanPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void RespawnEnemy(){
        Instantiate(enemy,spwanPoint.transform.position,spwanPoint.transform.rotation);
    }

    void OnTriggerEnter2D(Collider2D other){

        if (other.gameObject.tag =="Player"){
            RespawnEnemy();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
