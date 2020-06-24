using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gongju {
    class TaskInfo {
        public string TaskId;
        public string Type;
        public string Starttype;
        public string Mapid;
        public string LuaTaskType;
        public string NpcGroup;
        public string MonsterGroup;
        public string Effect;
        public string Marktype;

        public string Name;
        public string Intention;


        public string Tablename = "TaskInfo.csv";
        public string TablenameChinese = "13$TaskInfo.csv";


        public TaskInfo(string Name,string Intention,string TaskId,string Type, string Starttype, string Mapid, string LuaTaskType, string NpcGroup, string Effect, string Marktype) {
            this.Name = Name;
            this.Intention = Intention;
            this.TaskId = TaskId;
            this.Type = Type;
            this.Starttype = Starttype;
            this.Mapid = Mapid;
            this.LuaTaskType = LuaTaskType;
            this.NpcGroup = NpcGroup;
            this.Effect = Effect;
            this.Marktype = Marktype;
        }

    }
}
