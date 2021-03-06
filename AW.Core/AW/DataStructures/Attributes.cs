// // (c) 2007 - 2011 Joshua R. Rodgers under the terms of the Ms-PL license.
using System;

namespace AW
{
    /// <summary>
    /// This enumeration specifies all attributes used to operate the SDK.
    /// </summary>
    /// <remarks>
    /// There are several functions that require an attribute to be specified.  These include:
    /// <list type="bullet">
    ///     <item><description><see cref="AW.Instance.SetInt">AW.Instance.SetInt</see></description></item>
    ///     <item><description><see cref="AW.Instance.GetInt">AW.Instance.GetInt</see></description></item>
    ///     <item><description><see cref="AW.Instance.SetString">AW.Instance.SetString</see></description></item>
    ///     <item><description><see cref="AW.Instance.GetString">AW.Instance.GetString</see></description></item>
    ///     <item><description><see cref="AW.Instance.SetFloat">AW.Instance.SetFloat</see></description></item>
    ///     <item><description><see cref="AW.Instance.GetFloat">AW.Instance.GetFloat</see></description></item>
    ///     <item><description><see cref="AW.Instance.SetBool">AW.Instance.SetBool</see></description></item>
    ///     <item><description><see cref="AW.Instance.GetBool">AW.Instance.GetBool</see></description></item>
    ///     <item><description><see cref="AW.Instance.SetData">AW.Instance.SetData</see></description></item>
    ///     <item><description><see cref="AW.Instance.GetData">AW.Instance.GetData</see></description></item>
    /// </list>
    /// </remarks>
    [Obsolete("This enum is now obsolete, use the AW.IInstance.Attributes property instead.")]
    public enum Attributes
    {
        /// <summary>
        /// Specifies the name of the instance before calling <see>AW.Instance.Login</see>. 
        /// </summary>
        /// <remarks>
        /// The name can be between 2 and 16 characters in length.
        /// Valid characters for use in the names are A-Z, a-z, 0-9, spaces (' ') and punctuation marks ('.'). 
        /// </remarks>
        LoginName,

        /// <summary>
        /// Not available to the SDK.
        /// </summary>
        LoginPassword,

        /// <summary>
        /// Specifies the citizen number of the bot's owner before a call to <see>AW.Instance.Login</see>.
        /// </summary>
        /// <remarks>
        /// All bots must be owned by a citizen. This attribute must be combined with <see>AW.Attributes.LoginPrivilegePassword</see> to identify the owner.
        /// </remarks>
        LoginOwner,

        /// <summary>
        /// Specifies the privilege password of the bot's owner before a call to <see>AW.Instance.Login</see>.
        /// </summary>
        /// <remarks>
        /// All bots must be owned by a citizen. This attribute must be combined with <see>AW.Attributes.LoginOwner</see> to identify the owner.
        /// </remarks>
        LoginPrivilegePassword,

        /// <summary>
        /// Not available to the SDK.
        /// </summary>
        LoginPrivilegeNumber,

        /// <summary>
        /// Not available to the SDK.
        /// </summary>
        LoginPrivilegeName,

        /// <summary>
        /// An optional string, specifying the name of the application upon a call to <see>AW.Instance.Login</see>
        /// </summary>
        /// <remarks>
        /// This is an optional string and is not required for applications to login.
        /// </remarks>
        LoginApplication,

        /// <summary>
        /// Not available to the SDK.
        /// </summary>
        LoginEmail,


