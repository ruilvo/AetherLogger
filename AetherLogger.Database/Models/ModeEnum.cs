// This file is part of AetherLogger
// SPDX-FileCopyrightText: 2024 Rui Oliveira <ruimail24@gmail.com>
// SPDX-License-Identifier: Apache-2.0


using Ardalis.SmartEnum;
using ISmartEnum = AetherLogger.Common.ISmartEnum;

namespace AetherLogger.Database.Models;

public interface IModeEnum : ISmartEnum
{
    string ReadableName { get; }
}

public abstract class ModeEnumBase<TEnum>(string name, string? readableName = null) : SmartEnum<TEnum, int>(name, ++_counter), IModeEnum where TEnum : SmartEnum<TEnum, int>
{

    // I think this static member is shared across all instances of the generic type
    // but it's not a problem because the numeric value is unimportant.
    private static int _counter;
    public string ReadableName { get; } = readableName ?? name;
}

/// <summary>
/// The mode of operation.
/// </summary>
/// <remarks>
/// This follows the
/// <see href="https://www.adif.org/315/ADIF_315_annotated.htm#Mode_Enumeration">ADIF 3.15 specification</see>
/// for the enumeration of modes.
/// Import-only modes are not included.
/// </remarks>
public sealed class ModeEnum : ModeEnumBase<ModeEnum>
{
    public static readonly ModeEnum AM = new(nameof(AM));
    public static readonly ModeEnum ARDOP = new(nameof(ARDOP));
    public static readonly ModeEnum ATV = new(nameof(ATV));
    public static readonly ModeEnum CHIP = new(nameof(CHIP), ChipSubMode.List);
    public static readonly ModeEnum CLO = new(nameof(CLO));
    public static readonly ModeEnum CONTESTI = new(nameof(CONTESTI), "Contestia");
    public static readonly ModeEnum CW = new(nameof(CW), "Morse (CW)", CwSubMode.List);
    public static readonly ModeEnum DIGITALVOICE = new(nameof(DIGITALVOICE), "Digital Voice", DigitalVoiceSubMode.List);
    public static readonly ModeEnum DOMINO = new(nameof(DOMINO), "Domino", DominoSubMode.List);
    public static readonly ModeEnum DYNAMIC = new(nameof(DYNAMIC), "VARA (Dynamic)", DynamicSubMode.List);
    public static readonly ModeEnum FAX = new(nameof(FAX), "Fax");
    public static readonly ModeEnum FM = new(nameof(FM));
    public static readonly ModeEnum FSK411 = new(nameof(FSK411));
    public static readonly ModeEnum FT8 = new(nameof(FT8));
    public static readonly ModeEnum HELL = new(nameof(HELL), "Hellschreiber", HellSubMode.List);
    public static readonly ModeEnum ISCAT = new(nameof(ISCAT), "Ionospheric Scattering (ISCAT)", IscatSubMode.List);
    public static readonly ModeEnum JT4 = new(nameof(JT4), Jt4SubMode.List);
    public static readonly ModeEnum JT6M = new(nameof(JT6M));
    public static readonly ModeEnum JT9 = new(nameof(JT9), Jt9SubMode.List);
    public static readonly ModeEnum JT44 = new(nameof(JT44));
    public static readonly ModeEnum JT65 = new(nameof(JT65), Jt65SubMode.List);
    public static readonly ModeEnum MFSK = new(nameof(MFSK), MfskSubMode.List);
    public static readonly ModeEnum MSK144 = new(nameof(MSK144));
    public static readonly ModeEnum MT63 = new(nameof(MT63));
    public static readonly ModeEnum OLIVIA = new(nameof(OLIVIA), "Olivia MFSK", OliviaSubMode.List);
    public static readonly ModeEnum OPERA = new(nameof(OPERA), OperaSubMode.List);
    public static readonly ModeEnum PAC = new(nameof(PAC), "PACTOR", PacSubMode.List);
    public static readonly ModeEnum PAX = new(nameof(PAX), PaxSubMode.List);
    public static readonly ModeEnum PKT = new(nameof(PKT), "Packet");
    public static readonly ModeEnum PSK = new(nameof(PSK), PskSubMode.List);
    public static readonly ModeEnum PSK2K = new(nameof(PSK2K));
    public static readonly ModeEnum Q15 = new(nameof(Q15));
    public static readonly ModeEnum QRA64 = new(nameof(QRA64), Qra64SubMode.List);
    public static readonly ModeEnum ROS = new(nameof(ROS), RosSubMode.List);
    public static readonly ModeEnum RTTY = new(nameof(RTTY), RttySubMode.List);
    public static readonly ModeEnum RTTYM = new(nameof(RTTYM));
    public static readonly ModeEnum SSB = new(nameof(SSB), SsbSubMode.List);
    public static readonly ModeEnum SSTV = new(nameof(SSTV));
    public static readonly ModeEnum T10 = new(nameof(T10));
    public static readonly ModeEnum THOR = new(nameof(THOR), ThorSubMode.List);
    public static readonly ModeEnum THRB = new(nameof(THRB), "THROB", ThrbSubMode.List);
    public static readonly ModeEnum TOR = new(nameof(TOR), "(SI)TOR", TorSubMode.List);
    public static readonly ModeEnum V4 = new(nameof(V4));
    public static readonly ModeEnum VOI = new(nameof(VOI), "VOICE (Olivia)");
    public static readonly ModeEnum WINMOR = new(nameof(WINMOR));
    public static readonly ModeEnum WSPR = new(nameof(WSPR));

