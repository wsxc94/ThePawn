using System.Collections;
using System.Collections.Generic;
using UnityEngine;
////////////////////////////////////////////////////
/*
    File MonsterData.cs
    class MonsterData
    
    담당자 : 안영훈

    몬스터의 스테이터스 데이터 클래스
*/
////////////////////////////////////////////////////
///
[System.Serializable]
[CSVReader.Data("id")]
public class MonsterData
{
    [Header("몬스터 기본 정보")]
    public int id;
    public string name;
    public float hp;
    public float findrange;
    public float attackrange;
    public float LimitTraceRange;
    public float AttackSpeed;
    public int damage;
    public float speed;
    public int gold;
    public int coin;
    public int xp;
}
