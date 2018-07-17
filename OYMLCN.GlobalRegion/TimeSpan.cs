using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OYMLCN.GlobalRegion
{
    public static class Extensions
    {
        /// <summary>
        /// 计算当前时间对应国家首都的时间
        /// </summary>
        /// <param name="dateTimeNow"></param>
        /// <param name="country"></param>
        /// <returns></returns>
        public static DateTime GetCountryTime(this DateTime dateTimeNow, M49 country)
        {
            return dateTimeNow.ToUniversalTime().Add(TimeSpan.FromHours(GetCountryUTCTimeDifference(country)));
        }
        /// <summary>
        /// 获取当前国家与世界协调时(UTC)相差的小时差
        /// 大洲及分类无具体定义，按默认UTC+0输出
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public static double GetCountryUTCTimeDifference(M49 country)
        {
            switch (country)
            {
                // UTC/GMT -11小时 (西十一区)
                case M49.AmericanSamoa美属萨摩亚:
                case M49.Niue纽埃:
                    return -11;
                // UTC/GMT -10小时 (西十区)
                case M49.CookIslands库克群岛:
                case M49.FrenchPolynesia法属波利尼西亚:
                    return -10;
                // UTC/GMT -8小时 (西八区)
                case M49.Pitcairn皮特凯恩:
                    return -10;
                // UTC/GMT -6小时 (西六区)
                case M49.Belize伯利兹:
                case M49.CostaRica哥斯达黎加:
                case M49.ElSalvador萨尔瓦多:
                case M49.Guatemala危地马拉:
                case M49.Honduras洪都拉斯:
                case M49.Mexico墨西哥:
                case M49.Nicaragua尼加拉瓜:
                    return -6;
                // UTC/GMT -5小时 (西五区)
                case M49.CaymanIslands开曼群岛:
                case M49.Cuba古巴:
                case M49.Haiti海地:
                case M49.Jamaica牙买加:
                case M49.TurksandCaicosIslands特克斯和凯科斯群岛:
                case M49.Panama巴拿马:
                case M49.Colombia哥伦比亚:
                case M49.Ecuador厄瓜多尔:
                case M49.Peru秘鲁:
                case M49.Canada加拿大:
                case M49.UnitedStatesOfAmerica美利坚合众国:
                    return -5;
                // UTC/GMT -4小时 (西四区)
                case M49.Anguilla安圭拉:
                case M49.AntiguaandBarbuda安提瓜和巴布达:
                case M49.Aruba阿鲁巴:
                case M49.Bahamas巴哈马:
                case M49.Barbados巴巴多斯:
                case M49.BonaireSaintEustatiusAndSaba博奈尔圣尤斯特歇斯和萨巴:
                case M49.BritishVirginIslands英属维尔京群岛:
                case M49.Curaçao库拉索:
                case M49.Dominica多米尼克:
                case M49.DominicanRepublic多米尼加共和国:
                case M49.Grenada格林纳达:
                case M49.Guadeloupe瓜德罗普:
                case M49.Martinique马提尼克:
                case M49.Montserrat蒙特塞拉特:
                case M49.PuertoRico波多黎各:
                case M49.SaintBarts圣巴泰勒米:
                case M49.SaintKittsandNevis圣基茨和尼维斯:
                case M49.SaintLucia圣卢西亚:
                case M49.SaintMartin圣马丁法属部分:
                case M49.SaintVincentandtheGrenadines圣文森特和格林纳丁斯:
                case M49.SintMaarten圣马丁荷属部分:
                case M49.TrinidadandTobago特立尼达和多巴哥:
                case M49.UnitedStatesVirginIslands美属维尔京群岛:
                case M49.PlurinationalStateOfBolivia多民族玻利维亚国:
                case M49.Chile智利:
                case M49.Guyana圭亚那:
                case M49.Paraguay巴拉圭:
                case M49.BolivarianRepublicOfVenezuela委内瑞拉玻利瓦尔共和国:
                case M49.Bermuda百慕大:
                    return -4;
                // UTC/GMT -3小时 (西三区)
                case M49.Argentina阿根廷:
                case M49.Brazil巴西:
                case M49.FalklandIslandsMalvinas福克兰群岛马尔维纳斯群岛:
                case M49.FrenchGuiana法属圭亚那:
                case M49.Suriname苏里南:
                case M49.Uruguay乌拉圭:
                case M49.Greenland格陵兰:
                case M49.SaintPierreandMiquelon圣皮埃尔和密克隆:
                    return -3;
                // UTC/GMT -1小时 (西一区)
                case M49.CaboVerde佛得角:
                    return -1;
                // UTC/GMT 0小时 (零时区)
                case M49.Morocco摩洛哥:
                case M49.WesternSahara西撒哈拉:
                case M49.BurkinaFaso布基纳法索:
                case M49.CotedIvoire科特迪瓦:
                case M49.Gambia冈比亚:
                case M49.Ghana加纳:
                case M49.Guinea几内亚:
                case M49.GuineaBissau几内亚比绍:
                case M49.Liberia利比里亚:
                case M49.Mali马里:
                case M49.Mauritania毛里塔尼亚:
                case M49.SaintHelena圣赫勒拿:
                case M49.Senegal塞内加尔:
                case M49.SierraLeone塞拉利昂:
                case M49.Togo多哥:
                case M49.ChannelIslands海峡群岛盎格鲁诺曼底群岛:
                case M49.FaeroeIslands法罗群岛:
                case M49.Guernsey根西:
                case M49.Iceland冰岛:
                case M49.IsleofMan马恩岛:
                case M49.Jersey泽西:
                case M49.Sark萨克:
                case M49.UnitedKingdomOfGreatBritainandNorthernIreland大不列颠及北爱尔兰联合王国:
                case M49.Portugal葡萄牙:
                    return 0;
                // UTC/GMT +1小时 (东一区)
                case M49.Angola安哥拉:
                case M49.Cameroon喀麦隆:
                case M49.CentralAfricanRepublic中非共和国:
                case M49.Chad乍得:
                case M49.Congo刚果:
                case M49.RDCongo刚果民主共和国:
                case M49.EquatorialGuinea赤道几内亚:
                case M49.Gabon加蓬:
                case M49.SaoTomeandPrincipe圣多美和普林西比:
                case M49.Algeria阿尔及利亚:
                case M49.Tunisia突尼斯:
                case M49.Benin贝宁:
                case M49.Niger尼日尔:
                case M49.Nigeria尼日利亚:
                case M49.CzechRepublic捷克共和国:
                case M49.Hungary匈牙利:
                case M49.Poland波兰:
                case M49.Slovakia斯洛伐克:
                case M49.Denmark丹麦:
                case M49.Norway挪威:
                case M49.SvalbardandJanMayenIslands斯瓦尔巴群岛和扬马延岛:
                case M49.Sweden瑞典:
                case M49.Albania阿尔巴尼亚:
                case M49.Andorra安道尔:
                case M49.BosniaandHerzegovina波斯尼亚和黑塞哥维那:
                case M49.Croatia克罗地亚:
                case M49.Gibraltar直布罗陀:
                case M49.HolySee圣座:
                case M49.Italy意大利:
                case M49.Malta马耳他:
                case M49.Montenegro黑山:
                case M49.SanMarino圣马力诺:
                case M49.Serbia塞尔维亚:
                case M49.Slovenia斯洛文尼亚:
                case M49.Spain西班牙:
                case M49.TheformerYugoslavRepublicOfMacedonia前南斯拉夫马其顿共和国:
                case M49.Austria奥地利:
                case M49.Belgium比利时:
                case M49.France法国:
                case M49.Germany德国:
                case M49.Liechtenstein列支敦士登:
                case M49.Luxembourg卢森堡:
                case M49.Monaco摩纳哥:
                case M49.Netherlands荷兰:
                case M49.Switzerland瑞士:
                    return 1;
                // UTC/GMT +2小时 (东二区)
                case M49.Burundi布隆迪:
                case M49.Malawi马拉维:
                case M49.Mozambique莫桑比克:
                case M49.Rwanda卢旺达:
                case M49.Zambia赞比亚:
                case M49.Zimbabwe津巴布韦:
                case M49.Egypt埃及:
                case M49.Libya利比亚:
                case M49.Sudan苏丹:
                case M49.Botswana博茨瓦纳:
                case M49.Lesotho莱索托:
                case M49.Namibia纳米比亚:
                case M49.SouthAfrica南非:
                case M49.Swaziland斯威士兰:
                case M49.Cyprus塞浦路斯:
                case M49.Israel以色列:
                case M49.Jordan约旦:
                case M49.Lebanon黎巴嫩:
                case M49.StateOfPalestine巴勒斯坦国:
                case M49.Bulgaria保加利亚:
                case M49.RepublicOfMoldova摩尔多瓦共和国:
                case M49.SyrianArabRepublic阿拉伯叙利亚共和国:
                case M49.Romania罗马尼亚:
                case M49.Ukraine乌克兰:
                case M49.AlandIslands奥兰群岛:
                case M49.Estonia爱沙尼亚:
                case M49.Finland芬兰:
                case M49.Latvia拉托维亚:
                case M49.Lithuania立陶宛:
                case M49.Greece希腊:
                    return 2;
                // UTC/GMT +3小时 (东三区)
                case M49.Comoros科摩罗:
                case M49.Djibouti吉布提:
                case M49.Eritrea厄立特里亚:
                case M49.Ethiopia埃塞俄比亚:
                case M49.Kenya肯尼亚:
                case M49.Madagascar马达加斯加:
                case M49.Mayotte马约特:
                case M49.Somalia索马里:
                case M49.SouthSudan南苏丹:
                case M49.Uganda乌干达:
                case M49.Tanzania坦桑尼亚:
                case M49.Bahrain巴林:
                case M49.Iraq伊拉克:
                case M49.Kuwait科威特:
                case M49.Qatar卡塔尔:
                case M49.SaudiArabia沙特阿拉伯:
                case M49.Turkey土耳其:
                case M49.Yemen也门:
                case M49.Belarus白俄罗斯:
                case M49.RussianFederation俄罗斯联邦:
                    return 3;
                // UTC/GMT +3.5小时
                case M49.IslamicRepublicOfIran伊朗伊斯兰共和国:
                    return 3.5;
                // UTC/GMT +4小时 (东四区)
                case M49.Mauritius毛里求斯:
                case M49.Reunion留尼汪:
                case M49.Seychelles塞舌尔:
                case M49.Armenia亚美尼亚:
                case M49.Azerbaijan阿塞拜疆:
                case M49.Georgia格鲁吉亚:
                case M49.Oman阿曼:
                case M49.UnitedArabEmirates阿拉伯联合酋长国:
                    return 4;
                // UTC/GMT +4.5小时
                case M49.Afghanistan阿富汗:
                    return 4.5;
                // UTC/GMT +5小时 (东五区)
                case M49.Tajikistan塔吉克斯坦:
                case M49.Turkmenistan土库曼斯坦:
                case M49.Uzbekistan乌兹别克斯坦:
                case M49.Maldives马尔代夫:
                case M49.Pakistan巴基斯坦:
                    return 5;
                // UTC/GMT +5.5小时
                case M49.India印度:
                case M49.SriLanka斯里兰卡:
                    return 5.5;
                // UTC/GMT +5小时45分
                case M49.Nepal尼泊尔:
                    return 5.75;
                // UTC/GMT +6小时 (东六区)
                case M49.Kazakhstan哈萨克斯坦:
                case M49.Kyrgyzstan吉尔吉斯斯坦:
                case M49.Bangladesh孟加拉国:
                case M49.Bhutan不丹:
                    return 6;
                // UTC/GMT +6.5小时
                case M49.Myanmar缅甸:
                    return 6.5;
                // UTC/GMT +7小时 (东七区)
                case M49.Cambodia柬埔寨:
                case M49.Indonesia印度尼西亚:
                case M49.LaoPeoplesDemocraticRepublic老挝人民民主共和国:
                case M49.Thailand泰国:
                case M49.VietNam越南:
                    return 7;
                // UTC/GMT +8小时 (东八区)
                case M49.China中国:
                case M49.ChinaHongKongSpecialAdministrativeRegion中国香港特别行政区:
                case M49.ChinaMacaoSpecialAdministrativeRegion中国澳门特别行政区:
                case M49.Mongolia蒙古:
                case M49.BruneiDarussalam文莱达鲁萨兰国:
                case M49.Malaysia马来西亚:
                case M49.Philippines菲律宾:
                case M49.Singapore新加坡:
                    return 8;
                // UTC/GMT +9小时 (东九区)
                case M49.Japan日本:
                case M49.DemocraticPeoplesRepublicOfKorea朝鲜民主主义人民共和国:
                case M49.RepublicOfKorea大韩民国:
                case M49.TimorLeste东帝汶:
                case M49.Palau帕劳:
                    return 9;
                // UTC/GMT +10小时 (东十区)
                case M49.Australia澳大利亚:
                case M49.PapuaNewGuinea巴布亚新几内亚:
                case M49.Guam关岛:
                case M49.NorthernMarianaIslands北马里亚纳群岛:
                    return 10;
                // UTC/GMT +11小时 (东十一区)
                case M49.NorfolkIsland诺福克岛:
                case M49.NewCaledonia新喀里多尼亚:
                case M49.SolomonIslands所罗门群岛:
                case M49.Vanuatu瓦努阿图:
                case M49.FederatedStatesOfMicronesia密克罗尼西亚联邦:
                    return 11;
                // UTC/GMT +12小时 (东十二区)
                case M49.NewZealand新西兰:
                case M49.Fiji斐济:
                case M49.Kiribati基里巴斯:
                case M49.MarshallIslands马绍尔群岛:
                case M49.Nauru瑙鲁:
                case M49.Tuvalu图瓦卢:
                case M49.WallisandFutunaIslands瓦利斯和富图纳群岛:
                    return 12;
                // UTC/GMT +13小时 (东十三区)
                case M49.Samoa萨摩亚:
                case M49.Tokelau托克劳:
                case M49.Tonga汤加:
                    return 13;
                default:
                    return 0;
            }
        }
        /// <summary>
        /// 获取当前国家的实时时间页面地址
        /// 大洲及分类无具体定义，默认返回跟地址
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public static string GetCountryTimeIsUrl(M49 country)
        {
            const string baseUrl = "https://time.is/";
            return $"{baseUrl}/{ Data.TimeIsKey.Where(d => d.Key == country).Select(d => d.Value).FirstOrDefault() }";
        }
    }

}
