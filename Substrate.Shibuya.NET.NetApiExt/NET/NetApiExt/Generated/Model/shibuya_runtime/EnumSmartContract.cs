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


namespace Substrate.Shibuya.NET.NetApiExt.Generated.Model.shibuya_runtime
{
    
    
    public enum SmartContract
    {
        
        Evm = 0,
        
        Wasm = 1,
    }
    
    /// <summary>
    /// >> 48 - Variant[shibuya_runtime.SmartContract]
    /// </summary>
    public sealed class EnumSmartContract : BaseEnumExt<SmartContract, Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types.H160, Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>
    {
    }
}
