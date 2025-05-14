using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public bool Empty1 = true;
    public bool Empty2 = true;
    public bool Empty3 = true;
    [SerializeField] List<ScriptableCard> scripts;
    [SerializeField] GameObject Card_Prefab;
    [SerializeField] Transform Canva;
    public void SpawnCard()
    {
        if (scripts.Count != 0)
        {
            int rand = Random.Range(0, scripts.Count);
            GameObject card = Instantiate(Card_Prefab, new Vector3(1740, 200, 0), Quaternion.identity, Canva);
            GameObject child = card.transform.Find("CardImage").gameObject;
            ShowCard showCard = child.GetComponent<ShowCard>();
            showCard.cards = scripts[rand];
            scripts.Remove(scripts[rand]);
        }
        else
        {
            return;
        }
    }
}
