using System;
using System.Collections.Generic;
using System.Text;

namespace OYMLCN.GlobalRegion
{
    /// <summary>
    /// GlobalRegionData
    /// </summary>
    public static partial class GlobalRegionData
    {
        /// <summary>
        /// 大洲
        /// </summary>
        public static IReadOnlyList<M49> Continent = new List<M49>() {
            M49.Africa非洲,
            M49.Americas美洲,
            M49.Asia亚洲,
            M49.Europe欧洲,
            M49.Oceania大洋洲
        }.AsReadOnly();

        /// <summary>
        /// 大洲地区
        /// </summary>
        public static IReadOnlyDictionary<M49, M49> ContinentRegion = new Dictionary<M49, M49>()
        {
            { M49.EasternAfrica东部非洲 , M49.Africa非洲 },
            { M49.MiddleAfrica中部非洲 , M49.Africa非洲 },
            { M49.NorthernAfrica北部非洲 , M49.Africa非洲 },
            { M49.SouthAfrica南非 , M49.Africa非洲 },
            { M49.WesternAfrica西部非洲 , M49.Africa非洲 },

            { M49.Caribbean加勒比地区 , M49.Americas美洲 },
            { M49.CentralAmerica中美洲 , M49.Americas美洲 },
            { M49.SouthAmerica南美洲 , M49.Americas美洲 },
            { M49.NorthernAmerica北美地区 , M49.Americas美洲 },

            { M49.CentralAsia中亚 , M49.Asia亚洲 },
            { M49.EasternAsia东亚 , M49.Asia亚洲 },
            { M49.SouthernAsia南亚 , M49.Asia亚洲 },
            { M49.SouthEasternAsia东南亚 , M49.Asia亚洲 },
            { M49.WesternAsia西亚 , M49.Asia亚洲 },

            { M49.EasternEurope东欧 , M49.Europe欧洲 },
            { M49.NorthernEurope北欧 , M49.Europe欧洲 },
            { M49.SouthernEurope南欧 , M49.Europe欧洲 },
            { M49.WesternEurope西欧 , M49.Europe欧洲 },

            { M49.AustraliaAndNewZealand澳大利亚和新西兰 , M49.Oceania大洋洲 },
            { M49.Melanesia美拉尼西亚 , M49.Oceania大洋洲 },
            { M49.Micronesia密克罗尼西亚联邦 , M49.Oceania大洋洲 },
            { M49.Polynesia波利尼西亚 , M49.Oceania大洋洲 },
        };

