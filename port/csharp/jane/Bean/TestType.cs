// This file is generated by genbeans tool. Do NOT edit it!
using System;
using System.Text;
using System.Collections.Generic;

namespace Jane.Bean
{
	/**
	 * 测试生成所有支持的类型;
	 */
	[Serializable]
	public struct TestType : IBean, IEquatable<TestType>, IComparable<TestType>
	{
		public const int BEAN_TYPE = 2;

		public  /*  1*/ bool v1; // 1字节布尔,0表示假,1表示真,其它默认表示真;
		public  /*  2*/ sbyte v2; // 1字节整数;
		public  /*  3*/ short v3; // 2字节整数;
		public  /*  4*/ int v4; // 4字节整数;
		public  /*  5*/ long v5; // 8字节整数;
		public  /*  6*/ float v6; // 4字节浮点数;
		public  /*  7*/ double v7; // 8字节浮点数;
		public  /*  8*/ Octets v8; // 二进制数据(Octets);
		public  /*  9*/ string v9; // 字符串(String);
		public  /* 10*/ List<bool> v10; // 数组容器(ArrayList);
		public  /* 11*/ LinkedList<sbyte> v11; // 链表容器(LinkedList);
		public  /* 12*/ LinkedList<int> v12; // 队列容器(ArrayDeque);
		public  /* 13*/ HashSet<long> v13; // 无序集合容器(HashSet);
		public  /* 14*/ HashSet<float> v14; // 排序集合容器(TreeSet);
		public  /* 15*/ HashSet<double> v15; // 有序集合容器(LinkedHashSet);
		public  /* 16*/ Dictionary<long, string> v16; // 无序映射容器(HashMap);
		public  /* 17*/ SortedDictionary<TestBean, bool> v17; // 排序映射容器(TreeMap);
		public  /* 18*/ Dictionary<Octets, TestBean> v18; // 有序映射容器(LinkedHashMap);
		public  /* 19*/ TestBean v19; // 嵌入其它bean;

		public TestType(bool v1, sbyte v2, short v3, int v4, long v5, float v6, double v7, Octets v8, string v9, ICollection<bool> v10, ICollection<sbyte> v11, ICollection<int> v12, ICollection<long> v13, ICollection<float> v14, ICollection<double> v15, IDictionary<long, string> v16, IDictionary<TestBean, bool> v17, IDictionary<Octets, TestBean> v18, TestBean v19)
		{
			this.v1 = v1;
			this.v2 = v2;
			this.v3 = v3;
			this.v4 = v4;
			this.v5 = v5;
			this.v6 = v6;
			this.v7 = v7;
			this.v8 = v8 ?? new Octets();
			this.v9 = v9 ?? string.Empty;
			this.v10 = new List<bool>(10); if(v10 != null) this.v10.AddRange(v10);
			this.v11 = new LinkedList<sbyte>(); if(v11 != null) Util.AddAll(this.v11, v11);
			this.v12 = new LinkedList<int>(); if(v12 != null) Util.AddAll(this.v12, v12);
			this.v13 = new HashSet<long>(); if(v13 != null) this.v13.UnionWith(v13);
			this.v14 = new HashSet<float>(); if(v14 != null) this.v14.UnionWith(v14);
			this.v15 = new HashSet<double>(); if(v15 != null) this.v15.UnionWith(v15);
			this.v16 = new Dictionary<long, string>(0); if(v16 != null) Util.AddAll(this.v16, v16);
			this.v17 = new SortedDictionary<TestBean, bool>(); if(v17 != null) Util.AddAll(this.v17, v17);
			this.v18 = new Dictionary<Octets, TestBean>(); if(v18 != null) Util.AddAll(this.v18, v18);
			this.v19 = TestBean.Create();
		}

		public void Reset()
		{
			v1 = false;
			v2 = 0;
			v3 = 0;
			v4 = 0;
			v5 = 0;
			v6 = 0;
			v7 = 0;
			v8.Clear();
			v9 = string.Empty;
			v10.Clear();
			v11.Clear();
			v12.Clear();
			v13.Clear();
			v14.Clear();
			v15.Clear();
			v16.Clear();
			v17.Clear();
			v18.Clear();
			v19.Reset();
		}

