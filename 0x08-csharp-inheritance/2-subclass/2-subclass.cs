using System;

class Obj
{
	public static bool IsOnlyASubclass(Type derivedType, Type baseType) => derivedType.IsSubclassOf(baseType);
}