using Itsdits.Ravar.Monster.Move;
using System.Collections.Generic;
using UnityEngine;

namespace Itsdits.Ravar.Monster { 
    [CreateAssetMenu(fileName = "Monster", menuName = "Monster/Create a new monster")] 
    public class MonsterBase : ScriptableObject
    {
        #region config
        [SerializeField] string _name;
        [TextArea]
        [SerializeField] string description;
        [SerializeField] int maxHp;
        [SerializeField] int attack;
        [SerializeField] int defense;
        [SerializeField] int spAttack;
        [SerializeField] int spDefense;
        [SerializeField] int speed;
        [SerializeField] int catchRate = 255;
        [SerializeField] Sprite leftSprite;
        [SerializeField] Sprite rightSprite;
        [SerializeField] MonsterType primaryType;
        [SerializeField] MonsterType secondaryType;
        [SerializeField] List<LearnableMove> learnableMoves;
        #endregion
        #region Properties
        public string Name => _name;
        public string Description => description;
        public int MaxHp => maxHp;
        public int Attack => attack;
        public int Defense => defense;
        public int SpAttack => spAttack;
        public int SpDefense => spDefense;
        public int Speed => speed;
        public int CatchRate => catchRate;
        public Sprite LeftSprite => leftSprite;
        public Sprite RightSprite => rightSprite;
        public MonsterType PrimaryType => primaryType;
        public MonsterType SecondaryType => secondaryType;
        public List<LearnableMove> LearnableMoves => learnableMoves;
        #endregion
    }
}