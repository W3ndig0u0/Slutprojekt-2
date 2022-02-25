using System;
using Raylib_cs;
using System.Collections.Generic;

namespace Projekt
{
  public class GameController
  {
    //   !Håller kolla på alla Fiender i Listan
    public List<Enemy> enemyList;
    public Color Black = Color.BLACK;
    public Color White = Color.WHITE;
    int timer;

    public GameController()
    {
      enemyList = new List<Enemy>();
    }

    public void FeverMode(Player player)
    {
      if (player.IsFeverMode)
      {
        // !Ändrar färgerna
        Black = Color.WHITE;
        White = Color.WHITE;
      }
      else if (player.IsFeverMode)
      {
        Black = Color.WHITE;
        White = Color.BLACK;
      }
    }

  }
}