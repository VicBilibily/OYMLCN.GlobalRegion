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
        /// 缩写代码(国家代码)[ISO3166/ShortCode]
        /// </summary>
        public string ISO3166 { get; internal set; }
        /// <summary>
        /// 国际电话区号
        /// </summary>
        public string CallingCode { get; internal set; }

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
        public DateTime TimeIs => DateTime.UtcNow + UTCTimeSpan;

    }

    public static partial class Data
    {
        public static IReadOnlyDictionary<M49, M49Info> M49Infos = new Dictionary<M49, M49Info>()
        {
#region EasternAfrica东部非洲
		    // EasternAfrica东部非洲
            { M49.Burundi布隆迪 , new M49Info(){
                M49 = M49.Burundi布隆迪,
                ISO3166 = "BI",
                CallingCode = "+257",
                ShortName = "Burundi",
                FullName = "Republic of Burundi",
                ChineseShortName = "布隆迪",
                ChineseFullName = "布隆迪共和国",
                UTCTimeSpan = new TimeSpan(2,0,0)
            } },
            { M49.Comoros科摩罗 , new M49Info(){
                M49 = M49.Comoros科摩罗,
                ISO3166 = "KM",
                CallingCode = "+269",
                ShortName = "Comoros",
                FullName = "Union of the Comoros",
                ChineseShortName = "科摩罗",
                ChineseFullName = "科摩罗伊斯兰联邦共和国",
                UTCTimeSpan = new TimeSpan(3,0,0)
            } },
            { M49.Djibouti吉布提 , new M49Info(){
                M49 = M49.Djibouti吉布提,
                ISO3166 = "DJ",
                CallingCode = "+253",
                ShortName = "Djibouti",
                FullName = "Republic of Djibouti",
                ChineseShortName = "吉布提",
                ChineseFullName = "吉布提共和国",
                UTCTimeSpan = new TimeSpan(3,0,0)
            } },
            { M49.Eritrea厄立特里亚 , new M49Info(){
                M49 = M49.Eritrea厄立特里亚,
                ISO3166 = "ER",
                CallingCode = "+291",
                ShortName = "Eritrea",
                FullName = "State of Eritrea",
                ChineseShortName = "厄立特里亚",
                ChineseFullName = "厄立特里亚国",
                UTCTimeSpan = new TimeSpan(3,0,0)
            } },
            { M49.Ethiopia埃塞俄比亚 , new M49Info(){
                M49 = M49.Ethiopia埃塞俄比亚,
                ISO3166 = "ET",
                CallingCode = "+251",
                ShortName = "Ethiopia",
                FullName = "Federal Democratic Republic of Ethiopia",
                ChineseShortName = "埃塞俄比亚",
                ChineseFullName = "埃塞俄比亚联邦民主共和国",
                UTCTimeSpan = new TimeSpan(3,0,0)
            } },//5
            { M49.Kenya肯尼亚 , new M49Info(){
                M49 = M49.Kenya肯尼亚,
                ISO3166 = "KE",
                CallingCode = "+254",
                ShortName = "Kenya",
                FullName = "Republic of Kenya",
                ChineseShortName = "肯尼亚",
                ChineseFullName = "肯尼亚共和国",
                UTCTimeSpan = new TimeSpan(3,0,0)
            } },
            { M49.Madagascar马达加斯加 , new M49Info(){
                M49 = M49.Madagascar马达加斯加,
                ISO3166 = "MG",
                CallingCode = "+261",
                ShortName = "Madagascar",
                FullName = "Republic of Madagascar",
                ChineseShortName = "马达加斯加",
                ChineseFullName = "马达加斯加共和国",
                UTCTimeSpan = new TimeSpan(3,0,0)
            } },
            { M49.Malawi马拉维 , new M49Info(){
                M49 = M49.Malawi马拉维,
                ISO3166 = "MW",
                CallingCode = "+265",
                ShortName = "Malawi",
                FullName = "Republic of Malawi",
                ChineseShortName = "马拉维",
                ChineseFullName = "马拉维共和国",
                UTCTimeSpan = new TimeSpan(2,0,0)
            } },
            { M49.Mauritius毛里求斯 , new M49Info(){
                M49 = M49.Mauritius毛里求斯,
                ISO3166 = "MU",
                CallingCode = "+230",
                ShortName = "Mauritius",
                FullName = "Republic of Mauritius",
                ChineseShortName = "毛里求斯",
                ChineseFullName = "毛里求斯共和国",
                UTCTimeSpan = new TimeSpan(4,0,0)
            } },
            { M49.Mayotte马约特 , new M49Info(){
                M49 = M49.Mayotte马约特,
                ISO3166 = "YT",
                CallingCode = "+262",
                ShortName = "Mayotte",
                FullName = "Territorial Collectivity of Mayotte",
                ChineseShortName = "马约特",
                ChineseFullName = "马约特岛",
                UTCTimeSpan = new TimeSpan(3,0,0)
            } },//10
            { M49.Mozambique莫桑比克 , new M49Info(){
                M49 = M49.Mozambique莫桑比克,
                ISO3166 = "MZ",
                CallingCode = "+258",
                ShortName = "Mozambique",
                FullName = "Republic of Mozambique",
                ChineseShortName = "莫桑比克",
                ChineseFullName = "莫桑比克共和国",
                UTCTimeSpan = new TimeSpan(2,0,0)
            } },
            { M49.Reunion留尼汪 , new M49Info(){
                M49 = M49.Reunion留尼汪,
                ISO3166 = "RE",
                CallingCode = "+262",
                ShortName = "Reunion",
                FullName = "Reunion Island",
                ChineseShortName = "留尼汪",
                ChineseFullName = "留尼汪岛",
                UTCTimeSpan = new TimeSpan(4,0,0)
            } },
            { M49.Rwanda卢旺达 , new M49Info(){
                M49 = M49.Rwanda卢旺达,
                ISO3166 = "RW",
                CallingCode = "+250",
                ShortName = "Rwanda",
                FullName = "Republic of Rwanda",
                ChineseShortName = "卢旺达",
                ChineseFullName = "卢旺达共和国",
                UTCTimeSpan = new TimeSpan(2,0,0)
            } },
            { M49.Seychelles塞舌尔 , new M49Info(){
                M49 = M49.Seychelles塞舌尔,
                ISO3166 = "SC",
                CallingCode = "+248",
                ShortName = "Seychelles",
                FullName = "Republic of Seychelles",
                ChineseShortName = "塞舌尔",
                ChineseFullName = "塞舌尔共和国",
                UTCTimeSpan = new TimeSpan(4,0,0)
            } },
            { M49.Somalia索马里 , new M49Info(){
                M49 = M49.Somalia索马里,
                ISO3166 = "SO",
                CallingCode = "+252",
                ShortName = "Somalia",
                FullName = "Federal Republic of Somalia",
                ChineseShortName = "索马里",
                ChineseFullName = "索马里联邦共和国",
                UTCTimeSpan = new TimeSpan(3,0,0)
            } },//15
            { M49.SouthSudan南苏丹 , new M49Info(){
                M49 = M49.SouthSudan南苏丹,
                ISO3166 = "SS",
                CallingCode = "+211",
                ShortName = "South Sudan",
                FullName = "Republic of South Sudan",
                ChineseShortName = "南苏丹",
                ChineseFullName = "南苏丹共和国",
                UTCTimeSpan = new TimeSpan(3,0,0)
            } },
            { M49.Uganda乌干达 , new M49Info(){
                M49 = M49.Uganda乌干达,
                ISO3166 = "UGA",
                CallingCode = "+256",
                ShortName = "Uganda",
                FullName = "Republic of Uganda",
                ChineseShortName = "乌干达",
                ChineseFullName = "乌干达共和国",
                UTCTimeSpan = new TimeSpan(3,0,0)
            } },
            { M49.Tanzania坦桑尼亚 , new M49Info(){
                M49 = M49.Tanzania坦桑尼亚,
                ISO3166 = "TZ",
                CallingCode = "+255",
                ShortName = "Tanzania",
                FullName = "United Republic of Tanzania",
                ChineseShortName = "坦桑尼亚",
                ChineseFullName = "坦桑尼亚联合共和国",
                UTCTimeSpan = new TimeSpan(3,0,0)
            } },
            { M49.Zambia赞比亚 , new M49Info(){
                M49 = M49.Zambia赞比亚,
                ISO3166 = "ZM",
                CallingCode = "+260",
                ShortName = "Zambia",
                FullName = "Republic of Zambia",
                ChineseShortName = "赞比亚",
                ChineseFullName = "赞比亚共和国",
                UTCTimeSpan = new TimeSpan(2,0,0)
            } },
            { M49.Zimbabwe津巴布韦 , new M49Info(){
                M49 = M49.Zimbabwe津巴布韦,
                ISO3166 = "ZW",
                CallingCode = "+263",
                ShortName = "Zimbabwe",
                FullName = "Republic of Zimbabwe",
                ChineseShortName = "津巴布韦",
                ChineseFullName = "津巴布韦共和国",
                UTCTimeSpan = new TimeSpan(2,0,0)
            } },//20
#endregion

#region MiddleAfrica中部非洲
		    // MiddleAfrica中部非洲
            { M49.Angola安哥拉 , new M49Info(){
                M49 = M49.Angola安哥拉,
                ISO3166 = "AO",
                CallingCode = "+244",
                ShortName = "Angola",
                FullName = "Republic of Angola",
                ChineseShortName = "安哥拉",
                ChineseFullName = "安哥拉共和国",
                UTCTimeSpan = new TimeSpan(1,0,0)
            } },
            { M49.Cameroon喀麦隆 , new M49Info(){
                M49 = M49.Cameroon喀麦隆,
                ISO3166 = "CM",
                CallingCode = "+237",
                ShortName = "Cameroon",
                FullName = "Republic of Cameroon",
                ChineseShortName = "喀麦隆",
                ChineseFullName = "喀麦隆共和国",
                UTCTimeSpan = new TimeSpan(1,0,0)
            } },
            { M49.CentralAfricanRepublic中非共和国 , new M49Info(){
                M49 = M49.CentralAfricanRepublic中非共和国,
                ISO3166 = "CF",
                CallingCode = "+236",
                ShortName = "Central African",
                FullName = "Central African Republic",
                ChineseShortName = "中非",
                ChineseFullName = "中非共和国",
                UTCTimeSpan = new TimeSpan(1,0,0)
            } },
            { M49.Chad乍得 , new M49Info(){
                M49 = M49.Chad乍得,
                ISO3166 = "TD",
                CallingCode = "+235",
                ShortName = "Chad",
                FullName = "Republic of Chad",
                ChineseShortName = "乍得",
                ChineseFullName = "乍得共和国",
                UTCTimeSpan = new TimeSpan(1,0,0)
            } },
            { M49.Congo刚果 , new M49Info(){
                M49 = M49.Congo刚果,
                ISO3166 = "CG",
                CallingCode = "+242",
                ShortName = "Congo",
                FullName = "Republic of Congo",
                ChineseShortName = "刚果（布）",
                ChineseFullName = "刚果共和国",
                UTCTimeSpan = new TimeSpan(1,0,0)
            } },//5
            { M49.RDCongo刚果民主共和国 , new M49Info(){
                M49 = M49.RDCongo刚果民主共和国,
                ISO3166 = "CD",
                CallingCode = "+243",
                ShortName = "RD Congo",
                FullName = "Democratic Republic of the Congo",
                ChineseShortName = "刚果（金）",
                ChineseFullName = "刚果民主共和国",
                UTCTimeSpan = new TimeSpan(2,0,0)
            } },
            { M49.EquatorialGuinea赤道几内亚 , new M49Info(){
                M49 = M49.EquatorialGuinea赤道几内亚,
                ISO3166 = "GQ",
                CallingCode = "+240",
                ShortName = "Equatorial Guinea",
                FullName = "Republic of Equatorial Guinea",
                ChineseShortName = "赤道几内亚",
                ChineseFullName = "赤道几内亚共和国",
                UTCTimeSpan = new TimeSpan(1,0,0)
            } },
            { M49.Gabon加蓬 , new M49Info(){
                M49 = M49.Gabon加蓬,
                ISO3166 = "GA",
                CallingCode = "+241",
                ShortName = "Gabon",
                FullName = "Gabonese Republic",
                ChineseShortName = "加蓬",
                ChineseFullName = "加蓬共和国",
                UTCTimeSpan = new TimeSpan(1,0,0)
            } },
            { M49.SaoTomeandPrincipe圣多美和普林西比 , new M49Info(){
                M49 = M49.SaoTomeandPrincipe圣多美和普林西比,
                ISO3166 = "ST",
                CallingCode = "+239",
                ShortName = "São Tomé and Príncipe",
                FullName = "The Democratic Republic of São Tomé and Príncipe",
                ChineseShortName = "圣多美和普林西比",
                ChineseFullName = "圣多美和普林西比民主共和国",
                UTCTimeSpan = new TimeSpan(0,0,0)
            } },
#endregion

#region NorthernAfrica北部非洲
		    // NorthernAfrica北部非洲
            { M49.Algeria阿尔及利亚 , new M49Info(){
                M49 = M49.Algeria阿尔及利亚,
                ISO3166 = "DZ",
                CallingCode = "+213",
                ShortName = "Algeria",
                FullName = "People's Democratic Republic of Algeria",
                ChineseShortName = "阿尔及利亚",
                ChineseFullName = "阿尔及利亚民主人民共和国",
                UTCTimeSpan = new TimeSpan(1,0,0)
            } },
            { M49.Egypt埃及 , new M49Info(){
                M49 = M49.Egypt埃及,
                ISO3166 = "EG",
                CallingCode = "+020",
                ShortName = "Egypt",
                FullName = "Arab Republic of Egypt",
                ChineseShortName = "埃及",
                ChineseFullName = "阿拉伯埃及共和国",
                UTCTimeSpan = new TimeSpan(2,0,0)
            } },
            { M49.Libya利比亚 , new M49Info(){
                M49 = M49.Libya利比亚,
                ISO3166 = "LY",
                CallingCode = "+218",
                ShortName = "Libya",
                FullName = "State of Libya",
                ChineseShortName = "利比亚",
                ChineseFullName = "利比亚国",
                UTCTimeSpan = new TimeSpan(2,0,0)
            } },
            { M49.Morocco摩洛哥 , new M49Info(){
                M49 = M49.Morocco摩洛哥,
                ISO3166 = "MA",
                CallingCode = "+212",
                ShortName = "Morocco",
                FullName = "Kingdom of Morocco",
                ChineseShortName = "摩洛哥",
                ChineseFullName = "摩洛哥王国",
                UTCTimeSpan = new TimeSpan(0,0,0)
            } },
            { M49.Sudan苏丹 , new M49Info(){
                M49 = M49.Sudan苏丹,
                ISO3166 = "SD",
                CallingCode = "+249",
                ShortName = "Sudan",
                FullName = "Republic of Sudan",
                ChineseShortName = "苏丹",
                ChineseFullName = "苏丹共和国",
                UTCTimeSpan = new TimeSpan(2,0,0)
            } },
            { M49.Tunisia突尼斯 , new M49Info(){
                M49 = M49.Tunisia突尼斯,
                ISO3166 = "TN",
                CallingCode = "+216",
                ShortName = "Tunisia",
                FullName = "Republic of Tunisia",
                ChineseShortName = "突尼斯",
                ChineseFullName = "突尼斯共和国",
                UTCTimeSpan = new TimeSpan(1,0,0)
            } },
            { M49.WesternSahara西撒哈拉 , new M49Info(){
                M49 = M49.WesternSahara西撒哈拉,
                ISO3166 = "EH",
                CallingCode = "+210",
                ShortName = "Western Sahara",
                FullName = "Sahrawi Arab Democratic Republic",
                ChineseShortName = "西撒哈拉",
                ChineseFullName = "阿拉伯撒哈拉民主共和国",
                UTCTimeSpan = new TimeSpan(0,0,0)
            } },
#endregion

#region SouthernAfrica南部非洲
            // SouthernAfrica南部非洲
            { M49.Botswana博茨瓦纳 , new M49Info(){
                M49 = M49.Botswana博茨瓦纳,
                ISO3166 = "BW",
                CallingCode = "+267",
                ShortName = "Botswana",
                FullName = "Republic of Botswana",
                ChineseShortName = "博茨瓦纳",
                ChineseFullName = "博茨瓦纳共和国",
                UTCTimeSpan = new TimeSpan(2,0,0)
            } },
            { M49.Lesotho莱索托 , new M49Info(){
                M49 = M49.Lesotho莱索托,
                ISO3166 = "LS",
                CallingCode = "+266",
                ShortName = "Lesotho",
                FullName = "Kingdom of Lesotho",
                ChineseShortName = "莱索托",
                ChineseFullName = "莱索托王国",
                UTCTimeSpan = new TimeSpan(2,0,0)
            } },
            { M49.Namibia纳米比亚 , new M49Info(){
                M49 = M49.Namibia纳米比亚,
                ISO3166 = "NA",
                CallingCode = "+264",
                ShortName = "Namibia",
                FullName = "Republic of Namibia",
                ChineseShortName = "纳米比亚",
                ChineseFullName = "纳米比亚共和国",
                UTCTimeSpan = new TimeSpan(2,0,0)
            } },
            { M49.SouthAfrica南非 , new M49Info(){
                M49 = M49.SouthAfrica南非,
                ISO3166 = "ZA",
                CallingCode = "+027",
                ShortName = "South Africa",
                FullName = "Republic of South Africa",
                ChineseShortName = "南非",
                ChineseFullName = "南非共和国",
                UTCTimeSpan = new TimeSpan(2,0,0)
            } },
            { M49.Swaziland斯威士兰 , new M49Info(){
                M49 = M49.Swaziland斯威士兰,
                ISO3166 = "SZ",
                CallingCode = "+268",
                ShortName = "Swaziland",
                FullName = "Kingdom of Swaziland",
                ChineseShortName = "斯威士兰",
                ChineseFullName = "斯威士兰王国",
                UTCTimeSpan = new TimeSpan(2,0,0)
            } },
#endregion

#region WesternAfrica西部非洲
            // WesternAfrica西部非洲
            { M49.Benin贝宁 , new M49Info(){
                M49 = M49.Benin贝宁,
                ISO3166 = "BJ",
                CallingCode = "+229",
                ShortName = "Benin",
                FullName = "Republic of Benin",
                ChineseShortName = "贝宁",
                ChineseFullName = "贝宁共和国",
                UTCTimeSpan = new TimeSpan(1,0,0)
            } },
            { M49.BurkinaFaso布基纳法索 , new M49Info(){
                M49 = M49.BurkinaFaso布基纳法索,
                ISO3166 = "BF",
                CallingCode = "+226",
                ShortName = "Burkina Faso",
                FullName = "Burkina Faso",
                ChineseShortName = "布基纳法索",
                ChineseFullName = "布基纳法索",
                UTCTimeSpan = new TimeSpan(0,0,0)
            } },
            { M49.CaboVerde佛得角 , new M49Info(){
                M49 = M49.CaboVerde佛得角,
                ISO3166 = "CV",
                CallingCode = "+238",
                ShortName = "Cabo Verde",
                FullName = "Republic of Cape Verde",
                ChineseShortName = "佛得角",
                ChineseFullName = "佛得角共和国",
                UTCTimeSpan = new TimeSpan(-1,0,0)
            } },
            { M49.CotedIvoire科特迪瓦 , new M49Info(){
                M49 = M49.CotedIvoire科特迪瓦,
                ISO3166 = "CI",
                CallingCode = "+225",
                ShortName = "Coted Ivoire",
                FullName = "The Republic of Côte d'Ivoire",
                ChineseShortName = "科特迪瓦",
                ChineseFullName = "科特迪瓦共和国",
                UTCTimeSpan = new TimeSpan(0,0,0)
            } },
            { M49.Gambia冈比亚 , new M49Info(){
                M49 = M49.Gambia冈比亚,
                ISO3166 = "GM",
                CallingCode = "+220",
                ShortName = "Gambia",
                FullName = "Republic of the Gambia",
                ChineseShortName = "冈比亚",
                ChineseFullName = "冈比亚共和国",
                UTCTimeSpan = new TimeSpan(0,0,0)
            } },//5
            { M49.Ghana加纳 , new M49Info(){
                M49 = M49.Ghana加纳,
                ISO3166 = "GH",
                CallingCode = "+233",
                ShortName = "Ghana",
                FullName = "Republic of Ghana",
                ChineseShortName = "加纳",
                ChineseFullName = "加纳共和国",
                UTCTimeSpan = new TimeSpan(0,0,0)
            } },
            { M49.Guinea几内亚 , new M49Info(){
                M49 = M49.Guinea几内亚,
                ISO3166 = "GN",
                CallingCode = "+224",
                ShortName = "Guinea",
                FullName = "Republic of Guinea",
                ChineseShortName = "几内亚",
                ChineseFullName = "几内亚共和国",
                UTCTimeSpan = new TimeSpan(0,0,0)
            } },
            { M49.GuineaBissau几内亚比绍 , new M49Info(){
                M49 = M49.GuineaBissau几内亚比绍,
                ISO3166 = "GW",
                CallingCode = "+245",
                ShortName = "Guinea-Bissau",
                FullName = "Republic of Guinea-Bissau",
                ChineseShortName = "几内亚比绍",
                ChineseFullName = "几内亚比绍共和国",
                UTCTimeSpan = new TimeSpan(0,0,0)
            } },
            { M49.Liberia利比里亚 , new M49Info(){
                M49 = M49.Liberia利比里亚,
                ISO3166 = "LR",
                CallingCode = "+231",
                ShortName = "Liberia",
                FullName = "Republic of Liberia",
                ChineseShortName = "利比里亚",
                ChineseFullName = "利比里亚共和国",
                UTCTimeSpan = new TimeSpan(0,0,0)
            } },
            { M49.Mali马里 , new M49Info(){
                M49 = M49.Mali马里,
                ISO3166 = "ML",
                CallingCode = "+223",
                ShortName = "Mali",
                FullName = "Republic of Mali",
                ChineseShortName = "马里",
                ChineseFullName = "马里共和国",
                UTCTimeSpan = new TimeSpan(0,0,0)
            } },//10
            { M49.Mauritania毛里塔尼亚 , new M49Info(){
                M49 = M49.Mauritania毛里塔尼亚,
                ISO3166 = "MR",
                CallingCode = "+222",
                ShortName = "Mauritania",
                FullName = "Islamic Republic of Mauritania",
                ChineseShortName = "毛里塔尼亚",
                ChineseFullName = "毛里塔尼亚伊斯兰共和国",
                UTCTimeSpan = new TimeSpan(0,0,0)
            } },
            { M49.Niger尼日尔 , new M49Info(){
                M49 = M49.Niger尼日尔,
                ISO3166 = "NE",
                CallingCode = "+227",
                ShortName = "Niger",
                FullName = "Republic of the Niger",
                ChineseShortName = "尼日尔",
                ChineseFullName = "尼日尔共和国",
                UTCTimeSpan = new TimeSpan(1,0,0)
            } },
            { M49.Nigeria尼日利亚 , new M49Info(){
                M49 = M49.Nigeria尼日利亚,
                ISO3166 = "NG",
                CallingCode = "+234",
                ShortName = "Nigeria",
                FullName = "Federal Republic of Nigeria",
                ChineseShortName = "尼日利亚",
                ChineseFullName = "尼日利亚联邦共和国",
                UTCTimeSpan = new TimeSpan(1,0,0)
            } },
            { M49.SaintHelena圣赫勒拿 , new M49Info(){
                M49 = M49.SaintHelena圣赫勒拿,
                ISO3166 = "SH",
                CallingCode = "+290",
                ShortName = "Saint Helena",
                FullName = "Saint Helena",
                ChineseShortName = "圣赫勒拿",
                ChineseFullName = "圣赫勒拿岛",
                UTCTimeSpan = new TimeSpan(0,0,0)
            } },
            { M49.Senegal塞内加尔 , new M49Info(){
                M49 = M49.Senegal塞内加尔,
                ISO3166 = "SN",
                CallingCode = "+221",
                ShortName = "Senegal",
                FullName = "Republic of Senegal",
                ChineseShortName = "塞内加尔",
                ChineseFullName = "塞内加尔共和国",
                UTCTimeSpan = new TimeSpan(0,0,0)
            } },//15
            { M49.SierraLeone塞拉利昂 , new M49Info(){
                M49 = M49.SierraLeone塞拉利昂,
                ISO3166 = "SL",
                CallingCode = "+232",
                ShortName = "Sierra Leone",
                FullName = "Republic of Sierra Leone",
                ChineseShortName = "塞拉利昂",
                ChineseFullName = "塞拉利昂共和国",
                UTCTimeSpan = new TimeSpan(0,0,0)
            } },
            { M49.Togo多哥 , new M49Info(){
                M49 = M49.Togo多哥,
                ISO3166 = "TG",
                CallingCode = "+228",
                ShortName = "Togo",
                FullName = "Togolese Republic",
                ChineseShortName = "多哥",
                ChineseFullName = "多哥共和国",
                UTCTimeSpan = new TimeSpan(0,0,0)
            } },
#endregion

#region Caribbean加勒比地区
		    // Caribbean加勒比地区
            { M49.Anguilla安圭拉 , new M49Info(){
                M49 = M49.Anguilla安圭拉,
                ISO3166 = "AI",
                CallingCode = "+001-264",
                ShortName = "Anguilla",
                FullName = "Anguilla",
                ChineseShortName = "安圭拉",
                ChineseFullName = "安圭拉",
                UTCTimeSpan = new TimeSpan(-4,0,0)
            } },
            { M49.AntiguaandBarbuda安提瓜和巴布达 , new M49Info(){
                M49 = M49.AntiguaandBarbuda安提瓜和巴布达,
                ISO3166 = "AG",
                CallingCode = "+001-268",
                ShortName = "Antigua and Barbuda",
                FullName = "Antigua and Barbuda",
                ChineseShortName = "安提瓜和巴布达",
                ChineseFullName = "安提瓜和巴布达",
                UTCTimeSpan = new TimeSpan(-4,0,0)
            } },
            { M49.Aruba阿鲁巴 , new M49Info(){
                M49 = M49.Aruba阿鲁巴,
                ISO3166 = "AW",
                CallingCode = "+297",
                ShortName = "Aruba",
                FullName = "Aruba",
                ChineseShortName = "阿鲁巴",
                ChineseFullName = "阿鲁巴",
                UTCTimeSpan = new TimeSpan(-4,0,0)
            } },
            { M49.Bahamas巴哈马 , new M49Info(){
                M49 = M49.Bahamas巴哈马,
                ISO3166 = "BS",
                CallingCode = "+001-242",
                ShortName = "Bahamas",
                FullName = "Commonwealth of The Bahamas",
                ChineseShortName = "巴哈马",
                ChineseFullName = "巴哈马国",
                UTCTimeSpan = new TimeSpan(-5,0,0)
            } },
            { M49.Barbados巴巴多斯 , new M49Info(){
                M49 = M49.Barbados巴巴多斯,
                ISO3166 = "BB",
                CallingCode = "+001-246",
                ShortName = "Barbados",
                FullName = "Barbados ",
                ChineseShortName = "巴巴多斯",
                ChineseFullName = "巴巴多斯",
                UTCTimeSpan = new TimeSpan(-4,0,0)
            } },//5
            { M49.BonaireSaintEustatiusAndSaba博奈尔圣尤斯特歇斯和萨巴 , new M49Info(){
                M49 = M49.BonaireSaintEustatiusAndSaba博奈尔圣尤斯特歇斯和萨巴,
                ISO3166 = "BQ",
                CallingCode = "+599",
                ShortName = "Caribbean Netherlands",
                FullName = "Bonaire, Saint Eustatius and Saba",
                ChineseShortName = "荷兰加勒比区",
                ChineseFullName = "博奈尔圣尤斯特歇斯和萨巴",
                UTCTimeSpan = new TimeSpan(-4,0,0)
            } },
            { M49.BritishVirginIslands英属维尔京群岛 , new M49Info(){
                M49 = M49.BritishVirginIslands英属维尔京群岛,
                ISO3166 = "VG",
                CallingCode = "+001-284",
                ShortName = "British Virgin Islands",
                FullName = "British Virgin Islands",
                ChineseShortName = "英属维尔京群岛",
                ChineseFullName = "英属维尔京群岛",
                UTCTimeSpan = new TimeSpan(-4,0,0)
            } },
            { M49.CaymanIslands开曼群岛 , new M49Info(){
                M49 = M49.CaymanIslands开曼群岛,
                ISO3166 = "KY",
                CallingCode = "+001-345",
                ShortName = "Cayman Islands",
                FullName = "Cayman Islands",
                ChineseShortName = "开曼群岛",
                ChineseFullName = "开曼群岛",
                UTCTimeSpan = new TimeSpan(-5,0,0)
            } },
            { M49.Cuba古巴 , new M49Info(){
                M49 = M49.Cuba古巴,
                ISO3166 = "CU",
                CallingCode = "+053",
                ShortName = "Cuba",
                FullName = "Republic of Cuba",
                ChineseShortName = "古巴",
                ChineseFullName = "古巴共和国",
                UTCTimeSpan = new TimeSpan(-5,0,0)
            } },
            { M49.Curaçao库拉索 , new M49Info(){
                M49 = M49.Curaçao库拉索,
                ISO3166 = "CW",
                CallingCode = "+599-9",
                ShortName = "Curaçao",
                FullName = "Country of Curaçao",
                ChineseShortName = "库拉索",
                ChineseFullName = "库拉索国",
                UTCTimeSpan = new TimeSpan(-4,0,0)
            } },//10
            { M49.Dominica多米尼克 , new M49Info(){
                M49 = M49.Dominica多米尼克,
                ISO3166 = "DO",
                CallingCode = "+001-809/829/849",
                ShortName = "Dominica",
                FullName = "Commonwealth of Dominica",
                ChineseShortName = "多米尼克",
                ChineseFullName = "多米尼克国",
                UTCTimeSpan = new TimeSpan(-4,0,0)
            } },
            { M49.DominicanRepublic多米尼加共和国 , new M49Info(){
                M49 = M49.DominicanRepublic多米尼加共和国,
                ISO3166 = "DM",
                CallingCode = "+001-767",
                ShortName = "Dominican Republic",
                FullName = "The Dominican Republic",
                ChineseShortName = "多米尼加",
                ChineseFullName = "多米尼加共和国",
                UTCTimeSpan = new TimeSpan(-4,0,0)
            } },
            { M49.Grenada格林纳达 , new M49Info(){
                M49 = M49.Grenada格林纳达,
                ISO3166 = "GD",
                CallingCode = "+001-473",
                ShortName = "Grenada",
                FullName = "Grenada",
                ChineseShortName = "格林纳达",
                ChineseFullName = "格林纳达",
                UTCTimeSpan = new TimeSpan(-4,0,0)
            } },
            { M49.Guadeloupe瓜德罗普 , new M49Info(){
                M49 = M49.Guadeloupe瓜德罗普,
                ISO3166 = "GP",
                CallingCode = "+590",
                ShortName = "Guadeloupe",
                FullName = "Guadeloupe",
                ChineseShortName = "瓜德罗普",
                ChineseFullName = "瓜德罗普",
                UTCTimeSpan = new TimeSpan(-4,0,0)
            } },
            { M49.Haiti海地 , new M49Info(){
                M49 = M49.Haiti海地,
                ISO3166 = "HT",
                CallingCode = "+509",
                ShortName = "Haiti",
                FullName = "Republic of Haiti",
                ChineseShortName = "海地",
                ChineseFullName = "海地共和国",
                UTCTimeSpan = new TimeSpan(-5,0,0)
            } },//15
            { M49.Jamaica牙买加 , new M49Info(){
                M49 = M49.Jamaica牙买加,
                ISO3166 = "JM",
                CallingCode = "+001-658",
                ShortName = "Jamaica",
                FullName = "Jamaica",
                ChineseShortName = "牙买加",
                ChineseFullName = "牙买加",
                UTCTimeSpan = new TimeSpan(-5,0,0)
            } },
            { M49.Martinique马提尼克 , new M49Info(){
                M49 = M49.Martinique马提尼克,
                ISO3166 = "MQ",
                CallingCode = "+596",
                ShortName = "Martinique",
                FullName = "Martinique",
                ChineseShortName = "马提尼克",
                ChineseFullName = "马提尼克岛",
                UTCTimeSpan = new TimeSpan(-4,0,0)
            } },
            { M49.Montserrat蒙特塞拉特 , new M49Info(){
                M49 = M49.Montserrat蒙特塞拉特,
                ISO3166 = "MS",
                CallingCode = "+001-664",
                ShortName = "Montserrat",
                FullName = "Montserrat",
                ChineseShortName = "蒙特塞拉特",
                ChineseFullName = "蒙特塞拉特岛",
                UTCTimeSpan = new TimeSpan(-4,0,0)
            } },
            { M49.PuertoRico波多黎各 , new M49Info(){
                M49 = M49.PuertoRico波多黎各,
                ISO3166 = "PR",
                CallingCode = "+001-787/939",
                ShortName = "Puerto Rico",
                FullName = "Commonwealth of Puerto Rico",
                ChineseShortName = "波多黎各",
                ChineseFullName = "波多黎各自由邦",
                UTCTimeSpan = new TimeSpan(-4,0,0)
            } },
            { M49.SaintBarts圣巴泰勒米 , new M49Info(){
                M49 = M49.SaintBarts圣巴泰勒米,
                ISO3166 = "BL",
                CallingCode = "+590",
                ShortName = "Saint Barts",
                FullName = "Collectivity of Saint-Barthélemy",
                ChineseShortName = "圣巴泰勒米",
                ChineseFullName = "圣巴泰勒米岛",
                UTCTimeSpan = new TimeSpan(-4,0,0)
            } },//20
            { M49.SaintKittsandNevis圣基茨和尼维斯 , new M49Info(){
                M49 = M49.SaintKittsandNevis圣基茨和尼维斯,
                ISO3166 = "KN",
                CallingCode = "+001-869",
                ShortName = "Saint Kitts and Nevis",
                FullName = "The Federation of Saint Kitts and Nevis",
                ChineseShortName = "圣基茨和尼维斯",
                ChineseFullName = "圣基茨和尼维斯联邦",
                UTCTimeSpan = new TimeSpan(-4,0,0)
            } },
            { M49.SaintLucia圣卢西亚 , new M49Info(){
                M49 = M49.SaintLucia圣卢西亚,
                ISO3166 = "LC",
                CallingCode = "+001-758",
                ShortName = "Saint Lucia",
                FullName = "Saint Lucia",
                ChineseShortName = "圣卢西亚",
                ChineseFullName = "圣卢西亚",
                UTCTimeSpan = new TimeSpan(-4,0,0)
            } },
            { M49.SaintMartin圣马丁法属部分 , new M49Info(){
                M49 = M49.SaintMartin圣马丁法属部分,
                ISO3166 = "MF",
                CallingCode = "+590",
                ShortName = "Saint Martin",
                FullName = "Saint Martin",
                ChineseShortName = "圣马丁法属部分",
                ChineseFullName = "圣马丁法属部分",
                UTCTimeSpan = new TimeSpan(-4,0,0)
            } },
            { M49.SaintVincentandtheGrenadines圣文森特和格林纳丁斯 , new M49Info(){
                M49 = M49.SaintVincentandtheGrenadines圣文森特和格林纳丁斯,
                ISO3166 = "VC",
                CallingCode = "+001-784",
                ShortName = "Saint Vincent and the Grenadines",
                FullName = "Saint Vincent and the Grenadines",
                ChineseShortName = "圣文森特和格林纳丁斯",
                ChineseFullName = "圣文森特和格林纳丁斯",
                UTCTimeSpan = new TimeSpan(-4,0,0)
            } },
            { M49.SintMaarten圣马丁荷属部分 , new M49Info(){
                M49 = M49.SintMaarten圣马丁荷属部分,
                ISO3166 = "SX",
                CallingCode = "+001-721",
                ShortName = "Sint Maarten",
                FullName = "Sint Maarten",
                ChineseShortName = "圣马丁荷属部分",
                ChineseFullName = "圣马丁荷属部分",
                UTCTimeSpan = new TimeSpan(-4,0,0)
            } },//25
            { M49.TrinidadandTobago特立尼达和多巴哥 , new M49Info(){
                M49 = M49.TrinidadandTobago特立尼达和多巴哥,
                ISO3166 = "TT",
                CallingCode = "+001-868",
                ShortName = "Trinidad and Tobago",
                FullName = "Republic of Trinidad and Tobago",
                ChineseShortName = "特立尼达和多巴哥",
                ChineseFullName = "特立尼达和多巴哥共和国",
                UTCTimeSpan = new TimeSpan(-4,0,0)
            } },
            { M49.TurksandCaicosIslands特克斯和凯科斯群岛 , new M49Info(){
                M49 = M49.TurksandCaicosIslands特克斯和凯科斯群岛,
                ISO3166 = "TC",
                CallingCode = "+001-649",
                ShortName = "Turks and Caicos Islands",
                FullName = "Turks and Caicos Islands",
                ChineseShortName = "特克斯和凯科斯群岛",
                ChineseFullName = "特克斯和凯科斯群岛",
                UTCTimeSpan = new TimeSpan(-5,0,0)
            } },
            { M49.UnitedStatesVirginIslands美属维尔京群岛 , new M49Info(){
                M49 = M49.UnitedStatesVirginIslands美属维尔京群岛,
                ISO3166 = "VI",
                CallingCode = "+001-340",
                ShortName = "United States Virgin Islands",
                FullName = "Virgin Islands of the United States",
                ChineseShortName = "美属维尔京群岛",
                ChineseFullName = "美属维尔京群岛",
                UTCTimeSpan = new TimeSpan(-4,0,0)
            } },
#endregion

#region CentralAmerica中美洲
            // CentralAmerica中美洲
            { M49.Belize伯利兹 , new M49Info(){
                M49 = M49.Belize伯利兹,
                ISO3166 = "BZ",
                CallingCode = "+501",
                ShortName = "Belize",
                FullName = "Belize",
                ChineseShortName = "伯利兹",
                ChineseFullName = "伯利兹",
                UTCTimeSpan = new TimeSpan(-6,0,0)
            } },
            { M49.CostaRica哥斯达黎加 , new M49Info(){
                M49 = M49.CostaRica哥斯达黎加,
                ISO3166 = "CR",
                CallingCode = "+506",
                ShortName = "Costa Rica",
                FullName = "Republic of Costa Rica",
                ChineseShortName = "哥斯达黎加",
                ChineseFullName = "哥斯达黎加共和国",
                UTCTimeSpan = new TimeSpan(-6,0,0)
            } },
            { M49.ElSalvador萨尔瓦多 , new M49Info(){
                M49 = M49.ElSalvador萨尔瓦多,
                ISO3166 = "SV",
                CallingCode = "+503",
                ShortName = "El Salvador",
                FullName = "Republic of El Salvador",
                ChineseShortName = "萨尔瓦多",
                ChineseFullName = "萨尔瓦多共和国",
                UTCTimeSpan = new TimeSpan(-6,0,0)
            } },
            { M49.Guatemala危地马拉 , new M49Info(){
                M49 = M49.Guatemala危地马拉,
                ISO3166 = "GT",
                CallingCode = "+502",
                ShortName = "Guatemala",
                FullName = "Republic of Guatemala",
                ChineseShortName = "危地马拉",
                ChineseFullName = "危地马拉共和国",
                UTCTimeSpan = new TimeSpan(-6,0,0)
            } },
            { M49.Honduras洪都拉斯 , new M49Info(){
                M49 = M49.Honduras洪都拉斯,
                ISO3166 = "HN",
                CallingCode = "+504",
                ShortName = "Honduras",
                FullName = "Republic of Honduras",
                ChineseShortName = "洪都拉斯",
                ChineseFullName = "洪都拉斯共和国",
                UTCTimeSpan = new TimeSpan(-6,0,0)
            } },
            { M49.Mexico墨西哥 , new M49Info(){
                M49 = M49.Mexico墨西哥,
                ISO3166 = "MX",
                CallingCode = "+052",
                ShortName = "Mexico",
                FullName = "United States of Mexico",
                ChineseShortName = "墨西哥",
                ChineseFullName = "墨西哥合众国",
                UTCTimeSpan = new TimeSpan(-6,0,0)
            } },
            { M49.Nicaragua尼加拉瓜 , new M49Info(){
                M49 = M49.Nicaragua尼加拉瓜,
                ISO3166 = "NI",
                CallingCode = "+505",
                ShortName = "Nicaragua",
                FullName = "Republic of Nicaragua",
                ChineseShortName = "尼加拉瓜",
                ChineseFullName = "尼加拉瓜共和国",
                UTCTimeSpan = new TimeSpan(-6,0,0)
            } },
            { M49.Panama巴拿马 , new M49Info(){
                M49 = M49.Panama巴拿马,
                ISO3166 = "PA",
                CallingCode = "+507",
                ShortName = "Panama",
                FullName = "Republic of Panama",
                ChineseShortName = "巴拿马",
                ChineseFullName = "尼加拉瓜共和国",
                UTCTimeSpan = new TimeSpan(-5,0,0)
            } },
#endregion

#region SouthAmerica南美洲
            // SouthAmerica南美洲
            { M49.Argentina阿根廷 , new M49Info(){
                M49 = M49.Argentina阿根廷,
                ISO3166 = "AR",
                CallingCode = "+054",
                ShortName = "Argentina",
                FullName = "Argentina Republic",
                ChineseShortName = "阿根廷",
                ChineseFullName = "阿根廷共和国",
                UTCTimeSpan = new TimeSpan(-3,0,0)
            } },
            { M49.Bolivia玻利维亚 , new M49Info(){
                M49 = M49.Bolivia玻利维亚,
                ISO3166 = "BO",
                CallingCode = "+591",
                ShortName = "Bolivia",
                FullName = "Plurinational State of Bolivia",
                ChineseShortName = "玻利维亚",
                ChineseFullName = "多民族玻利维亚国",
                UTCTimeSpan = new TimeSpan(-4,0,0)
            } },
            { M49.Brazil巴西 , new M49Info(){
                M49 = M49.Brazil巴西,
                ISO3166 = "BR",
                CallingCode = "+055",
                ShortName = "Brazil",
                FullName = "Federative Republic of Brazil",
                ChineseShortName = "巴西",
                ChineseFullName = "巴西联邦共和国",
                UTCTimeSpan = new TimeSpan(-3,0,0)
            } },
            { M49.Chile智利 , new M49Info(){
                M49 = M49.Chile智利,
                ISO3166 = "CL",
                CallingCode = "+056",
                ShortName = "Chile",
                FullName = "Republic of Chile",
                ChineseShortName = "智利",
                ChineseFullName = "智利共和国",
                UTCTimeSpan = new TimeSpan(-4,0,0)
            } },
            { M49.Colombia哥伦比亚 , new M49Info(){
                M49 = M49.Colombia哥伦比亚,
                ISO3166 = "CO",
                CallingCode = "+057",
                ShortName = "Colombia",
                FullName = "Republic of Colombia",
                ChineseShortName = "哥伦比亚",
                ChineseFullName = "哥伦比亚共和国",
                UTCTimeSpan = new TimeSpan(-5,0,0)
            } },//5
            { M49.Ecuador厄瓜多尔 , new M49Info(){
                M49 = M49.Ecuador厄瓜多尔,
                ISO3166 = "EC",
                CallingCode = "+593",
                ShortName = "Ecuador",
                FullName = "Republic of Ecuador",
                ChineseShortName = "厄瓜多尔",
                ChineseFullName = "厄瓜多尔共和国",
                UTCTimeSpan = new TimeSpan(-5,0,0)
            } },
            { M49.FalklandIslandsMalvinas福克兰群岛马尔维纳斯群岛 , new M49Info(){
                M49 = M49.FalklandIslandsMalvinas福克兰群岛马尔维纳斯群岛,
                ISO3166 = "FK",
                CallingCode = "+500",
                ShortName = "Falkland Islands",
                FullName = "Falkland Islands Malvinas",
                ChineseShortName = "福克兰群岛",
                ChineseFullName = "福克兰群岛马尔维纳斯群岛",
                UTCTimeSpan = new TimeSpan(-3,0,0)
            } },
            { M49.FrenchGuiana法属圭亚那 , new M49Info(){
                M49 = M49.FrenchGuiana法属圭亚那,
                ISO3166 = "GF",
                CallingCode = "+594",
                ShortName = "French Guiana",
                FullName = "Guyane Francaise",
                ChineseShortName = "法属圭亚那",
                ChineseFullName = "法属圭亚那",
                UTCTimeSpan = new TimeSpan(-3,0,0)
            } },
            { M49.Guyana圭亚那 , new M49Info(){
                M49 = M49.Guyana圭亚那,
                ISO3166 = "GY",
                CallingCode = "+592",
                ShortName = "Guyana",
                FullName = "Co-operative Republic of Guyana",
                ChineseShortName = "圭亚那",
                ChineseFullName = "圭亚那合作共和国",
                UTCTimeSpan = new TimeSpan(-4,0,0)
            } },
            { M49.Paraguay巴拉圭 , new M49Info(){
                M49 = M49.Paraguay巴拉圭,
                ISO3166 = "PY",
                CallingCode = "+595",
                ShortName = "Paraguay",
                FullName = "Republic of Paraguay",
                ChineseShortName = "巴拉圭",
                ChineseFullName = "巴拉圭共和国",
                UTCTimeSpan = new TimeSpan(-4,0,0)
            } },//10
            { M49.Peru秘鲁 , new M49Info(){
                M49 = M49.Peru秘鲁,
                ISO3166 = "PE",
                CallingCode = "+051",
                ShortName = "Peru",
                FullName = "Republic of Peru",
                ChineseShortName = "秘鲁",
                ChineseFullName = "秘鲁共和国",
                UTCTimeSpan = new TimeSpan(-5,0,0)
            } },
            { M49.Suriname苏里南 , new M49Info(){
                M49 = M49.Suriname苏里南,
                ISO3166 = "SR",
                CallingCode = "+597",
                ShortName = "Suriname",
                FullName = "Republic of Suriname",
                ChineseShortName = "苏里南",
                ChineseFullName = "苏里南共和国",
                UTCTimeSpan = new TimeSpan(-3,0,0)
            } },
            { M49.Uruguay乌拉圭 , new M49Info(){
                M49 = M49.Uruguay乌拉圭,
                ISO3166 = "UY",
                CallingCode = "+598",
                ShortName = "Uruguay",
                FullName = "Oriental Republic of Uruguay",
                ChineseShortName = "乌拉圭",
                ChineseFullName = "乌拉圭东岸共和国",
                UTCTimeSpan = new TimeSpan(-3,0,0)
            } },
            { M49.Venezuela委内瑞拉 , new M49Info(){
                M49 = M49.Venezuela委内瑞拉,
                ISO3166 = "VE",
                CallingCode = "+058",
                ShortName = "Venezuela",
                FullName = "Bolivarian Republic of Venezuela",
                ChineseShortName = "委内瑞拉",
                ChineseFullName = "委内瑞拉玻利瓦尔共和国",
                UTCTimeSpan = new TimeSpan(-4,0,0)
            } },
#endregion

#region NorthernAmerica北美地区
            // NorthernAmerica北美地区
            { M49.Bermuda百慕大 , new M49Info(){
                M49 = M49.Bermuda百慕大,
                ISO3166 = "BM",
                CallingCode = "+001-441",
                ShortName = "Bermuda",
                FullName = "Bermuda",
                ChineseShortName = "百慕大",
                ChineseFullName = "百慕大",
                UTCTimeSpan = new TimeSpan(-4,0,0)
            } },
            { M49.Canada加拿大 , new M49Info(){
                M49 = M49.Canada加拿大,
                ISO3166 = "CA",
                CallingCode = "+001",
                ShortName = "Canada",
                FullName = "Canada",
                ChineseShortName = "加拿大",
                ChineseFullName = "加拿大",
                UTCTimeSpan = new TimeSpan(-5,0,0)
            } },
            { M49.Greenland格陵兰 , new M49Info(){
                M49 = M49.Greenland格陵兰,
                ISO3166 = "GL",
                CallingCode = "+299",
                ShortName = "Greenland",
                FullName = "Greenland",
                ChineseShortName = "格陵兰",
                ChineseFullName = "格陵兰岛",
                UTCTimeSpan = new TimeSpan(-3,0,0)
            } },
            { M49.SaintPierreandMiquelon圣皮埃尔和密克隆 , new M49Info(){
                M49 = M49.SaintPierreandMiquelon圣皮埃尔和密克隆,
                ISO3166 = "PM",
                CallingCode = "+508",
                ShortName = "Saint Pierre and Miquelon",
                FullName = "Overseas Collectivity of Saint Pierre and Miquelon",
                ChineseShortName = "圣皮埃尔和密克隆",
                ChineseFullName = "圣皮埃尔和密克隆群岛",
                UTCTimeSpan = new TimeSpan(-3,0,0)
            } },
            { M49.UnitedStatesOfAmerica美利坚合众国 , new M49Info(){
                M49 = M49.UnitedStatesOfAmerica美利坚合众国,
                ISO3166 = "US",
                CallingCode = "+001",
                ShortName = "America",
                FullName = "United States of America",
                ChineseShortName = "美国",
                ChineseFullName = "美利坚合众国",
                UTCTimeSpan = new TimeSpan(-5,0,0)
            } },
#endregion

#region CentralAsia中亚
            // CentralAsia中亚
            { M49.Kazakhstan哈萨克斯坦 , new M49Info(){
                M49 = M49.Kazakhstan哈萨克斯坦,
                ISO3166 = "KZ",
                CallingCode = "+007",
                ShortName = "Kazakhstan",
                FullName = "Republic of Kazakhstan",
                ChineseShortName = "哈萨克斯坦",
                ChineseFullName = "哈萨克斯坦共和国",
                UTCTimeSpan = new TimeSpan(6,0,0)
            } },
            { M49.Kazakhstan哈萨克斯坦 , new M49Info(){
                M49 = M49.Kazakhstan哈萨克斯坦,
                ISO3166 = "KG",
                CallingCode = "+996",
                ShortName = "Kyrgyzstan",
                FullName = "Kyrgyz Republic",
                ChineseShortName = "吉尔吉斯斯坦",
                ChineseFullName = "吉尔吉斯共和国",
                UTCTimeSpan = new TimeSpan(6,0,0)
            } },
            { M49.Tajikistan塔吉克斯坦 , new M49Info(){
                M49 = M49.Tajikistan塔吉克斯坦,
                ISO3166 = "TJ",
                CallingCode = "+992",
                ShortName = "Tajikistan",
                FullName = "Republic of Tajikistan",
                ChineseShortName = "塔吉克斯坦",
                ChineseFullName = "塔吉克斯坦共和国",
                UTCTimeSpan = new TimeSpan(5,0,0)
            } },
            { M49.Turkmenistan土库曼斯坦 , new M49Info(){
                M49 = M49.Turkmenistan土库曼斯坦,
                ISO3166 = "TM",
                CallingCode = "+993",
                ShortName = "Turkmenistan",
                FullName = "Turkmenistan",
                ChineseShortName = "土库曼斯坦",
                ChineseFullName = "土库曼斯坦",
                UTCTimeSpan = new TimeSpan(5,0,0)
            } },
            { M49.Uzbekistan乌兹别克斯坦 , new M49Info(){
                M49 = M49.Uzbekistan乌兹别克斯坦,
                ISO3166 = "UZ",
                CallingCode = "+998",
                ShortName = "Uzbekistan",
                FullName = "Republic of Uzbekistan",
                ChineseShortName = "乌兹别克斯坦",
                ChineseFullName = "乌兹别克斯坦共和国",
                UTCTimeSpan = new TimeSpan(5,0,0)
            } },
#endregion

#region EasternAsia东亚
            // EasternAsia东亚
            { M49.China中国 , new M49Info(){
                M49 = M49.China中国,
                ISO3166 = "CN",
                CallingCode = "+086",
                ShortName = "China",
                FullName = "People's Republic of China",
                ChineseShortName = "中国",
                ChineseFullName = "中华人民共和国",
                UTCTimeSpan = new TimeSpan(8,0,0)
            } },
            { M49.HongKong香港 , new M49Info(){
                M49 = M49.HongKong香港,
                ISO3166 = "HK",
                CallingCode = "+852",
                ShortName = "Hong Kong",
                FullName = "Hong Kong Special Administrative Region of the People's Republic of China",
                ChineseShortName = "香港",
                ChineseFullName = "中华人民共和国香港特别行政区",
                UTCTimeSpan = new TimeSpan(8,0,0)
            } },
            { M49.Macao澳门 , new M49Info(){
                M49 = M49.Macao澳门,
                ISO3166 = "MO",
                CallingCode = "+853",
                ShortName = "Macao",
                FullName = "Macao Special Administrative Region of the People's Republic of China",
                ChineseShortName = "澳门",
                ChineseFullName = "中华人民共和国澳门特别行政区",
                UTCTimeSpan = new TimeSpan(8,0,0)
            } },
            { M49.KoreaDPR朝鲜 , new M49Info(){
                M49 = M49.KoreaDPR朝鲜,
                ISO3166 = "KP",
                CallingCode = "+850",
                ShortName = "Korea DPR",
                FullName = "Democratic People's Republic of Korea",
                ChineseShortName = "朝鲜",
                ChineseFullName = "朝鲜民主主义人民共和国",
                UTCTimeSpan = new TimeSpan(9,0,0)
            } },
            { M49.Japan日本 , new M49Info(){
                M49 = M49.Japan日本,
                ISO3166 = "JP",
                CallingCode = "+081",
                ShortName = "Japan",
                FullName = "Japan",
                ChineseShortName = "日本",
                ChineseFullName = "日本国",
                UTCTimeSpan = new TimeSpan(9,0,0)
            } },
            { M49.Mongolia蒙古 , new M49Info(){
                M49 = M49.Mongolia蒙古,
                ISO3166 = "MN",
                CallingCode = "+976",
                ShortName = "Mongolia",
                FullName = "Mongolia",
                ChineseShortName = "蒙古",
                ChineseFullName = "蒙古国",
                UTCTimeSpan = new TimeSpan(8,0,0)
            } },
            { M49.Korea韩国 , new M49Info(){
                M49 = M49.Korea韩国,
                ISO3166 = "KR",
                CallingCode = "+082",
                ShortName = "South Korea",
                FullName = "Republic of Korea",
                ChineseShortName = "韩国",
                ChineseFullName = "大韩民国",
                UTCTimeSpan = new TimeSpan(9,0,0)
            } },
#endregion

#region SouthernAsia南亚
            // SouthernAsia南亚
            { M49.Afghanistan阿富汗 , new M49Info(){
                M49 = M49.Afghanistan阿富汗,
                ISO3166 = "AF",
                CallingCode = "+093",
                ShortName = "Afghanistan",
                FullName = "Islamic Republic of Afghanistan",
                ChineseShortName = "阿富汗",
                ChineseFullName = "阿富汗斯坦伊斯兰共和国",
                UTCTimeSpan = new TimeSpan(4,30,0)
            } },
            { M49.Bangladesh孟加拉国 , new M49Info(){
                M49 = M49.Bangladesh孟加拉国,
                ISO3166 = "BD",
                CallingCode = "+880",
                ShortName = "Bangladesh",
                FullName = "People's Republic of Bangladesh",
                ChineseShortName = "孟加拉国",
                ChineseFullName = "孟加拉人民共和国",
                UTCTimeSpan = new TimeSpan(6,0,0)
            } },
            { M49.Bhutan不丹 , new M49Info(){
                M49 = M49.Bhutan不丹,
                ISO3166 = "BT",
                CallingCode = "+975",
                ShortName = "Bhutan",
                FullName = "Kingdom of Bhutan",
                ChineseShortName = "不丹",
                ChineseFullName = "不丹王国",
                UTCTimeSpan = new TimeSpan(6,0,0)
            } },
            { M49.India印度 , new M49Info(){
                M49 = M49.India印度,
                ISO3166 = "IN",
                CallingCode = "+091",
                ShortName = "India",
                FullName = "Republic of India",
                ChineseShortName = "印度",
                ChineseFullName = "印度共和国",
                UTCTimeSpan = new TimeSpan(5,30,0)
            } },
            { M49.Iran伊朗 , new M49Info(){
                M49 = M49.Iran伊朗,
                ISO3166 = "IR",
                CallingCode = "+098",
                ShortName = "Iran",
                FullName = "Islamic Republic of Iran",
                ChineseShortName = "伊朗",
                ChineseFullName = "伊朗伊斯兰共和国",
                UTCTimeSpan = new TimeSpan(3,30,0)
            } },//5
            { M49.Maldives马尔代夫 , new M49Info(){
                M49 = M49.Maldives马尔代夫,
                ISO3166 = "MV",
                CallingCode = "+960",
                ShortName = "Maldives",
                FullName = "The Republic of Maldives",
                ChineseShortName = "马尔代夫",
                ChineseFullName = "马尔代夫共和国",
                UTCTimeSpan = new TimeSpan(5,0,0)
            } },
            { M49.Nepal尼泊尔 , new M49Info(){
                M49 = M49.Nepal尼泊尔,
                ISO3166 = "NP",
                CallingCode = "+977",
                ShortName = "Nepal",
                FullName = "Federal Democratic Republic of Nepal",
                ChineseShortName = "尼泊尔",
                ChineseFullName = "尼泊尔联邦民主共和国",
                UTCTimeSpan = new TimeSpan(5,45,0)
            } },
            { M49.Pakistan巴基斯坦 , new M49Info(){
                M49 = M49.Pakistan巴基斯坦,
                ISO3166 = "PK",
                CallingCode = "+092",
                ShortName = "Pakistan",
                FullName = "Islamic Republic of Pakistan",
                ChineseShortName = "巴基斯坦",
                ChineseFullName = "巴基斯坦伊斯兰共和国",
                UTCTimeSpan = new TimeSpan(5,0,0)
            } },
            { M49.SriLanka斯里兰卡 , new M49Info(){
                M49 = M49.SriLanka斯里兰卡,
                ISO3166 = "LK",
                CallingCode = "+094",
                ShortName = "SriLanka",
                FullName = "Democratic Socialist Republic of Sri Lanka",
                ChineseShortName = "斯里兰卡",
                ChineseFullName = "斯里兰卡民主社会主义共和国",
                UTCTimeSpan = new TimeSpan(5,30,0)
            } },
#endregion

#region SouthernAsia南亚
            // SouthEasternAsia东南亚
            { M49.Brunei文莱 , new M49Info(){
                M49 = M49.Brunei文莱,
                ISO3166 = "BN",
                CallingCode = "+673",
                ShortName = "Brunei",
                FullName = "Negara Brunei Darussalam",
                ChineseShortName = "文莱",
                ChineseFullName = "文莱达鲁萨兰国",
                UTCTimeSpan = new TimeSpan(8,0,0)
            } },
            { M49.Cambodia柬埔寨 , new M49Info(){
                M49 = M49.Cambodia柬埔寨,
                ISO3166 = "KH",
                CallingCode = "+855",
                ShortName = "Cambodia",
                FullName = "Kingdom of Cambodia",
                ChineseShortName = "柬埔寨",
                ChineseFullName = "柬埔寨王国",
                UTCTimeSpan = new TimeSpan(7,0,0)
            } },
            { M49.Indonesia印度尼西亚 , new M49Info(){
                M49 = M49.Indonesia印度尼西亚,
                ISO3166 = "ID",
                CallingCode = "+062",
                ShortName = "Indonesia",
                FullName = "Republic of Indonesia",
                ChineseShortName = "印度尼西亚",
                ChineseFullName = "印度尼西亚共和国",
                UTCTimeSpan = new TimeSpan(7,0,0)
            } },
            { M49.Laos老挝 , new M49Info(){
                M49 = M49.Laos老挝,
                ISO3166 = "LA",
                CallingCode = "+856",
                ShortName = "Laos",
                FullName = "Lao People's Democratic Republic",
                ChineseShortName = "老挝",
                ChineseFullName = "老挝人民民主共和国",
                UTCTimeSpan = new TimeSpan(7,0,0)
            } },
            { M49.Malaysia马来西亚 , new M49Info(){
                M49 = M49.Malaysia马来西亚,
                ISO3166 = "MY",
                CallingCode = "+060",
                ShortName = "Malaysia",
                FullName = "Malaysia",
                ChineseShortName = "马来西亚",
                ChineseFullName = "马来西亚",
                UTCTimeSpan = new TimeSpan(8,0,0)
            } },//5
            { M49.Myanmar缅甸 , new M49Info(){
                M49 = M49.Myanmar缅甸,
                ISO3166 = "MM",
                CallingCode = "+095",
                ShortName = "Myanmar",
                FullName = "Republic of the Union of Myanmar",
                ChineseShortName = "缅甸",
                ChineseFullName = "缅甸联邦共和国",
                UTCTimeSpan = new TimeSpan(6,30,0)
            } },
            { M49.Philippines菲律宾 , new M49Info(){
                M49 = M49.Philippines菲律宾,
                ISO3166 = "PH",
                CallingCode = "+063",
                ShortName = "Philippines",
                FullName = "Republic of the Philippines",
                ChineseShortName = "菲律宾",
                ChineseFullName = "菲律宾共和国",
                UTCTimeSpan = new TimeSpan(8,0,0)
            } },
            { M49.Singapore新加坡 , new M49Info(){
                M49 = M49.Singapore新加坡,
                ISO3166 = "SG",
                CallingCode = "+065",
                ShortName = "Singapore",
                FullName = "Republic of Singapore",
                ChineseShortName = "新加坡",
                ChineseFullName = "新加坡共和国",
                UTCTimeSpan = new TimeSpan(8,0,0)
            } },
            { M49.Thailand泰国 , new M49Info(){
                M49 = M49.Thailand泰国,
                ISO3166 = "TH",
                CallingCode = "+066",
                ShortName = "Thailand",
                FullName = "Kingdom of Thailand",
                ChineseShortName = "泰国",
                ChineseFullName = "泰王国",
                UTCTimeSpan = new TimeSpan(7,0,0)
            } },
            { M49.TimorLeste东帝汶 , new M49Info(){
                M49 = M49.TimorLeste东帝汶,
                ISO3166 = "TL",
                CallingCode = "+670",
                ShortName = "Timor-Leste",
                FullName = "Democratic Republic of Timor-Leste",
                ChineseShortName = "东帝汶",
                ChineseFullName = "东帝汶民主共和国",
                UTCTimeSpan = new TimeSpan(9,0,0)
            } },//10
            { M49.VietNam越南 , new M49Info(){
                M49 = M49.VietNam越南,
                ISO3166 = "VN",
                CallingCode = "+084",
                ShortName = "VietNam",
                FullName = "Socialist Republic of Vietnam",
                ChineseShortName = "越南",
                ChineseFullName = "越南社会主义共和国",
                UTCTimeSpan = new TimeSpan(7,0,0)
            } },
#endregion

#region WesternAsia西亚
            // WesternAsia西亚
            { M49.Armenia亚美尼亚 , new M49Info(){
                M49 = M49.Armenia亚美尼亚,
                ISO3166 = "AM",
                CallingCode = "+374",
                ShortName = "Armenia",
                FullName = "Republic of Armenia",
                ChineseShortName = "亚美尼亚",
                ChineseFullName = "亚美尼亚共和国",
                UTCTimeSpan = new TimeSpan(4,0,0)
            } },
            { M49.Azerbaijan阿塞拜疆 , new M49Info(){
                M49 = M49.Azerbaijan阿塞拜疆,
                ISO3166 = "AZ",
                CallingCode = "+994",
                ShortName = "Azerbaijan",
                FullName = "Republic of Azerbaijan",
                ChineseShortName = "阿塞拜疆",
                ChineseFullName = "阿塞拜疆共和国",
                UTCTimeSpan = new TimeSpan(4,0,0)
            } },
            { M49.Bahrain巴林 , new M49Info(){
                M49 = M49.Bahrain巴林,
                ISO3166 = "BH",
                CallingCode = "+973",
                ShortName = "Bahrain",
                FullName = "Kingdom of Bahrain",
                ChineseShortName = "巴林",
                ChineseFullName = "巴林王国",
                UTCTimeSpan = new TimeSpan(3,0,0)
            } },
            { M49.Cyprus塞浦路斯 , new M49Info(){
                M49 = M49.Cyprus塞浦路斯,
                ISO3166 = "CY",
                CallingCode = "+357",
                ShortName = "Cyprus",
                FullName = "Republic of Cyprus",
                ChineseShortName = "塞浦路斯",
                ChineseFullName = "塞浦路斯共和国",
                UTCTimeSpan = new TimeSpan(2,0,0)
            } },
            { M49.Georgia格鲁吉亚 , new M49Info(){
                M49 = M49.Georgia格鲁吉亚,
                ISO3166 = "GE",
                CallingCode = "+995",
                ShortName = "Georgia",
                FullName = "Georgia",
                ChineseShortName = "格鲁吉亚",
                ChineseFullName = "格鲁吉亚",
                UTCTimeSpan = new TimeSpan(4,0,0)
            } },//5
            { M49.Iraq伊拉克 , new M49Info(){
                M49 = M49.Iraq伊拉克,
                ISO3166 = "IQ",
                CallingCode = "+964",
                ShortName = "Iraq",
                FullName = "Republic Of Iraq",
                ChineseShortName = "伊拉克",
                ChineseFullName = "伊拉克共和国",
                UTCTimeSpan = new TimeSpan(3,0,0)
            } },
            { M49.Israel以色列 , new M49Info(){
                M49 = M49.Israel以色列,
                ISO3166 = "IL",
                CallingCode = "+972",
                ShortName = "Israel",
                FullName = "State of Israel",
                ChineseShortName = "以色列",
                ChineseFullName = "以色列国",
                UTCTimeSpan = new TimeSpan(2,0,0)
            } },
            { M49.Jordan约旦 , new M49Info(){
                M49 = M49.Jordan约旦,
                ISO3166 = "JO",
                CallingCode = "+962",
                ShortName = "Jordan",
                FullName = "Hashemite Kingdom of Jordan",
                ChineseShortName = "约旦",
                ChineseFullName = "约旦哈希姆王国",
                UTCTimeSpan = new TimeSpan(2,0,0)
            } },
            { M49.Kuwait科威特 , new M49Info(){
                M49 = M49.Kuwait科威特,
                ISO3166 = "KW",
                CallingCode = "+965",
                ShortName = "Kuwait",
                FullName = "State of Kuwait",
                ChineseShortName = "科威特",
                ChineseFullName = "科威特国",
                UTCTimeSpan = new TimeSpan(3,0,0)
            } },
            { M49.Lebanon黎巴嫩 , new M49Info(){
                M49 = M49.Lebanon黎巴嫩,
                ISO3166 = "LB",
                CallingCode = "+961",
                ShortName = "Lebanon",
                FullName = "Lebanon Republic",
                ChineseShortName = "黎巴嫩",
                ChineseFullName = "黎巴嫩共和国",
                UTCTimeSpan = new TimeSpan(2,0,0)
            } },//10
            { M49.Oman阿曼 , new M49Info(){
                M49 = M49.Oman阿曼,
                ISO3166 = "OM",
                CallingCode = "+968",
                ShortName = "Oman",
                FullName = "Sultanate of Oman",
                ChineseShortName = "阿曼",
                ChineseFullName = "阿曼苏丹国",
                UTCTimeSpan = new TimeSpan(4,0,0)
            } },
            { M49.Qatar卡塔尔 , new M49Info(){
                M49 = M49.Qatar卡塔尔,
                ISO3166 = "QA",
                CallingCode = "+974",
                ShortName = "Qatar",
                FullName = "State of Qatar",
                ChineseShortName = "卡塔尔",
                ChineseFullName = "卡塔尔国",
                UTCTimeSpan = new TimeSpan(3,0,0)
            } },
            { M49.SaudiArabia沙特阿拉伯 , new M49Info(){
                M49 = M49.SaudiArabia沙特阿拉伯,
                ISO3166 = "SA",
                CallingCode = "+966",
                ShortName = "Saudi Arabia",
                FullName = "Kingdom of Saudi Arabia",
                ChineseShortName = "沙特阿拉伯",
                ChineseFullName = "沙特阿拉伯王国",
                UTCTimeSpan = new TimeSpan(3,0,0)
            } },
            { M49.Palestine巴勒斯坦 , new M49Info(){
                M49 = M49.Palestine巴勒斯坦,
                ISO3166 = "PS",
                CallingCode = "+970",
                ShortName = "Palestine",
                FullName = "State of Palestine",
                ChineseShortName = "巴勒斯坦",
                ChineseFullName = "巴勒斯坦国",
                UTCTimeSpan = new TimeSpan(2,0,0)
            } },
            { M49.Syrian叙利亚 , new M49Info(){
                M49 = M49.Syrian叙利亚,
                ISO3166 = "SY",
                CallingCode = "+963",
                ShortName = "Syria",
                FullName = "Syrian Arab Republic",
                ChineseShortName = "叙利亚",
                ChineseFullName = "阿拉伯叙利亚共和国",
                UTCTimeSpan = new TimeSpan(2,0,0)
            } },//15
            { M49.Turkey土耳其 , new M49Info(){
                M49 = M49.Turkey土耳其,
                ISO3166 = "TR",
                CallingCode = "+090",
                ShortName = "Turkey",
                FullName = "Republic of Turkey",
                ChineseShortName = "土耳其",
                ChineseFullName = "土耳其共和国",
                UTCTimeSpan = new TimeSpan(3,0,0)
            } },
            { M49.UAE阿联酋 , new M49Info(){
                M49 = M49.UAE阿联酋,
                ISO3166 = "AE",
                CallingCode = "+971",
                ShortName = "UAE",
                FullName = "United Arab Emirates",
                ChineseShortName = "阿联酋",
                ChineseFullName = "阿拉伯联合酋长国",
                UTCTimeSpan = new TimeSpan(4,0,0)
            } },
            { M49.Yemen也门 , new M49Info(){
                M49 = M49.Yemen也门,
                ISO3166 = "YE",
                CallingCode = "+967",
                ShortName = "Yemen",
                FullName = "Republic of Yemen",
                ChineseShortName = "也门",
                ChineseFullName = "也门共和国",
                UTCTimeSpan = new TimeSpan(3,0,0)
            } },
#endregion
            
#region EasternEurope东欧
            // EasternEurope东欧
            { M49.Belarus白俄罗斯 , new M49Info(){
                M49 = M49.Belarus白俄罗斯,
                ISO3166 = "BY",
                CallingCode = "+375",
                ShortName = "Belarus",
                FullName = "Republic of Belarus",
                ChineseShortName = "白俄罗斯",
                ChineseFullName = "白俄罗斯共和国",
                UTCTimeSpan = new TimeSpan(3,0,0)
            } },
            { M49.Bulgaria保加利亚 , new M49Info(){
                M49 = M49.Bulgaria保加利亚,
                ISO3166 = "BG",
                CallingCode = "+359",
                ShortName = "Bulgaria",
                FullName = "Republic of Bulgaria",
                ChineseShortName = "保加利亚",
                ChineseFullName = "保加利亚共和国",
                UTCTimeSpan = new TimeSpan(2,0,0)
            } },
            { M49.Czech捷克 , new M49Info(){
                M49 = M49.Czech捷克,
                ISO3166 = "CZ",
                CallingCode = "+420",
                ShortName = "Czech",
                FullName = "Czech Republic",
                ChineseShortName = "捷克",
                ChineseFullName = "捷克共和国",
                UTCTimeSpan = new TimeSpan(1,0,0)
            } },
            { M49.Hungary匈牙利 , new M49Info(){
                M49 = M49.Hungary匈牙利,
                ISO3166 = "HU",
                CallingCode = "+036",
                ShortName = "Hungary",
                FullName = "Hungary",
                ChineseShortName = "匈牙利",
                ChineseFullName = "匈牙利",
                UTCTimeSpan = new TimeSpan(1,0,0)
            } },
            { M49.Poland波兰 , new M49Info(){
                M49 = M49.Poland波兰,
                ISO3166 = "PL",
                CallingCode = "+048",
                ShortName = "Poland",
                FullName = "Republic of Poland",
                ChineseShortName = "波兰",
                ChineseFullName = "波兰共和国",
                UTCTimeSpan = new TimeSpan(1,0,0)
            } },//5
            { M49.Moldova摩尔多瓦 , new M49Info(){
                M49 = M49.Moldova摩尔多瓦,
                ISO3166 = "MD",
                CallingCode = "+373",
                ShortName = "Moldova",
                FullName = "Republic of Moldova",
                ChineseShortName = "摩尔多瓦",
                ChineseFullName = "摩尔多瓦共和国",
                UTCTimeSpan = new TimeSpan(2,0,0)
            } },
            { M49.Romania罗马尼亚 , new M49Info(){
                M49 = M49.Romania罗马尼亚,
                ISO3166 = "RO",
                CallingCode = "+040",
                ShortName = "Romania",
                FullName = "Romania",
                ChineseShortName = "罗马尼亚",
                ChineseFullName = "罗马尼亚",
                UTCTimeSpan = new TimeSpan(2,0,0)
            } },
            { M49.Russia俄罗斯 , new M49Info(){
                M49 = M49.Russia俄罗斯,
                ISO3166 = "RU",
                CallingCode = "+007",
                ShortName = "Russian",
                FullName = "Russian Federation",
                ChineseShortName = "俄罗斯",
                ChineseFullName = "俄罗斯联邦",
                UTCTimeSpan = new TimeSpan(3,0,0)
            } },
            { M49.Slovakia斯洛伐克 , new M49Info(){
                M49 = M49.Slovakia斯洛伐克,
                ISO3166 = "SK",
                CallingCode = "+421",
                ShortName = "Slovakia",
                FullName = "Slovak Republic",
                ChineseShortName = "斯洛伐克",
                ChineseFullName = "斯洛伐克共和国",
                UTCTimeSpan = new TimeSpan(1,0,0)
            } },
            { M49.Ukraine乌克兰 , new M49Info(){
                M49 = M49.Ukraine乌克兰,
                ISO3166 = "UA",
                CallingCode = "+380",
                ShortName = "Ukraine",
                FullName = "Ukraine",
                ChineseShortName = "乌克兰",
                ChineseFullName = "乌克兰",
                UTCTimeSpan = new TimeSpan(2,0,0)
            } },
#endregion
            





        };
    }
}