		public void Assign(ref TestType b)
		{
			this.v1 = b.v1;
			this.v2 = b.v2;
			this.v3 = b.v3;
			this.v4 = b.v4;
			this.v5 = b.v5;
			this.v6 = b.v6;
			this.v7 = b.v7;
			if(b.v8 != null) this.v8.Replace(b.v8); else this.v8.Clear();
			this.v9 = b.v9 ?? string.Empty;
			this.v10.Clear(); if(b.v10 != null) this.v10.AddRange(b.v10);
			this.v11.Clear(); if(b.v11 != null) Util.AddAll(this.v11, b.v11);
			this.v12.Clear(); if(b.v12 != null) Util.AddAll(this.v12, b.v12);
			this.v13.Clear(); if(b.v13 != null) this.v13.UnionWith(v13);
			this.v14.Clear(); if(b.v14 != null) this.v14.UnionWith(v14);
			this.v15.Clear(); if(b.v15 != null) this.v15.UnionWith(v15);
			this.v16.Clear(); if(b.v16 != null) Util.AddAll(this.v16, b.v16);
			this.v17.Clear(); if(b.v17 != null) Util.AddAll(this.v17, b.v17);
			this.v18.Clear(); if(b.v18 != null) Util.AddAll(this.v18, b.v18);
			this.v19.Assign(ref b.v19);
		}
/*
		public bool GetV1()
		{
			return v1;
		}

		public void setV1(bool v1)
		{
			this.v1 = v1;
		}

		public sbyte GetV2()
		{
			return v2;
		}

		public void setV2(sbyte v2)
		{
			this.v2 = v2;
		}

		public short GetV3()
		{
			return v3;
		}

		public void setV3(short v3)
		{
			this.v3 = v3;
		}

		public int GetV4()
		{
			return v4;
		}

		public void setV4(int v4)
		{
			this.v4 = v4;
		}

		public long GetV5()
		{
			return v5;
		}

		public void setV5(long v5)
		{
			this.v5 = v5;
		}

		public float GetV6()
		{
			return v6;
		}

		public void setV6(float v6)
		{
			this.v6 = v6;
		}

		public double GetV7()
		{
			return v7;
		}

		public void setV7(double v7)
		{
			this.v7 = v7;
		}

		public Octets GetV8()
		{
			return v8;
		}

		public void setV8(Octets v8)
		{
			this.v8 = v8 ?? new Octets();
		}

		public string GetV9()
		{
			return v9;
		}

		public void setV9(string v9)
		{
			this.v9 = v9 ?? string.Empty;
		}

		public List<bool> GetV10()
		{
			return v10;
		}

		public void setV10(List<bool> v10)
		{
			this.v10 = v10 ?? new Octets();
		}

		public LinkedList<sbyte> GetV11()
		{
			return v11;
		}

		public void setV11(LinkedList<sbyte> v11)
		{
			this.v11 = v11 ?? new Octets();
		}

		public LinkedList<int> GetV12()
		{
			return v12;
		}

		public void setV12(LinkedList<int> v12)
		{
			this.v12 = v12 ?? new Octets();
		}

		public HashSet<long> GetV13()
		{
			return v13;
		}

		public void setV13(HashSet<long> v13)
		{
			this.v13 = v13 ?? new Octets();
		}

		public HashSet<float> GetV14()
		{
			return v14;
		}

		public void setV14(HashSet<float> v14)
		{
			this.v14 = v14 ?? new Octets();
		}

		public HashSet<double> GetV15()
		{
			return v15;
		}

		public void setV15(HashSet<double> v15)
		{
			this.v15 = v15 ?? new Octets();
		}

		public Dictionary<long, string> GetV16()
		{
			return v16;
		}

		public void setV16(Dictionary<long, string> v16)
		{
			this.v16 = v16 ?? new Octets();
		}

		public SortedDictionary<TestBean, bool> GetV17()
		{
			return v17;
		}

		public void setV17(SortedDictionary<TestBean, bool> v17)
		{
			this.v17 = v17 ?? new Octets();
		}

		public Dictionary<Octets, TestBean> GetV18()
		{
			return v18;
		}

		public void setV18(Dictionary<Octets, TestBean> v18)
		{
			this.v18 = v18 ?? new Octets();
		}

		public TestBean GetV19()
		{
			return v19;
		}

		public void setV19(TestBean v19)
		{
			this.v19 = v19 ?? new Octets();
		}
*/
		public int Type()
		{
			return 2;
		}

