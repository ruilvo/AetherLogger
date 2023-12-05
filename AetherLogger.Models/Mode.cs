using System.Collections.Generic;

using Ardalis.SmartEnum;

namespace AetherLogger.Models;

public interface IModeInterface: ISmartEnum
{
    string ReadableName { get; }
}

/// <summary>
/// The mode of operation.
/// </summary>
/// <remarks>
/// This follows the 
/// <see href="https://www.adif.org/314/ADIF_314.htm#Mode_Enumeration">ADIF specification</see> 
/// for the enumeration of modes.
/// </remarks>  
public abstract class Mode : SmartEnum<Mode>, IModeInterface
{
    // Options
    public static readonly Mode AM = new AmMode();
    public static readonly Mode ARDOP = new ArdopMode();
    public static readonly Mode ATV = new AtvMode();
    public static readonly Mode CHIP = new ChipMode();
    public static readonly Mode CLO = new CloMode();
    public static readonly Mode CONTESTI = new ContestiMode();
    public static readonly Mode CW = new CwMode();
    public static readonly Mode DIGITALVOICE = new DigitalVoiceMode();
    public static readonly Mode DOMINO = new DominoMode();
    public static readonly Mode DYNAMIC = new DynamicMode();
    public static readonly Mode FAX = new FaxMode();
    public static readonly Mode FM = new FmMode();
    public static readonly Mode FSK411 = new Fsk411Mode();
    public static readonly Mode FT8 = new Ft8Mode();
    public static readonly Mode HELL = new HellMode();
    public static readonly Mode ISCAT = new IscatMode();
    public static readonly Mode JT4 = new Jt4Mode();
    public static readonly Mode JT6M = new Jt6mMode();
    public static readonly Mode JT9 = new Jt9Mode();
    public static readonly Mode JT44 = new Jt44Mode();
    public static readonly Mode JT65 = new Jt65Mode();
    public static readonly Mode MFSK = new MfskMode();
    public static readonly Mode MSK144 = new Msk144Mode();
    public static readonly Mode MT63 = new Mt63Mode();
    public static readonly Mode OLIVIA = new OliviaMode();
    public static readonly Mode OPERA = new OperaMode();
    public static readonly Mode PAC = new PacMode();
    public static readonly Mode PAX = new PaxMode();
    public static readonly Mode PKT = new PktMode();
    public static readonly Mode PSK = new PskMode();
    public static readonly Mode PSK2K = new Psk2kMode();
    public static readonly Mode Q15 = new Q15Mode();
    public static readonly Mode QRA64 = new Qra64Mode();
    public static readonly Mode ROS = new RosMode();
    public static readonly Mode RTTY = new RttyMode();
    public static readonly Mode RTTYM = new RttymMode();
    public static readonly Mode SSB = new SsbMode();
    public static readonly Mode SSTV = new SstvMode();
    public static readonly Mode T10 = new T10Mode();
    public static readonly Mode THOR = new ThorMode();
    public static readonly Mode THRB = new ThrbMode();
    public static readonly Mode TOR = new TorMode();
    public static readonly Mode V4 = new V4Mode();
    public static readonly Mode VOI = new VoiMode();
    public static readonly Mode WINMOR = new WinmorMode();
    public static readonly Mode WSPR = new WsprMode();

    // Properties
    public abstract IEnumerable<IModeInterface>? Submodes { get; }
    public abstract string ReadableName { get; }

    // Counter
    private static int _counter = 0;

    private Mode(string name, int value) : base(name, value)
    {
    }

    // Option implementations
    public sealed class AmMode : Mode
    {
        public AmMode() : base("AM", _counter++)
        {
        }

        public override string ReadableName => Name;
        public override IEnumerable<IModeInterface>? Submodes => null;
    }

    public sealed class ArdopMode : Mode
    {
        public ArdopMode() : base("ARDOP", _counter++)
        {
        }

        public override string ReadableName => Name;
        public override IEnumerable<IModeInterface>? Submodes => null;
    }

    public sealed class AtvMode: Mode
    {
        public AtvMode() : base("ATV", _counter++)
        {
        }

        public override string ReadableName => Name;
        public override IEnumerable<IModeInterface>? Submodes => null;
    }

    public sealed class ChipMode : Mode
    {
        public ChipMode() : base("CHIP", _counter++)
        {
        }

        public override string ReadableName => Name;
        public override IEnumerable<IModeInterface>? Submodes => ChipSubMode.List;
    }

    public sealed class CloMode : Mode
    {
        public CloMode() : base("CLO", _counter++)
        {
        }

        public override string ReadableName => Name;
        public override IEnumerable<IModeInterface>? Submodes => null;
    }

    public sealed class ContestiMode : Mode
    {
        public ContestiMode() : base("CONTESTI", _counter++)
        {
        }

        public override string ReadableName => "Contestia";
        public override IEnumerable<IModeInterface>? Submodes => null;
    }

    public sealed class CwMode : Mode
    {
        public CwMode() : base("CW", _counter++)
        {
        }

        public override string ReadableName => "Morse (CW)";
        public override IEnumerable<IModeInterface>? Submodes => CwSubMode.List;
    }

    public sealed class  DigitalVoiceMode: Mode
    {
        public DigitalVoiceMode() : base("DIGITALVOICE", _counter++)
        {
        }

        public override string ReadableName => "Digital Voice";
        public override IEnumerable<IModeInterface>? Submodes => DigitalVoiceSubMode.List;
    }

    public sealed class DominoMode : Mode
    {
        public DominoMode() : base("DOMINO", _counter++)
        {
        }

        public override string ReadableName => "Domino";
        public override IEnumerable<IModeInterface>? Submodes => DominoSubMode.List;
    }

    public sealed class  DynamicMode: Mode
    {
        public DynamicMode(): base("DYNAMIC", _counter++)
        {
        }

        public override string ReadableName => "VARA (Dynamic)";
        public override IEnumerable<IModeInterface>? Submodes => DynamicSubMode.List;
    }

    public sealed class FaxMode : Mode
    {
        public FaxMode() : base("FAX", _counter++)
        {
        }

        public override string ReadableName => "Fax";
        public override IEnumerable<IModeInterface>? Submodes => null;
    }

    public sealed class FmMode : Mode
    {
        public FmMode() : base("FM", _counter++)
        {
        }

        public override string ReadableName => "FM";
        public override IEnumerable<IModeInterface>? Submodes => null;
    }

    public sealed class Fsk411Mode : Mode
    {
        public Fsk411Mode() : base("FSK411", _counter++)
        {
        }

        public override string ReadableName => Name;
        public override IEnumerable<IModeInterface>? Submodes => null;
    }

    public sealed class Ft8Mode : Mode
    {
        public Ft8Mode() : base("FT8", _counter++)
        {
        }

        public override string ReadableName => "FT8";
        public override IEnumerable<IModeInterface>? Submodes => null;
    }

    public sealed class HellMode : Mode
    {
        public HellMode() : base("HELL", _counter++)
        {
        }

        public override string ReadableName => "Hellschreiber";
        public override IEnumerable<IModeInterface>? Submodes => HellSubMode.List;
    }

    public sealed class IscatMode : Mode
    {
        public IscatMode() : base("ISCAT", _counter++)
        {
        }

        public override string ReadableName => "Ionospheric Scattering (ISCAT)";
        public override IEnumerable<IModeInterface>? Submodes => IscatSubMode.List;
    }

    public sealed class Jt4Mode : Mode
    {
        public Jt4Mode() : base("JT4", _counter++)
        {
        }

        public override string ReadableName => Name;
        public override IEnumerable<IModeInterface>? Submodes => Jt4SubMode.List;
    }

    public sealed class Jt6mMode : Mode
    {
        public Jt6mMode() : base("JT6M", _counter++)
        {
        }

        public override string ReadableName => Name;
        public override IEnumerable<IModeInterface>? Submodes => null;
    }

    public sealed class Jt9Mode : Mode
    {
        public Jt9Mode() : base("JT9", _counter++)
        {
        }

        public override string ReadableName => Name;
        public override IEnumerable<IModeInterface>? Submodes => Jt9SubMode.List;
    }

    public sealed class Jt44Mode : Mode
    {
        public Jt44Mode() : base("JT44", _counter++)
        {
        }

        public override string ReadableName => Name;
        public override IEnumerable<IModeInterface>? Submodes => null;
    }

    public sealed class Jt65Mode : Mode
    {
        public Jt65Mode() : base("JT65", _counter++)
        {
        }

        public override string ReadableName => Name;
        public override IEnumerable<IModeInterface>? Submodes => Jt65SubMode.List;
    }

    public sealed class MfskMode : Mode
    {
        public MfskMode() : base("MFSK", _counter++)
        {
        }

        public override string ReadableName => Name;
        public override IEnumerable<IModeInterface>? Submodes => MfskSubMode.List;
    }

    public sealed class Msk144Mode : Mode
    {
        public Msk144Mode() : base("MSK144", _counter++)
        {
        }

        public override string ReadableName => Name;
        public override IEnumerable<IModeInterface>? Submodes => null;
    }

