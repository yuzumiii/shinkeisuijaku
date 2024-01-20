using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static CardCreateManager;

public class Card : MonoBehaviour
{
    // カードのID
    public int Id;

    // 表示するカードの画像
    public Image CardImage;

    // 選択されているか判定
    private bool mIsSelected = false;

    // カード情報
    private CardData mData;

    // カードの設定
    public void Set(CardData data)
    {

        // カード情報を設定
        this.mData = data;

        // IDを設定する
        this.Id = data.Id;

        // 表示する画像を設定する
        // 初回は全て裏面表示とする
        //this.CardImage.sprite = Resources.Load<Sprite>("Image/card_back");

        // 選択判定フラグを初期化する
        this.mIsSelected = false;

    }

    /// <summary>
    /// 選択された時の処理
    /// </summary>
    public void OnClick()
    {

        // カードが表面になっていた場合は無効
        if (this.mIsSelected)
        {
            return;
        }

        Debug.Log("OnClick");

        // 選択判定フラグを有効にする
        this.mIsSelected = true;

        // カードを表面にする
        this.CardImage.sprite = this.mData.ImgSprite;

        // 選択したCardIdを保存しよう！
        GameStateController.Instance.SelectedCardIdList.Add(this.mData.Id);
    }
}
