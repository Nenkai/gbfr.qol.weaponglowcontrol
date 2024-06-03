using System.Diagnostics;
using System.Linq;
using System.Xml;

using Reloaded.Mod.Interfaces;

using gbfr.qol.weaponglowcontrol.Configuration;
using gbfr.qol.weaponglowcontrol.Template;
using gbfrelink.utility.manager.Interfaces;

using GBFRDataTools.Files;
using GBFRDataTools.Files.BinaryXML;

namespace gbfr.qol.weaponglowcontrol
{
    /// <summary>
    /// Your mod logic goes here.
    /// </summary>
    public class Mod : ModBase // <= Do not Remove.
    {
        /// <summary>
        /// Provides access to the mod loader API.
        /// </summary>
        private readonly IModLoader _modLoader;

        /// <summary>
        /// Provides access to the Reloaded logger.
        /// </summary>
        private readonly ILogger _logger;

        /// <summary>
        /// Entry point into the mod, instance that created this class.
        /// </summary>
        private readonly IMod _owner;

        /// <summary>
        /// Provides access to this mod's configuration.
        /// </summary>
        private Config _configuration;

        /// <summary>
        /// The configuration of the currently executing mod.
        /// </summary>
        private readonly IModConfig _modConfig;

        private WeakReference<IDataManager> _dataManagerRef;

        public Mod(ModContext context)
        {
            _modLoader = context.ModLoader;
            _logger = context.Logger;
            _owner = context.Owner;
            _configuration = context.Configuration;
            _modConfig = context.ModConfig;

#if DEBUG
            // NOTE (Nenkai): Only works with unpacked exe (use steamless)
            // Ensure that another mod isn't also launching the debugger (use release mode for any other mods)
            Debugger.Launch();
#endif

            _logger.WriteLine($"[{_modConfig.ModId}] Initializing...");
            _dataManagerRef = _modLoader.GetController<IDataManager>();
            if (!_dataManagerRef.TryGetTarget(out IDataManager manager))
                return;

            ApplyEffectChanges();
            manager.UpdateIndex();

            _logger.WriteLine($"[{_modConfig.ModId}] Initialized.");
        }

