using gbfr.qol.weaponglowcontrol.Template.Configuration;

using Reloaded.Mod.Interfaces.Structs;

using System.ComponentModel;

namespace gbfr.qol.weaponglowcontrol.Configuration
{
    public class Config : Configurable<Config>
    {
        // 0000-0100
        [DisplayName("Sword of Eos")]
        [Category("Captain")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Captain_SwordOfEos { get; set; } = WeaponEffectControlType.Enabled;

        [DisplayName("Seven-Star Sword")]
        [Category("Captain")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Captain_SevenStarSword { get; set; } = WeaponEffectControlType.Enabled;

        // 0200
        [DisplayName("Murgleis, the Azure Oath")]
        [Category("Katalina")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Katalina_Murgleis { get; set; } = WeaponEffectControlType.Enabled;

        [DisplayName("Blutgang, Blade of Refuge")]
        [Category("Katalina")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Katalina_Blutgang { get; set; } = WeaponEffectControlType.Enabled;

        // 0300
        [DisplayName("Benedia, Azure Ammunition")]
        [Category("Rackam")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Rackam_Benedia { get; set; } = WeaponEffectControlType.Enabled;

        [DisplayName("Freikugel, the Purifier")]
        [Category("Rackam")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Rackam_Freikugel { get; set; } = WeaponEffectControlType.Enabled;

        // 0400
        [DisplayName("Gambanteinn, Staff of Hope")]
        [Category("Io")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Io_Gambanteinn { get; set; } = WeaponEffectControlType.Enabled;

        [DisplayName("Caduceus, Immortal Coil")]
        [Category("Io")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Io_Caduceus { get; set; } = WeaponEffectControlType.Enabled;

        // 0500
        [DisplayName("AK-4A, the Suppressor")]
        [Category("Eugen")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Eugen_AK4A { get; set; } = WeaponEffectControlType.Enabled;

        [DisplayName("Draconic Fire, Charring Breath")]
        [Category("Eugen")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Eugen_DraconicFire { get; set; } = WeaponEffectControlType.Enabled;

        // 0600
        [DisplayName("Love Eternal, Forevermore")]
        [Category("Rosetta")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Rosetta_LoveEternal { get; set; } = WeaponEffectControlType.Enabled;

        [DisplayName("Primal Dagger of Bahamut Coda")]
        [Category("Rosetta")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Rosetta_DaggerOfBahamutCoda { get; set; } = WeaponEffectControlType.Enabled;

        // 0700
        [DisplayName("Ethereal Lasher, Fleeting End")]
        [Category("Ferry")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Ferry_EtherealLasher { get; set; } = WeaponEffectControlType.Enabled;

        [DisplayName("Erinnerung, From Beyond")]
        [Category("Ferry")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Ferry_Erinnerung { get; set; } = WeaponEffectControlType.Enabled;

        // 0800
        [DisplayName("Knight of Ice, the Silver Blur")]
        [Category("Lancelot")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Lancelot_KnightOfIce { get; set; } = WeaponEffectControlType.Enabled;

        [DisplayName("Damascus Knife, the Unseen")]
        [Category("Lancelot")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Lancelot_DamascusKnife { get; set; } = WeaponEffectControlType.Enabled;

        // 0900
        [DisplayName("Treuer Krieger, the Dauntless")]
        [Category("Vane")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Vane_TreuerKrieger { get; set; } = WeaponEffectControlType.Enabled;

        [DisplayName("Mjolnir, Thunderous Crusher")]
        [Category("Vane")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Vane_Mjolnir { get; set; } = WeaponEffectControlType.Enabled;

        // 1000
        [DisplayName("Lord of Flames, Exalted Reign")]
        [Category("Percival")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Percival_LordOfFlames { get; set; } = WeaponEffectControlType.Enabled;

        [DisplayName("Gottfried, the White Fang")]
        [Category("Percival")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Percival_Gottfried { get; set; } = WeaponEffectControlType.Enabled;

        // 1100
        [DisplayName("Ascalon, Dragon's Bane")]
        [Category("Siegfried")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Siegfried_Ascalon { get; set; } = WeaponEffectControlType.Enabled;

        [DisplayName("Balmung, the Blue Blaze")]
        [Category("Siegfried")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Siegfried_Balmung { get; set; } = WeaponEffectControlType.Enabled;

        // 1200
        [DisplayName("Claidheamh Soluis, the Radiant")]
        [Category("Charlotta")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Charlotta_Claidheamh { get; set; } = WeaponEffectControlType.Enabled;

        [DisplayName("Galatine, Trinity's Wrath")]
        [Category("Charlotta")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Charlotta_Galatine { get; set; } = WeaponEffectControlType.Enabled;

        // 1300
        [DisplayName("Fudo-Kuniyuki, Scarlet Glory")]
        [Category("Yodarha")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Yodarha_FudoKuniyuki { get; set; } = WeaponEffectControlType.Enabled;

        [DisplayName("Swordfish, Tipper of Scales")]
        [Category("Yodarha")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Yodarha_Swordfish { get; set; } = WeaponEffectControlType.Enabled;

        // 1400
        [DisplayName("Venustas, the Sacred Gift")]
        [Category("Narmaya")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Narmaya_Venustas { get; set; } = WeaponEffectControlType.Enabled;

        [DisplayName("Ameno Habakiri, the Beheader")]
        [Category("Narmaya")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Narmaya_AmenoHabakiri { get; set; } = WeaponEffectControlType.Enabled;

        // 1500
        [DisplayName("Golden Fists of Ura, No Mercy")]
        [Category("Ghandagoza")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Ghandagoza_GoldenFistsOfUra { get; set; } = WeaponEffectControlType.Enabled;

        [DisplayName("Sky Piercer, the Apex Fist")]
        [Category("Ghandagoza")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Ghandagoza_SkyPiercer { get; set; } = WeaponEffectControlType.Enabled;

        // 1600
        [DisplayName("Brionac, the Dominant")]
        [Category("Zeta")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Zeta_Brionac { get; set; } = WeaponEffectControlType.Enabled;

        [DisplayName("Gae Bulg, Impaler of Ruin")]
        [Category("Zeta")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Zeta_GaeBulg { get; set; } = WeaponEffectControlType.Enabled;

        // 1700
        [DisplayName("Wurtzite Scythe, Reaper's Hand")]
        [Category("Vaseraga")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Vaseraga_WurtziteScythe { get; set; } = WeaponEffectControlType.Enabled;

        [DisplayName("Ereshkigal, Impending Doom")]
        [Category("Vaseraga")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Vaseraga_Ereshkigal { get; set; } = WeaponEffectControlType.Enabled;

        // 1800
        [DisplayName("Transmigration Tome, Infinity")]
        [Category("Cagliostro")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Cagliostro_TransmigrationTome { get; set; } = WeaponEffectControlType.Enabled;

        [DisplayName("Zosimos, the Unabridged Truth")]
        [Category("Cagliostro")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Cagliostro_Zosimos { get; set; } = WeaponEffectControlType.Enabled;

        // 1900
        [DisplayName("Susanoo, the Condemner")]
        [Category("Id")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Id_Susanoo { get; set; } = WeaponEffectControlType.Enabled;

        [DisplayName("Primal Sword of Bahamut")]
        [Category("Id")]
        [DefaultValue(WeaponEffectControlType.Enabled)]
        public WeaponEffectControlType Id_PrimalSwordOfBahamut { get; set; } = WeaponEffectControlType.Enabled;

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

    /// <summary>
    /// Allows you to override certain aspects of the configuration creation process (e.g. create multiple configurations).
    /// Override elements in <see cref="ConfiguratorMixinBase"/> for finer control.
    /// </summary>
    public class ConfiguratorMixin : ConfiguratorMixinBase
    {
        // 
    }
}
