using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie_Chase : MonoBehaviour
{
    public float Chase_Speed = 10;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, Chase_Speed * Time.deltaTime);
    }
}
