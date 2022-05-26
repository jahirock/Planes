using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : MonoBehaviour
{
    public GameObject explosion;

    private void OnEnable()
    {
        //GameManager.OnUpdateScore += Deactivate;
    }

    private void OnDisable()
    {
        GameManager.OnUpdateScore.Invoke();
        //GameManager.OnUpdateScore -= Deactivate;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player") || collision.CompareTag("Bullet"))
        {
            GameObject go = ObjectPooler.instance.GetPoolObject("Explosion");
            go.transform.position = transform.position;
            go.SetActive(true);

            Deactivate();
        }
    }

    private void Deactivate()
    {
        //destroy
        gameObject.SetActive(false);
    }
}
