using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class Data : MonoBehaviour
{
    public static string[] song_list = {"Free", "Sang-Sa-Hwa", "Hedwig's Theme" };
    public static float[] speed = { 0f, 1f, 2f }; //곡마다 올가미 줄어드는 속도!
    public static int[] bpms = { 105, 107, 158, 0 };
    public static double[] songDelays = { 0, -13.4, -3.5 };
    public static double[] snareDelays={0,2d,2d};
    public static int[] hit_terms = { 0, 88199, 44099 };
    public static double[] note_terms={4,40000,20000};
    public static int[][] answers = new[]
    {
        new[] {0,0,0,0,0,0,0,0},//sync
        new[] {7, 14, 12, 14, 12, 14, 12, 14, 7, 14, 12, 14, 7, 5, 7},//상사화
        new[] {5, 5, 10, 7, 5, 4, 12, 16, 5, 5, 15, 13, 13, 11, 5, 16, 12, 12, 13, 11, 8, 11, 12, 16, 12, 12, 15, 13, 11, 5}//해리포터
    };
    public static double[][] answers_tsample = new[]{
        new[] {0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0},//sync
        new[] {665301.6, 739938.3, 812614.6, 885683.0, 959379.3, 1033702.6, 1107477.3, 1179056.6, 1252909.3, 1327154.3, 1400694.0, 1473840.3, 1548006.6, 1618645.0, 1694066.0},//상사화
        new[] {117520.6, 162208.6, 214187.3, 266010,316264, 360638.6, 412304.3, 462402,512499.6,561059.3, 611832.3, 662870.6, 711243.3, 758205.3,809714, 859576.3, 909438.6, 959536.6, 1007909.3, 1058085.3,1108104.6,1155814.3, 1208142.6,1257574, 1307005.3, 1355299.3, 1405554,1505043.60,1552318.6, 1603671}//해리포터
    };
    public static int[] best_scores = { 0, 0, 0};
    public static int[] max_scores = { 0, 150, 270 };

    public static bool[] acquired_stone= { true, false, true, false, false, false };
    public static bool[] acquired_frame = { true, false, true, false, false, false };
    public static bool[] acquired_stick = { true, false, true, false, false, false };
    public static bool[] acquired_info = { false, false, false, false};

    public static int[] reward_index = { 0,0,0,0};//인덱스 순서는 곡 순서와 동일
    public static int[] reward_type = {-1,3,1,2};//0 frame, 1 stone, 2 stick, 3 info

    public static int selected_song=1, user_lev, user_ex, dic_lev, volume;
    public static double usersyncDelay;
    public static int stone = 0;
    public static int frame = 0;
    public static int stick = 0;

    public static float[] volumes = {0.5f, 0.5f, 0.5f}; // 편경, 배경음악, 버튼 볼륨
    public static double hit_tsample;
    public static List<List<UserRank>> userList = new List<List<UserRank>>();
    List<UserRank> sortedList = new List<UserRank>();

    
}