    public IEnumerable<IModeEnum>? Submodes { get; }

    private ModeEnum(string name, string? readableName = null, IEnumerable<IModeEnum>? submodes = null) : base(name, readableName)
    {
        Submodes = submodes;
    }

    public ModeEnum(string name, IEnumerable<IModeEnum> submodes) : this(name, name, submodes)
    {
    }
}


public sealed class ChipSubMode(string name, string? readableName = null) : ModeEnumBase<ChipSubMode>(name, readableName)
{
    public static readonly ChipSubMode CHIP64 = new(nameof(CHIP64), "CHIP 64");
    public static readonly ChipSubMode CHIP128 = new(nameof(CHIP128), "CHIP 128");
}

public sealed class CwSubMode(string name, string? readableName = null) : ModeEnumBase<CwSubMode>(name, readableName)
{
    public static readonly CwSubMode PCW = new(nameof(PCW), "Precision CW");
}

public sealed class DigitalVoiceSubMode(string name, string? readableName = null) : ModeEnumBase<DigitalVoiceSubMode>(name, readableName)
{
    public static readonly DigitalVoiceSubMode C4FM = new(nameof(C4FM), "C4FM (Fusion)");
    public static readonly DigitalVoiceSubMode DMR = new(nameof(DMR), "DMR");
    public static readonly DigitalVoiceSubMode DSTAR = new(nameof(DSTAR), "D-Star");
    public static readonly DigitalVoiceSubMode FREEDV = new(nameof(FREEDV), "FreeDV");
    public static readonly DigitalVoiceSubMode M17 = new(nameof(M17), "M17");
}

public sealed class DominoSubMode(string name, string? readableName = null) : ModeEnumBase<DominoSubMode>(name, readableName)
{
    public static readonly DominoSubMode DOM_M = new("DOM-M");
    public static readonly DominoSubMode DOM4 = new(nameof(DOM4));
    public static readonly DominoSubMode DOM5 = new(nameof(DOM5));
    public static readonly DominoSubMode DOM8 = new(nameof(DOM8));
    public static readonly DominoSubMode DOM11 = new(nameof(DOM11));
    public static readonly DominoSubMode DOM16 = new(nameof(DOM16));
    public static readonly DominoSubMode DOM22 = new(nameof(DOM22));
    public static readonly DominoSubMode DOM44 = new(nameof(DOM44));
    public static readonly DominoSubMode DOM88 = new(nameof(DOM88));
    public static readonly DominoSubMode DOMINOEX = new(nameof(DOMINOEX), "DominoEX");
    public static readonly DominoSubMode DOMINOF = new(nameof(DOMINOF), "DominoF");
}

