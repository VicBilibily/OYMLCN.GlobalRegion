using System;

namespace OYMLCN.GlobalRegion
{
    // https://baike.baidu.com/item/联合国地理区划列表/20416123#5
    public enum M49
    {
        World世界 = 001,

        Africa非洲 = 002,
        EasternAfrica东部非洲 = 014,
        MiddleAfrica中部非洲 = 017,
        NorthernAfrica北部非洲 = 015,
        SouthernAfrica南部非洲 = 018,
        WesternAfrica西部非洲 = 011,

        Americas美洲 = 019,
        Caribbean加勒比地区 = 029,
        CentralAmerica中美洲 = 013,
        SouthAmerica南美洲 = 005,
        NorthernAmerica北美地区 = 021,

        Asia亚洲 = 142,
        CentralAsia中亚 = 143,
        EasternAsia东亚 = 030,
        SouthernAsia南亚 = 034,
        SouthEasternAsia东南亚 = 035,
        WesternAsia西亚 = 145,

        Europe欧洲 = 150,
        EasternEurope东欧 = 151,
        NorthernEurope北欧 = 154,
        SouthernEurope南欧 = 039,
        WesternEurope西欧 = 155,

        Oceania大洋洲 = 009,
        AustraliaAndNewZealand澳大利亚和新西兰 = 053,
        Melanesia美拉尼西亚 = 054,
        Micronesia密克罗尼西亚 = 057,
        Polynesia波利尼西亚 = 061,

        // EasternAfrica东部非洲
        Burundi布隆迪 = 108,
        Comoros科摩罗 = 174,
        Djibouti吉布提 = 262,
        Eritrea厄立特里亚 = 232,
        Ethiopia埃塞俄比亚 = 231,
        Kenya肯尼亚 = 404,
        Madagascar马达加斯加 = 450,
        Malawi马拉维 = 454,
        Mauritius毛里求斯 = 480,
        Mayotte马约特 = 175,
        Mozambique莫桑比克 = 508,
        Reunion留尼汪 = 638,
        Rwanda卢旺达 = 646,
        Seychelles塞舌尔 = 690,
        Somalia索马里 = 706,
        SouthSudan南苏丹 = 728,
        Uganda乌干达 = 800,
        UnitedRepublicOfTanzania坦桑尼亚联合共和国 = 834,
        Zambia赞比亚 = 894,
        Zimbabwe津巴布韦 = 716,

        // MiddleAfrica中部非洲
        Angola安哥拉 = 024,
        Cameroon喀麦隆 = 120,
        CentralAfricanRepublic中非共和国 = 140,
        Chad乍得 = 148,
        Congo刚果 = 178,
        DemocraticRepublicOfTheCongo刚果民主共和国 = 180,
        EquatorialGuinea赤道几内亚 = 226,
        Gabon加蓬 = 266,
        SaoTomeandPrincipe圣多美和普林西比 = 678,

        // NorthernAfrica北部非洲
        Algeria阿尔及利亚 = 012,
        Egypt埃及 = 818,
        Libya利比亚 = 434,
        Morocco摩洛哥 = 504,
        Sudan苏丹 = 729,
        Tunisia突尼斯 = 788,
        WesternSahara西撒哈拉 = 732,

        // SouthernAfrica南部非洲
        Botswana博茨瓦纳 = 072,
        Lesotho莱索托 = 426,
        Namibia纳米比亚 = 516,
        SouthAfrica南非 = 710,
        Swaziland斯威士兰 = 748,

        // WesternAfrica西部非洲
        Benin贝宁 = 204,
        BurkinaFaso布基纳法索 = 854,
        CaboVerde佛得角 = 132,
        CotedIvoire科特迪瓦 = 384,
        Gambia冈比亚 = 270,
        Ghana加纳 = 288,
        Guinea几内亚 = 324,
        GuineaBissau几内亚比绍 = 624,
        Liberia利比里亚 = 430,
        Mali马里 = 466,
        Mauritania毛里塔尼亚 = 478,
        Niger尼日尔 = 562,
        Nigeria尼日利亚 = 566,
        SaintHelena圣赫勒拿 = 654,
        Senegal塞内加尔 = 686,
        SierraLeone塞拉利昂 = 694,
        Togo多哥 = 768,

