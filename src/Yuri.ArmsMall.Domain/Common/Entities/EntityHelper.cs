namespace Yuri.ArmsMall.Common.Entities;

/// <summary>
/// 
/// </summary>
public static class EntityHelper
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// <param name="entity"></param>
    /// <param name="idFactory"></param>
    /// <param name="checkForDisableIdGenerationAttribute"></param>
    public static void TrySetId<TKey>(IEntity<TKey> entity, Func<TKey> idFactory, bool checkForDisableIdGenerationAttribute = false)
    {

    }
}
