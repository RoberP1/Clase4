using UnityEngine;
using UnityEngine.UI;

public class Dice : MonoBehaviour
{
    [SerializeField] private int sides;

    [SerializeField] private int totalBonus;

    [SerializeField] private Text rollText;

    [SerializeField] private Text totalText;
    public void Roll()
    {
        int result = Random.Range(1, sides + 1);
        
        rollText.text = result.ToString();
        
        result += totalBonus;
        
        totalText.text = "Total = " + result.ToString();
        
        Debug.Log(result);
    }

    public void SetBonus(int value)
    {
        totalBonus = value;
    }

    private void OnEnable()
    {
        Bonus.OnBonusChanged += SetBonus;
    }
    private void OnDisable()
    {
        Bonus.OnBonusChanged -= SetBonus;
    }
    
}
