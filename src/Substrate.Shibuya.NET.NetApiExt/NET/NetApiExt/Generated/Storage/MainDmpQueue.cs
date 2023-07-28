//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi;
using Substrate.NetApi.Model.Extrinsics;
using Substrate.NetApi.Model.Meta;
using Substrate.NetApi.Model.Types;
using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace Substrate.Shibuya.NET.NetApiExt.Generated.Storage
{
    
    
    public sealed class DmpQueueStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public DmpQueueStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("DmpQueue", "Configuration"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Model.cumulus_pallet_dmp_queue.ConfigData)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("DmpQueue", "PageIndex"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Model.cumulus_pallet_dmp_queue.PageIndexData)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("DmpQueue", "Pages"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.NetApi.Model.Types.Primitive.U32), typeof(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>>)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("DmpQueue", "Overweight"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.NetApi.Model.Types.Primitive.U64), typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("DmpQueue", "CounterForOverweight"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Primitive.U32)));
        }
        
        /// <summary>
        /// >> ConfigurationParams
        ///  The configuration.
        /// </summary>
        public static string ConfigurationParams()
        {
            return RequestGenerator.GetStorage("DmpQueue", "Configuration", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> ConfigurationDefault
        /// Default value as hex string
        /// </summary>
        public static string ConfigurationDefault()
        {
            return "0x0700E40B540202000400";
        }
        
        /// <summary>
        /// >> Configuration
        ///  The configuration.
        /// </summary>
        public async Task<Substrate.Shibuya.NET.NetApiExt.Generated.Model.cumulus_pallet_dmp_queue.ConfigData> Configuration(CancellationToken token)
        {
            string parameters = DmpQueueStorage.ConfigurationParams();
            var result = await _client.GetStorageAsync<Substrate.Shibuya.NET.NetApiExt.Generated.Model.cumulus_pallet_dmp_queue.ConfigData>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> PageIndexParams
        ///  The page index.
        /// </summary>
        public static string PageIndexParams()
        {
            return RequestGenerator.GetStorage("DmpQueue", "PageIndex", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> PageIndexDefault
        /// Default value as hex string
        /// </summary>
        public static string PageIndexDefault()
        {
            return "0x00000000000000000000000000000000";
        }
        
        /// <summary>
        /// >> PageIndex
        ///  The page index.
        /// </summary>
        public async Task<Substrate.Shibuya.NET.NetApiExt.Generated.Model.cumulus_pallet_dmp_queue.PageIndexData> PageIndex(CancellationToken token)
        {
            string parameters = DmpQueueStorage.PageIndexParams();
            var result = await _client.GetStorageAsync<Substrate.Shibuya.NET.NetApiExt.Generated.Model.cumulus_pallet_dmp_queue.PageIndexData>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> PagesParams
        ///  The queue pages.
        /// </summary>
        public static string PagesParams(Substrate.NetApi.Model.Types.Primitive.U32 key)
        {
            return RequestGenerator.GetStorage("DmpQueue", "Pages", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> PagesDefault
        /// Default value as hex string
        /// </summary>
        public static string PagesDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Pages
        ///  The queue pages.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>>> Pages(Substrate.NetApi.Model.Types.Primitive.U32 key, CancellationToken token)
        {
            string parameters = DmpQueueStorage.PagesParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>>>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> OverweightParams
        ///  The overweight messages.
        /// </summary>
        public static string OverweightParams(Substrate.NetApi.Model.Types.Primitive.U64 key)
        {
            return RequestGenerator.GetStorage("DmpQueue", "Overweight", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> OverweightDefault
        /// Default value as hex string
        /// </summary>
        public static string OverweightDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Overweight
        ///  The overweight messages.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>> Overweight(Substrate.NetApi.Model.Types.Primitive.U64 key, CancellationToken token)
        {
            string parameters = DmpQueueStorage.OverweightParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> CounterForOverweightParams
        /// Counter for the related counted storage map
        /// </summary>
        public static string CounterForOverweightParams()
        {
            return RequestGenerator.GetStorage("DmpQueue", "CounterForOverweight", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> CounterForOverweightDefault
        /// Default value as hex string
        /// </summary>
        public static string CounterForOverweightDefault()
        {
            return "0x00000000";
        }
        
        /// <summary>
        /// >> CounterForOverweight
        /// Counter for the related counted storage map
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U32> CounterForOverweight(CancellationToken token)
        {
            string parameters = DmpQueueStorage.CounterForOverweightParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U32>(parameters, token);
            return result;
        }
    }
    
    public sealed class DmpQueueCalls
    {
        
        /// <summary>
        /// >> service_overweight
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ServiceOverweight(Substrate.NetApi.Model.Types.Primitive.U64 index, Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight weight_limit)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(index.Encode());
            byteArray.AddRange(weight_limit.Encode());
            return new Method(53, "DmpQueue", 0, "service_overweight", byteArray.ToArray());
        }
    }
    
    public sealed class DmpQueueConstants
    {
    }
    
    public enum DmpQueueErrors
    {
        
        /// <summary>
        /// >> Unknown
        /// The message index given is unknown.
        /// </summary>
        Unknown,
        
        /// <summary>
        /// >> OverLimit
        /// The amount of weight given is possibly not enough for executing the message.
        /// </summary>
        OverLimit,
    }
}
