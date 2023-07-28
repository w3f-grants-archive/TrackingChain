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


namespace Substrate.ContractRococo.NET.NetApiExt.Generated.Model.pallet_contracts.storage
{
    
    
    /// <summary>
    /// >> 277 - Composite[pallet_contracts.storage.DeletionQueueManager]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class DeletionQueueManager : BaseType
    {
        
        /// <summary>
        /// >> insert_counter
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _insertCounter;
        
        /// <summary>
        /// >> delete_counter
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _deleteCounter;
        
        public Substrate.NetApi.Model.Types.Primitive.U32 InsertCounter
        {
            get
            {
                return this._insertCounter;
            }
            set
            {
                this._insertCounter = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 DeleteCounter
        {
            get
            {
                return this._deleteCounter;
            }
            set
            {
                this._deleteCounter = value;
            }
        }
        
        public override string TypeName()
        {
            return "DeletionQueueManager";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(InsertCounter.Encode());
            result.AddRange(DeleteCounter.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            InsertCounter = new Substrate.NetApi.Model.Types.Primitive.U32();
            InsertCounter.Decode(byteArray, ref p);
            DeleteCounter = new Substrate.NetApi.Model.Types.Primitive.U32();
            DeleteCounter.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