		public int InitSize()
		{
			return 256;
		}

		public int MaxSize()
		{
			return 65536;
		}

		public void Init()
		{
			v8 = new Octets(5);
			v9 = string.Empty;
			v10 = new List<bool>(10);
			v11 = new LinkedList<sbyte>();
			v12 = new LinkedList<int>();
			v13 = new HashSet<long>();
			v14 = new HashSet<float>();
			v15 = new HashSet<double>();
			v16 = new Dictionary<long, string>(0);
			v17 = new SortedDictionary<TestBean, bool>();
			v18 = new Dictionary<Octets, TestBean>();
			v19 = TestBean.Create();
		}

		public static TestType Create()
		{
			TestType b = new TestType();
			b.Init();
			return b;
		}

		public static IBean CreateIBean()
		{
			IBean b = new TestType();
			b.Init();
			return b;
		}

		public OctetsStream Marshal(OctetsStream s)
		{
			if(this.v1) s.Marshal2(0x0401);
			if(this.v2 != 0) s.Marshal1((byte)0x08).Marshal(this.v2);
			if(this.v3 != 0) s.Marshal1((byte)0x0c).Marshal(this.v3);
			if(this.v4 != 0) s.Marshal1((byte)0x10).Marshal(this.v4);
			if(this.v5 != 0) s.Marshal1((byte)0x14).Marshal(this.v5);
			if(this.v6 != 0) s.Marshal2(0x1b08).Marshal(this.v6);
			if(this.v7 != 0) s.Marshal2(0x1f09).Marshal(this.v7);
			if(!this.v8.Empty()) s.Marshal1((byte)0x21).Marshal(this.v8);
			if(this.v9.Length > 0) s.Marshal1((byte)0x25).Marshal(this.v9);
			if(this.v10 != null && this.v10.Count > 0)
			{
				s.Marshal2(0x2b00).MarshalUInt(this.v10.Count);
				foreach(bool e in Util.Enum(this.v10))
					s.Marshal(e);
			}
			if(this.v11 != null && this.v11.Count > 0)
			{
				s.Marshal2(0x2f00).MarshalUInt(this.v11.Count);
				foreach(sbyte e in Util.Enum(this.v11))
					s.Marshal(e);
			}
			if(this.v12 != null && this.v12.Count > 0)
			{
				s.Marshal2(0x3300).MarshalUInt(this.v12.Count);
				foreach(int e in Util.Enum(this.v12))
					s.Marshal(e);
			}
			if(this.v13 != null && this.v13.Count > 0)
			{
				s.Marshal2(0x3700).MarshalUInt(this.v13.Count);
				foreach(long e in Util.Enum(this.v13))
					s.Marshal(e);
			}
			if(this.v14 != null && this.v14.Count > 0)
			{
				s.Marshal2(0x3b04).MarshalUInt(this.v14.Count);
				foreach(float e in Util.Enum(this.v14))
					s.Marshal(e);
			}
			if(this.v15 != null && this.v15.Count > 0)
			{
				s.Marshal2(0x3f05).MarshalUInt(this.v15.Count);
				foreach(double e in Util.Enum(this.v15))
					s.Marshal(e);
			}
			if(this.v16 != null && this.v16.Count > 0)
			{
				s.Marshal2(0x4341).MarshalUInt(this.v16.Count);
				foreach(KeyValuePair<long, string> p in Util.Enum(this.v16))
					s.Marshal(p.Key).Marshal(p.Value);
			}
			if(this.v17 != null && this.v17.Count > 0)
			{
				s.Marshal2(0x4750).MarshalUInt(this.v17.Count);
				foreach(KeyValuePair<TestBean, bool> p in Util.Enum(this.v17))
					s.Marshal(p.Key).Marshal(p.Value);
			}
			if(this.v18 != null && this.v18.Count > 0)
			{
				s.Marshal2(0x4b4a).MarshalUInt(this.v18.Count);
				foreach(KeyValuePair<Octets, TestBean> p in Util.Enum(this.v18))
					s.Marshal(p.Key).Marshal(p.Value);
			}
			{
				int n = s.Size();
				this.v19.Marshal(s.Marshal1((byte)0x4e));
				if(s.Size() - n < 3) s.Resize(n);
			}
			return s.Marshal1((byte)0);
		}

