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
    
    
    public sealed class XtokensStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public XtokensStorage(SubstrateClientExt client)
        {
            this._client = client;
        }
    }
    
    public sealed class XtokensCalls
    {
        
        /// <summary>
        /// >> transfer
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Transfer(Substrate.NetApi.Model.Types.Primitive.U128 currency_id, Substrate.NetApi.Model.Types.Primitive.U128 amount, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation dest, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.v3.EnumWeightLimit dest_weight_limit)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(currency_id.Encode());
            byteArray.AddRange(amount.Encode());
            byteArray.AddRange(dest.Encode());
            byteArray.AddRange(dest_weight_limit.Encode());
            return new Method(55, "Xtokens", 0, "transfer", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> transfer_multiasset
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method TransferMultiasset(Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiAsset asset, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation dest, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.v3.EnumWeightLimit dest_weight_limit)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(asset.Encode());
            byteArray.AddRange(dest.Encode());
            byteArray.AddRange(dest_weight_limit.Encode());
            return new Method(55, "Xtokens", 1, "transfer_multiasset", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> transfer_with_fee
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method TransferWithFee(Substrate.NetApi.Model.Types.Primitive.U128 currency_id, Substrate.NetApi.Model.Types.Primitive.U128 amount, Substrate.NetApi.Model.Types.Primitive.U128 fee, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation dest, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.v3.EnumWeightLimit dest_weight_limit)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(currency_id.Encode());
            byteArray.AddRange(amount.Encode());
            byteArray.AddRange(fee.Encode());
            byteArray.AddRange(dest.Encode());
            byteArray.AddRange(dest_weight_limit.Encode());
            return new Method(55, "Xtokens", 2, "transfer_with_fee", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> transfer_multiasset_with_fee
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method TransferMultiassetWithFee(Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiAsset asset, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiAsset fee, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation dest, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.v3.EnumWeightLimit dest_weight_limit)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(asset.Encode());
            byteArray.AddRange(fee.Encode());
            byteArray.AddRange(dest.Encode());
            byteArray.AddRange(dest_weight_limit.Encode());
            return new Method(55, "Xtokens", 3, "transfer_multiasset_with_fee", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> transfer_multicurrencies
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method TransferMulticurrencies(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>> currencies, Substrate.NetApi.Model.Types.Primitive.U32 fee_item, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation dest, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.v3.EnumWeightLimit dest_weight_limit)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(currencies.Encode());
            byteArray.AddRange(fee_item.Encode());
            byteArray.AddRange(dest.Encode());
            byteArray.AddRange(dest_weight_limit.Encode());
            return new Method(55, "Xtokens", 4, "transfer_multicurrencies", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> transfer_multiassets
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method TransferMultiassets(Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiAssets assets, Substrate.NetApi.Model.Types.Primitive.U32 fee_item, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation dest, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.v3.EnumWeightLimit dest_weight_limit)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(assets.Encode());
            byteArray.AddRange(fee_item.Encode());
            byteArray.AddRange(dest.Encode());
            byteArray.AddRange(dest_weight_limit.Encode());
            return new Method(55, "Xtokens", 5, "transfer_multiassets", byteArray.ToArray());
        }
    }
    
    public sealed class XtokensConstants
    {
        
        /// <summary>
        /// >> SelfLocation
        ///  Self chain location.
        /// </summary>
        public Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.v3.multilocation.MultiLocation SelfLocation()
        {
            var result = new Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.v3.multilocation.MultiLocation();
            result.Create("0x0000");
            return result;
        }
        
        /// <summary>
        /// >> BaseXcmWeight
        ///  Base XCM weight.
        /// 
        ///  The actually weight for an XCM message is `T::BaseXcmWeight +
        ///  T::Weigher::weight(&msg)`.
        /// </summary>
        public Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight BaseXcmWeight()
        {
            var result = new Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight();
            result.Create("0x02286BEE02000400");
            return result;
        }
    }
    
    public enum XtokensErrors
    {
        
        /// <summary>
        /// >> AssetHasNoReserve
        /// Asset has no reserve location.
        /// </summary>
        AssetHasNoReserve,
        
        /// <summary>
        /// >> NotCrossChainTransfer
        /// Not cross-chain transfer.
        /// </summary>
        NotCrossChainTransfer,
        
        /// <summary>
        /// >> InvalidDest
        /// Invalid transfer destination.
        /// </summary>
        InvalidDest,
        
        /// <summary>
        /// >> NotCrossChainTransferableCurrency
        /// Currency is not cross-chain transferable.
        /// </summary>
        NotCrossChainTransferableCurrency,
        
        /// <summary>
        /// >> UnweighableMessage
        /// The message's weight could not be determined.
        /// </summary>
        UnweighableMessage,
        
        /// <summary>
        /// >> XcmExecutionFailed
        /// XCM execution failed.
        /// </summary>
        XcmExecutionFailed,
        
        /// <summary>
        /// >> CannotReanchor
        /// Could not re-anchor the assets to declare the fees for the
        /// destination chain.
        /// </summary>
        CannotReanchor,
        
        /// <summary>
        /// >> InvalidAncestry
        /// Could not get ancestry of asset reserve location.
        /// </summary>
        InvalidAncestry,
        
        /// <summary>
        /// >> InvalidAsset
        /// The MultiAsset is invalid.
        /// </summary>
        InvalidAsset,
        
        /// <summary>
        /// >> DestinationNotInvertible
        /// The destination `MultiLocation` provided cannot be inverted.
        /// </summary>
        DestinationNotInvertible,
        
        /// <summary>
        /// >> BadVersion
        /// The version of the `Versioned` value used is not able to be
        /// interpreted.
        /// </summary>
        BadVersion,
        
        /// <summary>
        /// >> DistinctReserveForAssetAndFee
        /// We tried sending distinct asset and fee but they have different
        /// reserve chains.
        /// </summary>
        DistinctReserveForAssetAndFee,
        
        /// <summary>
        /// >> ZeroFee
        /// The fee is zero.
        /// </summary>
        ZeroFee,
        
        /// <summary>
        /// >> ZeroAmount
        /// The transfering asset amount is zero.
        /// </summary>
        ZeroAmount,
        
        /// <summary>
        /// >> TooManyAssetsBeingSent
        /// The number of assets to be sent is over the maximum.
        /// </summary>
        TooManyAssetsBeingSent,
        
        /// <summary>
        /// >> AssetIndexNonExistent
        /// The specified index does not exist in a MultiAssets struct.
        /// </summary>
        AssetIndexNonExistent,
        
        /// <summary>
        /// >> FeeNotEnough
        /// Fee is not enough.
        /// </summary>
        FeeNotEnough,
        
        /// <summary>
        /// >> NotSupportedMultiLocation
        /// Not supported MultiLocation
        /// </summary>
        NotSupportedMultiLocation,
        
        /// <summary>
        /// >> MinXcmFeeNotDefined
        /// MinXcmFee not registered for certain reserve location
        /// </summary>
        MinXcmFeeNotDefined,
    }
}
