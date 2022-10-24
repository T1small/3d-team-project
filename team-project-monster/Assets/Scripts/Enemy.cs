using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float speed =1.5f;
    [SerializeField]
    private GameObject player;
    void Start()
    {
        player=GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Swarm();
    }
    private void Swarm()
    {
        transform.position=Vector2.MoveTowards(transform.position,player.transform.position,speed*Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D Collider)
    {
        if(Collider.CompareTag("Player"))
        {
            Destroy(gameObject,0.5f);
        }
    }
}
