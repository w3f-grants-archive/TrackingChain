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
    
    
    public sealed class PolkadotXcmStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public PolkadotXcmStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("PolkadotXcm", "QueryCounter"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Primitive.U64)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("PolkadotXcm", "Queries"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.NetApi.Model.Types.Primitive.U64), typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_xcm.pallet.EnumQueryStatus)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("PolkadotXcm", "AssetTraps"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types.H256), typeof(Substrate.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("PolkadotXcm", "SafeXcmVersion"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("PolkadotXcm", "SupportedVersion"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation>), typeof(Substrate.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("PolkadotXcm", "VersionNotifiers"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation>), typeof(Substrate.NetApi.Model.Types.Primitive.U64)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("PolkadotXcm", "VersionNotifyTargets"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation>), typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U64, Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight, Substrate.NetApi.Model.Types.Primitive.U32>)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("PolkadotXcm", "VersionDiscoveryQueue"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT20)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("PolkadotXcm", "CurrentMigration"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_xcm.pallet.EnumVersionMigrationStage)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("PolkadotXcm", "RemoteLockedFungibles"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat,
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedAssetId>), typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_xcm.pallet.RemoteLockedFungibleRecord)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("PolkadotXcm", "LockedFungibles"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32), typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT21)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("PolkadotXcm", "XcmExecutionSuspended"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Primitive.Bool)));
        }
        
        /// <summary>
        /// >> QueryCounterParams
        ///  The latest available query index.
        /// </summary>
        public static string QueryCounterParams()
        {
            return RequestGenerator.GetStorage("PolkadotXcm", "QueryCounter", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> QueryCounterDefault
        /// Default value as hex string
        /// </summary>
        public static string QueryCounterDefault()
        {
            return "0x0000000000000000";
        }
        
        /// <summary>
        /// >> QueryCounter
        ///  The latest available query index.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U64> QueryCounter(CancellationToken token)
        {
            string parameters = PolkadotXcmStorage.QueryCounterParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U64>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> QueriesParams
        ///  The ongoing queries.
        /// </summary>
        public static string QueriesParams(Substrate.NetApi.Model.Types.Primitive.U64 key)
        {
            return RequestGenerator.GetStorage("PolkadotXcm", "Queries", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> QueriesDefault
        /// Default value as hex string
        /// </summary>
        public static string QueriesDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Queries
        ///  The ongoing queries.
        /// </summary>
        public async Task<Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_xcm.pallet.EnumQueryStatus> Queries(Substrate.NetApi.Model.Types.Primitive.U64 key, CancellationToken token)
        {
            string parameters = PolkadotXcmStorage.QueriesParams(key);
            var result = await _client.GetStorageAsync<Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_xcm.pallet.EnumQueryStatus>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> AssetTrapsParams
        ///  The existing asset traps.
        /// 
        ///  Key is the blake2 256 hash of (origin, versioned `MultiAssets`) pair. Value is the number of
        ///  times this pair has been trapped (usually just 1 if it exists at all).
        /// </summary>
        public static string AssetTrapsParams(Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types.H256 key)
        {
            return RequestGenerator.GetStorage("PolkadotXcm", "AssetTraps", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> AssetTrapsDefault
        /// Default value as hex string
        /// </summary>
        public static string AssetTrapsDefault()
        {
            return "0x00000000";
        }
        
        /// <summary>
        /// >> AssetTraps
        ///  The existing asset traps.
        /// 
        ///  Key is the blake2 256 hash of (origin, versioned `MultiAssets`) pair. Value is the number of
        ///  times this pair has been trapped (usually just 1 if it exists at all).
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U32> AssetTraps(Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types.H256 key, CancellationToken token)
        {
            string parameters = PolkadotXcmStorage.AssetTrapsParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U32>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> SafeXcmVersionParams
        ///  Default version to encode XCM when latest version of destination is unknown. If `None`,
        ///  then the destinations whose XCM version is unknown are considered unreachable.
        /// </summary>
        public static string SafeXcmVersionParams()
        {
            return RequestGenerator.GetStorage("PolkadotXcm", "SafeXcmVersion", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> SafeXcmVersionDefault
        /// Default value as hex string
        /// </summary>
        public static string SafeXcmVersionDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> SafeXcmVersion
        ///  Default version to encode XCM when latest version of destination is unknown. If `None`,
        ///  then the destinations whose XCM version is unknown are considered unreachable.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U32> SafeXcmVersion(CancellationToken token)
        {
            string parameters = PolkadotXcmStorage.SafeXcmVersionParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U32>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> SupportedVersionParams
        ///  The Latest versions that we know various locations support.
        /// </summary>
        public static string SupportedVersionParams(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation> key)
        {
            return RequestGenerator.GetStorage("PolkadotXcm", "SupportedVersion", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, key.Value);
        }
        
        /// <summary>
        /// >> SupportedVersionDefault
        /// Default value as hex string
        /// </summary>
        public static string SupportedVersionDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> SupportedVersion
        ///  The Latest versions that we know various locations support.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U32> SupportedVersion(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation> key, CancellationToken token)
        {
            string parameters = PolkadotXcmStorage.SupportedVersionParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U32>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> VersionNotifiersParams
        ///  All locations that we have requested version notifications from.
        /// </summary>
        public static string VersionNotifiersParams(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation> key)
        {
            return RequestGenerator.GetStorage("PolkadotXcm", "VersionNotifiers", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, key.Value);
        }
        
        /// <summary>
        /// >> VersionNotifiersDefault
        /// Default value as hex string
        /// </summary>
        public static string VersionNotifiersDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> VersionNotifiers
        ///  All locations that we have requested version notifications from.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U64> VersionNotifiers(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation> key, CancellationToken token)
        {
            string parameters = PolkadotXcmStorage.VersionNotifiersParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U64>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> VersionNotifyTargetsParams
        ///  The target locations that are subscribed to our version changes, as well as the most recent
        ///  of our versions we informed them of.
        /// </summary>
        public static string VersionNotifyTargetsParams(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation> key)
        {
            return RequestGenerator.GetStorage("PolkadotXcm", "VersionNotifyTargets", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, key.Value);
        }
        
        /// <summary>
        /// >> VersionNotifyTargetsDefault
        /// Default value as hex string
        /// </summary>
        public static string VersionNotifyTargetsDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> VersionNotifyTargets
        ///  The target locations that are subscribed to our version changes, as well as the most recent
        ///  of our versions we informed them of.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U64, Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight, Substrate.NetApi.Model.Types.Primitive.U32>> VersionNotifyTargets(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation> key, CancellationToken token)
        {
            string parameters = PolkadotXcmStorage.VersionNotifyTargetsParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U64, Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight, Substrate.NetApi.Model.Types.Primitive.U32>>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> VersionDiscoveryQueueParams
        ///  Destinations whose latest XCM version we would like to know. Duplicates not allowed, and
        ///  the `u32` counter is the number of times that a send to the destination has been attempted,
        ///  which is used as a prioritization.
        /// </summary>
        public static string VersionDiscoveryQueueParams()
        {
            return RequestGenerator.GetStorage("PolkadotXcm", "VersionDiscoveryQueue", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> VersionDiscoveryQueueDefault
        /// Default value as hex string
        /// </summary>
        public static string VersionDiscoveryQueueDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> VersionDiscoveryQueue
        ///  Destinations whose latest XCM version we would like to know. Duplicates not allowed, and
        ///  the `u32` counter is the number of times that a send to the destination has been attempted,
        ///  which is used as a prioritization.
        /// </summary>
        public async Task<Substrate.Shibuya.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT20> VersionDiscoveryQueue(CancellationToken token)
        {
            string parameters = PolkadotXcmStorage.VersionDiscoveryQueueParams();
            var result = await _client.GetStorageAsync<Substrate.Shibuya.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT20>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> CurrentMigrationParams
        ///  The current migration's stage, if any.
        /// </summary>
        public static string CurrentMigrationParams()
        {
            return RequestGenerator.GetStorage("PolkadotXcm", "CurrentMigration", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> CurrentMigrationDefault
        /// Default value as hex string
        /// </summary>
        public static string CurrentMigrationDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> CurrentMigration
        ///  The current migration's stage, if any.
        /// </summary>
        public async Task<Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_xcm.pallet.EnumVersionMigrationStage> CurrentMigration(CancellationToken token)
        {
            string parameters = PolkadotXcmStorage.CurrentMigrationParams();
            var result = await _client.GetStorageAsync<Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_xcm.pallet.EnumVersionMigrationStage>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> RemoteLockedFungiblesParams
        ///  Fungible assets which we know are locked on a remote chain.
        /// </summary>
        public static string RemoteLockedFungiblesParams(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedAssetId> key)
        {
            return RequestGenerator.GetStorage("PolkadotXcm", "RemoteLockedFungibles", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat,
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, key.Value);
        }
        
        /// <summary>
        /// >> RemoteLockedFungiblesDefault
        /// Default value as hex string
        /// </summary>
        public static string RemoteLockedFungiblesDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> RemoteLockedFungibles
        ///  Fungible assets which we know are locked on a remote chain.
        /// </summary>
        public async Task<Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_xcm.pallet.RemoteLockedFungibleRecord> RemoteLockedFungibles(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedAssetId> key, CancellationToken token)
        {
            string parameters = PolkadotXcmStorage.RemoteLockedFungiblesParams(key);
            var result = await _client.GetStorageAsync<Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_xcm.pallet.RemoteLockedFungibleRecord>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> LockedFungiblesParams
        ///  Fungible assets which we know are locked on this chain.
        /// </summary>
        public static string LockedFungiblesParams(Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
        {
            return RequestGenerator.GetStorage("PolkadotXcm", "LockedFungibles", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> LockedFungiblesDefault
        /// Default value as hex string
        /// </summary>
        public static string LockedFungiblesDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> LockedFungibles
        ///  Fungible assets which we know are locked on this chain.
        /// </summary>
        public async Task<Substrate.Shibuya.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT21> LockedFungibles(Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key, CancellationToken token)
        {
            string parameters = PolkadotXcmStorage.LockedFungiblesParams(key);
            var result = await _client.GetStorageAsync<Substrate.Shibuya.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT21>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> XcmExecutionSuspendedParams
        ///  Global suspension state of the XCM executor.
        /// </summary>
        public static string XcmExecutionSuspendedParams()
        {
            return RequestGenerator.GetStorage("PolkadotXcm", "XcmExecutionSuspended", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> XcmExecutionSuspendedDefault
        /// Default value as hex string
        /// </summary>
        public static string XcmExecutionSuspendedDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> XcmExecutionSuspended
        ///  Global suspension state of the XCM executor.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.Bool> XcmExecutionSuspended(CancellationToken token)
        {
            string parameters = PolkadotXcmStorage.XcmExecutionSuspendedParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.Bool>(parameters, token);
            return result;
        }
    }
    
    public sealed class PolkadotXcmCalls
    {
        
        /// <summary>
        /// >> send
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Send(Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation dest, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedXcm message)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(dest.Encode());
            byteArray.AddRange(message.Encode());
            return new Method(51, "PolkadotXcm", 0, "send", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> teleport_assets
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method TeleportAssets(Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation dest, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation beneficiary, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiAssets assets, Substrate.NetApi.Model.Types.Primitive.U32 fee_asset_item)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(dest.Encode());
            byteArray.AddRange(beneficiary.Encode());
            byteArray.AddRange(assets.Encode());
            byteArray.AddRange(fee_asset_item.Encode());
            return new Method(51, "PolkadotXcm", 1, "teleport_assets", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> reserve_transfer_assets
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ReserveTransferAssets(Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation dest, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation beneficiary, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiAssets assets, Substrate.NetApi.Model.Types.Primitive.U32 fee_asset_item)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(dest.Encode());
            byteArray.AddRange(beneficiary.Encode());
            byteArray.AddRange(assets.Encode());
            byteArray.AddRange(fee_asset_item.Encode());
            return new Method(51, "PolkadotXcm", 2, "reserve_transfer_assets", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> execute
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Execute(Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedXcm message, Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight max_weight)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(message.Encode());
            byteArray.AddRange(max_weight.Encode());
            return new Method(51, "PolkadotXcm", 3, "execute", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> force_xcm_version
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ForceXcmVersion(Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.v3.multilocation.MultiLocation location, Substrate.NetApi.Model.Types.Primitive.U32 xcm_version)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(location.Encode());
            byteArray.AddRange(xcm_version.Encode());
            return new Method(51, "PolkadotXcm", 4, "force_xcm_version", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> force_default_xcm_version
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ForceDefaultXcmVersion(Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32> maybe_xcm_version)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(maybe_xcm_version.Encode());
            return new Method(51, "PolkadotXcm", 5, "force_default_xcm_version", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> force_subscribe_version_notify
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ForceSubscribeVersionNotify(Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation location)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(location.Encode());
            return new Method(51, "PolkadotXcm", 6, "force_subscribe_version_notify", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> force_unsubscribe_version_notify
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ForceUnsubscribeVersionNotify(Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation location)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(location.Encode());
            return new Method(51, "PolkadotXcm", 7, "force_unsubscribe_version_notify", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> limited_reserve_transfer_assets
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method LimitedReserveTransferAssets(Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation dest, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation beneficiary, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiAssets assets, Substrate.NetApi.Model.Types.Primitive.U32 fee_asset_item, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.v3.EnumWeightLimit weight_limit)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(dest.Encode());
            byteArray.AddRange(beneficiary.Encode());
            byteArray.AddRange(assets.Encode());
            byteArray.AddRange(fee_asset_item.Encode());
            byteArray.AddRange(weight_limit.Encode());
            return new Method(51, "PolkadotXcm", 8, "limited_reserve_transfer_assets", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> limited_teleport_assets
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method LimitedTeleportAssets(Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation dest, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation beneficiary, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiAssets assets, Substrate.NetApi.Model.Types.Primitive.U32 fee_asset_item, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.v3.EnumWeightLimit weight_limit)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(dest.Encode());
            byteArray.AddRange(beneficiary.Encode());
            byteArray.AddRange(assets.Encode());
            byteArray.AddRange(fee_asset_item.Encode());
            byteArray.AddRange(weight_limit.Encode());
            return new Method(51, "PolkadotXcm", 9, "limited_teleport_assets", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> force_suspension
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ForceSuspension(Substrate.NetApi.Model.Types.Primitive.Bool suspended)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(suspended.Encode());
            return new Method(51, "PolkadotXcm", 10, "force_suspension", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> reserve_withdraw_assets
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ReserveWithdrawAssets(Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation dest, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation beneficiary, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiAssets assets, Substrate.NetApi.Model.Types.Primitive.U32 fee_asset_item)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(dest.Encode());
            byteArray.AddRange(beneficiary.Encode());
            byteArray.AddRange(assets.Encode());
            byteArray.AddRange(fee_asset_item.Encode());
            return new Method(51, "PolkadotXcm", 200, "reserve_withdraw_assets", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> limited_reserve_withdraw_assets
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method LimitedReserveWithdrawAssets(Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation dest, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation beneficiary, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiAssets assets, Substrate.NetApi.Model.Types.Primitive.U32 fee_asset_item, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.v3.EnumWeightLimit weight_limit)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(dest.Encode());
            byteArray.AddRange(beneficiary.Encode());
            byteArray.AddRange(assets.Encode());
            byteArray.AddRange(fee_asset_item.Encode());
            byteArray.AddRange(weight_limit.Encode());
            return new Method(51, "PolkadotXcm", 201, "limited_reserve_withdraw_assets", byteArray.ToArray());
        }
    }
    
    public sealed class PolkadotXcmConstants
    {
    }
    
    public enum PolkadotXcmErrors
    {
        
        /// <summary>
        /// >> Unreachable
        /// The desired destination was unreachable, generally because there is a no way of routing
        /// to it.
        /// </summary>
        Unreachable,
        
        /// <summary>
        /// >> SendFailure
        /// There was some other issue (i.e. not to do with routing) in sending the message. Perhaps
        /// a lack of space for buffering the message.
        /// </summary>
        SendFailure,
        
        /// <summary>
        /// >> Filtered
        /// The message execution fails the filter.
        /// </summary>
        Filtered,
        
        /// <summary>
        /// >> UnweighableMessage
        /// The message's weight could not be determined.
        /// </summary>
        UnweighableMessage,
        
        /// <summary>
        /// >> DestinationNotInvertible
        /// The destination `MultiLocation` provided cannot be inverted.
        /// </summary>
        DestinationNotInvertible,
        
        /// <summary>
        /// >> Empty
        /// The assets to be sent are empty.
        /// </summary>
        Empty,
        
        /// <summary>
        /// >> CannotReanchor
        /// Could not re-anchor the assets to declare the fees for the destination chain.
        /// </summary>
        CannotReanchor,
        
        /// <summary>
        /// >> TooManyAssets
        /// Too many assets have been attempted for transfer.
        /// </summary>
        TooManyAssets,
        
        /// <summary>
        /// >> InvalidOrigin
        /// Origin is invalid for sending.
        /// </summary>
        InvalidOrigin,
        
        /// <summary>
        /// >> BadVersion
        /// The version of the `Versioned` value used is not able to be interpreted.
        /// </summary>
        BadVersion,
        
        /// <summary>
        /// >> BadLocation
        /// The given location could not be used (e.g. because it cannot be expressed in the
        /// desired version of XCM).
        /// </summary>
        BadLocation,
        
        /// <summary>
        /// >> NoSubscription
        /// The referenced subscription could not be found.
        /// </summary>
        NoSubscription,
        
        /// <summary>
        /// >> AlreadySubscribed
        /// The location is invalid since it already has a subscription from us.
        /// </summary>
        AlreadySubscribed,
        
        /// <summary>
        /// >> InvalidAsset
        /// Invalid asset for the operation.
        /// </summary>
        InvalidAsset,
        
        /// <summary>
        /// >> LowBalance
        /// The owner does not own (all) of the asset that they wish to do the operation on.
        /// </summary>
        LowBalance,
        
        /// <summary>
        /// >> TooManyLocks
        /// The asset owner has too many locks on the asset.
        /// </summary>
        TooManyLocks,
        
        /// <summary>
        /// >> AccountNotSovereign
        /// The given account is not an identifiable sovereign account for any location.
        /// </summary>
        AccountNotSovereign,
        
        /// <summary>
        /// >> FeesNotMet
        /// The operation required fees to be paid which the initiator could not meet.
        /// </summary>
        FeesNotMet,
        
        /// <summary>
        /// >> LockNotFound
        /// A remote lock with the corresponding data could not be found.
        /// </summary>
        LockNotFound,
        
        /// <summary>
        /// >> InUse
        /// The unlock operation cannot succeed because there are still users of the lock.
        /// </summary>
        InUse,
    }
}