		public OctetsStream Unmarshal(OctetsStream s)
		{
			Init();
			for(;;) { int i = s.UnmarshalUInt1(), t = i & 3; if(i > 251) i += s.UnmarshalUInt1() << 2; switch(i >> 2)
			{
				case 0: return s;
				case 1: this.v1 = (s.UnmarshalInt(t) != 0); break;
				case 2: this.v2 = (sbyte)s.UnmarshalInt(t); break;
				case 3: this.v3 = (short)s.UnmarshalInt(t); break;
				case 4: this.v4 = s.UnmarshalInt(t); break;
				case 5: this.v5 = s.UnmarshalLong(t); break;
				case 6: this.v6 = s.UnmarshalFloat(t); break;
				case 7: this.v7 = s.UnmarshalDouble(t); break;
				case 8: s.Unmarshal(this.v8, t); break;
				case 9: this.v9 = s.UnmarshalString(t); break;
				case 10:
				{
					this.v10.Clear();
					if(t != 3) { s.UnmarshalSkipVar(t); break; }
					t = s.UnmarshalUInt1();
					if((t >> 3) != 0) { s.UnmarshalSkipVarSub(t); break; }
					t &= 7;
					int n = s.UnmarshalUInt();
					this.v10.Capacity = (n < 0x10000 ? n : 0x10000);
					for(; n > 0; --n)
						this.v10.Add((s.UnmarshalIntKV(t) != 0));
				} break;
				case 11:
				{
					this.v11.Clear();
					if(t != 3) { s.UnmarshalSkipVar(t); break; }
					t = s.UnmarshalUInt1();
					if((t >> 3) != 0) { s.UnmarshalSkipVarSub(t); break; }
					t &= 7;
					for(int n = s.UnmarshalUInt(); n > 0; --n)
						this.v11.AddLast((sbyte)s.UnmarshalIntKV(t));
				} break;
				case 12:
				{
					this.v12.Clear();
					if(t != 3) { s.UnmarshalSkipVar(t); break; }
					t = s.UnmarshalUInt1();
					if((t >> 3) != 0) { s.UnmarshalSkipVarSub(t); break; }
					t &= 7;
					for(int n = s.UnmarshalUInt(); n > 0; --n)
						this.v12.AddLast(s.UnmarshalIntKV(t));
				} break;
				case 13:
				{
					this.v13.Clear();
					if(t != 3) { s.UnmarshalSkipVar(t); break; }
					t = s.UnmarshalUInt1();
					if((t >> 3) != 0) { s.UnmarshalSkipVarSub(t); break; }
					t &= 7;
					for(int n = s.UnmarshalUInt(); n > 0; --n)
						this.v13.Add(s.UnmarshalLongKV(t));
				} break;
				case 14:
				{
					this.v14.Clear();
					if(t != 3) { s.UnmarshalSkipVar(t); break; }
					t = s.UnmarshalUInt1();
					if((t >> 3) != 0) { s.UnmarshalSkipVarSub(t); break; }
					t &= 7;
					for(int n = s.UnmarshalUInt(); n > 0; --n)
						this.v14.Add(s.UnmarshalFloatKV(t));
				} break;
				case 15:
				{
					this.v15.Clear();
					if(t != 3) { s.UnmarshalSkipVar(t); break; }
					t = s.UnmarshalUInt1();
					if((t >> 3) != 0) { s.UnmarshalSkipVarSub(t); break; }
					t &= 7;
					for(int n = s.UnmarshalUInt(); n > 0; --n)
						this.v15.Add(s.UnmarshalDoubleKV(t));
				} break;
				case 16:
				{
					this.v16.Clear();
					if(t != 3) { s.UnmarshalSkipVar(t); break; }
					t = s.UnmarshalUInt1();
					if((t >> 6) != 1) { s.UnmarshalSkipVarSub(t); break; }
					int k = (t >> 3) & 7; t &= 7;
					for(int n = s.UnmarshalUInt(); n > 0; --n)
						this.v16.Add(s.UnmarshalLongKV(k), s.UnmarshalStringKV(t));
				} break;
				case 17:
				{
					this.v17.Clear();
					if(t != 3) { s.UnmarshalSkipVar(t); break; }
					t = s.UnmarshalUInt1();
					if((t >> 6) != 1) { s.UnmarshalSkipVarSub(t); break; }
					int k = (t >> 3) & 7; t &= 7;
					for(int n = s.UnmarshalUInt(); n > 0; --n)
						this.v17.Add((TestBean)s.UnmarshalBeanKV(TestBean.Create(), k), (s.UnmarshalIntKV(t) != 0));
				} break;
				case 18:
				{
					this.v18.Clear();
					if(t != 3) { s.UnmarshalSkipVar(t); break; }
					t = s.UnmarshalUInt1();
					if((t >> 6) != 1) { s.UnmarshalSkipVarSub(t); break; }
					int k = (t >> 3) & 7; t &= 7;
					for(int n = s.UnmarshalUInt(); n > 0; --n)
						this.v18.Add(s.UnmarshalOctetsKV(k), (TestBean)s.UnmarshalBeanKV(TestBean.Create(), t));
				} break;
				case 19: s.UnmarshalBean(ref this.v19, t); break;
				default: s.UnmarshalSkipVar(t); break;
			}}
		}

