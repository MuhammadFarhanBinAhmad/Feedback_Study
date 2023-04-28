using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    [SerializeField] Rigidbody2D the_RB;
    [SerializeField] GameObject effect_Hit;

    [SerializeField] float bullet_Speed;
    [SerializeField] float bullet_Damage;

    FeedbackManager s_FeedbackManager;

    private void Start()
    {
        s_FeedbackManager = FindObjectOfType<FeedbackManager>();
    }

    void Update()
    {
        the_RB.velocity = transform.up * bullet_Speed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(!s_FeedbackManager.ProjectileExplosionActivate)
        {
            GameObject e = Instantiate(effect_Hit, transform.position, effect_Hit.transform.rotation);
        }

        if (other.GetComponent<EnemyHealth>() != null)
        {
            other.GetComponent<EnemyHealth>().TakingDamage(bullet_Damage);
            Destroy(gameObject);
        }
    }
}