public sealed class DynamicSubMode(string name, string? readableName = null) : ModeEnumBase<DynamicSubMode>(name, readableName)
{
    public static readonly DynamicSubMode VARA_HF = new("VARA HF");
    public static readonly DynamicSubMode VARA_SATELLITE = new("VARA SATELLITE", "VARA Satellite");
    public static readonly DynamicSubMode VARA_FM_1200 = new("VARA FM 1200");
    public static readonly DynamicSubMode VARA_FM_9600 = new("VARA FM 9600");
}

public sealed class HellSubMode(string name, string? readableName = null) : ModeEnumBase<HellSubMode>(name, readableName)
{
    public static readonly HellSubMode FMHELL = new(nameof(FMHELL), "FM Hellschreiber");
    public static readonly HellSubMode FSKH105 = new(nameof(FSKH105), "FSK Hellschreiber 105");
    public static readonly HellSubMode FSKH245 = new(nameof(FSKH245), "FSK Hellschreiber 245");
    public static readonly HellSubMode FSKHELL = new(nameof(FSKHELL), "FSK Hellschreiber");
    public static readonly HellSubMode HELL80 = new(nameof(HELL80), "Hellschreiber 80");
    public static readonly HellSubMode HELLX5 = new(nameof(HELLX5), "Hellschreiber X5");
    public static readonly HellSubMode HELLX9 = new(nameof(HELLX9), "Hellschreiber X9");
    public static readonly HellSubMode HFSK = new(nameof(HFSK), "Hellschreiber FSK");
    public static readonly HellSubMode PSKHELL = new(nameof(PSKHELL), "PSK Hellschreiber");
    public static readonly HellSubMode SLOWHELL = new(nameof(SLOWHELL), "Slow Hellschreiber");
}

public sealed class IscatSubMode(string name, string? readableName = null) : ModeEnumBase<IscatSubMode>(name, readableName)
{
    public static readonly IscatSubMode ISCAT_A = new("ISCAT-A");
    public static readonly IscatSubMode ISCAT_B = new("ISCAT-B");
}

public sealed class Jt4SubMode(string name, string? readableName = null) : ModeEnumBase<Jt4SubMode>(name, readableName)
{
    public static readonly Jt4SubMode JT4A = new(nameof(JT4A));
    public static readonly Jt4SubMode JT4B = new(nameof(JT4B));
    public static readonly Jt4SubMode JT4C = new(nameof(JT4C));
    public static readonly Jt4SubMode JT4D = new(nameof(JT4D));
    public static readonly Jt4SubMode JT4E = new(nameof(JT4E));
    public static readonly Jt4SubMode JT4F = new(nameof(JT4F));
    public static readonly Jt4SubMode JT4G = new(nameof(JT4G));
}

public sealed class Jt9SubMode(string name, string? readableName = null) : ModeEnumBase<Jt9SubMode>(name, readableName)
{
    public static readonly Jt9SubMode JT9_1 = new("JT9-1");
    public static readonly Jt9SubMode JT9_2 = new("JT9-2");
    public static readonly Jt9SubMode JT9_5 = new("JT9-5");
    public static readonly Jt9SubMode JT9_10 = new("JT9-10");
    public static readonly Jt9SubMode JT9_30 = new("JT9-30");
    public static readonly Jt9SubMode JT9A = new(nameof(JT9A));
    public static readonly Jt9SubMode JT9B = new(nameof(JT9B));
    public static readonly Jt9SubMode JT9C = new(nameof(JT9C));
    public static readonly Jt9SubMode JT9D = new(nameof(JT9D));
    public static readonly Jt9SubMode JT9E = new(nameof(JT9E));
    public static readonly Jt9SubMode JT9E_FAST = new("JT9E FAST", "JT9E (Fast)");
    public static readonly Jt9SubMode JT9F = new(nameof(JT9F));
    public static readonly Jt9SubMode JT9F_FAST = new("JT9F FAST", "JT9F (Fast)");
    public static readonly Jt9SubMode JT9G = new(nameof(JT9G));
    public static readonly Jt9SubMode JT9G_FAST = new("JT9G FAST", "JT9G (Fast)");
    public static readonly Jt9SubMode JT9H = new(nameof(JT9H));
    public static readonly Jt9SubMode JT9H_FAST = new("JT9H FAST", "JT9H (Fast)");
}

