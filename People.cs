﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyAllTestDemo
{
    public class People
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int ContionCount { get; set; }
        public object fdg { get; set; }
        public bool Marray { get; set; }
    }
    public class PeopleChild : People
    {
        public int Height { get; set; }
        public int StudentNo { get; set; }
    }

    public class PeopleGraner
    {
        public People People { get; set; }
        public string RoomName { get; set; }
        public int RoomNo { get; set; }
    }
    public class FocusTagValue23
    {
        public string Tag { get; set; }
        public double[][] Value { get; set; }
		public int IndexNo{get;set;}
    }

    public class VarList
    {
        public string Code { get; set; }
        public List<string> Address { get; set; }
    }
	//基于某一个tag的修改
	public class TagCurrent
	{
		public string CurrentCode { get; set; }
        public List<string> CurrentValue { get; set; }
	}
}