    public sealed class Mt63Mode : Mode
    {
        public Mt63Mode() : base("MT63", _counter++)
        {
        }

        public override string ReadableName => Name;
        public override IEnumerable<IModeInterface>? Submodes => null;
    }

    public sealed class OliviaMode : Mode
    {
        public OliviaMode() : base("OLIVIA", _counter++)
        {
        }

        public override string ReadableName => "Olivia MFSK";
        public override IEnumerable<IModeInterface>? Submodes => OliviaSubMode.List;
    }

    public sealed class OperaMode : Mode
    {
        public OperaMode() : base("OPERA", _counter++)
        {
        }

        public override string ReadableName => Name;
        public override IEnumerable<IModeInterface>? Submodes => OperaSubMode.List;
    }

    public sealed class PacMode : Mode
    {
        public PacMode() : base("PAC", _counter++)
        {
        }

        public override string ReadableName => "PACTOR";
        public override IEnumerable<IModeInterface>? Submodes => PacSubMode.List;
    }

    public sealed class PaxMode : Mode
    {
        public PaxMode() : base("PAX", _counter++)
        {
        }

        public override string ReadableName => Name;
        public override IEnumerable<IModeInterface>? Submodes => PaxSubMode.List;
    }

    public sealed class PktMode : Mode
    {
        public PktMode() : base("PKT", _counter++)
        {
        }

        public override string ReadableName => "Packet";
        public override IEnumerable<IModeInterface>? Submodes => null;
    }

    public sealed class PskMode : Mode
    {
        public PskMode() : base("PSK", _counter++)
        {
        }

        public override string ReadableName => Name;
        public override IEnumerable<IModeInterface>? Submodes => PskSubMode.List;
    }

    public sealed class Psk2kMode : Mode
    {
        public Psk2kMode() : base("PSK2K", _counter++)
        {
        }

        public override string ReadableName => Name;
        public override IEnumerable<IModeInterface>? Submodes => null;
    }

    public sealed class Q15Mode : Mode
    {
        public Q15Mode() : base("Q15", _counter++)
        {
        }

        public override string ReadableName => Name;
        public override IEnumerable<IModeInterface>? Submodes => null;
    }

    public sealed class Qra64Mode : Mode
    {
        public Qra64Mode() : base("QRA64", _counter++)
        {
        }

        public override string ReadableName => Name;
        public override IEnumerable<IModeInterface>? Submodes => Qra64SubMode.List;
    }

    public sealed class RosMode : Mode
    {
        public RosMode() : base("ROS", _counter++)
        {
        }

        public override string ReadableName => Name;
        public override IEnumerable<IModeInterface>? Submodes => RosSubMode.List;
    }

    public sealed class RttyMode : Mode
    {
        public RttyMode() : base("RTTY", _counter++)
        {
        }

        public override string ReadableName => Name;
        public override IEnumerable<IModeInterface>? Submodes => RttySubMode.List;
    }

    public sealed class RttymMode : Mode
    {
        public RttymMode() : base("RTTYM", _counter++)
        {
        }

        public override string ReadableName => Name;
        public override IEnumerable<IModeInterface>? Submodes => null;
    }

    public sealed class SsbMode : Mode
    {
        public SsbMode() : base("SSB", _counter++)
        {
        }

        public override string ReadableName => Name;
        public override IEnumerable<IModeInterface>? Submodes => SsbSubMode.List;
    }

    public sealed class SstvMode : Mode
    {
        public SstvMode() : base("SSTV", _counter++)
        {
        }

        public override string ReadableName => Name;
        public override IEnumerable<IModeInterface>? Submodes => null;
    }

    public sealed class T10Mode : Mode
    {
        public T10Mode() : base("T10", _counter++)
        {
        }

        public override string ReadableName => Name;
        public override IEnumerable<IModeInterface>? Submodes => null;
    }

    public sealed class ThorMode : Mode
    {
        public ThorMode() : base("THOR", _counter++)
        {
        }

        public override string ReadableName => Name;
        public override IEnumerable<IModeInterface>? Submodes => ThorSubMode.List;
    }

    public sealed class ThrbMode : Mode
    {
        public ThrbMode() : base("THRB", _counter++)
        {
        }

        public override string ReadableName => "THROB";
        public override IEnumerable<IModeInterface>? Submodes => ThrbSubMode.List;
    }

    public sealed class TorMode : Mode
    {
        public TorMode() : base("TOR", _counter++)
        {
        }

        public override string ReadableName => "(SI)TOR";
        public override IEnumerable<IModeInterface>? Submodes => TorSubMode.List;
    }

    public sealed class V4Mode : Mode
    {
        public V4Mode() : base("V4", _counter++)
        {
        }

        public override string ReadableName => Name;
        public override IEnumerable<IModeInterface>? Submodes => null;
    }

    public sealed class VoiMode : Mode
    {
        public VoiMode() : base("VOI", _counter++)
        {
        }

        public override string ReadableName => "VOICE (Olivia)";
        public override IEnumerable<IModeInterface>? Submodes => null;
    }

    public sealed class WinmorMode : Mode
    {
        public WinmorMode() : base("WINMOR", _counter++)
        {
        }

        public override string ReadableName => Name;
        public override IEnumerable<IModeInterface>? Submodes => null;
    }

    public sealed class WsprMode : Mode
    {
        public WsprMode() : base("WSPR", _counter++)
        {
        }

        public override string ReadableName => Name;
        public override IEnumerable<IModeInterface>? Submodes => null;
    }
}


public abstract class ChipSubMode : SmartEnum<ChipSubMode>, IModeInterface
{
    // Options
    public static readonly ChipSubMode CHIP64 = new Chip64Mode();
    public static readonly ChipSubMode CHIP128 = new Chip128Mode();

    // Properties
    public abstract string ReadableName { get; }

    // Counter
    private static int _counter = 0;

    private ChipSubMode(string name, int value) : base(name, value)
    {
    }

    // Option implementations
    public sealed class Chip64Mode : ChipSubMode
    {
        public Chip64Mode() : base("CHIP64", _counter++)
        {
        }

        public override string ReadableName => "CHIP 64";
    }

    public sealed class Chip128Mode : ChipSubMode
    {
        public Chip128Mode() : base("CHIP128", _counter++)
        {
        }

        public override string ReadableName => "CHIP 128";
    }
}

public abstract class CwSubMode : SmartEnum<CwSubMode>, IModeInterface
{
    // Options
    // Who came up with a single submode system?!
    // TODO(ruilvo, 2023-12-05): Handle "standard" CW versus single submode CW.
    public static readonly CwSubMode PCW = new PcwSubMode();

    // Properties
    public abstract string ReadableName { get; }

    // Counter
    private static int _counter = 0;

    private CwSubMode(string name, int value) : base(name, value)
    {
    }

    // Option implementations
    public sealed class PcwSubMode : CwSubMode
    {
        public PcwSubMode() : base("PCW", _counter++)
        {
        }

        public override string ReadableName => "Precision CW";
    }
}

public abstract class DigitalVoiceSubMode : SmartEnum<DigitalVoiceSubMode>, IModeInterface
{
    // Options
    public static readonly DigitalVoiceSubMode C4FM = new C4fmMode();
    public static readonly DigitalVoiceSubMode DMR = new DmrMode();
    public static readonly DigitalVoiceSubMode DSTAR = new DstarMode();
    public static readonly DigitalVoiceSubMode FREEDV = new FreedvMode();
    public static readonly DigitalVoiceSubMode M17 = new D17Mode();

    // Properties
    public abstract string ReadableName { get; }

    // Counter
    private static int _counter = 0;

    private DigitalVoiceSubMode(string name, int value) : base(name, value)
    {
    }

    // Option implementations
    public sealed class C4fmMode : DigitalVoiceSubMode
    {
        public C4fmMode() : base("C4FM", _counter++)
        {
        }

        public override string ReadableName => "C4FM (Fusion)";
    }

    public sealed class DmrMode : DigitalVoiceSubMode
    {
        public DmrMode() : base("DMR", _counter++)
        {
        }

        public override string ReadableName => Name;
    }

    public sealed class DstarMode : DigitalVoiceSubMode
    {
        public DstarMode() : base("DSTAR", _counter++)
        {
        }

        public override string ReadableName => "D-STAR";
    }

    public sealed class FreedvMode : DigitalVoiceSubMode
    {
        public FreedvMode() : base("FREEDV", _counter++)
        {
        }

        public override string ReadableName => "FreeDV";
    }

    public sealed class D17Mode : DigitalVoiceSubMode
    {
        public D17Mode() : base("M17", _counter++)
        {
        }

        public override string ReadableName => Name;
    }
}

public abstract class DominoSubMode : SmartEnum<DominoSubMode>, IModeInterface
{
    // Options
    public static readonly DominoSubMode DOM_M = new DommSubMode();
    public static readonly DominoSubMode DOM4 = new Dom4SubMode();
    public static readonly DominoSubMode DOM5 = new Dom5SubMode();
    public static readonly DominoSubMode DOM8 = new Dom8SubMode();
    public static readonly DominoSubMode DOM11 = new Dom11SubMode();
    public static readonly DominoSubMode DOM16 = new Dom16SubMode();
    public static readonly DominoSubMode DOM22 = new Dom22SubMode();
    public static readonly DominoSubMode DOM44 = new Dom44SubMode();
    public static readonly DominoSubMode DOM88 = new Dom88SubMode();
    public static readonly DominoSubMode DOMINOEX = new DominoexSubMode();
    public static readonly DominoSubMode DOMINOF = new DominofSubMode();


