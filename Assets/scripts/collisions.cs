using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class collisions : MonoBehaviour
{
    public TMP_Text tex1;
    public int  Player_score=0;
    public void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("bash"))
        {
            
            Debug.Log("you destroy");
            Destroy(collision.gameObject);
            Player_score += 10;
            Debug.Log(Player_score);
        }
        if (collision.CompareTag("killer"))
        {
            Debug.Log("you die");
            Destroy(gameObject);
            this.gameObject.SetActive(false);
            Player_score = 0;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
