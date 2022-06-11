using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisions : MonoBehaviour
{
    public int  Player_score=0;
    //public GameObject ObjectTo_Disappear;
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
    void OnCollisionEnter(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            Debug.DrawRay(contact.point, contact.normal, Color.green,10,false);
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