    // Properties
    public abstract string ReadableName { get; }

    // Counter
    private static int _counter = 0;

    private DominoSubMode(string name, int value) : base(name, value)
    {
    }

    // Option implementations
    public sealed class DommSubMode : DominoSubMode
    {
        public DommSubMode() : base("DOM-M", _counter++)
        {
        }

        public override string ReadableName => Name;
    }

    public sealed class Dom4SubMode : DominoSubMode
    {
        public Dom4SubMode() : base("DOM4", _counter++)
        {
        }

        public override string ReadableName => Name;
    }

    public sealed class Dom5SubMode : DominoSubMode
    {
        public Dom5SubMode() : base("DOM5", _counter++)
        {
        }

        public override string ReadableName => Name;
    }

    public sealed class Dom8SubMode : DominoSubMode
    {
        public Dom8SubMode() : base("DOM8", _counter++)
        {
        }

        public override string ReadableName => Name;
    }

    public sealed class Dom11SubMode : DominoSubMode
    {
        public Dom11SubMode() : base("DOM11", _counter++)
        {
        }

        public override string ReadableName => Name;
    }

    public sealed class Dom16SubMode : DominoSubMode
    {
        public Dom16SubMode() : base("DOM16", _counter++)
        {
        }

        public override string ReadableName => Name;
    }

    public sealed class Dom22SubMode : DominoSubMode
    {
        public Dom22SubMode() : base("DOM22", _counter++)
        {
        }

        public override string ReadableName => Name;
    }

    public sealed class Dom44SubMode : DominoSubMode
    {
        public Dom44SubMode() : base("DOM44", _counter++)
        {
        }

        public override string ReadableName => Name;
    }

    public sealed class Dom88SubMode : DominoSubMode
    {
        public Dom88SubMode() : base("DOM88", _counter++)
        {
        }

        public override string ReadableName => Name;
    }

    public sealed class DominoexSubMode : DominoSubMode
    {
        public DominoexSubMode() : base("DOMINOEX", _counter++)
        {
        }

        public override string ReadableName => "DominoEX";
    }

    public sealed class DominofSubMode : DominoSubMode
    {
        public DominofSubMode() : base("DOMINOF", _counter++)
        {
        }

        public override string ReadableName => "DominoF";
    }
}

public abstract class DynamicSubMode : SmartEnum<DynamicSubMode>, IModeInterface
{
    // Options
    public static readonly DynamicSubMode VARA_HF = new VaraHfMode();
    public static readonly DynamicSubMode VARA_SATELLITE = new VaraSatelliteMode();
    public static readonly DynamicSubMode VARA_FM_1200 = new VaraFm1200Mode();
    public static readonly DynamicSubMode VARA_FM_9600 = new VaraFm9600Mode();

    // Properties
    public abstract string ReadableName { get; }

    // Counter
    private static int _counter = 0;

    private DynamicSubMode(string name, int value) : base(name, value)
    {
    }

    // Option implementations
    public sealed class VaraHfMode : DynamicSubMode
    {
        public VaraHfMode() : base("VARA HF", _counter++)
        {
        }

        public override string ReadableName => Name;
    }

    public sealed class VaraSatelliteMode : DynamicSubMode
    {
        public VaraSatelliteMode() : base("VARA SATELLITE", _counter++)
        {
        }

        public override string ReadableName => "VARA Satellite";
    }

    public sealed class VaraFm1200Mode : DynamicSubMode
    {
        public VaraFm1200Mode() : base("VARA FM 1200", _counter++)
        {
        }

        public override string ReadableName => Name;
    }

    public sealed class VaraFm9600Mode : DynamicSubMode
    {
        public VaraFm9600Mode() : base("VARA FM 9600", _counter++)
        {
        }

        public override string ReadableName => Name;
    }
}

public abstract class HellSubMode : SmartEnum<HellSubMode>, IModeInterface
{
    // Options
    public static readonly HellSubMode FMHELL = new FmHellMode();
    public static readonly HellSubMode FSKHELL = new FskHellMode();
    public static readonly HellSubMode HELL80 = new Hell80Mode();
    public static readonly HellSubMode HELLX5 = new HellX5Mode();
    public static readonly HellSubMode HELLX9 = new HellX9Mode();
    public static readonly HellSubMode HFSK = new HellFskMode();
    public static readonly HellSubMode PSKHELL = new PskHellMode();
    public static readonly HellSubMode SLOWHELL = new SlowHellMode();

    // Properties
    public abstract string ReadableName { get; }

    // Counter
    private static int _counter = 0;

    private HellSubMode(string name, int value) : base(name, value)
    {
    }

    // Option implementations
    public sealed class FmHellMode : HellSubMode
    {
        public FmHellMode() : base("FMHELL", _counter++)
        {
        }

        public override string ReadableName => "FM Hellschreiber";
    }

    public sealed class FskHellMode : HellSubMode
    {
        public FskHellMode() : base("FSKHELL", _counter++)
        {
        }

        public override string ReadableName => "FSK Hellschreiber";
    }

    public sealed class Hell80Mode : HellSubMode
    {
        public Hell80Mode() : base("HELL80", _counter++)
        {
        }

        public override string ReadableName => "Hellschreiber 80";
    }

    public sealed class HellX5Mode : HellSubMode
    {
        public HellX5Mode() : base("HELLX5", _counter++)
        {
        }

        public override string ReadableName => "Hellschreiber X5";
    }

    public sealed class HellX9Mode : HellSubMode
    {
        public HellX9Mode() : base("HELLX9", _counter++)
        {
        }

        public override string ReadableName => "Hellschreiber X9";
    }

    public sealed class HellFskMode : HellSubMode
    {
        public HellFskMode() : base("HFSK", _counter++)
        {
        }

        public override string ReadableName => "Hellschreiber FSK";
    }

    public sealed class PskHellMode : HellSubMode
    {
        public PskHellMode() : base("PSKHELL", _counter++)
        {
        }

        public override string ReadableName => "PSK Hellschreiber";
    }

    public sealed class SlowHellMode : HellSubMode
    {
        public SlowHellMode() : base("SLOWHELL", _counter++)
        {
        }

        public override string ReadableName => "Slow Hellschreiber";
    }
}

public abstract class IscatSubMode : SmartEnum<IscatSubMode>, IModeInterface
{
    // Options
    public static readonly IscatSubMode ISCAT_A = new IscatAMode();
    public static readonly IscatSubMode ISCAT_B = new IscatBMode();

    // Properties
    public abstract string ReadableName { get; }

    // Counter
    private static int _counter = 0;

    private IscatSubMode(string name, int value) : base(name, value)
    {
    }

    // Option implementations
    public sealed class IscatAMode : IscatSubMode
    {
        public IscatAMode() : base("ISCAT-A", _counter++)
        {
        }

        public override string ReadableName => Name;
    }

    public sealed class IscatBMode : IscatSubMode
    {
        public IscatBMode() : base("ISCAT-B", _counter++)
        {
        }

        public override string ReadableName => Name;
    }
}

public abstract class Jt4SubMode : SmartEnum<Jt4SubMode>, IModeInterface
{
    // Options
    public static readonly Jt4SubMode JT4A = new Jt4AMode();
    public static readonly Jt4SubMode JT4B = new Jt4BMode();
    public static readonly Jt4SubMode JT4C = new Jt4CMode();
    public static readonly Jt4SubMode JT4D = new Jt4DMode();
    public static readonly Jt4SubMode JT4E = new Jt4EMode();
    public static readonly Jt4SubMode JT4F = new Jt4FMode();
    public static readonly Jt4SubMode JT4G = new Jt4GMode();

    // Properties
    public abstract string ReadableName { get; }

    // Counter
    private static int _counter = 0;

    private Jt4SubMode(string name, int value) : base(name, value)
    {
    }

    // Option implementations
    public sealed class Jt4AMode : Jt4SubMode
    {
        public Jt4AMode() : base("JT4A", _counter++)
        {
        }

        public override string ReadableName => Name;
    }

    public sealed class Jt4BMode : Jt4SubMode
    {
        public Jt4BMode() : base("JT4B", _counter++)
        {
        }

        public override string ReadableName => Name;
    }

    public sealed class Jt4CMode : Jt4SubMode
    {
        public Jt4CMode() : base("JT4C", _counter++)
        {
        }

        public override string ReadableName => Name;
    }

    public sealed class Jt4DMode : Jt4SubMode
    {
        public Jt4DMode() : base("JT4D", _counter++)
        {
        }

        public override string ReadableName => Name;
    }

    public sealed class Jt4EMode : Jt4SubMode
    {
        public Jt4EMode() : base("JT4E", _counter++)
        {
        }

        public override string ReadableName => Name;
    }