public sealed class Jt65SubMode(string name, string? readableName = null) : ModeEnumBase<Jt65SubMode>(name, readableName)
{
    public static readonly Jt65SubMode JT65A = new(nameof(JT65A));
    public static readonly Jt65SubMode JT65B = new(nameof(JT65B));
    public static readonly Jt65SubMode JT65B2 = new(nameof(JT65B2));
    public static readonly Jt65SubMode JT65C = new(nameof(JT65C));
    public static readonly Jt65SubMode JT65C2 = new(nameof(JT65C2));
}

public sealed class MfskSubMode(string name, string? readableName = null) : ModeEnumBase<MfskSubMode>(name, readableName)
{
    public static readonly MfskSubMode FSQCALL = new(nameof(FSQCALL), "FSQCall");
    public static readonly MfskSubMode FST4 = new(nameof(FST4));
    public static readonly MfskSubMode FST4W = new(nameof(FST4W));
    public static readonly MfskSubMode FT4 = new(nameof(FT4));
    public static readonly MfskSubMode JS8 = new(nameof(JS8));
    public static readonly MfskSubMode JTMS = new(nameof(JTMS));
    public static readonly MfskSubMode MFSK4 = new(nameof(MFSK4), "MFSK 4");
    public static readonly MfskSubMode MFSK8 = new(nameof(MFSK8), "MFSK 8");
    public static readonly MfskSubMode MFSK11 = new(nameof(MFSK11), "MFSK 11");
    public static readonly MfskSubMode MFSK16 = new(nameof(MFSK16), "MFSK 16");
    public static readonly MfskSubMode MFSK22 = new(nameof(MFSK22), "MFSK 22");
    public static readonly MfskSubMode MFSK31 = new(nameof(MFSK31), "MFSK 31");
    public static readonly MfskSubMode MFSK32 = new(nameof(MFSK32), "MFSK 32");
    public static readonly MfskSubMode MFSK64 = new(nameof(MFSK64), "MFSK 64");
    public static readonly MfskSubMode MFSK64L = new(nameof(MFSK64L), "MFSK 64 L");
    public static readonly MfskSubMode MFSK128 = new(nameof(MFSK128), "MFSK 128");
    public static readonly MfskSubMode MFSK128L = new(nameof(MFSK128L), "MFSK 128 L");
    public static readonly MfskSubMode Q65 = new(nameof(Q65));
}

public sealed class OliviaSubMode(string name, string? readableName = null) : ModeEnumBase<OliviaSubMode>(name, readableName)
{
    public static readonly OliviaSubMode OLIVIA_4_125 = new("OLIVIA 4/125", "Olivia 4/125");
    public static readonly OliviaSubMode OLIVIA_4_250 = new("OLIVIA 4/250", "Olivia 4/250");
    public static readonly OliviaSubMode OLIVIA_8_250 = new("OLIVIA 8/250", "Olivia 8/250");
    public static readonly OliviaSubMode OLIVIA_8_500 = new("OLIVIA 8/500", "Olivia 8/500");
    public static readonly OliviaSubMode OLIVIA_16_500 = new("OLIVIA 16/500", "Olivia 16/500");
    public static readonly OliviaSubMode OLIVIA_16_1000 = new("OLIVIA 16/1000", "Olivia 16/1000");
    public static readonly OliviaSubMode OLIVIA_32_1000 = new("OLIVIA 32/1000", "Olivia 32/1000");
}

