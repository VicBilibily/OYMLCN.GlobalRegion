using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OYMLCN.GlobalRegion
{
    /// <summary>
    /// Extensions
    /// </summary>
    public static partial class Extensions
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
            return GlobalRegionData.M49CountryInfos.Where(d => d.Key == country).Select(d => d.Value.UTCTimeSpan.TotalHours).First();
            //switch (country)
            //{
            //    // UTC/GMT -11小时 (西十一区)
            //    case M49.AmericanSamoa美属萨摩亚:
            //    case M49.Niue纽埃:
            //        return -11;
            //    // UTC/GMT -10小时 (西十区)
            //    case M49.CookIslands库克群岛:
            //    case M49.FrenchPolynesia法属波利尼西亚:
            //        return -10;
            //    // UTC/GMT -8小时 (西八区)
            //    case M49.Pitcairn皮特凯恩:
            //        return -10;
            //    // UTC/GMT -6小时 (西六区)
            //    case M49.Belize伯利兹:
            //    case M49.CostaRica哥斯达黎加:
            //    case M49.ElSalvador萨尔瓦多:
            //    case M49.Guatemala危地马拉:
            //    case M49.Honduras洪都拉斯:
            //    case M49.Mexico墨西哥:
            //    case M49.Nicaragua尼加拉瓜:
            //        return -6;
            //    // UTC/GMT -5小时 (西五区)
            //    case M49.CaymanIslands开曼群岛:
            //    case M49.Cuba古巴:
            //    case M49.Haiti海地:
            //    case M49.Jamaica牙买加:
            //    case M49.TurksandCaicosIslands特克斯和凯科斯群岛:
            //    case M49.Panama巴拿马:
            //    case M49.Colombia哥伦比亚:
            //    case M49.Ecuador厄瓜多尔:
            //    case M49.Peru秘鲁:
            //    case M49.Canada加拿大:
            //    case M49.UnitedStatesOfAmerica美利坚合众国:
            //        return -5;
            //    // UTC/GMT -4小时 (西四区)
            //    case M49.Anguilla安圭拉:
            //    case M49.AntiguaandBarbuda安提瓜和巴布达:
            //    case M49.Aruba阿鲁巴:
            //    case M49.Bahamas巴哈马:
            //    case M49.Barbados巴巴多斯:
            //    case M49.BonaireSaintEustatiusAndSaba博奈尔圣尤斯特歇斯和萨巴:
            //    case M49.BritishVirginIslands英属维尔京群岛:
            //    case M49.Curaçao库拉索:
            //    case M49.Dominica多米尼克:
            //    case M49.DominicanRepublic多米尼加共和国:
            //    case M49.Grenada格林纳达:
            //    case M49.Guadeloupe瓜德罗普:
            //    case M49.Martinique马提尼克:
            //    case M49.Montserrat蒙特塞拉特:
            //    case M49.PuertoRico波多黎各:
            //    case M49.SaintBarts圣巴泰勒米:
            //    case M49.SaintKittsandNevis圣基茨和尼维斯:
            //    case M49.SaintLucia圣卢西亚:
            //    case M49.SaintMartin圣马丁法属部分:
            //    case M49.SaintVincentandtheGrenadines圣文森特和格林纳丁斯:
            //    case M49.SintMaarten圣马丁荷属部分:
            //    case M49.TrinidadandTobago特立尼达和多巴哥:
            //    case M49.UnitedStatesVirginIslands美属维尔京群岛:
            //    case M49.Bolivia玻利维亚:
            //    case M49.Chile智利:
            //    case M49.Guyana圭亚那:
            //    case M49.Paraguay巴拉圭:
            //    case M49.Venezuela委内瑞拉:
            //    case M49.Bermuda百慕大:
            //        return -4;
            //    // UTC/GMT -3小时 (西三区)
            //    case M49.Argentina阿根廷:
            //    case M49.Brazil巴西:
            //    case M49.FalklandIslandsMalvinas福克兰群岛马尔维纳斯群岛:
            //    case M49.FrenchGuiana法属圭亚那:
            //    case M49.Suriname苏里南:
            //    case M49.Uruguay乌拉圭:
            //    case M49.Greenland格陵兰:
            //    case M49.SaintPierreandMiquelon圣皮埃尔和密克隆:
            //        return -3;
            //    // UTC/GMT -1小时 (西一区)
            //    case M49.CaboVerde佛得角:
            //        return -1;
            //    // UTC/GMT 0小时 (零时区)
            //    case M49.Morocco摩洛哥:
            //    case M49.WesternSahara西撒哈拉:
            //    case M49.BurkinaFaso布基纳法索:
            //    case M49.CotedIvoire科特迪瓦:
            //    case M49.Gambia冈比亚:
            //    case M49.Ghana加纳:
            //    case M49.Guinea几内亚:
            //    case M49.GuineaBissau几内亚比绍:
            //    case M49.Liberia利比里亚:
            //    case M49.Mali马里:
            //    case M49.Mauritania毛里塔尼亚:
            //    case M49.SaintHelena圣赫勒拿:
            //    case M49.Senegal塞内加尔:
            //    case M49.SierraLeone塞拉利昂:
            //    case M49.Togo多哥:
            //    case M49.ChannelIslands海峡群岛:
            //    case M49.FaeroeIslands法罗群岛:
            //    case M49.Guernsey根西:
            //    case M49.Iceland冰岛:
            //    case M49.IsleofMan马恩岛:
            //    case M49.Jersey泽西:
            //    case M49.Sark萨克:
            //    case M49.UK英国:
            //    case M49.Portugal葡萄牙:
            //        return 0;
            //    // UTC/GMT +1小时 (东一区)
            //    case M49.Angola安哥拉:
            //    case M49.Cameroon喀麦隆:
            //    case M49.CentralAfricanRepublic中非共和国:
            //    case M49.Chad乍得:
            //    case M49.Congo刚果:
            //    case M49.RDCongo刚果民主共和国:
            //    case M49.EquatorialGuinea赤道几内亚:
            //    case M49.Gabon加蓬:
            //    case M49.SaoTomeandPrincipe圣多美和普林西比:
            //    case M49.Algeria阿尔及利亚:
            //    case M49.Tunisia突尼斯:
            //    case M49.Benin贝宁:
            //    case M49.Niger尼日尔:
            //    case M49.Nigeria尼日利亚:
            //    case M49.Czech捷克:
            //    case M49.Hungary匈牙利:
            //    case M49.Poland波兰:
            //    case M49.Slovakia斯洛伐克:
            //    case M49.Denmark丹麦:
            //    case M49.Norway挪威:
            //    case M49.SvalbardandJanMayenIslands斯瓦尔巴群岛和扬马延岛:
            //    case M49.Sweden瑞典:
            //    case M49.Albania阿尔巴尼亚:
            //    case M49.Andorra安道尔:
            //    case M49.BosniaandHerzegovina波斯尼亚和黑塞哥维那:
            //    case M49.Croatia克罗地亚:
            //    case M49.Gibraltar直布罗陀:
            //    case M49.HolySee圣座:
            //    case M49.Italy意大利:
            //    case M49.Malta马耳他:
            //    case M49.Montenegro黑山:
            //    case M49.SanMarino圣马力诺:
            //    case M49.Serbia塞尔维亚:
            //    case M49.Slovenia斯洛文尼亚:
            //    case M49.Spain西班牙:
            //    case M49.Macedonia马其顿:
            //    case M49.Austria奥地利:
            //    case M49.Belgium比利时:
            //    case M49.France法国:
            //    case M49.Germany德国:
            //    case M49.Liechtenstein列支敦士登:
            //    case M49.Luxembourg卢森堡:
            //    case M49.Monaco摩纳哥:
            //    case M49.Netherlands荷兰:
            //    case M49.Switzerland瑞士:
            //        return 1;
            //    // UTC/GMT +2小时 (东二区)
            //    case M49.Burundi布隆迪:
            //    case M49.Malawi马拉维:
            //    case M49.Mozambique莫桑比克:
            //    case M49.Rwanda卢旺达:
            //    case M49.Zambia赞比亚:
            //    case M49.Zimbabwe津巴布韦:
            //    case M49.Egypt埃及:
            //    case M49.Libya利比亚:
            //    case M49.Sudan苏丹:
            //    case M49.Botswana博茨瓦纳:
            //    case M49.Lesotho莱索托:
            //    case M49.Namibia纳米比亚:
            //    case M49.SouthAfrica南非:
            //    case M49.Swaziland斯威士兰:
            //    case M49.Cyprus塞浦路斯:
            //    case M49.Israel以色列:
            //    case M49.Jordan约旦:
            //    case M49.Lebanon黎巴嫩:
            //    case M49.Palestine巴勒斯坦:
            //    case M49.Bulgaria保加利亚:
            //    case M49.Moldova摩尔多瓦:
            //    case M49.Syrian叙利亚:
            //    case M49.Romania罗马尼亚:
            //    case M49.Ukraine乌克兰:
            //    case M49.AlandIslands奥兰群岛:
            //    case M49.Estonia爱沙尼亚:
            //    case M49.Finland芬兰:
            //    case M49.Latvia拉托维亚:
            //    case M49.Lithuania立陶宛:
            //    case M49.Greece希腊:
            //        return 2;
            //    // UTC/GMT +3小时 (东三区)
            //    case M49.Comoros科摩罗:
            //    case M49.Djibouti吉布提:
            //    case M49.Eritrea厄立特里亚:
            //    case M49.Ethiopia埃塞俄比亚:
            //    case M49.Kenya肯尼亚:
            //    case M49.Madagascar马达加斯加:
            //    case M49.Mayotte马约特:
            //    case M49.Somalia索马里:
            //    case M49.SouthSudan南苏丹:
            //    case M49.Uganda乌干达:
            //    case M49.Tanzania坦桑尼亚:
            //    case M49.Bahrain巴林:
            //    case M49.Iraq伊拉克:
            //    case M49.Kuwait科威特:
            //    case M49.Qatar卡塔尔:
            //    case M49.SaudiArabia沙特阿拉伯:
            //    case M49.Turkey土耳其:
            //    case M49.Yemen也门:
            //    case M49.Belarus白俄罗斯:
            //    case M49.Russia俄罗斯:
            //        return 3;
            //    // UTC/GMT +3.5小时
            //    case M49.Iran伊朗:
            //        return 3.5;
            //    // UTC/GMT +4小时 (东四区)
            //    case M49.Mauritius毛里求斯:
            //    case M49.Reunion留尼汪:
            //    case M49.Seychelles塞舌尔:
            //    case M49.Armenia亚美尼亚:
            //    case M49.Azerbaijan阿塞拜疆:
            //    case M49.Georgia格鲁吉亚:
            //    case M49.Oman阿曼:
            //    case M49.UAE阿联酋:
            //        return 4;
            //    // UTC/GMT +4.5小时
            //    case M49.Afghanistan阿富汗:
            //        return 4.5;
            //    // UTC/GMT +5小时 (东五区)
            //    case M49.Tajikistan塔吉克斯坦:
            //    case M49.Turkmenistan土库曼斯坦:
            //    case M49.Uzbekistan乌兹别克斯坦:
            //    case M49.Maldives马尔代夫:
            //    case M49.Pakistan巴基斯坦:
            //        return 5;
            //    // UTC/GMT +5.5小时
            //    case M49.India印度:
            //    case M49.SriLanka斯里兰卡:
            //        return 5.5;
            //    // UTC/GMT +5小时45分
            //    case M49.Nepal尼泊尔:
            //        return 5.75;
            //    // UTC/GMT +6小时 (东六区)
            //    case M49.Kazakhstan哈萨克斯坦:
            //    case M49.Kyrgyzstan吉尔吉斯斯坦:
            //    case M49.Bangladesh孟加拉国:
            //    case M49.Bhutan不丹:
            //        return 6;
            //    // UTC/GMT +6.5小时
            //    case M49.Myanmar缅甸:
            //        return 6.5;
            //    // UTC/GMT +7小时 (东七区)
            //    case M49.Cambodia柬埔寨:
            //    case M49.Indonesia印度尼西亚:
            //    case M49.Laos老挝:
            //    case M49.Thailand泰国:
            //    case M49.VietNam越南:
            //        return 7;
            //    // UTC/GMT +8小时 (东八区)
            //    case M49.China中国:
            //    case M49.HongKong香港:
            //    case M49.Macao澳门:
            //    case M49.Mongolia蒙古:
            //    case M49.Brunei文莱:
            //    case M49.Malaysia马来西亚:
            //    case M49.Philippines菲律宾:
            //    case M49.Singapore新加坡:
            //        return 8;
            //    // UTC/GMT +9小时 (东九区)
            //    case M49.Japan日本:
            //    case M49.KoreaDPR朝鲜:
            //    case M49.Korea韩国:
            //    case M49.TimorLeste东帝汶:
            //    case M49.Palau帕劳:
            //        return 9;
            //    // UTC/GMT +10小时 (东十区)
            //    case M49.Australia澳大利亚:
            //    case M49.PapuaNewGuinea巴布亚新几内亚:
            //    case M49.Guam关岛:
            //    case M49.NorthernMarianaIslands北马里亚纳群岛:
            //        return 10;
            //    // UTC/GMT +11小时 (东十一区)
            //    case M49.NorfolkIsland诺福克岛:
            //    case M49.NewCaledonia新喀里多尼亚:
            //    case M49.SolomonIslands所罗门群岛:
            //    case M49.Vanuatu瓦努阿图:
            //    case M49.Micronesia密克罗尼西亚联邦:
            //        return 11;
            //    // UTC/GMT +12小时 (东十二区)
            //    case M49.NewZealand新西兰:
            //    case M49.Fiji斐济:
            //    case M49.Kiribati基里巴斯:
            //    case M49.MarshallIslands马绍尔群岛:
            //    case M49.Nauru瑙鲁:
            //    case M49.Tuvalu图瓦卢:
            //    case M49.WallisandFutunaIslands瓦利斯和富图纳群岛:
            //        return 12;
            //    // UTC/GMT +13小时 (东十三区)
            //    case M49.Samoa萨摩亚:
            //    case M49.Tokelau托克劳:
            //    case M49.Tonga汤加:
            //        return 13;
            //    default:
            //        return 0;
            //}
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
            return $"{baseUrl}/{ GlobalRegionData.TimeIsKey.Where(d => d.Key == country).Select(d => d.Value).FirstOrDefault() }";
        }
    }

    /// <summary>
    /// GlobalRegionData
    /// </summary>
    public static partial class GlobalRegionData
    {
        /// <summary>
        /// Tims.Is 查询对应值
        /// </summary>
        public static IReadOnlyDictionary<M49, string> TimeIsKey = new Dictionary<M49, string>() {
            // EasternAfrica东部非洲
            { M49.Burundi布隆迪 , "Burundi" },
            { M49.Comoros科摩罗 , "Comoros" },
            { M49.Djibouti吉布提 , "Djibouti" },
            { M49.Eritrea厄立特里亚 , "Eritrea" },
            { M49.Ethiopia埃塞俄比亚 , "Ethiopia" },//5
            { M49.Kenya肯尼亚 , "Kenya" },
            { M49.Madagascar马达加斯加 , "Madagascar" },
            { M49.Malawi马拉维 , "Malawi" },
            { M49.Mauritius毛里求斯 , "Mauritius" },
            { M49.Mayotte马约特 , "Mayotte" },//10
            { M49.Mozambique莫桑比克 , "Mozambique" },
            { M49.Reunion留尼汪 , "Réunion" },
            { M49.Rwanda卢旺达 , "Rwanda" },
            { M49.Seychelles塞舌尔 , "Seychelles" },
            { M49.Somalia索马里 , "Somalia" },//15
            { M49.SouthSudan南苏丹 , "South_Sudan" },
            { M49.Uganda乌干达 , "Uganda" },
            { M49.Tanzania坦桑尼亚 , "Tanzania" },
            { M49.Zambia赞比亚 , "Zambia" },
            { M49.Zimbabwe津巴布韦 , "Zimbabwe" },//20

            // MiddleAfrica中部非洲
            { M49.Angola安哥拉 , "Angola" },
            { M49.Cameroon喀麦隆 , "Cameroon" },
            { M49.CentralAfricanRepublic中非共和国 , "Central_African_Republic" },
            { M49.Chad乍得 , "Chad" },
            { M49.Congo刚果 , "Congo-Brazzaville" },//5
            { M49.RDCongo刚果民主共和国 , "Congo-Kinshasa" },
            { M49.EquatorialGuinea赤道几内亚 , "Equatorial_Guinea" },
            { M49.Gabon加蓬 , "Gabon" },
            { M49.SaoTomeandPrincipe圣多美和普林西比 , "São_Tomé_and_Príncipe" },

            // NorthernAfrica北部非洲
            { M49.Algeria阿尔及利亚 , "Algeria" },
            { M49.Egypt埃及 , "Egypt" },
            { M49.Libya利比亚 , "Libya" },
            { M49.Morocco摩洛哥 , "Morocco" },
            { M49.Sudan苏丹 , "Sudan" },
            { M49.Tunisia突尼斯 , "Tunisia" },
            { M49.WesternSahara西撒哈拉 , "Western_Sahara" },

            // SouthernAfrica南部非洲
            { M49.Botswana博茨瓦纳 , "Botswana" },
            { M49.Lesotho莱索托 , "Lesotho" },
            { M49.Namibia纳米比亚 , "Namibia" },
            { M49.SouthAfrica南非 , "South_Africa" },
            { M49.Swaziland斯威士兰 , "Swaziland" },

            // WesternAfrica西部非洲
            { M49.Benin贝宁 , "Benin" },
            { M49.BurkinaFaso布基纳法索 , "Burkina_Faso" },
            { M49.CaboVerde佛得角 , "Cape_Verde" },
            { M49.CotedIvoire科特迪瓦 , "Ivory_Coast" },
            { M49.Gambia冈比亚 , "Gambia" },//5
            { M49.Ghana加纳 , "Ghana" },
            { M49.Guinea几内亚 , "Guinea" },
            { M49.GuineaBissau几内亚比绍 , "Guinea-Bissau" },
            { M49.Liberia利比里亚 , "Liberia" },
            { M49.Mali马里 , "Mali" },//10
            { M49.Mauritania毛里塔尼亚 , "Mauritania" },
            { M49.Niger尼日尔 , "Niger" },
            { M49.Nigeria尼日利亚 , "Nigeria" },
            { M49.SaintHelena圣赫勒拿 , "Saint_Helena" },
            { M49.Senegal塞内加尔 , "Senegal" },//15
            { M49.SierraLeone塞拉利昂 , "Sierra_Leone" },
            { M49.Togo多哥 , "Togo" },

            // Caribbean加勒比地区
            { M49.Anguilla安圭拉 , "Anguilla" },
            { M49.AntiguaandBarbuda安提瓜和巴布达 , "Antigua_and_Barbuda" },
            { M49.Aruba阿鲁巴 , "Aruba" },
            { M49.Bahamas巴哈马 , "Bahamas" },
            { M49.Barbados巴巴多斯 , "Barbados" },//5
            { M49.BonaireSaintEustatiusAndSaba博奈尔圣尤斯特歇斯和萨巴 , "Sint_Eustatius" },
            { M49.BritishVirginIslands英属维尔京群岛 , "Virgin_Gorda_Island" },
            { M49.CaymanIslands开曼群岛 , "Cayman_Islands" },
            { M49.Cuba古巴 , "Cuba" },
            { M49.Curaçao库拉索 , "Curaçao" },//10
            { M49.Dominica多米尼克 , "Dominica" },
            { M49.DominicanRepublic多米尼加共和国 , "Dominican_Republic" },
            { M49.Grenada格林纳达 , "Grenada" },
            { M49.Guadeloupe瓜德罗普 , "Guadeloupe" },
            { M49.Haiti海地 , "Haiti" },//15
            { M49.Jamaica牙买加 , "Jamaica" },
            { M49.Martinique马提尼克 , "Martinique" },
            { M49.Montserrat蒙特塞拉特 , "Montserrat" },
            { M49.PuertoRico波多黎各 , "Puerto_Rico" },
            { M49.SaintBarts圣巴泰勒米 , "Saint_Barthélemy" },//20
            { M49.SaintKittsandNevis圣基茨和尼维斯 , "Saint_Kitts_and_Nevis" },
            { M49.SaintLucia圣卢西亚 , "Saint_Lucia" },
            { M49.SaintMartin圣马丁法属部分 , "Saint_Martin" },
            { M49.SaintVincentandtheGrenadines圣文森特和格林纳丁斯 , "Saint_Vincent_and_the_Grenadines" },
            { M49.SintMaarten圣马丁荷属部分 , "Sint_Maarten" },//25
            { M49.TrinidadandTobago特立尼达和多巴哥 , "Trinidad_and_Tobago" },
            { M49.TurksandCaicosIslands特克斯和凯科斯群岛 , "Turks_and_Caicos_Islands" },
            { M49.UnitedStatesVirginIslands美属维尔京群岛 , "U.S._Virgin_Islands" },

            // CentralAmerica中美洲
            { M49.Belize伯利兹 , "Belize" },
            { M49.CostaRica哥斯达黎加 , "Costa_Rica" },
            { M49.ElSalvador萨尔瓦多 , "El_Salvador" },
            { M49.Guatemala危地马拉 , "Guatemala" },
            { M49.Honduras洪都拉斯 , "Honduras" },
            { M49.Mexico墨西哥 , "Mexico" },
            { M49.Nicaragua尼加拉瓜 , "Nicaragua" },
            { M49.Panama巴拿马 , "Panama" },

            // SouthAmerica南美洲
            { M49.Argentina阿根廷 , "Argentina" },
            { M49.Bolivia玻利维亚 , "Bolivia" },
            { M49.Brazil巴西 , "Brazil" },
            { M49.Chile智利 , "Chile" },
            { M49.Colombia哥伦比亚 , "Colombia" },//5
            { M49.Ecuador厄瓜多尔 , "Ecuador" },
            { M49.FalklandIslandsMalvinas福克兰群岛马尔维纳斯群岛 , "Falkland_Islands" },
            { M49.FrenchGuiana法属圭亚那 , "French_Guiana" },
            { M49.Guyana圭亚那 , "Guyana" },
            { M49.Paraguay巴拉圭 , "Paraguay" },//10
            { M49.Peru秘鲁 , "Peru" },
            { M49.Suriname苏里南 , "Suriname" },
            { M49.Uruguay乌拉圭 , "Uruguay" },
            { M49.Venezuela委内瑞拉 , "Venezuela" },

            // NorthernAmerica北美地区
            { M49.Bermuda百慕大 , "Bermuda" },
            { M49.Canada加拿大 , "Canada" },
            { M49.Greenland格陵兰 , "Greenland" },
            { M49.SaintPierreandMiquelon圣皮埃尔和密克隆 , "Saint_Pierre_and_Miquelon" },
            { M49.UnitedStatesOfAmerica美利坚合众国 , "United_States" },

            // CentralAsia中亚
            { M49.Kazakhstan哈萨克斯坦 , "Kazakhstan" },
            { M49.Kyrgyzstan吉尔吉斯斯坦 , "Kyrgyzstan" },
            { M49.Tajikistan塔吉克斯坦 , "Tajikistan" },
            { M49.Turkmenistan土库曼斯坦 , "Turkmenistan" },
            { M49.Uzbekistan乌兹别克斯坦 , "Uzbekistan" },

            // EasternAsia东亚
            { M49.China中国 , "China" },
            { M49.HongKong香港 , "Hong_Kong" },
            { M49.Macao澳门 , "Macao" },
            { M49.KoreaDPR朝鲜 , "North_Korea" },
            { M49.Japan日本 , "Japan" },
            { M49.Mongolia蒙古 , "Mongolia" },
            { M49.Korea韩国 , "South_Korea" },

            // SouthernAsia南亚
            { M49.Afghanistan阿富汗 , "Afghanistan" },
            { M49.Bangladesh孟加拉国 , "Bangladesh" },
            { M49.Bhutan不丹 , "Bhutan" },
            { M49.India印度 , "India" },
            { M49.Iran伊朗 , "Iran" },//5
            { M49.Maldives马尔代夫 , "Maldives" },
            { M49.Nepal尼泊尔 , "Nepal" },
            { M49.Pakistan巴基斯坦 , "Pakistan" },
            { M49.SriLanka斯里兰卡 , "Sri_Lanka" },

            // SouthEasternAsia东南亚
            { M49.Brunei文莱 , "Brunei" },
            { M49.Cambodia柬埔寨 , "Cambodia" },
            { M49.Indonesia印度尼西亚 , "Indonesia" },
            { M49.Laos老挝 , "Laos" },
            { M49.Malaysia马来西亚 , "Malaysia" },//5
            { M49.Myanmar缅甸 , "Myanmar" },
            { M49.Philippines菲律宾 , "Philippines" },
            { M49.Singapore新加坡 , "Singapore" },
            { M49.Thailand泰国 , "Thailand" },
            { M49.TimorLeste东帝汶 , "East_Timor" },//10
            { M49.VietNam越南 , "Vietnam" },

            // WesternAsia西亚
            { M49.Armenia亚美尼亚 , "Armenia" },
            { M49.Azerbaijan阿塞拜疆 , "Azerbaijan" },
            { M49.Bahrain巴林 , "Bahrain" },
            { M49.Cyprus塞浦路斯 , "Cyprus" },
            { M49.Georgia格鲁吉亚 , "Georgia" },//5
            { M49.Iraq伊拉克 , "Iraq" },
            { M49.Israel以色列 , "Israel" },
            { M49.Jordan约旦 , "Jordan" },
            { M49.Kuwait科威特 , "Kuwait" },
            { M49.Lebanon黎巴嫩 , "Lebanon" },//10
            { M49.Oman阿曼 , "Oman" },
            { M49.Qatar卡塔尔 , "Qatar" },
            { M49.SaudiArabia沙特阿拉伯 , "Saudi_Arabia" },
            { M49.Palestine巴勒斯坦 , "Palestine" },
            { M49.Syrian叙利亚 , "Syria" },//15
            { M49.Turkey土耳其 , "Turkey" },
            { M49.UAE阿联酋 , "United_Arab_Emirates" },
            { M49.Yemen也门 , "Yemen" },

            // EasternEurope东欧
            { M49.Belarus白俄罗斯 , "Belarus" },
            { M49.Bulgaria保加利亚 , "Bulgaria" },
            { M49.Czech捷克 , "Czechia" },
            { M49.Hungary匈牙利 , "Hungary" },
            { M49.Poland波兰 , "Poland" },//5
            { M49.Moldova摩尔多瓦 , "Moldova" },
            { M49.Romania罗马尼亚 , "Romania" },
            { M49.Russia俄罗斯 , "Russia" },
            { M49.Slovakia斯洛伐克 , "Slovakia" },
            { M49.Ukraine乌克兰 , "Ukraine" },

            // NorthernEurope北欧
            { M49.AlandIslands奥兰群岛 , "Åland" },
            { M49.ChannelIslands海峡群岛 , "Guernsey_Airport" },
            { M49.Denmark丹麦 , "Denmark" },
            { M49.Estonia爱沙尼亚 , "Estonia" },
            { M49.FaeroeIslands法罗群岛 , "Faroe_Islands" },//5
            { M49.Finland芬兰 , "Finland" },
            { M49.Guernsey根西 , "Guernsey" },
            { M49.Iceland冰岛 , "Iceland" },
            { M49.Ireland爱尔兰 , "Ireland" },
            { M49.IsleofMan马恩岛 , "Isle_of_Man" },//10
            { M49.Jersey泽西 , "Jersey" },
            { M49.Latvia拉托维亚 , "Latvia" },
            { M49.Lithuania立陶宛 , "Lithuania" },
            { M49.Norway挪威 , "Norway" },
            { M49.Sark萨克 , "Sark" },//15
            { M49.SvalbardandJanMayenIslands斯瓦尔巴群岛和扬马延岛 , "Svalbard" },
            { M49.Sweden瑞典 , "Sweden" },
            { M49.UK英国 , "United_Kingdom" },

            // SouthernEurope南欧
            { M49.Albania阿尔巴尼亚 , "Albania" },
            { M49.Andorra安道尔 , "Andorra" },
            { M49.BosniaandHerzegovina波斯尼亚和黑塞哥维那 , "Bosnia_and_Herzegovina" },
            { M49.Croatia克罗地亚 , "Croatia" },
            { M49.Gibraltar直布罗陀 , "Gibraltar" },//5
            { M49.Greece希腊 , "Greece" },
            { M49.HolySee圣座 , "Vatican_City" },
            { M49.Italy意大利 , "Italy" },
            { M49.Malta马耳他 , "Malta" },
            { M49.Montenegro黑山 , "Montenegro" },//10
            { M49.Portugal葡萄牙 , "Portugal" },
            { M49.SanMarino圣马力诺 , "San_Marino" },
            { M49.Serbia塞尔维亚 , "Serbia" },
            { M49.Slovenia斯洛文尼亚 , "Slovenia" },
            { M49.Spain西班牙 , "Spain" },//15
            { M49.Macedonia马其顿 , "Macedonia" },

            // WesternEurope西欧
            { M49.Austria奥地利 , "Austria" },
            { M49.Belgium比利时 , "Belgium" },
            { M49.France法国 , "France" },
            { M49.Germany德国 , "Germany" },
            { M49.Liechtenstein列支敦士登 , "Liechtenstein" },//5
            { M49.Luxembourg卢森堡 , "Luxembourg" },
            { M49.Monaco摩纳哥 , "Monaco" },
            { M49.Netherlands荷兰 , "Netherlands" },
            { M49.Switzerland瑞士 , "Switzerland" },

            // AustraliaAndNewZealand澳大利亚和新西兰
            { M49.Australia澳大利亚 , "Australia" },
            { M49.NewZealand新西兰 , "New_Zealand" },
            { M49.NorfolkIsland诺福克岛 , "Norfolk_Island" },

            // Melanesia美拉尼西亚
            { M49.Fiji斐济 , "Fiji" },
            { M49.NewCaledonia新喀里多尼亚 , "New_Caledonia" },
            { M49.PapuaNewGuinea巴布亚新几内亚 , "Papua_New_Guinea" },
            { M49.SolomonIslands所罗门群岛 , "Solomon_Islands" },
            { M49.Vanuatu瓦努阿图 , "Vanuatu" },

            // Micronesia密克罗尼西亚
            { M49.Guam关岛 , "Guam" },
            { M49.Kiribati基里巴斯 , "Kiribati" },
            { M49.MarshallIslands马绍尔群岛 , "Marshall_Islands" },
            { M49.Micronesia密克罗尼西亚联邦 , "Micronesia" },
            { M49.Nauru瑙鲁 , "Nauru" },//5
            { M49.NorthernMarianaIslands北马里亚纳群岛 , "Northern_Mariana_Islands" },
            { M49.Palau帕劳 , "Palau" },

            // Polynesia波利尼西亚
            { M49.AmericanSamoa美属萨摩亚 , "American_Samoa" },
            { M49.CookIslands库克群岛 , "Cook_Islands" },
            { M49.FrenchPolynesia法属波利尼西亚 , "French_Polynesia" },
            { M49.Niue纽埃 , "Niue" },
            { M49.Pitcairn皮特凯恩 , "Pitcairn_Islands" },//5
            { M49.Samoa萨摩亚 , "Samoa" },
            { M49.Tokelau托克劳 , "Tokelau" },
            { M49.Tonga汤加 , "Tonga" },
            { M49.Tuvalu图瓦卢 , "Tuvalu" },
            { M49.WallisandFutunaIslands瓦利斯和富图纳群岛 , "Wallis_and_Futuna" },//10

        };
    }

}
