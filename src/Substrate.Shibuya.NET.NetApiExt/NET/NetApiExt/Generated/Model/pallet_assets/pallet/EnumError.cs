//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_assets.pallet
{
    
    
    public enum Error
    {
        
        BalanceLow = 0,
        
        NoAccount = 1,
        
        NoPermission = 2,
        
        Unknown = 3,
        
        Frozen = 4,
        
        InUse = 5,
        
        BadWitness = 6,
        
        MinBalanceZero = 7,
        
        NoProvider = 8,
        
        BadMetadata = 9,
        
        Unapproved = 10,
        
        WouldDie = 11,
        
        AlreadyExists = 12,
        
        NoDeposit = 13,
        
        WouldBurn = 14,
        
        LiveAsset = 15,
        
        AssetNotLive = 16,
        
        IncorrectStatus = 17,
        
        NotFrozen = 18,
    }
    
    /// <summary>
    /// >> 418 - Variant[pallet_assets.pallet.Error]
    /// 
    ///			Custom [dispatch errors](https://docs.substrate.io/main-docs/build/events-errors/)
    ///			of this pallet.
    ///			
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
