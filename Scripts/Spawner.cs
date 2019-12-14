using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    public float MaxRadius = 1f;
    public float Interval = 5f;
    public int max_Zombies = 100;
    public GameObject ObjToSpawn = null;
    private Transform Origin = null;

    public Text zombie_num;
    static int total_zombies = 0;

    void Awake()
    {
        Origin = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        Origin.GetComponent<SpriteRenderer>().enabled = true;
        Origin.GetComponent<Movement>().enabled = true;
        Origin.GetComponent<CircleCollider2D>().enabled = true;
        Health.HP = 100;
        total_zombies = 0;
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 0f, Interval);
    }
    
    void Spawn()
    {
        if (Origin == null || total_zombies >= max_Zombies) return;

        Vector3 SpawnPos = Origin.position + UnityEngine.Random.onUnitSphere * MaxRadius;
        SpawnPos = new Vector3(SpawnPos.x, 0f, SpawnPos.z);
        Instantiate(ObjToSpawn, SpawnPos, Quaternion.identity);
        total_zombies++;
        zombie_num.text = "Zombies: " + total_zombies;
        if (total_zombies == max_Zombies)
            this.GetComponent<Countdown>().enabled = true;
    }
}
