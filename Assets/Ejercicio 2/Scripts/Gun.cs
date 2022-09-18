using UnityEngine;
using UnityEngine.UI;

public class Gun : MonoBehaviour
{
    Animator animator;

    public Text ammoText;

    public int maxBullets;
    
    public int currentBullets;

    private bool canShoot;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        UpdateAmmoUI();
        canShoot = true;
    }

    public void Shoot()
    {
        if (currentBullets > 0 && canShoot)
        {
            animator.SetTrigger("Shoot");
            
            canShoot = false;
            currentBullets--;
            UpdateAmmoUI();
            
            Debug.Log("Shoot");
        }
    }
    public void FinishShoot()
    {
        canShoot = true;
        if (currentBullets == 0) StartReload();
    }

    public void StartReload()
    {
        if (currentBullets < maxBullets)
            animator.SetTrigger("Reload");
    }
    public void FinishReload()
    {
        currentBullets++;
        UpdateAmmoUI();

        Debug.Log("Reload, current bullets = " + currentBullets);

        if (currentBullets <= maxBullets) StartReload();
    }
    private void UpdateAmmoUI() =>
        ammoText.text = currentBullets.ToString();
}
