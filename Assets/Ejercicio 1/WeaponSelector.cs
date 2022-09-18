using UnityEngine;
using UnityEngine.UI;

public class WeaponSelector : MonoBehaviour
{
    public WeaponManager weaponManager;
    
    public InputField weaponName;
    public void SelectWeapon()
    {
        weaponManager.EquipWeapon(weaponName.text);
    }
}
