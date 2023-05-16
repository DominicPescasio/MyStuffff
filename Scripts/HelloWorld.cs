using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("HelloWorld");
        string name = ("Tree");
        int health = 20;
        float critChance = 0.2f;
        bool alive = true;
        Vector2 moveDir = new Vector2(4, 26);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
