using System;
using UnityEngine;

namespace E.Story
{
    //句子数据
    [Serializable]
    public class SentenceData
    {
        [SerializeField] private string text;

        // 句子文本
        public string Text { get => text; set => text = value; }

        /// <summary>
        /// 构造器
        /// </summary>
        public SentenceData(string text)
        {
            this.text = text;
        }
    }
}