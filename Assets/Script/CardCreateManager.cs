using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class CardCreateManager : MonoBehaviour
{
    public Card CardPrefab;
    public RectTransform CardCreateParent;

    public class CardData
    {
        // �J�[�hID
        public int Id { get; private set; }

        // �摜
        public Sprite ImgSprite { get; private set; }

        public CardData(int _id, Sprite _sprite)
        {
            this.Id = _id;
            this.ImgSprite = _sprite;
        }
    }
void Start(){
        //�J�[�h��񃊃X�g
        List<CardData> cardDataList = new List<CardData>();
        // �\������J�[�h�摜���̃��X�g
        List<Sprite> imgList = new List<Sprite>();
        // Resources/Image�t�H���_���ɂ���摜���擾����
        imgList.Add(Resources.Load<Sprite>("Image/1"));
        imgList.Add(Resources.Load<Sprite>("Image/2"));
        imgList.Add(Resources.Load<Sprite>("Image/3"));
        imgList.Add(Resources.Load<Sprite>("Image/4"));
        imgList.Add(Resources.Load<Sprite>("Image/5"));
        imgList.Add(Resources.Load<Sprite>("Image/6"));
        imgList.Add(Resources.Load<Sprite>("Image/7"));
        //for���񂷉񐔂��擾����
        int loopCnt = imgList.Count;
        for(int i=0; i<loopCnt; i++)
        {
            CardData cardData = new CardData(i, imgList[i]);
            cardDataList.Add(cardData);
        }
        // ���������J�[�h���X�g�Q���̃��X�g�𐶐�����
        List<CardData> SumCardDataList = new List<CardData>();
        SumCardDataList.AddRange(cardDataList);
        SumCardDataList.AddRange(cardDataList);
        // ���X�g�̒��g�������_���ɍĔz�u����
        List<CardData> randomCardDataList = SumCardDataList.OrderBy(a => Guid.NewGuid()).ToList();
        // �J�[�h�I�u�W�F�N�g�𐶐�����
        foreach (var _cardData in randomCardDataList)
        {

            // Instantiate �� Card�I�u�W�F�N�g�𐶐�
            Card card = Instantiate<Card>(this.CardPrefab, this.CardCreateParent);
            // �f�[�^��ݒ肷��
            card.Set(_cardData);
        }
    }
}
