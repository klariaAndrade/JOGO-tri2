using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

[Serializable]

public class Level02UIComponents
{
    [Serializable]
   public class Hud 
   {
       [Header ("Text")]
       public Text txtCoinCount;
       public Text txtLifeCount;

       [Header ("Other")]
       public GameObject panelHud;
   }
   [Serializable]
   public class LevelCompletePanel 
   {
       [Header ("Text")]
       public Text txtScore;

       [Header ("Other")]
       public GameObject LCpanel;
   }
   [Serializable]
   public class GameOverPanel 
   {
       [Header ("Text")]
       public Text txtScore;

       [Header ("Other")]
       public GameObject GOpanel;
   }
   public Hud hud;
   public LevelCompletePanel levelcompletepanel;
   public GameOverPanel gameoverpanel;
}