    public sealed class Jt4FMode : Jt4SubMode
    {
        public Jt4FMode() : base("JT4F", _counter++)
        {
        }

        public override string ReadableName => Name;
    }

    public sealed class Jt4GMode : Jt4SubMode
    {
        public Jt4GMode() : base("JT4G", _counter++)
        {
        }

        public override string ReadableName => Name;
    }
}

public abstract class Jt9SubMode : SmartEnum<Jt9SubMode>, IModeInterface
{
    // Options
    public static readonly Jt9SubMode JT9_1 = new Jt91Mode();
    public static readonly Jt9SubMode JT9_2 = new Jt92Mode();
    public static readonly Jt9SubMode JT9_5 = new Jt95Mode();
    public static readonly Jt9SubMode JT9_10 = new Jt910Mode();
    public static readonly Jt9SubMode JT9_30 = new Jt930Mode();
    public static readonly Jt9SubMode JT9A = new Jt9AMode();
    public static readonly Jt9SubMode JT9B = new Jt9BMode();
    public static readonly Jt9SubMode JT9C = new Jt9CMode();
    public static readonly Jt9SubMode JT9D = new Jt9DMode();
    public static readonly Jt9SubMode JT9E = new Jt9EMode();
    public static readonly Jt9SubMode JT9E_FAST = new Jt9EFastMode();
    public static readonly Jt9SubMode JT9F = new Jt9FMode();
    public static readonly Jt9SubMode JT9F_FAST = new Jt9FFastMode();
    public static readonly Jt9SubMode JT9G = new Jt9GMode();
    public static readonly Jt9SubMode JT9G_FAST = new Jt9GFastMode();
    public static readonly Jt9SubMode JT9H = new Jt9HMode();
    public static readonly Jt9SubMode JT9H_FAST = new Jt9HFastMode();

    // Properties
    public abstract string ReadableName { get; }

    // Counter
    private static int _counter = 0;

    private Jt9SubMode(string name, int value) : base(name, value)
    {
    }

    // Option implementations
    public sealed class Jt91Mode : Jt9SubMode
    {
        public Jt91Mode() : base("JT9-1", _counter++)
        {
        }

        public override string ReadableName => Name;
    }

    public sealed class Jt92Mode : Jt9SubMode
    {
        public Jt92Mode() : base("JT9-2", _counter++)
        {
        }

        public override string ReadableName => Name;
    }

    public sealed class Jt95Mode : Jt9SubMode
    {
        public Jt95Mode() : base("JT9-5", _counter++)
        {
        }

        public override string ReadableName => Name;
    }

    public sealed class Jt910Mode : Jt9SubMode
    {
        public Jt910Mode() : base("JT9-10", _counter++)
        {
        }

        public override string ReadableName => Name;
    }

    public sealed class Jt930Mode : Jt9SubMode
    {
        public Jt930Mode() : base("JT9-30", _counter++)
        {
        }

        public override string ReadableName => Name;
    }

    public sealed class Jt9AMode : Jt9SubMode
    {
        public Jt9AMode() : base("JT9A", _counter++)
        {
        }

        public override string ReadableName => Name;
    }

    public sealed class Jt9BMode : Jt9SubMode
    {
        public Jt9BMode() : base("JT9B", _counter++)
        {
        }

        public override string ReadableName => Name;
    }

    public sealed class Jt9CMode : Jt9SubMode
    {
        public Jt9CMode() : base("JT9C", _counter++)
        {
        }

        public override string ReadableName => Name;
    }

    public sealed class Jt9DMode : Jt9SubMode
    {
        public Jt9DMode() : base("JT9D", _counter++)
        {
        }

        public override string ReadableName => Name;
    }

    public sealed class Jt9EMode : Jt9SubMode
    {
        public Jt9EMode() : base("JT9E", _counter++)
        {
        }

        public override string ReadableName => Name;
    }

    public sealed class Jt9EFastMode : Jt9SubMode
    {
        public Jt9EFastMode() : base("JT9E FAST,", _counter++)
        {
        }

        public override string ReadableName => "JT9E (Fast)";
    }

    public sealed class Jt9FMode : Jt9SubMode
    {
        public Jt9FMode() : base("JT9F", _counter++)
        {
        }

        public override string ReadableName => Name;
    }

    public sealed class Jt9FFastMode : Jt9SubMode
    {
        public Jt9FFastMode() : base("JT9F FAST", _counter++)
        {
        }

        public override string ReadableName => "JT9F (Fast)";
    }

    public sealed class Jt9GMode : Jt9SubMode
    {
        public Jt9GMode() : base("JT9G", _counter++)
        {
        }

        public override string ReadableName => Name;
    }

    public sealed class Jt9GFastMode : Jt9SubMode
    {
        public Jt9GFastMode() : base("JT9G FAST", _counter++)
        {
        }

        public override string ReadableName => "JT9G (Fast)";
    }

    public sealed class Jt9HMode : Jt9SubMode
    {
        public Jt9HMode() : base("JT9H", _counter++)
        {
        }

        public override string ReadableName => Name;
    }

    public sealed class Jt9HFastMode : Jt9SubMode
    {
        public Jt9HFastMode() : base("JT9H FAST", _counter++)
        {
        }

        public override string ReadableName => "JT9H (Fast)";
    }
}

public abstract class Jt65SubMode : SmartEnum<Jt65SubMode>, IModeInterface
{
    // Options
    public static readonly Jt65SubMode JT65A = new Jt65AMode();
    public static readonly Jt65SubMode JT65B = new Jt65BMode();
    public static readonly Jt65SubMode JT65B2 = new Jt65B2Mode();
    public static readonly Jt65SubMode JT65C = new Jt65CMode();
    public static readonly Jt65SubMode JT65C2 = new Jt65C2Mode();

    // Properties
    public abstract string ReadableName { get; }

    // Counter
    private static int _counter = 0;

    private Jt65SubMode(string name, int value) : base(name, value)
    {
    }

    // Option implementations
    public sealed class Jt65AMode : Jt65SubMode
    {
        public Jt65AMode() : base("JT65A", _counter++)
        {
        }

        public override string ReadableName => Name;
    }

    public sealed class Jt65BMode : Jt65SubMode
    {
        public Jt65BMode() : base("JT65B", _counter++)
        {
        }

        public override string ReadableName => Name;
    }

    public sealed class Jt65B2Mode : Jt65SubMode
    {
        public Jt65B2Mode() : base("JT65B2", _counter++)
        {
        }

        public override string ReadableName => Name;
    }

    public sealed class Jt65CMode : Jt65SubMode
    {
        public Jt65CMode() : base("JT65C", _counter++)
        {
        }

        public override string ReadableName => Name;
    }

    public sealed class Jt65C2Mode : Jt65SubMode
    {
        public Jt65C2Mode() : base("JT65C2", _counter++)
        {
        }

        public override string ReadableName => Name;
    }
}

public abstract class MfskSubMode : SmartEnum<MfskSubMode>, IModeInterface
{
    // Options
    public static readonly MfskSubMode FSQCALL = new FsqcallMode();
    public static readonly MfskSubMode FST4 = new Fst4Mode();
    public static readonly MfskSubMode FST4W = new Fst4WMode();
    public static readonly MfskSubMode FT4 = new Ft4Mode();
    public static readonly MfskSubMode JS8 = new Js8Mode();
    public static readonly MfskSubMode JTMS = new JtmsMode();
    public static readonly MfskSubMode MFSK4 = new Mfsk4Mode();
    public static readonly MfskSubMode MFSK8 = new Msfk8Mode();
    public static readonly MfskSubMode MFSK11 = new Msfk11Mode();
    public static readonly MfskSubMode MFSK16 = new Msfk16Mode();
    public static readonly MfskSubMode MFSK22 = new Msfk22Mode();
    public static readonly MfskSubMode MFSK31 = new Msfk31Mode();
    public static readonly MfskSubMode MFSK32 = new Msfk32Mode();
    public static readonly MfskSubMode MFSK64 = new Msfk64Mode();
    public static readonly MfskSubMode MFSK64L = new Msfk64LMode();
    public static readonly MfskSubMode MFSK128 = new Msfk128Mode();
    public static readonly MfskSubMode MFSK128L = new Msfk128LMode();
    public static readonly MfskSubMode Q65 = new Q65Mode();

    // Properties
    public abstract string ReadableName { get; }

    // Counter
    private static int _counter = 0;

    private MfskSubMode(string name, int value) : base(name, value)
    {
    }

    // Option implementations
    public sealed class FsqcallMode : MfskSubMode
    {
        public FsqcallMode() : base("FSQCALL", _counter++)
        {
        }

        public override string ReadableName => "FSQCall";
    }

    public sealed class Fst4Mode : MfskSubMode
    {
        public Fst4Mode() : base("FST4", _counter++)
        {
        }

        public override string ReadableName => Name;
    }

    public sealed class Fst4WMode : MfskSubMode
    {
        public Fst4WMode() : base("FST4W", _counter++)
        {
        }

        public override string ReadableName => Name;
    }

    public sealed class Ft4Mode : MfskSubMode
    {
        public Ft4Mode() : base("FT4", _counter++)
        {
        }

