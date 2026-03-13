using System;
using UnityEngine;

namespace E.Story
{
    // 选项数据
    [Serializable]
    public class ChoiceData
    {
        [SerializeField] private string text;
        [SerializeField] private string nextNodeID;

        // 选项文本
        public string Text { get => text; set => text = value; }

        // 节点GUID
        public string NextNodeID { get => nextNodeID; set => nextNodeID = value; }

        // 构造器
        public ChoiceData(string text)
        {
            this.text = text;
        }
        public ChoiceData(string text, string nextNodeID)
        {
            this.text = text;
            this.nextNodeID = nextNodeID;
        }
    }
}