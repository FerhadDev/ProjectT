using UnityEngine;

[CreateAssetMenu(fileName = "New Card" , menuName = "Card")]
public class ScriptableCard : ScriptableObject
{
    public string _CardName;
    public string _CardDescription;
    public int _EnergyUse;
    public int _CardPrice;
    public int _CardDamage;
    public bool _Protect;
    public Sprite _CardPhoto;
}
