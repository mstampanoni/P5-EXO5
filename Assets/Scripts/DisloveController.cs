using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.VFX;

public class DissolveController : MonoBehaviour
{
    [SerializeField] private Material dissolveMaterial;
    [SerializeField] private VisualEffect dissolveVisualEffect;

    private float dissolveAmount = 0f; 
    private float timer = 0f;

    private littleDummyScript dummyScript; 
    private Animator animator;
    private float dissolveDuration;

    private bool isCoroutineRunning;

    void Start()
    {
        isCoroutineRunning = false;
        dissolveMaterial.SetFloat("_DissolveAmount", 0f);
        dummyScript = GetComponent<littleDummyScript>();
        animator = GetComponent<Animator>();

        if (animator != null && animator.HasState(0, Animator.StringToHash("died")))
        {
            dissolveDuration = animator.runtimeAnimatorController.animationClips.FirstOrDefault(clip => clip.name == "died")?.length ?? 1f;
        }
        else
        {
            dissolveDuration = 1f;
        }
    }

    void Update()
    {
        if (dummyScript != null && dummyScript.isDead)
        {
            if (dissolveVisualEffect != null)
            {
                dissolveVisualEffect.Play();
            }

            timer += Time.deltaTime;
            dissolveAmount = Mathf.Clamp01(timer / dissolveDuration);
            dissolveMaterial.SetFloat("_DissolveAmount", dissolveAmount);
            if (isCoroutineRunning)
            {
                StartCoroutine(OnDissolveComplete());
            }
        }
    }

    IEnumerator OnDissolveComplete()
    {
        isCoroutineRunning = true;
        yield return new WaitForSeconds(animator.GetCurrentAnimatorStateInfo(0).length);
        gameObject.SetActive(false);
        dissolveMaterial.SetFloat("_DissolveAmount", 0f);
        Destroy(gameObject);
    }
}
