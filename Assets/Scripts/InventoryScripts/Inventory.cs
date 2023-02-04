using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Inventory : MonoBehaviour
{
	private static bool inventory_active = false;
	public static Inventory instance;
	public GameObject inventory_menu;

	public int space = 6;  // Amount of item spaces

	[SerializeField] public GameObject inventory_slot0;
	[SerializeField] public GameObject inventory_slot1;
	[SerializeField] public GameObject inventory_slot2;
	[SerializeField] public GameObject inventory_slot3;
	[SerializeField] public GameObject inventory_slot4;
	[SerializeField] public GameObject inventory_slot5;

	[SerializeField] public string item0;
	[SerializeField] public string item1;
	[SerializeField] public string item2;
	[SerializeField] public string item3;
	[SerializeField] public string item4;
	[SerializeField] public string item5;

	[SerializeField] private TMP_Text lore;

	void Awake()
	{
		instance = this;

		updateInventory();
	}

	void Update()
	{
		if (PlayerPrefs.GetInt(item0) == 1)
		{
			Debug.Log("test");

		}

		// Open and close inventory
		if (Input.GetKeyDown(KeyCode.I))
		{
			inventory_menu.SetActive(!inventory_active);
			inventory_active = !inventory_active;
			lore.text = "";
		}

		// Check what items have been collected
		updateInventory();
	}

        private void updateInventory()
        {

			if (PlayerPrefs.GetInt(item0) == 1)
			{
				Debug.Log("test");

				Image icon = inventory_slot0.GetComponent<Image>();
				icon.enabled = true;
			}

			if (PlayerPrefs.GetInt(item1) == 1)
			{
				Image icon = inventory_slot1.GetComponent<Image>();
				icon.enabled = true;
			}

			if (PlayerPrefs.GetInt(item2) == 1)
			{
				Image icon = inventory_slot2.GetComponent<Image>();
				icon.enabled = true;
			}

			if (PlayerPrefs.GetInt(item3) == 1)
			{
				Image icon = inventory_slot3.GetComponent<Image>();
				icon.enabled = true;

			}

			if (PlayerPrefs.GetInt(item4) == 1)
			{
				Image icon = inventory_slot4.GetComponent<Image>();
				icon.enabled = true;
			}

			if (PlayerPrefs.GetInt(item5) == 1)
			{
				Image icon = inventory_slot5.GetComponent<Image>();
				icon.enabled = true;
			}
		}
    
}
