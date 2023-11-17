using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class QuestGoal
{
    public Goaltype goaltype;

    public int requiredAmount;
    public int currentAmount;

    public bool IsReached(){
        return (currentAmount >= requiredAmount);
    }
}

public enum Goaltype
{
    Kill,
    Gathering
}
