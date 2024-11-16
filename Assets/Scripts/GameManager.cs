using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    void Start()
    {
        Player player1 = new Player();
        Player player2 = new Player();

        player1.InitializePlayer("ahmed",70);
        player2.InitializePlayer("khaled",50);

        player1.Heal(10);

        player1.Heal(true);

        Player.ShowPlayerCount();
    }

}
