using System.ComponentModel;

namespace Yuri.ArmsMall.IdentityCards;

/// <summary>
/// 民族
/// </summary>
public enum Nation
{
    /// <summary>
    /// 汉族
    /// </summary>
    [Description("汉族")]
    HAN = 1,

    /// <summary>
    /// 壮族
    /// </summary>
    [Description("壮族")]
    ZHUANG = 2,

    /// <summary>
    /// 满族
    /// </summary>
    [Description("满族")]
    MANCHU = 3,

    /// <summary>
    /// 回族
    /// </summary>
    [Description("回族")]
    HUI = 4,

    /// <summary>
    /// 苗族
    /// </summary>
    [Description("苗族")]
    MIAO = 5,

    /// <summary>
    /// 维吾尔族
    /// </summary>
    [Description("维吾尔族")]
    UYGHUR = 6,

    /// <summary>
    /// 彝族
    /// </summary>
    [Description("彝族")]
    YI = 7,

    /// <summary>
    /// 土家族
    /// </summary>
    [Description("土家族")]
    TUJIA = 8,

    /// <summary>
    /// 蒙古族
    /// </summary>
    [Description("蒙古族")]
    MONGOL = 9,

    /// <summary>
    /// 藏族
    /// </summary>
    [Description("藏族")]
    TIBETAN = 10,

    /// <summary>
    /// 布依族
    /// </summary>
    [Description("布依族")]
    BUYEI = 11,

    /// <summary>
    /// 侗族
    /// </summary>
    [Description("侗族")]
    DONG = 12,

    /// <summary>
    /// 瑶族
    /// </summary>
    [Description("瑶族")]
    YAO = 13,

    /// <summary>
    /// 朝鲜族
    /// </summary>
    [Description("朝鲜族")]
    KOREAN = 14,

    /// <summary>
    /// 白族
    /// </summary>
    [Description("白族")]
    BAI = 15,

    /// <summary>
    /// 哈尼族
    /// </summary>
    [Description("哈尼族")]
    HANI = 16,

    /// <summary>
    /// 黎族
    /// </summary>
    [Description("黎族")]
    LI = 17,

    /// <summary>
    /// 哈萨克族
    /// </summary>
    [Description("哈萨克族")]
    KAZAK = 18,

    /// <summary>
    /// 傣族
    /// </summary>
    [Description("傣族")]
    DAI = 19,

    /// <summary>
    /// 畲族
    /// </summary>
    [Description("畲族")]
    SHE = 20,

    /// <summary>
    /// 僳僳族
    /// </summary>
    [Description("僳僳族")]
    LISU = 21,

    /// <summary>
    /// 仡佬族
    /// </summary>
    [Description("仡佬族")]
    GELAO = 22,

    /// <summary>
    /// 拉祜族
    /// </summary>
    [Description("拉祜族")]
    LAHU = 23,

    /// <summary>
    /// 东乡族
    /// </summary>
    [Description("东乡族")]
    DONGXIANG = 24,

    /// <summary>
    /// 佤族
    /// </summary>
    [Description("佤族")]
    VA = 25,

    /// <summary>
    /// 水族
    /// </summary>
    [Description("水族")]
    SUI = 26,

    /// <summary>
    /// 纳西族
    /// </summary>
    [Description("纳西族")]
    NAXI = 27,

    /// <summary>
    /// 羌族
    /// </summary>
    [Description("羌族")]
    QIANG = 28,

    /// <summary>
    /// 土族
    /// </summary>
    [Description("土族")]
    TU = 29,

    /// <summary>
    /// 锡伯族
    /// </summary>
    [Description("锡伯族")]
    XIBE = 30,

    /// <summary>
    /// 仫佬族
    /// </summary>
    [Description("仫佬族")]
    MULAO = 31,

    /// <summary>
    /// 柯尔克孜族
    /// </summary>
    [Description("柯尔克孜族")]
    KIRGIZ = 32,

    /// <summary>
    /// 达斡尔族
    /// </summary>
    [Description("达斡尔族")]
    DAUR = 33,

    /// <summary>
    /// 景颇族
    /// </summary>
    [Description("景颇族")]
    JINGPO = 34,

    /// <summary>
    /// 撒拉族
    /// </summary>
    [Description("撒拉族")]
    SALAR = 35,

    /// <summary>
    /// 布朗族
    /// </summary>
    [Description("布朗族")]
    BLANG = 36,

    /// <summary>
    /// 毛南族
    /// </summary>
    [Description("毛南族")]
    MAONAN = 37,

    /// <summary>
    /// 塔吉克族
    /// </summary>
    [Description("塔吉克族")]
    TAJIK = 38,

    /// <summary>
    /// 普米族
    /// </summary>
    [Description("普米族")]
    PUMI = 39,

    /// <summary>
    /// 阿昌族
    /// </summary>
    [Description("阿昌族")]
    ACHANG = 40,

    /// <summary>
    /// 怒族
    /// </summary>
    [Description("怒族")]
    NU = 41,

    /// <summary>
    /// 鄂温克族
    /// </summary>
    [Description("鄂温克族")]
    EWENKI = 42,

    /// <summary>
    /// 京族
    /// </summary>
    [Description("京族")]
    GIN = 43,

    /// <summary>
    /// 基诺族
    /// </summary>
    [Description("基诺族")]
    JINO = 44,

    /// <summary>
    /// 德昂族
    /// </summary>
    [Description("德昂族")]
    DEANG = 45,

    /// <summary>
    /// 乌孜别克族
    /// </summary>
    [Description("乌孜别克族")]
    UZBEK = 46,

    /// <summary>
    /// 俄罗斯族
    /// </summary>
    [Description("俄罗斯族")]
    RUSSIANS = 47,

    /// <summary>
    /// 裕固族
    /// </summary>
    [Description("裕固族")]
    YUGUR = 48,

    /// <summary>
    /// 保安族
    /// </summary>
    [Description("保安族")]
    BONAN = 49,

    /// <summary>
    /// 门巴族
    /// </summary>
    [Description("门巴族")]
    MONBA = 50,

    /// <summary>
    /// 鄂伦春族
    /// </summary>
    [Description("鄂伦春族")]
    OROQEN = 51,

    /// <summary>
    /// 独龙族
    /// </summary>
    [Description("独龙族")]
    DERUNG = 52,

    /// <summary>
    /// 塔塔尔族
    /// </summary>
    [Description("塔塔尔族")]
    TATAR = 53,

    /// <summary>
    /// 赫哲族
    /// </summary>
    [Description("赫哲族")]
    HEZHEN = 54,

    /// <summary>
    /// 珞巴族
    /// </summary>
    [Description("珞巴族")]
    LHOBA = 55,

    /// <summary>
    /// 高山族
    /// </summary>
    [Description("高山族")]
    GAOSHAN = 56,
}