        // Caribbean加勒比地区
        Anguilla安圭拉 = 660,
        AntiguaandBarbuda安提瓜和巴布达 = 028,
        Aruba阿鲁巴 = 533,
        Bahamas巴哈马 = 044,
        Barbados巴巴多斯 = 052,
        BonaireSaintEustatiusAndSaba博奈尔圣尤斯特歇斯和萨巴 = 535,
        BritishVirginIslands英属维尔京群岛 = 92,
        CaymanIslands开曼群岛 = 136,
        Cuba古巴 = 192,
        Curaçao库拉索 = 531,
        Dominica多米尼克 = 212,
        DominicanRepublic多米尼加共和国 = 214,
        Grenada格林纳达 = 308,
        Guadeloupe瓜德罗普 = 312,
        Haiti海地 = 332,
        Jamaica牙买加 = 388,
        Martinique马提尼克 = 474,
        Montserrat蒙特塞拉特 = 500,
        PuertoRico波多黎各 = 630,
        SaintBarts圣巴泰勒米 = 652,
        SaintKittsandNevis圣基茨和尼维斯 = 659,
        SaintLucia圣卢西亚 = 662,
        SaintMartin圣马丁法属部分 = 663,
        SaintVincentandtheGrenadines圣文森特和格林纳丁斯 = 670,
        SintMaarten圣马丁荷属部分 = 534,
        TrinidadandTobago特立尼达和多巴哥 = 780,
        TurksandCaicosIslands特克斯和凯科斯群岛 = 796,
        UnitedStatesVirginIslands美属维尔京群岛 = 850,

        // CentralAmerica中美洲
        Belize伯利兹 = 084,
        CostaRica哥斯达黎加 = 188,
        ElSalvador萨尔瓦多 = 222,
        Guatemala危地马拉 = 320,
        Honduras洪都拉斯 = 340,
        Mexico墨西哥 = 484,
        Nicaragua尼加拉瓜 = 558,
        Panama巴拿马 = 591,

        // SouthAmerica南美洲
        Argentina阿根廷 = 032,
        PlurinationalStateOfBolivia多民族玻利维亚国 = 068,
        Brazil巴西 = 076,
        Chile智利 = 152,
        Colombia哥伦比亚 = 170,
        Ecuador厄瓜多尔 = 218,
        FalklandIslandsMalvinas福克兰群岛马尔维纳斯群岛 = 238,
        FrenchGuiana法属圭亚那 = 254,
        Guyana圭亚那 = 328,
        Paraguay巴拉圭 = 600,
        Peru秘鲁 = 604,
        Suriname苏里南 = 740,
        Uruguay乌拉圭 = 858,
        BolivarianRepublicOfVenezuela委内瑞拉玻利瓦尔共和国 = 862,

        // NorthernAmerica北美地区
        Bermuda百慕大 = 060,
        Canada加拿大 = 124,
        Greenland格陵兰 = 304,
        SaintPierreandMiquelon圣皮埃尔和密克隆 = 666,
        UnitedStatesOfAmerica美利坚合众国 = 840,

        // CentralAsia中亚
        Kazakhstan哈萨克斯坦 = 398,
        Kyrgyzstan吉尔吉斯斯坦 = 417,
        Tajikistan塔吉克斯坦 = 762,
        Turkmenistan土库曼斯坦 = 795,
        Uzbekistan乌兹别克斯坦 = 860,

        // EasternAsia东亚
        China中国 = 156,
        ChinaHongKongSpecialAdministrativeRegion中国香港特别行政区 = 344,
        ChinaMacaoSpecialAdministrativeRegion中国澳门特别行政区 = 446,
        DemocraticPeoplesRepublicOfKorea朝鲜民主主义人民共和国 = 408,
        Japan日本 = 392,
        Mongolia蒙古 = 496,
        RepublicOfKorea大韩民国 = 410,

        // SouthernAsia南亚
        Afghanistan阿富汗 = 004,
        Bangladesh孟加拉国 = 50,
        Bhutan不丹 = 064,
        India印度 = 356,
        IslamicRepublicOfIran伊朗伊斯兰共和国 = 364,
        Maldives马尔代夫 = 462,
        Nepal尼泊尔 = 524,
        Pakistan巴基斯坦 = 586,
        SriLanka斯里兰卡 = 144,

        // SouthEasternAsia东南亚
        BruneiDarussalam文莱达鲁萨兰国 = 096,
        Cambodia柬埔寨 = 116,
        Indonesia印度尼西亚 = 360,
        LaoPeoplesDemocraticRepublic老挝人民民主共和国 = 418,
        Malaysia马来西亚 = 458,
        Myanmar缅甸 = 104,
        Philippines菲律宾 = 608,
        Singapore新加坡 = 702,
        Thailand泰国 = 764,
        TimorLeste东帝汶 = 626,
        VietNam越南 = 704,