		public object Clone()
		{
			return new TestType(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19);
		}

		public override int GetHashCode()
		{
			int h = unchecked(2 * (int)0x9e3779b1);
			h = h * 31 + 1 + (int)(this.v1 ? 0xcafebabe : 0xdeadbeef);
			h = h * 31 + 1 + this.v2;
			h = h * 31 + 1 + this.v3;
			h = h * 31 + 1 + this.v4;
			h = h * 31 + 1 + (int)this.v5;
			h = h * 31 + 1 + (int)((BitConverter.DoubleToInt64Bits(this.v6) * 0x100000001L) >> 32);
			h = h * 31 + 1 + (int)((BitConverter.DoubleToInt64Bits(this.v7) * 0x100000001L) >> 32);
			h = h * 31 + 1 + this.v8.GetHashCode();
			h = h * 31 + 1 + this.v9.GetHashCode();
			h = h * 31 + 1 + this.v10.GetHashCode();
			h = h * 31 + 1 + this.v11.GetHashCode();
			h = h * 31 + 1 + this.v12.GetHashCode();
			h = h * 31 + 1 + this.v13.GetHashCode();
			h = h * 31 + 1 + this.v14.GetHashCode();
			h = h * 31 + 1 + this.v15.GetHashCode();
			h = h * 31 + 1 + this.v16.GetHashCode();
			h = h * 31 + 1 + this.v17.GetHashCode();
			h = h * 31 + 1 + this.v18.GetHashCode();
			h = h * 31 + 1 + this.v19.GetHashCode();
			return h;
		}