        public void ApplyEffectChanges()
        {
            ProcessEffectFile(_configuration.Captain_SwordOfEos, "wp0003");
            ProcessEffectFile(_configuration.Captain_SevenStarSword, "wp0006");

            ProcessEffectFile(_configuration.Katalina_Murgleis, "wp0202");
            ProcessEffectFile(_configuration.Katalina_Blutgang, "wp0205");

            ProcessEffectFile(_configuration.Rackam_Benedia, "wp0302");
            ProcessEffectFile(_configuration.Rackam_Freikugel, "wp0305");

            ProcessEffectFile(_configuration.Io_Gambanteinn, "wp0402");
            ProcessEffectFile(_configuration.Io_Caduceus, "wp0405");

            ProcessEffectFile(_configuration.Eugen_AK4A, "wp0502");
            ProcessEffectFile(_configuration.Eugen_DraconicFire, "wp0505");

            ProcessEffectFile(_configuration.Rosetta_LoveEternal, "wp0602");
            ProcessEffectFile(_configuration.Rosetta_DaggerOfBahamutCoda, "wp0605");

            ProcessEffectFile(_configuration.Ferry_EtherealLasher, "wp0702");
            ProcessEffectFile(_configuration.Ferry_Erinnerung, "wp0705");

            ProcessEffectFile(_configuration.Lancelot_KnightOfIce, "wp0804");
            ProcessEffectFile(_configuration.Lancelot_DamascusKnife, "wp0805");

            ProcessEffectFile(_configuration.Vane_TreuerKrieger, "wp0902");
            ProcessEffectFile(_configuration.Vane_Mjolnir, "wp0905");

            ProcessEffectFile(_configuration.Percival_LordOfFlames, "wp1004");
            ProcessEffectFile(_configuration.Percival_Gottfried, "wp1005");

            ProcessEffectFile(_configuration.Siegfried_Ascalon, "wp1102");
            ProcessEffectFile(_configuration.Siegfried_Balmung, "wp1105");

            ProcessEffectFile(_configuration.Charlotta_Claidheamh, "wp1202");
            ProcessEffectFile(_configuration.Charlotta_Galatine, "wp1205");

            ProcessEffectFile(_configuration.Yodarha_FudoKuniyuki, "wp1302");
            ProcessEffectFile(_configuration.Yodarha_Swordfish, "wp1305");

            ProcessEffectFile(_configuration.Narmaya_Venustas, "wp1402");
            ProcessEffectFile(_configuration.Narmaya_AmenoHabakiri, "wp1405");

            ProcessEffectFile(_configuration.Ghandagoza_GoldenFistsOfUra, "wp1503");
            ProcessEffectFile(_configuration.Ghandagoza_SkyPiercer, "wp1505");

            ProcessEffectFile(_configuration.Zeta_Brionac, "wp1602");
            ProcessEffectFile(_configuration.Zeta_GaeBulg, "wp1605");

            ProcessEffectFile(_configuration.Vaseraga_WurtziteScythe, "wp1702");
            ProcessEffectFile(_configuration.Vaseraga_Ereshkigal, "wp1705");

            ProcessEffectFile(_configuration.Cagliostro_TransmigrationTome, "wp1802");
            ProcessEffectFile(_configuration.Cagliostro_Zosimos, "wp1805");

            ProcessEffectFile(_configuration.Id_Susanoo, "wp1902");
            ProcessEffectFile(_configuration.Id_PrimalSwordOfBahamut, "wp1905");

            ProcessEffectFile(_configuration.Seofon_GatewayStarSword, "wp2206");

            ProcessEffectFile(_configuration.Tweyen_DesolationCrownBow, "wp2306");

            ProcessEffectFile(_configuration.Sandalphon_WorldEnder, "wp2106");
        }

        public void ProcessEffectFile(WeaponEffectControlType controlType, string name)
        {
            if (controlType == WeaponEffectControlType.Enabled)
                return;

            if (!_dataManagerRef.TryGetTarget(out IDataManager manager))
                return;

            string effectFile = $"effect/{name}.bxm";
            if (!manager.FileExists(effectFile, includeExternal: false))
                return;

            try
            {
                byte[] file = manager.GetArchiveFile(effectFile);

                using var ms = new MemoryStream(file);
                XmlDocument xmlDoc = XmlBin.Read(ms);
                if (controlType == WeaponEffectControlType.NoEffect)
                    xmlDoc["root"]["est"].RemoveAll();
                else
                {
                    bool found = false;
                    var est = xmlDoc["root"]["est"];
                    foreach (XmlNode node in est.ChildNodes)
                    {
                        if (node.Name == "data")
                        {
                            foreach (XmlAttribute attr in node.Attributes)
                            {
                                if ((controlType == WeaponEffectControlType.IdleOnly && attr.Value == "2010") ||
                                    (controlType == WeaponEffectControlType.CombatOnly && attr.Value == "2020"))
                                {
                                    est.RemoveChild(node);
                                    found = true;
                                    break;
                                }
                            }

                            if (found)
                                break;
                        }
                    }
                }

                using var outputXmlStream = new MemoryStream();
                XmlBin.Write(outputXmlStream, xmlDoc);

                manager.AddOrUpdateExternalFile(effectFile, outputXmlStream.ToArray());
            }
            catch (Exception ex)
            {
                _logger.WriteLine($"[{_modConfig.ModId}] Failed to apply {name} effect patch - {ex.Message}");
            }
        }

        #region Standard Overrides
        public override void ConfigurationUpdated(Config configuration)
        {
            // Apply settings from configuration.
            // ... your code here.
            _configuration = configuration;
            _logger.WriteLine($"[{_modConfig.ModId}] Config Updated: Applying");
        }
        #endregion

        #region For Exports, Serialization etc.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Mod() { }
#pragma warning restore CS8618
        #endregion
    }
}