using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InputAction : ScriptableObject {

    [SerializeField] private string keyword;
    [HideInInspector] public string Keyword { get { return keyword.ToLower(); } }

    public abstract void RespondToInput(GameController controller, string[] separatedInputWords);
}