		public bool Equals(TestType b)
		{
			if(this.v1 != b.v1) return false;
			if(this.v2 != b.v2) return false;
			if(this.v3 != b.v3) return false;
			if(this.v4 != b.v4) return false;
			if(this.v5 != b.v5) return false;
			if(this.v6 != b.v6) return false;
			if(this.v7 != b.v7) return false;
			if(!this.v8.Equals(b.v8)) return false;
			if(!this.v9.Equals(b.v9)) return false;
			if(!this.v10.Equals(b.v10)) return false;
			if(!this.v11.Equals(b.v11)) return false;
			if(!this.v12.Equals(b.v12)) return false;
			if(!this.v13.Equals(b.v13)) return false;
			if(!this.v14.Equals(b.v14)) return false;
			if(!this.v15.Equals(b.v15)) return false;
			if(!this.v16.Equals(b.v16)) return false;
			if(!this.v17.Equals(b.v17)) return false;
			if(!this.v18.Equals(b.v18)) return false;
			if(!this.v19.Equals(b.v19)) return false;
			return true;
		}

		public override bool Equals(object o)
		{
			if(!(o is TestType)) return false;
			TestType b = (TestType)o;
			if(this.v1 != b.v1) return false;
			if(this.v2 != b.v2) return false;
			if(this.v3 != b.v3) return false;
			if(this.v4 != b.v4) return false;
			if(this.v5 != b.v5) return false;
			if(this.v6 != b.v6) return false;
			if(this.v7 != b.v7) return false;
			if(!this.v8.Equals(b.v8)) return false;
			if(!this.v9.Equals(b.v9)) return false;
			if(!this.v10.Equals(b.v10)) return false;
			if(!this.v11.Equals(b.v11)) return false;
			if(!this.v12.Equals(b.v12)) return false;
			if(!this.v13.Equals(b.v13)) return false;
			if(!this.v14.Equals(b.v14)) return false;
			if(!this.v15.Equals(b.v15)) return false;
			if(!this.v16.Equals(b.v16)) return false;
			if(!this.v17.Equals(b.v17)) return false;
			if(!this.v18.Equals(b.v18)) return false;
			if(!this.v19.Equals(b.v19)) return false;
			return true;
		}

		public static bool operator==(TestType a, TestType b)
		{
			return a.Equals(b);
		}

		public static bool operator!=(TestType a, TestType b)
		{
			return !a.Equals(b);
		}

		public int CompareTo(TestType b)
		{
			int c;
			c = (this.v1 == b.v1 ? 0 : (this.v1 ? 1 : -1)); if(c != 0) return c;
			c = this.v2 - b.v2; if(c != 0) return c;
			c = this.v3 - b.v3; if(c != 0) return c;
			c = this.v4 - b.v4; if(c != 0) return c;
			c = Math.Sign(this.v5 - b.v5); if(c != 0) return c;
			c = Math.Sign(this.v6 - b.v6); if(c != 0) return c;
			c = Math.Sign(this.v7 - b.v7); if(c != 0) return c;
			c = this.v8.CompareTo(b.v8); if(c != 0) return c;
			c = this.v9.CompareTo(b.v9); if(c != 0) return c;
			c = Util.CompareTo(this.v10, b.v10); if(c != 0) return c;
			c = Util.CompareTo(this.v11, b.v11); if(c != 0) return c;
			c = Util.CompareTo(this.v12, b.v12); if(c != 0) return c;
			c = Util.CompareTo(this.v13, b.v13); if(c != 0) return c;
			c = Util.CompareTo(this.v14, b.v14); if(c != 0) return c;
			c = Util.CompareTo(this.v15, b.v15); if(c != 0) return c;
			c = Util.CompareTo(this.v16, b.v16); if(c != 0) return c;
			c = Util.CompareTo(this.v17, b.v17); if(c != 0) return c;
			c = Util.CompareTo(this.v18, b.v18); if(c != 0) return c;
			c = this.v19.CompareTo(b.v19); if(c != 0) return c;
			return 0;
		}

		public int CompareTo(IBean b)
		{
			return b is TestType ? CompareTo((TestType)b) : 1;
		}

		public int CompareTo(object b)
		{
			return b is IBean ? CompareTo((IBean)b) : 1;
		}

