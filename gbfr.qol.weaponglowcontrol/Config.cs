using gbfr.qol.weaponglowcontrol.Template.Configuration;

using Reloaded.Mod.Interfaces.Structs;

using System.ComponentModel;

namespace gbfr.qol.weaponglowcontrol.Configuration
{
    public class Config : Configurable<Config>
    {
        // 0000-0100
        [DisplayName("1 Sword of Eos")]
        [Category("Captain")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Captain_SwordOfEos { get; set; } = WeaponEffectControlType.Enabled;

        [DisplayName("2")]
        [Category("Captain")]
        [Description("Sword of Eos")]
        [DefaultValue(WeaponEffectSwap.Ascension)]
        public WeaponEffectSwap Captain_SwordOfEosSwap { get; set; } = WeaponEffectSwap.Ascension;

        [DisplayName("3 Seven-Star Sword")]
        [Category("Captain")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Captain_SevenStarSword { get; set; } = WeaponEffectControlType.Enabled;

        [DisplayName("4")]
        [Category("Captain")]
        [Description("Seven-Star Sword")]
        [DefaultValue(WeaponEffectSwap.Terminus)]
        public WeaponEffectSwap Captain_SevenStarSwordSwap { get; set; } = WeaponEffectSwap.Terminus;

        // 0200
        [DisplayName("1 Murgleis, the Azure Oath")]
        [Category("Katalina")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Katalina_Murgleis { get; set; } = WeaponEffectControlType.Enabled;

        [DisplayName("2")]
        [Category("Katalina")]
        [Description("Murgleis, the Azure Oath")]
        [DefaultValue(WeaponEffectSwap.Ascension)]
        public WeaponEffectSwap Katalina_MurgleisSwap { get; set; } = WeaponEffectSwap.Ascension;

        [DisplayName("3 Blutgang, Blade of Refuge")]
        [Category("Katalina")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Katalina_Blutgang { get; set; } = WeaponEffectControlType.Enabled;

        [DisplayName("4")]
        [Category("Katalina")]
        [Description("Blutgang, Blade of Refuge")]
        [DefaultValue(WeaponEffectSwap.Terminus)]
        public WeaponEffectSwap Katalina_BlutgangSwap { get; set; } = WeaponEffectSwap.Terminus;

        // 0300
        [DisplayName("1 Benedia, Azure Ammunition")]
        [Category("Rackam")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Rackam_Benedia { get; set; } = WeaponEffectControlType.Enabled;

        [DisplayName("2")]
        [Category("Rackam")]
        [Description("Benedia, Azure Ammunition")]
        [DefaultValue(WeaponEffectSwap.Ascension)]
        public WeaponEffectSwap Rackam_BenediaSwap { get; set; } = WeaponEffectSwap.Ascension;

        [DisplayName("3 Freikugel, the Purifier")]
        [Category("Rackam")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Rackam_Freikugel { get; set; } = WeaponEffectControlType.Enabled;

        [DisplayName("4")]
        [Category("Rackam")]
        [Description("Freikugel, the Purifier")]
        [DefaultValue(WeaponEffectSwap.Terminus)]
        public WeaponEffectSwap Rackam_FreikugelSwap { get; set; } = WeaponEffectSwap.Terminus;

        // 0400
        [DisplayName("1 Gambanteinn, Staff of Hope")]
        [Category("Io")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Io_Gambanteinn { get; set; } = WeaponEffectControlType.Enabled;

        [DisplayName("2")]
        [Category("Io")]
        [Description("Gambanteinn, Staff of Hope")]
        [DefaultValue(WeaponEffectSwap.Ascension)]
        public WeaponEffectSwap Io_GambanteinnSwap { get; set; } = WeaponEffectSwap.Ascension;

        [DisplayName("3 Caduceus, Immortal Coil")]
        [Category("Io")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Io_Caduceus { get; set; } = WeaponEffectControlType.Enabled;

        [DisplayName("4")]
        [Category("Io")]
        [Description("Caduceus, Immortal Coil")]
        [DefaultValue(WeaponEffectSwap.Terminus)]
        public WeaponEffectSwap Io_CaduceusSwap { get; set; } = WeaponEffectSwap.Terminus;

        // 0500
        [DisplayName("1 AK-4A, the Suppressor")]
        [Category("Eugen")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Eugen_AK4A { get; set; } = WeaponEffectControlType.Enabled;

        [DisplayName("2")]
        [Category("Eugen")]
        [Description("AK-4A, the Suppressor")]
        [DefaultValue(WeaponEffectSwap.Ascension)]
        public WeaponEffectSwap Eugen_AK4ASwap { get; set; } = WeaponEffectSwap.Ascension;

        [DisplayName("3 Draconic Fire, Charring Breath")]
        [Category("Eugen")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Eugen_DraconicFire { get; set; } = WeaponEffectControlType.Enabled;

        [DisplayName("4")]
        [Category("Eugen")]
        [Description("Draconic Fire, Charring Breath")]
        [DefaultValue(WeaponEffectSwap.Terminus)]
        public WeaponEffectSwap Eugen_DraconicFireSwap { get; set; } = WeaponEffectSwap.Terminus;

        // 0600
        [DisplayName("1 Love Eternal, Forevermore")]
        [Category("Rosetta")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Rosetta_LoveEternal { get; set; } = WeaponEffectControlType.Enabled;

        [DisplayName("2")]
        [Category("Rosetta")]
        [Description("Love Eternal, Forevermore")]
        [DefaultValue(WeaponEffectSwap.Ascension)]
        public WeaponEffectSwap Rosetta_LoveEternalSwap { get; set; } = WeaponEffectSwap.Ascension;

        [DisplayName("3 Primal Dagger of Bahamut Coda")]
        [Category("Rosetta")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Rosetta_DaggerOfBahamutCoda { get; set; } = WeaponEffectControlType.Enabled;

        [DisplayName("4")]
        [Category("Rosetta")]
        [Description("Primal Dagger of Bahamut Coda")]
        [DefaultValue(WeaponEffectSwap.Terminus)]
        public WeaponEffectSwap Rosetta_DaggerOfBahamutCodaSwap { get; set; } = WeaponEffectSwap.Terminus;

        // 0700
        [DisplayName("1 Ethereal Lasher, Fleeting End")]
        [Category("Ferry")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Ferry_EtherealLasher { get; set; } = WeaponEffectControlType.Enabled;

        [DisplayName("2")]
        [Category("Ferry")]
        [Description("Ethereal Lasher, Fleeting End")]
        [DefaultValue(WeaponEffectSwap.Ascension)]
        public WeaponEffectSwap Ferry_EtherealLasherSwap { get; set; } = WeaponEffectSwap.Ascension;

        [DisplayName("3 Erinnerung, From Beyond")]
        [Category("Ferry")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Ferry_Erinnerung { get; set; } = WeaponEffectControlType.Enabled;

        [DisplayName("4")]
        [Category("Ferry")]
        [Description("Erinnerung, From Beyond")]
        [DefaultValue(WeaponEffectSwap.Terminus)]
        public WeaponEffectSwap Ferry_ErinnerungSwap { get; set; } = WeaponEffectSwap.Terminus;

        // 0800
        [DisplayName("1 Knight of Ice, the Silver Blur")]
        [Category("Lancelot")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Lancelot_KnightOfIce { get; set; } = WeaponEffectControlType.Enabled;

        [DisplayName("2")]
        [Category("Lancelot")]
        [Description("Knight of Ice, the Silver Blur")]
        [DefaultValue(WeaponEffectSwap.Ascension)]
        public WeaponEffectSwap Lancelot_KnightOfIceSwap { get; set; } = WeaponEffectSwap.Ascension;

        [DisplayName("3 Damascus Knife, the Unseen")]
        [Category("Lancelot")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Lancelot_DamascusKnife { get; set; } = WeaponEffectControlType.Enabled;

        [DisplayName("4")]
        [Category("Lancelot")]
        [Description("Damascus Knife, the Unseen")]
        [DefaultValue(WeaponEffectSwap.Terminus)]
        public WeaponEffectSwap Lancelot_DamascusKnifeSwap { get; set; } = WeaponEffectSwap.Terminus;

        // 0900
        [DisplayName("1 Treuer Krieger, the Dauntless")]
        [Category("Vane")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Vane_TreuerKrieger { get; set; } = WeaponEffectControlType.Enabled;

        [DisplayName("2")]
        [Category("Vane")]
        [Description("Treuer Krieger, the Dauntless")]
        [DefaultValue(WeaponEffectSwap.Ascension)]
        public WeaponEffectSwap Vane_TreuerKriegerSwap { get; set; } = WeaponEffectSwap.Ascension;

        [DisplayName("3 Mjolnir, Thunderous Crusher")]
        [Category("Vane")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Vane_Mjolnir { get; set; } = WeaponEffectControlType.Enabled;

        [DisplayName("4")]
        [Category("Vane")]
        [Description("Mjolnir, Thunderous Crusher")]
        [DefaultValue(WeaponEffectSwap.Terminus)]
        public WeaponEffectSwap Vane_MjolnirSwap { get; set; } = WeaponEffectSwap.Terminus;

        // 1000
        [DisplayName("1 Lord of Flames, Exalted Reign")]
        [Category("Percival")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Percival_LordOfFlames { get; set; } = WeaponEffectControlType.Enabled;

        [DisplayName("2")]
        [Category("Percival")]
        [Description("Lord of Flames, Exalted Reign")]
        [DefaultValue(WeaponEffectSwap.Ascension)]
        public WeaponEffectSwap Percival_LordOfFlamesSwap { get; set; } = WeaponEffectSwap.Ascension;

        [DisplayName("3 Gottfried, the White Fang")]
        [Category("Percival")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Percival_Gottfried { get; set; } = WeaponEffectControlType.Enabled;

        [DisplayName("4")]
        [Category("Percival")]
        [Description("Gottfried, the White Fang")]
        [DefaultValue(WeaponEffectSwap.Terminus)]
        public WeaponEffectSwap Percival_GottfriedSwap { get; set; } = WeaponEffectSwap.Terminus;

        // 1100
        [DisplayName("1 Ascalon, Dragon's Bane")]
        [Category("Siegfried")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Siegfried_Ascalon { get; set; } = WeaponEffectControlType.Enabled;

        [DisplayName("2")]
        [Category("Siegfried")]
        [Description("Ascalon, Dragon's Bane")]
        [DefaultValue(WeaponEffectSwap.Ascension)]
        public WeaponEffectSwap Siegfried_AscalonSwap { get; set; } = WeaponEffectSwap.Ascension;

        [DisplayName("3 Balmung, the Blue Blaze")]
        [Category("Siegfried")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Siegfried_Balmung { get; set; } = WeaponEffectControlType.Enabled;

        [DisplayName("4")]
        [Category("Siegfried")]
        [Description("Balmung, the Blue Blaze")]
        [DefaultValue(WeaponEffectSwap.Terminus)]
        public WeaponEffectSwap Siegfried_BalmungSwap { get; set; } = WeaponEffectSwap.Terminus;

        // 1200
        [DisplayName("1 Claidheamh Soluis, the Radiant")]
        [Category("Charlotta")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Charlotta_Claidheamh { get; set; } = WeaponEffectControlType.Enabled;

        [DisplayName("2")]
        [Category("Charlotta")]
        [Description("Claidheamh Soluis, the Radiant")]
        [DefaultValue(WeaponEffectSwap.Ascension)]
        public WeaponEffectSwap Charlotta_ClaidheamhSwap { get; set; } = WeaponEffectSwap.Ascension;

        [DisplayName("3 Galatine, Trinity's Wrath")]
        [Category("Charlotta")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Charlotta_Galatine { get; set; } = WeaponEffectControlType.Enabled;

        [DisplayName("4")]
        [Category("Charlotta")]
        [Description("Galatine, Trinity's Wrath")]
        [DefaultValue(WeaponEffectSwap.Terminus)]
        public WeaponEffectSwap Charlotta_GalatineSwap { get; set; } = WeaponEffectSwap.Terminus;

        // 1300
        [DisplayName("1 Fudo-Kuniyuki, Scarlet Glory")]
        [Category("Yodarha")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Yodarha_FudoKuniyuki { get; set; } = WeaponEffectControlType.Enabled;

        [DisplayName("2")]
        [Category("Yodarha")]
        [Description("Fudo-Kuniyuki, Scarlet Glory")]
        [DefaultValue(WeaponEffectSwap.Ascension)]
        public WeaponEffectSwap Yodarha_FudoKuniyukiSwap { get; set; } = WeaponEffectSwap.Ascension;

        [DisplayName("3 Swordfish, Tipper of Scales")]
        [Category("Yodarha")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Yodarha_Swordfish { get; set; } = WeaponEffectControlType.Enabled;

        [DisplayName("4")]
        [Category("Yodarha")]
        [Description("Swordfish, Tipper of Scales")]
        [DefaultValue(WeaponEffectSwap.Terminus)]
        public WeaponEffectSwap Yodarha_SwordfishSwap { get; set; } = WeaponEffectSwap.Terminus;

        // 1400
        [DisplayName("1 Venustas, the Sacred Gift")]
        [Category("Narmaya")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Narmaya_Venustas { get; set; } = WeaponEffectControlType.Enabled;

        [DisplayName("2")]
        [Category("Narmaya")]
        [Description("Venustas, the Sacred Gift")]
        [DefaultValue(WeaponEffectSwap.Ascension)]
        public WeaponEffectSwap Narmaya_VenustasSwap { get; set; } = WeaponEffectSwap.Ascension;

        [DisplayName("3 Ameno Habakiri, the Beheader")]
        [Category("Narmaya")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Narmaya_AmenoHabakiri { get; set; } = WeaponEffectControlType.Enabled;

        [DisplayName("4")]
        [Category("Narmaya")]
        [Description("Ameno Habakiri, the Beheader")]
        [DefaultValue(WeaponEffectSwap.Terminus)]
        public WeaponEffectSwap Narmaya_AmenoHabakiriSwap { get; set; } = WeaponEffectSwap.Terminus;

        // 1500
        [DisplayName("1 Golden Fists of Ura, No Mercy")]
        [Category("Ghandagoza")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Ghandagoza_GoldenFistsOfUra { get; set; } = WeaponEffectControlType.Enabled;

        [DisplayName("2")]
        [Category("Ghandagoza")]
        [Description("Golden Fists of Ura, No Mercy")]
        [DefaultValue(WeaponEffectSwap.Ascension)]
        public WeaponEffectSwap Ghandagoza_GoldenFistsOfUraSwap { get; set; } = WeaponEffectSwap.Ascension;

        [DisplayName("3 Sky Piercer, the Apex Fist")]
        [Category("Ghandagoza")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Ghandagoza_SkyPiercer { get; set; } = WeaponEffectControlType.Enabled;

        [DisplayName("4")]
        [Category("Ghandagoza")]
        [Description("Sky Piercer, the Apex Fist")]
        [DefaultValue(WeaponEffectSwap.Terminus)]
        public WeaponEffectSwap Ghandagoza_SkyPiercerSwap { get; set; } = WeaponEffectSwap.Terminus;

        // 1600
        [DisplayName("1 Brionac, the Dominant")]
        [Category("Zeta")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Zeta_Brionac { get; set; } = WeaponEffectControlType.Enabled;

        [DisplayName("2")]
        [Category("Zeta")]
        [Description("Brionac, the Dominant")]
        [DefaultValue(WeaponEffectSwap.Ascension)]
        public WeaponEffectSwap Zeta_BrionacSwap { get; set; } = WeaponEffectSwap.Ascension;

        [DisplayName("3 Gae Bulg, Impaler of Ruin")]
        [Category("Zeta")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Zeta_GaeBulg { get; set; } = WeaponEffectControlType.Enabled;

        [DisplayName("4")]
        [Category("Zeta")]
        [Description("Gae Bulg, Impaler of Ruin")]
        [DefaultValue(WeaponEffectSwap.Terminus)]
        public WeaponEffectSwap Zeta_GaeBulgSwap { get; set; } = WeaponEffectSwap.Terminus;

        // 1700
        [DisplayName("1 Wurtzite Scythe, Reaper's Hand")]
        [Category("Vaseraga")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Vaseraga_WurtziteScythe { get; set; } = WeaponEffectControlType.Enabled;

        [DisplayName("2")]
        [Category("Vaseraga")]
        [Description("Wurtzite Scythe, Reaper's Hand")]
        [DefaultValue(WeaponEffectSwap.Ascension)]
        public WeaponEffectSwap Vaseraga_WurtziteScytheSwap { get; set; } = WeaponEffectSwap.Ascension;

        [DisplayName("3 Ereshkigal, Impending Doom")]
        [Category("Vaseraga")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Vaseraga_Ereshkigal { get; set; } = WeaponEffectControlType.Enabled;

        [DisplayName("4")]
        [Category("Vaseraga")]
        [Description("Ereshkigal, Impending Doom")]
        [DefaultValue(WeaponEffectSwap.Terminus)]
        public WeaponEffectSwap Vaseraga_EreshkigalSwap { get; set; } = WeaponEffectSwap.Terminus;

        // 1800
        [DisplayName("1 Transmigration Tome, Infinity")]
        [Category("Cagliostro")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Cagliostro_TransmigrationTome { get; set; } = WeaponEffectControlType.Enabled;

        [DisplayName("2")]
        [Category("Cagliostro")]
        [Description("Transmigration Tome, Infinity")]
        [DefaultValue(WeaponEffectSwap.Ascension)]
        public WeaponEffectSwap Cagliostro_TransmigrationTomeSwap { get; set; } = WeaponEffectSwap.Ascension;

        [DisplayName("3 Zosimos, the Unabridged Truth")]
        [Category("Cagliostro")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Cagliostro_Zosimos { get; set; } = WeaponEffectControlType.Enabled;

        [DisplayName("4")]
        [Category("Cagliostro")]
        [Description("Zosimos, the Unabridged Truth")]
        [DefaultValue(WeaponEffectSwap.Terminus)]
        public WeaponEffectSwap Cagliostro_ZosimosSwap { get; set; } = WeaponEffectSwap.Terminus;

        // 1900
        [DisplayName("1 Susanoo, the Condemner")]
        [Category("Id")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Id_Susanoo { get; set; } = WeaponEffectControlType.Enabled;

        [DisplayName("2")]
        [Category("Id")]
        [Description("Susanoo, the Condemner")]
        [DefaultValue(WeaponEffectSwap.Ascension)]
        public WeaponEffectSwap Id_SusanooSwap { get; set; } = WeaponEffectSwap.Ascension;

        [DisplayName("3 Primal Sword of Bahamut")]
        [Category("Id")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Id_PrimalSwordOfBahamut { get; set; } = WeaponEffectControlType.Enabled;

        [DisplayName("4")]
        [Category("Id")]
        [Description("Primal Sword of Bahamut")]
        [DefaultValue(WeaponEffectSwap.Terminus)]
        public WeaponEffectSwap Id_PrimalSwordOfBahamutSwap { get; set; } = WeaponEffectSwap.Terminus;

        // 2200
        [DisplayName("Gateway-Star Sword, Seven Winks")]
        [Category("Seofon")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Seofon_GatewayStarSword { get; set; } = WeaponEffectControlType.Enabled;

        // 2300
        [DisplayName("Desolation-Crown Bow, Two Feuds")]
        [Category("Tweyen")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Tweyen_DesolationCrownBow { get; set; } = WeaponEffectControlType.Enabled;

        // 2300
        [DisplayName("World Ender, The Fated Edge")]
        [Category("Sandalphon")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Sandalphon_WorldEnder { get; set; } = WeaponEffectControlType.Enabled;

    }

    public enum WeaponEffectControlType
    {
        [Description("Enabled")]
        Enabled,

        [Description("Combats Only")]
        CombatOnly,

        [Description("Idle Only")]
        IdleOnly,

        [Description("No Effect")]
        NoEffect,
    }

    public enum WeaponEffectSwap
    {
        [Description("Ascension")]
        Ascension,

        [Description("Terminus")]
        Terminus,
    }

    /// <summary>
    /// Allows you to override certain aspects of the configuration creation process (e.g. create multiple configurations).
    /// Override elements in <see cref="ConfiguratorMixinBase"/> for finer control.
    /// </summary>
    public class ConfiguratorMixin : ConfiguratorMixinBase
    {
        // 
    }
}
