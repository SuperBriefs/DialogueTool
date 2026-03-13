using UnityEngine;

namespace E.Story
{
    public enum NodeType
    {
        // 基础
        Base = 0,
        // 零进零出
        ZeroInZeroOut = 1,
        // 零进单出
        ZeroInSingleOut = 2,
        // 零进多出
        ZeroInMultiOut = 3,
        // 单进零出
        SingleInZeroOut = 4,
        // 单进单出
        SingleInSingleOut = 5,
        // 单进多出
        SingleInMultiOut = 6,
        // 多进零出
        MultiInZeroOut = 7,
        // 多进单出
        MultiInSingleOut = 8,
        // 多进多出
        MultiInMultiOut = 9,

        // 开始
        Start = 21,
        // 结束
        End = 31,
        // 对话
        Dialogue = 51,
        // 分支
        Branch = 61,
    }
}