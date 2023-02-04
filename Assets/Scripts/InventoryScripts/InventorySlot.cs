using UnityEngine;
using TMPro;

public class InventorySlot : MonoBehaviour
{

    public string description;

    public TMP_Text lore;

    public void updateLore()
    {
        lore.text = description;
    }
}
