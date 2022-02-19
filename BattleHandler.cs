﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleHandler : MonoBehaviour{

    private static BattleHandler instance;
    public static BattleHandler GetInstance() {
        return instance;
    }
    
    [SerializedField] private Transform pfCharacterBattle;
    public Texture2D playerSpritesheet;
    public Texture2D enemySpritesheet;

    private CharacterBattle playerCharacterBattle;
    private CharacterBattle enemyCharacterBattle;

    private enum State {
        WaitingForPlayer,
        Busy,
    }

    private void Awake() {
        instance = this;
    }

    private void Start(){
        playerCharacterBattle = SpawnCharacter(true);
        enemyCharacterBattle = SpawnCharacter(false);

        state = State.WaitingForPlayer;
    }
    private void Update() {
        if (state == State.WaitingForPlayer) { 
            if (Input.GetKeyDown(KeyCode.Space)) {
                state = State.Busy;
                playerCharacterBattle.Attack(enemyCharacterBattle, () => {
                    state = State.WaitingForPlayer;
                });
            }
        }
    }
    private CharacterBattle SpawnCharacter(bool isPlayerTeam){
        Vector3 position;
        if (isPlayerTeam){
            position = new Vector3(-50, 0);
        }else{
            position = new Vector3(+50, 0);
        }
        Transform characterTransform = Instantiate(pfCharacterBattle, position, Quaternion.identity);
        CharacterBattle characterBattle = characterTransform.GetComponent<CharacterBattle>();
        characterBattle.Setup(isPlayerTeam);

        return characterBattle;
    }
}