public sealed class OperaSubMode(string name, string? readableName = null) : ModeEnumBase<OperaSubMode>(name, readableName)
{
    public static readonly OperaSubMode OPERA_BEACON = new("OPERA-BEACON", "OPERA Beacon");
    public static readonly OperaSubMode OPERA_QSO = new("OPERA-QSO", "OPERA QSO");
}

public sealed class PacSubMode(string name, string? readableName = null) : ModeEnumBase<PacSubMode>(name, readableName)
{
    public static readonly PacSubMode PAC2 = new(nameof(PAC2));
    public static readonly PacSubMode PAC3 = new(nameof(PAC3));
    public static readonly PacSubMode PAC4 = new(nameof(PAC4));
}

public sealed class PaxSubMode(string name, string? readableName = null) : ModeEnumBase<PaxSubMode>(name, readableName)
{
    public static readonly PaxSubMode PAX2 = new(nameof(PAX2));
}

public sealed class PskSubMode(string name, string? readableName = null) : ModeEnumBase<PskSubMode>(name, readableName)
{
    public static readonly PskSubMode PSK_8PSK125 = new("8PSK125", "8-PSK 125");
    public static readonly PskSubMode PSK_8PSK125F = new("8PSK125F", "8-PSK 125 F");
    public static readonly PskSubMode PSK_8PSK125FL = new("8PSK125FL", "8-PSK 125 FL");
    public static readonly PskSubMode PSK_8PSK250 = new("8PSK250", "8-PSK 250");
    public static readonly PskSubMode PSK_8PSK250F = new("8PSK250F", "8-PSK 250 F");
    public static readonly PskSubMode PSK_8PSK250FL = new("8PSK250FL", "8-PSK 250 FL");
    public static readonly PskSubMode PSK_8PSK500 = new("8PSK500", "8-PSK 500");
    public static readonly PskSubMode PSK_8PSK500F = new("8PSK500F", "8-PSK 500 F");
    public static readonly PskSubMode PSK_8PSK1000 = new("8PSK1000", "8-PSK 1000");
    public static readonly PskSubMode PSK_8PSK1000F = new("8PSK1000F", "8-PSK 1000 F");
    public static readonly PskSubMode PSK_8PSK1200F = new("8PSK1200F", "8-PSK 1200 F");
    public static readonly PskSubMode FSK31 = new(nameof(FSK31), "FSK 31");
    public static readonly PskSubMode PSK10 = new(nameof(PSK10), "PSK 10");
    public static readonly PskSubMode PSK31 = new(nameof(PSK31), "PSK 31");
    public static readonly PskSubMode PSK63 = new(nameof(PSK63), "PSK 63");
    public static readonly PskSubMode PSK63F = new(nameof(PSK63F), "PSK 63 F");
    public static readonly PskSubMode PSK63RC4 = new(nameof(PSK63RC4), "PSK 63 RC 4");
    public static readonly PskSubMode PSK63RC5 = new(nameof(PSK63RC5), "PSK 63 RC 5");
    public static readonly PskSubMode PSK63RC10 = new(nameof(PSK63RC10), "PSK 63 RC 10");
    public static readonly PskSubMode PSK63RC20 = new(nameof(PSK63RC20), "PSK 63 RC 20");
    public static readonly PskSubMode PSK63RC32 = new(nameof(PSK63RC32), "PSK 63 RC 32");
    public static readonly PskSubMode PSK125 = new(nameof(PSK125), "PSK 125");
    public static readonly PskSubMode PSK125C12 = new(nameof(PSK125C12), "PSK 125 C 12");
    public static readonly PskSubMode PSK125R = new(nameof(PSK125R), "PSK 125 R");
    public static readonly PskSubMode PSK125RC10 = new(nameof(PSK125RC10), "PSK 125 RC 10");
    public static readonly PskSubMode PSK125RC12 = new(nameof(PSK125RC12), "PSK 125 RC 12");
    public static readonly PskSubMode PSK125RC16 = new(nameof(PSK125RC16), "PSK 125 RC 16");
    public static readonly PskSubMode PSK125RC4 = new(nameof(PSK125RC4), "PSK 125 RC 4");
    public static readonly PskSubMode PSK125RC5 = new(nameof(PSK125RC5), "PSK 125 RC 5");
    public static readonly PskSubMode PSK250 = new(nameof(PSK250), "PSK 250");
    public static readonly PskSubMode PSK250C6 = new(nameof(PSK250C6), "PSK 250 C 6");
    public static readonly PskSubMode PSK250R = new(nameof(PSK250R), "PSK 250 R");
    public static readonly PskSubMode PSK250RC2 = new(nameof(PSK250RC2), "PSK 250 RC 2");
    public static readonly PskSubMode PSK250RC3 = new(nameof(PSK250RC3), "PSK 250 RC 3");
    public static readonly PskSubMode PSK250RC5 = new(nameof(PSK250RC5), "PSK 250 RC 5");
    public static readonly PskSubMode PSK250RC6 = new(nameof(PSK250RC6), "PSK 250 RC 6");
    public static readonly PskSubMode PSK250RC7 = new(nameof(PSK250RC7), "PSK 250 RC 7");
    public static readonly PskSubMode PSK500 = new(nameof(PSK500), "PSK 500");
    public static readonly PskSubMode PSK500C2 = new(nameof(PSK500C2), "PSK 500 C2");
    public static readonly PskSubMode PSK500C4 = new(nameof(PSK500C4), "PSK 500 C4");
    public static readonly PskSubMode PSK500R = new(nameof(PSK500R), "PSK 500 R");
    public static readonly PskSubMode PSK500RC2 = new(nameof(PSK500RC2), "PSK 500 RC 2");
    public static readonly PskSubMode PSK500RC3 = new(nameof(PSK500RC3), "PSK 500 RC 3");
    public static readonly PskSubMode PSK500RC4 = new(nameof(PSK500RC4), "PSK 500 RC 4");
    public static readonly PskSubMode PSK800C2 = new(nameof(PSK800C2), "PSK 800 C 2");
    public static readonly PskSubMode PSK800RC2 = new(nameof(PSK800RC2), "PSK 800 RC 2");
    public static readonly PskSubMode PSK1000 = new(nameof(PSK1000), "PSK 1000");
    public static readonly PskSubMode PSK1000C2 = new(nameof(PSK1000C2), "PSK 1000 C 2");
    public static readonly PskSubMode PSK1000R = new(nameof(PSK1000R), "PSK 1000 R");
    public static readonly PskSubMode PSK1000RC2 = new(nameof(PSK1000RC2), "PSK 1000 RC 2");
    public static readonly PskSubMode PSKAM10 = new(nameof(PSKAM10), "PSKAM 10");
    public static readonly PskSubMode PSKAM31 = new(nameof(PSKAM31), "PSKAM 31");
    public static readonly PskSubMode PSKAM50 = new(nameof(PSKAM50), "PSKAM 50");
    public static readonly PskSubMode PSKFEC31 = new(nameof(PSKFEC31), "PSK FEC 31");
    public static readonly PskSubMode QPSK31 = new(nameof(QPSK31), "QPSK 31");
    public static readonly PskSubMode QPSK63 = new(nameof(QPSK63), "QPSK 63");
    public static readonly PskSubMode QPSK125 = new(nameof(QPSK125), "QPSK 125");
    public static readonly PskSubMode QPSK250 = new(nameof(QPSK250), "QPSK 250");
    public static readonly PskSubMode QPSK500 = new(nameof(QPSK500), "QPSK 500");
    public static readonly PskSubMode SIM31 = new(nameof(SIM31), "SIM 31");
}