        public override string ReadableName => Name;
    }

    public sealed class Js8Mode : MfskSubMode
    {
        public Js8Mode() : base("JS8", _counter++)
        {
        }

        public override string ReadableName => Name;
    }

    public sealed class JtmsMode : MfskSubMode
    {
        public JtmsMode() : base("JTMS", _counter++)
        {
        }

        public override string ReadableName => "JTMS";
    }

    public sealed class Mfsk4Mode : MfskSubMode
    {
        public Mfsk4Mode() : base("MFSK4", _counter++)
        {
        }

        public override string ReadableName => "MFSK 4";
    }

    public sealed class Msfk8Mode : MfskSubMode
    {
        public Msfk8Mode() : base("MFSK8", _counter++)
        {
        }

        public override string ReadableName => "MFSK 8";
    }

    public sealed class Msfk11Mode : MfskSubMode
    {
        public Msfk11Mode() : base("MFSK11", _counter++)
        {
        }

        public override string ReadableName => "MFSK 11";
    }

    public sealed class Msfk16Mode : MfskSubMode
    {
        public Msfk16Mode() : base("MFSK16", _counter++)
        {
        }

        public override string ReadableName => "MFSK 16";
    }

    public sealed class Msfk22Mode : MfskSubMode
    {
        public Msfk22Mode() : base("MFSK22", _counter++)
        {
        }

        public override string ReadableName => "MFSK 22";
    }

    public sealed class Msfk31Mode : MfskSubMode
    {
        public Msfk31Mode() : base("MFSK31", _counter++)
        {
        }

        public override string ReadableName => "MFSK 31";
    }

    public sealed class Msfk32Mode : MfskSubMode
    {
        public Msfk32Mode() : base("MFSK32", _counter++)
        {
        }

        public override string ReadableName => "MFSK 32";
    }

    public sealed class Msfk64Mode : MfskSubMode
    {
        public Msfk64Mode() : base("MFSK64", _counter++)
        {
        }

        public override string ReadableName => "MFSK 64";
    }

    public sealed class Msfk64LMode : MfskSubMode
    {
        public Msfk64LMode() : base("MFSK64L", _counter++)
        {
        }

        public override string ReadableName => "MFSK 64 L";
    }

    public sealed class Msfk128Mode : MfskSubMode
    {
        public Msfk128Mode() : base("MFSK128", _counter++)
        {
        }

        public override string ReadableName => "MFSK 128";
    }

    public sealed class Msfk128LMode : MfskSubMode
    {
        public Msfk128LMode() : base("MFSK128L", _counter++)
        {
        }

        public override string ReadableName => "MFSK 128 L";
    }

    public sealed class Q65Mode : MfskSubMode
    {
        public Q65Mode() : base("Q65", _counter++)
        {
        }

        public override string ReadableName => "Q65";
    }
}

public abstract class OliviaSubMode : SmartEnum<OliviaSubMode>, IModeInterface
{
    // Options
    public static readonly OliviaSubMode OLIVIA_4_125 = new Olivia_4_125Mode();
    public static readonly OliviaSubMode OLIVIA_4_250 = new Olivia_4_250Mode();
    public static readonly OliviaSubMode OLIVIA_8_250 = new Olivia_8_250Mode();
    public static readonly OliviaSubMode OLIVIA_8_500 = new Olivia_8_500Mode();
    public static readonly OliviaSubMode OLIVIA_16_500 = new Olivia_16_500Mode();
    public static readonly OliviaSubMode OLIVIA_16_1000 = new Olivia_16_1000Mode();
    public static readonly OliviaSubMode OLIVIA_32_1000 = new Olivia_32_1000Mode();

    // Properties
    public abstract string ReadableName { get; }

    // Counter
    private static int _counter = 0;

    private OliviaSubMode(string name, int value) : base(name, value)
    {
    }

    // Option implementations
    public sealed class Olivia_4_125Mode : OliviaSubMode
    {
        public Olivia_4_125Mode() : base("OLIVIA 4/125", _counter++)
        {
        }

        public override string ReadableName => "Olivia 4/125";
    }

    public sealed class Olivia_4_250Mode : OliviaSubMode
    {
        public Olivia_4_250Mode() : base("OLIVIA 4/250", _counter++)
        {
        }

        public override string ReadableName => "Olivia 4/250";
    }

    public sealed class Olivia_8_250Mode : OliviaSubMode
    {
        public Olivia_8_250Mode() : base("OLIVIA 8/250", _counter++)
        {
        }

        public override string ReadableName => "Olivia 8/250";
    }

    public sealed class Olivia_8_500Mode : OliviaSubMode
    {
        public Olivia_8_500Mode() : base("OLIVIA 8/500", _counter++)
        {
        }

        public override string ReadableName => "Olivia 8/500";
    }

    public sealed class Olivia_16_500Mode : OliviaSubMode
    {
        public Olivia_16_500Mode() : base("OLIVIA 16/500", _counter++)
        {
        }

        public override string ReadableName => "Olivia 16/500";
    }

    public sealed class Olivia_16_1000Mode : OliviaSubMode
    {
        public Olivia_16_1000Mode() : base("OLIVIA 16/1000", _counter++)
        {
        }

        public override string ReadableName => "Olivia 16/1000";
    }

    public sealed class Olivia_32_1000Mode : OliviaSubMode
    {
        public Olivia_32_1000Mode() : base("OLIVIA 32/1000", _counter++)
        {
        }

        public override string ReadableName => "Olivia 32/1000";
    }
}

public abstract class OperaSubMode : SmartEnum<OperaSubMode>, IModeInterface
{
    // Options
    public static readonly OperaSubMode OPERA_BEACON = new OperaBeaconMode();
    public static readonly OperaSubMode OPERA_QSO = new OperaQsoMode();

    // Properties
    public abstract string ReadableName { get; }

    // Counter
    private static int _counter = 0;

    private OperaSubMode(string name, int value) : base(name, value)
    {
    }

    // Option implementations
    public sealed class OperaBeaconMode : OperaSubMode
    {
        public OperaBeaconMode() : base("OPERA-BEACON", _counter++)
        {
        }

        public override string ReadableName => "OPERA Beacon";
    }

    public sealed class OperaQsoMode : OperaSubMode
    {
        public OperaQsoMode() : base("OPERA-QSO", _counter++)
        {
        }

        public override string ReadableName => "OPERA QSO";
    }
}

public abstract class PacSubMode : SmartEnum<PacSubMode>, IModeInterface
{
    // Options
    public static readonly PacSubMode PAC2 = new Pac2Mode();
    public static readonly PacSubMode PAC3 = new Pac3Mode();
    public static readonly PacSubMode PAC4 = new Pac4Mode();

    // Properties
    public abstract string ReadableName { get; }

    // Counter
    private static int _counter = 0;

    private PacSubMode(string name, int value) : base(name, value)
    {
    }

    // Option implementations
    public sealed class Pac2Mode : PacSubMode
    {
        public Pac2Mode() : base("PAC2", _counter++)
        {
        }

        public override string ReadableName => Name;
    }

    public sealed class Pac3Mode : PacSubMode
    {
        public Pac3Mode() : base("PAC3", _counter++)
        {
        }

        public override string ReadableName => Name;
    }

    public sealed class Pac4Mode : PacSubMode
    {
        public Pac4Mode() : base("PAC4", _counter++)
        {
        }

        public override string ReadableName => Name;
    }
}

public abstract class PaxSubMode : SmartEnum<PaxSubMode>, IModeInterface
{
    // Options
    public static readonly PaxSubMode PAX2 = new Pax2Mode();

    // Properties
    public abstract string ReadableName { get; }

    // Counter
    private static int _counter = 0;

    private PaxSubMode(string name, int value) : base(name, value)
    {
    }

    // Option implementations
    public sealed class Pax2Mode : PaxSubMode
    {
        public Pax2Mode() : base("PAX2", _counter++)
        {
        }

        public override string ReadableName => Name;
    }
}

