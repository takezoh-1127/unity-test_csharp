using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// グローバルで定義してみる.
public enum ElementAttr
{
	None = 0,

	Fire = 0x01 << 0,		// 火属性.
	Water = 0x01 << 1,		// 水属性.
	Earth = 0x01 << 2,		// 土属性.
	Light = 0x01 << 3,		// 光属性.
	Dark = 0x01 << 4,		// 闇属性.
}

// 名前空間で括ってみる.
namespace GameConst
{
	// 物理攻撃属性.
	public enum PhysicsAttackAttr
	{
		None = -1,

		Slash = 0,		// 斬.
		Blow,			// 打.
		Spear,			// 突.
	}
}