public sealed class Qra64SubMode(string name, string? readableName = null) : ModeEnumBase<Qra64SubMode>(name, readableName)
{
    public static readonly Qra64SubMode QRA64A = new(nameof(QRA64A), "QRA 64 A");
    public static readonly Qra64SubMode QRA64B = new(nameof(QRA64B), "QRA 64 B");
    public static readonly Qra64SubMode QRA64C = new(nameof(QRA64C), "QRA 64 C");
    public static readonly Qra64SubMode QRA64D = new(nameof(QRA64D), "QRA 64 D");
    public static readonly Qra64SubMode QRA64E = new(nameof(QRA64E), "QRA 64 E");
}

public sealed class RosSubMode(string name, string? readableName = null) : ModeEnumBase<RosSubMode>(name, readableName)
{
    public static readonly RosSubMode ROS_EME = new("ROS-EME", "ROS EME");
    public static readonly RosSubMode ROS_HF = new("ROS-HF", "ROS HF");
    public static readonly RosSubMode ROS_MF = new("ROS-MF", "ROS MF");
}

public sealed class RttySubMode(string name, string? readableName = null) : ModeEnumBase<RttySubMode>(name, readableName)
{
    public static readonly RttySubMode ASCI = new(nameof(ASCI), "ASCII");
}

