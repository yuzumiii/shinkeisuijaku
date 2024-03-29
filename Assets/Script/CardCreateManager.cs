using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class CardCreateManager : MonoBehaviour
{
    // 生成するCardオブジェクト
    public Card CardPrefab;
    // 「カード」を生成する親オブジェクト
    public RectTransform CardCreateParent;
    // 生成したカードオブジェクトを保存する
    public List<Card> CardList = new List<Card>();

    public class CardData
    {
        // カードID
        public int Id { get; private set; }

        // 画像
        public Sprite ImgSprite { get; private set; }

        public CardData(int _id, Sprite _sprite)
        {
            this.Id = _id;
            this.ImgSprite = _sprite;
        }
    }
    //void Start()
    //{
    //    //カード情報リスト
    //    List<CardData> cardDataList = new List<CardData>();
    //    // 表示するカード画像情報のリスト
    //    List<Sprite> imgList = new List<Sprite>();
    //    // Resources/Imageフォルダ内にある画像を取得する
    //    imgList.Add(Resources.Load<Sprite>("Image/1"));
    //    imgList.Add(Resources.Load<Sprite>("Image/2"));
    //    imgList.Add(Resources.Load<Sprite>("Image/3"));
    //    imgList.Add(Resources.Load<Sprite>("Image/4"));
    //    imgList.Add(Resources.Load<Sprite>("Image/5"));
    //    imgList.Add(Resources.Load<Sprite>("Image/6"));
    //    imgList.Add(Resources.Load<Sprite>("Image/7"));
    //    //forを回す回数を取得する
    //    int loopCnt = imgList.Count;
    //    for (int i = 0; i < loopCnt; i++)
    //    {
    //        CardData cardData = new CardData(i, imgList[i]);
    //        cardDataList.Add(cardData);
    //    }
    //    // 生成したカードリスト２つ分のリストを生成する
    //    List<CardData> SumCardDataList = new List<CardData>();
    //    SumCardDataList.AddRange(cardDataList);
    //    SumCardDataList.AddRange(cardDataList);
    //    // リストの中身をランダムに再配置する
    //    List<CardData> randomCardDataList = SumCardDataList.OrderBy(a => Guid.NewGuid()).ToList();
    //    // カードオブジェクトを生成する
    //    foreach (var _cardData in randomCardDataList)
    //    {

    //        // Instantiate で Cardオブジェクトを生成
    //        Card card = Instantiate<Card>(this.CardPrefab, this.CardCreateParent);
    //        // データを設定する
    //        card.Set(_cardData);
    //        // 生成したカードオブジェクトを保存する
    //        this.CardList.Add(card);
    //    }
    //}
    /// <summary>
    /// カードを生成する
    /// </summary>
    public void CreateCard()
    {
        //カード情報リスト
        List<CardData> cardDataList = new List<CardData>();
        // 表示するカード画像情報のリスト
        List<Sprite> imgList = new List<Sprite>();
        // Resources/Imageフォルダ内にある画像を取得する
        imgList.Add(Resources.Load<Sprite>("Image/1"));
        imgList.Add(Resources.Load<Sprite>("Image/2"));
        imgList.Add(Resources.Load<Sprite>("Image/3"));
        imgList.Add(Resources.Load<Sprite>("Image/4"));
        imgList.Add(Resources.Load<Sprite>("Image/5"));
        imgList.Add(Resources.Load<Sprite>("Image/6"));
        imgList.Add(Resources.Load<Sprite>("Image/7"));
        //forを回す回数を取得する
        int loopCnt = imgList.Count;
        for (int i = 0; i < loopCnt; i++)
        {
            CardData cardData = new CardData(i, imgList[i]);
            cardDataList.Add(cardData);
        }
        // 生成したカードリスト２つ分のリストを生成する
        List<CardData> SumCardDataList = new List<CardData>();
        SumCardDataList.AddRange(cardDataList);
        SumCardDataList.AddRange(cardDataList);
        // リストの中身をランダムに再配置する
        List<CardData> randomCardDataList = SumCardDataList.OrderBy(a => Guid.NewGuid()).ToList();
        // カードオブジェクトを生成する
        foreach (var _cardData in randomCardDataList)
        {

            // Instantiate で Cardオブジェクトを生成
            Card card = Instantiate<Card>(this.CardPrefab, this.CardCreateParent);
            // データを設定する
            card.Set(_cardData);
            // 生成したカードオブジェクトを保存する
            this.CardList.Add(card);
        }
    }

    /// <summary>
    /// 取得していないカードを背面にする
    /// </summary>
    public void HideCardList(List<int> containCardIdList)
    {

        foreach (var _card in this.CardList)
        {

            // 既に獲得したカードIDの場合、非表示にする
            if (containCardIdList.Contains(_card.Id))
            {

                // カードを非表示にする
                _card.SetInvisible();
            }
            // 獲得していないカードは裏面表示にする
            else
            {

                // カードを裏面表示にする
                _card.SetHide();
            }
        }
    }
}