        // WesternAsia西亚
        Armenia亚美尼亚 = 051,
        Azerbaijan阿塞拜疆 = 031,
        Bahrain巴林 = 048,
        Cyprus塞浦路斯 = 196,
        Georgia格鲁吉亚 = 268,
        Iraq伊拉克 = 368,
        Israel以色列 = 376,
        Jordan约旦 = 400,
        Kuwait科威特 = 414,
        Lebanon黎巴嫩 = 422,
        Oman阿曼 = 512,
        Qatar卡塔尔 = 634,
        SaudiArabia沙特阿拉伯 = 682,
        StateOfPalestine巴勒斯坦国 = 275,
        SyrianArabRepublic阿拉伯叙利亚共和国 = 760,
        Turkey土耳其 = 792,
        UnitedArabEmirates阿拉伯联合酋长国 = 784,
        Yemen也门 = 887,

        // EasternEurope东欧
        Belarus白俄罗斯 = 112,
        Bulgaria保加利亚 = 100,
        CzechRepublic捷克共和国 = 203,
        Hungary匈牙利 = 348,
        Poland波兰 = 616,
        RepublicOfMoldova摩尔多瓦共和国 = 498,
        Romania罗马尼亚 = 642,
        RussianFederation俄罗斯联邦 = 643,
        Slovakia斯洛伐克 = 703,
        Ukraine乌克兰 = 804,

        // NorthernEurope北欧
        AlandIslands奥兰群岛 = 248,
        ChannelIslands海峡群岛盎格鲁诺曼底群岛 = 830,
        Denmark丹麦 = 208,
        Estonia爱沙尼亚 = 233,
        FaeroeIslands法罗群岛 = 234,
        Finland芬兰 = 246,
        Guernsey根西 = 831,
        Iceland冰岛 = 352,
        Ireland爱尔兰 = 372,
        IsleofMan马恩岛 = 833,
        Jersey泽西 = 832,
        Latvia拉托维亚 = 428,
        Lithuania立陶宛 = 440,
        Norway挪威 = 578,
        Sark萨克 = 680,
        SvalbardandJanMayenIslands斯瓦尔巴群岛和扬马延岛 = 744,
        Sweden瑞典 = 752,
        UnitedKingdomOfGreatBritainandNorthernIreland大不列颠及北爱尔兰联合王国 = 826,

        // SouthernEurope南欧
        Albania阿尔巴尼亚 = 008,
        Andorra安道尔 = 020,
        BosniaandHerzegovina波斯尼亚和黑塞哥维那 = 070,
        Croatia克罗地亚 = 191,
        Gibraltar直布罗陀 = 292,
        Greece希腊 = 300,
        HolySee圣座 = 336,
        Italy意大利 = 380,
        Malta马耳他 = 470,
        Montenegro黑山 = 499,
        Portugal葡萄牙 = 620,
        SanMarino圣马力诺 = 674,
        Serbia塞尔维亚 = 688,
        Slovenia斯洛文尼亚 = 705,
        Spain西班牙 = 724,
        TheformerYugoslavRepublicOfMacedonia前南斯拉夫马其顿共和国 = 807,

        // WesternEurope西欧
        Austria奥地利 = 040,
        Belgium比利时 = 056,
        France法国 = 250,
        Germany德国 = 276,
        Liechtenstein列支敦士登 = 438,
        Luxembourg卢森堡 = 442,
        Monaco摩纳哥 = 492,
        Netherlands荷兰 = 528,
        Switzerland瑞士 = 756,

        // AustraliaAndNewZealand澳大利亚和新西兰
        Australia澳大利亚 = 036,
        NewZealand新西兰 = 554,
        NorfolkIsland诺福克岛 = 574,

        // Melanesia美拉尼西亚
        Fiji斐济 = 242,
        NewCaledonia新喀里多尼亚 = 540,
        PapuaNewGuinea巴布亚新几内亚 = 598,
        SolomonIslands所罗门群岛 = 090,
        Vanuatu瓦努阿图 = 548,

        // Micronesia密克罗尼西亚
        Guam关岛 = 316,
        Kiribati基里巴斯 = 296,
        MarshallIslands马绍尔群岛 = 584,
        FederatedStatesOfMicronesia密克罗尼西亚联邦 = 583,
        Nauru瑙鲁 = 520,
        NorthernMarianaIslands北马里亚纳群岛 = 580,
        Palau帕劳 = 585,

        // Polynesia波利尼西亚
        AmericanSamoa美属萨摩亚 = 016,
        CookIslands库克群岛 = 184,
        FrenchPolynesia法属波利尼西亚 = 258,
        Niue纽埃 = 570,
        Pitcairn皮特凯恩 = 612,
        Samoa萨摩亚 = 882,
        Tokelau托克劳 = 772,
        Tonga汤加 = 776,
        Tuvalu图瓦卢 = 798,
        WallisandFutunaIslands瓦利斯和富图纳群岛 = 876,

    }
}