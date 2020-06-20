using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleBurndown : MonoBehaviour
{
    public GameObject player;
    public Sprite fullStamina;
    public Sprite stamina80;
    public Sprite stamina60;
    public Sprite stamina40;
    public Sprite stamina20;
    

    private int lastStamina;
    private int staminaDivider;
    private SpriteRenderer sprite;
    // Start is called before the first frame update
    void Start()
    {
        lastStamina = player.GetComponent<PlayerMovement>().stamina;
        sprite = GetComponent<SpriteRenderer>();
        staminaDivider = lastStamina / 5;
    }

    // Update is called once per frame
    void Update()
    {
        int newStamina = player.GetComponent<PlayerMovement>().stamina;
        if (lastStamina != newStamina)
        {
            var spriteToUse = fullStamina;
            switch ( newStamina / staminaDivider)
            {
                case 5:
                    spriteToUse = fullStamina;
                    break;
                case 4:
                    spriteToUse = stamina80;
                    break;
                case 3:
                    spriteToUse = stamina60;
                    break;
                case 2:
                    spriteToUse = stamina40;
                    break;
                default:
                case 0:                    
                    spriteToUse = stamina20;
                    break;
            }

            sprite.sprite = spriteToUse;
        }
        
    }
}
