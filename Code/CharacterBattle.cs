using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBattle : MonoBehaviour{

    private Character_Base characterBase;
    private State state;
    private Vector3 slideTargetPosition;
    private Action onSlideComplete;
    private bool isPlayerTeam;

    private enum State {
        Idle,
        Sliding,
        Busy,
    }

    private void Awake(){
        characterBase = GetComponent<Character_Base>();
        state = State.Idle;
    }
    private void Start(){

    }

    public void Setup(bool isPlayerTeam){
        this.isPlayerTeam = isPlayerTeam;
        if (isPlayerTeam) {
            characterBase.SetAnimsSwordTwoHandedBack();
            characterBase.GetMaterial().mainTexture = BattleHandler.GetInstance().playerSpriteSheet;
        } else {
            characterBase.SetAnimsSwordShield();
            characterBase.GetMaterial().mainTexture = BattleHandler.GetInstance().enemySpriteSheet;

        }
        PlayAnimIdle();
    }

    private void PlayAnimIdle() {
        if (isPlayerTeam) {
            characterBase.PlayAnimIdle(new Vector3(+1, 0));
        }
        else {
            characterBase.PlayAnimIdle(new Vector3(-1, 0));
        }
    }

    private void Update() {
        switch (state) { 
        case State.Idle;
            break;
        case State.Busy;
            break
        case State.Sliding;
            float slideSpeed = 10f;
            transform.position += (slideTargetPosition - GetPosition()) * slideSpeed * Time.deltaTime;
            
            if (Vector3.Distance(GetPosition, slideTargetPosition) < reachedDistance) {
                    // Arrived at Slide Target Position
                    transform.position = slideTargetPosition;
                    onSlideComplete();
            }
            break;
        }
    }

    public Vector3 GetPosition() {
        return transfor.position;
    }

    public void Attack(CharacterBattle targetCharacterBattle, Action onAttackComplete) {
        Vector3 slideTargetPosition = targetCharacterBattle.GetPosition() + (GetPosition() - targetCharacterBattle.GetPosition()).normalized * 10f;
        Vector3 startingPosition = GetPosition();

        // Slide to Target
        SlideToPosition(slideTargetPosition, () => {
            // Arrived at Target, attack animation
            state = State.Busy;
            Vector3 attackDir = (targetCharacterBattle.GetPosition() - GetPosition()).normalized;
            characterBase.PlayAnimAttack(attackDir, null, () => {
                // Attack completed, slide back
                SlideToPosition(slideTargetPosition, () => {
                    // Slide back completed, back to idle
                    state = State.Idle;
                    characterBase.PlayAnimIdle(attackDir);
                    onAttackComplete();
                });   
            });
        });
    }
    private void SlideToPosition(Vector3 slideTargetPosition, Action onSlideComplete) {
        this.slideTargetPosition = slideTargetPosition;
        this.onSlideComplete = onSlideComplete;
        state = State.Sliding;
        if (slideTargetPosition.x > 0) {
            characterBase.PlayAnimSlideRight();
        }
        else {
            characterBase.PlayAnimSlideLeft();
        }
    }
}