public abstract class PskSubMode : SmartEnum<PskSubMode>, IModeInterface
{
    // Options
    public static readonly PskSubMode PSK_8PSK125 = new Psk_8Psk125();
    public static readonly PskSubMode PSK_8PSK125F = new Psk_8Psk125F();
    public static readonly PskSubMode PSK_8PSK125FL = new Psk_8Psk125Fl();
    public static readonly PskSubMode PSK_8PSK250 = new Psk_8Psk250();
    public static readonly PskSubMode PSK_8PSK250F = new Psk_8Psk250F();
    public static readonly PskSubMode PSK_8PSK250FL = new Psk_8Psk250Fl();
    public static readonly PskSubMode PSK_8PSK500 = new Psk_8Psk500();
    public static readonly PskSubMode PSK_8PSK500F = new Psk_8Psk500F();
    public static readonly PskSubMode PSK_8PSK1000 = new Psk_8Psk1000();
    public static readonly PskSubMode PSK_8PSK1000F = new Psk_8Psk1000F();
    public static readonly PskSubMode PSK_8PSK1200F = new Psk_8Psk1200F();
    public static readonly PskSubMode FSK31 = new Fsk31Mode();
    public static readonly PskSubMode PSK10 = new Psk10Mode();
    public static readonly PskSubMode PSK31 = new Psk31Mode();
    public static readonly PskSubMode PSK63 = new Psk63Mode();
    public static readonly PskSubMode PSK63F = new Psk63FMode();
    public static readonly PskSubMode PSK63RC4 = new Psk63Rc4Mode();
    public static readonly PskSubMode PSK63RC5 = new Psk63Rc5Mode();
    public static readonly PskSubMode PSK63RC10 = new Psk63Rc10Mode();
    public static readonly PskSubMode PSK63RC20 = new Psk63Rc20Mode();
    public static readonly PskSubMode PSK63RC32 = new Psk63Rc32Mode();
    public static readonly PskSubMode PSK125 = new Psk125Mode();
    public static readonly PskSubMode PSK125C12 = new Psk125C12Mode();
    public static readonly PskSubMode PSK125R = new Psk125RMode();
    public static readonly PskSubMode PSK125RC10 = new Psk125Rc10Mode();
    public static readonly PskSubMode PSK125RC12 = new Psk125Rc12();
    public static readonly PskSubMode PSK125RC16 = new Psk125Rc16();
    public static readonly PskSubMode PSK125RC4 = new Psk125Rc4();
    public static readonly PskSubMode PSK125RC5 = new Psk125Rc5();
    public static readonly PskSubMode PSK250 = new Psk250Mode();
    public static readonly PskSubMode PSK250C6 = new Psk250C6Mode();
    public static readonly PskSubMode PSK250R = new Psk250RMode();
    public static readonly PskSubMode PSK250RC2 = new Psk250Rc2Mode();
    public static readonly PskSubMode PSK250RC3 = new Psk250Rc3Mode();
    public static readonly PskSubMode PSK250RC5 = new Psk250Rc5Mode();
    public static readonly PskSubMode PSK250RC6 = new Psk250Rc6Mode();
    public static readonly PskSubMode PSK250RC7 = new Psk250Rc7Mode();
    public static readonly PskSubMode PSK500 = new Psk500Mode();
    public static readonly PskSubMode PSK500C2 = new Psk500C2Mode();
    public static readonly PskSubMode PSK500C4 = new Psk500C4Mode();
    public static readonly PskSubMode PSK500R = new Psk500RMode();
    public static readonly PskSubMode PSK500RC2 = new Psk500Rc2Mode();
    public static readonly PskSubMode PSK500RC3 = new Psk500Rc3Mode();
    public static readonly PskSubMode PSK500RC4 = new Psk500Rc4Mode();
    public static readonly PskSubMode PSK800C2 = new Psk800C2Mode();
    public static readonly PskSubMode PSK800RC2 = new Psk800Rc2Mode();
    public static readonly PskSubMode PSK1000 = new Psk1000Mode();
    public static readonly PskSubMode PSK1000C2 = new Psk1000C2Mode();
    public static readonly PskSubMode PSK1000R = new Psk1000RMode();
    public static readonly PskSubMode PSK1000RC2 = new Psk1000Rc2Mode();
    public static readonly PskSubMode PSKAM10 = new PskAm10Mode();
    public static readonly PskSubMode PSKAM31 = new PskAm31Mode();
    public static readonly PskSubMode PSKAM50 = new PskAm50Mode();
    public static readonly PskSubMode PSKFEC31 = new PskFec31Mode();
    public static readonly PskSubMode QPSK31 = new QPsk31Mode();
    public static readonly PskSubMode QPSK63 = new QPsk63Mode();
    public static readonly PskSubMode QPSK125 = new QPsk125Mode();
    public static readonly PskSubMode QPSK250 = new QPsk250Mode();
    public static readonly PskSubMode QPSK500 = new QPsk500Mode();
    public static readonly PskSubMode SIM31 = new Sim31Mode();

    // Properties
    public abstract string ReadableName { get; }

    // Counter
    private static int _counter = 0;

    private PskSubMode(string name, int value) : base(name, value)
    {
    }

    // Option implementations
    public sealed class Psk_8Psk125 : PskSubMode
    {
        public Psk_8Psk125() : base("8PSK125", _counter++)
        {
        }

        public override string ReadableName => "8-PSK 125";
    }

    public sealed class Psk_8Psk125F : PskSubMode
    {
        public Psk_8Psk125F() : base("8PSK125F", _counter++)
        {
        }

        public override string ReadableName => "8-PSK 125F";
    }

    public sealed class Psk_8Psk125Fl : PskSubMode
    {
        public Psk_8Psk125Fl() : base("8PSK125FL", _counter++)
        {
        }

        public override string ReadableName => "8-PSK 125 FL";
    }

    public sealed class Psk_8Psk250 : PskSubMode
    {
        public Psk_8Psk250() : base("8PSK250", _counter++)
        {
        }

        public override string ReadableName => "8-PSK 250";
    }

    public sealed class Psk_8Psk250F : PskSubMode
    {
        public Psk_8Psk250F() : base("8PSK250F", _counter++)
        {
        }

        public override string ReadableName => "8-PSK 250 F";
    }

    public sealed class Psk_8Psk250Fl : PskSubMode
    {
        public Psk_8Psk250Fl() : base("8PSK250FL", _counter++)
        {
        }

        public override string ReadableName => "8-PSK 250 FL";
    }

    public sealed class Psk_8Psk500 : PskSubMode
    {
        public Psk_8Psk500() : base("8PSK500", _counter++)
        {
        }

        public override string ReadableName => "8-PSK 500";
    }

    public sealed class Psk_8Psk500F : PskSubMode
    {
        public Psk_8Psk500F() : base("8PSK500F", _counter++)
        {
        }

        public override string ReadableName => "8-PSK 500 F";
    }

    public sealed class Psk_8Psk1000 : PskSubMode
    {
        public Psk_8Psk1000() : base("8PSK1000", _counter++)
        {
        }

        public override string ReadableName => "8-PSK 1000";
    }

    public sealed class Psk_8Psk1000F : PskSubMode
    {
        public Psk_8Psk1000F() : base("8PSK1000F", _counter++)
        {
        }

        public override string ReadableName => "8-PSK 1000 F";
    }

    public sealed class Psk_8Psk1200F : PskSubMode
    {
        public Psk_8Psk1200F() : base("8PSK1200F", _counter++)
        {
        }

        public override string ReadableName => "8-PSK 1200 F";
    }

    public sealed class Fsk31Mode : PskSubMode
    {
        public Fsk31Mode() : base("FSK31", _counter++)
        {
        }

        public override string ReadableName => "FSK 31";
    }

    public sealed class Psk10Mode : PskSubMode
    {
        public Psk10Mode() : base("PSK10", _counter++)
        {
        }

        public override string ReadableName => "PSK 10";
    }

    public sealed class Psk31Mode : PskSubMode
    {
        public Psk31Mode() : base("PSK31", _counter++)
        {
        }

        public override string ReadableName => "PSK 31";
    }

    public sealed class Psk63Mode : PskSubMode
    {
        public Psk63Mode() : base("PSK63", _counter++)
        {
        }

        public override string ReadableName => "PSK 63";
    }

    public sealed class Psk63FMode : PskSubMode
    {
        public Psk63FMode() : base("PSK63F", _counter++)
        {
        }

        public override string ReadableName => "PSK 63 F";
    }

    public sealed class Psk63Rc4Mode : PskSubMode
    {
        public Psk63Rc4Mode() : base("PSK63RC4", _counter++)
        {
        }

        public override string ReadableName => "PSK 63 RC 4";
    }

    public sealed class Psk63Rc5Mode : PskSubMode
    {
        public Psk63Rc5Mode() : base("PSK63RC5", _counter++)
        {
        }

        public override string ReadableName => "PSK 63 RC 5";
    }

    public sealed class Psk63Rc10Mode : PskSubMode
    {
        public Psk63Rc10Mode() : base("PSK63RC10", _counter++)
        {
        }

        public override string ReadableName => "PSK 63 RC 10";
    }

    public sealed class Psk63Rc20Mode : PskSubMode
    {
        public Psk63Rc20Mode() : base("PSK63RC20", _counter++)
        {
        }

        public override string ReadableName => "PSK 63 RC 20";
    }

    public sealed class Psk63Rc32Mode : PskSubMode
    {
        public Psk63Rc32Mode() : base("PSK63RC32", _counter++)
        {
        }

        public override string ReadableName => "PSK 63 RC 32";
    }

    public sealed class Psk125Mode : PskSubMode
    {
        public Psk125Mode() : base("PSK125", _counter++)
        {
        }

        public override string ReadableName => "PSK 125";
    }

    public sealed class Psk125C12Mode : PskSubMode
    {
        public Psk125C12Mode() : base("PSK125C12", _counter++)
        {
        }

        public override string ReadableName => "PSK 125 C 12";
    }

    public sealed class Psk125RMode : PskSubMode
    {
        public Psk125RMode() : base("PSK125R", _counter++)
        {
        }

        public override string ReadableName => "PSK 125 R";
    }

    public sealed class Psk125Rc10Mode : PskSubMode
    {
        public Psk125Rc10Mode() : base("PSK125RC10", _counter++)
        {
        }

