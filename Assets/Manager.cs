using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    [SerializeField] List<ScriptableCard> scripts;
    [SerializeField] GameObject Card_Prefab;
    public void SpawnCard()
    {
        if (scripts.Count != 0)
        {
            int rand = Random.Range(0, scripts.Count);
            GameObject card = Instantiate(Card_Prefab);
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
