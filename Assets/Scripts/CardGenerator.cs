using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardGenerator : MonoBehaviour
{
    public GameObject CardTemplate;
    public Sprite CoolKidSprite;
    void start()
    {
        for (int i = 0; i < 1; i++)
        {
            GameObject cardPrefab = Instantiate(CardTemplate, this.transform);
            cardPrefab.GetComponent<Card>().IWantToDie = true;
            cardPrefab.GetComponent<SpriteRenderer>().sprite = CoolKidSprite;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
