using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnemyHealth : MonoBehaviour
{
    public int health = 2;
    EnemyKeyCounter enemyKeyCounter;

    // Start is called before the first frame update
    void Start()
    {
        enemyKeyCounter= GameObject.Find("EKC").GetComponent<EnemyKeyCounter>();
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {

            Destroy(gameObject);
            enemyKeyCounter.AddKill();
        }
    }




}


