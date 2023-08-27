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


namespace Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_evm
{
    
    
    /// <summary>
    /// >> 469 - Composite[pallet_evm.CodeMetadata]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class CodeMetadata : BaseType
    {
        
        /// <summary>
        /// >> size
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U64 _size;
        
        /// <summary>
        /// >> hash
        /// </summary>
        private Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types.H256 _hash;
        
        public Substrate.NetApi.Model.Types.Primitive.U64 Size
        {
            get
            {
                return this._size;
            }
            set
            {
                this._size = value;
            }
        }
        
        public Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types.H256 Hash
        {
            get
            {
                return this._hash;
            }
            set
            {
                this._hash = value;
            }
        }
        
        public override string TypeName()
        {
            return "CodeMetadata";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Size.Encode());
            result.AddRange(Hash.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Size = new Substrate.NetApi.Model.Types.Primitive.U64();
            Size.Decode(byteArray, ref p);
            Hash = new Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types.H256();
            Hash.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
