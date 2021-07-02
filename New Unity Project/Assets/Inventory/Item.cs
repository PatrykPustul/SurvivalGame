using UnityEngine;
[CreateAssetMenu(fileName ="Ekwipunek", menuName ="Ekwipunek/NewItem")]
public class Item : ScriptableObject
{
    public int id;
    public string Name = "NewItem";
    public Sprite sprite = null;
    public TypeOfItem typeOfItem = TypeOfItem.other;

    public enum TypeOfItem
    {
        food,
        tool,
        build,
        ammo,
        weapon,
        other,
    }
}
