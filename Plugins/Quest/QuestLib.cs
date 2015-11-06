﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicObserver.Window
{
    public class QuestLib
    {
        public static Dictionary<int, QuestInfo> Quests = new Dictionary<int, QuestInfo>();
        public static QuestInfo GetQuest(int id)
        {
            if (Quests.ContainsKey(id))
            {
                if (Quests[id].Tips != "")
                    return Quests[id];
                else
                    return null;
            }
            else
                return null;
        }

        static QuestLib()
        {
            //はじめての「編成」！
            AddQuest(101, "「白雪」", "编成一只拥有2只舰娘的舰队");
            //「駆逐隊」を編成せよ！
            AddQuest(102, "高速建造材x1", "编成一只拥有4只驱逐的舰队");
            //「水雷戦隊」を編成せよ！
            AddQuest(103, "開発資材x1", "编成以轻巡为旗舰和数只驱逐的舰队");
            //６隻編成の艦隊を編成せよ
            AddQuest(104, "第2艦隊開放", "编成一只拥有6只舰娘的舰队", 103);
            //軽巡２隻を擁する隊を編成せよ
            AddQuest(105, "開発資材x1", "编成一只拥有2只轻巡的舰队");
            //「重巡戦隊」を編成せよ
            AddQuest(106, "高速修復材x1", "编成一只拥有2只重巡的舰队");
            //「空母機動部隊」を編成せよ
            AddQuest(107, "開発資材x1", "编成空母或水母旗舰,驱逐3只的舰队");
            //「天龍」型軽巡姉妹の全２艦を編成せよ！
            AddQuest(108, "高速建造材x1", "在舰队里编入天龙和龙田", 105);
            //「川内」型軽巡姉妹の全３艦を編成せよ
            AddQuest(109, "第3艦隊開放", "编成一只拥有川内,神通,那珂的舰队", 106);
            //「妙高」型重巡姉妹の全４隻を編成せよ
            AddQuest(110, "高速修復材x1，開発資材x1", "编成一只拥有妙高,那智,足柄,羽黑的舰队");
            //「扶桑」型戦艦姉妹の全２隻を編成せよ
            AddQuest(111, "高速修復材x2，開発資材x1", "编成一只拥有扶桑,山城的舰队", 108);
            //「伊勢」型戦艦姉妹の全２隻を編成せよ
            AddQuest(112, "高速修復材x2，開発資材x2", "编成一只拥有伊势,日向的舰队", 111);
            //戦艦と重巡による主力艦隊を編成せよ
            AddQuest(113, "高速建造材x2", "编成一只拥有1只战舰,2只重巡的舰队", 107);
            //「南雲機動部隊」を編成せよ
            AddQuest(114, "高速建造材x2，開発資材x4", "编成一只拥有赤城,加贺,飞龙,苍龙的舰队,不能有其他船", 113);
            //第２艦隊を編成せよ
            AddQuest(115, "高速建造材x1", "编成第二舰队");
            //「水上機母艦」を配備せよ
            AddQuest(116, "開発資材x1", "在舰队里编入一只水上机母舰");
            //第２艦隊で空母機動部隊を編成せよ
            AddQuest(117, "高速建造材x2", "第二舰队编入空母或水母一只,驱逐2只", 215);
            //「金剛」型による高速戦艦部隊を編成せよ
            AddQuest(118, "第4艦隊開放", "编成一只拥有金刚,比叡,榛名,雾岛的舰队", 110);
            //「三川艦隊」を編成せよ
            AddQuest(119, "高速修復材x3", "编成一只拥有鸟海,青叶,加古,古鹰,天龙和任一只高速舰船的舰队", 113);
            //「第六駆逐隊」を編成せよ
            AddQuest(120, "応急修理要員x1", "在舰队里编入晓响雷电,不能有其他船", 116);
            //「第四戦隊」を編成せよ
            AddQuest(121, "高速修復材x2，開発資材x1", "编成一只拥有高雄,爱宕,鸟海,摩耶的舰队", 119);
            //「西村艦隊」を編成せよ
            AddQuest(122, "給糧艦「間宮」", "编成一只拥有扶桑,山城,最上,时雨的舰队", 121);
            //「第五航空戦隊」を編成せよ
            AddQuest(123, "応急修理要員x1", "编成一只拥有翔鹤,瑞鹤和2只驱逐的舰队", 122);
            //新「三川艦隊」を編成せよ
            AddQuest(124, "給糧艦「間宮」", "编成一只拥有鸟海,青叶,衣笠,加古,古鹰,天龙的舰队", 121);
            //潜水艦隊を編成せよ
            AddQuest(125, "応急修理要員x1", "编成一只拥有2只潜水艇或者潜水空母的舰队", 121);
            //航空水上打撃艦隊を編成せよ
            AddQuest(126, "高速修復材x2", "编成一只拥有2只航战和2只航巡的舰队", 122);
            //中規模潜水艦隊を編成せよ
            AddQuest(127, "給糧艦「間宮」x1", "编成一只拥有3只潜水艇或者潜水空母的舰队", 121);
            //「第六戦隊」を編成せよ
            AddQuest(128, "給糧艦「間宮」x1", "编成一只拥有古鹰,加古,青叶,衣笠的舰队", 120);
            //「第五艦隊」を編成せよ
            AddQuest(129, "高速修復材x3", "编成一只拥有那智,足柄,多摩,木曾的舰队", 121);
            //「第一水雷戦隊」を編成せよ！",
            AddQuest(130, "応急修理要員x1", "编成一只拥有阿武隈,曙,潮,霞,不知火的舰队", 129);
            //「第八駆逐隊」を編成せよ
            AddQuest(131, "開発資材x3", "编成一只拥有朝潮,满潮,大潮,荒潮的舰队,不能有其他船", 125);
            //「第十八駆逐隊」を編成せよ
            AddQuest(132, "開発資材x1，応急修理要員x1", "编成一只拥有霞,霰,阳炎,不知火的舰队,不能有其他船", 239);
            //「第三十駆逐隊(第一次)」を編成せよ
            AddQuest(133, "高速修復材x2，応急修理要員x1", "编成一只拥有睦月,如月,弥生,望月的舰队,不能有其他船", 131);
            //式の準備！(その参)
            AddQuest(134, "家具箱(大)x1", "将Lv90-99的舰船设置为秘书舰",306);
            //新たなる旅立ち
            AddQuest(135, "応急修理要員", "编成旗舰Lv100以上,5只其他船的第一舰队",245);
            //「第三十駆逐隊(第二次)」を編成せよ
            AddQuest(136, "開発資材x3", "编成一只拥有睦月,卯月,弥生,望月的舰队,不能有其他船", 133);
            //「第五戦隊」を編成せよ
            AddQuest(137, "開発資材x5", "编成一只拥有妙高,那智,羽黑的舰队", 248);
            //新編「第二航空戦隊」を編成せよ
            AddQuest(138, "高速修復材x2，開発資材x2", "编成一只飞龙改二为旗舰,含有苍龙和2只驱逐的舰队", 128);
            //潜水艦隊「第六艦隊」を編成せよ
            AddQuest(139, "開発資材x3", "编成一只潜水母舰(大鲸)为旗舰,另有4只潜水舰或潜水空母的舰队", 127);
            //新型電探を配備せよ
            AddQuest(140, "「22号対水上電探改四」", "设置妙高改二为第一舰队旗舰", 137);
            //再編成「第二航空戦隊」を強化せよ
            AddQuest(141, "高速建造材x2，開発資材x2", "编成一只苍龙改二为旗舰,含有飞龙改二和2只驱逐的舰队", 250);
            //精鋭「第三戦隊」全艦集結せよ
            AddQuest(142, "「試製35.6cm三連装砲」", "编成一只拥有4只金刚级改二的舰队", 246);
            //「新型正規空母」を配備せよ
            AddQuest(143, "開発資材x2", "设置云龙为第一舰队旗舰", 123);
            //主力戦艦部隊「第二戦隊」を編成せよ
            AddQuest(144, "高速修復材x2", "编成一只拥有长门,陆奥,扶桑,山城的舰队", 132);
            //戦艦を主力とした水上打撃部隊を編成せよ
            AddQuest(145, "開発資材x3", "编成一只拥有[大和型・長門型・伊勢型・扶桑型]其中任意三只,轻巡一只的舰队", 258);
            //改修工廠を準備せよ
            AddQuest(146, "改修資材x5，改修工廠開放", "设置明石为第一舰队旗舰", 116);
            //「西村艦隊」を再編成せよ
            AddQuest(147, "開発資材x2，改修資材x3", "编成一只拥有扶桑,山城,最上,时雨,满潮的舰队", 137, 224);
            //軽快な「水上反撃部隊」を編成せよ
            AddQuest(148, "高速修復材x2，開発資材x2", "编成一只霞为旗舰,足柄,1只轻巡,4只驱逐的舰队", 123, 224);
            //「第十一駆逐隊」を編成せよ
            AddQuest(149, "開発資材x3", "编成一只拥有吹雪,白雪,初雪,从云的舰队,不能有其他船", 132);
            //「第二一駆逐隊」を編成せよ
            AddQuest(150, "高速修復材x3", "编成一只拥有初春,子日,若叶,初霜的舰队,不能有其他船", 267);
            //「第二二駆逐隊」を編成せよ
            AddQuest(151, "開発資材x2，高速修復材x2", "编成一只拥有皋月,文月,长月和1只其他驱逐的舰队,不能有其他船", 271);
            //「三川艦隊」を新編、突入準備せよ
            AddQuest(152, "高速修復材x2", "编成一只鸟海改二为旗舰,古鹰,加古,青叶,衣笠,夕张,天龙中任意5只的舰队", 136, 227);
            //「第十八戦隊」を新編成せよ
            AddQuest(153, "開発資材x2", "编成一只拥有天龙,龙田和其他2只舰船的舰队", 274);
            //海上突入部隊を編成せよ
            AddQuest(154, "開発資材x2，高速修復材x2", "编成一只拥有比叡,雾岛,长良,晓,雷,电的舰队", 227);
            //新編「第六駆逐隊」を編成せよ
            AddQuest(155, "「探照灯」", "编成一只晓改二为旗舰,响,雷,电的舰队", 224);
            //「第一水雷戦隊」北方突入準備
            AddQuest(156, "高速修復材x2,家具箱(中)x1", "编成一只阿武隈为旗舰,響,初霜,若葉,五月雨,島風的舰队", 240);
            //「第一水雷戦隊」北方再突入準備
            AddQuest(157, "高速修復材x3,家具箱(大)x1", "编成一只阿武隈改二为旗舰,響,夕雲,長波,秋雲,島風的舰队", 309);
            //
            AddQuest(158, "高速建造材x1", "");
            //
            AddQuest(159, "高速建造材x1", "");

            //「第五航空戦隊」を再編成せよ！
            AddQuest(161, "開発資材x3", "编成含有翔鶴,瑞鶴,朧,秋雲的舰队");
            //新編「第二一戦隊」出撃準備！
            AddQuest(162, "開発資材x2,改修資材x2", "编成含有那智改二,足柄改二,多摩,木曾的舰队");
            //「第十六戦隊(第一次)」を編成せよ！
            AddQuest(163, "開発資材x2,高速修復材x2", "编成含有旗舰足柄,球磨,長良的舰队");
            //「第三航空戦隊」を編成せよ！
            AddQuest(164, "開発資材x2,熟練搭乗員x1", "编成含有旗舰瑞鹤,瑞凤改,千代田航,千岁航的舰队");
            //「第四航空戦隊」を編成せよ！
            AddQuest(165, "改修資材x2,瑞雲(六三四空)", "编成含有伊势改,日向改的舰队");
            //「小沢艦隊」を編成せよ！
            AddQuest(166, "開発資材x2,応急修理要員", "编成含有旗舰瑞鹤,瑞凤改,千代田航,千岁航,伊势改,日向改的舰队");
            //新航空戦隊を編成せよ！
            AddQuest(167, "給糧艦,熟練搭乗員", "编成含有翔鹤改二(甲),瑞鹤改二(甲),2驱逐的舰队");

            //敵艦隊を撃破せよ
            AddQuest(201, "開発資材x1", "赢得一次战斗", 204);
            //はじめての「出撃」
            AddQuest(202, "高速修復材x1", "进行一次战斗");
            //鎮守府正面海域を護れ
            AddQuest(203, "高速修復材x1", "在1-1 BOSS点战斗胜利");
            //南西諸島沖に出撃せよ
            AddQuest(204, "高速修復材x1", "在1-2进行一次战斗");
            //接近する「敵前衛艦隊」を迎撃せよ
            AddQuest(205, "開発資材x1，「深雪」", "在1-2 BOSS点战斗胜利");
            //「水雷戦隊」で出撃せよ
            AddQuest(206, "「龍田」", "用轻巡旗舰和驱逐舰的舰队进行一次战斗",205);
            //「重巡洋艦」を出撃させよ
            AddQuest(207, "開発資材x1", "用旗舰为重巡的舰队进行一次战斗",206);
            //「戦艦」を出撃させよ
            AddQuest(208, "開発資材x1", "用旗舰为战舰的舰队进行一次战斗",207);
            //「空母機動部隊」出撃せよ
            AddQuest(209, "高速修復材x1，開発資材x1", "用包含1只空母或者水母和3只其他舰船的舰队进行一次战斗",208);
            //敵艦隊を10回邀撃せよ
            AddQuest(210, "開発資材x1", "进行10次战斗",216);
            //敵空母を３隻撃沈せよ
            AddQuest(211, "高速修復材x2", "击沉3只空母或轻母",201);
            //敵輸送船団を叩け
            AddQuest(212, "開発資材x2", "击沉5只补给舰", 201);
            //海上通商破壊作戦
            AddQuest(213, "開発資材x3", "击沉20只补给舰",216);
            //あ号作戦
            AddQuest(214, "高速建造材x2，開発資材x2", "战斗36次,获得6次S胜,进入BOSS点24次,获得12次BOSS战胜利", 216);
            //第２艦隊、出撃せよ
            AddQuest(215, "開発資材x1", "用第二舰队进行一次战斗",115);
            //敵艦隊主力を撃滅せよ
            AddQuest(216, "高速修復材x1，開発資材x1", "进行一次战斗",201);
            //敵空母を撃沈せよ
            AddQuest(217, "「赤城」", "击沉一只空母或者轻母",117);
            //敵補給艦を3隻撃沈せよ
            AddQuest(218, "高速修復材x1，開発資材x1", "击沉3只补给舰",216);
            //「三川艦隊」出撃せよ
            AddQuest(219, "応急修理要員x1", "使用鸟海,青叶,加古,古鹰,天龙和1只高速舰船进行一次战斗",119);
            //い号作戦
            AddQuest(220, "開発資材x2", "击沉20只空母或轻母", 218);
            //ろ号作戦
            AddQuest(221, "高速修復材x3", "击沉50只补给舰", 214);
            //「第六駆逐隊」出撃せよ
            AddQuest(222, "高速修復材x1", "使用晓响雷电进行一次战斗,不能带其他船",120,213);
            //「第四戦隊」出撃せよ
            AddQuest(223, "高速修復材x2", "使用爱宕,高雄,鸟海,摩耶在2-2 BOSS取得胜利,可以带其他船", 121);
            //「西村艦隊」出撃せよ
            AddQuest(224, "高速修復材x2，家具箱(小)x1", "使用扶桑,山城,最上,时雨在2-3 BOSS取得胜利,可以带其他船", 122);
            //「第五航空戦隊」出撃せよ
            AddQuest(225, "高速修復材x2，家具箱(中)x1", "使用翔鹤,瑞鹤在3-1 BOSS取得胜利,可以带其他船",123);
            //南西諸島海域の制海権を握れ
            AddQuest(226, "高速建造材x1，高速修復材x1", "取得2图BOSS战胜利5次",218);
            //新「三川艦隊」出撃せよ
            AddQuest(227, "応急修理要員x1", "使用鸟海,青叶,衣笠,加古,古鹰,天龙在2-3 BOSS取得胜利\r\n这个任务可以和第六战队任务一起做,需要注意的是六战任务要求S胜",124);
            //海上護衛戦
            AddQuest(228, "高速修復材x2，改修資材x1", "击沉15只潜水舰", 220);
            //敵東方艦隊を撃滅せよ
            AddQuest(229, "開発資材x2", "获得4图BOSS战胜利共12次", 228);
            //敵潜水艦を制圧せよ
            AddQuest(230, "高速修復材x1", "击沉6只潜水舰",226);
            //「潜水艦隊」出撃せよ
            AddQuest(231, "特注家具職人", "使用2只潜水艇或者潜水空母在2-3 BOSS取得胜利,可以带其他船", 125);
            //「航空水上打撃艦隊」出撃せよ
            AddQuest(232, "給糧艦「間宮」", "使用2只航战和2只航巡在4-2 BOSS取得胜利,可以带其他船(建议至少1cv)",126);
            //「第六戦隊」出撃せよ
            AddQuest(233, "家具箱(中)x1，応急修理要員x1", "使用古鹰,加古,青叶,衣笠在2-3 BOSS取得S胜,可以带其他船\r\n这个任务可以和新三川2-3一起做",128);
            //はじめての「出撃」
            AddQuest(234, "高速修復材x1", "");
            //はじめての「出撃」
            AddQuest(235, "高速修復材x1", "");
            //はじめての「出撃」
            AddQuest(236, "高速修復材x1", "");
            //はじめての「出撃」
            AddQuest(237, "高速修復材x1", "");
            //はじめての「出撃」
            AddQuest(238, "高速修復材x1", "");
            //「第八駆逐隊」出撃せよ
            AddQuest(239, "開発資材x1，家具箱(中)x1", "使用朝潮,满潮,大潮,荒潮在2-3 BOSS取得胜利,可以带其他船", 131);
            //第十八駆逐隊」出撃せよ
            AddQuest(240, "開発資材x2，家具箱(大)x1", "使用霞,霰,阳炎,不知火在3-1 BOSS取得胜利,建议再带2cv洗地", 132);
            //敵北方艦隊主力を撃滅せよ
            AddQuest(241, "開発資材x3，改修資材x3", "取得3-3 3-4 3-5 BOSS战胜利共5次",228);
            //敵東方中枢艦隊を撃破せよ
            AddQuest(242, "高速修復材x1，開発資材x1", "取得4-4 BOSS战胜利",229);
            //南方海域珊瑚諸島沖の制空権を握れ
            AddQuest(243, "開発資材x2，改修資材x2", "取得5-2 BOSS战S胜利2次", 242);
            //「第三十駆逐隊(第一次)」出撃せよ
            AddQuest(244, "給糧艦「間宮」x1", "使用睦月,如月,弥生,望月和3-2 BOSS交战,不能D败,可以再携带1cl1dd",133);
            //式の準備！(最終)
            AddQuest(245, "書類一式&指輪", "使用Lv90-99旗舰的第一舰队取得2-3BOSS战S胜", 134);
            //二人でする初めての任務
            AddQuest(246, "「煎餅布団」", "使用婚舰旗舰的第一舰队取得4-3BOSS S胜", 135);
            //「航空戦艦」抜錨せよ
            AddQuest(247, "高速修復材x3，家具箱(大)x1", "使用2只航战在4-4 BOSS取得胜利,建议再带1cv2dd1ca",412);
            //「第三十駆逐隊」対潜哨戒
            AddQuest(248, "特注家具職人x1", "使用睦月,卯月,弥生,望月和1-5 BOSS交战,不能D败,不能带其他船", 136);
            //「第五戦隊」出撃せよ
            AddQuest(249, "開発資材x5，家具箱(大)x1", "使用妙高,那智,羽黑在2-5 BOSS取得S胜,建议再携带2cav和clt/ca", 137);
            //新編「第二航空戦隊」出撃せよ
            AddQuest(250, "給糧艦「間宮」", "使用飞龙改二为旗舰,苍龙,2只驱逐和其他舰船的舰队取得5-2BOSS战S胜,建议再带1cvl 1bb", 138);
            //精鋭「第二航空戦隊」抜錨せよ
            AddQuest(251, "特注家具職人", "使用苍龙改二为旗舰,飞龙改二,2只驱逐和其他舰船的舰队取得4-3BOSS战S胜,建议再带1cav1ca", 141);
            //戦艦「榛名」出撃せよ
            AddQuest(252, "「試製35.6cm三連装砲」", "使用榛名改二在5-1 BOSS取得S胜,建议再带1cv2dd2ca,注意的是BOSS点1/3几率有鱼,dd可以带反潜套并且boss战复纵",248);
            //「第六〇一航空隊」出撃せよ
            AddQuest(253, "家具箱(大)x1，装備「熟練艦載機整備員」", "使用云龙改在5-2 BOSS取得S胜,建议再带1bb1cv1cvl2clt",143);
            //「軽空母」戦隊、出撃せよ
            AddQuest(254, "高速修復材x3，応急修理要員x1", "用轻母1-2只和轻巡1只和驱逐3-4只取得2-1BOSS战S胜,不能带其他船",105);
            //「水雷戦隊」バシー島沖緊急展開
            AddQuest(255, "家具箱(大)x1，特注家具職人", "用轻巡1-2只和1-5只驱逐取得2-2BOSS战S胜,不能带其他船", 206);
            //「潜水艦隊」出撃せよ
            AddQuest(256, "家具箱(大)x1，給糧艦「伊良湖」", "取得6-1 BOSS战S胜3次", 255);
            //「水雷戦隊」南西へ
            AddQuest(257, "改修資材x3，給糧艦「伊良湖」x1", "使用轻巡为旗舰1-3只和其他若干驱逐取得1-4BOSS战S胜", 221);
            //「第二戦隊」抜錨
            AddQuest(258, "「一式徹甲弾」", "使用长门+陆奥+扶桑+山城在4-2 BOSS取得S胜 2次,可以带其他船", 144);
            //「水上打撃部隊」南方へ
            AddQuest(259, "高速修復材x3，改修資材x4", "使用3只低速战舰或航战3只和1只轻巡取得5-1BOSS战S胜,建议再带2ca,注意BOSS点1/3几率有鱼",145);
            //「戦艦部隊」北方海域に突入せよ
            AddQuest(260, "開発資材x2，「一式徹甲弾」", "使用2只战舰1只轻母在3-5 BOSS取得S胜,不能带空母,可以带其他船,建议在3-5磨血阶段做", 259);
            //海上輸送路の安全確保に努めよ
            AddQuest(261, "改修資材x3", "取得1-5 BOSS战A,S胜 3次", 146, 221);
            //「西村艦隊」南方海域へ進出せよ
            AddQuest(262, "改修資材x5，勲章x1", "使用扶桑,山城,最上,时雨,满潮取得5-1BOSS S胜,建议再带个ca,需要注意的是BOSS点1/3几率有鱼,可以dd带反潜并且复纵进入boss点", 147);
            //「第六戦隊」南西海域へ出撃せよ
            AddQuest(263, "家具箱(大)x1，特注家具職人", "使用古鹰,加古,青叶,衣笠取得2-5BOSS S胜,建议再带2个cav各背1桶至少1瑞云", 233);
            //「空母機動部隊」西へ
            AddQuest(264, "改修資材x2，家具箱(大)x2", "需要2只航母和2只驱逐取得4-2BOSS战S胜,可以带其他船", 221, 239);
            //海上護衛強化月間
            AddQuest(265, "開発資材x5，改修資材x3", "取得1-5 BOSS战A,S胜10次",240,249);
            //「水上反撃部隊」突入せよ
            AddQuest(266, "開発資材x4，改修資材x2", "使用驱逐为旗舰(4只),1只重巡,1只轻巡,取得2-5BOSS战S胜,注意堆索敌",148,264);
            //「第十一駆逐隊」出撃せよ
            AddQuest(267, "給糧艦「間宮」", "使用吹雪,白雪,初雪,从云取得2-3BOSS胜利,可以带其他船", 149);
            //「第十一駆逐隊」対潜哨戒
            AddQuest(268, "開発資材x2，「三式水中探信儀」", "使用吹雪,白雪,初雪,从云与1-5BOSS交战,不能D败",149);
            //「第二一駆逐隊」出撃せよ
            AddQuest(269, "プレゼント箱", "使用初春,子日,若叶,初霜取得3-1BOSS S胜,建议带2cv洗地,dd最好1改喂满",150);
            //「第二二駆逐隊」出撃せよ
            AddQuest(270, "給糧艦「伊良湖」,家具箱(中)x1", "使用皋月,文月,长月和1只驱逐取得1-4BOSS S胜,可以带其他船", 151);
            //「那智戦隊」抜錨せよ
            AddQuest(271, "改修資材x2，家具箱(大)", "使用那智为旗舰,初霜,霞,潮,曙和1只其他舰船取得2-2BOSS S胜", 249, 269);
            //「改装防空重巡」出撃せよ
            AddQuest(272, "「25mm三連装機銃」,「三式弾」", "使用摩耶改/改二,1只轻巡,2只驱逐取得2-3BOSS S胜,可以带其他船",416);
            //新編「三川艦隊」ソロモン方面へ
            AddQuest(273, "開発資材x3，改修資材x3", "使用鸟海改二为旗舰和古鹰,加古,青叶,衣笠,夕张,天龙中的任意5只取得5-1BOSS S胜,祝你好运", 154, 307);
            //「第六駆逐隊」対潜哨戒なのです
            AddQuest(274, "開発資材x3,「九三式水中聴音機」", "使用晓,响,雷,电取得1-5BOSS交战,不能D败",120);
            //抜錨！「第十八戦隊」
            AddQuest(275, "高速修復材x3，特注家具職人", "使用天龙,龙田取得2-3BOSS S胜,可以带其他船", 153);
            //海上突入部隊、進発せよ
            AddQuest(276, "開発資材x5，改修資材x2", "使用比叡,雾岛,长良,晓,雷,电取得5-1BOSS S胜,祝你好运", 154, 243);
            //「第六駆逐隊」対潜哨戒を徹底なのです
            AddQuest(277, "改修資材x2，「九三式水中聴音機」", "使用晓,响,雷,电在1-5BOSS取得S或A胜", 155, 274);
            //「第一水雷戦隊」ケ号作戦、突入せよ
            AddQuest(278, "高速修復剤x3,特注家具職人", "使用阿武隈为旗艦,響,初霜,若葉,五月雨,島風取得3-2BOSS 胜利",156);
            //「第一水雷戦隊」北方ケ号作戦、再突入
            AddQuest(279, "開発資材x4,改修資材x4", "使用阿武隈改二为旗艦,響,夕雲,長波,秋雲,島風取得3-2BOSS S胜",157);
           
            //「空母機動部隊」北方海域に進出せよ
            AddQuest(285, "改修資材x3,戦闘糧食x2", "使用空母旗舰取得3-5BOSS S胜,建议2cv1bb1ca2clt或者3cv1ca2clt 并且选择在磨血阶段做", 260, 226);
            //鎮守府正面の対潜哨戒を強化せよ
            AddQuest(286, "特注家具職人", "取得1-5BOSS A,S胜 4次", 205, 201);
            //287 五航
            //「第五航空戦隊」珊瑚諸島沖に出撃せよ！
            AddQuest(287, "高速修復材x3,給糧艦「伊良湖」", "使用翔鶴,瑞鶴,朧,秋雲以及其他2只舰船取得5-2BOSS战S胜",161);
            //288 21战队
            //新編「第二一戦隊」北方へ出撃せよ！
            AddQuest(288, "戦闘糧食x1,プレゼント箱x1", "使用那智改二,足柄改二,多摩,木曾取得3-1BOSS战S胜,可以带其他船",162);
            //289 16战队
            //「第十六戦隊(第一次)」出撃せよ！
            AddQuest(289, "家具箱中x1,プレゼント箱x1", "使用足柄为旗艦,球磨,長良的舰队取得2-2BOSS战S胜,可以带其他船",163);
            //290秋刀鱼
            //鎮守府正面の対潜哨戒を強化せよ
            AddQuest(290, "特注家具職人", "");
            //「第三航空戦隊」南西諸島防衛線に出撃！
            AddQuest(293, "高速修復材x2,給糧艦「伊良湖」", "用含有旗舰瑞鹤,瑞凤改,千代田航,千岁航的舰队取得1-4 BOSS S胜,可以带其他舰");
            //「小沢艦隊」出撃せよ！
            AddQuest(294, "高速修復材x3,零戦52型丙(六〇一空)", "用旗舰瑞鹤,瑞凤改,千代田航,千岁航,伊势改,日向改的舰队取得2-4BOSS S胜");

            
            //はじめての「演習」
            AddQuest(301, "開発資材x1", "演习1次");
            //大規模演習
            AddQuest(302, "開発資材x2，改修資材x1", "本周取得20次演习胜利", 303);
            //「演習」で練度向上
            AddQuest(303, "高速建造材x1", "演习3次");
            //「演習」で他提督を圧倒せよ
            AddQuest(304, "開発資材x1", "本日取得5次演习胜利", 303);
            
            //
            AddQuest(305, "----------", "");
            //式の準備！(その弐)
            AddQuest(306, "開発資材x1", "本日演习胜利2次",611);
            //艦隊の練度向上に努めよ
            AddQuest(307, "高速修復材x2", "本日取得3次演习胜利",152);
            //演習を強化、艦隊の練度向上に努めよ
            AddQuest(308, "高速修復材x2，改修資材x1", "本日取得4次演习胜利",418);
            //北方再突入に備え、練度向上に努めよ
            AddQuest(309, "高速修復材x2，改修資材x1", "本日取得4次演习胜利",278);
            //精鋭艦隊演習
            AddQuest(311, "高速修復材x2，戦闘糧食x1", "本日取得7次演习胜利");

            //はじめての「遠征」
            AddQuest(401, "家具箱(小)x1", "远征成功1次",105);
            //「遠征」を３回成功させよう
            AddQuest(402, "開発資材x1", "本日远征成功3次");
            //「遠征」を１０回成功させよう
            AddQuest(403, "家具箱(小)x1，家具箱(中)x1", "本日远征成功10次", 402);
            //大規模遠征作戦、発令
            AddQuest(404, "開発資材x3，家具箱(大)x1", "本周远征成功30次");
            //第一次潜水艦派遣作戦
            AddQuest(405, "応急修理要員x1", "取得远征30[潜水艦派遣作戦]成功", 127);
            //第二次潜水艦派遣作戦
            AddQuest(406, "「Ju87C改」", "取得远征30[潜水艦派遣作戦]成功", 405);
            //
            AddQuest(407, "--", "");
            //潜水艦派遣作戦による技術入手の継続
            AddQuest(408, "「Ju87C改」,特注家具職人", "取得远征30[潜水艦派遣作戦]成功 2次", 406);
            //潜水艦派遣による海外艦との接触作戦
            AddQuest(409, "「Z1」", "取得远征31[海外艦との接触]成功",408);
            //南方への輸送作戦を成功させよ
            AddQuest(410, "家具箱(小)x1", "取得远征37,38[东急1,2]成功1次", 130);
            //南方への鼠輸送を継続実施せよ
            AddQuest(411, "開発資材x2，改修資材x1", "取得远征37,38[东急1,2]成功6次", 410);
            //航空火力艦の運用を強化せよ
            AddQuest(412, "「瑞雲(六三四空)」", "取得远征23[航空火力艦の運用の強化]成功1次", 239);
            //(続)航空火力艦の運用を強化せよ
            AddQuest(413, "「瑞雲(六三四空)」", "取得远征23[航空火力艦の運用の強化]成功3次", 412);
            //遠洋潜水艦作戦を実施せよ
            AddQuest(414, "「潜水艦53cm艦首魚雷(8門)」", "取得远征39[遠洋潜水艦作戦]成功1次", 139);
            //遠洋潜水艦作戦の成果を拡大せよ
            AddQuest(415, "「潜水艦53cm艦首魚雷(8門)」", "取得远征39[遠洋潜水艦作戦]成功2次", 414);
            //防空射撃演習を実施せよ
            AddQuest(416, "開発資材x2，「25mm三連装機銃」", "取得远征6[防空射撃演習]成功3次", 207);
            //囮機動部隊支援作戦を実施せよ
            AddQuest(417, "開発資材x2，「91式高射装置」", "取得远征15[囮機動部隊支援作戦]成功1次", 272);
            //観艦式予行を実施せよ
            AddQuest(418, "開発資材x3", "取得远征7[観艦式予行]成功2次", 137);
            //"観艦式を敢行せよ
            AddQuest(419, "改修資材x1，司令部要員", "取得远征8[観艦式]成功1次", 308);
            //機動部隊の運用を強化せよ
            AddQuest(420, "改修資材x2,家具箱(大)x1", "取得远征[MO作戦][敵母港空襲作戦]成功各1次", 410, 282);

            //はじめての「補給」
            AddQuest(501, "高速修復材x1", "补给1次",203);
            //はじめての「入渠」
            AddQuest(502, "開発資材x1", "入渠1次",203);
            //艦隊大整備
            AddQuest(503, "高速修復材x2", "入渠5次");
            //艦隊酒保祭り
            AddQuest(504, "開発資材x1，高速建造材x1", "补给15次",503);

            //はじめての「建造」
            AddQuest(601, "開発資材x1", "建造1只舰娘");
            //はじめての「開発」
            AddQuest(602, "開発資材x1", "开发1次装备");
            //はじめての「解体」
            AddQuest(603, "高速建造材x1，開発資材x1", "解体1次舰娘");
            //はじめての「廃棄」
            AddQuest(604, "高速修復材x1，開発資材x1", "废弃1次装备");
            //新装備「開発」指令
            AddQuest(605, "高速建造材x1，開発資材x1", "开发一次");
            //新造艦「建造」指令
            AddQuest(606, "高速修復材x1，開発資材x1", "建造一次",605);
            //装備「開発」集中強化
            AddQuest(607, "開発資材x2", "本日开发3次",606);
            //艦娘「建造」艦隊強化
            AddQuest(608, "高速建造材x1，開発資材x2", "本日建造3次",607);
            //軍縮条約対応
            AddQuest(609, "高速修復材x1", "本日解体2次",608);
            //「大型艦建造」の準備！(その弐)
            AddQuest(610, "大型艦建造開放", "废弃4次", 704);
            //式の準備！(その壱)
            AddQuest(611, "開発資材x1", "废弃2次",118);
            //輸送用ドラム缶の準備
            AddQuest(612, "「ドラム缶(輸送用)」x3", "废弃3次");
            //資源の再利用
            AddQuest(613, "「ドラム缶(輸送用)」", "废弃24次",228);
            //機種転換
            AddQuest(614, "「天山一二型(友永隊)」", "空母旗舰装备九七式舰攻(友永队),废弃天山x2  注意友永队不能上锁", 250);
            //機種転換
            AddQuest(615, "「彗星(江草隊)」", "空母旗舰装备九九式舰爆(江草队),废弃彗星x2  注意江草队不能上锁", 250);
            //機種転換
            AddQuest(616, "「烈風(六〇一空)」", "空母旗舰装备零战52型丙(六〇一空),废弃烈风x2  注意零战52不能上锁", 253);
            //「伊良湖」の準備
            AddQuest(617, "給糧艦「伊良湖」x4", "废弃10次", 215, 608);
            //はじめての「装備改修」
            AddQuest(618, "改修資材x7", "改修1次装备", 146);
            //装備の改修強化
            AddQuest(619, "改修資材x1", "改修1次装备", 608, 618);
            //
            AddQuest(620, "-----", "");
            //
            AddQuest(621, "-----", "");
            //機種転換
            AddQuest(622, "「天山(村田隊)」", "翔鹤作为秘书舰废弃天山2只,注意97村田不能上锁",287);
            //機種転換
            AddQuest(623, "「九七式艦攻(村田隊)", "翔鹤/赤诚作为秘书舰废弃97舰攻3只", 287);
            //試作艤装の準備
            AddQuest(624, "試製甲板カタパルト", "废弃7个装备", 420);

            //試製航空艤装の追加試作
            AddQuest(625, "試製甲板カタパルト", "废弃9个装备", 420);
            //精鋭「艦戦」隊の新編成
            AddQuest(626, "零式艦戦21型(熟練)", "需要消耗熟練搭乗員!秘书舰凤翔配备满熟练!零戦21型不可上锁,废弃「零戦21型」×2「九六艦戦」×1", 420);
            //機種転換
            AddQuest(627, "零式艦戦52型(熟練)", "秘书舰配备零戦21型(熟練)不可上锁,废弃2只零戦52型", 420);
            //機種転換
            AddQuest(628, "零式艦戦52型(熟練)", "秘书舰配备满熟练!零戦21型(熟練)不可上锁,废弃2只零戦52型", 420);
            //「艦戦」隊の再編成
            AddQuest(629, "零式艦戦52型丙(付岩井小隊)", "秘书舰瑞鹤配备满熟练!零戦52型(熟練)不可上锁,废弃1只零戦52型丙(六〇一空),请仔细检查条件", 420);
            //「艦戦」隊の再編成
            AddQuest(630, "零式艦戦21型(付岩本小隊)", "秘书舰瑞鹤配备满熟练!零戦21型(熟練)不可上锁,废弃2只零戦21型", 420);
            //機種転換＆部隊再編
            AddQuest(631, "零式艦戦62型(爆戦／岩井隊)", "秘书舰瑞鹤配备满熟练!零式艦戦52型丙(付岩井小隊)不可上锁,废弃2只零戦62型(爆戦)", 420);
            //機種転換
            AddQuest(632, "零式艦戦52型甲(付岩本小隊)", "秘书舰瑞鹤配备满熟练!「零戦21型(付岩本小隊)不可上锁,废弃2只零戦52型", 420);
            //機種転換＆部隊再編
            AddQuest(633, "零式艦戦53型(岩本隊)", "秘书舰瑞鹤配备满熟练!零式艦戦52型甲(付岩本小隊)不可上锁,废弃2只彩云", 420);



            //はじめての「近代化改修」
            AddQuest(701, "開発資材x1", "近代化改修1次");
            //艦の「近代化改修」を実施せよ
            AddQuest(702, "高速修復材x1", "本日近代化改修2次");
            //「近代化改修」を進め、戦備を整えよ
            AddQuest(703, "高速建造材x1，開発資材x2", "本日近代化改修15次", 702);
            //「大型艦建造」の準備！(その壱)
            AddQuest(704, "開発資材x1", "近代化改修4次", 109);
        }

        static void AddQuest(int id, string award, string tips, params int[] preconditions)
        {
            QuestInfo qi = new QuestInfo();
            qi.ID = id;
            if (preconditions != null && preconditions.Length > 0)
            {
                qi.Precondition = new List<int>();
                qi.Precondition.AddRange(preconditions);
            }
            qi.Award = award;
            qi.Tips = tips;

            Quests.Add(id, qi);
        }
    }

    public class QuestInfo
    {
        public int ID
        {
            get;
            set;
        }
        public string Tips
        {
            get;
            set;
        }
        public List<int> Precondition
        {
            get;
            set;
        }
        public string Award
        {
            get;
            set;
        }
    }
}
