using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public Team team { get; set; }
    public BoardObjectManager boardObjectManager { get; set; }
    public bool isAI { get; set; }
    public PlayerType playerType { get; set; }
    public (HexCoordinates, HexCoordinates) aiMove { get; set; }
    public Player(Team team, BoardObjectManager boardObjectManager)
    {
        this.team = team;
        this.boardObjectManager = boardObjectManager;
        isAI = false;
    }

    public virtual void ProcessAI()
    {

    }
}