        UniverseBrowserMinimum,
        UniverseBrowserRelease,
        UniverseBrowserBeta,
        UniverseWorldMinimum,
        UniverseWorldStart,
        UniverseRegistrationRequired,
        UniverseBuildNumber,
        UniverseMonthlyCharge,
        UniverseAnnualCharge,
        UniverseRegisterMethod,
        UniverseTime,
        UniverseCitizenChangesAllowed,
        UniverseBrowserRelease22,
        UniverseWelcomeMessage,
        UniverseWorldRelease,
        UniverseWorldBeta,
        UniverseAllowTourists,
        UniverseSearchUrl,
        UniverseNotepadUrl,
        UniverseName,
        UniverseUserListEnabled,
        CitizenNumber,
        CitizenName,
        CitizenPassword,
        CitizenEmail,
        CitizenTimeLeft,
        CitizenPrivilegePassword,
        CitizenImmigrationTime,
        CitizenExpirationTime,
        CitizenBeta,
        CitizenLastLogin,
        CitizenBotLimit,
        CitizenTotalTime,
        CitizenEnabled,
        CitizenComment,
        CitizenUrl,
        WorldName,
        WorldTitle,
        WorldBackdrop,
        WorldGround,
        WorldObjectPath,
        WorldObjectRefresh,
        WorldBuildRight,
        WorldEminentDomainRight,
        WorldEnterRight,
        WorldSpecialObjectsRight,
        WorldFogRed,
        WorldFogGreen,
        WorldFogBlue,
        WorldCaretakerCapability,
        WorldRestrictedRadius,
        WorldPublicSpeakerCapability,
        WorldPublicSpeakerRight,
        WorldCreationTimestamp,
        WorldHomePage,
        WorldBuildNumber,
        WorldObjectPassword,
        WorldDisableCreateUrl,
        WorldRating,
        WorldWelcomeMessage,
        WorldEjectRight,
        WorldEjectCapability,
        WorldCellLimit,
        WorldBuildCapability,
        WorldAllowPassthru,
        WorldAllowFlying,
        WorldAllowTeleport,
        WorldAllowObjectSelect,
        WorldBotsRight,
        WorldSpeakCapability,
        WorldSpeakRight,
        WorldAllowTouristWhisper,
        WorldLightX,
        WorldLightY,
        WorldLightZ,
        WorldLightRed,
        WorldLightGreen,
        WorldLightBlue,
        WorldAmbientLightRed,
        WorldAmbientLightGreen,
        WorldAmbientLightBlue,
        WorldAllowAvatarCollision,
        WorldFogEnable,
        WorldFogMinimum,
        WorldFogMaximum,
        WorldFogTinted,
        WorldMaxUsers,
        WorldSize,
        WorldObjectCount,
        WorldExpiration,
        WorldSpecialCommandsRight,
        WorldMaxLightRadius,
        WorldSkybox,
        WorldMinimumVisibility,
        WorldRepeatingGround,
        WorldKeywords,
        WorldEnableTerrain,
        WorldAllow3AxisRotation,
        WorldTerrainTimestamp,
        WorldEntryPoint,
        WorldSkyNorthRed,
        WorldSkyNorthGreen,
        WorldSkyNorthBlue,
        WorldSkySouthRed,
        WorldSkySouthGreen,
        WorldSkySouthBlue,
        WorldSkyEastRed,
        WorldSkyEastGreen,
        WorldSkyEastBlue,
        WorldSkyWestRed,
        WorldSkyWestGreen,
        WorldSkyWestBlue,
        WorldSkyTopRed,
        WorldSkyTopGreen,
        WorldSkyTopBlue,
        WorldSkyBottomRed,
        WorldSkyBottomGreen,
        WorldSkyBottomBlue,
        WorldCloudsLayer1Texture,
        WorldCloudsLayer1Mask,
        WorldCloudsLayer1Tile,
        WorldCloudsLayer1SpeedX,
        WorldCloudsLayer1SpeedZ,
        WorldCloudsLayer1Opacity,
        WorldCloudsLayer2Texture,
        WorldCloudsLayer2Mask,
        WorldCloudsLayer2Tile,
        WorldCloudsLayer2SpeedX,
        WorldCloudsLayer2SpeedZ,
        WorldCloudsLayer2Opacity,
        WorldCloudsLayer3Texture,
        WorldCloudsLayer3Mask,
        WorldCloudsLayer3Tile,
        WorldCloudsLayer3SpeedX,
        WorldCloudsLayer3SpeedZ,
        WorldCloudsLayer3Opacity,
        WorldDisableChat,
        WorldAllowCitizenWhisper,
        WorldAlwaysShowNames,
        WorldDisableAvatarList,
        WorldAvatarRefreshRate,
        WorldWaterTexture,
        WorldWaterMask,
        WorldWaterBottomTexture,
        WorldWaterBottomMask,
        WorldWaterOpacity,
        WorldWaterRed,
        WorldWaterGreen,
        WorldWaterBlue,
        WorldWaterLevel,
        WorldWaterSurfaceMove,
        WorldWaterWaveMove,
        WorldWaterSpeed,
        WorldWaterEnabled,
        WorldEminentDomainCapability,
        WorldLightTexture,
        WorldLightMask,
        WorldLightDrawSize,
        WorldLightDrawFront,
        WorldLightDrawBright,
        WorldLightSourceUseColor,
        WorldLightSourceColor,
        WorldTerrainAmbient,
        WorldTerrainDiffuse,
        WorldWaterVisibility,
        WorldSoundFootstep,
        WorldSoundWaterEnter,
        WorldSoundWaterExit,
        WorldSoundAmbient,
        WorldGravity,
        WorldBuoyancy,
        WorldFriction,
        WorldWaterFriction,
        WorldSlopeslideEnabled,
        WorldSlopeslideMinAngle,
        WorldSlopeslideMaxAngle,
        WorldAllowTouristBuild,
        WorldEnableReferer,
        WorldWaterUnderTerrain,
        WorldTerrainOffset,
        WorldVoipRight,
        WorldDisableMultipleMedia,
        WorldBotmenuUrl,
        WorldEnableBumpEvent,
        WorldEnableSyncEvents,
        WorldEnableCav,
        WorldEnablePav,
        WorldChatDisableUrlClicks,
        WorldMoverEmptyResetTimeout,
        WorldMoverUsedResetTimeout,
        MyX,
        MyY,
        MyZ,
        MyYaw,
        MyPitch,
        MyType,
        MyGesture,
        MyState,
        AvatarSession,
        AvatarName,
        AvatarX,
        AvatarY,
        AvatarZ,
        AvatarYaw,
        AvatarPitch,
        AvatarType,
        AvatarGesture,
        AvatarState,
        AvatarAddress,
        AvatarVersion,
        AvatarCitizen,
        AvatarPrivilege,
        AvatarLock,
        AvatarFlags,
        ChatSession,
        ChatMessage,
        CellX,
        CellZ,
        CellSequence,
        CellSize,
        CellIterator,
        CellCombine,
        ObjectId,
        ObjectNumber,
        ObjectX,
        ObjectY,
        ObjectZ,
        ObjectYaw,
        ObjectTilt,
        ObjectRoll,
        ObjectModel,
        ObjectDescription,
        ObjectAction,
        ObjectOldNumber,
        ObjectOldX,
        ObjectOldZ,
        ObjectOwner,
        ObjectSession,
        ObjectBuildTimestamp,
        ObjectSync,
        ObjectType,
        ObjectData,
        QueryComplete,
        ChatType,
        LicenseName,
        LicensePassword,
        LicenseUsers,
        LicenseRange,
        LicenseEmail,
        LicenseComment,
        LicenseCreationTime,
        LicenseExpirationTime,
        LicenseLastStart,
        LicenseLastAddress,
        LicenseHidden,
        LicenseAllowTourists,
        LicenseVoip,
        LicensePlugins,
        WorldListName,
        WorldListStatus,
        WorldListUsers,
        WorldListRating,
        WorldListMore,
        EjectSession,
        EjectDuration,
        EjectionType,
        EjectionAddress,
        EjectionExpirationTime,
        EjectionCreationTime,
        EjectionComment,
        DisconnectReason,
        FileRecipient,
        FileSender,
        FileSenderName,
        FileSession,
        FileAddress,
        FilePort,
        ClickedSession,
        ClickedName,
        UrlName,
        UrlPost,
        UrlTarget,
        UrlTarget3D,
        TeleportWorld,
        TeleportX,
        TeleportY,
        TeleportZ,
        TeleportYaw,
        TeleportWarp,
        ServerBuild,
        ServerName,
        ServerPassword,
        ServerRegistry,
        ServerCaretakers,
        ServerId,
        ServerInstance,
        ServerEnabled,
        ServerState,
        ServerUsers,
        ServerMaxUsers,
        ServerObjects,
        ServerSize,
        ServerExpiration,
        ServerStartRc,
        ServerMore,
        ServerTerrainNodes,
        TerrainX,
        TerrainZ,
        TerrainPageX,
        TerrainPageZ,
        TerrainNodeX,
        TerrainNodeZ,
        TerrainNodeSize,
        TerrainNodeTextureCount,
        TerrainNodeHeightCount,
        TerrainNodeTextures,
        TerrainNodeHeights,
        TerrainSequence,
        TerrainComplete,
        TerrainVersionNeeded,
        EnterGlobal,
        ConsoleRed,
        ConsoleGreen,
        ConsoleBlue,
        ConsoleBold,
        ConsoleItalics,
        ConsoleMessage,
        BotgramTo,
        BotgramFrom,
        BotgramFromName,
        BotgramType,
        BotgramText,
        ToolbarId,
        ToolbarSession,
        UserlistMore,
        UserlistName,
        UserlistWorld,
        UserlistEmail,
        UserlistCitizen,
        UserlistPrivilege,
        UserlistState,
        UserlistAddress,
        UserlistId,
        SoundName,
        CameraLocationType,
        CameraLocationObject,
        CameraLocationSession,
        CameraTargetType,
        CameraTargetObject,
        CameraTargetSession,
        PluginString,
        BotmenuToSession,
        BotmenuFromName,
        BotmenuFromSession,
        BotmenuQuestion,
        BotmenuAnswer,
        UniverseCavPath = 396,
        CitizenPavEnabled,
        CavCitizen,
        CavDefinition,
        EntityType,
        EntityId,
        EntityState,
        EntityFlags,
        EntityX,
        EntityY,
        EntityZ,
        EntityYaw,
        EntityPitch,
        EntityRoll,
        EntityOwnerSession,
        EntityOwnerCitizen,
        AvatarDistance,
        AvatarAngle,
        AvatarYDelta,
        AvatarYawDelta,
        AvatarPitchDelta,
        AvatarWorldInstance,
        AttribSenderSession,
        EntityModelNum,
        WorldV4ObjectsRight,
        CitizenLastAddress,
        HudElementType,
        HudElementId,
        HudElementSession,
        HudElementOrigin,
        HudElementX,
        HudElementY,
        HudElementZ,
        HudElementFlags,
        HudElementText,
        HudElementColor,
        HudElementOpacity,
        HudElementSizeX,
        HudElementSizeY,
        HudElementSizeZ,
        HudElementClickX,
        HudElementClickY,
        HudElementClickZ,
        HudElementTextureOffsetX,
        HudElementTextureOffsetY,
        CitizenPrivacy,
        CitizenTrial,
        UniverseCavPath2,
        WorldDisableShadows,
        WorldEnableCameraCollision,
        WorldSpecialCommands,
        UniverseObjectRefresh,
        UniverseObjectPassword,
        CavSession,
        CitizenCavEnabled,
        WorldCavObjectPath,
        WorldCavObjectPassword,
        WorldCavObjectRefresh,
        ObjectCallbackReference,
        WorldTerrainRight,
        UniverseAllowTouristsCav,
        UniverseAllowBotsCav,
        WorldVoipConferenceGlobal,
        WorldVoipModerateGlobal,
        ObjectSessionTo,
        WorldCameraZoom,
        WorldWaitLimit,
        XferDisconnectReason,
        XferType,
        XferFromSession,
        XferFromName,
        XferToSession,
        XferToName,
        XferToWorldName,
        XferToZoneName,
        XferToTagName,
        XferDataId,
        XferDataFileName,
        XferDataLenTotal,
        XferDataLenOffset,
        XferData,
        XferData2,
        XferData3,
        XferDataMore,
        XferRc,
        XferShowName,
        XferOptions,
        XferExpiration,
        LicenseXferShowRights,
        XferShowCapability,
        XferShowSequence,
        LaserBeamSourceType,
        LaserBeamSourceId,
        LaserBeamSourceX,
        LaserBeamSourceY,
        LaserBeamSourceZ,
        LaserBeamTargetType,
        LaserBeamTargetId,
        LaserBeamTargetX,
        LaserBeamTargetY,
        LaserBeamTargetZ,
        LaserBeamStyle,
        LaserBeamColor,
        LaserBeamDefinition,
        WorldVoipcastHost,
        WorldVoipcastPort,
        MyZone,
        AvatarZone,
        UniversePerCitizenCav,
        XferOwner,
        WorldEnableWireframe,
        ShopItemId,
        ShopItemCreation,
        ShopItemExpiration,
        ShopItemPrice,
        ShopItemType,
        ShopItemCategory,
        ShopItemDescription,
        ShopItemObject,
        ShopItemDefinition,
        ShopTransId,
        ShopTransCitizen,
        ShopTransItemid,
        ShopTransAmount,
        ShopTransDate,
        ShopTransSeller,
        ShopTransComment,
        ShopTransTotal,
        ShopTransIterator,
        ShopTransMore,
        ShopItemChanged,
        LicenseShop,
        CitizenPasswordExpire,
        UniverseExpirationDate,
        UniverseImmigration,
        CitizenSecondaryPassword,
        ChatChannel,
        ChatCitizen,
        WorldChatChannel1Name,
        WorldChatChannel2Name,
        WorldChatChannel3Name,
        WorldChatChannel4Name,
        WorldChatChannel5Name,
        WorldChatChannel1Color,
        WorldChatChannel2Color,
        WorldChatChannel3Color,
        WorldChatChannel4Color,
        WorldChatChannel5Color,
        WorldListBots
    }
}