// This file is generated by genbeans tool. Do NOT edit it! @formatter:off
package jane.bean;

import jane.core.Bean;
import jane.core.MarshalException;
import jane.core.OctetsStream;
import jane.core.UndoContext;

/**
 * 测试空bean
 */
public class TestEmpty extends Bean<TestEmpty> implements Comparable<TestEmpty>
{
	private static final long serialVersionUID = 0xbeac245da40b43f8L;
	public  static final int BEAN_TYPE = 4;
	public  static final TestEmpty BEAN_STUB = new TestEmpty();

	@Override
	public void reset()
	{
	}

	/** @param b unused */
	public void assign(TestEmpty b)
	{
	}

	@Override
	public int type()
	{
		return 4;
	}

	@Override
	public int initSize()
	{
		return 0;
	}

	@Override
	public int maxSize()
	{
		return 0;
	}

	@Override
	public TestEmpty stub()
	{
		return BEAN_STUB;
	}

	@Override
	public TestEmpty create()
	{
		return new TestEmpty();
	}

	@Override
	public OctetsStream marshal(OctetsStream s)
	{
		return s.marshal1((byte)0);
	}

	@Override
	public OctetsStream unmarshal(OctetsStream s) throws MarshalException
	{
		for(;;) { int i = s.unmarshalByte() & 0xff, t = i & 3; switch(i >> 2)
		{
			case 0: return s;
			default: s.unmarshalSkipVar(t);
		}}
	}

	@Override
	public TestEmpty clone()
	{
		return new TestEmpty();
	}

	@Override
	public int hashCode()
	{
		int h = 4 * 0x9e3779b1;
		return h;
	}

	@Override
	public boolean equals(Object o)
	{
		if(o == this) return true;
		if(!(o instanceof TestEmpty)) return false;
		return true;
	}

	@Override
	public int compareTo(TestEmpty b)
	{
		if(b == this) return 0;
		if(b == null) return 1;
		return 0;
	}

	@Override
	public String toString()
	{
		StringBuilder s = new StringBuilder(16 + 0 * 2).append('{');
		return s.append('}').toString();
	}

	@Override
	public StringBuilder toJson(StringBuilder s)
	{
		if(s == null) s = new StringBuilder(1024);
		s.append('{');
		return s.append('}');
	}

	@Override
	public StringBuilder toLua(StringBuilder s)
	{
		if(s == null) s = new StringBuilder(1024);
		s.append('{');
		return s.append('}');
	}

	@Override
	public Safe safe(UndoContext.Safe<?> parent)
	{
		return new Safe(parent);
	}

	public final class Safe implements UndoContext.Safe<TestEmpty>, Comparable<TestEmpty>
	{
		private transient final UndoContext.Safe<?> _owner;
		private transient UndoContext _undoctx;
		private transient boolean _dirty;
		private transient boolean _fullundo;

		private Safe(UndoContext.Safe<?> parent)
		{
			_owner = (parent != null ? parent.owner() : this);
		}

		@Override
		public TestEmpty unsafe()
		{
			return TestEmpty.this;
		}

		@Override
		public UndoContext.Safe<?> owner()
		{
			return _owner;
		}

		@Override
		public boolean isDirtyAndClear()
		{
			boolean r = _dirty;
			_dirty = false;
			return r;
		}

		@Override
		public void dirty()
		{
			if(_owner == this)
				_dirty = true;
			else
				_owner.dirty();
		}

		private void initUndoContext()
		{
			if(!_fullundo && _undoctx == null)
			{
				_owner.dirty();
				_undoctx = UndoContext.current();
			}
		}

		private void addFullUndo()
		{
			initUndoContext();
			if(_undoctx == null) return;
			_undoctx.add(new UndoContext.Undo()
			{
				private final TestEmpty _saved = TestEmpty.this.clone();
				@Override
				public void rollback() throws Exception
				{
					TestEmpty.this.assign(_saved);
				}
			});
			_undoctx = null;
			_fullundo = true;
		}

		public void reset()
		{
			addFullUndo();
			TestEmpty.this.reset();
		}

		public void assign(TestEmpty b)
		{
			addFullUndo();
			TestEmpty.this.assign(b);
		}

		public OctetsStream marshal(OctetsStream s)
		{
			return TestEmpty.this.marshal(s);
		}

		public OctetsStream unmarshal(OctetsStream s) throws MarshalException
		{
			addFullUndo();
			return TestEmpty.this.unmarshal(s);
		}

		@Override
		public TestEmpty clone()
		{
			return TestEmpty.this.clone();
		}

		@Override
		public int hashCode()
		{
			return TestEmpty.this.hashCode();
		}

		@Override
		public boolean equals(Object o)
		{
			return TestEmpty.this.equals(o);
		}

		@Override
		public int compareTo(TestEmpty b)
		{
			return TestEmpty.this.compareTo(b);
		}

		@Override
		public String toString()
		{
			return TestEmpty.this.toString();
		}

		public StringBuilder toJson(StringBuilder s)
		{
			return TestEmpty.this.toJson(s);
		}

		public StringBuilder toLua(StringBuilder s)
		{
			return TestEmpty.this.toLua(s);
		}
	}
}
