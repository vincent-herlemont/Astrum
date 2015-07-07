﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astrum.Json.Raid
{
    class RaidInfo
    {
        public RaidBattleInfo find { get; set; }

        public Rescue rescue { get; set; }

        public bool isFullRewards { get; set; }
    }

    class Rescue
    {
        public List<RaidBattleInfo> list { get; set; }
    }

    class RaidBattleInfo
    {
        public string _id { get; set; }
        public string bossId { get; set; }
        public string type { get; set; }

        public string name { get; set; }
        public long level { get; set; }
        public long rare { get; set; }

        public long bpValue { get; set; }
        public long bpMax { get; set; }
        public long combo { get; set; }
        public bool canCombo { get; set; }
        public long hp { get; set; }
        public long totalDamage { get; set; }
        public bool isWin { get; set; }
        public bool isPlaying { get; set; }
        public bool isLose { get; set; }
        public bool isNew { get; set; }
        public long joinNum { get; set; }
    }

    class RaidBattleResultInfo
    {
        public Result result { get; set; }
    }

    public class Result
    {
        public BossInfo afterBoss { get; set; }
        public string resultType { get; set; }
    }

    public class BossInfo
    {
        public int maxHp { get; set; }
        public int hp { get; set; }
        public int atk { get; set; }
    }
}