        public override string ReadableName => "PSK 125 RC 10";
    }

    public sealed class Psk125Rc12 : PskSubMode
    {
        public Psk125Rc12() : base("PSK125RC12", _counter++)
        {
        }

        public override string ReadableName => "PSK 125 RC 12";
    }

    public sealed class Psk125Rc16 : PskSubMode
    {
        public Psk125Rc16() : base("PSK125RC16", _counter++)
        {
        }

        public override string ReadableName => "PSK 125 RC 16";
    }

    public sealed class Psk125Rc4 : PskSubMode
    {
        public Psk125Rc4() : base("PSK125RC4", _counter++)
        {
        }

        public override string ReadableName => "PSK 125 RC 4";
    }

    public sealed class Psk125Rc5 : PskSubMode
    {
        public Psk125Rc5() : base("PSK125RC5", _counter++)
        {
        }

        public override string ReadableName => "PSK 125 RC 5";
    }

    public sealed class Psk250Mode : PskSubMode
    {
        public Psk250Mode() : base("PSK250", _counter++)
        {
        }

        public override string ReadableName => "PSK 250";
    }

    public sealed class Psk250C6Mode : PskSubMode
    {
        public Psk250C6Mode() : base("PSK250C6", _counter++)
        {
        }

        public override string ReadableName => "PSK 250 C 6";
    }

    public sealed class Psk250RMode : PskSubMode
    {
        public Psk250RMode() : base("PSK250R", _counter++)
        {
        }

        public override string ReadableName => "PSK 250 R";
    }

    public sealed class Psk250Rc2Mode : PskSubMode
    {
        public Psk250Rc2Mode() : base("PSK250RC2", _counter++)
        {
        }

        public override string ReadableName => "PSK 250 RC 2";
    }

    public sealed class Psk250Rc3Mode : PskSubMode
    {
        public Psk250Rc3Mode() : base("PSK250RC3", _counter++)
        {
        }

        public override string ReadableName => "PSK 250 RC 3";
    }

    public sealed class Psk250Rc5Mode : PskSubMode
    {
        public Psk250Rc5Mode() : base("PSK250RC5", _counter++)
        {
        }

        public override string ReadableName => "PSK 250 RC 5";
    }

    public sealed class Psk250Rc6Mode : PskSubMode
    {
        public Psk250Rc6Mode() : base("PSK250RC6", _counter++)
        {
        }

        public override string ReadableName => "PSK 250 RC 6";
    }

    public sealed class Psk250Rc7Mode : PskSubMode
    {
        public Psk250Rc7Mode() : base("PSK250RC7", _counter++)
        {
        }

        public override string ReadableName => "PSK 250 RC 7";
    }

    public sealed class Psk500Mode : PskSubMode
    {
        public Psk500Mode() : base("PSK500", _counter++)
        {
        }

        public override string ReadableName => "PSK 500";
    }

    public sealed class Psk500C2Mode : PskSubMode
    {
        public Psk500C2Mode() : base("PSK500C2", _counter++)
        {
        }

        public override string ReadableName => "PSK 500 C 2";
    }

    public sealed class Psk500C4Mode : PskSubMode
    {
        public Psk500C4Mode() : base("PSK500C4", _counter++)
        {
        }

        public override string ReadableName => "PSK 500 C 4";
    }

    public sealed class Psk500RMode : PskSubMode
    {
        public Psk500RMode() : base("PSK500R", _counter++)
        {
        }

        public override string ReadableName => "PSK 500 R";
    }

    public sealed class Psk500Rc2Mode : PskSubMode
    {
        public Psk500Rc2Mode() : base("PSK500RC2", _counter++)
        {
        }

        public override string ReadableName => "PSK 500 RC 2";
    }

    public sealed class Psk500Rc3Mode : PskSubMode
    {
        public Psk500Rc3Mode() : base("PSK500RC3", _counter++)
        {
        }

        public override string ReadableName => "PSK 500 RC 3";
    }

    public sealed class Psk500Rc4Mode : PskSubMode
    {
        public Psk500Rc4Mode() : base("PSK500RC4", _counter++)
        {
        }

        public override string ReadableName => "PSK 500 RC 4";
    }

    public sealed class Psk800C2Mode : PskSubMode
    {
        public Psk800C2Mode() : base("PSK800C2", _counter++)
        {
        }

        public override string ReadableName => "PSK 800 C 2";
    }

    public sealed class Psk800Rc2Mode : PskSubMode
    {
        public Psk800Rc2Mode() : base("PSK800RC2", _counter++)
        {
        }

        public override string ReadableName => "PSK 800 RC 2";
    }

    public sealed class Psk1000Mode : PskSubMode
    {
        public Psk1000Mode() : base("PSK1000", _counter++)
        {
        }

        public override string ReadableName => "PSK 1000";
    }

    public sealed class Psk1000C2Mode : PskSubMode
    {
        public Psk1000C2Mode() : base("PSK1000C2", _counter++)
        {
        }

        public override string ReadableName => "PSK 1000 C 2";
    }

    public sealed class Psk1000RMode : PskSubMode
    {
        public Psk1000RMode() : base("PSK1000R", _counter++)
        {
        }

        public override string ReadableName => "PSK 1000 R";
    }

    public sealed class Psk1000Rc2Mode : PskSubMode
    {
        public Psk1000Rc2Mode() : base("PSK1000RC2", _counter++)
        {
        }

        public override string ReadableName => "PSK 1000 RC 2";
    }

    public sealed class PskAm10Mode : PskSubMode
    {
        public PskAm10Mode() : base("PSKAM10", _counter++)
        {
        }

        public override string ReadableName => "PSK AM 10";
    }

    public sealed class PskAm31Mode : PskSubMode
    {
        public PskAm31Mode() : base("PSKAM31", _counter++)
        {
        }

        public override string ReadableName => "PSK AM 31";
    }

    public sealed class PskAm50Mode : PskSubMode
    {
        public PskAm50Mode() : base("PSKAM50", _counter++)
        {
        }

        public override string ReadableName => "PSK AM 50";
    }

    public sealed class PskFec31Mode : PskSubMode
    {
        public PskFec31Mode() : base("PSKFEC31", _counter++)
        {
        }

        public override string ReadableName => "PSK FEC 31";
    }

    public sealed class QPsk31Mode : PskSubMode
    {
        public QPsk31Mode() : base("QPSK31", _counter++)
        {
        }

        public override string ReadableName => "QPSK 31";
    }

    public sealed class QPsk63Mode : PskSubMode
    {
        public QPsk63Mode() : base("QPSK63", _counter++)
        {
        }

        public override string ReadableName => "QPSK 63";
    }

    public sealed class QPsk125Mode : PskSubMode
    {
        public QPsk125Mode() : base("QPSK125", _counter++)
        {
        }

        public override string ReadableName => "QPSK 125";
    }

    public sealed class QPsk250Mode : PskSubMode
    {
        public QPsk250Mode() : base("QPSK250", _counter++)
        {
        }

        public override string ReadableName => "QPSK 250";
    }

    public sealed class QPsk500Mode : PskSubMode
    {
        public QPsk500Mode() : base("QPSK500", _counter++)
        {
        }

        public override string ReadableName => "QPSK 500";
    }

    public sealed class Sim31Mode : PskSubMode
    {
        public Sim31Mode() : base("SIM31", _counter++)
        {
        }

        public override string ReadableName => "SIM31";
    }
}

public abstract class Qra64SubMode : SmartEnum<Qra64SubMode>, IModeInterface
{
    // Options
    public static readonly Qra64SubMode QRA64A = new Qra64AMode();
    public static readonly Qra64SubMode QRA64B = new Qra64BMode();
    public static readonly Qra64SubMode QRA64C = new Qra64CMode();
    public static readonly Qra64SubMode QRA64D = new Qra64DMode();
    public static readonly Qra64SubMode QRA64E = new Qra64EMode();

    // Properties
    public abstract string ReadableName { get; }

    // Counter
    private static int _counter = 0;

    private Qra64SubMode(string name, int value) : base(name, value)
    {
    }

    // Option implementations
    public sealed class Qra64AMode : Qra64SubMode
    {
        public Qra64AMode() : base("QRA64A", _counter++)
        {
        }

        public override string ReadableName => "QRA 64 A";
    }

    public sealed class Qra64BMode : Qra64SubMode
    {
        public Qra64BMode() : base("QRA64B", _counter++)
        {
        }

        public override string ReadableName => "QRA 64 B";
    }

    public sealed class Qra64CMode : Qra64SubMode
    {
        public Qra64CMode() : base("QRA64C", _counter++)
        {
        }

        public override string ReadableName => "QRA 64 C";
    }

    public sealed class Qra64DMode : Qra64SubMode
    {
        public Qra64DMode() : base("QRA64D", _counter++)
        {
        }

        public override string ReadableName => "QRA 64 D";
    }

    public sealed class Qra64EMode : Qra64SubMode
    {
        public Qra64EMode() : base("QRA64E", _counter++)
        {
        }

        public override string ReadableName => "QRA 64 E";
    }
}

