﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestPanel : MonoBehaviour
{
    public List<string> quests;
    public int currentQuest = 0 ;
    public Text TextUI;
    // Start is called before the first frame update
    void Start()
    {
        quests.Add("Press r to drop a hive, make sure it is near flowers");
        quests.Add("You used up your starting honey making that hive so lets make some more");
        quests.Add("Press E on the hive to start honey production");
        quests.Add("Press E again once it is done to collect the honey");
        quests.Add("Use this menu to buy them with 1 2 or 3");
        TextUI.text = quests[0];
    }

    // Update is called once per frame
    void nextQuest()
    {
        currentQuest++;
        if (quests.Count > currentQuest)
        {
            TextUI.text = quests[currentQuest];
        }
    }
}