		public override string ToString()
		{
			StringBuilder s = new StringBuilder(16 + 256 * 2).Append('{');
			s.Append(this.v1).Append(',');
			s.Append(this.v2).Append(',');
			s.Append(this.v3).Append(',');
			s.Append(this.v4).Append(',');
			s.Append(this.v5).Append(',');
			s.Append(this.v6).Append(',');
			s.Append(this.v7).Append(',');
			s.Append(this.v8).Append(',');
			s.Append(this.v9).Append(',');
			Util.Append(s, this.v10);
			Util.Append(s, this.v11);
			Util.Append(s, this.v12);
			Util.Append(s, this.v13);
			Util.Append(s, this.v14);
			Util.Append(s, this.v15);
			Util.Append(s, this.v16);
			Util.Append(s, this.v17);
			Util.Append(s, this.v18);
			s.Append(this.v19).Append(',');
			--s.Length;
			return s.Append('}').ToString();
		}
#if TO_JSON_LUA
		public StringBuilder ToJson(StringBuilder s)
		{
			if(s == null) s = new StringBuilder(1024);
			s.Append('{');
			s.Append("\"v1\":").Append(this.v1).Append(',');
			s.Append("\"v2\":").Append(this.v2).Append(',');
			s.Append("\"v3\":").Append(this.v3).Append(',');
			s.Append("\"v4\":").Append(this.v4).Append(',');
			s.Append("\"v5\":").Append(this.v5).Append(',');
			s.Append("\"v6\":").Append(this.v6).Append(',');
			s.Append("\"v7\":").Append(this.v7).Append(',');
			this.v8.DumpJStr(s.Append("\"v8\":")).Append(',');
			Util.ToJStr(s.Append("\"v9\":"), this.v9).Append(',');
			Util.AppendJson(s.Append("\"v10\":"), this.v10);
			Util.AppendJson(s.Append("\"v11\":"), this.v11);
			Util.AppendJson(s.Append("\"v12\":"), this.v12);
			Util.AppendJson(s.Append("\"v13\":"), this.v13);
			Util.AppendJson(s.Append("\"v14\":"), this.v14);
			Util.AppendJson(s.Append("\"v15\":"), this.v15);
			Util.AppendJson(s.Append("\"v16\":"), this.v16);
			Util.AppendJson(s.Append("\"v17\":"), this.v17);
			Util.AppendJson(s.Append("\"v18\":"), this.v18);
			this.v19.ToJson(s.Append("\"v19\":")).Append(',');
			--s.Length;
			return s.Append('}');
		}

		public StringBuilder ToJson()
		{
			return ToJson(null);
		}

		public StringBuilder ToLua(StringBuilder s)
		{
			if(s == null) s = new StringBuilder(1024);
			s.Append('{');
			s.Append("v1=").Append(this.v1).Append(',');
			s.Append("v2=").Append(this.v2).Append(',');
			s.Append("v3=").Append(this.v3).Append(',');
			s.Append("v4=").Append(this.v4).Append(',');
			s.Append("v5=").Append(this.v5).Append(',');
			s.Append("v6=").Append(this.v6).Append(',');
			s.Append("v7=").Append(this.v7).Append(',');
			this.v8.DumpJStr(s.Append("v8=")).Append(',');
			Util.ToJStr(s.Append("v9="), this.v9).Append(',');
			Util.AppendLua(s.Append("v10="), this.v10);
			Util.AppendLua(s.Append("v11="), this.v11);
			Util.AppendLua(s.Append("v12="), this.v12);
			Util.AppendLua(s.Append("v13="), this.v13);
			Util.AppendLua(s.Append("v14="), this.v14);
			Util.AppendLua(s.Append("v15="), this.v15);
			Util.AppendLua(s.Append("v16="), this.v16);
			Util.AppendLua(s.Append("v17="), this.v17);
			Util.AppendLua(s.Append("v18="), this.v18);
			this.v19.ToLua(s.Append("v19=")).Append(',');
			--s.Length;
			return s.Append('}');
		}

		public StringBuilder ToLua()
		{
			return ToLua(null);
		}
#endif
	}
}
