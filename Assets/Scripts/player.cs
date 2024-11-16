using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public string playerName = "";
    public int health;
    static public int playerCount = 0;



    public void InitializePlayer(string name, int initialHealth)
    {
        playerName = name;
        health = initialHealth;

        
        
        playerCount++;
 
    }



    public void Heal(int amount)
    {
        if((health + amount) > 100)
        {
            health = 100;
            Debug.Log(playerName + " Full health ");

        }
        else 
        {
            health += amount;
            Debug.Log(amount + " added to your health");

        }
        
        
    }


    public void Heal(bool fullRestore)
    {
        if(fullRestore)
        {
            health = 100;
        }

        Debug.Log( "your health is" + health);

    
    }

    public static void ShowPlayerCount()
    {
        Debug.Log("player Count is " + playerCount);


    }



}
