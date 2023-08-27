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


namespace Substrate.Shibuya.NET.NetApiExt.Generated.Model.orml_xtokens.module
{
    
    
    public enum Call
    {
        
        transfer = 0,
        
        transfer_multiasset = 1,
        
        transfer_with_fee = 2,
        
        transfer_multiasset_with_fee = 3,
        
        transfer_multicurrencies = 4,
        
        transfer_multiassets = 5,
    }
    
    /// <summary>
    /// >> 277 - Variant[orml_xtokens.module.Call]
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.v3.EnumWeightLimit>, BaseTuple<Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiAsset, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.v3.EnumWeightLimit>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.v3.EnumWeightLimit>, BaseTuple<Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiAsset, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiAsset, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.v3.EnumWeightLimit>, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>>, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.v3.EnumWeightLimit>, BaseTuple<Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiAssets, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.v3.EnumWeightLimit>>
    {
    }
}
