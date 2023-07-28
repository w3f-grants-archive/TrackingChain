//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Attributes;
using Substrate.NetApi.Model.Types.Base;
using Substrate.NetApi.Model.Types.Metadata.V14;
using System.Collections.Generic;


namespace Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.v2.multiasset
{
    
    
    /// <summary>
    /// >> 106 - Composite[xcm.v2.multiasset.MultiAsset]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class MultiAsset : BaseType
    {
        
        /// <summary>
        /// >> id
        /// </summary>
        private Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.v2.multiasset.EnumAssetId _id;
        
        /// <summary>
        /// >> fun
        /// </summary>
        private Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.v2.multiasset.EnumFungibility _fun;
        
        public Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.v2.multiasset.EnumAssetId Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
        
        public Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.v2.multiasset.EnumFungibility Fun
        {
            get
            {
                return this._fun;
            }
            set
            {
                this._fun = value;
            }
        }
        
        public override string TypeName()
        {
            return "MultiAsset";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Id.Encode());
            result.AddRange(Fun.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Id = new Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.v2.multiasset.EnumAssetId();
            Id.Decode(byteArray, ref p);
            Fun = new Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.v2.multiasset.EnumFungibility();
            Fun.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
