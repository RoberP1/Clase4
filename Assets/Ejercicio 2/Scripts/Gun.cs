using UnityEngine;
using UnityEngine.UI;

public class Gun : MonoBehaviour
{
    Animator animator;

    public Text ammoText;

    public int maxBullets;
    
    public int currentBullets;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        UpdateAmmoUI();
    }

    public void Shoot()
    {
        if (currentBullets > 0)
        {
            animator.SetTrigger("Shoot");
            animator.SetBool("Reload", false);
            currentBullets--;
            Debug.Log("Shoot");
            UpdateAmmoUI();
        }
    }
    public void FinishShoot()
    {
        if (currentBullets == 0) StartReload();
    }

    public void StartReload()
    {
        if (currentBullets < maxBullets)
        {
            animator.SetBool("Reload", true);
        }
    }
    public void FinishReload()
    {
        currentBullets++;
        Debug.Log("Reload");
        UpdateAmmoUI();
        if (currentBullets == maxBullets)
        {
            animator.SetBool("Reload", false);
        }
    }
    private void UpdateAmmoUI()
    {
        ammoText.text = currentBullets.ToString();
    }
}
