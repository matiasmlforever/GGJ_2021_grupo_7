using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameData
{
    private static List<string> foundWords = new List<string>();
    private static int interest = 100;

    public static List<string> FoundWords { get => foundWords; set => foundWords = value; }
    public static int Interest { get => interest; set => interest = value; }
}
