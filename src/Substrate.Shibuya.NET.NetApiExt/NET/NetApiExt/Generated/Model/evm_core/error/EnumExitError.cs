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


namespace Substrate.Shibuya.NET.NetApiExt.Generated.Model.evm_core.error
{
    
    
    public enum ExitError
    {
        
        StackUnderflow = 0,
        
        StackOverflow = 1,
        
        InvalidJump = 2,
        
        InvalidRange = 3,
        
        DesignatedInvalid = 4,
        
        CallTooDeep = 5,
        
        CreateCollision = 6,
        
        CreateContractLimit = 7,
        
        InvalidCode = 15,
        
        OutOfOffset = 8,
        
        OutOfGas = 9,
        
        OutOfFund = 10,
        
        PCUnderflow = 11,
        
        CreateEmpty = 12,
        
        Other = 13,
        
        MaxNonce = 14,
    }
    
    /// <summary>
    /// >> 129 - Variant[evm_core.error.ExitError]
    /// </summary>
    public sealed class EnumExitError : BaseEnumExt<ExitError, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, Substrate.Shibuya.NET.NetApiExt.Generated.Types.Base.CowT1, BaseVoid, Substrate.Shibuya.NET.NetApiExt.Generated.Model.evm_core.opcode.Opcode>
    {
    }
}
