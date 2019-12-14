using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zed_Bite : MonoBehaviour
{
    public Text HP_Text;
    public int bite_dmg = 5;

    void Awake()
    {
        HP_Text = GameObject.FindGameObjectWithTag("HP_Text").GetComponent<Text>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Health.HP -= bite_dmg;
            if (HP_Text != null)
                if (Health.HP >= 0)
                    HP_Text.text = "Health: " + Health.HP;
            StartCoroutine(Bite_Stop());
        }

    }
    IEnumerator Bite_Stop()
    {
        yield return new WaitForSeconds(1);
        Debug.Log("Bite! HP: " + Health.HP);
    }
}
