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


namespace Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_balances.types
{
    
    
    /// <summary>
    /// >> 373 - Composite[pallet_balances.types.BalanceLock]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class BalanceLock : BaseType
    {
        
        /// <summary>
        /// >> id
        /// </summary>
        private Substrate.Shibuya.NET.NetApiExt.Generated.Types.Base.Arr8U8 _id;
        
        /// <summary>
        /// >> amount
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U128 _amount;
        
        /// <summary>
        /// >> reasons
        /// </summary>
        private Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_balances.types.EnumReasons _reasons;
        
        public Substrate.Shibuya.NET.NetApiExt.Generated.Types.Base.Arr8U8 Id
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
        
        public Substrate.NetApi.Model.Types.Primitive.U128 Amount
        {
            get
            {
                return this._amount;
            }
            set
            {
                this._amount = value;
            }
        }
        
        public Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_balances.types.EnumReasons Reasons
        {
            get
            {
                return this._reasons;
            }
            set
            {
                this._reasons = value;
            }
        }
        
        public override string TypeName()
        {
            return "BalanceLock";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Id.Encode());
            result.AddRange(Amount.Encode());
            result.AddRange(Reasons.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Id = new Substrate.Shibuya.NET.NetApiExt.Generated.Types.Base.Arr8U8();
            Id.Decode(byteArray, ref p);
            Amount = new Substrate.NetApi.Model.Types.Primitive.U128();
            Amount.Decode(byteArray, ref p);
            Reasons = new Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_balances.types.EnumReasons();
            Reasons.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
