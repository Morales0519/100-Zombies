using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public static int HP = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Health.HP <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        this.GetComponent<SpriteRenderer>().enabled = false;
        this.GetComponent<Movement>().enabled = false;
        this.GetComponent<CircleCollider2D>().enabled = false;
        StartCoroutine(Waiting());
    }

    IEnumerator Waiting()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
