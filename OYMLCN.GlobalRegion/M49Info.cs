using System;
using System.Collections.Generic;
using System.Text;

namespace OYMLCN.GlobalRegion
{
    /// <summary>
    /// 信息集合
    /// </summary>
    public class M49Info
    {
        internal M49Info() { }

        /// <summary>
        /// M49
        /// </summary>
        public M49 M49 { get; internal set; }

        /// <summary>
        /// 缩写代码(国家代码)
        /// </summary>
        public string Flag { get; internal set; }
        /// <summary>
        /// 简要名称(英)
        /// </summary>
        public string ShortName { get; internal set; }
        /// <summary>
        /// 全名(英)
        /// </summary>
        public string FullName { get; internal set; }
        /// <summary>
        /// 中文名称(简称)
        /// </summary>
        public string ChineseShortName { get; internal set; }
        /// <summary>
        /// 中文名称(全称)
        /// </summary>
        public string ChineseFullName { get; internal set; }

        /// <summary>
        /// 标准时间与UTC的偏差
        /// </summary>
        public TimeSpan UTCTimeSpan { get; internal set; }
        /// <summary>
        /// 国家或地区标准时间
        /// </summary>
        public DateTime TimeIs => DateTime.Now + UTCTimeSpan;

    }

    public static partial class Data
    {
        public static IReadOnlyDictionary<M49, M49Info> M49Infos = new Dictionary<M49, M49Info>()
        {
#region EasternAfrica东部非洲
		    // EasternAfrica东部非洲
            { M49.Burundi布隆迪 , new M49Info(){
                M49 = M49.Burundi布隆迪,
                Flag = "BDI",
                ShortName="Burundi",
                FullName="The Republic of Burundi",
                ChineseShortName="布隆迪",
                ChineseFullName="布隆迪共和国",
                UTCTimeSpan=new TimeSpan(2,0,0)
            } },
            { M49.Comoros科摩罗 , new M49Info(){
                M49 = M49.Comoros科摩罗,
                Flag = "COM",
                ShortName="Comoros",
                FullName="the Federal and Islamic Republic of the Comoros",
                ChineseShortName="科摩罗",
                ChineseFullName="科摩罗伊斯兰联邦共和国",
                UTCTimeSpan=new TimeSpan(3,0,0)
            } },
            { M49.Djibouti吉布提 , new M49Info(){
                M49 = M49.Djibouti吉布提,
                Flag = "DJI",
                ShortName="Djibouti",
                FullName="The Republic of Djibouti",
                ChineseShortName="吉布提",
                ChineseFullName="吉布提共和国",
                UTCTimeSpan=new TimeSpan(3,0,0)
            } },
            { M49.Eritrea厄立特里亚 , new M49Info(){
                M49 = M49.Eritrea厄立特里亚,
                Flag = "ERI",
                ShortName="Eritrea",
                FullName="The State of Eritrea",
                ChineseShortName="厄立特里亚",
                ChineseFullName="厄立特里亚国",
                UTCTimeSpan=new TimeSpan(3,0,0)
            } },
            { M49.Ethiopia埃塞俄比亚 , new M49Info(){
                M49 = M49.Ethiopia埃塞俄比亚,
                Flag = "ETH",
                ShortName="Ethiopia",
                FullName="The Federal Democratic Republic of Ethiopia",
                ChineseShortName="埃塞俄比亚",
                ChineseFullName="埃塞俄比亚联邦民主共和国",
                UTCTimeSpan=new TimeSpan(3,0,0)
            } },//5
            { M49.Kenya肯尼亚 , new M49Info(){
                M49 = M49.Kenya肯尼亚,
                Flag = "KEN",
                ShortName="Kenya",
                FullName="The Republic of Kenya",
                ChineseShortName="肯尼亚",
                ChineseFullName="肯尼亚共和国",
                UTCTimeSpan=new TimeSpan(3,0,0)
            } },
            { M49.Madagascar马达加斯加 , new M49Info(){
                M49 = M49.Madagascar马达加斯加,
                Flag = "MDG",
                ShortName="Madagascar",
                FullName="The Republic of Madagascar",
                ChineseShortName="马达加斯加",
                ChineseFullName="马达加斯加共和国",
                UTCTimeSpan=new TimeSpan(3,0,0)
            } },
            { M49.Malawi马拉维 , new M49Info(){
                M49 = M49.Malawi马拉维,
                Flag = "MWI",
                ShortName="Malawi",
                FullName="The Republic of Malawi",
                ChineseShortName="马拉维",
                ChineseFullName="马拉维共和国",
                UTCTimeSpan=new TimeSpan(2,0,0)
            } },
            { M49.Mauritius毛里求斯 , new M49Info(){
                M49 = M49.Mauritius毛里求斯,
                Flag = "MUS",
                ShortName="Mauritius",
                FullName="The Republic of Mauritius",
                ChineseShortName="毛里求斯",
                ChineseFullName="毛里求斯共和国",
                UTCTimeSpan=new TimeSpan(4,0,0)
            } },
            { M49.Mayotte马约特 , new M49Info(){
                M49 = M49.Mayotte马约特,
                Flag = "MYT",
                ShortName="Mayotte",
                FullName="Territorial Collectivity of Mayotte",
                ChineseShortName="马约特",
                ChineseFullName="马约特岛",
                UTCTimeSpan=new TimeSpan(3,0,0)
            } },//10
            { M49.Mozambique莫桑比克 , new M49Info(){
                M49 = M49.Mozambique莫桑比克,
                Flag = "MOZ",
                ShortName="Mozambique",
                FullName="The Republic of Mozambique",
                ChineseShortName="莫桑比克",
                ChineseFullName="莫桑比克共和国",
                UTCTimeSpan=new TimeSpan(2,0,0)
            } },
            { M49.Reunion留尼汪 , new M49Info(){
                M49 = M49.Reunion留尼汪,
                Flag = "RE",
                ShortName="Reunion",
                FullName="Reunion Island",
                ChineseShortName="留尼汪",
                ChineseFullName="留尼汪岛",
                UTCTimeSpan=new TimeSpan(4,0,0)
            } },
            { M49.Rwanda卢旺达 , new M49Info(){
                M49 = M49.Rwanda卢旺达,
                Flag = "RWA",
                ShortName="Rwanda",
                FullName="The Republic of Rwanda",
                ChineseShortName="卢旺达",
                ChineseFullName="卢旺达共和国",
                UTCTimeSpan=new TimeSpan(2,0,0)
            } },
            { M49.Seychelles塞舌尔 , new M49Info(){
                M49 = M49.Seychelles塞舌尔,
                Flag = "SYC",
                ShortName="Seychelles",
                FullName="Republic of Seychelles",
                ChineseShortName="塞舌尔",
                ChineseFullName="塞舌尔共和国",
                UTCTimeSpan=new TimeSpan(4,0,0)
            } },
            { M49.Somalia索马里 , new M49Info(){
                M49 = M49.Somalia索马里,
                Flag = "SOM",
                ShortName="Somalia",
                FullName="Federal Republic of Somalia",
                ChineseShortName="索马里",
                ChineseFullName="索马里联邦共和国",
                UTCTimeSpan=new TimeSpan(3,0,0)
            } },//15
            { M49.SouthSudan南苏丹 , new M49Info(){
                M49 = M49.SouthSudan南苏丹,
                Flag = "SSD",
                ShortName="South Sudan",
                FullName="The Republic of South Sudan",
                ChineseShortName="南苏丹",
                ChineseFullName="南苏丹共和国",
                UTCTimeSpan=new TimeSpan(3,0,0)
            } },
            { M49.Uganda乌干达 , new M49Info(){
                M49 = M49.Uganda乌干达,
                Flag = "UGA",
                ShortName="Uganda",
                FullName="The Republic of Uganda",
                ChineseShortName="乌干达",
                ChineseFullName="乌干达共和国",
                UTCTimeSpan=new TimeSpan(3,0,0)
            } },
            { M49.Tanzania坦桑尼亚 , new M49Info(){
                M49 = M49.Tanzania坦桑尼亚,
                Flag = "TZA",
                ShortName="Tanzania",
                FullName="The United Republic of Tanzania",
                ChineseShortName="坦桑尼亚",
                ChineseFullName="坦桑尼亚联合共和国",
                UTCTimeSpan=new TimeSpan(3,0,0)
            } },
            { M49.Zambia赞比亚 , new M49Info(){
                M49 = M49.Zambia赞比亚,
                Flag = "ZMB",
                ShortName="Zambia",
                FullName="The Republic of Zambia",
                ChineseShortName="赞比亚",
                ChineseFullName="赞比亚共和国",
                UTCTimeSpan=new TimeSpan(2,0,0)
            } },
            { M49.Zimbabwe津巴布韦 , new M49Info(){
                M49 = M49.Zimbabwe津巴布韦,
                Flag = "ZWE",
                ShortName="Zimbabwe",
                FullName="Republic of Zimbabwe",
                ChineseShortName="津巴布韦",
                ChineseFullName="津巴布韦共和国",
                UTCTimeSpan=new TimeSpan(2,0,0)
            } },//20
#endregion

#region MiddleAfrica中部非洲
		    // MiddleAfrica中部非洲
            { M49.Angola安哥拉 , new M49Info(){
                M49 = M49.Angola安哥拉,
                Flag = "AGO",
                ShortName="Angola",
                FullName="The Republic of Angola",
                ChineseShortName="安哥拉",
                ChineseFullName="安哥拉共和国",
                UTCTimeSpan=new TimeSpan(1,0,0)
            } },
            { M49.Cameroon喀麦隆 , new M49Info(){
                M49 = M49.Cameroon喀麦隆,
                Flag = "CMR",
                ShortName="Cameroon",
                FullName="Republic of Cameroon",
                ChineseShortName="喀麦隆",
                ChineseFullName="喀麦隆共和国",
                UTCTimeSpan=new TimeSpan(1,0,0)
            } },
            { M49.CentralAfricanRepublic中非共和国 , new M49Info(){
                M49 = M49.CentralAfricanRepublic中非共和国,
                Flag = "CAF",
                ShortName="Central African",
                FullName="The Central African Republic",
                ChineseShortName="中非",
                ChineseFullName="中非共和国",
                UTCTimeSpan=new TimeSpan(1,0,0)
            } },
            { M49.Chad乍得 , new M49Info(){
                M49 = M49.Chad乍得,
                Flag = "TCD",
                ShortName="Chad",
                FullName="The Republic of Chad",
                ChineseShortName="乍得",
                ChineseFullName="乍得共和国",
                UTCTimeSpan=new TimeSpan(1,0,0)
            } },
            { M49.Congo刚果 , new M49Info(){
                M49 = M49.Congo刚果,
                Flag = "COG",
                ShortName="Congo",
                FullName="The Republic of Congo",
                ChineseShortName="刚果（布）",
                ChineseFullName="刚果共和国",
                UTCTimeSpan=new TimeSpan(1,0,0)
            } },//5
            { M49.RDCongo刚果民主共和国 , new M49Info(){
                M49 = M49.RDCongo刚果民主共和国,
                Flag = "COD",
                ShortName="RD Congo",
                FullName="Democratic Republic of the Congo",
                ChineseShortName="刚果（金）",
                ChineseFullName="刚果民主共和国",
                UTCTimeSpan=new TimeSpan(2,0,0)
            } },
            { M49.EquatorialGuinea赤道几内亚 , new M49Info(){
                M49 = M49.EquatorialGuinea赤道几内亚,
                Flag = "GNQ",
                ShortName="Equatorial Guinea",
                FullName="The Republic of Equatorial Guinea",
                ChineseShortName="赤道几内亚",
                ChineseFullName="赤道几内亚共和国",
                UTCTimeSpan=new TimeSpan(1,0,0)
            } },
            { M49.Gabon加蓬 , new M49Info(){
                M49 = M49.Gabon加蓬,
                Flag = "GAB",
                ShortName="Gabon",
                FullName="The Gabonese Republic",
                ChineseShortName="加蓬",
                ChineseFullName="加蓬共和国",
                UTCTimeSpan=new TimeSpan(1,0,0)
            } },
            { M49.SaoTomeandPrincipe圣多美和普林西比 , new M49Info(){
                M49 = M49.SaoTomeandPrincipe圣多美和普林西比,
                Flag = "STP",
                ShortName="Sao Tomeand Principe",
                FullName="The Democratic Republic of Sao Tome and Principe",
                ChineseShortName="圣多美和普林西比",
                ChineseFullName="圣多美和普林西比民主共和国",
                UTCTimeSpan=new TimeSpan(0,0,0)
            } },
#endregion

#region NorthernAfrica北部非洲
		    // NorthernAfrica北部非洲
            { M49.Algeria阿尔及利亚 , new M49Info(){
                M49 = M49.Algeria阿尔及利亚,
                Flag = "DZA",
                ShortName="Algeria",
                FullName="People's Democratic Republic of Algeria",
                ChineseShortName="阿尔及利亚",
                ChineseFullName="阿尔及利亚民主人民共和国",
                UTCTimeSpan=new TimeSpan(1,0,0)
            } },
            { M49.Egypt埃及 , new M49Info(){
                M49 = M49.Egypt埃及,
                Flag = "EGY",
                ShortName="Egypt",
                FullName="The Arab Republic of Egypt",
                ChineseShortName="埃及",
                ChineseFullName="阿拉伯埃及共和国",
                UTCTimeSpan=new TimeSpan(2,0,0)
            } },
            { M49.Libya利比亚 , new M49Info(){
                M49 = M49.Libya利比亚,
                Flag = "LBY",
                ShortName="Libya",
                FullName="State of Libya",
                ChineseShortName="利比亚",
                ChineseFullName="利比亚国",
                UTCTimeSpan=new TimeSpan(2,0,0)
            } },
            { M49.Morocco摩洛哥 , new M49Info(){
                M49 = M49.Morocco摩洛哥,
                Flag = "MAR",
                ShortName="Morocco",
                FullName="The Kingdom of Morocco",
                ChineseShortName="摩洛哥",
                ChineseFullName="摩洛哥王国",
                UTCTimeSpan=new TimeSpan(0,0,0)
            } },
            { M49.Sudan苏丹 , new M49Info(){
                M49 = M49.Sudan苏丹,
                Flag = "SDN",
                ShortName="Sudan",
                FullName="The Republic of Sudan",
                ChineseShortName="苏丹",
                ChineseFullName="苏丹共和国",
                UTCTimeSpan=new TimeSpan(2,0,0)
            } },
            { M49.Tunisia突尼斯 , new M49Info(){
                M49 = M49.Tunisia突尼斯,
                Flag = "TUN",
                ShortName="Tunisia",
                FullName="The Republic of Tunisia",
                ChineseShortName="突尼斯",
                ChineseFullName="突尼斯共和国",
                UTCTimeSpan=new TimeSpan(1,0,0)
            } },
            { M49.WesternSahara西撒哈拉 , new M49Info(){
                M49 = M49.WesternSahara西撒哈拉,
                Flag = "EH",
                ShortName="Western Sahara",
                FullName="the Sahrawi Arab Democratic Republic",
                ChineseShortName="西撒哈拉",
                ChineseFullName="阿拉伯撒哈拉民主共和国",
                UTCTimeSpan=new TimeSpan(0,0,0)
            } },
#endregion

#region SouthernAfrica南部非洲
            // SouthernAfrica南部非洲
            { M49.Botswana博茨瓦纳 , new M49Info(){
                M49 = M49.Botswana博茨瓦纳,
                Flag = "BWA",
                ShortName="Botswana",
                FullName="The Republic of Botswana",
                ChineseShortName="博茨瓦纳",
                ChineseFullName="博茨瓦纳共和国",
                UTCTimeSpan=new TimeSpan(2,0,0)
            } },
            { M49.Lesotho莱索托 , new M49Info(){
                M49 = M49.Lesotho莱索托,
                Flag = "LSO",
                ShortName="Lesotho",
                FullName="The Kingdom of Lesotho",
                ChineseShortName="莱索托",
                ChineseFullName="莱索托王国",
                UTCTimeSpan=new TimeSpan(2,0,0)
            } },
            { M49.Namibia纳米比亚 , new M49Info(){
                M49 = M49.Namibia纳米比亚,
                Flag = "NAM",
                ShortName="Namibia",
                FullName="The Republic of Namibia",
                ChineseShortName="纳米比亚",
                ChineseFullName="纳米比亚共和国",
                UTCTimeSpan=new TimeSpan(2,0,0)
            } },
            { M49.SouthAfrica南非 , new M49Info(){
                M49 = M49.SouthAfrica南非,
                Flag = "RSA",
                ShortName="SouthAfrica",
                FullName="The Republic of South Africa",
                ChineseShortName="南非",
                ChineseFullName="南非共和国",
                UTCTimeSpan=new TimeSpan(2,0,0)
            } },
            { M49.Swaziland斯威士兰 , new M49Info(){
                M49 = M49.Swaziland斯威士兰,
                Flag = "SWZ",
                ShortName="Swaziland",
                FullName="The Kingdom of Swaziland",
                ChineseShortName="斯威士兰",
                ChineseFullName="斯威士兰王国",
                UTCTimeSpan=new TimeSpan(2,0,0)
            } },
#endregion

#region WesternAfrica西部非洲
            // WesternAfrica西部非洲
            { M49.Benin贝宁 , new M49Info(){
                M49 = M49.Benin贝宁,
                Flag = "BEN",
                ShortName="Benin",
                FullName="The Republic of Benin",
                ChineseShortName="贝宁",
                ChineseFullName="贝宁共和国",
                UTCTimeSpan=new TimeSpan(1,0,0)
            } },
            { M49.BurkinaFaso布基纳法索 , new M49Info(){
                M49 = M49.BurkinaFaso布基纳法索,
                Flag = "BFA",
                ShortName="Burkina Faso",
                FullName="Burkina Faso",
                ChineseShortName="布基纳法索",
                ChineseFullName="布基纳法索",
                UTCTimeSpan=new TimeSpan(0,0,0)
            } },
            { M49.CaboVerde佛得角 , new M49Info(){
                M49 = M49.CaboVerde佛得角,
                Flag = "CPV",
                ShortName="Cabo Verde",
                FullName="Republic of Cape Verde",
                ChineseShortName="佛得角",
                ChineseFullName="佛得角共和国",
                UTCTimeSpan=new TimeSpan(-1,0,0)
            } },
            { M49.CotedIvoire科特迪瓦 , new M49Info(){
                M49 = M49.CotedIvoire科特迪瓦,
                Flag = "CIV",
                ShortName="Coted Ivoire",
                FullName="The Republic of Côte d'Ivoire",
                ChineseShortName="科特迪瓦",
                ChineseFullName="科特迪瓦共和国",
                UTCTimeSpan=new TimeSpan(0,0,0)
            } },
            { M49.Gambia冈比亚 , new M49Info(){
                M49 = M49.Gambia冈比亚,
                Flag = "GMB",
                ShortName="Gambia",
                FullName="Republic of The Gambia",
                ChineseShortName="冈比亚",
                ChineseFullName="冈比亚共和国",
                UTCTimeSpan=new TimeSpan(0,0,0)
            } },//5
            { M49.Ghana加纳 , new M49Info(){
                M49 = M49.Ghana加纳,
                Flag = "GHA",
                ShortName="Ghana",
                FullName="The Republic of Ghana",
                ChineseShortName="加纳",
                ChineseFullName="加纳共和国",
                UTCTimeSpan=new TimeSpan(0,0,0)
            } },
            { M49.Guinea几内亚 , new M49Info(){
                M49 = M49.Guinea几内亚,
                Flag = "GIN",
                ShortName="Guinea",
                FullName="The Republic of Guinea",
                ChineseShortName="几内亚",
                ChineseFullName="几内亚共和国",
                UTCTimeSpan=new TimeSpan(0,0,0)
            } },
            { M49.GuineaBissau几内亚比绍 , new M49Info(){
                M49 = M49.GuineaBissau几内亚比绍,
                Flag = "GNB",
                ShortName="Guinea-Bissau",
                FullName="The Republic of Guinea-Bissau",
                ChineseShortName="几内亚比绍",
                ChineseFullName="几内亚比绍共和国",
                UTCTimeSpan=new TimeSpan(0,0,0)
            } },
            { M49.Liberia利比里亚 , new M49Info(){
                M49 = M49.Liberia利比里亚,
                Flag = "LBR",
                ShortName="Liberia",
                FullName="The Republic of Liberia",
                ChineseShortName="利比里亚",
                ChineseFullName="利比里亚共和国",
                UTCTimeSpan=new TimeSpan(0,0,0)
            } },
            { M49.Mali马里 , new M49Info(){
                M49 = M49.Mali马里,
                Flag = "MLI",
                ShortName="Mali",
                FullName="The Republic of Mali",
                ChineseShortName="马里",
                ChineseFullName="马里共和国",
                UTCTimeSpan=new TimeSpan(0,0,0)
            } },//10
            { M49.Mauritania毛里塔尼亚 , new M49Info(){
                M49 = M49.Mauritania毛里塔尼亚,
                Flag = "MRT",
                ShortName="Mauritania",
                FullName="The Islamic Republic of Mauritania",
                ChineseShortName="毛里塔尼亚",
                ChineseFullName="毛里塔尼亚伊斯兰共和国",
                UTCTimeSpan=new TimeSpan(0,0,0)
            } },
            { M49.Niger尼日尔 , new M49Info(){
                M49 = M49.Niger尼日尔,
                Flag = "NER",
                ShortName="Niger",
                FullName="The Republic of Niger",
                ChineseShortName="尼日尔",
                ChineseFullName="尼日尔共和国",
                UTCTimeSpan=new TimeSpan(1,0,0)
            } },
            { M49.Nigeria尼日利亚 , new M49Info(){
                M49 = M49.Nigeria尼日利亚,
                Flag = "NGA",
                ShortName="Nigeria",
                FullName="Federal Republic of Nigeria",
                ChineseShortName="尼日利亚",
                ChineseFullName="尼日利亚联邦共和国",
                UTCTimeSpan=new TimeSpan(1,0,0)
            } },
            { M49.SaintHelena圣赫勒拿 , new M49Info(){
                M49 = M49.SaintHelena圣赫勒拿,
                Flag = "SHN",
                ShortName="Saint Helena",
                FullName="Saint Helena",
                ChineseShortName="圣赫勒拿",
                ChineseFullName="圣赫勒拿岛",
                UTCTimeSpan=new TimeSpan(0,0,0)
            } },
            { M49.Senegal塞内加尔 , new M49Info(){
                M49 = M49.Senegal塞内加尔,
                Flag = "SEN",
                ShortName="Senegal",
                FullName="Republic of Senegal",
                ChineseShortName="塞内加尔",
                ChineseFullName="塞内加尔共和国",
                UTCTimeSpan=new TimeSpan(0,0,0)
            } },//15
            { M49.SierraLeone塞拉利昂 , new M49Info(){
                M49 = M49.SierraLeone塞拉利昂,
                Flag = "SLE",
                ShortName="Sierra Leone",
                FullName="The Republic of Sierra Leone",
                ChineseShortName="塞拉利昂",
                ChineseFullName="塞拉利昂共和国",
                UTCTimeSpan=new TimeSpan(0,0,0)
            } },
            { M49.Togo多哥 , new M49Info(){
                M49 = M49.Togo多哥,
                Flag = "TGO",
                ShortName="Togo",
                FullName="The Republic of Togo",
                ChineseShortName="多哥",
                ChineseFullName="多哥共和国",
                UTCTimeSpan=new TimeSpan(0,0,0)
            } },
#endregion


        };
    }
}
