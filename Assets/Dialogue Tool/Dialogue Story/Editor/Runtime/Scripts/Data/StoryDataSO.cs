using System.Collections.Generic;
using UnityEngine;

namespace E.Story
{
    // 故事数据
    public class StoryDataSO : ScriptableObject
    {
        [SerializeField] private string fileName;
        [SerializeField] private List<GroupData> groupDatas;
        [SerializeField] private List<NodeData> nodeDatas;

        // 文件名称
        public string FileName { get => fileName; set => fileName = value; }

        // 分组数据列表
        public List<GroupData> GroupDatas { get => groupDatas; set => groupDatas = value; }

        // 节点数据列表
        public List<NodeData> NodeDatas { get => nodeDatas; set => nodeDatas = value; }
        
        /// <summary>
        /// 初始化
        /// </summary>
        public void Init(string fileName)
        {
            this.fileName = fileName;
            groupDatas = new List<GroupData>();
            nodeDatas = new List<NodeData>();
        }
    }
}