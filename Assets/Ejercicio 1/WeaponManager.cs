using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
public class WeaponManager : MonoBehaviour
{
    public string defaultWeapon;

    public string actualWeapon;

    public InputField weaponName;

    public List<GameObject> weapons;
    private void Awake()
    {
        List<GameObject> weaponsResources;
        weaponsResources = Resources.LoadAll<GameObject>("Weapons").ToList();
        foreach (GameObject weapon in weaponsResources)
        {
            GameObject instance = Instantiate(weapon);
            weapons.Add(instance);
            instance.SetActive(false);

        }
        actualWeapon = defaultWeapon;
    }

    public void EquipWeapon(string name)
    {
        //unequip actual weapon
        GameObject actual = weapons.Find(item => item.GetComponent<Weapon>().name == actualWeapon);
        actual?.SetActive(false);

        //find new weapon and equip it
        GameObject weapon = weapons.Find(item => item.GetComponent<Weapon>().name == name);
        if (weapon != null)
        {
            weapon.SetActive(true);
            actualWeapon = weapon.GetComponent<Weapon>().name;
        }
        else //equip default weapon
        {
            weapon = weapons.Find(item => item.GetComponent<Weapon>().name == defaultWeapon);
            weapon?.SetActive(true);
            actualWeapon = defaultWeapon;
        }
    }
    public void SelectWeapon()
    {
        EquipWeapon(weaponName.text);
    }
}
