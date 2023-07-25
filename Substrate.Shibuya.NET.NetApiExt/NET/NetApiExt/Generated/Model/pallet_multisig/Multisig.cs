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


namespace Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_multisig
{
    
    
    /// <summary>
    /// >> 344 - Composite[pallet_multisig.Multisig]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class Multisig : BaseType
    {
        
        /// <summary>
        /// >> when
        /// </summary>
        private Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_multisig.Timepoint _when;
        
        /// <summary>
        /// >> deposit
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U128 _deposit;
        
        /// <summary>
        /// >> depositor
        /// </summary>
        private Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 _depositor;
        
        /// <summary>
        /// >> approvals
        /// </summary>
        private Substrate.Shibuya.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT10 _approvals;
        
        public Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_multisig.Timepoint When
        {
            get
            {
                return this._when;
            }
            set
            {
                this._when = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U128 Deposit
        {
            get
            {
                return this._deposit;
            }
            set
            {
                this._deposit = value;
            }
        }
        
        public Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 Depositor
        {
            get
            {
                return this._depositor;
            }
            set
            {
                this._depositor = value;
            }
        }
        
        public Substrate.Shibuya.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT10 Approvals
        {
            get
            {
                return this._approvals;
            }
            set
            {
                this._approvals = value;
            }
        }
        
        public override string TypeName()
        {
            return "Multisig";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(When.Encode());
            result.AddRange(Deposit.Encode());
            result.AddRange(Depositor.Encode());
            result.AddRange(Approvals.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            When = new Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_multisig.Timepoint();
            When.Decode(byteArray, ref p);
            Deposit = new Substrate.NetApi.Model.Types.Primitive.U128();
            Deposit.Decode(byteArray, ref p);
            Depositor = new Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32();
            Depositor.Decode(byteArray, ref p);
            Approvals = new Substrate.Shibuya.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT10();
            Approvals.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
