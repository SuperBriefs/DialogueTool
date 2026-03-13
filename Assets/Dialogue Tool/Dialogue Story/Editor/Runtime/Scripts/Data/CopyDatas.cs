using System.Collections.Generic;
using System;

namespace E.Story
{
    // 复制数据
    [Serializable]
    public class CopyDatas
    {
        public List<NodeData> nodeDatas = new();
        public List<GroupData> groupDatas = new();
    }
}