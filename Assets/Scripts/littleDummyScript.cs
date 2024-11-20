using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class littleDummyScript : MonoBehaviour
{
    public Animator animator;
    public int health = 100;
    public int damage = 25;
    public bool isDead = false;
    private Rigidbody rb;
    public ParticleSystem hitParticles;
    public Material dummyMaterial; 
    private string effectProperty = "_Effect";

    private float force = 0.7f;
    public CinemachineImpulseSource thisImpulse;

    public Material swordMaterial;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision other)
    {
        foreach (ContactPoint contact in other.contacts)
        {
            if (contact.otherCollider.CompareTag("Sword") && !isDead)
            {
                if (swordMaterial != null)
                {
                    swordMaterial.SetFloat(effectProperty, 1.0f); // Active l'effet pour l'épée
                }

                TakeDamage(damage);
                break;
            }
        }

        if (other.gameObject.CompareTag("Ground") && !isDead)
        {
            rb.constraints = RigidbodyConstraints.FreezeAll;
        }
    }

    void TakeDamage(int damageAmount)
    {
        health -= damageAmount;

        thisImpulse.GenerateImpulseWithForce(force);

        if (hitParticles != null)
        {
            hitParticles.Play();
        }

        if (dummyMaterial != null)
        {
            dummyMaterial.SetFloat(effectProperty, 0.5f);
        }

        if (health <= 0)
        {
            Die();
        }
        else
        {
            StartCoroutine(EndAnimation());
        }
    }

    void Die()
    {
        isDead = true;
        StartCoroutine(DestroyAfterDeath());
    }

    private void Update()
    {
    }

    IEnumerator DestroyAfterDeath()
    {
        animator.Play("died", -1, 0f);
        yield return new WaitForSeconds(animator.GetCurrentAnimatorStateInfo(0).length);
        if (swordMaterial != null)
        {
            swordMaterial.SetFloat(effectProperty, 0.0f);
        }
        if (dummyMaterial != null)
        {
            dummyMaterial.SetFloat(effectProperty, 0.0f);
        }
    }

    IEnumerator EndAnimation()
    {
        animator.SetBool("hit", true);
        yield return new WaitForSeconds(animator.GetCurrentAnimatorStateInfo(0).length);
        animator.SetBool("hit", false);

        if (dummyMaterial != null)
        {
            dummyMaterial.SetFloat(effectProperty, 0.0f);
        }

        if (swordMaterial != null)
        {
            swordMaterial.SetFloat(effectProperty, 0.0f); 
        }
    }

}
