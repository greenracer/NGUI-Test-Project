using System.Diagnostics;
using UnityEngine;
using System;

public class PlayerData
{
    public readonly int Id;
    public readonly int Avatar;
    public readonly int ExpOverall;
    public readonly int ExpForToday;
    public readonly int ExpForWeek;
    public readonly int ExpForMonth;
    public int RatingPlace;

    public PlayerData(int id, int avatar, int exp) 
    {
        if (exp >= 0 && avatar > -1 && avatar < 4)
        {
            Id = id;
            Avatar = avatar;

            ExpOverall = exp;
            ExpForToday = exp / UnityEngine.Random.Range(1, 10);
            ExpForWeek = exp / UnityEngine.Random.Range(1, 10);
            ExpForMonth = exp / UnityEngine.Random.Range(1, 10);
        }
        else
            throw new ArgumentOutOfRangeException();
    }
}
