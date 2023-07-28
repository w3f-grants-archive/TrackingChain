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
    
    
    public sealed class CollatorSelectionStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public CollatorSelectionStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("CollatorSelection", "Invulnerables"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("CollatorSelection", "Candidates"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_collator_selection.pallet.CandidateInfo>)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("CollatorSelection", "LastAuthoredBlock"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32), typeof(Substrate.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("CollatorSelection", "DesiredCandidates"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("CollatorSelection", "CandidacyBond"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Primitive.U128)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("CollatorSelection", "SlashDestination"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32)));
        }
        
        /// <summary>
        /// >> InvulnerablesParams
        ///  The invulnerable, fixed collators.
        /// </summary>
        public static string InvulnerablesParams()
        {
            return RequestGenerator.GetStorage("CollatorSelection", "Invulnerables", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> InvulnerablesDefault
        /// Default value as hex string
        /// </summary>
        public static string InvulnerablesDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Invulnerables
        ///  The invulnerable, fixed collators.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>> Invulnerables(CancellationToken token)
        {
            string parameters = CollatorSelectionStorage.InvulnerablesParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> CandidatesParams
        ///  The (community, limited) collation candidates.
        /// </summary>
        public static string CandidatesParams()
        {
            return RequestGenerator.GetStorage("CollatorSelection", "Candidates", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> CandidatesDefault
        /// Default value as hex string
        /// </summary>
        public static string CandidatesDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Candidates
        ///  The (community, limited) collation candidates.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_collator_selection.pallet.CandidateInfo>> Candidates(CancellationToken token)
        {
            string parameters = CollatorSelectionStorage.CandidatesParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_collator_selection.pallet.CandidateInfo>>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> LastAuthoredBlockParams
        ///  Last block authored by collator.
        /// </summary>
        public static string LastAuthoredBlockParams(Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
        {
            return RequestGenerator.GetStorage("CollatorSelection", "LastAuthoredBlock", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> LastAuthoredBlockDefault
        /// Default value as hex string
        /// </summary>
        public static string LastAuthoredBlockDefault()
        {
            return "0x00000000";
        }
        
        /// <summary>
        /// >> LastAuthoredBlock
        ///  Last block authored by collator.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U32> LastAuthoredBlock(Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key, CancellationToken token)
        {
            string parameters = CollatorSelectionStorage.LastAuthoredBlockParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U32>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> DesiredCandidatesParams
        ///  Desired number of candidates.
        /// 
        ///  This should ideally always be less than [`Config::MaxCandidates`] for weights to be correct.
        /// </summary>
        public static string DesiredCandidatesParams()
        {
            return RequestGenerator.GetStorage("CollatorSelection", "DesiredCandidates", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> DesiredCandidatesDefault
        /// Default value as hex string
        /// </summary>
        public static string DesiredCandidatesDefault()
        {
            return "0x00000000";
        }
        
        /// <summary>
        /// >> DesiredCandidates
        ///  Desired number of candidates.
        /// 
        ///  This should ideally always be less than [`Config::MaxCandidates`] for weights to be correct.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U32> DesiredCandidates(CancellationToken token)
        {
            string parameters = CollatorSelectionStorage.DesiredCandidatesParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U32>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> CandidacyBondParams
        ///  Fixed amount to deposit to become a collator.
        /// 
        ///  When a collator calls `leave_intent` they immediately receive the deposit back.
        /// </summary>
        public static string CandidacyBondParams()
        {
            return RequestGenerator.GetStorage("CollatorSelection", "CandidacyBond", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> CandidacyBondDefault
        /// Default value as hex string
        /// </summary>
        public static string CandidacyBondDefault()
        {
            return "0x00000000000000000000000000000000";
        }
        
        /// <summary>
        /// >> CandidacyBond
        ///  Fixed amount to deposit to become a collator.
        /// 
        ///  When a collator calls `leave_intent` they immediately receive the deposit back.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U128> CandidacyBond(CancellationToken token)
        {
            string parameters = CollatorSelectionStorage.CandidacyBondParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U128>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> SlashDestinationParams
        ///  Destination account for slashed amount.
        /// </summary>
        public static string SlashDestinationParams()
        {
            return RequestGenerator.GetStorage("CollatorSelection", "SlashDestination", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> SlashDestinationDefault
        /// Default value as hex string
        /// </summary>
        public static string SlashDestinationDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> SlashDestination
        ///  Destination account for slashed amount.
        /// </summary>
        public async Task<Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> SlashDestination(CancellationToken token)
        {
            string parameters = CollatorSelectionStorage.SlashDestinationParams();
            var result = await _client.GetStorageAsync<Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>(parameters, token);
            return result;
        }
    }
    
    public sealed class CollatorSelectionCalls
    {
        
        /// <summary>
        /// >> set_invulnerables
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SetInvulnerables(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(41, "CollatorSelection", 0, "set_invulnerables", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_desired_candidates
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SetDesiredCandidates(Substrate.NetApi.Model.Types.Primitive.U32 max)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(max.Encode());
            return new Method(41, "CollatorSelection", 1, "set_desired_candidates", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_candidacy_bond
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SetCandidacyBond(Substrate.NetApi.Model.Types.Primitive.U128 bond)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(bond.Encode());
            return new Method(41, "CollatorSelection", 2, "set_candidacy_bond", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> register_as_candidate
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method RegisterAsCandidate()
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            return new Method(41, "CollatorSelection", 3, "register_as_candidate", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> leave_intent
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method LeaveIntent()
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            return new Method(41, "CollatorSelection", 4, "leave_intent", byteArray.ToArray());
        }
    }
    
    public sealed class CollatorSelectionConstants
    {
    }
    
    public enum CollatorSelectionErrors
    {
        
        /// <summary>
        /// >> TooManyCandidates
        /// Too many candidates
        /// </summary>
        TooManyCandidates,
        
        /// <summary>
        /// >> TooFewCandidates
        /// Too few candidates
        /// </summary>
        TooFewCandidates,
        
        /// <summary>
        /// >> Unknown
        /// Unknown error
        /// </summary>
        Unknown,
        
        /// <summary>
        /// >> Permission
        /// Permission issue
        /// </summary>
        Permission,
        
        /// <summary>
        /// >> AlreadyCandidate
        /// User is already a candidate
        /// </summary>
        AlreadyCandidate,
        
        /// <summary>
        /// >> NotCandidate
        /// User is not a candidate
        /// </summary>
        NotCandidate,
        
        /// <summary>
        /// >> AlreadyInvulnerable
        /// User is already an Invulnerable
        /// </summary>
        AlreadyInvulnerable,
        
        /// <summary>
        /// >> NoAssociatedValidatorId
        /// Account has no associated validator ID
        /// </summary>
        NoAssociatedValidatorId,
        
        /// <summary>
        /// >> ValidatorNotRegistered
        /// Validator ID is not yet registered
        /// </summary>
        ValidatorNotRegistered,
    }
}
