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


namespace Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_state_trie_migration.pallet
{
    
    
    public enum Error
    {
        
        MaxSignedLimits = 0,
        
        KeyTooLong = 1,
        
        NotEnoughFunds = 2,
        
        BadWitness = 3,
        
        SignedMigrationNotAllowed = 4,
        
        BadChildRoot = 5,
    }
    
    /// <summary>
    /// >> 155 - Variant[pallet_state_trie_migration.pallet.Error]
    /// 
    ///			Custom [dispatch errors](https://docs.substrate.io/main-docs/build/events-errors/)
    ///			of this pallet.
    ///			
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