public abstract class RosSubMode : SmartEnum<RosSubMode>, IModeInterface
{
    // Options
    public static readonly RosSubMode ROS_EME = new RosEmeMode();
    public static readonly RosSubMode ROS_HF = new RosHfMode();
    public static readonly RosSubMode ROS_MF = new RosMfMode();

    // Properties
    public abstract string ReadableName { get; }

    // Counter
    private static int _counter = 0;

    private RosSubMode(string name, int value) : base(name, value)
    {
    }

    // Option implementations
    public sealed class RosEmeMode : RosSubMode
    {
        public RosEmeMode() : base("ROS-EME", _counter++)
        {
        }

        public override string ReadableName => "ROS EME";
    }

    public sealed class RosHfMode : RosSubMode
    {
        public RosHfMode() : base("ROS-HF", _counter++)
        {
        }

        public override string ReadableName => "ROS HF";
    }

    public sealed class RosMfMode : RosSubMode
    {
        public RosMfMode() : base("ROS-MF", _counter++)
        {
        }

        public override string ReadableName => "ROS MF";
    }
}

public abstract class RttySubMode : SmartEnum<RttySubMode>, IModeInterface
{
    // Options
    public static readonly RttySubMode ASCI = new AsciiMode();

    // Properties
    public abstract string ReadableName { get; }

    // Counter
    private static int _counter = 0;

    private RttySubMode(string name, int value) : base(name, value)
    {
    }

    // Option implementations
    public sealed class AsciiMode : RttySubMode
    {
        public AsciiMode() : base("ASCI", _counter++)
        {
        }

        public override string ReadableName => Name;
    }
}

public abstract class SsbSubMode : SmartEnum<SsbSubMode>, IModeInterface
{
    // Options
    public static readonly SsbSubMode LSB = new LsbMode();
    public static readonly SsbSubMode USB = new UsbMode();

    // Properties
    public abstract string ReadableName { get; }

    // Counter
    private static int _counter = 0;

    private SsbSubMode(string name, int value) : base(name, value)
    {
    }

    // Option implementations
    public sealed class LsbMode : SsbSubMode
    {
        public LsbMode() : base("LSB", _counter++)
        {
        }

        public override string ReadableName => Name;
    }

    public sealed class UsbMode : SsbSubMode
    {
        public UsbMode() : base("USB", _counter++)
        {
        }

        public override string ReadableName => Name;
    }
}

public abstract class ThorSubMode : SmartEnum<ThorSubMode>, IModeInterface
{
    // Options
    public static readonly ThorSubMode THOR_M = new ThorMMode();
    public static readonly ThorSubMode THOR4 = new Thor4Mode();
    public static readonly ThorSubMode THOR5 = new Thor5Mode();
    public static readonly ThorSubMode THOR8 = new Thor8Mode();
    public static readonly ThorSubMode THOR11 = new Thor11Mode();
    public static readonly ThorSubMode THOR16 = new Thor16Mode();
    public static readonly ThorSubMode THOR22 = new Thor22Mode();
    public static readonly ThorSubMode THOR25X4 = new Thor25X4Mode();
    public static readonly ThorSubMode THOR50X1 = new Thor50X1Mode();
    public static readonly ThorSubMode THOR50X2 = new Thor50X2Mode();
    public static readonly ThorSubMode THOR100 = new Thor100Mode();

    // Properties
    public abstract string ReadableName { get; }

    // Counter
    private static int _counter = 0;

    private ThorSubMode(string name, int value) : base(name, value)
    {
    }

    // Option implementations
    public sealed class ThorMMode : ThorSubMode
    {
        public ThorMMode() : base("THOR-M", _counter++)
        {
        }

        public override string ReadableName => Name;
    }

    public sealed class Thor4Mode : ThorSubMode
    {
        public Thor4Mode() : base("THOR4", _counter++)
        {
        }

        public override string ReadableName => "THOR 4";
    }

    public sealed class Thor5Mode : ThorSubMode
    {
        public Thor5Mode() : base("THOR5", _counter++)
        {
        }

        public override string ReadableName => "THOR 5";
    }

    public sealed class Thor8Mode : ThorSubMode
    {
        public Thor8Mode() : base("THOR8", _counter++)
        {
        }

        public override string ReadableName => "THOR 8";
    }

    public sealed class Thor11Mode : ThorSubMode
    {
        public Thor11Mode() : base("THOR11", _counter++)
        {
        }

        public override string ReadableName => "THOR 11";
    }

    public sealed class Thor16Mode : ThorSubMode
    {
        public Thor16Mode() : base("THOR16", _counter++)
        {
        }

        public override string ReadableName => "THOR 16";
    }

    public sealed class Thor22Mode : ThorSubMode
    {
        public Thor22Mode() : base("THOR22", _counter++)
        {
        }

        public override string ReadableName => "THOR 22";
    }

    public sealed class Thor25X4Mode : ThorSubMode
    {
        public Thor25X4Mode() : base("THOR25X4", _counter++)
        {
        }

        public override string ReadableName => "THOR 25X4";
    }

    public sealed class Thor50X1Mode : ThorSubMode
    {
        public Thor50X1Mode() : base("THOR50X1", _counter++)
        {
        }

        public override string ReadableName => "THOR 50X1";
    }

    public sealed class Thor50X2Mode : ThorSubMode
    {
        public Thor50X2Mode() : base("THOR50X2", _counter++)
        {
        }

        public override string ReadableName => "THOR 50X2";
    }

    public sealed class Thor100Mode : ThorSubMode
    {
        public Thor100Mode() : base("THOR100", _counter++)
        {
        }

        public override string ReadableName => "THOR 100";
    }
}

public abstract class ThrbSubMode : SmartEnum<ThrbSubMode>, IModeInterface
{
    // Options
    public static readonly ThrbSubMode THRBX = new ThrbXMode();
    public static readonly ThrbSubMode THRBX1 = new ThrbX1Mode();
    public static readonly ThrbSubMode THRBX2 = new ThrbX2Mode();
    public static readonly ThrbSubMode THRBX4 = new ThrbX4Mode();
    public static readonly ThrbSubMode THROB1 = new ThrOb1Mode();
    public static readonly ThrbSubMode THROB2 = new ThrOb2Mode();
    public static readonly ThrbSubMode THROB4 = new ThrOb4Mode();

    // Properties
    public abstract string ReadableName { get; }

    // Counter
    private static int _counter = 0;

    private ThrbSubMode(string name, int value) : base(name, value)
    {
    }

    // Option implementations
    public sealed class ThrbXMode : ThrbSubMode
    {
        public ThrbXMode() : base("THRBX", _counter++)
        {
        }

        public override string ReadableName => "THROB X";
    }

    public sealed class ThrbX1Mode : ThrbSubMode
    {
        public ThrbX1Mode() : base("THRBX1", _counter++)
        {
        }

        public override string ReadableName => "THROB X1";
    }

    public sealed class ThrbX2Mode : ThrbSubMode
    {
        public ThrbX2Mode() : base("THRBX2", _counter++)
        {
        }

        public override string ReadableName => "THROB X2";
    }

    public sealed class ThrbX4Mode : ThrbSubMode
    {
        public ThrbX4Mode() : base("THRBX4", _counter++)
        {
        }

        public override string ReadableName => "THROB X4";
    }

    public sealed class ThrOb1Mode : ThrbSubMode
    {
        public ThrOb1Mode() : base("THROB1", _counter++)
        {
        }

        public override string ReadableName => "THROB B1";
    }

    public sealed class ThrOb2Mode : ThrbSubMode
    {
        public ThrOb2Mode() : base("THROB2", _counter++)
        {
        }

        public override string ReadableName => "THROB B2";
    }

    public sealed class ThrOb4Mode : ThrbSubMode
    {
        public ThrOb4Mode() : base("THROB4", _counter++)
        {
        }

        public override string ReadableName => "THROB B4";
    }
}

public abstract class TorSubMode : SmartEnum<TorSubMode>, IModeInterface
{
    // Options
    public static readonly TorSubMode AMTORFEC = new AmtorfecMode();
    public static readonly TorSubMode GTOR = new GtorMode();
    public static readonly TorSubMode NAVTEX = new NavtexMode();
    public static readonly TorSubMode SITORB = new SitorbMode();

    // Properties
    public abstract string ReadableName { get; }

    // Counter
    private static int _counter = 0;

    private TorSubMode(string name, int value) : base(name, value)
    {
    }

    // Option implementations
    public sealed class AmtorfecMode : TorSubMode
    {
        public AmtorfecMode() : base("AMTORFEC", _counter++)
        {
        }

        public override string ReadableName => "AMTOR-FEC";
    }

    public sealed class GtorMode : TorSubMode
    {
        public GtorMode() : base("FTOR", _counter++)
        {
        }

        public override string ReadableName => Name;
    }

    public sealed class NavtexMode : TorSubMode
    {
        public NavtexMode() : base("NAVTEX", _counter++)
        {
        }

        public override string ReadableName => Name;
    }

    public sealed class SitorbMode : TorSubMode
    {
        public SitorbMode() : base("SITORB", _counter++)
        {
        }

        public override string ReadableName => Name;
    }
}