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


namespace Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_custom_signatures.pallet
{
    
    
    public enum Error
    {
        
        DecodeFailure = 0,
        
        InvalidSignature = 1,
        
        BadNonce = 2,
    }
    
    /// <summary>
    /// >> 347 - Variant[pallet_custom_signatures.pallet.Error]
    /// 
    ///			Custom [dispatch errors](https://docs.substrate.io/main-docs/build/events-errors/)
    ///			of this pallet.
    ///			
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