        /// <summary>
        /// Africa非洲
        /// </summary>
        public static IReadOnlyDictionary<M49, M49> Africa = new Dictionary<M49, M49>()
        {
            { M49.Burundi布隆迪 , M49.EasternAfrica东部非洲 },
            { M49.Comoros科摩罗 , M49.EasternAfrica东部非洲 },
            { M49.Djibouti吉布提 , M49.EasternAfrica东部非洲 },
            { M49.Eritrea厄立特里亚 , M49.EasternAfrica东部非洲 },
            { M49.Ethiopia埃塞俄比亚 , M49.EasternAfrica东部非洲 },
            { M49.Kenya肯尼亚 , M49.EasternAfrica东部非洲 },
            { M49.Madagascar马达加斯加 , M49.EasternAfrica东部非洲 },
            { M49.Malawi马拉维 , M49.EasternAfrica东部非洲 },
            { M49.Mauritius毛里求斯 , M49.EasternAfrica东部非洲 },
            { M49.Mayotte马约特 , M49.EasternAfrica东部非洲 },
            { M49.Mozambique莫桑比克 , M49.EasternAfrica东部非洲 },
            { M49.Reunion留尼汪 , M49.EasternAfrica东部非洲 },
            { M49.Rwanda卢旺达 , M49.EasternAfrica东部非洲 },
            { M49.Seychelles塞舌尔 , M49.EasternAfrica东部非洲 },
            { M49.Somalia索马里 , M49.EasternAfrica东部非洲 },
            { M49.SouthSudan南苏丹 , M49.EasternAfrica东部非洲 },
            { M49.Uganda乌干达 , M49.EasternAfrica东部非洲 },
            { M49.Tanzania坦桑尼亚 , M49.EasternAfrica东部非洲 },
            { M49.Zambia赞比亚 , M49.EasternAfrica东部非洲 },
            { M49.Zimbabwe津巴布韦 , M49.EasternAfrica东部非洲 },

            { M49.Angola安哥拉 , M49.MiddleAfrica中部非洲 },
            { M49.Cameroon喀麦隆 , M49.MiddleAfrica中部非洲 },
            { M49.CentralAfricanRepublic中非共和国 , M49.MiddleAfrica中部非洲 },
            { M49.Chad乍得 , M49.MiddleAfrica中部非洲 },
            { M49.Congo刚果 , M49.MiddleAfrica中部非洲 },
            { M49.RDCongo刚果民主共和国 , M49.MiddleAfrica中部非洲 },
            { M49.EquatorialGuinea赤道几内亚 , M49.MiddleAfrica中部非洲 },
            { M49.Gabon加蓬 , M49.MiddleAfrica中部非洲 },
            { M49.SaoTomeandPrincipe圣多美和普林西比 , M49.MiddleAfrica中部非洲 },

            { M49.Algeria阿尔及利亚 , M49.NorthernAfrica北部非洲 },
            { M49.Egypt埃及 , M49.NorthernAfrica北部非洲 },
            { M49.Libya利比亚 , M49.NorthernAfrica北部非洲 },
            { M49.Morocco摩洛哥 , M49.NorthernAfrica北部非洲 },
            { M49.Sudan苏丹 , M49.NorthernAfrica北部非洲 },
            { M49.Tunisia突尼斯 , M49.NorthernAfrica北部非洲 },
            { M49.WesternSahara西撒哈拉 , M49.NorthernAfrica北部非洲 },

            { M49.Botswana博茨瓦纳 , M49.SouthernAfrica南部非洲 },
            { M49.Lesotho莱索托 , M49.SouthernAfrica南部非洲 },
            { M49.Namibia纳米比亚 , M49.SouthernAfrica南部非洲 },
            { M49.SouthAfrica南非 , M49.SouthernAfrica南部非洲 },
            { M49.Swaziland斯威士兰 , M49.SouthernAfrica南部非洲 },

            { M49.Benin贝宁 , M49.WesternAfrica西部非洲 },
            { M49.BurkinaFaso布基纳法索 , M49.WesternAfrica西部非洲 },
            { M49.CaboVerde佛得角 , M49.WesternAfrica西部非洲 },
            { M49.CotedIvoire科特迪瓦 , M49.WesternAfrica西部非洲 },
            { M49.Gambia冈比亚 , M49.WesternAfrica西部非洲 },
            { M49.Ghana加纳 , M49.WesternAfrica西部非洲 },
            { M49.Guinea几内亚 , M49.WesternAfrica西部非洲 },
            { M49.GuineaBissau几内亚比绍 , M49.WesternAfrica西部非洲 },
            { M49.Liberia利比里亚 , M49.WesternAfrica西部非洲 },
            { M49.Mali马里 , M49.WesternAfrica西部非洲 },
            { M49.Mauritania毛里塔尼亚 , M49.WesternAfrica西部非洲 },
            { M49.Niger尼日尔 , M49.WesternAfrica西部非洲 },
            { M49.Nigeria尼日利亚 , M49.WesternAfrica西部非洲 },
            { M49.SaintHelena圣赫勒拿 , M49.WesternAfrica西部非洲 },
            { M49.Senegal塞内加尔 , M49.WesternAfrica西部非洲 },
            { M49.SierraLeone塞拉利昂 , M49.WesternAfrica西部非洲 },
            { M49.Togo多哥 , M49.WesternAfrica西部非洲 },

        };
        /// <summary>
        /// Americas美洲
        /// </summary>
        public static IReadOnlyDictionary<M49, M49> Americas = new Dictionary<M49, M49>()
        {
            { M49.Anguilla安圭拉 , M49.Caribbean加勒比地区 },
            { M49.AntiguaandBarbuda安提瓜和巴布达 , M49.Caribbean加勒比地区 },
            { M49.Aruba阿鲁巴 , M49.Caribbean加勒比地区 },
            { M49.Bahamas巴哈马 , M49.Caribbean加勒比地区 },
            { M49.Barbados巴巴多斯 , M49.Caribbean加勒比地区 },
            { M49.BonaireSaintEustatiusAndSaba博奈尔圣尤斯特歇斯和萨巴 , M49.Caribbean加勒比地区 },
            { M49.BritishVirginIslands英属维尔京群岛 , M49.Caribbean加勒比地区 },
            { M49.CaymanIslands开曼群岛 , M49.Caribbean加勒比地区 },
            { M49.Cuba古巴 , M49.Caribbean加勒比地区 },
            { M49.Curaçao库拉索 , M49.Caribbean加勒比地区 },
            { M49.Dominica多米尼克 , M49.Caribbean加勒比地区 },
            { M49.DominicanRepublic多米尼加共和国 , M49.Caribbean加勒比地区 },
            { M49.Grenada格林纳达 , M49.Caribbean加勒比地区 },
            { M49.Guadeloupe瓜德罗普 , M49.Caribbean加勒比地区 },
            { M49.Haiti海地 , M49.Caribbean加勒比地区 },
            { M49.Jamaica牙买加 , M49.Caribbean加勒比地区 },
            { M49.Martinique马提尼克 , M49.Caribbean加勒比地区 },
            { M49.Montserrat蒙特塞拉特 , M49.Caribbean加勒比地区 },
            { M49.PuertoRico波多黎各 , M49.Caribbean加勒比地区 },
            { M49.SaintBarts圣巴泰勒米 , M49.Caribbean加勒比地区 },
            { M49.SaintKittsandNevis圣基茨和尼维斯 , M49.Caribbean加勒比地区 },
            { M49.SaintLucia圣卢西亚 , M49.Caribbean加勒比地区 },
            { M49.SaintMartin圣马丁法属部分 , M49.Caribbean加勒比地区 },
            { M49.SaintVincentandtheGrenadines圣文森特和格林纳丁斯 , M49.Caribbean加勒比地区 },
            { M49.SintMaarten圣马丁荷属部分 , M49.Caribbean加勒比地区 },
            { M49.TrinidadandTobago特立尼达和多巴哥 , M49.Caribbean加勒比地区 },
            { M49.TurksandCaicosIslands特克斯和凯科斯群岛 , M49.Caribbean加勒比地区 },
            { M49.UnitedStatesVirginIslands美属维尔京群岛 , M49.Caribbean加勒比地区 },

            { M49.Belize伯利兹 , M49.CentralAmerica中美洲 },
            { M49.CostaRica哥斯达黎加 , M49.CentralAmerica中美洲 },
            { M49.ElSalvador萨尔瓦多 , M49.CentralAmerica中美洲 },
            { M49.Guatemala危地马拉 , M49.CentralAmerica中美洲 },
            { M49.Honduras洪都拉斯 , M49.CentralAmerica中美洲 },
            { M49.Mexico墨西哥 , M49.CentralAmerica中美洲 },
            { M49.Nicaragua尼加拉瓜 , M49.CentralAmerica中美洲 },
            { M49.Panama巴拿马 , M49.CentralAmerica中美洲 },

            { M49.Argentina阿根廷 , M49.SouthAmerica南美洲 },
            { M49.Bolivia玻利维亚 , M49.SouthAmerica南美洲 },
            { M49.Brazil巴西 , M49.SouthAmerica南美洲 },
            { M49.Chile智利 , M49.SouthAmerica南美洲 },
            { M49.Colombia哥伦比亚 , M49.SouthAmerica南美洲 },
            { M49.Ecuador厄瓜多尔 , M49.SouthAmerica南美洲 },
            { M49.FalklandIslandsMalvinas福克兰群岛马尔维纳斯群岛 , M49.SouthAmerica南美洲 },
            { M49.FrenchGuiana法属圭亚那 , M49.SouthAmerica南美洲 },
            { M49.Guyana圭亚那 , M49.SouthAmerica南美洲 },
            { M49.Paraguay巴拉圭 , M49.SouthAmerica南美洲 },
            { M49.Peru秘鲁 , M49.SouthAmerica南美洲 },
            { M49.Suriname苏里南 , M49.SouthAmerica南美洲 },
            { M49.Uruguay乌拉圭 , M49.SouthAmerica南美洲 },
            { M49.Venezuela委内瑞拉 , M49.SouthAmerica南美洲 },

            { M49.Bermuda百慕大 , M49.NorthernAmerica北美地区 },
            { M49.Canada加拿大 , M49.NorthernAmerica北美地区 },
            { M49.Greenland格陵兰 , M49.NorthernAmerica北美地区 },
            { M49.SaintPierreandMiquelon圣皮埃尔和密克隆 , M49.NorthernAmerica北美地区 },
            { M49.UnitedStatesOfAmerica美利坚合众国 , M49.NorthernAmerica北美地区 },

        };
        /// <summary>
        /// Asia亚洲
        /// </summary>
        public static IReadOnlyDictionary<M49, M49> Asia = new Dictionary<M49, M49>()
        {
            { M49.Kazakhstan哈萨克斯坦 , M49.CentralAsia中亚 },
            { M49.Kyrgyzstan吉尔吉斯斯坦 , M49.CentralAsia中亚 },
            { M49.Tajikistan塔吉克斯坦 , M49.CentralAsia中亚 },
            { M49.Turkmenistan土库曼斯坦 , M49.CentralAsia中亚 },
            { M49.Uzbekistan乌兹别克斯坦 , M49.CentralAsia中亚 },

            { M49.China中国 , M49.EasternAsia东亚 },
            { M49.HongKong香港 , M49.EasternAsia东亚 },
            { M49.Macao澳门 , M49.EasternAsia东亚 },
            { M49.KoreaDPR朝鲜 , M49.EasternAsia东亚 },
            { M49.Japan日本 , M49.EasternAsia东亚 },
            { M49.Mongolia蒙古 , M49.EasternAsia东亚 },
            { M49.Korea韩国 , M49.EasternAsia东亚 },

            { M49.Afghanistan阿富汗 , M49.SouthernAsia南亚 },
            { M49.Bangladesh孟加拉国 , M49.SouthernAsia南亚 },
            { M49.Bhutan不丹 , M49.SouthernAsia南亚 },
            { M49.India印度 , M49.SouthernAsia南亚 },
            { M49.Iran伊朗 , M49.SouthernAsia南亚 },
            { M49.Maldives马尔代夫 , M49.SouthernAsia南亚 },
            { M49.Nepal尼泊尔 , M49.SouthernAsia南亚 },
            { M49.Pakistan巴基斯坦 , M49.SouthernAsia南亚 },
            { M49.SriLanka斯里兰卡 , M49.SouthernAsia南亚 },

            { M49.Brunei文莱 , M49.SouthEasternAsia东南亚 },
            { M49.Cambodia柬埔寨 , M49.SouthEasternAsia东南亚 },
            { M49.Indonesia印度尼西亚 , M49.SouthEasternAsia东南亚 },
            { M49.Laos老挝 , M49.SouthEasternAsia东南亚 },
            { M49.Malaysia马来西亚 , M49.SouthEasternAsia东南亚 },
            { M49.Myanmar缅甸 , M49.SouthEasternAsia东南亚 },
            { M49.Philippines菲律宾 , M49.SouthEasternAsia东南亚 },
            { M49.Singapore新加坡 , M49.SouthEasternAsia东南亚 },
            { M49.Thailand泰国 , M49.SouthEasternAsia东南亚 },
            { M49.TimorLeste东帝汶 , M49.SouthEasternAsia东南亚 },
            { M49.VietNam越南 , M49.SouthEasternAsia东南亚 },

            { M49.Armenia亚美尼亚 , M49.WesternAsia西亚 },
            { M49.Azerbaijan阿塞拜疆 , M49.WesternAsia西亚 },
            { M49.Bahrain巴林 , M49.WesternAsia西亚 },
            { M49.Cyprus塞浦路斯 , M49.WesternAsia西亚 },
            { M49.Georgia格鲁吉亚 , M49.WesternAsia西亚 },
            { M49.Iraq伊拉克 , M49.WesternAsia西亚 },
            { M49.Israel以色列 , M49.WesternAsia西亚 },
            { M49.Jordan约旦 , M49.WesternAsia西亚 },
            { M49.Kuwait科威特 , M49.WesternAsia西亚 },
            { M49.Lebanon黎巴嫩 , M49.WesternAsia西亚 },
            { M49.Oman阿曼 , M49.WesternAsia西亚 },
            { M49.Qatar卡塔尔 , M49.WesternAsia西亚 },
            { M49.SaudiArabia沙特阿拉伯 , M49.WesternAsia西亚 },
            { M49.Palestine巴勒斯坦 , M49.WesternAsia西亚 },
            { M49.Syrian叙利亚 , M49.WesternAsia西亚 },
            { M49.Turkey土耳其 , M49.WesternAsia西亚 },
            { M49.UAE阿联酋 , M49.WesternAsia西亚 },
            { M49.Yemen也门 , M49.WesternAsia西亚 },

        };
        /// <summary>
        /// Europe欧洲
        /// </summary>
        public static IReadOnlyDictionary<M49, M49> Europe = new Dictionary<M49, M49>()
        {
            { M49.Belarus白俄罗斯 , M49.EasternEurope东欧 },
            { M49.Bulgaria保加利亚 , M49.EasternEurope东欧 },
            { M49.Czech捷克 , M49.EasternEurope东欧 },
            { M49.Hungary匈牙利 , M49.EasternEurope东欧 },
            { M49.Poland波兰 , M49.EasternEurope东欧 },
            { M49.Moldova摩尔多瓦 , M49.EasternEurope东欧 },
            { M49.Romania罗马尼亚 , M49.EasternEurope东欧 },
            { M49.Russia俄罗斯 , M49.EasternEurope东欧 },
            { M49.Slovakia斯洛伐克 , M49.EasternEurope东欧 },
            { M49.Ukraine乌克兰 , M49.EasternEurope东欧 },

            { M49.AlandIslands奥兰群岛 , M49.NorthernEurope北欧 },
            { M49.ChannelIslands海峡群岛 , M49.NorthernEurope北欧 },
            { M49.Denmark丹麦 , M49.NorthernEurope北欧 },
            { M49.Estonia爱沙尼亚 , M49.NorthernEurope北欧 },
            { M49.FaeroeIslands法罗群岛 , M49.NorthernEurope北欧 },
            { M49.Finland芬兰 , M49.NorthernEurope北欧 },
            { M49.Guernsey根西 , M49.NorthernEurope北欧 },
            { M49.Iceland冰岛 , M49.NorthernEurope北欧 },
            { M49.Ireland爱尔兰 , M49.NorthernEurope北欧 },
            { M49.IsleofMan马恩岛 , M49.NorthernEurope北欧 },
            { M49.Jersey泽西 , M49.NorthernEurope北欧 },
            { M49.Latvia拉托维亚 , M49.NorthernEurope北欧 },
            { M49.Lithuania立陶宛 , M49.NorthernEurope北欧 },
            { M49.Norway挪威 , M49.NorthernEurope北欧 },
            { M49.Sark萨克 , M49.NorthernEurope北欧 },
            { M49.SvalbardandJanMayenIslands斯瓦尔巴群岛和扬马延岛 , M49.NorthernEurope北欧 },
            { M49.Sweden瑞典 , M49.NorthernEurope北欧 },
            { M49.UK英国 , M49.NorthernEurope北欧 },

            { M49.Albania阿尔巴尼亚 , M49.SouthernEurope南欧 },
            { M49.Andorra安道尔 , M49.SouthernEurope南欧 },
            { M49.BosniaandHerzegovina波斯尼亚和黑塞哥维那 , M49.SouthernEurope南欧 },
            { M49.Croatia克罗地亚 , M49.SouthernEurope南欧 },
            { M49.Gibraltar直布罗陀 , M49.SouthernEurope南欧 },
            { M49.Greece希腊 , M49.SouthernEurope南欧 },
            { M49.HolySee圣座 , M49.SouthernEurope南欧 },
            { M49.Italy意大利 , M49.SouthernEurope南欧 },
            { M49.Malta马耳他 , M49.SouthernEurope南欧 },
            { M49.Montenegro黑山 , M49.SouthernEurope南欧 },
            { M49.Portugal葡萄牙 , M49.SouthernEurope南欧 },
            { M49.SanMarino圣马力诺 , M49.SouthernEurope南欧 },
            { M49.Serbia塞尔维亚 , M49.SouthernEurope南欧 },
            { M49.Slovenia斯洛文尼亚 , M49.SouthernEurope南欧 },
            { M49.Spain西班牙 , M49.SouthernEurope南欧 },
            { M49.Macedonia马其顿 , M49.SouthernEurope南欧 },

            { M49.Austria奥地利 , M49.WesternEurope西欧 },
            { M49.Belgium比利时 , M49.WesternEurope西欧 },
            { M49.France法国 , M49.WesternEurope西欧 },
            { M49.Germany德国 , M49.WesternEurope西欧 },
            { M49.Liechtenstein列支敦士登 , M49.WesternEurope西欧 },
            { M49.Luxembourg卢森堡 , M49.WesternEurope西欧 },
            { M49.Monaco摩纳哥 , M49.WesternEurope西欧 },
            { M49.Netherlands荷兰 , M49.WesternEurope西欧 },
            { M49.Switzerland瑞士 , M49.WesternEurope西欧 },

        };
        /// <summary>
        /// Oceania大洋洲
        /// </summary>
        public static IReadOnlyDictionary<M49, M49> Oceania = new Dictionary<M49, M49>()
        {
            { M49.Australia澳大利亚 , M49.AustraliaAndNewZealand澳大利亚和新西兰 },
            { M49.NewZealand新西兰 , M49.AustraliaAndNewZealand澳大利亚和新西兰 },
            { M49.NorfolkIsland诺福克岛 , M49.AustraliaAndNewZealand澳大利亚和新西兰 },

            { M49.Fiji斐济 , M49.Melanesia美拉尼西亚 },
            { M49.NewCaledonia新喀里多尼亚 , M49.Melanesia美拉尼西亚 },
            { M49.PapuaNewGuinea巴布亚新几内亚 , M49.Melanesia美拉尼西亚 },
            { M49.SolomonIslands所罗门群岛 , M49.Melanesia美拉尼西亚 },
            { M49.Vanuatu瓦努阿图 , M49.Melanesia美拉尼西亚 },

            { M49.Guam关岛 , M49.Micronesia密克罗尼西亚 },
            { M49.Kiribati基里巴斯 , M49.Micronesia密克罗尼西亚 },
            { M49.MarshallIslands马绍尔群岛 , M49.Micronesia密克罗尼西亚 },
            { M49.Micronesia密克罗尼西亚联邦 , M49.Micronesia密克罗尼西亚 },
            { M49.Nauru瑙鲁 , M49.Micronesia密克罗尼西亚 },
            { M49.NorthernMarianaIslands北马里亚纳群岛 , M49.Micronesia密克罗尼西亚 },
            { M49.Palau帕劳 , M49.Micronesia密克罗尼西亚 },

            { M49.AmericanSamoa美属萨摩亚 , M49.Polynesia波利尼西亚 },
            { M49.CookIslands库克群岛 , M49.Polynesia波利尼西亚 },
            { M49.FrenchPolynesia法属波利尼西亚 , M49.Polynesia波利尼西亚 },
            { M49.Niue纽埃 , M49.Polynesia波利尼西亚 },
            { M49.Pitcairn皮特凯恩 , M49.Polynesia波利尼西亚 },
            { M49.Samoa萨摩亚 , M49.Polynesia波利尼西亚 },
            { M49.Tokelau托克劳 , M49.Polynesia波利尼西亚 },
            { M49.Tonga汤加 , M49.Polynesia波利尼西亚 },
            { M49.Tuvalu图瓦卢 , M49.Polynesia波利尼西亚 },
            { M49.WallisandFutunaIslands瓦利斯和富图纳群岛 , M49.Polynesia波利尼西亚 },

        };



    }
}