public sealed class SsbSubMode(string name, string? readableName = null) : ModeEnumBase<SsbSubMode>(name, readableName)
{
    public static readonly SsbSubMode LSB = new(nameof(LSB));
    public static readonly SsbSubMode USB = new(nameof(USB));
}

public sealed class ThorSubMode(string name, string? readableName = null) : ModeEnumBase<ThorSubMode>(name, readableName)
{
    public static readonly ThorSubMode THOR_M = new("THOR-M");
    public static readonly ThorSubMode THOR4 = new(nameof(THOR4), "THOR 4");
    public static readonly ThorSubMode THOR5 = new(nameof(THOR5), "THOR 5");
    public static readonly ThorSubMode THOR8 = new(nameof(THOR8), "THOR 8");
    public static readonly ThorSubMode THOR11 = new(nameof(THOR11), "THOR 11");
    public static readonly ThorSubMode THOR16 = new(nameof(THOR16), "THOR 16");
    public static readonly ThorSubMode THOR22 = new(nameof(THOR22), "THOR 22");
    public static readonly ThorSubMode THOR25X4 = new(nameof(THOR25X4), "THOR 25X4");
    public static readonly ThorSubMode THOR50X1 = new(nameof(THOR50X1), "THOR 50X1");
    public static readonly ThorSubMode THOR50X2 = new(nameof(THOR50X2), "THOR 50X2");
    public static readonly ThorSubMode THOR100 = new(nameof(THOR100), "THOR 100");
}

public sealed class ThrbSubMode(string name, string? readableName = null) : ModeEnumBase<ThrbSubMode>(name, readableName)
{
    public static readonly ThrbSubMode THRBX = new(nameof(THRBX), "THROB X");
    public static readonly ThrbSubMode THRBX1 = new(nameof(THRBX1), "THROB X1");
    public static readonly ThrbSubMode THRBX2 = new(nameof(THRBX2), "THROB X2");
    public static readonly ThrbSubMode THRBX4 = new(nameof(THRBX4), "THROB X4");
    public static readonly ThrbSubMode THROB1 = new(nameof(THROB1), "THROB B1");
    public static readonly ThrbSubMode THROB2 = new(nameof(THROB2), "THROB B2");
    public static readonly ThrbSubMode THROB4 = new(nameof(THROB4), "THROB B4");
}

public sealed class TorSubMode(string name, string? readableName = null) : ModeEnumBase<TorSubMode>(name, readableName)
{
    public static readonly TorSubMode AMTORFEC = new(nameof(AMTORFEC), "AMTOR-FEC");
    public static readonly TorSubMode GTOR = new(nameof(GTOR));
    public static readonly TorSubMode NAVTEX = new(nameof(NAVTEX));
    public static readonly TorSubMode SITORB = new(nameof(SITORB));
}
