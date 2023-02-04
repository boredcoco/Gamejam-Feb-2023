using UnityEngine;

public class Item : MonoBehaviour
{

    public string collectable_name;
    public string description;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(gameObject);
            CollectItem(collectable_name, 1);
        }
    }

    public void CollectItem(string KeyName, int Value)
    {
        PlayerPrefs.SetInt(KeyName, Value);
    }
}
