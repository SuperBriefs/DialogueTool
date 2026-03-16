using System;
using UnityEngine;

namespace E.Story
{
    // 变量数据
    [Serializable]
    public class VarData
    {
        [SerializeField] private string key;
        [SerializeField] private int value;
        
        // 变量名
        public string  Key { get => key; set => key = value; }

        // 变量值
        public int Value { get => value; set => this.value = value; }

        public VarData(string key, int value = 0)
        {
            this.key = key;
            this.value = value;
        }
    }
}