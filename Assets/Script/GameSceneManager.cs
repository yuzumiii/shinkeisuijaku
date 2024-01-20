using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSceneManager : MonoBehaviour
{

    // 一致したカードリストID
    private List<int> mContainCardIdList = new List<int>();

    void Update()
    {

        // 選択したカードが２枚以上になったら
        if (GameStateController.Instance.SelectedCardIdList.Count >= 2)
        {

            // 最初に選択したCardIDを取得する
            int selectedId = GameStateController.Instance.SelectedCardIdList[0];

            // 2枚目にあったカードと一緒だったら
            if (selectedId == GameStateController.Instance.SelectedCardIdList[1])
            {

                Debug.Log($"Contains! {selectedId}");
                // 一致したカードIDを保存する
                this.mContainCardIdList.Add(selectedId);
            }
            // 選択したカードリストを初期化する
            GameStateController.Instance.SelectedCardIdList.Clear();

        }
    }
}